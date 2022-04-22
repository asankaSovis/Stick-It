
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
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 0);
            this.spcMain.Name = "spcMain";
            this.spcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.tlpControls);
            this.spcMain.Panel1Collapsed = true;
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.lblDrag);
            this.spcMain.Panel2.Controls.Add(this.lblHide);
            this.spcMain.Panel2.Controls.Add(this.splMain);
            this.spcMain.Panel2.Controls.Add(this.webMain);
            this.spcMain.Size = new System.Drawing.Size(442, 395);
            this.spcMain.SplitterDistance = 35;
            this.spcMain.TabIndex = 0;
            // 
            // tlpControls
            // 
            this.tlpControls.ColumnCount = 3;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpControls.Controls.Add(this.btnClose, 2, 0);
            this.tlpControls.Controls.Add(this.btnPin, 0, 0);
            this.tlpControls.Controls.Add(this.lblMove, 1, 0);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(0, 0);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 1;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpControls.Size = new System.Drawing.Size(150, 35);
            this.tlpControls.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(115, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Palette = this.kplButton;
            this.btnClose.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnClose.Size = new System.Drawing.Size(32, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Values.Text = "X";
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
            this.kplButton.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 3;
            this.kplButton.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kplButton.ButtonStyles.ButtonCommon.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            // 
            // btnPin
            // 
            this.btnPin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPin.Location = new System.Drawing.Point(3, 3);
            this.btnPin.Name = "btnPin";
            this.btnPin.Palette = this.kplButton;
            this.btnPin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnPin.Size = new System.Drawing.Size(32, 29);
            this.btnPin.TabIndex = 1;
            this.btnPin.Values.Text = "P";
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            this.btnPin.MouseLeave += new System.EventHandler(this.btnPin_MouseLeave);
            // 
            // lblMove
            // 
            this.lblMove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMove.Location = new System.Drawing.Point(41, 0);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(68, 35);
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
            this.lblDrag.Location = new System.Drawing.Point(419, 375);
            this.lblDrag.Name = "lblDrag";
            this.lblDrag.Size = new System.Drawing.Size(23, 20);
            this.lblDrag.TabIndex = 2;
            this.lblDrag.Text = "...";
            this.lblDrag.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblDrag_MouseMove);
            // 
            // lblHide
            // 
            this.lblHide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHide.BackColor = System.Drawing.Color.Transparent;
            this.lblHide.Location = new System.Drawing.Point(420, 0);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(22, 395);
            this.lblHide.TabIndex = 3;
            // 
            // splMain
            // 
            this.splMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.splMain.Location = new System.Drawing.Point(0, 0);
            this.splMain.Name = "splMain";
            this.splMain.Size = new System.Drawing.Size(442, 3);
            this.splMain.TabIndex = 1;
            this.splMain.TabStop = false;
            this.splMain.MouseEnter += new System.EventHandler(this.splMain_MouseEnter);
            // 
            // webMain
            // 
            this.webMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webMain.Location = new System.Drawing.Point(0, 0);
            this.webMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMain.Name = "webMain";
            this.webMain.Size = new System.Drawing.Size(442, 395);
            this.webMain.TabIndex = 0;
            // 
            // frmNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 395);
            this.Controls.Add(this.spcMain);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmNote";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
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