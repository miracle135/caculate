using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;


namespace caculate
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        string Number1 = "", Number2 = "", flag = "";
        List<string> expression = new List<string>();
        double result = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            if (flag == "")
            {
                Number1 += "1";
                label2.Content = Number1;
            }
            else 
            {
                Number2 += "1";
                label2.Content = Number2;
            }
            
        }
        private void button17_Click(object sender, RoutedEventArgs e)
        {
            if (flag == "")
            {
                Number1 += "2";
                label2.Content = Number1;
            }
            else
            {
                Number2 +="2";
                label2.Content = Number2;
            }

        }
        private void button18_Click(object sender, RoutedEventArgs e)
        {
            if (flag == "")
            {
                Number1 += 3;
                label2.Content = Number1;
            }
            else
            {
                Number2 += 3;
                label2.Content = Number2;
            }

        }
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (flag == "")
            {
                Number1 += 4;
                label2.Content = Number1;
            }
            else
            {
                Number2 += 4;
                label2.Content = Number2;
            }

        }
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (flag == "")
            {
                Number1 += 5;
                label2.Content = Number1;
            }
            else
            {
                Number2 += 5;
                label2.Content = Number2;
            }

        }
        private void button13_Click(object sender, RoutedEventArgs e)
        {
            if (flag == "")
            {
                Number1 += 6;
                label2.Content = Number1;
            }
            else
            {
                Number2 += 6;
                label2.Content = Number2;
            }

        }
        private void button12_Click(object sender, RoutedEventArgs e)
        {
            if (flag == "")
            {
                Number1 += "7";
                label2.Content = Number1;
            }
            else
            {
                Number2 += "7";
                label2.Content = Number2;
            }

        }
        private void button14_Click(object sender, RoutedEventArgs e)
        {
            if (flag == "")
            {
                Number1 += 8;
                label2.Content = Number1;
            }
            else
            {
                Number2 += 8;
                label2.Content = Number2;
            }

        }
        private void button15_Click(object sender, RoutedEventArgs e)
        {
            if (flag == "")
            {
                Number1 += "9";
                label2.Content = Number1;
            }
            else
            {
                Number2 += "9";
                label2.Content = Number2;
            }

        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            flag = "/";
            label2.Content = flag;
            
        }

        private void button19_Click(object sender, RoutedEventArgs e)
        {
            flag = "*";
            label2.Content = flag;
            
        }

        private void button20_Click(object sender, RoutedEventArgs e)
        {
            flag = "-";
            label2.Content = flag;
        }

        private void button21_Click(object sender, RoutedEventArgs e)
        {
            flag = "+";
            label2.Content = flag;
        }

        private void button22_Click(object sender, RoutedEventArgs e)
        {
            switch(flag)
            {

                case "+": result = Convert.ToDouble(Number1) + Convert.ToDouble(Number2);
                          label2.Content = result;
                          expression.Add(Number1+"+"+Number2+"="+result);
                          Number1 = "";
                          Number2="";
                          flag="";
                          break;
                case "-": result = Convert.ToDouble(Number1) - Convert.ToDouble(Number2);
                        label2.Content = result;
                        expression.Add(Number1+"-"+Number2+"="+result); 
                          Number1 = "";
                          Number2="";
                          flag="";
                          break;
                case "*": result = Convert.ToDouble(Number1) * Convert.ToDouble(Number2);
                        label2.Content = result;
                        expression.Add(Number1+"*"+Number2+"="+result); 
                          Number1 = "";
                          Number2="";
                          flag="";
                          break;
                case "/": result = Convert.ToDouble(Number1) / Convert.ToDouble(Number2);
                          label2.Content = result;
                          expression.Add(Number1+"/"+Number2+"="+result); 
                          Number1 = "";
                          Number2="";
                          flag="";
                          break;
                case "%": result = Convert.ToDouble(Number1) % Convert.ToDouble(Number2);
                          label2.Content = result;
                          expression.Add(Number1 + "%" + Number2 + "=" + result);
                          Number1 = "";
                          Number2 = "";
                          flag = "";
                          break;

               
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            label2.Content = "0";
            Number1 = "";
            Number2 = "";
            flag = "";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            label2.Content = "0";
            Number1 = "";
            Number2 = "";
            flag = "";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            result = Math.Pow(Convert.ToDouble(Number1), -1);
            label2.Content = result;
            expression.Add(1 + "/" + Number1 + "=" + result);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            result = Math.Pow(Convert.ToDouble(Number1),2);
            label2.Content = result;
            expression.Add( Number1+"的平方" + "=" + result);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            result = Math.Pow(Convert.ToDouble(Number1),0.5);
            label2.Content = result;
            expression.Add("根号下" + Number1 + "=" + result);
        }

     

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FileStream f = new FileStream("历史记录.txt", FileMode.OpenOrCreate);
            StreamWriter s = new StreamWriter(f);
            foreach (string a in expression)
            {
                s.WriteLine(a);
            }
            s.Close();
        }

        private void button24_Click(object sender, RoutedEventArgs e)
        {
            if (flag == "")
            {
                Number1 += ".";
                label2.Content = Number1;
            }
            else
            {
                Number2 += ".";
                label2.Content = Number2;
            }
        }

        private void button25_Click(object sender, RoutedEventArgs e)
        {
            if (flag == "")
            {
                Number1 += ".";
                label2.Content = Number1;
            }
            else
            {
                Number2 += ".";
                label2.Content = Number2;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            flag = "%";
            label2.Content = flag;
            
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            label2.Content = "0";
            Number1 = "";
            Number2 = "";
            flag = "";
        }

       
       



 

  


   



     

       
    }
}
