/*---------------------------------------------------------

                Stick It - Basic Note Taking App
                        v1.0.0 Alpha
    Stick it is a basic note taking app that is fully opensource.
    Written in Visual C#, this application is intended to be used
            for day today, small note-taking purposes.
    
    Author: Asanka Sovis
    Start Date: 20/04/2022
    Public Release: 22/04/2022
    Last Edit: 22/04/2022

    This is the main form. It handles all the work.

---------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton;
using ComponentFactory.Krypton.Toolkit;
using MarkdownSharp;
using Newtonsoft.Json;

namespace Sticky_Notes
{
    public partial class frmMain : KryptonForm
    {
        // This is the primary colour palette to be used for the interface
        public Color[] palette =
        {
            Color.FromArgb(225, 44, 55, 64),     // Primary Colour
            Color.FromArgb(255, 40, 89, 75),     // Secondary 01 Colour
            Color.FromArgb(255, 41, 115, 80),    // Secondary 02 Colour
            Color.FromArgb(255, 242, 182, 160),  // Complementary Colour
            Color.FromArgb(255, 242, 242, 242),  // Neutral Colour

            Color.FromArgb(255, 41, 115, 90),    // Secondary 01 Light
            Color.FromArgb(255, 200, 200, 200),  // Grey
            Color.FromArgb(255, 170, 185, 170),  // Secondary 02 Light

            Color.FromArgb(255, 152, 102, 100),  // Complementary Light
        };

        // Colour palettes for note backgrounds
        // NOTE: Not implemented yet
        Color[] noteBackgrounds =
        {
            Color.FromArgb(255, 255, 235, 165), // Yellow
            Color.FromArgb(255, 255, 179, 126), // Orange
            Color.FromArgb(255, 232, 117, 140), // Red
            Color.FromArgb(190, 166, 217, 166), // Green
            Color.FromArgb(170, 98, 195, 222),  // Blue
        };

        // Strings that are used as text throughout the application
        // NOTE: Needs properly implementing
        public string[] defaultStrings =
        {
            // Message for no notes available
            "                     No notes to show\nTry making a new one using the plus button",
            // Message for no note selected
            "            No notes selected\nPlease select a note to preview"
        };

        // Default location of the notes
        string defaultLocation = Environment.CurrentDirectory + @"\notes\";
        // Note template to be used for a new note
        string noteTemplate = "#My Note\n";

        // Metadata of notes loaded
        List<Tuple<DateTime, string, Color>> noteMetadata = new List<Tuple<DateTime, string, Color>>();
        // Cache of edited notes
        Dictionary<int, string> cache = new Dictionary<int, string>();

        // The controls form that shows controls for selected text
        frmControls controls = null;

        public frmMain()
        {
            InitializeComponent();

            loadColours(); // Loads the form palette at startup
        }

        // ///////////////////////////////////////////////////////
        // Event handlers

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadAssets(); // Loads the assets for the form
            loadNotes(); // Loads the note metadata

            controls = new frmControls(this); // Initialize the form control
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // When the new button is clicked, we make a new note
            newNote();
        }

        private void lsbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When the selected index is changed, we load the relevant note
            loadNote();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // If we're on view mode of a note, we switch to edit mode,
            // or else we save the note and switch to preview mode.
            if (spcNote.Panel1Collapsed)
            {
                editNote();
            }
            else
            {
                saveNote();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // If delete button is clicked, we first show a warning.
            // If the user select yes, we delete the note. Otherwise
            // we do nothing
            frmWarning warning = new frmWarning(this, "Are you sure you want to delete this note?");
            warning.ShowDialog();

            if (warning.selection == 1)
            {
                deleteNote();
            }

            warning.Dispose();
        }

        private void btnStick_Click(object sender, EventArgs e)
        {
            // Sticks the note to the screen
            stickNote();
        }

        private void rtbMain_KeyDown(object sender, KeyEventArgs e)
        {
            // If a user presses a key while pressing the CTRL key,
            // we perform an action according to the key pressed.
            if (e.Control)
            {
                if (e.KeyCode == Keys.S)
                {
                    // Save note
                    btnEdit.PerformClick();
                }
                else if (e.KeyCode == Keys.D)
                {
                    // Show command panel
                    controls.Show(this);
                    controls.Location = MousePosition;
                }
                else if (e.KeyCode == Keys.B)
                {
                    // Makes the selected text bold
                    stylizeText("**");
                }
                else if (e.KeyCode == Keys.I)
                {
                    // Makes the selected text italic
                    e.SuppressKeyPress = true;
                    stylizeText("*");
                }
            }
        }

        private void rtbMain_SelectionChanged(object sender, EventArgs e)
        {
            // If we change the selection, we hide the command panel
            controls.Visible = false;
        }

        private void rtbMain_Leave(object sender, EventArgs e)
        {
            // If we leave the rich text box, if there is a selection in the
            // notes list, we cache the text, add an indicator to the notes
            // panel and switch to edit mode
            if (lsbMain.SelectedIndex > -1)
            {
                cache[lsbMain.SelectedIndex] = rtbMain.Text;

                editNote();
            }
        }

        // ////////////////////////////////////////////////////////
        // Functions

        /// <summary>
        /// Function to create a new note
        /// </summary>
        /// <returns>Error as int</returns>

        private int newNote()
        {
            // We first add the metadata of that note
            noteMetadata.Add(new Tuple<DateTime, string, Color>(DateTime.Now, noteTemplate.Substring(0, noteTemplate.IndexOf("\n")).Replace("#", ""), noteBackgrounds[0]));
            // Add a cache note
            cache.Add(lsbMain.Items.Count, noteTemplate);

            // Then we refresh the list and select the new note
            // and switch to the edit mode
            refreshList();
            lsbMain.SelectedIndex = lsbMain.Items.Count - 1;
            btnEdit.PerformClick();

            return 0;
        }

        /// <summary>
        /// Loads the list of notes from the hard disk
        /// NOTE: Only the metadata is stored in RAM to save memory
        /// </summary>
        /// <returns>Error as int</returns>

        private int loadNotes()
        {
            noteMetadata.Clear(); // Clear the metadata

            // Load all the files in the folder with ".txt" extension
            // NOTE: Might change later
            string[] files = System.IO.Directory.GetFiles(defaultLocation, "*.txt");

            // For each of the notes we go through them and add the metadata to the
            // metadata variable
            foreach (var item in files)
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(item);

                // Extracting metadata
                string jsonData = reader.ReadLine();
                List<string> metadata = JsonConvert.DeserializeObject<List<string>>(jsonData);
                Color noteColor = Color.FromArgb(int.Parse(metadata[0]), int.Parse(metadata[1]), int.Parse(metadata[2]), int.Parse(metadata[3]));

                // Reading title
                string title = reader.ReadLine();

                // Applying metadata
                noteMetadata.Add(new Tuple<DateTime, string, Color>(
                    DateTime.Parse(item.Replace(".txt", "").Replace(defaultLocation, "").Replace("-", "/").Replace("+", ":")),
                    title.Replace("#", ""),
                    noteColor)
                );

                reader.Dispose();
            }

            // Refresh the list
            refreshList();

            return 0;
        }

        /// <summary>
        /// Refreshes the list of notes
        /// </summary>
        /// <returns>Error as integer</returns>

        private int refreshList()
        {
            // Loading all notes to the list
            lsbMain.Items.Clear();
            foreach (var item in noteMetadata)
            {
                lsbMain.Items.Add(item.Item2);
            }

            // Showing message if list is empty
            lblPreviewMessage.Visible = (lsbMain.Items.Count == 0);
            lblPreviewMessage.Text = defaultStrings[0];

            // Disable control buttons
            btnEdit.Enabled = btnDelete.Enabled = btnStick.Enabled = (lsbMain.Items.Count == 0);

            // If the list is not empty, we select the first item
            // otherwise we empty the RTB and add back colour to
            // the note
            if (lsbMain.Items.Count > 0)
            {
                lsbMain.SelectedIndex = 0;
            }
            else
            {
                rtbMain.Text = "";
                webNote.DocumentText = "<body style='background - color:" + HexConverter(palette[4]) + "; '>";
                showNote();
            }

            return 0;
        }

        /// <summary>
        /// Loads a note that was selected
        /// </summary>
        /// <returns>Error as int</returns>

        private int loadNote()
        {
            // Show no note selected message if no note is selected
            lblPreviewMessage.Visible = (lsbMain.SelectedIndex == -1);
            lblPreviewMessage.Text = defaultStrings[1];

            // If there is a selection we display the note,
            // otherwise we show that there are no notes
            if (lsbMain.SelectedIndex > -1)
            {
                Markdown markdown = new Markdown();

                // Set the group heading to the name of the note
                grpMain.Values.Heading = lsbMain.SelectedItem.ToString();

                // If note is in cache, then we load it, otherwise
                // we load it from disk
                if (cache.Keys.Contains(lsbMain.SelectedIndex))
                {
                    rtbMain.Text = cache[lsbMain.SelectedIndex];
                    webNote.DocumentText = "<body style='background - color:" + HexConverter(noteMetadata[lsbMain.SelectedIndex].Item3) + "; '>" + markdown.Transform(cache[lsbMain.SelectedIndex]);
                }
                else
                {
                    System.IO.StreamReader reader = new System.IO.StreamReader(defaultLocation + noteMetadata[lsbMain.SelectedIndex].Item1.ToString().Replace("/", "-").Replace(":", "+") + ".txt");
                    reader.ReadLine();
                    string body = reader.ReadToEnd();
                    reader.Dispose();

                    rtbMain.Text = body;
                    webNote.DocumentText = "<body style='background - color:" + HexConverter(noteMetadata[lsbMain.SelectedIndex].Item3) + "; '>" + markdown.Transform(body);
                }

                // Show display panel
                showNote();
            }
            else
            {
                rtbMain.Text = "";
                webNote.DocumentText = "<body style='background - color:" + HexConverter(palette[4]) + "; '>";
                grpMain.Values.Heading = "No Notes";
            }

            return 0;
        }

        /// <summary>
        /// Shows the note preview by displaying the note
        /// and hiding the RTB
        /// </summary>

        private void showNote()
        {
            spcNote.Panel2Collapsed = false;
            spcNote.Panel1Collapsed = true;
            btnEdit.Text = "E";
        }

        /// <summary>
        /// Switch to editing mode by hiding the preview
        /// and showing RTB
        /// </summary>

        private void editNote()
        {
            lsbMain.Items[lsbMain.SelectedIndex] = "* " + noteMetadata[lsbMain.SelectedIndex].Item2;

            spcNote.Panel2Collapsed = true;
            spcNote.Panel1Collapsed = false;
            btnEdit.Text = "S";
        }

        /// <summary>
        /// Saves a note
        /// </summary>
        /// <returns>Error as int</returns>

        private int saveNote()
        {
            int selected = lsbMain.SelectedIndex;

            // Store metadata to JSON
            Color noteColour = noteMetadata[selected].Item3;
            List<string> jsonData = new List<string>();
            jsonData.Add(noteColour.A.ToString());
            jsonData.Add(noteColour.R.ToString());
            jsonData.Add(noteColour.G.ToString());
            jsonData.Add(noteColour.B.ToString());

            string json = JsonConvert.SerializeObject(jsonData);

            // Write metadata and note to file
            System.IO.StreamWriter writer = new System.IO.StreamWriter(defaultLocation + noteMetadata[lsbMain.SelectedIndex].Item1.ToString().Replace("/", "-").Replace(":", "+") + ".txt", false);
            writer.WriteLine(json);
            writer.Write(rtbMain.Text);
            writer.Flush();
            writer.Close();
            writer.Dispose();

            // Remove unsaved indicator from list and remove from
            // cache
            noteMetadata[selected] = new Tuple<DateTime, string, Color>(noteMetadata[selected].Item1, rtbMain.Text.Replace("#", "").Substring(0, rtbMain.Text.IndexOf("\n")), noteMetadata[selected].Item3);
            lsbMain.Items[selected] = noteMetadata[selected].Item2;

            if (cache.Keys.Contains(lsbMain.SelectedIndex))
            {
                cache.Remove(lsbMain.SelectedIndex);
            }

            // Display the note
            showNote();

            return 0;
        }

        /// <summary>
        /// Deletes a selected note
        /// </summary>
        /// <returns>Error as int</returns>

        private int deleteNote()
        {
            // Deletes the note and cache
            System.IO.File.Delete(defaultLocation + noteMetadata[lsbMain.SelectedIndex].Item1.ToString().Replace("/", "-").Replace(":", "+") + ".txt");
            if (cache.Keys.Contains(lsbMain.SelectedIndex))
            {
                cache.Remove(lsbMain.SelectedIndex);
            }

            // Reload the notes list
            loadNotes();

            return 0;
        }

        /// <summary>
        /// Sticks a note to the screen
        /// </summary>
        /// <returns>Error as int</returns>

        private int stickNote()
        {
            // Create a note form and pin it to the screen
            frmNote myNote = new frmNote(this, webNote.DocumentText, noteMetadata[lsbMain.SelectedIndex].Item3);
            myNote.Show();

            return 0;
        }

        /// <summary>
        /// Adds a style to the selected text from markdown
        /// </summary>
        /// <param name="characters">Characters to wrap the text by</param>

        public void stylizeText(string characters)
        {
            // If text is selected, we proceed
            if (rtbMain.SelectionLength > 0)
            {
                int[] cursorLocation = { rtbMain.SelectionStart, rtbMain.SelectionLength };

                // If the wrapping is already there at the end, we remove it.
                // Otherwise we add it
                if (rtbMain.Text.Substring(cursorLocation[0] + cursorLocation[1] - characters.Length).Replace("\n", "") == characters)
                {
                    rtbMain.Text = rtbMain.Text.Remove(cursorLocation[0] + cursorLocation[1] - characters.Length);
                }
                else
                {
                    rtbMain.Text = rtbMain.Text.Insert(cursorLocation[0] + cursorLocation[1], characters);
                }

                // If the wrapping is already there at the front, we remove it.
                // Otherwise we add it
                if (rtbMain.Text.Substring(cursorLocation[0], characters.Length) == characters)
                {
                    rtbMain.Text = rtbMain.Text.Remove(cursorLocation[0], characters.Length);
                }
                else
                {
                    rtbMain.Text = rtbMain.Text.Insert(cursorLocation[0], characters);
                }

                rtbMain.Select(cursorLocation[0], 0);
            }
        }

        /// <summary>
        /// Loads the palette of the interface
        /// </summary>
        /// <returns>Error as int</returns>

        private int loadColours()
        {
            // Button palette
            kplButton.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = palette[2];
            kplButton.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = palette[1];
            kplButton.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = palette[5];
            kplButton.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = palette[2];
            kplButton.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = palette[4];

            // Overrides for special delete button
            btnDelete.StateCommon.Back.Color1 = palette[3];
            btnDelete.StateCommon.Border.Color1 = palette[8];

            // Listbox overrides
            lsbMain.StateCheckedNormal.Item.Back.Color1 = lsbMain.StateCheckedPressed.Item.Back.Color1 = palette[2];
            lsbMain.StateTracking.Item.Back.Color1 = lsbMain.StateCheckedTracking.Item.Back.Color1 = palette[5];

            // General list
            kplList.Common.StateCommon.Back.Color1 = kplGroup.ControlStyles.ControlGroupBox.StateCommon.Back.Color1 = palette[4];

            // Common group
            kplGroup.ControlStyles.ControlGroupBox.StateCommon.Border.Color1 = palette[2];
            kplGroup.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = palette[2];

            // Common form
            kplForm.FormStyles.FormCommon.StateCommon.Back.Color1 = kplForm.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = palette[6];
            kplForm.ButtonStyles.ButtonForm.StateCommon.Back.Color1 = palette[7];

            return 0;
        }

        /// <summary>
        /// Loads the assets of the application
        /// </summary>
        /// <returns>Error as Err</returns>

        private int loadAssets()
        {
            this.Text = "Stick Up - Notes";
            this.Icon = new Icon(Environment.CurrentDirectory + "/assets/icon.ico");

            return 0;
        }

        /// <summary>
        /// Converts RGB colours to hex
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>

        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
    }
}
