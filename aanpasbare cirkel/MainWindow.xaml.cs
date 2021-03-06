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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace aanpasbare_cirkel
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

       

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cirkel.Width = HorizentalSlider.Value;
            HorizentalSlider.Maximum = 350;
                

        }

        private void VerticalSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            cirkel.Height = VerticalSlider.Value;
            VerticalSlider.Maximum = 240;

        }

        private void SliderX_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cirkel.Margin = new Thickness(SliderX.Value, SliderY.Value, 0, 0);
            SliderX.Maximum = 250;
        }

        private void SliderY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cirkel.Margin = new Thickness(SliderX.Value, SliderY.Value, 0, 0);
            SliderY.Maximum = 130;
        }
    }

}
