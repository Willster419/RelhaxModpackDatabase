using System.Windows;
using System.Windows.Input;

namespace RelhaxDescriptionDesigner.Designs.TheIllusion
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Designs.TheIllusion.PmodIMAGE1 pmodAuthorImage = new Designs.TheIllusion.PmodIMAGE1();
            pmodAuthorImage.Show();
        }

        private void CloseWindow_CanExec(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;

        private void CloseWindow_Exec(object sender, ExecutedRoutedEventArgs e) => SystemCommands.CloseWindow(this);

        private void Click_PMOD_ReplayFreecam(object sender, RoutedEventArgs e)
        {
            Designs.TheIllusion.PMOD_ReplayFreecam pmodReplayFreecam = new Designs.TheIllusion.PMOD_ReplayFreecam();
            pmodReplayFreecam.Show();
        }
        private void Click_PMOD_ServerReticle(object sender, RoutedEventArgs e)
        {
            Designs.TheIllusion.PMOD_ServerReticle pmodServerReticle = new Designs.TheIllusion.PMOD_ServerReticle();
            pmodServerReticle.Show();
        }
        private void Click_PMOD_PenMarkers(object sender, RoutedEventArgs e)
        {
            Designs.TheIllusion.PMOD_PenMarkers pmodPenMarker = new Designs.TheIllusion.PMOD_PenMarkers();
            pmodPenMarker.Show();
        }
        private void Click_PMOD_HPPools(object sender, RoutedEventArgs e)
        {
            Designs.TheIllusion.PMOD_HPPools pmodHPPools = new Designs.TheIllusion.PMOD_HPPools();
            pmodHPPools.Show();
        }
    }
}
