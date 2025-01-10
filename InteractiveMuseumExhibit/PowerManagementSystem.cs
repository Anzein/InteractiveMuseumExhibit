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
        private PowerManagementSystemModes _currentMode;

        public PowerManagementSystem()
        {
            _currentMode = PowerManagementSystemModes.StandBy;
        }

        public void GoActivatedMode()
        {
            _currentMode = PowerManagementSystemModes.Activated;
        }

        public void GoStandByMode()
        {
            _currentMode = PowerManagementSystemModes.StandBy;
        }
    }
}
