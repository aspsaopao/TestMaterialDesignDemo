using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace TestMaterialDesignDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Rect rc = SystemParameters.WorkArea; //获取工作区大小
            //this.Left = 0; //设置位置
            //this.Top = 0;
            //this.Width = rc.Width;
            //this.Height = rc.Height;
            this.WindowState = System.Windows.WindowState.Maximized;

            //DataContext = new DialogsViewModel();
            //this.WindowStyle = System.Windows.WindowStyle.None;
        }
        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            //DialogHost.CloseDialogCommand.Execute(null, null);
            this.PopupAddCustom.IsOpen = this.PopupAddCustom.IsOpen ? false : true;
        }
        private void GridTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.PopupAddCustom.IsOpen = false;

        }
    
        private void GridMenu_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            gdMian.Margin = new Thickness(e.NewSize.Width, 50, 0, 0);
        }

        private void ListViewItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
        }
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
            //this.MenuItem.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            //this.MenuItem.Visibility = Visibility.Visible;
        }

        private void PackIcon_MouseUp1(object sender, MouseButtonEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }
        private void ButtonCloseMenu_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }
        private void Sample1_DialogHost_OnDialogClosing(object sender, DialogClosingEventArgs eventArgs)
        {

            //you can cancel the dialog close:
            //eventArgs.Cancel();

            if (!Equals(eventArgs.Parameter, true))
                return;

            //if (!string.IsNullOrWhiteSpace(FruitTextBox.Text))
            //    FruitListBox.Items.Add(FruitTextBox.Text.Trim());
        }

        // Used for DialogHost.DialogClosingAttached
        private void Sample2_DialogHost_OnDialogClosing(object sender, DialogClosingEventArgs eventArgs)
            => Debug.WriteLine($"SAMPLE 2: Closing dialog with parameter: {eventArgs.Parameter ?? string.Empty}");

        private void Sample5_DialogHost_OnDialogClosing(object sender, DialogClosingEventArgs eventArgs)
        {
            Debug.WriteLine($"SAMPLE 5: Closing dialog with parameter: {eventArgs.Parameter ?? string.Empty}");

            //you can cancel the dialog close:
            //eventArgs.Cancel();

            if (!Equals(eventArgs.Parameter, true))
                return;
        }

        private void ImageBrush_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

    }
}
