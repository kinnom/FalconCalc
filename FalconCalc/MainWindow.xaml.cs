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

namespace FalconCalc
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

        private void NumberKeyClick(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hello world");
            if (sender is Button button)
              TopDisplay.Text = TopDisplay.Text + (string)button.Content;
        }

        private void SpecialKeyClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if ((string)button.Content == "Back")
                {
                    if (TopDisplay.Text.EndsWith("Ans"))
                        TopDisplay.Text = TopDisplay.Text.Remove(TopDisplay.Text.Length - 3);
                    else
                        if (TopDisplay.Text.Length != 0) TopDisplay.Text = TopDisplay.Text.Remove(TopDisplay.Text.Length - 1);
                }

            }
        }
    }
}
