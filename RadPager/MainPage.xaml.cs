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
using RadPager.Controls;

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
    private ObservableCollection<LoadChunk> _pages;

    private ObservableCollection<ItemX> _itemXs;
    private LoadChunk _currentPage;

    public TestVm()
    {
        var pos = 1000;
        var list = new List<ItemX>();
        var chunkList = new List<LoadChunk>();
        for (int i = 0; i < 100; i++)
        {
            list.Add(new ItemX() { Text1 = i.ToString(), Text2 = "Namn" + i.ToString() });
            var start = pos;
            var end = start + 2;
            var peIds = new List<int>() { start, start + 1, start + 2 };
            pos = end + 1;
            chunkList.Add(new LoadChunk() { StartPlanningUnitId = start, EndPlanningUnitId = end, StartPlanningUnitNumber = start.ToString(), EndPlanningUnitNumber= end.ToString(), PlanningUnitIds = peIds});
        }
        ItemXs = new ObservableCollection<ItemX>(list);
        PagesCollection = new ObservableCollection<LoadChunk>(chunkList);
        CurrentPage = PagesCollection[0];
    }

    public ObservableCollection<ItemX> ItemXs
    {
        get { return _itemXs; }
        set { _itemXs = value; RaisePropertyChanged(() => ItemXs);}
    }

    public ObservableCollection<LoadChunk> PagesCollection
    {
        get { return _pages; }
        set { _pages = value; RaisePropertyChanged(() => PagesCollection); }
    }

    public LoadChunk CurrentPage
    {
        get { return _currentPage; }
        set { _currentPage = value; RaisePropertyChanged(() => CurrentPage); }
    }
}

public class ItemX
{
    public string Text1 { get; set; }
    public string Text2 { get; set; }
}
