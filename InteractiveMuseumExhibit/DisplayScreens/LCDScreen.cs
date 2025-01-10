using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InteractiveMuseumExhibit.ContentItems;

namespace InteractiveMuseumExhibit.DisplayScreens
{
    public class LCDScreen : DisplayScreen
    {
        public override ContentItemTypes[] SupportedContentItemTypes => new ContentItemTypes[]
        {
            ContentItemTypes.Image,
            ContentItemTypes.Text,
        };
    }
}
