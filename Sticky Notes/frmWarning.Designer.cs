
namespace Sticky_Notes
{
    partial class frmWarning
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
            this.kplForm = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kplButton = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // kplForm
            // 
            this.kplForm.FormStyles.FormCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kplForm.HeaderStyles.HeaderCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            // 
            // kplButton
            // 
            this.kplButton.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kplButton.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kplButton.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kplButton.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 3;
            this.kplButton.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kplButton.ButtonStyles.ButtonCommon.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tlpMain, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pcbIcon, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 107);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tlpControls, 0, 1);
            this.tlpMain.Controls.Add(this.lblMessage, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(109, 3);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpMain.Size = new System.Drawing.Size(446, 101);
            this.tlpMain.TabIndex = 1;
            // 
            // tlpControls
            // 
            this.tlpControls.ColumnCount = 4;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tlpControls.Controls.Add(this.btnButton2, 2, 0);
            this.tlpControls.Controls.Add(this.btnButton1, 3, 0);
            this.tlpControls.Controls.Add(this.btnButton3, 1, 0);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(3, 61);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 1;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.Size = new System.Drawing.Size(440, 37);
            this.tlpControls.TabIndex = 1;
            // 
            // btnButton2
            // 
            this.btnButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnButton2.Location = new System.Drawing.Point(219, 3);
            this.btnButton2.Name = "btnButton2";
            this.btnButton2.Palette = this.kplButton;
            this.btnButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnButton2.Size = new System.Drawing.Size(106, 31);
            this.btnButton2.TabIndex = 0;
            this.btnButton2.Values.Text = "Button2";
            this.btnButton2.Click += new System.EventHandler(this.btnButton2_Click);
            // 
            // btnButton1
            // 
            this.btnButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnButton1.Location = new System.Drawing.Point(331, 3);
            this.btnButton1.Name = "btnButton1";
            this.btnButton1.Palette = this.kplButton;
            this.btnButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnButton1.Size = new System.Drawing.Size(106, 31);
            this.btnButton1.TabIndex = 1;
            this.btnButton1.Values.Text = "Button1";
            this.btnButton1.Click += new System.EventHandler(this.btnButton1_Click);
            // 
            // btnButton3
            // 
            this.btnButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnButton3.Location = new System.Drawing.Point(107, 3);
            this.btnButton3.Name = "btnButton3";
            this.btnButton3.Palette = this.kplButton;
            this.btnButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnButton3.Size = new System.Drawing.Size(106, 31);
            this.btnButton3.TabIndex = 2;
            this.btnButton3.Values.Text = "Button3";
            this.btnButton3.Click += new System.EventHandler(this.btnButton3_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(3, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(440, 58);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbIcon
            // 
            this.pcbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbIcon.Location = new System.Drawing.Point(3, 3);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(100, 101);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIcon.TabIndex = 0;
            this.pcbIcon.TabStop = false;
            // 
            // frmWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 107);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(576, 152);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(576, 152);
            this.Name = "frmWarning";
            this.Palette = this.kplForm;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kplForm;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kplButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnButton1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pcbIcon;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnButton3;
    }
}