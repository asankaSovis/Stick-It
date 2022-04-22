
namespace Sticky_Notes
{
    partial class frmControls
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBold = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kplButton = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kplItalic = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnBold, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kplItalic, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 43);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnBold
            // 
            this.btnBold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBold.Location = new System.Drawing.Point(3, 3);
            this.btnBold.Name = "btnBold";
            this.btnBold.Palette = this.kplButton;
            this.btnBold.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnBold.Size = new System.Drawing.Size(147, 37);
            this.btnBold.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBold.TabIndex = 0;
            this.btnBold.Values.Text = "Bold";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // kplButton
            // 
            this.kplButton.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.kplButton.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kplButton.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kplButton.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 3;
            this.kplButton.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kplButton.ButtonStyles.ButtonCommon.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            // 
            // kplItalic
            // 
            this.kplItalic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kplItalic.Location = new System.Drawing.Point(156, 3);
            this.kplItalic.MaximumSize = new System.Drawing.Size(148, 37);
            this.kplItalic.MinimumSize = new System.Drawing.Size(148, 37);
            this.kplItalic.Name = "kplItalic";
            this.kplItalic.Palette = this.kplButton;
            this.kplItalic.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kplItalic.Size = new System.Drawing.Size(148, 37);
            this.kplItalic.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kplItalic.TabIndex = 1;
            this.kplItalic.Values.Text = "Italic";
            this.kplItalic.Click += new System.EventHandler(this.kplItalic_Click);
            // 
            // frmControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(307, 43);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(307, 43);
            this.MinimumSize = new System.Drawing.Size(307, 43);
            this.Name = "frmControls";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBold;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kplButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kplItalic;
    }
}