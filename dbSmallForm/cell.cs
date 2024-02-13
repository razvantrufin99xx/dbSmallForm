using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbSmallForm
{
    public class cell
    {
        public string value;
        public string datatype;
        public int length;
        public cell() { }
        public cell(string pvalue, string pdataype, int plength) 
        { 
            this.value = pvalue;
            this.datatype = pdataype;
            this.length = plength;
        }
    }
}
