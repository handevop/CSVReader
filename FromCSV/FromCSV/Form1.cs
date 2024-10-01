using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LumenWorks.Framework.IO.Csv;
using System.IO;

namespace FromCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable csvTable , pomocni;

        public DataTable ReverseRowsInDataTable(DataTable inputTable)
        {
            DataTable outputTable = inputTable.Clone();

            for (int i = inputTable.Rows.Count - 1; i >= 0; i--)
            {
                outputTable.ImportRow(inputTable.Rows[i]);
            }

            return outputTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text.Trim() != string.Empty)
                {
                    DataView dv = new DataView(csvTable);
                    dv.RowFilter = "Name like '%" + textBox1.Text + "%'";
                    dataGridView1.DataSource = dv;
                }
                else
                {
                    csvTable = pomocni;
                    dataGridView1.DataSource = csvTable;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    csvTable.DefaultView.Sort = "Name ASC";
                }
                else
                {
                    csvTable.DefaultView.Sort = "Name DESC";
                }
            }
            else if (radioButton2.Checked)
            {
                if (textBox1.Text.Trim() != string.Empty)
                {
                    DataView dv = new DataView(csvTable);
                    dv.RowFilter = "Author like '%" + textBox1.Text + "%'";
                    dataGridView1.DataSource = dv;
                }
                else
                {
                    csvTable = pomocni;
                    dataGridView1.DataSource = csvTable;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    csvTable.DefaultView.Sort = "Author ASC";
                }
                else
                {
                    csvTable.DefaultView.Sort = "Author DESC";
                }
            }
            else if (radioButton3.Checked)
            {
                if (textBox1.Text.Trim() != string.Empty)
                {
                    DataView dv = new DataView(csvTable);
                    dv.RowFilter = "'User rating' like '%" + textBox1.Text + "%'";
                    dataGridView1.DataSource = dv;
                }
                else
                {
                    csvTable = pomocni;
                    dataGridView1.DataSource = csvTable;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    csvTable.DefaultView.Sort = "User rating ASC";
                }
                else
                {
                    csvTable.DefaultView.Sort = "User rating DESC";
                }
            }
            else if (radioButton4.Checked)
            {
                if (textBox1.Text.Trim() != string.Empty)
                {
                    DataView dv = new DataView(csvTable);
                    dv.RowFilter = "Reviews like '%" + textBox1.Text + "%'";
                    dataGridView1.DataSource = dv;
                }
                else
                {
                    csvTable = pomocni;
                    dataGridView1.DataSource = csvTable;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    csvTable.DefaultView.Sort = "Reviews ASC";
                }
                else
                {
                    csvTable.DefaultView.Sort = "Reviews DESC";
                }
            }
            else if (radioButton5.Checked)
            {
                if (textBox1.Text.Trim() != string.Empty)
                {
                    DataView dv = new DataView(csvTable);
                    dv.RowFilter = "Price like '%" + textBox1.Text + "%'";
                    dataGridView1.DataSource = dv;
                }
                else
                {
                    csvTable = pomocni;
                    dataGridView1.DataSource = csvTable;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    csvTable.DefaultView.Sort = "Price ASC";
                }
                else
                {
                    csvTable.DefaultView.Sort = "Price DESC";
                }
            }
            else if (radioButton6.Checked)
            {
                if (textBox1.Text.Trim() != string.Empty)
                {
                    DataView dv = new DataView(csvTable);
                    dv.RowFilter = "Year like '%" + textBox1.Text + "%'";
                    dataGridView1.DataSource = dv;
                }
                else
                {
                    csvTable = pomocni;
                    dataGridView1.DataSource = csvTable;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    csvTable.DefaultView.Sort = "Year ASC";
                }
                else
                {
                    csvTable.DefaultView.Sort = "Year DESC";
                }
            }
            if (radioButton7.Checked)
            {
                if (textBox1.Text.Trim() != string.Empty)
                {
                    DataView dv = new DataView(csvTable);
                    dv.RowFilter = "Genre like '%" + textBox1.Text + "%'";
                    dataGridView1.DataSource = dv;
                }
                else
                {
                    csvTable = pomocni;
                    dataGridView1.DataSource = csvTable;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    csvTable.DefaultView.Sort = "Genre ASC";
                }
                else
                {
                    csvTable.DefaultView.Sort = "Genre DESC";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"C:\Users\Antonio\Desktop\knjige.csv")), true))
            {
                csvTable.Load(csvReader);
            }
            pomocni = csvTable;
            dataGridView1.DataSource = csvTable;
        }
    }
}
