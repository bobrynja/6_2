using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                if (n <= 0) MessageBox.Show("Размер массива не может быть неположительным");
                else
                { 
                    
                    
                        double[] arr = new double[n];
                        string[] a = textBox2.Text.Split(' ');
                        if (a.Length > n) MessageBox.Show("Вы ввели больше числе, чем необходиом, данные будут обрезаны!!!");
                        for (int i = 0; i < n; i++)
                        {
                            arr[i] = Convert.ToDouble(a[i]);
                        }

                        double num = 0; //само максимальное число
                        int number = 0; //номер максимального числа
                        for (int i = 0; i < n; i++)
                        {
                            if (arr[i] >= num)
                            {
                                num = arr[i];
                                number = i + 1;
                            }
                        }
                        textBox3.Text = "Номер последнего максимального числа - " + number;
                    
                }
            
            }
            catch { MessageBox.Show("Некорректный ввод данных"); }
        }
    }
}
