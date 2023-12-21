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

namespace NSMusicS.UserControlLibrary.MusicPlayer_Main
{
    /// <summary>
    /// MusicPlayer_Model_3_Singer_UserControl.xaml 的交互逻辑
    /// </summary>
    public partial class MusicPlayer_Model_3_Singer_UserControl : UserControl
    {
        public MusicPlayer_Model_3_Singer_UserControl()
        {
            InitializeComponent();
        }

        public void ListView_For_Album_Performer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {

        }

        private void ListView_For_Album_Performer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            /*var scrollViewer = GetScrollViewer(ListView_For_Album_Performer);
            if (scrollViewer != null)
            {
                if (0 - e.Delta > 0)
                    scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset + 1);
                else
                    scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset - 1);

                e.Handled = true;
            }*/
        }
        public static ScrollViewer GetScrollViewer(DependencyObject o)
        {
            if (o is ScrollViewer scrollViewer)
            {
                return scrollViewer;
            }

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(o); i++)
            {
                var child = VisualTreeHelper.GetChild(o, i);
                var result = GetScrollViewer(child);
                if (result != null)
                {
                    return result;
                }
            }

            return null;
        }

    }
}
