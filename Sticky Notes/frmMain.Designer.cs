
namespace Sticky_Notes
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpMain = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kplGroup = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.tlpNote = new System.Windows.Forms.TableLayoutPanel();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnStick = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kplButton = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.spcNote = new System.Windows.Forms.SplitContainer();
            this.rtbMain = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.lblPreviewMessage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.webNote = new System.Windows.Forms.WebBrowser();
            this.grpList = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnInfo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNew = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lsbMain = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kplList = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kplMessage = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kplEditedItem = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kplForm = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain.Panel)).BeginInit();
            this.grpMain.Panel.SuspendLayout();
            this.grpMain.SuspendLayout();
            this.tlpNote.SuspendLayout();
            this.tlpControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcNote)).BeginInit();
            this.spcNote.Panel1.SuspendLayout();
            this.spcNote.Panel2.SuspendLayout();
            this.spcNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpList.Panel)).BeginInit();
            this.grpList.Panel.SuspendLayout();
            this.grpList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpMain.Controls.Add(this.grpMain, 1, 0);
            this.tlpMain.Controls.Add(this.grpList, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(766, 481);
            this.tlpMain.TabIndex = 0;
            // 
            // grpMain
            // 
            this.grpMain.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.grpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMain.Location = new System.Drawing.Point(308, 2);
            this.grpMain.Margin = new System.Windows.Forms.Padding(2);
            this.grpMain.Name = "grpMain";
            this.grpMain.Palette = this.kplGroup;
            this.grpMain.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            // 
            // grpMain.Panel
            // 
            this.grpMain.Panel.Controls.Add(this.tlpNote);
            this.grpMain.Size = new System.Drawing.Size(456, 477);
            this.grpMain.TabIndex = 1;
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
            // tlpNote
            // 
            this.tlpNote.ColumnCount = 1;
            this.tlpNote.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNote.Controls.Add(this.tlpControls, 0, 1);
            this.tlpNote.Controls.Add(this.spcNote, 0, 0);
            this.tlpNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNote.Location = new System.Drawing.Point(0, 0);
            this.tlpNote.Margin = new System.Windows.Forms.Padding(2);
            this.tlpNote.Name = "tlpNote";
            this.tlpNote.RowCount = 2;
            this.tlpNote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpNote.Size = new System.Drawing.Size(452, 457);
            this.tlpNote.TabIndex = 0;
            // 
            // tlpControls
            // 
            this.tlpControls.ColumnCount = 4;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpControls.Controls.Add(this.btnStick, 0, 0);
            this.tlpControls.Controls.Add(this.btnEdit, 0, 0);
            this.tlpControls.Controls.Add(this.btnDelete, 3, 0);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(2, 422);
            this.tlpControls.Margin = new System.Windows.Forms.Padding(2);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 1;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.Size = new System.Drawing.Size(448, 33);
            this.tlpControls.TabIndex = 1;
            // 
            // btnStick
            // 
            this.btnStick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStick.Location = new System.Drawing.Point(35, 2);
            this.btnStick.Margin = new System.Windows.Forms.Padding(2);
            this.btnStick.Name = "btnStick";
            this.btnStick.Palette = this.kplButton;
            this.btnStick.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnStick.Size = new System.Drawing.Size(29, 29);
            this.btnStick.TabIndex = 0;
            this.btnStick.TabStop = false;
            this.btnStick.Values.Text = "";
            this.btnStick.Click += new System.EventHandler(this.btnStick_Click);
            // 
            // kplButton
            // 
            this.kplButton.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.kplButton.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kplButton.ButtonStyles.ButtonCommon.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.kplButton.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kplButton.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 1;
            this.kplButton.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kplButton.ButtonStyles.ButtonCommon.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Location = new System.Drawing.Point(2, 2);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Palette = this.kplButton;
            this.btnEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnEdit.Size = new System.Drawing.Size(29, 29);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.TabStop = false;
            this.btnEdit.Values.Text = "";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(417, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Palette = this.kplButton;
            this.btnDelete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnDelete.Size = new System.Drawing.Size(29, 29);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.TabStop = false;
            this.btnDelete.Values.Text = "";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // spcNote
            // 
            this.spcNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcNote.Location = new System.Drawing.Point(2, 2);
            this.spcNote.Margin = new System.Windows.Forms.Padding(2);
            this.spcNote.Name = "spcNote";
            // 
            // spcNote.Panel1
            // 
            this.spcNote.Panel1.Controls.Add(this.rtbMain);
            // 
            // spcNote.Panel2
            // 
            this.spcNote.Panel2.Controls.Add(this.lblPreviewMessage);
            this.spcNote.Panel2.Controls.Add(this.webNote);
            this.spcNote.Size = new System.Drawing.Size(448, 416);
            this.spcNote.SplitterDistance = 148;
            this.spcNote.SplitterWidth = 3;
            this.spcNote.TabIndex = 2;
            // 
            // rtbMain
            // 
            this.rtbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMain.Location = new System.Drawing.Point(0, 0);
            this.rtbMain.Margin = new System.Windows.Forms.Padding(2);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.Palette = this.kplButton;
            this.rtbMain.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.rtbMain.Size = new System.Drawing.Size(148, 416);
            this.rtbMain.TabIndex = 1;
            this.rtbMain.Text = "";
            this.rtbMain.SelectionChanged += new System.EventHandler(this.rtbMain_SelectionChanged);
            this.rtbMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbMain_KeyDown);
            this.rtbMain.Leave += new System.EventHandler(this.rtbMain_Leave);
            // 
            // lblPreviewMessage
            // 
            this.lblPreviewMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreviewMessage.AutoSize = false;
            this.lblPreviewMessage.Location = new System.Drawing.Point(53, 115);
            this.lblPreviewMessage.Margin = new System.Windows.Forms.Padding(2);
            this.lblPreviewMessage.Name = "lblPreviewMessage";
            this.lblPreviewMessage.Size = new System.Drawing.Size(186, 201);
            this.lblPreviewMessage.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblPreviewMessage.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblPreviewMessage.TabIndex = 1;
            this.lblPreviewMessage.Values.Text = "";
            // 
            // webNote
            // 
            this.webNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webNote.Location = new System.Drawing.Point(0, 0);
            this.webNote.Margin = new System.Windows.Forms.Padding(2);
            this.webNote.MinimumSize = new System.Drawing.Size(15, 16);
            this.webNote.Name = "webNote";
            this.webNote.Size = new System.Drawing.Size(297, 416);
            this.webNote.TabIndex = 0;
            // 
            // grpList
            // 
            this.grpList.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.Location = new System.Drawing.Point(2, 2);
            this.grpList.Margin = new System.Windows.Forms.Padding(2);
            this.grpList.Name = "grpList";
            this.grpList.Palette = this.kplGroup;
            this.grpList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            // 
            // grpList.Panel
            // 
            this.grpList.Panel.Controls.Add(this.btnInfo);
            this.grpList.Panel.Controls.Add(this.btnNew);
            this.grpList.Panel.Controls.Add(this.lsbMain);
            this.grpList.Size = new System.Drawing.Size(302, 477);
            this.grpList.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.grpList.TabIndex = 2;
            this.grpList.Values.Heading = "My Notes";
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInfo.Location = new System.Drawing.Point(7, 420);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Palette = this.kplButton;
            this.btnInfo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnInfo.Size = new System.Drawing.Size(29, 29);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.TabStop = false;
            this.btnInfo.Values.Text = "";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Location = new System.Drawing.Point(246, 404);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Palette = this.kplButton;
            this.btnNew.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnNew.Size = new System.Drawing.Size(45, 45);
            this.btnNew.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNew.StateCommon.Border.Rounding = 30;
            this.btnNew.TabIndex = 0;
            this.btnNew.TabStop = false;
            this.btnNew.Values.Text = "";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lsbMain
            // 
            this.lsbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbMain.Location = new System.Drawing.Point(0, 0);
            this.lsbMain.Margin = new System.Windows.Forms.Padding(2);
            this.lsbMain.Name = "lsbMain";
            this.lsbMain.Palette = this.kplList;
            this.lsbMain.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lsbMain.Size = new System.Drawing.Size(298, 457);
            this.lsbMain.StateCheckedNormal.Item.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.lsbMain.StateCheckedNormal.Item.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.lsbMain.StateCheckedNormal.Item.Border.Rounding = 2;
            this.lsbMain.StateCheckedNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.lsbMain.StateCheckedPressed.Item.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.lsbMain.StateCheckedPressed.Item.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.lsbMain.StateCheckedPressed.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.lsbMain.StateCheckedTracking.Item.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.lsbMain.StateCheckedTracking.Item.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.lsbMain.StateCheckedTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.lsbMain.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.lsbMain.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.lsbMain.StateTracking.Item.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.lsbMain.StateTracking.Item.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.lsbMain.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.lsbMain.TabIndex = 3;
            this.lsbMain.SelectedIndexChanged += new System.EventHandler(this.lsbMain_SelectedIndexChanged);
            // 
            // kplList
            // 
            this.kplList.BasePalette = this.kplGroup;
            this.kplList.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kplList.Common.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.kplList.Common.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            // 
            // kplEditedItem
            // 
            this.kplEditedItem.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            // 
            // kplForm
            // 
            this.kplForm.FormStyles.FormCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kplForm.HeaderStyles.HeaderCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 481);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(616, 405);
            this.Name = "frmMain";
            this.Palette = this.kplForm;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Stick It";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMain.Panel)).EndInit();
            this.grpMain.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).EndInit();
            this.grpMain.ResumeLayout(false);
            this.tlpNote.ResumeLayout(false);
            this.tlpControls.ResumeLayout(false);
            this.spcNote.Panel1.ResumeLayout(false);
            this.spcNote.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcNote)).EndInit();
            this.spcNote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpList.Panel)).EndInit();
            this.grpList.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpList)).EndInit();
            this.grpList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kplButton;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpMain;
        private System.Windows.Forms.TableLayoutPanel tlpNote;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kplGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kplList;
        private System.Windows.Forms.SplitContainer spcNote;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtbMain;
        private System.Windows.Forms.WebBrowser webNote;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPreviewMessage;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kplMessage;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kplEditedItem;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kplForm;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStick;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpList;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNew;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lsbMain;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInfo;
    }
}

