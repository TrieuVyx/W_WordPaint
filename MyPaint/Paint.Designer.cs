using System.Windows.Forms;

namespace MyPaint
{
    partial class Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.fromAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pNGPỉctureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPEGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMPPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gIFPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsDesktopBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteCtrlVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInCtrlPageUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutCtrlPageDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitToWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridlinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thumbnailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem4,
            this.recentToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.printToolStripMenuItem,
            this.sendToolStripMenuItem,
            this.setAsDesktopBackgroundToolStripMenuItem,
            this.imagePropertiesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::MyPaint.Properties.Resources.file;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::MyPaint.Properties.Resources.folder_open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromAFileToolStripMenuItem});
            this.toolStripMenuItem4.Image = global::MyPaint.Properties.Resources.add_image__1_;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // fromAFileToolStripMenuItem
            // 
            this.fromAFileToolStripMenuItem.Name = "fromAFileToolStripMenuItem";
            resources.ApplyResources(this.fromAFileToolStripMenuItem, "fromAFileToolStripMenuItem");
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Image = global::MyPaint.Properties.Resources.recent;
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            resources.ApplyResources(this.recentToolStripMenuItem, "recentToolStripMenuItem");
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::MyPaint.Properties.Resources.save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pNGPỉctureToolStripMenuItem,
            this.jPEGToolStripMenuItem,
            this.bMPPictureToolStripMenuItem,
            this.gIFPictureToolStripMenuItem,
            this.otherFormatToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::MyPaint.Properties.Resources.diskette1;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // pNGPỉctureToolStripMenuItem
            // 
            this.pNGPỉctureToolStripMenuItem.Name = "pNGPỉctureToolStripMenuItem";
            resources.ApplyResources(this.pNGPỉctureToolStripMenuItem, "pNGPỉctureToolStripMenuItem");
            // 
            // jPEGToolStripMenuItem
            // 
            this.jPEGToolStripMenuItem.Name = "jPEGToolStripMenuItem";
            resources.ApplyResources(this.jPEGToolStripMenuItem, "jPEGToolStripMenuItem");
            // 
            // bMPPictureToolStripMenuItem
            // 
            this.bMPPictureToolStripMenuItem.Name = "bMPPictureToolStripMenuItem";
            resources.ApplyResources(this.bMPPictureToolStripMenuItem, "bMPPictureToolStripMenuItem");
            // 
            // gIFPictureToolStripMenuItem
            // 
            this.gIFPictureToolStripMenuItem.Name = "gIFPictureToolStripMenuItem";
            resources.ApplyResources(this.gIFPictureToolStripMenuItem, "gIFPictureToolStripMenuItem");
            // 
            // otherFormatToolStripMenuItem
            // 
            this.otherFormatToolStripMenuItem.Name = "otherFormatToolStripMenuItem";
            resources.ApplyResources(this.otherFormatToolStripMenuItem, "otherFormatToolStripMenuItem");
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::MyPaint.Properties.Resources.print;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            resources.ApplyResources(this.printToolStripMenuItem, "printToolStripMenuItem");
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Image = global::MyPaint.Properties.Resources.paper_plane_top;
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            resources.ApplyResources(this.sendToolStripMenuItem, "sendToolStripMenuItem");
            // 
            // setAsDesktopBackgroundToolStripMenuItem
            // 
            this.setAsDesktopBackgroundToolStripMenuItem.Image = global::MyPaint.Properties.Resources.add_image;
            this.setAsDesktopBackgroundToolStripMenuItem.Name = "setAsDesktopBackgroundToolStripMenuItem";
            resources.ApplyResources(this.setAsDesktopBackgroundToolStripMenuItem, "setAsDesktopBackgroundToolStripMenuItem");
            // 
            // imagePropertiesToolStripMenuItem
            // 
            this.imagePropertiesToolStripMenuItem.Image = global::MyPaint.Properties.Resources.file_download;
            this.imagePropertiesToolStripMenuItem.Name = "imagePropertiesToolStripMenuItem";
            resources.ApplyResources(this.imagePropertiesToolStripMenuItem, "imagePropertiesToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::MyPaint.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutCtrlXToolStripMenuItem,
            this.copyCtrlCToolStripMenuItem,
            this.pasteCtrlVToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // cutCtrlXToolStripMenuItem
            // 
            this.cutCtrlXToolStripMenuItem.Image = global::MyPaint.Properties.Resources.scissors1;
            this.cutCtrlXToolStripMenuItem.Name = "cutCtrlXToolStripMenuItem";
            resources.ApplyResources(this.cutCtrlXToolStripMenuItem, "cutCtrlXToolStripMenuItem");
            // 
            // copyCtrlCToolStripMenuItem
            // 
            this.copyCtrlCToolStripMenuItem.Image = global::MyPaint.Properties.Resources.copy1;
            this.copyCtrlCToolStripMenuItem.Name = "copyCtrlCToolStripMenuItem";
            resources.ApplyResources(this.copyCtrlCToolStripMenuItem, "copyCtrlCToolStripMenuItem");
            // 
            // pasteCtrlVToolStripMenuItem
            // 
            this.pasteCtrlVToolStripMenuItem.Image = global::MyPaint.Properties.Resources.paste1;
            this.pasteCtrlVToolStripMenuItem.Name = "pasteCtrlVToolStripMenuItem";
            resources.ApplyResources(this.pasteCtrlVToolStripMenuItem, "pasteCtrlVToolStripMenuItem");
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.rulersToolStripMenuItem,
            this.gridlinesToolStripMenuItem,
            this.statusBarToolStripMenuItem,
            this.fullScreenToolStripMenuItem,
            this.thumbnailToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem,
            this.zoomInCtrlPageUpToolStripMenuItem,
            this.zoomOutCtrlPageDownToolStripMenuItem,
            this.fitToWindowToolStripMenuItem});
            this.zoomToolStripMenuItem.Image = global::MyPaint.Properties.Resources.zoom_in;
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            resources.ApplyResources(this.zoomToolStripMenuItem, "zoomToolStripMenuItem");
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            resources.ApplyResources(this.sToolStripMenuItem, "sToolStripMenuItem");
            // 
            // zoomInCtrlPageUpToolStripMenuItem
            // 
            this.zoomInCtrlPageUpToolStripMenuItem.Name = "zoomInCtrlPageUpToolStripMenuItem";
            resources.ApplyResources(this.zoomInCtrlPageUpToolStripMenuItem, "zoomInCtrlPageUpToolStripMenuItem");
            // 
            // zoomOutCtrlPageDownToolStripMenuItem
            // 
            this.zoomOutCtrlPageDownToolStripMenuItem.Name = "zoomOutCtrlPageDownToolStripMenuItem";
            resources.ApplyResources(this.zoomOutCtrlPageDownToolStripMenuItem, "zoomOutCtrlPageDownToolStripMenuItem");
            // 
            // fitToWindowToolStripMenuItem
            // 
            this.fitToWindowToolStripMenuItem.Name = "fitToWindowToolStripMenuItem";
            resources.ApplyResources(this.fitToWindowToolStripMenuItem, "fitToWindowToolStripMenuItem");
            // 
            // rulersToolStripMenuItem
            // 
            this.rulersToolStripMenuItem.Name = "rulersToolStripMenuItem";
            resources.ApplyResources(this.rulersToolStripMenuItem, "rulersToolStripMenuItem");
            // 
            // gridlinesToolStripMenuItem
            // 
            this.gridlinesToolStripMenuItem.Name = "gridlinesToolStripMenuItem";
            resources.ApplyResources(this.gridlinesToolStripMenuItem, "gridlinesToolStripMenuItem");
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            resources.ApplyResources(this.statusBarToolStripMenuItem, "statusBarToolStripMenuItem");
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Image = global::MyPaint.Properties.Resources.expand;
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            resources.ApplyResources(this.fullScreenToolStripMenuItem, "fullScreenToolStripMenuItem");
            // 
            // thumbnailToolStripMenuItem
            // 
            this.thumbnailToolStripMenuItem.Image = global::MyPaint.Properties.Resources.images;
            this.thumbnailToolStripMenuItem.Name = "thumbnailToolStripMenuItem";
            resources.ApplyResources(this.thumbnailToolStripMenuItem, "thumbnailToolStripMenuItem");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::MyPaint.Properties.Resources.circle1;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MyPaint.Properties.Resources.square2;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MyPaint.Properties.Resources.redo_alt;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MyPaint.Properties.Resources.undo_alt;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.panelCanvas, "panelCanvas");
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Paint
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paint";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem fromAFileToolStripMenuItem;
        private ToolStripMenuItem recentToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem pNGPỉctureToolStripMenuItem;
        private ToolStripMenuItem jPEGToolStripMenuItem;
        private ToolStripMenuItem bMPPictureToolStripMenuItem;
        private ToolStripMenuItem gIFPictureToolStripMenuItem;
        private ToolStripMenuItem otherFormatToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem sendToolStripMenuItem;
        private ToolStripMenuItem setAsDesktopBackgroundToolStripMenuItem;
        private ToolStripMenuItem imagePropertiesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem cutCtrlXToolStripMenuItem;
        private ToolStripMenuItem copyCtrlCToolStripMenuItem;
        private ToolStripMenuItem pasteCtrlVToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem sToolStripMenuItem;
        private ToolStripMenuItem zoomInCtrlPageUpToolStripMenuItem;
        private ToolStripMenuItem zoomOutCtrlPageDownToolStripMenuItem;
        private ToolStripMenuItem fitToWindowToolStripMenuItem;
        private ToolStripMenuItem rulersToolStripMenuItem;
        private ToolStripMenuItem gridlinesToolStripMenuItem;
        private ToolStripMenuItem statusBarToolStripMenuItem;
        private ToolStripMenuItem fullScreenToolStripMenuItem;
        private ToolStripMenuItem thumbnailToolStripMenuItem;
        private MenuStrip menuStrip1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Button button2;
        private Panel panelCanvas;
        private Label label1;
        private Label label2;
    }
}

