using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAngleModel.ViewModel
{
    public class UCFooterViewModel : BaseModel
    {

        private string hardwareStatus;
        public string HardwareStatus
        {
            get { return hardwareStatus; }
            set
            {
                hardwareStatus = value;
                RaisePropertyChanged("HardwareStatus");
            }
        }


        private string runningStatus;
        public string RunningStatus
        {
            get { return runningStatus; }
            set
            {
                runningStatus = value;
                RaisePropertyChanged("RunningStatus");
            }
        }


        private int videoCurrentFrame;
        public int VideoCurrentFrame
        {
            get { return videoCurrentFrame; }
            set
            {
                videoCurrentFrame = value;
                RaisePropertyChanged("VideoCurrentFrame");
            }
        }

        private int allFrame;
        public int AllFrame
        {
            get { return allFrame; }
            set
            {
                allFrame = value;
                RaisePropertyChanged("AllFrame");
            }
        }
    }
}
