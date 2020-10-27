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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
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
            const int MaxN = 10;
            int[] A = new int[MaxN];

            int i;
            int sum = 0;

            i = 0;
            do
            {
                if (A[i] > 0)
                    sum += A[i];
                i++;
            }
            while (i < MaxN);
        }
    }
