using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RelhaxDescriptionDesigner.Designs.TheIllusion.StarTrek
{
    /// <summary>
    /// Interaction logic for StarTrekMainWindow.xaml
    /// </summary>
    public partial class StarTrekMainWindow : Window
    {
        public StarTrekMainWindow()
        {
            InitializeComponent();
        }
        private void CloseWindow_CanExec(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;

        private void CloseWindow_Exec(object sender, ExecutedRoutedEventArgs e) => SystemCommands.CloseWindow(this);
        private void Click_ST_Crew(object sender, RoutedEventArgs e)
        {
            ST_Crew stCrew = new ST_Crew();
            stCrew.Show();
        }
        private void Click_ST_Camo(object sender, RoutedEventArgs e)
        {
            ST_Camo stCamo = new ST_Camo();
            stCamo.Show();
        }
        private void Click_ST_LoadingScreen(object sender, RoutedEventArgs e)
        {
            ST_LoadingScreens stLoad = new ST_LoadingScreens();
            stLoad.Show();
        }
        private void Click_ST_GunSounds(object sender, RoutedEventArgs e)
        {
            ST_GunSounds stGun = new ST_GunSounds();
            stGun.Show();
        }
    }
}
