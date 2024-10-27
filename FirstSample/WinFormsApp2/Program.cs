namespace WinFormsApp2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        static DialogResult ShowMessageBoxes()
        {
            //показ окна, отображающего текстовое
            //сообщение и кнопку ОК
            String message = "Окно, отображающее текстовое сообщение";
            MessageBox.Show(message);
            //показ окна с текстом и двумя кнопками
            //OK и CANCEL
            message = "Окно с текстом и двумя кнопками OK и CANCEL";
            String caption = "Окно с двумя кнопками";
            DialogResult result = MessageBox.
            Show(message, caption,
            MessageBoxButtons.OKCancel);
            String button = result.ToString();
        
    
    //показ Окна с тремя кнопками и какой-то
    //иконкой
    result = MessageBox.Show("Вы нажали кнопку"+ button+ ". Повторить?",button, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
        return result;
        }
         [STAThread]
    static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            DialogResult result;
            do
            {
                result = ShowMessageBoxes();
            } while (result == DialogResult.Retry);
           // Application.Run(new Form1());




        }
    }
}