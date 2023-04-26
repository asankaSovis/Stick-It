
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarning));
            this.kplForm = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kplButton = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.spl2 = new System.Windows.Forms.Splitter();
            this.btnButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.spl1 = new System.Windows.Forms.Splitter();
            this.btnButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kplPanel = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kplForm
            // 
            this.kplForm.FormStyles.FormCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kplForm.HeaderStyles.HeaderCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            // 
            // kplButton
            // 
            this.kplButton.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kplButton.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kplButton.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kplButton.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 1;
            this.kplButton.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kplButton.ButtonStyles.ButtonCommon.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 110);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblMessage, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pcbIcon, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 69);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessage.Location = new System.Drawing.Point(83, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(314, 69);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbIcon
            // 
            this.pcbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbIcon.Location = new System.Drawing.Point(10, 10);
            this.pcbIcon.Margin = new System.Windows.Forms.Padding(10);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(60, 49);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIcon.TabIndex = 1;
            this.pcbIcon.TabStop = false;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnButton3);
            this.kryptonPanel1.Controls.Add(this.spl2);
            this.kryptonPanel1.Controls.Add(this.btnButton2);
            this.kryptonPanel1.Controls.Add(this.spl1);
            this.kryptonPanel1.Controls.Add(this.btnButton1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 75);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.kryptonPanel1.Palette = this.kplPanel;
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonPanel1.Size = new System.Drawing.Size(406, 35);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btnButton3
            // 
            this.btnButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnButton3.Location = new System.Drawing.Point(68, 5);
            this.btnButton3.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnButton3.Name = "btnButton3";
            this.btnButton3.Palette = this.kplButton;
            this.btnButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnButton3.Size = new System.Drawing.Size(106, 30);
            this.btnButton3.TabIndex = 6;
            this.btnButton3.TabStop = false;
            this.btnButton3.Values.Text = "Button 3";
            this.btnButton3.Click += new System.EventHandler(this.btnButton2_Click);
            // 
            // spl2
            // 
            this.spl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.spl2.Location = new System.Drawing.Point(174, 5);
            this.spl2.Name = "spl2";
            this.spl2.Size = new System.Drawing.Size(10, 30);
            this.spl2.TabIndex = 5;
            this.spl2.TabStop = false;
            // 
            // btnButton2
            // 
            this.btnButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnButton2.Location = new System.Drawing.Point(184, 5);
            this.btnButton2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnButton2.Name = "btnButton2";
            this.btnButton2.Palette = this.kplButton;
            this.btnButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnButton2.Size = new System.Drawing.Size(106, 30);
            this.btnButton2.TabIndex = 4;
            this.btnButton2.TabStop = false;
            this.btnButton2.Values.Text = "Button 2";
            this.btnButton2.Click += new System.EventHandler(this.btnButton2_Click);
            // 
            // spl1
            // 
            this.spl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.spl1.Location = new System.Drawing.Point(290, 5);
            this.spl1.Name = "spl1";
            this.spl1.Size = new System.Drawing.Size(10, 30);
            this.spl1.TabIndex = 3;
            this.spl1.TabStop = false;
            // 
            // btnButton1
            // 
            this.btnButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnButton1.Location = new System.Drawing.Point(300, 5);
            this.btnButton1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnButton1.Name = "btnButton1";
            this.btnButton1.Palette = this.kplButton;
            this.btnButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnButton1.Size = new System.Drawing.Size(106, 30);
            this.btnButton1.TabIndex = 0;
            this.btnButton1.TabStop = false;
            this.btnButton1.Values.Text = "Button 1";
            this.btnButton1.Click += new System.EventHandler(this.btnButton1_Click);
            // 
            // kplPanel
            // 
            this.kplPanel.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kplPanel.Common.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            // 
            // frmWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 110);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWarning";
            this.Palette = this.kplForm;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Warning";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kplForm;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kplButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pcbIcon;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kplPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnButton3;
        private System.Windows.Forms.Splitter spl2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnButton2;
        private System.Windows.Forms.Splitter spl1;
    }
}