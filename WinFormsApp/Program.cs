using System.Windows.Forms;

namespace WinFormsApp
{

    internal static class Program
    {
       

        [STAThread]
        static void Main()
        {

            using var db = new ApplicationContext();

            ApplicationConfiguration.Initialize();
            Application.Run(new Auth());
        }
    }
}