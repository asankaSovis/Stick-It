/*---------------------------------------------------------

                Stick It! - Basic Note Taking App
                        v1.0.0 Alpha
    Stick it is a basic note taking app that is fully opensource.
    Written in Visual C#, this application is intended to be used
            for day today, small note-taking purposes.
    
    Author: Asanka Sovis
    Start Date: 20/04/2022
    Public Release: 26/04/2023
    Last Edit: 26/04/2023

    This form displays a message to the user with Yes
    or No options

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
    public partial class frmWarning : KryptonForm
    {
        // Types of messages
        public static class MessageTypes
        {
            public static int WarningMessage = 0;
            public static int ErrorMessage = 1;
            public static int InformationMessage = 2;
            public static int QuestionMessage = 3;
            public static int WarningSelection = 4;
            public static int ErrorSelection = 5;
            public static int WarningSelectionWithRetry = 8;
            public static int ErrorSelectionWithRetry = 9;
        }

        // Types of buttons
        public static class Buttons
        {
            public static int Ok = 0;
            public static int No = 0;
            public static int Exit = 0;
            public static int Yes = 1;
            public static int Cancel = 2;
            public static int Retry = 2;

        }

        // Image assets
        Image[] icons =
        {
            Image.FromFile(Environment.CurrentDirectory + "/assets/warning.png"),
            Image.FromFile(Environment.CurrentDirectory + "/assets/error.png"),
            Image.FromFile(Environment.CurrentDirectory + "/assets/information.png"),
            Image.FromFile(Environment.CurrentDirectory + "/assets/question.png"),
        };

        // Which button the user clicked
        public int selection = 0;

        // Parent form
        frmMain parent = null;

        public frmWarning(frmMain _parent, string _message, int _messageType = 0)
        {
            InitializeComponent();

            lblMessage.Text = _message;
            pcbIcon.Image = icons[_messageType % 4];
            loadButtons(_messageType);
            parent = _parent;

            this.Text = parent.about["title"];
            this.Icon = parent.Icon;

            loadColours(); // Loads the palette
        }

        // ///////////////////////////////////////////////////////
        // Event handlers

        private void btnButton1_Click(object sender, EventArgs e)
        {
            // If Button 1 is clicked, we select accordingly
            this.Close();
        }

        private void btnButton2_Click(object sender, EventArgs e)
        {
            // If Button 2 is clicked, we select 1 and close
            selection = 1;
            this.Close();
        }

        private void btnButton3_Click(object sender, EventArgs e)
        {
            // If Button 3 is clicked, we select 2 and close
            selection = 2;
            this.Close();
        }

        // /////////////////////////////////////////////////////
        // Functions

        /// <summary>
        /// Loads the palette of the form
        /// </summary>

        private void loadColours()
        {
            // Button palette
            kplButton.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = parent.palette[2];
            kplButton.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = parent.palette[1];
            kplButton.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = parent.palette[5];
            kplButton.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = parent.palette[2];

            // Form palette
            kplForm.FormStyles.FormCommon.StateCommon.Back.Color1 = kplForm.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = parent.palette[6];
            kplForm.ButtonStyles.ButtonForm.StateCommon.Back.Color1 = parent.palette[7];

            // Panel
            kplPanel.Common.StateCommon.Back.Color1 = parent.palette[6];
            spl1.BackColor = spl2.BackColor = parent.palette[6];
        }

        /// <summary>
        /// Loads the buttons of the form
        /// </summary>
        /// <param name="messageType">Type of the message</param>

        private void loadButtons(int messageType)
        {
            btnButton2.Visible = (messageType > 3);
            btnButton3.Visible = (messageType > 7);

            if (messageType == MessageTypes.ErrorMessage)
            {
                btnButton1.Text = "Exit";
            }
            if (messageType < 4)
            {
                btnButton1.Text = "Ok";
            } else
            {
                btnButton1.Text = "No";
                btnButton2.Text = "Yes";
            }
            if (messageType == 8)
            {
                btnButton3.Text = "Retry";
            }
            if (messageType == 9)
            {
                btnButton3.Text = "Abort";
            }
        }
    }
}
