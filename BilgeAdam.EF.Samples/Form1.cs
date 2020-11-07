using BilgeAdam.EF.Contracts;
using BilgeAdam.EF.Data.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.EF.Samples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public NorthwindContext Context { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Bu ders için böyle kullandık normalde dispose edilmesi gerek veya using ile kullanılmalı
            Context = new NorthwindContext();
        }

        private void msbProduct_Consumed_Click(object sender, EventArgs e)
        {
            dgvResult.DataSource = null;
            var result = Context.Products
                                .Where(i => i.UnitsInStock == 0)
                                .Select(p => new ProductStockDto
                                {
                                    Name = p.ProductName,
                                    Price = p.UnitPrice
                                })
                                .ToList();


            dgvResult.DataSource = result;
        }
    }
}
