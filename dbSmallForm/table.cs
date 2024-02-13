using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbSmallForm
{
    public class table
    {
        public List<List<cell>> cells = new List<List<cell>>();
        public table() { }
        public table(int c,int r) 
        { 
            for(int i =  0; i < c; i++)
            {
                cells.Add(new List<cell>());
                for (int j = 0; j < r; j++)
                {
                    cells[i].Add(new cell("_","string",1));

                }
            }
        }
    }
}
