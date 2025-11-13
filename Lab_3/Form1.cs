using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double a = 0;
        private double b = 0;
        private string action = "";
        private bool is_calculated = false;

        //Ввод чисел в textbox
        public void btn_num_click(object sender, EventArgs e)
        {
            if (is_calculated)
            {
                output_textbox.Clear();
                is_calculated = false;
                output_textbox.Text += ((Button)sender).Text;
            }
            else
            {
                output_textbox.Text += ((Button)sender).Text;
            }
        }
        
        //Удаление последнего введенного символа
        public void btn_del_last(object sender, EventArgs e)
        {
            string str = "";
            for(int i = 0; i < output_textbox.Text.Length - 1; i++)
            {
                str += output_textbox.Text[i];
            }
            output_textbox.Text = str;
        }

        //Инициализация действия в примере
        private void btn_action_click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(output_textbox.Text);
                action = ((Button)sender).Text;
                output_textbox.Clear();
            }
            catch (FormatException)  //Если нажали на одно действие, а потом сразу на другое - берем последнее.
            {
                action = ((Button)sender).Text;
            }
            catch
            {
                MessageBox.Show("Работать можно только с числами!");
            }
        }

        //Функция подсчета введенного примера
        private void btn_calculate(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToDouble(output_textbox.Text);

                switch (action)
                {
                    case "+":
                        output_textbox.Text = (a + b).ToString();
                        break;
                    case "-":
                        output_textbox.Text = (a - b).ToString();
                        break;
                    case "x":
                        output_textbox.Text = (a * b).ToString();
                        break;
                    case "/":
                        output_textbox.Text = (a / b).ToString();
                        break;
                    case "^":
                        output_textbox.Text = Math.Pow(a, b).ToString();
                        break;
                }
                is_calculated = true;
            }
            catch
            {
                MessageBox.Show($"Ошибка в операции '{action}'");
            }
        }

        //Удалить все из textbox
        private void btn_delete(object sender, EventArgs e)
        {
            is_calculated = false;
            output_textbox.Clear();
            a = 0;
            b = 0;
        }
    }
}
