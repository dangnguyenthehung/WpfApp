using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TronDeTracNghiem.Class
{
    public class ContentList
    {
        public List<ContentListItem> items { get; set; }
    }

    public class ContentListItem
    {
        public ContentListItem()
        {

        }

        public ContentListItem(string[] _content_after_random, int _index)
        {
            content_after_random = _content_after_random;
            index = _index;
        }
        public string[] content_after_random { get; set; }
        public int index { get; set; }
    }
}
