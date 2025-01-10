using InteractiveMuseumExhibit.ContentItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveMuseumExhibit
{
    public class PowerManagementSystem
    {
        private PowerManagementSystemModes _mode;
        public PowerManagementSystem()
        {
            _mode = PowerManagementSystemModes.StandBy;
        }

        public void GoActivatedMode()
        {
            _mode = PowerManagementSystemModes.Activated;
        }

        public void GoStandByMode()
        {
            _mode |= PowerManagementSystemModes.StandBy;
        }
    }
}
