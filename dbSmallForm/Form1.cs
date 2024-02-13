using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbSmallForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public db dbf = new db();
        public float cellw;
        public float cellh;

        public double pc;
        public double pr;

        private void Form1_Load(object sender, EventArgs e)
        {
           

            dbf.addNewTable(10, 10);



            cellw = (this.textBox1.Width / dbf.tables[0].cells.Count);
            cellh = this.textBox1.Font.Size;




            dbf.tables[0].cells[0][0].value = "razvan";
            dbf.tables[0].cells[0][0].datatype = "string";
            dbf.tables[0].cells[0][0].length = dbf.tables[0].cells[0][0].value.Length;

            dbf.tables[0].cells[0][1].value = "alex";
            dbf.tables[0].cells[0][1].datatype = "string";
            dbf.tables[0].cells[0][1].length = dbf.tables[0].cells[0][0].value.Length;

            dbf.tables[0].cells[2][2].value = "claudiu";
            dbf.tables[0].cells[2][2].datatype = "string";
            dbf.tables[0].cells[2][2].length = dbf.tables[0].cells[0][0].value.Length;

            dbf.tables[0].cells[9][3].value = "tibi";
            dbf.tables[0].cells[9][3].datatype = "string";
            dbf.tables[0].cells[9][3].length = dbf.tables[0].cells[0][0].value.Length;

            dbf.tables[0].cells[7][4].value = "maria";
            dbf.tables[0].cells[7][4].datatype = "string";
            dbf.tables[0].cells[7][4].length = dbf.tables[0].cells[0][0].value.Length;

            dbf.tables[0].cells[5][5].value = "neculai";
            dbf.tables[0].cells[5][5].datatype = "string";
            dbf.tables[0].cells[5][5].length = dbf.tables[0].cells[0][0].value.Length;

            dbf.tables[0].cells[3][6].value = "roxana";
            dbf.tables[0].cells[3][6].datatype = "string";
            dbf.tables[0].cells[3][6].length = dbf.tables[0].cells[0][0].value.Length;

            dbf.tables[0].cells[1][7].value = "andrada";
            dbf.tables[0].cells[1][7].datatype = "string";
            dbf.tables[0].cells[1][7].length = dbf.tables[0].cells[0][0].value.Length;


            this.Text = dbf.tables[0].cells[0][0].value;
            this.Text += ",";
            this.Text += dbf.tables[0].cells[0][0].datatype;
            this.Text += ",";
            this.Text += dbf.tables[0].cells[0][0].length.ToString();
            dbf.addNewQuery("SELECT * FROM tabels[0] where datatype = string;");
            dbf.drawTable(this, 0, 10, 10, ref this.textBox1);

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {

             pc = (Math.Floor(e.X / cellw));
             pr = (Math.Floor((e.Y / cellh) / 2));

            this.textBox2.Text = e.X.ToString();
            this.textBox3.Text = e.Y.ToString();
            this.textBox4.Text = pc.ToString();
            this.textBox5.Text = pr.ToString();
            this.textBox6.Text = dbf.tables[0].cells[(int)pc][(int)pr].value;
            this.textBox7.Text = dbf.tables[0].cells[(int)pc][(int)pr].datatype;
            this.textBox8.Text = dbf.tables[0].cells[(int)pc][(int)pr].length.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dbf.tables[0].cells[(int)pc][(int)pr].value = this.textBox6.Text;
            dbf.tables[0].cells[(int)pc][(int)pr].datatype = this.textBox7.Text;
            dbf.tables[0].cells[(int)pc][(int)pr].length = int.Parse(this.textBox8.Text);

            textBox1.Clear();
            dbf.drawTable(this, 0, 10, 10, ref this.textBox1);
        }
    }
}
