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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            for (i = 0; i < MaxN; i++)
                if (A[i] > 0)
                    sum = sum + A[i];
        }
    }
