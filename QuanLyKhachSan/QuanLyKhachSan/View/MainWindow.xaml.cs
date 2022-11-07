using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Media;
using System.Threading;
using MaterialDesignThemes.Wpf;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using System.IO;

namespace GUI.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        private void load_Windows(object sender, RoutedEventArgs e)
        {
            




        }

        private void lisviewMenu_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
        }

        private void click_ThayDoiAnh(object sender, RoutedEventArgs e)
        { 

        }

        private void btnDangXuat_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
