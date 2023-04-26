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

    This form is use to stylize the selected text of the RTB
    in the main form

---------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton;
using ComponentFactory.Krypton.Toolkit;

namespace Sticky_Notes
{
    public partial class frmAbout : KryptonForm
    {
        // Parent form
        frmMain parent = null;

        public frmAbout(frmMain _parent)
        {
            InitializeComponent();

            parent = _parent;
            this.Text = parent.about["title"];
            this.Icon = parent.Icon;

            lblTitle.Text = parent.about["title"];
            lblCopyright.Text = parent.about["copyright"];
            txtDescription.Text = parent.about["description"];
            lblVersion.Text = parent.about["version-long"] + " (Licensed under the " + parent.about["license"] + ")";

            loadColours(); // Loads the palette

            if (File.Exists("LICENSE"))
            {
                StreamReader reader = new StreamReader("LICENSE");
                txtLicense.Text = reader.ReadToEnd();
            }
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            pcbAbout.Image = Image.FromFile("assets/Stick It!.png");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkProject_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(parent.about["link"]);
        }

        /// <summary>
        /// Loads the palette of the interface
        /// </summary>
        /// <returns>Error as int</returns>

        private void loadColours()
        {
            // Button palette
            kplButton.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = parent.palette[2];
            kplButton.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = parent.palette[1];
            kplButton.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = parent.palette[5];
            kplButton.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = parent.palette[2];

            // Common group
            kplGroup.ControlStyles.ControlGroupBox.StateCommon.Border.Color1 = parent.palette[2];
            kplGroup.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = parent.palette[2];

            // Form palette
            kplForm.FormStyles.FormCommon.StateCommon.Back.Color1 = kplForm.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = parent.palette[6];
            kplForm.ButtonStyles.ButtonForm.StateCommon.Back.Color1 = parent.palette[7];

            // Panel
            kplPanel.Common.StateCommon.Back.Color1 = parent.palette[6];
        }
    }
}
