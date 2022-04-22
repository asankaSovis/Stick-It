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

---------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sticky_Notes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
