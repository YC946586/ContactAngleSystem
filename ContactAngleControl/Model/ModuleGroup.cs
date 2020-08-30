using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAngleControl.Model
{
    /// <summary>
    /// 模块组
    /// </summary>
    public class ModuleGroup : ViewModelBase
    {
        private string groupid;
        private string _groupIcon = "";
        private string groupName;
        private bool _check;
        private bool _checkDel;
        /// <summary>
        /// 模块ICO
        /// </summary>
        public string GroupIcon
        {
            get { return _groupIcon; }
            set { _groupIcon = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 父模块ID
        /// </summary>
        public string GroupId
        {
            get { return groupid; }
            set { groupid = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 父模块名称
        /// </summary>
        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 選擇
        /// </summary>
        public bool Check
        {
            get { return _check; }
            set { _check = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 選擇刪除
        /// </summary>
        public bool CheckDel
        {
            get { return _checkDel; }
            set { _checkDel = value; RaisePropertyChanged(); }
        }

    }
}
