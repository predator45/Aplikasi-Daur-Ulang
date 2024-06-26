

using System;
using Aplikasi_daur_ulang;


namespace Aplikasi_daur_ulang
{
    internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Application.Run(new LoginForm());
        Application.Run(new RegisterForm());
        Application.Run(new HomeForm());
        Application.Run(new AboutForm());
        Application.Run(new PlasticRecyclingForm());
        Application.Run(new PaperRecyclingForm());
        Application.Run(new OilRecyclingForm());
        Application.Run(new GlassRecyclingForm());
        Application.Run(new FabricRecyclingForm());
        Application.Run(new ElectronicsRecyclingForm());
    }
}
}