using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text;


namespace Energy_Cons_DW_BI
{
    public partial class Form1 : Form
    {
        List<Shop_Dim> storeList;
        List<Store_Data> storeData;
        DatabaseHandler handler;

        DateTime date;

        private const double co2 = 990.0;
        private const double nox = 4.19;
        private const double sox = 7.93;
        private const double part = 0.31;
        private const double water = 1.37;

        public Form1()
        {
            InitializeComponent();
            storeList = new List<Shop_Dim>();
            storeData = new List<Store_Data>();
            handler = new DatabaseHandler();
        }

        private double calcEmissions(double emissionVal, double factor)
        {
            return (emissionVal / 1000) * factor;
        }

        private async void addListItems(List<Store_Data> storeList )
        {
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
        private string monthName(int val)
        {
            string monthName = "";

            switch (val)
            {
                case 1 : monthName = "January";
                    break;
                case 2 : monthName = "February";
                    break;
                case 3 : monthName = "March";
                    break;
                case 4 : monthName = "April";
                    break;
                case 5 : monthName = "May";
                    break;
                case 6 : monthName = "June";
                    break;
                case 7 : monthName = "July";
                    break;
                case 8 : monthName = "August";
                    break;
                case 9 : monthName = "September";
                    break;
                case 10 : monthName = "October";
                    break;
                case 11 : monthName = "November";
                    break;
                case 12 : monthName = "December";
                    break;
            }

            return monthName;
        }

        private async void storesCVSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDiag = new OpenFileDialog();

            if (openDiag.ShowDialog() == DialogResult.OK)
            {
                var csvLines = File.ReadLines(openDiag.FileName);

                var linesData = csvLines.Skip(1).Select(i => i.Split(',').ToArray());

                storeList = linesData.Select(i => new Shop_Dim(i[0].Trim(), i[1].Trim(), i[2].Trim())).ToList();

                listBox1.Items.Clear();

                foreach (var item in storeList)
                {
                    await Task.Delay(1);
                    listBox1.Items.Add(listBox1.Items.Count + "\t" + item.SHOP_CODE + "\t" + item.SHOP_NAME + "\t" + item.SHOP_LOCATION + "\n");
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                }
            }
        }

        private void storeDataCVSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openDiag = new OpenFileDialog();

            if (openDiag.ShowDialog() == DialogResult.OK)
            {
                var csvLines = File.ReadLines(openDiag.FileName);

                var linesData = csvLines.Skip(1).Select(i => i.Split(',').ToArray());

                storeData = linesData.Select(i => new Store_Data(i[0].Trim(), i[1].Trim(), Convert.ToDouble(i[2].Trim()), Convert.ToDouble(i[3].Trim()), Convert.ToDouble(i[4].Trim()), Convert.ToDouble(i[2].Trim()) - (Convert.ToDouble(i[3].Trim()) + Convert.ToDouble(i[4].Trim())))).ToList();

                listBox1.Items.Clear();

                #region Add StoreData objects into listBox1
                /*foreach (var dataItem in storeData)
                {
                    await Task.Delay(1);

                    listBox1.Items.Add(listBox1.Items.Count + "\t" + dataItem.SHOP_CODE + "\t" + dataItem.SHOP_NAME + "\t\t" + dataItem.SHOP_LOCATION + "\t\t" + dataItem.KWH_MAIN);
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                }*/
                #endregion

                #region Date Test Code
                var testVals = (from z in storeData
                                select z)
                                .Take(100);

                StringBuilder sb = new StringBuilder();

                foreach (var t in testVals)
                {
                    date = DateTime.ParseExact(t.LOG_TIMESTAMP, "yyyy/MM/dd HH:mm", CultureInfo.InvariantCulture);

                    sb.Append("=".PadLeft(95, '=') + "\n");
                    sb.Append("Day is : " + date.Day + "\n");
                    sb.Append("Day of week is " + date.DayOfWeek + "\n");
                    sb.Append("Hour of day: " + date.Hour + "\n");
                    sb.Append("Time of day: " + date.TimeOfDay + "\n");
                    sb.Append("Date Month: " + date.Month + "\n");
                    sb.Append("Year: " + date.Year + "\n");
                }

                richTextBox1.Text = sb.ToString();
                #endregion
            }
        }

        private  void readFromListsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private async void truncateTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var list = storeData.Where(x => storeList.Any(y => x.SHOP_CODE == y.SHOP_CODE));

            #region Junk Code
            /*var joinedList = from first in storeList
                             join second in storeData                             
                             on first.SHOP_CODE equals second.SHOP_CODE
                             
                             select second;*/
            #endregion

            //Delete this projection to select all objects from StoreData -- IMPORTANT!!!
            //var thousandVals = (from x in storeData
              //                  select x
                //               ).Take(100);

            listBox1.Items.Clear();

            handler = new DatabaseHandler();

            foreach (var item in storeList)
            {
                string code = item.SHOP_CODE;

                var matchedList = storeData.Where(x => x.SHOP_CODE == code);

                foreach (var dataItem in matchedList)
                {
                    await Task.Delay(1);
                    dataItem.SHOP_NAME = item.SHOP_NAME;
                    dataItem.SHOP_LOCATION = item.SHOP_LOCATION;

                    date = DateTime.ParseExact(dataItem.LOG_TIMESTAMP, "yyyy/MM/dd HH:mm", CultureInfo.InvariantCulture);

                    Console.WriteLine(date.TimeOfDay);

                    handler.insertData(dataItem.SHOP_CODE, dataItem.SHOP_NAME, dataItem.SHOP_LOCATION, date.TimeOfDay.ToString(), date.DayOfWeek.ToString(), date.Day.ToString(), monthName(date.Month), date.Year.ToString(), "Main", dataItem.KWH_MAIN, calcEmissions(dataItem.KWH_MAIN, co2), calcEmissions(dataItem.KWH_MAIN, nox), calcEmissions(dataItem.KWH_MAIN, sox), calcEmissions(dataItem.KWH_MAIN, part), calcEmissions(dataItem.KWH_MAIN, water), 20);
                    handler.insertData(dataItem.SHOP_CODE, dataItem.SHOP_NAME, dataItem.SHOP_LOCATION, date.TimeOfDay.ToString(), date.DayOfWeek.ToString(), date.Day.ToString(), monthName(date.Month), date.Year.ToString(), "Bakery", dataItem.KWH_BAKERY, calcEmissions(dataItem.KWH_BAKERY, co2), calcEmissions(dataItem.KWH_BAKERY, nox), calcEmissions(dataItem.KWH_BAKERY, sox), calcEmissions(dataItem.KWH_BAKERY, part), calcEmissions(dataItem.KWH_BAKERY, water), 20);
                    handler.insertData(dataItem.SHOP_CODE, dataItem.SHOP_NAME, dataItem.SHOP_LOCATION, date.TimeOfDay.ToString(), date.DayOfWeek.ToString(), date.Day.ToString(), monthName(date.Month), date.Year.ToString(), "Refrigeration", dataItem.KWH_REFRIG, calcEmissions(dataItem.KWH_REFRIG, co2), calcEmissions(dataItem.KWH_REFRIG, nox), calcEmissions(dataItem.KWH_REFRIG, sox), calcEmissions(dataItem.KWH_REFRIG, part), calcEmissions(dataItem.KWH_REFRIG, water), 20);
                    handler.insertData(dataItem.SHOP_CODE, dataItem.SHOP_NAME, dataItem.SHOP_LOCATION, date.TimeOfDay.ToString(), date.DayOfWeek.ToString(), date.Day.ToString(), monthName(date.Month), date.Year.ToString(), "Other", dataItem.KWH_OTHER, calcEmissions(dataItem.KWH_OTHER, co2), calcEmissions(dataItem.KWH_OTHER, nox), calcEmissions(dataItem.KWH_OTHER, sox), calcEmissions(dataItem.KWH_OTHER, part), calcEmissions(dataItem.KWH_OTHER, water), 20);

                    listBox1.Items.Add(listBox1.Items.Count + "\t" + dataItem.SHOP_CODE + "\t" + dataItem.SHOP_NAME + "\t\t" + dataItem.SHOP_LOCATION + "\t\t" + dataItem.KWH_MAIN);
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to exit?","Exit Dialog",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}