using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InteractiveMuseumExhibit.ContentItems;
using InteractiveMuseumExhibit.DisplayScreens;

namespace InteractiveMuseumExhibit
{
    public class ExhibitConsole
    {
        private DisplayScreen[] _displayScreens;
        private PowerManagementSystem _powerManagementSystem;

        public ExhibitConsole(int fixedNumberOfDisplayScreens)
        {
            if (fixedNumberOfDisplayScreens <= 0)
            {
                throw new ArgumentException("Fixed number of display screens must be positive.");
            }

            _displayScreens = new DisplayScreen[fixedNumberOfDisplayScreens];
            _powerManagementSystem = new PowerManagementSystem();
        }

        public void TurnOn()
        {
            _powerManagementSystem.GoActivatedMode();
        }

        public void TurnOff()
        {
            _powerManagementSystem.GoStandByMode();
        }

        public void AddDisplayScreen(int displayScreenIndex, DisplayScreen displayScreen)
        {
            ValidateDisplayScreenIndex(displayScreenIndex);

            if (_displayScreens[displayScreenIndex] == null)
            {
                _displayScreens[displayScreenIndex] = displayScreen;
            }          
        }

        public void ReplaceDisplayScreenByIndex(int displayScreenIndex, DisplayScreen displayScreen)
        {
            ValidateDisplayScreenIndex(displayScreenIndex);

            if (_displayScreens[displayScreenIndex] != null)
            {
                _displayScreens[displayScreenIndex] = displayScreen;
            }               
        }

        private void ValidateDisplayScreenIndex(int displayScreenIndex)
        {
            if (displayScreenIndex < 0 || displayScreenIndex > _displayScreens.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Invalid dipslay index!");
            }
        }

        public List<DisplayScreen> ListAllDisplayScreensByContentItemType(ContentItemTypes contentItemType)
        {
            List<DisplayScreen> resultDisplayScreens = new List<DisplayScreen>();

            foreach (var screen in _displayScreens)
            {
                if (screen == null)
                {
                    continue;
                }

                foreach (var contentItem in screen.GetContentItems())
                {
                    if (contentItem.GetContentItemType() == contentItemType)
                    {
                        resultDisplayScreens.Add(screen);
                    }
                }
            }

            return resultDisplayScreens;
        }
    }
}
