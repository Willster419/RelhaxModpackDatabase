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
using System.Windows.Navigation;
using System.Windows.Shapes;
using RelhaxDescriptionDesigner.Designs;

namespace RelhaxDescriptionDesigner.Designs.TheIllusion.PMOD
{
    /// <summary>
    /// Interaction logic for PmodWindow.xaml
    /// </summary>
    public partial class PmodWindow : Window
    {
        public PmodWindow()
        {
            InitializeComponent();
        }

        private void CloseWindow_CanExec(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;

        private void CloseWindow_Exec(object sender, ExecutedRoutedEventArgs e) => SystemCommands.CloseWindow(this);

        private void Click_PMOD_ReplayFreecam(object sender, RoutedEventArgs e)
        {
            PMOD_ReplayFreecam pmodReplayFreecam = new PMOD_ReplayFreecam();
            pmodReplayFreecam.Show();
        }
        private void Click_PMOD_ServerReticle(object sender, RoutedEventArgs e)
        {
            PMOD_ServerReticle pmodServerReticle = new PMOD_ServerReticle();
            pmodServerReticle.Show();
        }
        private void Click_PMOD_PenMarkers(object sender, RoutedEventArgs e)
        {
            PMOD_PenMarkers pmodPenMarker = new PMOD_PenMarkers();
            pmodPenMarker.Show();
        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.ToString());
        }
    }
}
