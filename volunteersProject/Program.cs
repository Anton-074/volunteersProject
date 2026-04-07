namespace volunteersProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool exitProgram = false;

            while (!exitProgram)
            {
                using (var formLogin = new FormRegistration())
                {
                    if (formLogin.ShowDialog() == DialogResult.OK)
                    {
                        using (var formEvents = new FormEvent(formLogin.CurrentUser, formLogin.IsGuest))
                        {
                            if (formEvents.ShowDialog() == DialogResult.Cancel)
                            {
                                continue;
                            }
                            else
                            {
                                exitProgram = true;
                            }
                        }
                    }
                    else
                    {
                        exitProgram = true;
                    }
                }
            }
        }
    }
}