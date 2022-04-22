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

    This is the notes form. Everytime a note needs to be pinned
    we load this

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

namespace Sticky_Notes
{
    public partial class frmNote : Form
    {

        Point lastPosition; // Last position of the form

        frmMain parent = null; // Parent of the form

        public frmNote(frmMain _parent, string _myNote, Color _myColour)
        {
            InitializeComponent();

            webMain.DocumentText = _myNote;
            this.BackColor = _myColour;
            parent = _parent;
            this.Text = parent.Text;
            this.Icon = parent.Icon;

            lastPosition = Cursor.Position;

            loadColours(); // Load colour palette
        }

        // /////////////////////////////////////////////////////////////
        // Event handlers

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close this form
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            // Pin this form to the top
            this.TopMost = !this.TopMost;
        }

        private void lblMove_MouseMove(object sender, MouseEventArgs e)
        {
            // If the mouse is moved while pressing the left mouse button,
            // we move the note around
            if (e.Button == MouseButtons.Left)
            {
                int[] mouseOffset =
                {
                     Cursor.Position.X - this.Location.X,

                };

                this.Location = new Point(
                    this.Location.X + Cursor.Position.X - lastPosition.X,
                    this.Location.Y + Cursor.Position.Y - lastPosition.Y
                );
            }

            lastPosition = Cursor.Position;
        }

        private void splMain_MouseEnter(object sender, EventArgs e)
        {
            // If mouse come close to the trigger splitter, we open the panel
            spcMain.Panel1Collapsed = false;
        }

        private void lblMove_MouseLeave(object sender, EventArgs e)
        {
            // If the mouse leave the panel, we hide it again
            spcMain.Panel1Collapsed = true;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            // If the mouse leave the panel, we hide it again
            spcMain.Panel1Collapsed = true;
        }

        private void btnPin_MouseLeave(object sender, EventArgs e)
        {
            // If the mouse leave the panel, we hide it again
            spcMain.Panel1Collapsed = true;
        }

        private void lblDrag_MouseMove(object sender, MouseEventArgs e)
        {
            // Resizes the note when dragged from the bottom right
            if (e.Button == MouseButtons.Left)
            {
                this.Size = new Size(
                    Cursor.Position.X - this.Location.X,
                    Cursor.Position.Y - this.Location.Y
                    );
            }
        }

        // /////////////////////////////////////////////////////////////////
        // Functions

        /// <summary>
        /// Loads the colour palette for the form
        /// </summary>
        /// <returns>Error as int</returns>

        private int loadColours()
        {
            // Button palette
            kplButton.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = parent.palette[2];
            kplButton.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = parent.palette[1];
            kplButton.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = parent.palette[5];
            kplButton.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = parent.palette[2];

            // Special palette for close button
            kplButton.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = parent.palette[4];

            return 0;
        }
    }
}
