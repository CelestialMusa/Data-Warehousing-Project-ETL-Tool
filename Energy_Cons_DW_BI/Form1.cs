using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Energy_Cons_DW_BI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            List<Store_Data> storeList = new List<Store_Data>();
            
            if(op.ShowDialog() == DialogResult.OK)
            {
                var csvLines = File.ReadLines(op.FileName);

                var linesData = csvLines.Skip(1).Select(i => i.Split(',').ToArray());
                
                storeList = linesData.Select(i => new  Store_Data(i[0].Trim(), i[1].Trim(), Convert.ToDouble(i[2].Trim()), Convert.ToDouble(i[3].Trim()), Convert.ToDouble(i[4].Trim()), Convert.ToDouble(i[2].Trim())-(Convert.ToDouble(i[3].Trim())+ Convert.ToDouble(i[4].Trim())))).ToList();
                
                try
                {
                    foreach (var store in storeList)
                    {
                        await Task.Delay(1);
                        listBox1.Items.Add(listBox1.Items.Count + "\t" + store.SHOP_CODE + " " + store.LOG_TIMESTAMP + " " + store.KWH_MAIN + " " + store.KWH_REFRIG + " " + store.KWH_BAKERY + " " + store.KWH_OTHER + "\n");
                        listBox1.TopIndex = listBox1.Items.Count - 1;
                    }
                }
                catch (Exception)
                {
                    ;
                }
            }
        }
    }
}
