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
    public partial class Form1 : Form
    {
        public Form1()
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
                dataGridViewArray[i, 0].Value = rnd.Next(10,100);
                dataGridViewArray.Columns[i].Width = 35;
            }
        }

        private void buttonAvg_Click(object sender, EventArgs e)
        {
            int arr =new int[dataGridViewArray.ColumnCount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(dataGridViewArray[i, 0].Value.ToString());
            }
            double res = 0;
            for (int i = 0; i < arr.Length; i++)
                res += arr[i];
            res /= arr.Lenght;
            labelAvgValue.Text = res.ToString();
            labelAvg.Visible = true;
            labelAvgValue.Visible = true;
        }
    }
}
