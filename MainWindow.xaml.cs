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

namespace txtmsgTranslateUnit2
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

        private void txtTranslate_Click(object sender, RoutedEventArgs e)
        {
            string TextEntered = txtImput.Text;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }

            TextEntered = TextEntered.ToUpper();

            TextEntered = TextEntered.Replace("CUZ", "because" + Environment.NewLine);         
            TextEntered = TextEntered.Replace("CU", "see you" + Environment.NewLine);         
            TextEntered = TextEntered.Replace(":-)", "I'm happy" + Environment.NewLine);         
            TextEntered = TextEntered.Replace(":-(", "I'm unhappy" + Environment.NewLine);           
            TextEntered = TextEntered.Replace(";-)", "wink" + Environment.NewLine);        
            TextEntered = TextEntered.Replace(":-P", "stick out my tongue" + Environment.NewLine);          
            TextEntered = TextEntered.Replace("(~.~)", "sleepy" + Environment.NewLine);          
            TextEntered = TextEntered.Replace("TA", "totally awesome" + Environment.NewLine);          
            TextEntered = TextEntered.Replace("CCC", "Canadian Computing Competition" + Environment.NewLine);         
            TextEntered = TextEntered.Replace("TTYL", "talk to you later" + Environment.NewLine);        
            TextEntered = TextEntered.Replace("TY", "thank you" + Environment.NewLine);  
            TextEntered = TextEntered.Replace("YW", "you're welcome" + Environment.NewLine);

            lblOutput.Content = " " + TextEntered;
        }
    }
}
