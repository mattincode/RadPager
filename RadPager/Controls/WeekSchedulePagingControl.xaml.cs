using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace RadPager.Controls
{
    public partial class WeekSchedulePagingControl : UserControl
    {
        //public static readonly DependencyProperty PageIndexProperty = DependencyProperty.Register("PageIndex", typeof(int), typeof(UserControl), new PropertyMetadata(null, null));
        //public int PageIndex    
        //{
        //    get { return (int)GetValue(PageIndexProperty); }
        //    set { SetValue(PageIndexProperty, value); }
        //}

        public WeekSchedulePagingControl()
        {
            InitializeComponent();
        }
    }
}
