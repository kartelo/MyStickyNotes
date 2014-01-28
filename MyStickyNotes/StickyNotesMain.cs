using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyStickyNotes
{
    public delegate void FromCallBackDeligate();
    public delegate void DelegateWriteToDB(int id, string msg);
    public delegate void DelegateDeleteFromDB(int id);

    public partial class StickyNotesMain : Form
    {
        #region Variables
        private MyStickyNotes.Contols.NoteMain[] notesArr;
        private int currentNote;
        MyStickyNotes.FromCallBackDeligate CBNewForm;
        MyStickyNotes.DelegateWriteToDB writeToDB;
        MyStickyNotes.DelegateDeleteFromDB DeleteFromDB;


        MyStickyNotes.Database.NotesDBFile notesDB;
        #endregion

        public StickyNotesMain()
        {
            InitializeComponent();
            notesArr = new MyStickyNotes.Contols.NoteMain[128];
            currentNote = 0;
            CBNewForm = new MyStickyNotes.FromCallBackDeligate(CreateNewNote);
            writeToDB = new MyStickyNotes.DelegateWriteToDB(NoteMessage);
            DeleteFromDB = new MyStickyNotes.DelegateDeleteFromDB(DeleteNoteFromDB);
            notesDB = new MyStickyNotes.Database.NotesDBFile();
            currentNote = notesDB.ReadDBFromFile();
            if (currentNote != 0)
                ConstructNotes();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void ConstructNotes()
        {
            int tmpCur = currentNote;
            tmpCur--;
            for (int i = tmpCur; i >= 0; i--)
            {
                notesArr[i] = new MyStickyNotes.Contols.NoteMain(i, CBNewForm, writeToDB, DeleteFromDB);
                notesArr[i].Show();
                notesArr[i].setNoteMessage(notesDB.GetMsgFromID(i));
            }
        }

        #region Event Handlers
        private void buttonNewNote_Click(object sender, EventArgs e)
        {
            CreateNewNote();
            //notifyIcon.ShowBalloonTip(2000, "Smart Shot", "SmartShot now works in background.\r\n- use [ctrl + Print Screen] to capture active window\r\n- use [shift + Print Screen] to capture whole desktop", ToolTipIcon.Info);
        }
 
        private void buttonShowAllNotes_Click(object sender, EventArgs e)
        {

        }

        private void buttonHideAllNotes_Click(object sender, EventArgs e)
        {
            notesDB.PrintAllNotes();
        }
        #endregion

        #region Function callbacks
        private void CreateNewNote()
        {
            notesArr[currentNote] = new MyStickyNotes.Contols.NoteMain(currentNote, CBNewForm, writeToDB, DeleteFromDB);
            notesArr[currentNote].Show();
            currentNote++;
        }

        private void NoteMessage(int ID,string msgNote)
        {
            notesDB.WriteMsgInDB(ID, msgNote);
        }

        private void DeleteNoteFromDB(int ID)
        {
          notesDB.DeleteFromFromDB(ID);
        }

        #endregion

    }
}
