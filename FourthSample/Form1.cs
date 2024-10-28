namespace FourthSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToLongTimeString();
            //закрепление обработчика
            //timer1.Tick += new EventHandler(ShowTime);
            //установка интервала времени
            timer1.Interval = 500;
            timer1.Start();
        
           

    
    //стартуем таймер
}

    private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
