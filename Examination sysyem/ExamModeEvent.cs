using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_sysyem
{
    public enum modeType
    {
        starting,
        Queued,
        Finishing
    }
       
    public class ExamModeEvent
    {
        public event Action<modeType> modeDelegate;
        public modeType Mode {
            get {
                return Mode; 
            }
            set {
                Mode = value;
                OnModeChanged(Mode);
            } 
        }

        public  virtual void OnModeChanged(modeType mode)
        {
            if(modeDelegate != null)
            {
                modeDelegate?.Invoke(mode);
            }
        }

    }
}
