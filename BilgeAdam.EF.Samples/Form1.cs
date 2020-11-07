using BilgeAdam.EF.Contracts;
using BilgeAdam.EF.Data.Context;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BilgeAdam.EF.Samples
{
    public partial class Form1 : Form
    {
        private int index = 0;
        private readonly int capacity = 10;
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
            index = 0;
            dgvResult.DataSource = null;
            var result = Context.Products
                                .Where(i => i.UnitsInStock == 0)
                                .Select(p => new ProductStockDto
                                {
                                    Name = p.ProductName,
                                    Price = p.UnitPrice
                                })
                                .OrderBy(i => i.Name)
                                .Skip(index * capacity)
                                .Take(capacity)
                                .ToList();


            dgvResult.DataSource = result;
        }

        private void msbProducts_Milk_Click(object sender, EventArgs e)
        {
            index = 0;
            dgvResult.DataSource = null;
            var result = Context.Products
                                .Where(i => i.CategoryID == 4)
                                .Select(p => new ProductStockDto
                                {
                                    Name = p.ProductName,
                                    Price = p.UnitPrice
                                })
                                .OrderBy(i => i.Name)
                                .Skip(index * capacity)
                                .Take(capacity)
                                .ToList();


            dgvResult.DataSource = result;
        }

        private void msbProducts_All_Click(object sender, EventArgs e)
        {
            index = 0;
            dgvResult.DataSource = null;
            var result = Context.Products
                                .Select(p => new ProductDto
                                {
                                    Name = p.ProductName,
                                    Price = p.UnitPrice,
                                    CategoryName = p.Category.CategoryName,
                                    Company = p.Supplier.CompanyName,
                                    Stock = p.UnitsInStock
                                })
                                .OrderBy(i => i.Name)
                                .Skip(index * capacity)
                                .Take(capacity)
                                .ToList();


            dgvResult.DataSource = result;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            index++;
        }
    }
}
