using ContactAngleControl.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAngleControl.ViewModel.UC
{
    public class SurfaceTensionViewModel : ViewModelBase
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


        public SurfaceTensionViewModel()
        {
            InitUi();
        }

        private void InitUi()
        {
            try
            {
                curGroups = new List<string>
                {
                    "Density difference",
                    "Size amplification",
                    "Maximum width of droplet",
                    "Droplet calibration width",
                    "Amplification factor",
                    "SurfaceTension",
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
