using static System.Net.Mime.MediaTypeNames;

namespace WindowsForms_WPF
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}