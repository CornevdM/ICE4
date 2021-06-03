using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace prjProg6112_ICE_Task_
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public string Detail;
        public string Message = "";
        public string Question = "";
        public int Index = 0;

        Read_WriteDetails Read = new Read_WriteDetails();
        Read_WriteDetails Main = new Read_WriteDetails();

        Random RandomAnswers = new Random();
        string[] Answers = { "YES!!", "NO!!", "MAYBE!?" , "IN YOUR DREAMS!", "HIHGHLY UNLIKELY!", "TOO STUPID!", "MEH!", "POGGERS!"};

        public Window1()
        {
            InitializeComponent();
            string Content = Read.ReadFromTextFile();
            txtOuput.Text = Content;
        }
        
        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if(txtUserInput.Text == "")
            {
                MessageBox.Show("Please enter a question before trying to SPIN!");
            }
            else
            {
                Question = txtUserInput.Text;
                Index = RandomAnswers.Next(Answers.Length);
                Message = Answers[Index];
                txtUserInput.Text = "";
                MessageBox.Show(Message);
            }
        }
        public void SaveExtraDetails()
        {
            Main.SetPlayerQuestion(Question);
            Main.SetQuestionAnswer(Message);
            Main.SaveToTextFile();
        }
        private void txtOuput_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtOuput.Focusable = false;
        }
    }
}
