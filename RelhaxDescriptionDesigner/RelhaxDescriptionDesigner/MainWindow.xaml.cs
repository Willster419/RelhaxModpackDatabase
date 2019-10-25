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

namespace RelhaxDescriptionDesigner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WillstersFirstWindow_Click(object sender, RoutedEventArgs e)
        {
            Designs.Willster419.FirstFlowDocument firstFlowDocument = new Designs.Willster419.FirstFlowDocument();
            firstFlowDocument.Show();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.ToString());
        }

        private void PMOD_Click(object sender, RoutedEventArgs e)
        {
            Designs.TheIllusion.PMOD.PmodWindow pmod = new Designs.TheIllusion.PMOD.PmodWindow();
            pmod.Show();
        }
        private void StarTrek_Click(object sender, RoutedEventArgs e)
        {
            Designs.TheIllusion.StarTrek.StarTrekMainWindow starTrek = new Designs.TheIllusion.StarTrek.StarTrekMainWindow();
            starTrek.Show();
        }
        private void CA_Click(object sender, RoutedEventArgs e)
        {
            Designs.TheIllusion.ColourApparatus.ColourApparatus colourApparatus = new Designs.TheIllusion.ColourApparatus.ColourApparatus();
            colourApparatus.Show();
        }

    }
}