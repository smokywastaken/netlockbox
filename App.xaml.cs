namespace Lockbox
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            /*
             * if (flag):
             *      LockPage = new AppShell();
             * else 
             *      SetupView = new AppShell();
             */
        }
    }
}
