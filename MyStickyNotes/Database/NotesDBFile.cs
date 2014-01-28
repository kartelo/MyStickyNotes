using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStickyNotes.Database
{
    class NotesDBFile
    {
        private string[] msgNotesArr;

        public NotesDBFile()
        {
            msgNotesArr = new string[128];
        }

        public void WriteMsgInDB(int noteID, string msgNote)
        {
            msgNotesArr[noteID] = msgNote;
        }
        public void DeleteFromFromDB(int noteID)
        {
            msgNotesArr[noteID] = null;
        }
        
        public void PrintAllNotes()
        {
            for(int i = 0; i < 5; i++)
            {
                System.Windows.Forms.MessageBox.Show(msgNotesArr[i]);
            }
        }
        public void WriteAllDBToFile()
        {
            if (System.IO.File.Exists("WriteLines.txt"))
            {
                System.IO.File.Delete("WriteLines.txt");
            }

            foreach (string item in msgNotesArr)
            {
                if (item == null)
                {
                    continue;
                }
                System.IO.File.AppendAllText(@"WriteLines.txt", item + Environment.NewLine);

                // System.IO.File.WriteAllText(@"WriteLines.txt", item + Environment.NewLine);
               //System.IO.File.WriteAllLines(@"WriteLines.txt", msgNotesArr);
            }
        }

        public int ReadDBFromFile()
        {
            if(System.IO.File.Exists("WriteLines.txt"))
            {
                string[] arr = new string[128];
                int dbSize = 0;
                 arr  = System.IO.File.ReadAllLines(@"WriteLines.txt");
                 foreach (string item in arr)
                {
                    if (item == "")
                        break;
                    msgNotesArr[dbSize] = item;
                    dbSize++;
                }

                return dbSize;
            }
            return 0;
        }

        public string GetMsgFromID(int ID)
        {
            return msgNotesArr[ID];
        }
    }
}
