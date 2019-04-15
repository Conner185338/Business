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

namespace _185338Business
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.IO.StreamReader sr2017 = new System.IO.StreamReader("2017Sales.txt");
        System.IO.StreamReader sr2018 = new System.IO.StreamReader("2018Sales.txt");
        string temp;
        string[] monthArray2017 = new string[12];
        string[] monthArray2018 = new string[12];
        public MainWindow()
        {
            InitializeComponent();
            sr2017.ReadLine();
            sr2018.ReadLine();
            for (int i = 0; i < 12; i++)
            {
                monthArray2017[i] = sr2017.ReadLine();
            }
            for(int i = 0; i < 12; i++)
            {
                monthArray2018[i] = sr2018.ReadLine();
            }

        }

        private void btnSales_Click(object sender, RoutedEventArgs e)
        {
            if (textInput.Text.Contains("2017"))
            {
                try
                {
                    lblOutput.Content = "";
                    for (int i = 0; i < 12; i++)
                    {
                        lblOutput.Content += monthArray2017[i] + Environment.NewLine;
                    }//end while
                    //sr2017.Close();
                }//end try
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }//end catch

            }
            else if (textInput.Text.Contains("2018"))
            {
                try
                {
                    lblOutput.Content = "";
                    for (int i = 0; i < 12; i++)
                    {
                        lblOutput.Content += monthArray2018[i] + Environment.NewLine;
                    }//end while
                    //sr2018.Close();
                }//end try
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }//end catch   
            }
        }

        private void rbJan_Checked(object sender, RoutedEventArgs e)
        {
            temp = "";
            for(int i = 0;i < 1; i++)
            {
                if (textInput.Text.Contains("2017"))
                {
                    temp = monthArray2017[i];
                }
                else if (textInput.Text.Contains("2018"))
                {
                    temp = monthArray2018[i];
                }               
            }
           // sr2017.Close();
           // sr2018.Close();
            MessageBox.Show(temp);
        }

        private void rbFeb_Checked(object sender, RoutedEventArgs e)
        {

            temp = "";
            for (int i = 1; i < 2; i++)
            {
                if (textInput.Text.Contains("2017"))
                {
                    temp = monthArray2017[i];
                }
                else if (textInput.Text.Contains("2018"))
                {
                    temp = monthArray2018[i];
                }
            }
            // sr2017.Close();
            // sr2018.Close();
            MessageBox.Show(temp);
        }

        private void rbMar_Checked(object sender, RoutedEventArgs e)
        {
            temp = "";
            for (int i = 2; i < 3; i++)
            {
                if (textInput.Text.Contains("2017"))
                {
                    temp = monthArray2017[i];
                }
                else if (textInput.Text.Contains("2018"))
                {
                    temp = monthArray2018[i];
                }
            }
            // sr2017.Close();
            // sr2018.Close();
            MessageBox.Show(temp);
        }

        private void rbApr_Checked(object sender, RoutedEventArgs e)
        {
            temp = "";
            for (int i = 3; i < 4; i++)
            {
                if (textInput.Text.Contains("2017"))
                {
                    temp = monthArray2017[i];
                }
                else if (textInput.Text.Contains("2018"))
                {
                    temp = monthArray2018[i];
                }
            }
            // sr2017.Close();
            // sr2018.Close();
            MessageBox.Show(temp);
        }

        private void rbMay_Checked(object sender, RoutedEventArgs e)
        {
            temp = "";
            for (int i = 4; i < 5; i++)
            {
                if (textInput.Text.Contains("2017"))
                {
                    temp = monthArray2017[i];
                }
                else if (textInput.Text.Contains("2018"))
                {
                    temp = monthArray2018[i];
                }
            }
            // sr2017.Close();
            // sr2018.Close();
            MessageBox.Show(temp);
        }

        private void rbJun_Checked(object sender, RoutedEventArgs e)
        {
            temp = "";
            for (int i = 5; i < 6; i++)
            {
                if (textInput.Text.Contains("2017"))
                {
                    temp = monthArray2017[i];
                }
                else if (textInput.Text.Contains("2018"))
                {
                    temp = monthArray2018[i];
                }
            }
            // sr2017.Close();
            // sr2018.Close();
            MessageBox.Show(temp);
        }

        private void rbJul_Checked(object sender, RoutedEventArgs e)
        {
            temp = "";
            for (int i = 6; i < 7; i++)
            {
                if (textInput.Text.Contains("2017"))
                {
                    temp = monthArray2017[i];
                }
                else if (textInput.Text.Contains("2018"))
                {
                    temp = monthArray2018[i];
                }
            }
            // sr2017.Close();
            // sr2018.Close();
            MessageBox.Show(temp);
        }

        private void rbAug_Checked(object sender, RoutedEventArgs e)
        {
            temp = "";
            for (int i = 7; i < 8; i++)
            {
                if (textInput.Text.Contains("2017"))
                {
                    temp = monthArray2017[i];
                }
                else if (textInput.Text.Contains("2018"))
                {
                    temp = monthArray2018[i];
                }
            }
            // sr2017.Close();
            // sr2018.Close();
            MessageBox.Show(temp);
        }

        private void rbSep_Checked(object sender, RoutedEventArgs e)
        {
            temp = "";
            for (int i = 8; i < 9; i++)
            {
                if (textInput.Text.Contains("2017"))
                {
                    temp = monthArray2017[i];
                }
                else if (textInput.Text.Contains("2018"))
                {
                    temp = monthArray2018[i];
                }
            }
            // sr2017.Close();
            // sr2018.Close();
            MessageBox.Show(temp);
        }

        private void rbOct_Checked(object sender, RoutedEventArgs e)
        {
            temp = "";
            for (int i = 9; i < 10; i++)
            {
                if (textInput.Text.Contains("2017"))
                {
                    temp = monthArray2017[i];
                }
                else if (textInput.Text.Contains("2018"))
                {
                    temp = monthArray2018[i];
                }
            }
            // sr2017.Close();
            // sr2018.Close();
            MessageBox.Show(temp);
        }

        private void rbNov_Checked(object sender, RoutedEventArgs e)
        {
            temp = "";
            for (int i = 10; i < 11; i++)
            {
                if (textInput.Text.Contains("2017"))
                {
                    temp = monthArray2017[i];
                }
                else if (textInput.Text.Contains("2018"))
                {
                    temp = monthArray2018[i];
                }
            }
            // sr2017.Close();
            // sr2018.Close();
            MessageBox.Show(temp);
        }

        private void rbDec_Checked(object sender, RoutedEventArgs e)
        {
            temp = "";
            for (int i = 11; i < 12; i++)
            {
                if (textInput.Text.Contains("2017"))
                {
                    temp = monthArray2017[i];
                }
                else if (textInput.Text.Contains("2018"))
                {
                    temp = monthArray2018[i];
                }
            }
            // sr2017.Close();
            // sr2018.Close();
            MessageBox.Show(temp);
        }
    }
}
