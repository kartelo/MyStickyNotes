namespace MyStickyNotes.Contols
{
    partial class NoteMain
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
            this.NewNoteButton = new System.Windows.Forms.Button();
            this.DeleteNoteButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewNoteButton
            // 
            this.NewNoteButton.BackColor = System.Drawing.Color.Khaki;
            this.NewNoteButton.Location = new System.Drawing.Point(12, 12);
            this.NewNoteButton.Name = "NewNoteButton";
            this.NewNoteButton.Size = new System.Drawing.Size(42, 23);
            this.NewNoteButton.TabIndex = 0;
            this.NewNoteButton.Text = "New Note";
            this.NewNoteButton.UseVisualStyleBackColor = false;
            this.NewNoteButton.Click += new System.EventHandler(this.NewNote_Click);
            // 
            // DeleteNoteButton
            // 
            this.DeleteNoteButton.BackColor = System.Drawing.Color.Khaki;
            this.DeleteNoteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteNoteButton.Location = new System.Drawing.Point(173, 13);
            this.DeleteNoteButton.Name = "DeleteNoteButton";
            this.DeleteNoteButton.Size = new System.Drawing.Size(46, 23);
            this.DeleteNoteButton.TabIndex = 1;
            this.DeleteNoteButton.Text = "Delete Note";
            this.DeleteNoteButton.UseVisualStyleBackColor = false;
            this.DeleteNoteButton.Click += new System.EventHandler(this.DeleteNote_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(0, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(232, 205);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NoteMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(231, 247);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeleteNoteButton);
            this.Controls.Add(this.NewNoteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "NoteMain";
            this.ShowInTaskbar = false;
            this.Text = "NoteMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewNoteButton;
        private System.Windows.Forms.Button DeleteNoteButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}