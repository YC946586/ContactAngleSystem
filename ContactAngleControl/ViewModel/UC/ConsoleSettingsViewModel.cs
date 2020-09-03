using ContactAngleControl.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAngleControl.ViewModel.UC
{
    public class ConsoleSettingsViewModel: ViewModelBase
    {

        private ObservableCollection<ModuleGroup> _listGroups = new ObservableCollection<ModuleGroup>();

        /// <summary>
        /// 表单数据
        /// </summary>
        public ObservableCollection<ModuleGroup> ListGroups
        {
            get { return _listGroups; }
            set
            {
                _listGroups = value;
                RaisePropertyChanged();
            }
        }
        public ConsoleSettingsViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                ModuleGroup module = new ModuleGroup() { GroupName="TEST"+i,GroupId=i.ToString()};
                ListGroups.Add(module);
            }
        }
    }
}
