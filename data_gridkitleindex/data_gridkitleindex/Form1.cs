using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_gridkitleindex
{
    public partial class Form1 : Form
    {
        double k;
        double b;
        double hesap;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            
            for (int i = 0; i <= 100; i++)
            {
                dataGridView1.Rows.Add();
                k = rnd.Next(45,150);
                b = rnd.Next(135,215);
                b = b / 100; 
                hesap = (k) / (b * b);
                dataGridView1.Rows[i].Cells[0].Value = k;
                dataGridView1.Rows[i].Cells[1].Value = b;
                dataGridView1.Rows[i].Cells[2].Value = hesap;
               if (hesap < 18.5)
                {

                    dataGridView1.Rows[i].Cells[3].Value = "zayıf";

                }
                else if (18.5 <= hesap && hesap < 25)
                {
                    dataGridView1.Rows[i].Cells[3].Value = "normal";
                }
                else if (25 <= hesap && hesap < 30)
                {
                    dataGridView1.Rows[i].Cells[3].Value = "fazla kilolu";
                }
                else if (30 <= hesap && hesap < 40)
                {
                    dataGridView1.Rows[i].Cells[3].Value = "obez";
                }
                else
                {
                    dataGridView1.Rows[i].Cells[3].Value = "Aşırı obez";
                }
              
            }
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }
}
