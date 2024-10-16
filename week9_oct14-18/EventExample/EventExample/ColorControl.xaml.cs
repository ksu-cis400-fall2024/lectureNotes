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

namespace EventExample
{
    /// <summary>
    /// Interaction logic for ColorControl.xaml
    /// </summary>
    public partial class ColorControl : UserControl
    {
        public event EventHandler<ColorEventArgs>? ChangeColor;

        public ColorControl()
        {
            InitializeComponent();
        }

        public void ClickColor(object sender, RoutedEventArgs e)
        {
            //goal: display "Red" or "Blue" in the TextBlock in the main window
            //button names are "RedButton" and "BlueButton"

            //I want to change something in MainWindow

            if (sender is Button b)
            {
                if (b.Name == "RedButton")
                {
                    ChangeColor?.Invoke(this, new ColorEventArgs("Red"));
                }
                else if (b.Name == "BlueButton")
                {
                    ChangeColor?.Invoke(this, new ColorEventArgs("Blue"));
                }
            }

            
        }
    }
}
