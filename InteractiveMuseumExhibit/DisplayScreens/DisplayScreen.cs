using InteractiveMuseumExhibit.ContentItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveMuseumExhibit.DisplayScreens
{
    public abstract class DisplayScreen
    {
        private List<ContentItem> _contentItems;
        public abstract ContentItemTypes[] SupportedContentItemTypes { get; }

        protected DisplayScreen()
        {
            _contentItems = new List<ContentItem>();
        }

        public void AddContentItem(ContentItem contentItem)
        {
            if (!SupportedContentItemTypes.Contains(contentItem.GetContentItemType()))
            {
                throw new ArgumentException("Not supported content item type!");
            }
            _contentItems.Add(contentItem);
        }

        public IEnumerable<ContentItem> GetContentItems()
        {
            return _contentItems.AsReadOnly();
        }
    }
}
