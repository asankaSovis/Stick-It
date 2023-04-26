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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton;
using ComponentFactory.Krypton.Toolkit;

namespace Sticky_Notes
{
    public partial class frmControls : KryptonForm
    {
        // Parent of the form
        frmMain myParent = null;

        public frmControls(frmMain _myParent)
        {
            InitializeComponent();

            myParent = _myParent;
            this.Text = _myParent.Text;
            this.Icon = _myParent.Icon;
        }

        // ///////////////////////////////////////////////////////////////
        // Event handlers

        private void btnBold_Click(object sender, EventArgs e)
        {
            // If bold button is clicked, we bold the selected text
            myParent.stylizeText("**");
        }

        private void kplItalic_Click(object sender, EventArgs e)
        {
            // If italic button is clicked, italicize the selected text
            myParent.stylizeText("*");
        }
    }
}
