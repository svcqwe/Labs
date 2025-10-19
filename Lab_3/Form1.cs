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

        private void btn_num_click(object sender, EventArgs e)
        {
            if (is_calculated)
            {
                richTextBox1.Clear();
                is_calculated = false;
                richTextBox1.Text += ((Button)sender).Text;
            }
            else
            {
                richTextBox1.Text += ((Button)sender).Text;
            }
        }

        private void btn_action_click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(richTextBox1.Text);
                action = ((Button)sender).Text;
                richTextBox1.Clear();
            }
            catch
            {
                MessageBox.Show("Работать можно только с числами!");
            }
        }
        private void btn_calculate(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToDouble(richTextBox1.Text);

                switch (action)
                {
                    case "+":
                        richTextBox1.Text = (a + b).ToString();
                        break;
                    case "-":
                        richTextBox1.Text = (a - b).ToString();
                        break;
                    case "*":
                        richTextBox1.Text = (a * b).ToString();
                        break;
                    case "/":
                        richTextBox1.Text = (a / b).ToString();
                        break;
                    case "^":
                        richTextBox1.Text = Math.Pow(a, b).ToString();
                        break;
                }
                is_calculated = true;
            }
            catch
            {
                MessageBox.Show($"Ошибка в операции '{action}'");
            }
        }

        private void btn_delete(object sender, EventArgs e)
        {
            is_calculated = false;
            richTextBox1.Clear();
            a = 0;
            b = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
           
        }





        

    }
}
