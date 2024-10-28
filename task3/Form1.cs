namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            String message = "";
            if ((e.Button == MouseButtons.Right) && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                message = "Вы нажали правую кнопку мыши+CTRL.";
               // ModifierKeys

            }
            if (e.Button == MouseButtons.Left)
            {
                message = "Вы нажали левую кнопку мыши.";
            }
            message += "\n" + "Координаты мыши: х=" + e.X.ToString() + ";y = " + e.Y.ToString();

            //выведем сообщение в диалоговое окно
            String caption = "Клик мыши";
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
