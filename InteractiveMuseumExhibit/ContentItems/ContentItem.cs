using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveMuseumExhibit.ContentItems
{
    public class ContentItem
    {
        private readonly string _title;
        private readonly string _topic;
        private readonly ContentItemDataSizes _itemDataSize;
        private readonly ContentItemTypes _itemType;

        public ContentItem(string title, string topic, ContentItemDataSizes itemDataSize, ContentItemTypes itemType)
        {
            _title = title;
            _topic = topic;
            _itemDataSize = itemDataSize;
            _itemType = itemType;
        }

        public ContentItemTypes GetContentItemType()
        {
            return _itemType;
        }

        public string GetTitle()
        {
            return _title;
        }
    }
}
