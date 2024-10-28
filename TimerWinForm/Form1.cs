namespace TimerWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Enabled = false;
            MessageBox.Show("Таймер отработал!", "Таймер");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Количество секунд                 должно быть больше 0!");
            return;
            }
            //
            button2.Enabled = true;
            timer1.Interval = Decimal.ToInt32(numericUpDown1.Value) * 1000;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Таймер не успел             отработать!", "Таймер");
            button2.Enabled = false;
        }
    }
}
