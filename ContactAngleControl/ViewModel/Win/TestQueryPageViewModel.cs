using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAngleControl.ViewModel.UC
{
    public  class TestQueryPageViewModel: ViewModelBase
    {
        private string _SelectTab;

        /// <summary>
        /// 选中
        /// </summary>
        public string SelectTab
        {
            get { return _SelectTab; }
            set
            {
                _SelectTab = value;
                RaisePropertyChanged();
            }
        }
        private IList<string> _listGroups = new List<string>();

        /// <summary>
        /// 表单数据
        /// </summary>
        public IList<string> ListGroups
        {
            get { return _listGroups; }
            set
            {
                _listGroups = value;
                RaisePropertyChanged();
            }
        }

        public TestQueryPageViewModel()
        {
            ListGroups = new List<string>
            {
                "AngleQuerySystem",
                "TensionQuerySystem",
                "SurfaceEnergQuerySystem"
            };
        }
    }
}
