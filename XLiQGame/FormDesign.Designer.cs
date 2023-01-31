namespace XLiQGame
{
    partial class FormDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDesign));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.lblColumn = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.lblRow = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.lblToolbox = new System.Windows.Forms.Label();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.txtColumn);
            this.panel1.Controls.Add(this.lblColumn);
            this.panel1.Controls.Add(this.txtRow);
            this.panel1.Controls.Add(this.lblRow);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(424, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(106, 26);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtColumn
            // 
            this.txtColumn.Location = new System.Drawing.Point(296, 15);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(100, 22);
            this.txtColumn.TabIndex = 3;
            this.txtColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Location = new System.Drawing.Point(215, 15);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(55, 16);
            this.lblColumn.TabIndex = 2;
            this.lblColumn.Text = "Colums:";
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(76, 16);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(100, 22);
            this.txtRow.TabIndex = 1;
            this.txtRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(13, 16);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(44, 16);
            this.lblRow.TabIndex = 0;
            this.lblRow.Text = "Rows:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnGreenBox);
            this.panel2.Controls.Add(this.btnRedBox);
            this.panel2.Controls.Add(this.btnGreenDoor);
            this.panel2.Controls.Add(this.btnRedDoor);
            this.panel2.Controls.Add(this.btnWall);
            this.panel2.Controls.Add(this.btnNone);
            this.panel2.Controls.Add(this.lblToolbox);
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 388);
            this.panel2.TabIndex = 2;
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenBox.ImageIndex = 5;
            this.btnGreenBox.ImageList = this.imageList1;
            this.btnGreenBox.Location = new System.Drawing.Point(3, 310);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(139, 45);
            this.btnGreenBox.TabIndex = 6;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "None.jpg");
            this.imageList1.Images.SetKeyName(1, "Wall.jpg");
            this.imageList1.Images.SetKeyName(2, "Red Door.png");
            this.imageList1.Images.SetKeyName(3, "Green Door.jpg");
            this.imageList1.Images.SetKeyName(4, "Red Box.jpg");
            this.imageList1.Images.SetKeyName(5, "Green Box.jpg");
            // 
            // btnRedBox
            // 
            this.btnRedBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedBox.ImageIndex = 4;
            this.btnRedBox.ImageList = this.imageList1;
            this.btnRedBox.Location = new System.Drawing.Point(3, 259);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(139, 45);
            this.btnRedBox.TabIndex = 5;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenDoor.ImageIndex = 3;
            this.btnGreenDoor.ImageList = this.imageList1;
            this.btnGreenDoor.Location = new System.Drawing.Point(3, 208);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(139, 45);
            this.btnGreenDoor.TabIndex = 4;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedDoor.ImageIndex = 2;
            this.btnRedDoor.ImageList = this.imageList1;
            this.btnRedDoor.Location = new System.Drawing.Point(3, 157);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(139, 45);
            this.btnRedDoor.TabIndex = 3;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnWall
            // 
            this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWall.ImageIndex = 1;
            this.btnWall.ImageList = this.imageList1;
            this.btnWall.Location = new System.Drawing.Point(3, 106);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(139, 45);
            this.btnWall.TabIndex = 2;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnNone
            // 
            this.btnNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNone.ImageIndex = 0;
            this.btnNone.ImageList = this.imageList1;
            this.btnNone.Location = new System.Drawing.Point(3, 55);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(139, 45);
            this.btnNone.TabIndex = 1;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // lblToolbox
            // 
            this.lblToolbox.AutoSize = true;
            this.lblToolbox.Location = new System.Drawing.Point(42, 16);
            this.lblToolbox.Name = "lblToolbox";
            this.lblToolbox.Size = new System.Drawing.Size(57, 16);
            this.lblToolbox.TabIndex = 0;
            this.lblToolbox.Text = "Toolbox";
            // 
            // FormDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(806, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDesign";
            this.Text = "Design Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblToolbox;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ImageList imageList1;
    }
}