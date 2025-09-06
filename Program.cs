namespace EventDriven.Project.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using (FormLogin loginForm = new FormLogin())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FormMain());
                }
                else
                {
                    Application.Exit();
                }
            }
           
        }
    }
}