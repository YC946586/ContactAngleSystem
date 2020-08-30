using ContactAngleControl.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAngleControl.ViewModel.UC
{
    public class ContactAngleViewModel : ViewModelBase
    {
        private IList<ModuleGroup> _listGroups = new List<ModuleGroup>();

        /// <summary>
        /// 表单数据
        /// </summary>
        public IList<ModuleGroup> ListGroups
        {
            get { return _listGroups; }
            set
            {
                _listGroups = value;
                RaisePropertyChanged();
            }
        }
        private IList<string> curGroups = new List<string>();


        private RelayCommand _SaveCommand;

        /// <summary>
        /// baocun
        /// </summary>
        public RelayCommand SaveCommand
        {
            get
            {
                if (_SaveCommand == null)
                {
                    _SaveCommand = new RelayCommand(Save);
                }
                return _SaveCommand;
            }
        }

        private void Save()
        {
            var dd = ListGroups.Where(s => s.Check);
        }

        public ContactAngleViewModel()
        {
            InitUi();
        }

        private void InitUi()
        {
            try
            {
                curGroups = new List<string>
                {
                    "The left contact Angle",
                    "Right contact Angle",
                    "Differential contact Angle",
                    "Evaluation contact Angle",
                    "A few lines of inclination",
                    "Minimum contact Angle",
                    "Maximum contact Angle",
                    "The standard deviatio",
                    "Forward contact Angle",
                    "Backward contact Angle",
                    "Lag Angle",
                    "Rolling Angle",
                    "Droplet size",
                    "Droplet diameter"
                };
                foreach (var item in curGroups)
                {
                    ModuleGroup moduleGroup = new ModuleGroup() {  GroupName=item};
                    ListGroups.Add(moduleGroup);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
