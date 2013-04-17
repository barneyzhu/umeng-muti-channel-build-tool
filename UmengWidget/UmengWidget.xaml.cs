﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using UIControls;

namespace UmengWidget
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UmengWidget : UserControl
    {
        public UmengWidget()
        {
            InitializeComponent();

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SplitScreen split = new SplitScreen(this.button, new Point(0, 0), this.bg);

            //parse xaml and set to split screen

            split.setView(new AdsDetails());

            this.float_layer.Children.Add(split);
        }

    }
}
