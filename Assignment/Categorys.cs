using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Categorys
    {
        public string Name { get; set; }
        public List<Products> Products { get; set; }

        internal static IEnumerable<object> Select(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
