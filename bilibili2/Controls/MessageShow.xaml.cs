﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace bilibili2
{
    public sealed partial class MessageShow : UserControl
    {
        public MessageShow()
        {
            this.InitializeComponent();
        }
        public async void Show(string content, int showTime)
        {
            grid_GG.Visibility = Visibility.Visible;
            txt_GG.Text = content;
            await Task.Delay(showTime);
            grid_GG.Visibility = Visibility.Collapsed;
        }
    }
}
