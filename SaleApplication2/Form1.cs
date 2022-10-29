using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleApplication2
{
    public partial class Form1 : Form
    {
        Newsale sale = new Newsale();
        public Form1()
        {
            InitializeComponent();
            listView1_mehsul.Columns.Add("Ad", 200);
            listView1_mehsul.Columns.Add("Qiymət", 200);
            listView1_mehsul.Columns.Add("Miqdar", 200);
            listView1_mehsul.Columns.Add("Cəm", 200);

        }


        public static List<string> product_gelen2;
        public Form1(List<string> product_gelen1)
        {
            product_gelen2 = product_gelen1;

    
        }

        public void Add(List<string> ls)
        {
            ListViewItem listViewItem = new ListViewItem(ls[0]);
            ls.RemoveAt(0);
            foreach (var item in ls)
            {
                listViewItem.SubItems.Add(item);
            }
            listView1_mehsul.Items.Add(listViewItem);
        }

        private void yeniButton_Click(object sender, EventArgs e)
        {
            Newsale sale = new Newsale();
            sale.ShowDialog();
            if(product_gelen2!=null)Add(product_gelen2);

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

       
        private void kayitSayi()
        {
            int kayitsayi = listView1_mehsul.Items.Count;
            label1.Text = Convert.ToString(kayitsayi);
        }


    }
}
