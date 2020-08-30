using ContactAngleControl.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAngleControl.ViewModel.UC
{
    public class SurfaceEnergyViewModel : ViewModelBase
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


        public SurfaceEnergyViewModel()
        {
            InitUi();
        }

        private void InitUi()
        {
            try
            {
                curGroups = new List<string>
                {
                    "Contact Angle1",
                    "Contact Angle2",
                    "Contact Angle3",
                    "Solid polar componen",
                    "Dispersion component of solid",
                    "Solid hydrogen bonding force",
                    "solid van der Waals component",
                    "solid Lewis acid component",
                    "lewis base component of the solid",
                    "Solid surface energy",
                    "Estimation method"
                };
                foreach (var item in curGroups)
                {
                    ModuleGroup moduleGroup = new ModuleGroup() { GroupName = item };
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
