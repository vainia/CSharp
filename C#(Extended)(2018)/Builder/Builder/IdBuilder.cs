using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class IdBuilder
    {
        public string EmptyValue { get;  set; }
        public string Delimiter { get; set; }

        private HashSet<long> list = new HashSet<long>();
        public IdBuilder(string EmptyValue = "null", string Delimiter = ", ")
        {
            this.EmptyValue = EmptyValue;
            this.Delimiter = Delimiter;
        }
        public void Clear() { list.Clear(); }
        public void Add(long id) { list.Add(id); }
        public override string ToString()
        {
            if (list.Count <= 0) return EmptyValue;
            StringBuilder sb = new StringBuilder();

            /* 
            bool first = true;
            foreach(long id in list)
            {
                if (first) first = false;
                else sb.Append(",");
                sb.Append(id);
            }
            return sb.ToString();
            */

            /* 
            foreach (long id in list)
            {
                sb.Append(",").Append(id);
            }
            return sb.ToString().Substring(1);
            */

            return string.Join(Delimiter, list).ToString();
        }
    }
}
