using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP212_Week05_CreateDatabaseConsole
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Name { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}
