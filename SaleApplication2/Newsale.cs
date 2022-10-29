using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleApplication2.Models;
namespace SaleApplication2
{

    
    public partial class Newsale : Form
    {
       
      

        public Newsale()
        {
            InitializeComponent();
        }

        private void Newsale_Load(object sender, EventArgs e)
        {
            String[] ad = { "Meat", "Chicken", "Cheese", "Chocalate" };
            comboBox1_name.Items.AddRange(ad);
        }
        static List<string> product_list;
        private void SaxlaButton_Click(object sender, EventArgs e)
        {
            ProductData productData = new ProductData(comboBox1_name.Text, Convert.ToInt32(textBox1_quantity.Text),Convert.ToInt32(textBox2_cost.Text));
            product_list = new List<string>()
            {
                productData.Ad,
                productData.Quantity.ToString(),
                productData.Cost.ToString(),
                productData.Summary.ToString()
            };
            Form1 form1 = new Form1(product_list);
            this.Close();
        }

       
        private void ImtinaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

