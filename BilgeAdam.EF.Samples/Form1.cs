using BilgeAdam.EF.Contracts;
using BilgeAdam.EF.Data.Context;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using BilgeAdam.EF.Samples.Extensions;

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
            Reset();
            var result = Context.Products
                                .Where(i => i.UnitsInStock == 0)
                                .Select(p => new ProductStockDto
                                {
                                    Name = p.ProductName,
                                    Price = p.UnitPrice
                                })
                                .Paginate(i => i.Name, index)
                                .ToList();


            dgvResult.DataSource = result;
        }

        private void msbProducts_Milk_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Products
                                .Where(i => i.CategoryID == 4)
                                .Select(p => new ProductStockDto
                                {
                                    Name = p.ProductName,
                                    Price = p.UnitPrice
                                })
                                .Paginate(i => i.Name, index)
                                .ToList();


            dgvResult.DataSource = result;
        }

        private void msbProducts_All_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Products
                                .Select(p => new ProductDto
                                {
                                    Name = p.ProductName,
                                    Price = p.UnitPrice,
                                    CategoryName = p.Category.CategoryName,
                                    Company = p.Supplier.CompanyName,
                                    Stock = p.UnitsInStock
                                })
                                .Paginate(i => i.Name, index)
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

        private void Reset()
        {
            index = 0;
            dgvResult.DataSource = null;
        }

        private void msbProduct_Beverages_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Products
                                .Where(f => f.CategoryID == 1)
                                //.Where(f => f.Category.CategoryName == "Beverages")
                                .Select(p => new ProductDto
                                {
                                    Name = p.ProductName,
                                    Price = p.UnitPrice,
                                    CategoryName = p.Category.CategoryName,
                                    Company = p.Supplier.CompanyName,
                                    Stock = p.UnitsInStock
                                })
                                .Paginate(i => i.Name, index)
                                .ToList();

            dgvResult.DataSource = result;
        }

        private void msbProduct_Expensives_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Products
                                .Where(f => f.UnitPrice > 50)
                                .Select(p => new ProductDto
                                {
                                    Name = p.ProductName,
                                    Price = p.UnitPrice,
                                    CategoryName = p.Category.CategoryName,
                                    Company = p.Supplier.CompanyName,
                                    Stock = p.UnitsInStock
                                })
                                .Paginate(i => i.Name, index)
                                .ToList();

            dgvResult.DataSource = result;
        }

        private void msbProducts_Discontinued_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Products
                                .Where(f => f.Discontinued)
                                .Select(p => new ProductDto
                                {
                                    Name = p.ProductName,
                                    Price = p.UnitPrice,
                                    CategoryName = p.Category.CategoryName,
                                    Company = p.Supplier.CompanyName,
                                    Stock = p.UnitsInStock
                                })
                                .Paginate(i => i.Name, index)
                                .ToList();

            dgvResult.DataSource = result;
        }

        private void msbCustomers_All_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Customers
                                .Select(c => new CustomerDto
                                {
                                    Code = c.CustomerID,
                                    Name = c.CompanyName,
                                    ContactPerson = c.ContactName,
                                    Country = c.Country,
                                    Phone = c.Phone
                                }).Paginate(o => o.Name, index)
                                .ToList();

            dgvResult.DataSource = result;
        }

        private void msbCustomers_Orders_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Orders
                                .Where(f => f.CustomerID == "ALFKI")
                                .Select(o => new CustomerOrderDto
                                {
                                    OrderCode = o.OrderID,
                                    OrderDate = o.OrderDate
                                }).Paginate(o => o.OrderDate, index)
                                .ToList();

            dgvResult.DataSource = result;
        }

        private void msbCustomersOrderAmounts_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Orders
                                .Where(f => f.CustomerID == "ALFKI")
                                .Select(m => new CustomerOrderPriceListDto
                                {
                                    OrderDate = m.OrderDate.Value,
                                    Detail = m.Order_Details.Select(od => new OrderDetailDto
                                    {
                                        Discount = od.Discount,
                                        Quantity = od.Quantity,
                                        Price = od.UnitPrice
                                    })
                                })
                                .Paginate(o => o.OrderDate, index)
                                .AsEnumerable()
                                .Select(r => new OrderPriceMappingDto
                                {
                                    OrderDate = r.OrderDate,
                                    Amount = r.Detail.Sum(s => s.Price * s.Quantity * (1M - (decimal)s.Discount))
                                })
                                .ToList();

            dgvResult.DataSource = result;
        }

        private void msbEmployee_All_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Employees
                                .Select(em => new EmployeeListDto
                                {
                                    FullName = em.FirstName + " " + em.LastName,
                                    City = em.City,
                                    HireDate = em.HireDate,
                                    Phone = em.HomePhone
                                }).Paginate(o => o.FullName, index)
                                .ToList();

            dgvResult.DataSource = result;
        }

        private void msbEmployee_Elders_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Employees
                                .Select(em => new EmployeeAgeDto
                                {
                                    FullName = em.FirstName + " " + em.LastName,
                                    Age = DateTime.Now.Year - em.BirthDate.Value.Year
                                })
                                .OrderByDescending(o => o.Age)
                                .Take(3)
                                .ToList();

            dgvResult.DataSource = result;
        }

        private void msbEmployee_Managers_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Employees
                                .Select(em => new EmployeeManagerDto
                                {
                                    FullName = em.FirstName + " " + em.LastName,
                                    Manager = em.Employee1.FirstName + " " + em.Employee1.LastName
                                })
                                .Paginate(o => o.FullName, index)
                                .ToList();

            dgvResult.DataSource = result;
        }

        private void msbSuppliers_All_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Suppliers
                                .Select(s => new SupplierDto
                                {
                                    Name = s.CompanyName,
                                    City = s.City,
                                    Country = s.Country,
                                    Manager = s.ContactName,
                                    Phone = s.Phone
                                })
                                .Paginate(o => o.Name, index)
                                .ToList();

            dgvResult.DataSource = result;
        }

        private void msbSupplier_Swedish_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Suppliers
                                .Where(f => f.Country == "Sweden")
                                .Select(s => new SupplierDto
                                {
                                    Name = s.CompanyName,
                                    City = s.City,
                                    Country = s.Country,
                                    Manager = s.ContactName,
                                    Phone = s.Phone
                                })
                                .Paginate(o => o.Name, index)
                                .ToList();

            dgvResult.DataSource = result;
        }

        private void msbOrder_CountOfYearlySell_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Orders
                                .GroupBy(g => g.OrderDate.Value.Year)
                                .Select(s => new YearlyOrderReportDto
                                {
                                    Year = s.Key,
                                    Count = s.Count(c => c.OrderDate.Value.Year == s.Key)
                                })
                                .Paginate(o => o.Year, index)
                                .ToList();

            dgvResult.DataSource = result;
        }

        private void msbOrder_Top10Customers_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Orders
                                .GroupBy(g => g.Customer.CompanyName)
                                .Select(s => new CustomerBuyReportDto
                                {
                                    Company = s.Key,
                                    Count = s.Count(c => c.Customer.CompanyName == s.Key)
                                })
                                .OrderByDescending(o => o.Count)
                                .Take(10)
                                .ToList();

            dgvResult.DataSource = result;
        }

        private void msbOrder_Top5Date_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Orders
                                .GroupBy(g => g.OrderDate.Value)
                                .Select(s => new DateOrderReportDto
                                {
                                    OrderDate = s.Key,
                                    Summary = s.SelectMany(od => od.Order_Details).Sum(t => t.Quantity * t.UnitPrice)
                                })
                                .OrderByDescending(o => o.Summary)
                                .Take(3)
                                .ToList();

            dgvResult.DataSource = result;
        }

        private void msbOrder_1997MonthlyReport_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Orders
                                .Where(f => f.OrderDate.Value.Year == 1997)
                                .GroupBy(g => g.OrderDate.Value.Month)
                                .Select(s => new MonthlyReportOfYearDto
                                {
                                    Month = s.Key,
                                    Summary = s.SelectMany(m => m.Order_Details).Sum(t => t.UnitPrice * t.Quantity)
                                })
                                .OrderBy(o => o.Month)
                                .ToList();

            dgvResult.DataSource = result;
            var frm = new frmGraphic(result);
            frm.ShowDialog();
        }

        private void msbOrderDetail_MostSoldByCount_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Order_Details
                                .GroupBy(g => g.Product.ProductName)
                                .Select(s => new ProductReportDto
                                {
                                    Name = s.Key,
                                    Value = s.Sum(t => t.Quantity)
                                })
                                .OrderByDescending(o => o.Value)
                                .Take(20)
                                .ToList();

            dgvResult.DataSource = result;
        }

        private void msbOrderDetail_MostSoldByPrice_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Order_Details
                                .GroupBy(g => g.Product.ProductName)
                                .Select(s => new ProductReportDto
                                {
                                    Name = s.Key,
                                    Value = s.Sum(t => t.Quantity * t.UnitPrice)
                                })
                                .OrderByDescending(o => o.Value)
                                .Take(20)
                                .ToList();

            dgvResult.DataSource = result;
        }

        private void msbOrderDetails_Compare_Click(object sender, EventArgs e)
        {
            Reset();
            var result = Context.Order_Details
                                .GroupBy(g => g.Product.ProductName)
                                .Select(s => new ComparedProductReportDto
                                {
                                    Name = s.Key,
                                    DefaultValue = s.Sum(t => t.Quantity * t.UnitPrice),
                                    DiscountedValue = s.Sum(t => t.Quantity * t.UnitPrice * 0.90M) //TODO : Gerçek hesabı
                                })
                                .OrderByDescending(o => o.DefaultValue)
                                .Take(20)
                                .ToList();

            dgvResult.DataSource = result;
        }
    }
}
