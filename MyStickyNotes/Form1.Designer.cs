namespace MyStickyNotes
{
     
    partial class StickyNotesMain
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
            if(this.currentNote != 0)
                notesDB.WriteAllDBToFile();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StickyNotesMain));
            this.buttonNewNote = new System.Windows.Forms.Button();
            this.buttonShowAllNotes = new System.Windows.Forms.Button();
            this.buttonHideAllNotes = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNewNote
            // 
            this.buttonNewNote.Location = new System.Drawing.Point(55, 39);
            this.buttonNewNote.Name = "buttonNewNote";
            this.buttonNewNote.Size = new System.Drawing.Size(180, 23);
            this.buttonNewNote.TabIndex = 0;
            this.buttonNewNote.Text = "New Note";
            this.buttonNewNote.UseVisualStyleBackColor = true;
            this.buttonNewNote.Click += new System.EventHandler(this.buttonNewNote_Click);
            // 
            // buttonShowAllNotes
            // 
            this.buttonShowAllNotes.Location = new System.Drawing.Point(55, 80);
            this.buttonShowAllNotes.Name = "buttonShowAllNotes";
            this.buttonShowAllNotes.Size = new System.Drawing.Size(180, 23);
            this.buttonShowAllNotes.TabIndex = 2;
            this.buttonShowAllNotes.Text = "Show All Notes";
            this.buttonShowAllNotes.UseVisualStyleBackColor = true;
            this.buttonShowAllNotes.Click += new System.EventHandler(this.buttonShowAllNotes_Click);
            // 
            // buttonHideAllNotes
            // 
            this.buttonHideAllNotes.Location = new System.Drawing.Point(55, 120);
            this.buttonHideAllNotes.Name = "buttonHideAllNotes";
            this.buttonHideAllNotes.Size = new System.Drawing.Size(180, 23);
            this.buttonHideAllNotes.TabIndex = 3;
            this.buttonHideAllNotes.Text = "Hide All Notes";
            this.buttonHideAllNotes.UseVisualStyleBackColor = true;
            this.buttonHideAllNotes.Click += new System.EventHandler(this.buttonHideAllNotes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Cornsilk;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "My application still working...";
            this.notifyIcon1.BalloonTipTitle = "My Sample Application";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // StickyNotesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonHideAllNotes);
            this.Controls.Add(this.buttonShowAllNotes);
            this.Controls.Add(this.buttonNewNote);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StickyNotesMain";
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewNote;
        private System.Windows.Forms.Button buttonShowAllNotes;
        private System.Windows.Forms.Button buttonHideAllNotes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

