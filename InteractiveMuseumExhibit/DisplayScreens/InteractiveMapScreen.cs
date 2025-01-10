using InteractiveMuseumExhibit.ContentItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveMuseumExhibit.DisplayScreens
{
    public class InteractiveMapScreen : DisplayScreen
    {
        public override ContentItemTypes[] SupportedContentItemTypes => new ContentItemTypes[]
        {
            ContentItemTypes.Map,
            ContentItemTypes.Interactive_Geographical_Data,
        };
    }
}
