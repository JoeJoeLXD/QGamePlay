namespace XLiQGame
{
    partial class FormPlay
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoves = new System.Windows.Forms.TextBox();
            this.txtRemaningBoxes = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(903, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadGameToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pnlGame
            // 
            this.pnlGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGame.Location = new System.Drawing.Point(13, 32);
            this.pnlGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(644, 581);
            this.pnlGame.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Moves";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Remaning Boxes";
            // 
            // txtMoves
            // 
            this.txtMoves.Location = new System.Drawing.Point(681, 82);
            this.txtMoves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.ReadOnly = true;
            this.txtMoves.Size = new System.Drawing.Size(167, 22);
            this.txtMoves.TabIndex = 4;
            this.txtMoves.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRemaningBoxes
            // 
            this.txtRemaningBoxes.Location = new System.Drawing.Point(681, 160);
            this.txtRemaningBoxes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRemaningBoxes.Name = "txtRemaningBoxes";
            this.txtRemaningBoxes.ReadOnly = true;
            this.txtRemaningBoxes.Size = new System.Drawing.Size(167, 22);
            this.txtRemaningBoxes.TabIndex = 5;
            this.txtRemaningBoxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(759, 497);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(60, 60);
            this.btnUp.TabIndex = 6;
            this.btnUp.Tag = "Up";
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.controlPad_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(703, 554);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(60, 60);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.controlPad_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(759, 554);
            this.btnDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(60, 60);
            this.btnDown.TabIndex = 8;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.controlPad_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(816, 554);
            this.btnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(60, 60);
            this.btnRight.TabIndex = 9;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.controlPad_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "dlgOpen";
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 628);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtRemaningBoxes);
            this.Controls.Add(this.txtMoves);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPlay";
            this.Text = "PlayForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoves;
        private System.Windows.Forms.TextBox txtRemaningBoxes;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
    }
}