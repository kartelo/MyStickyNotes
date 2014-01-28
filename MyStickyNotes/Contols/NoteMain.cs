using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyStickyNotes.Contols
{

    public partial class NoteMain : Form
    {
        private String noteMessage;
        MyStickyNotes.FromCallBackDeligate createNewNote;
        MyStickyNotes.DelegateWriteToDB writeMsgToDB;
        MyStickyNotes.DelegateDeleteFromDB deleteNoteFromDB;
        private int noteID;

        private NoteMain()
        {
            InitializeComponent();
            noteMessage = "None";
        }

        public NoteMain(int ID, FromCallBackDeligate newFormCB, DelegateWriteToDB writeMsgCB, MyStickyNotes.DelegateDeleteFromDB deleteFromDB)
        {
            InitializeComponent();
          //  noteMessage = "None";
            createNewNote = newFormCB;
            writeMsgToDB = writeMsgCB;
            deleteNoteFromDB = deleteFromDB;
            noteID = ID;
        }

        public void setNoteMessage(string msg)
        {
            textBox1.Text = noteMessage = msg;
        }

        private void DeleteNote_Click(object sender, EventArgs e)
        {
            deleteNoteFromDB(noteID);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            noteMessage =  textBox1.Text;
            writeMsgToDB(noteID, noteMessage);
        }

        private void NewNote_Click(object sender, EventArgs e)
        {
            this.createNewNote();
        }
    }
}
