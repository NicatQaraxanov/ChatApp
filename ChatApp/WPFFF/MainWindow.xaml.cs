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

namespace WPFFF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbox.Text))
            {
                lBox.Items.Add(new Message() { Date = DateTime.Now.ToShortTimeString(), Title = tbox.Text });

                if (tbox.Text.ToUpper().Contains("SALAM"))
                {
                    lBox.Items.Add(new AnswerMessage() { AnswerDate = DateTime.Now.ToShortTimeString(), AnswerTitle = "Aleykuma salam" });
                }
                else if (tbox.Text.ToUpper().Contains("NECESEN"))
                {
                    lBox.Items.Add(new AnswerMessage() { AnswerDate = DateTime.Now.ToShortTimeString(), AnswerTitle = "Yaxsiyam sen necesen?" });
                }
                else if (tbox.Text.ToUpper().Contains("YAXSIYAM"))
                {
                    lBox.Items.Add(new AnswerMessage() { AnswerDate = DateTime.Now.ToShortTimeString(), AnswerTitle = "Hemise yaxci ol brat" });
                }
                tbox.Clear();
            }
        }

        private void tbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter && !string.IsNullOrWhiteSpace(tbox.Text))
            {
                lBox.Items.Add(new Message() { Date = DateTime.Now.ToShortTimeString(), Title = tbox.Text });

                if (tbox.Text.ToUpper().Contains("SALAM"))
                {
                    lBox.Items.Add(new AnswerMessage() { AnswerDate = DateTime.Now.ToShortTimeString(), AnswerTitle = "Aleykuma salam" });
                }
                else if (tbox.Text.ToUpper().Contains("NECESEN"))
                {
                    lBox.Items.Add(new AnswerMessage() { AnswerDate = DateTime.Now.ToShortTimeString(), AnswerTitle = "Yaxsiyam sen necesen?" });
                }
                else if (tbox.Text.ToUpper().Contains("YAXSIYAM"))
                {
                    lBox.Items.Add(new AnswerMessage() { AnswerDate = DateTime.Now.ToShortTimeString(), AnswerTitle = "Hemise yaxci ol brat" });
                }
                tbox.Clear();
            }
        }
    }



    public class Message
    {
        public string Title { get; set; }

        public string Date { get; set; }
    }

    public class AnswerMessage
    {
        public string AnswerTitle { get; set; }

        public string AnswerDate { get; set; }
    }
}
