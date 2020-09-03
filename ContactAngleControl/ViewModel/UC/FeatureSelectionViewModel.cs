using ContactAngleControl.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAngleControl.ViewModel.UC
{
    public class FeatureSelectionViewModel : ViewModelBase
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

        private IList<ModuleGroup> _listGroupsData = new List<ModuleGroup>();

        /// <summary>
        /// 表单数据
        /// </summary>
        public IList<ModuleGroup> ListGroupsData
        {
            get { return _listGroupsData; }
            set
            {
                _listGroupsData = value;
                RaisePropertyChanged();
            }
        }
        private IList<string> curGroups = new List<string>();
        private IList<string> curGroupsData = new List<string>();


        public FeatureSelectionViewModel()
        {
            InitUi();
        }

        private void InitUi()
        {
            try
            {

                curGroups = new List<string>
                {
                    "Circle fitting",
                 "Elliptic fitting",
                  "LY - AP fitting",
                   "LY - SD fitting",
                    "The experimental diagram of contact Angle is automatically fitted",
                     "Manual fitting of contact Angle",
                      "Three point fitting circle",
                       "Five points fit the ellipse",
            };
                foreach (var item in curGroups)
                {
                    ModuleGroup moduleGroup = new ModuleGroup() { GroupName = item };
                    ListGroups.Add(moduleGroup);
                }

                curGroupsData = new List<string>
                {
                    "Automatic baseline fitting (default)",
                    "Manually fit the horizontal/tilt baseline",
                    "Manually fitting the surface baseline",
                    "Surface tension",
                    "Automatic fitting test",
                    "The surface tension diagram was fitted automatically",
                    "Wettability analysis",
                    "Surface energy"
                };
                foreach (var item in curGroupsData)
                {
                    ModuleGroup moduleGroup = new ModuleGroup() { GroupName = item };
                    ListGroupsData.Add(moduleGroup);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
