using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet result;
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog() { Filter = "Excel Work Book 97-2003|*.xls|Excel Workbook|* .xlsx", ValidateNames = true })
            {
                if (of.ShowDialog() == DialogResult.OK)
                {

                    FileStream fs = File.Open(of.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader;
                    if (of.FilterIndex == 1)
                        reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    else
                        reader = ExcelReaderFactory.CreateOpenXmlReader(fs);

                    result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true  
                        }

                    });

                    comboBox1.Items.Clear();
                    foreach (DataTable dt in result.Tables)
                    {
                        comboBox1.Items.Add(dt.TableName);

                    }
                    reader.Close();


                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
  
                dataGridView1.DataSource = result.Tables[comboBox1.SelectedIndex];    
        }
    }
}
