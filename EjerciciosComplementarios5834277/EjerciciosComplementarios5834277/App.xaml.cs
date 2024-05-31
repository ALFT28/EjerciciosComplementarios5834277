
using Microsoft.Maui.Controls.PlatformConfiguration;

namespace EjerciciosComplementarios5834277
{
    /// <summary>
    /// 
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// 
        /// </summary>
        public App()
        {
            InitializeComponent();

            MainPage = new TabbPage();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="activationState"></param>
        /// <returns></returns>
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var windows = base.CreateWindow(activationState);

            windows.Height = 690;
            windows.Width = 835;

            return windows;

        }

    }
}
