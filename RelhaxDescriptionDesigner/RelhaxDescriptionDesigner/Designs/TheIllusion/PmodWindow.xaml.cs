﻿using System;
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
    }
}
