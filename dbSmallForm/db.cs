using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace dbSmallForm
{
    public class db
    {
        public List<table> tables = new List<table>();
        public List<query> querys = new List<query>();
        public List<Form> forms = new List<Form>();
        public db() { }
        public bool addNewTable(int c, int r)
        {
            this.tables.Add(new table(c, r));
            return true;
        }
        public bool addNewQuery(string q)
        {
            this.querys.Add(new query(q));
            return true;
        }
        public bool addNewForm()
        {
            this.forms.Add(new Form());
            return true;
        }
        public bool drawTable( Form f,int indexoftable, int c, int r ,ref TextBox t)
        {
            for (int i = 0; i < c; i++)
            {
                
                for (int j = 0; j < r; j++)
                {
                    t.Text += tables[indexoftable].cells[i][j].value;
                    t.Text += "\r\t";
                }
                t.Text += "\r\n";
            }
            return true;
        }
    }
}
