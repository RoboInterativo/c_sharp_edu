namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = "Координаты мыши: х=" + e.X.ToString() + ";y = " + e.Y.ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //определим какую кнопку мыши нажал пользователь
            String message = "";
            if (e.Button == MouseButtons.Right)
            {
                message = "Вы нажали правую кнопку мыши.";
            }
            if (e.Button == MouseButtons.Left)
            {
                message = "Вы нажали левую кнопку мыши.";
            }
            message += "\n" + "Координаты мыши: х=" + e.X.ToString() + ";y = " + e.Y.ToString();
        
        //выведем сообщение в диалоговое окно
        String caption = "Клик мыши";
         DialogResult result= MessageBox.Show(message, caption,        MessageBoxButtons.OK,        MessageBoxIcon.Information);
        }
    }
}
