
namespace Sticky_Notes
{
    partial class frmNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNote));
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kplButton = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnPin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblMove = new System.Windows.Forms.Label();
            this.lblDrag = new System.Windows.Forms.Label();
            this.lblHide = new System.Windows.Forms.Label();
            this.splMain = new System.Windows.Forms.Splitter();
            this.webMain = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            this.tlpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcMain
            // 
            this.spcMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.IsSplitterFixed = true;
            this.spcMain.Location = new System.Drawing.Point(0, 0);
            this.spcMain.Margin = new System.Windows.Forms.Padding(0);
            this.spcMain.Name = "spcMain";
            this.spcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.tlpControls);
            this.spcMain.Panel1Collapsed = true;
            this.spcMain.Panel1MinSize = 30;
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.lblDrag);
            this.spcMain.Panel2.Controls.Add(this.lblHide);
            this.spcMain.Panel2.Controls.Add(this.splMain);
            this.spcMain.Panel2.Controls.Add(this.webMain);
            this.spcMain.Panel2MinSize = 30;
            this.spcMain.Size = new System.Drawing.Size(332, 321);
            this.spcMain.SplitterDistance = 30;
            this.spcMain.SplitterWidth = 1;
            this.spcMain.TabIndex = 0;
            // 
            // tlpControls
            // 
            this.tlpControls.ColumnCount = 3;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpControls.Controls.Add(this.btnClose, 2, 0);
            this.tlpControls.Controls.Add(this.btnPin, 0, 0);
            this.tlpControls.Controls.Add(this.lblMove, 1, 0);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(0, 0);
            this.tlpControls.Margin = new System.Windows.Forms.Padding(2);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 1;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpControls.Size = new System.Drawing.Size(148, 28);
            this.tlpControls.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(122, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Palette = this.kplButton;
            this.btnClose.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 0;
            this.btnClose.Values.Text = "";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // kplButton
            // 
            this.kplButton.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.kplButton.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kplButton.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kplButton.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 1;
            this.kplButton.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kplButton.ButtonStyles.ButtonCommon.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kplButton.Common.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            // 
            // btnPin
            // 
            this.btnPin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPin.Location = new System.Drawing.Point(2, 2);
            this.btnPin.Margin = new System.Windows.Forms.Padding(2);
            this.btnPin.Name = "btnPin";
            this.btnPin.Palette = this.kplButton;
            this.btnPin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnPin.Size = new System.Drawing.Size(24, 24);
            this.btnPin.TabIndex = 1;
            this.btnPin.Values.Text = "";
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            this.btnPin.MouseLeave += new System.EventHandler(this.btnPin_MouseLeave);
            // 
            // lblMove
            // 
            this.lblMove.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblMove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMove.Location = new System.Drawing.Point(30, 0);
            this.lblMove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(88, 28);
            this.lblMove.TabIndex = 2;
            this.lblMove.Text = "...";
            this.lblMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMove.MouseLeave += new System.EventHandler(this.lblMove_MouseLeave);
            this.lblMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMove_MouseMove);
            // 
            // lblDrag
            // 
            this.lblDrag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrag.BackColor = System.Drawing.Color.Transparent;
            this.lblDrag.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.lblDrag.Location = new System.Drawing.Point(310, 301);
            this.lblDrag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDrag.Name = "lblDrag";
            this.lblDrag.Size = new System.Drawing.Size(17, 16);
            this.lblDrag.TabIndex = 2;
            this.lblDrag.Text = ". :";
            this.lblDrag.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblDrag_MouseMove);
            // 
            // lblHide
            // 
            this.lblHide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHide.BackColor = System.Drawing.Color.Transparent;
            this.lblHide.Location = new System.Drawing.Point(311, 0);
            this.lblHide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(16, 317);
            this.lblHide.TabIndex = 3;
            // 
            // splMain
            // 
            this.splMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.splMain.Location = new System.Drawing.Point(0, 0);
            this.splMain.Margin = new System.Windows.Forms.Padding(2);
            this.splMain.Name = "splMain";
            this.splMain.Size = new System.Drawing.Size(330, 2);
            this.splMain.TabIndex = 1;
            this.splMain.TabStop = false;
            this.splMain.MouseEnter += new System.EventHandler(this.splMain_MouseEnter);
            // 
            // webMain
            // 
            this.webMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webMain.Location = new System.Drawing.Point(0, 0);
            this.webMain.Margin = new System.Windows.Forms.Padding(2);
            this.webMain.MinimumSize = new System.Drawing.Size(15, 16);
            this.webMain.Name = "webMain";
            this.webMain.Size = new System.Drawing.Size(330, 319);
            this.webMain.TabIndex = 0;
            // 
            // frmNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 321);
            this.Controls.Add(this.spcMain);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(300, 244);
            this.Name = "frmNote";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Note";
            this.Resize += new System.EventHandler(this.frmNote_Resize);
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.tlpControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPin;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.WebBrowser webMain;
        private System.Windows.Forms.Splitter splMain;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kplButton;
        private System.Windows.Forms.Label lblDrag;
        private System.Windows.Forms.Label lblHide;
    }
}