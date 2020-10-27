using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBoxCount.Text);
            dataGridViewArray.ColumnCount = count;
            dataGridViewArray.RowCount = 1;
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                dataGridViewArray.Columns[i].HeaderCell.Value = i.ToString();
                dataGridViewArray[i, 0].Value = rnd.Next(10, 100);
                dataGridViewArray.Columns[i].Width = 35;
            }
    }

        private void buttonAvg_Click(object sender, EventArgs e)
        {
            char[] M = new char[10];
            char sym;
            int i;
            bool f;
            f = false;
            for (i = 0; i < 10; i++)
                if (M[i] == sym)
                    f = true;
        }
    }
