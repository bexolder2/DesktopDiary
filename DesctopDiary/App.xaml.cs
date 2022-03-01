using DesktopDiary.View;
using System;
using System.Windows;

namespace DesktopDiary
{
    public partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();
        }

        [STAThread]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public static void Main()
        {
            App app = new App();

            MainWindow window = new MainWindow();
            //window.DataContext = presenter;

            app.Run(window);
        }
    }
}
