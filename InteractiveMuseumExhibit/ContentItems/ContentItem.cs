﻿using System;
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
        private readonly ContentItemDataSizes _dataSize;
        private readonly ContentItemTypes _itemType;

        public ContentItem(string title, string topic, ContentItemDataSizes dataSize, ContentItemTypes itemType)
        {
            _title = title;
            _topic = topic;
            _dataSize = dataSize;
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