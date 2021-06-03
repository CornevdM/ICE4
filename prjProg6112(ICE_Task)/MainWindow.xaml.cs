using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prjProg6112_ICE_Task_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Read_WriteDetails Main = new Read_WriteDetails();

        public string Name, Surname, Email;
        private void btnSpin_Click(object sender, RoutedEventArgs e)
        {
            Main.SetName(Name = txtName.Text);
            Main.SetSurName(Name = txtName.Text);
            Main.SetEmail(Name = txtName.Text);
            Main.SaveToTextFile();
            
            Window1 Event = new Window1();
            Event.Show();

            this.Close();
        }
    }
}
