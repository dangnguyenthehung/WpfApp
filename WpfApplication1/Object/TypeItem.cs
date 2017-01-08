using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TronDeTracNghiem.Object
{
    public class TypeItem
    {
        public string text { get; set; }
        public string value { get; set; }

        public TypeItem(string text, string value)
        {
            this.text = text;
            this.value = value;
        }

        public override string ToString()
        {
            return text;
        }
    }
}
