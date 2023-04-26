namespace Sticky_Notes
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAbout = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lnkProject = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.btnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kplButton = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kplPanel = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.tlpAbout = new System.Windows.Forms.TableLayoutPanel();
            this.pcbAbout = new System.Windows.Forms.PictureBox();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblCopyright = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblVersion = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblTitle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtDescription = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.lblPlaceholder = new System.Windows.Forms.Label();
            this.tabLicense = new System.Windows.Forms.TabPage();
            this.txtLicense = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kplGroup = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kplForm = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAbout)).BeginInit();
            this.pnlAbout.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.tlpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAbout)).BeginInit();
            this.tlpTitle.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlAbout, 0, 1);
            this.tlpMain.Controls.Add(this.tabMain, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(591, 244);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlAbout
            // 
            this.pnlAbout.Controls.Add(this.lnkProject);
            this.pnlAbout.Controls.Add(this.btnOk);
            this.pnlAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAbout.Location = new System.Drawing.Point(0, 209);
            this.pnlAbout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pnlAbout.Palette = this.kplPanel;
            this.pnlAbout.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.pnlAbout.Size = new System.Drawing.Size(591, 35);
            this.pnlAbout.TabIndex = 0;
            // 
            // lnkProject
            // 
            this.lnkProject.Location = new System.Drawing.Point(12, 11);
            this.lnkProject.Name = "lnkProject";
            this.lnkProject.Size = new System.Drawing.Size(89, 20);
            this.lnkProject.TabIndex = 1;
            this.lnkProject.TabStop = false;
            this.lnkProject.Values.Text = "Github Project";
            this.lnkProject.LinkClicked += new System.EventHandler(this.lnkProject_LinkClicked);
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOk.Location = new System.Drawing.Point(459, 5);
            this.btnOk.Margin = new System.Windows.Forms.Padding(5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Palette = this.kplButton;
            this.btnOk.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnOk.Size = new System.Drawing.Size(132, 30);
            this.btnOk.TabIndex = 0;
            this.btnOk.TabStop = false;
            this.btnOk.Values.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
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
            // kplPanel
            // 
            this.kplPanel.Common.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabAbout);
            this.tabMain.Controls.Add(this.tabSettings);
            this.tabMain.Controls.Add(this.tabLicense);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(3, 3);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(585, 203);
            this.tabMain.TabIndex = 4;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.tlpAbout);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(577, 177);
            this.tabAbout.TabIndex = 1;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // tlpAbout
            // 
            this.tlpAbout.ColumnCount = 2;
            this.tlpAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tlpAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAbout.Controls.Add(this.pcbAbout, 0, 0);
            this.tlpAbout.Controls.Add(this.tlpTitle, 1, 0);
            this.tlpAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAbout.Location = new System.Drawing.Point(3, 3);
            this.tlpAbout.Name = "tlpAbout";
            this.tlpAbout.RowCount = 1;
            this.tlpAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tlpAbout.Size = new System.Drawing.Size(571, 171);
            this.tlpAbout.TabIndex = 1;
            // 
            // pcbAbout
            // 
            this.pcbAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbAbout.Location = new System.Drawing.Point(10, 10);
            this.pcbAbout.Margin = new System.Windows.Forms.Padding(10);
            this.pcbAbout.Name = "pcbAbout";
            this.pcbAbout.Size = new System.Drawing.Size(126, 151);
            this.pcbAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAbout.TabIndex = 0;
            this.pcbAbout.TabStop = false;
            // 
            // tlpTitle
            // 
            this.tlpTitle.ColumnCount = 1;
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTitle.Controls.Add(this.lblCopyright, 0, 3);
            this.tlpTitle.Controls.Add(this.lblVersion, 0, 2);
            this.tlpTitle.Controls.Add(this.lblTitle, 0, 0);
            this.tlpTitle.Controls.Add(this.txtDescription, 0, 1);
            this.tlpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitle.Location = new System.Drawing.Point(149, 3);
            this.tlpTitle.Name = "tlpTitle";
            this.tlpTitle.RowCount = 4;
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpTitle.Size = new System.Drawing.Size(419, 165);
            this.tlpTitle.TabIndex = 1;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = false;
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyright.Location = new System.Drawing.Point(3, 147);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(413, 15);
            this.lblCopyright.StateNormal.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Values.Text = "copyright";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = false;
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.lblVersion.Location = new System.Drawing.Point(3, 127);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(413, 14);
            this.lblVersion.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Values.Text = "version";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lblTitle.Location = new System.Drawing.Point(3, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(413, 29);
            this.lblTitle.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Values.Text = "title";
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(3, 38);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(413, 83);
            this.txtDescription.StateCommon.Back.Color1 = System.Drawing.SystemColors.InactiveBorder;
            this.txtDescription.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtDescription.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.txtDescription.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDescription.StateNormal.Back.Color1 = System.Drawing.SystemColors.Control;
            this.txtDescription.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "description";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.lblPlaceholder);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(577, 177);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlaceholder.AutoSize = true;
            this.lblPlaceholder.Location = new System.Drawing.Point(264, 72);
            this.lblPlaceholder.Name = "lblPlaceholder";
            this.lblPlaceholder.Size = new System.Drawing.Size(62, 13);
            this.lblPlaceholder.TabIndex = 0;
            this.lblPlaceholder.Text = "No Settings";
            // 
            // tabLicense
            // 
            this.tabLicense.Controls.Add(this.txtLicense);
            this.tabLicense.Location = new System.Drawing.Point(4, 22);
            this.tabLicense.Name = "tabLicense";
            this.tabLicense.Size = new System.Drawing.Size(577, 177);
            this.tabLicense.TabIndex = 2;
            this.tabLicense.Text = "License";
            this.tabLicense.UseVisualStyleBackColor = true;
            // 
            // txtLicense
            // 
            this.txtLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLicense.Location = new System.Drawing.Point(0, 0);
            this.txtLicense.Multiline = true;
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.ReadOnly = true;
            this.txtLicense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLicense.Size = new System.Drawing.Size(577, 177);
            this.txtLicense.StateCommon.Back.Color1 = System.Drawing.SystemColors.InactiveBorder;
            this.txtLicense.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtLicense.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.txtLicense.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLicense.StateNormal.Back.Color1 = System.Drawing.SystemColors.Control;
            this.txtLicense.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicense.TabIndex = 5;
            // 
            // kplGroup
            // 
            this.kplGroup.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kplGroup.ControlStyles.ControlGroupBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kplGroup.ControlStyles.ControlGroupBox.StateCommon.Border.Width = 1;
            this.kplGroup.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // kplForm
            // 
            this.kplForm.FormStyles.FormCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kplForm.HeaderStyles.HeaderCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 244);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.Palette = this.kplForm;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlAbout)).EndInit();
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.tlpAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAbout)).EndInit();
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitle.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabLicense.ResumeLayout(false);
            this.tabLicense.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlAbout;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOk;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kplButton;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kplGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kplForm;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kplPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkProject;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.TableLayoutPanel tlpAbout;
        private System.Windows.Forms.PictureBox pcbAbout;
        private System.Windows.Forms.TableLayoutPanel tlpTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCopyright;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblVersion;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDescription;
        private System.Windows.Forms.TabPage tabLicense;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLicense;
        private System.Windows.Forms.Label lblPlaceholder;
    }
}