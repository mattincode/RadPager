using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using RadPager;

namespace RadPager
{
    public partial class MainPage : UserControl
    {
        TestVm _vm;
        public MainPage()
        {
            InitializeComponent();
            _vm = new TestVm();
            DataContext = _vm;
        }
    }
}

public class TestVm : BaseViewModel
{
    private ObservableCollection<ItemX> _itemXs;

    public TestVm()
    {
        var list = new List<ItemX>();
        for (int i = 0; i < 100; i++)
        {
            list.Add(new ItemX() { Text1 = i.ToString(), Text2 = "Namn" + i.ToString() });
        }
        _itemXs = new ObservableCollection<ItemX>(list);
    }

    public ObservableCollection<ItemX> ItemXs
    {
        get { return _itemXs; }
        set { _itemXs = value; RaisePropertyChanged(() => ItemXs);}
    }
}

public class ItemX
{
    public string Text1 { get; set; }
    public string Text2 { get; set; }
}
