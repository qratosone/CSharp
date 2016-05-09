using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace UWP03
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        public Library library = new Library();
        private void new_Click(object sender, RoutedEventArgs e)
        {
            Email.Text = string.Empty;
            Website.Text = string.Empty;
            Telephone.Text = string.Empty;
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            Email.Text = library.LoadSetting("Email");
            Website.Text = library.LoadSetting("Website");
            Telephone.Text = library.LoadSetting("Telephone");
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            library.SaveSetting("Email", Email.Text);
            library.SaveSetting("Website", Website.Text);
            library.SaveSetting("Telephone", Telephone.Text);
        }
    }
}
