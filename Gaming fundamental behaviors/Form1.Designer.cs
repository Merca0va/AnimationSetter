namespace Gaming_fundamental_behaviors
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animateImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrowKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bufferingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 237);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animateImageToolStripMenuItem,
            this.changeImageToolStripMenuItem,
            this.bufferingToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // animateImageToolStripMenuItem
            // 
            this.animateImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveImageToolStripMenuItem,
            this.rotateImageToolStripMenuItem,
            this.resizeImageToolStripMenuItem});
            this.animateImageToolStripMenuItem.Name = "animateImageToolStripMenuItem";
            this.animateImageToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.animateImageToolStripMenuItem.Text = "Animate Image";
            // 
            // moveImageToolStripMenuItem
            // 
            this.moveImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrowKeysToolStripMenuItem,
            this.mouseClickToolStripMenuItem});
            this.moveImageToolStripMenuItem.Name = "moveImageToolStripMenuItem";
            this.moveImageToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.moveImageToolStripMenuItem.Text = "Move Image";
            // 
            // arrowKeysToolStripMenuItem
            // 
            this.arrowKeysToolStripMenuItem.Name = "arrowKeysToolStripMenuItem";
            this.arrowKeysToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.arrowKeysToolStripMenuItem.Text = "Arrow Keys";
            this.arrowKeysToolStripMenuItem.Click += new System.EventHandler(this.arrowKeysToolStripMenuItem_Click);
            // 
            // mouseClickToolStripMenuItem
            // 
            this.mouseClickToolStripMenuItem.Name = "mouseClickToolStripMenuItem";
            this.mouseClickToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.mouseClickToolStripMenuItem.Text = "Mouse Click";
            this.mouseClickToolStripMenuItem.Click += new System.EventHandler(this.mouseClickToolStripMenuItem_Click);
            // 
            // rotateImageToolStripMenuItem
            // 
            this.rotateImageToolStripMenuItem.Name = "rotateImageToolStripMenuItem";
            this.rotateImageToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.rotateImageToolStripMenuItem.Text = "Rotate Image";
            this.rotateImageToolStripMenuItem.Click += new System.EventHandler(this.rotateImageToolStripMenuItem_Click);
            // 
            // resizeImageToolStripMenuItem
            // 
            this.resizeImageToolStripMenuItem.Name = "resizeImageToolStripMenuItem";
            this.resizeImageToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.resizeImageToolStripMenuItem.Text = "Resize Image";
            this.resizeImageToolStripMenuItem.Click += new System.EventHandler(this.resizeImageToolStripMenuItem_Click);
            // 
            // changeImageToolStripMenuItem
            // 
            this.changeImageToolStripMenuItem.Name = "changeImageToolStripMenuItem";
            this.changeImageToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.changeImageToolStripMenuItem.Text = "Change Image";
            this.changeImageToolStripMenuItem.Click += new System.EventHandler(this.changeImageToolStripMenuItem_Click);
            // 
            // bufferingToolStripMenuItem
            // 
            this.bufferingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleToolStripMenuItem,
            this.doubleToolStripMenuItem});
            this.bufferingToolStripMenuItem.Name = "bufferingToolStripMenuItem";
            this.bufferingToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.bufferingToolStripMenuItem.Text = "Buffering";
            // 
            // singleToolStripMenuItem
            // 
            this.singleToolStripMenuItem.Name = "singleToolStripMenuItem";
            this.singleToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.singleToolStripMenuItem.Text = "Single";
            this.singleToolStripMenuItem.Click += new System.EventHandler(this.singleToolStripMenuItem_Click);
            // 
            // doubleToolStripMenuItem
            // 
            this.doubleToolStripMenuItem.Name = "doubleToolStripMenuItem";
            this.doubleToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.doubleToolStripMenuItem.Text = "Double";
            this.doubleToolStripMenuItem.Click += new System.EventHandler(this.doubleToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Object Behavior";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animateImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrowKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bufferingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubleToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

