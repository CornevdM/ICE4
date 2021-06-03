using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace prjProg6112_ICE_Task_
{
    class Read_WriteDetails : Details
    {
        public string strDisplay = "";

        public string PATH = Path.GetFullPath(@"..\..\..\") + "LuckyWinner.txt";
        static List<Details> DetailList = new List<Details>();
        public void PushToListDetails(string PlayerName, string PlayerSurname, string PlayerEmail)
        {
            DetailList.Add(new Read_WriteDetails()
            {
                PlayerName = GetName(),
                PlayerSurName = GetSurname(),
                PlayerEmail = GetEmail()
            });
        }
        
        public void SaveToTextFile()
        {
            try
            {
                if (!File.Exists(PATH))
                {
                    using (StreamWriter SW = File.CreateText(PATH))
                    {
                        foreach (var Value in DetailList)
                        {
                            SW.WriteLine(PlayerName);
                            SW.WriteLine(PlayerSurName);
                            SW.WriteLine(PlayerEmail);
                            SW.Close();//closeing the text file
                        }
                    }
                }
                else
                {
                    using (StreamWriter SW = new StreamWriter(PATH, true))
                    {
                        SW.WriteLine(PlayerName);
                        SW.WriteLine(PlayerSurName);
                        SW.WriteLine(PlayerEmail);
                        SW.Close();//closeing the text file
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocured " + ex.ToString());
            }
        }
        public string ReadFromTextFile()
        {
            if (!File.Exists(PATH))
            {
                using (StreamWriter SW = File.CreateText(PATH))
                {
                    foreach (var Value in DetailList)
                    {
                        SW.WriteLine(PlayerName);
                        SW.WriteLine(PlayerSurName);
                        SW.WriteLine(PlayerEmail);
                        SW.Close();//closeing the text file
                    }
                }
            }
            strDisplay = "";

            try
            {
                StreamReader SR = new StreamReader(PATH, true);
                foreach (var Value in DetailList)
                {
                    SR.ReadToEnd();
                    SR.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocured " + ex.ToString());
            }
            return strDisplay;
        }

        #region Getters & Setters
        public string GetName()
        {
            return PlayerName;
        }
        public string GetSurname()
        {
            return PlayerSurName;
        }
        public string GetEmail()
        {
            return PlayerEmail;
        }
        public override void SetName(string strPlayerName)
        {
            PlayerName = strPlayerName;
        }

        public override void SetSurName(string strPlayerSurName)
        {
            PlayerSurName = strPlayerSurName;
        }

        public override void SetEmail(string strPlayerEmail)
        {
            PlayerEmail = strPlayerEmail;
        }
        #endregion
    }
}
