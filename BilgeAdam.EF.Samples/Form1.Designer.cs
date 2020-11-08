namespace BilgeAdam.EF.Samples
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sorguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msbProduct_Consumed = new System.Windows.Forms.ToolStripMenuItem();
            this.msbProducts_Milk = new System.Windows.Forms.ToolStripMenuItem();
            this.msbProduct_Beverages = new System.Windows.Forms.ToolStripMenuItem();
            this.msbProduct_Expensives = new System.Windows.Forms.ToolStripMenuItem();
            this.msbProducts_Discontinued = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msbProducts_All = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msbCustomers_All = new System.Windows.Forms.ToolStripMenuItem();
            this.msbCustomers_Orders = new System.Windows.Forms.ToolStripMenuItem();
            this.msbCustomersOrderAmounts = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msbEmployee_All = new System.Windows.Forms.ToolStripMenuItem();
            this.msbEmployee_Elders = new System.Windows.Forms.ToolStripMenuItem();
            this.msbEmployee_Managers = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msbOrder_CountOfYearlySell = new System.Windows.Forms.ToolStripMenuItem();
            this.msbOrder_Top10Customers = new System.Windows.Forms.ToolStripMenuItem();
            this.msbOrder_Top5Date = new System.Windows.Forms.ToolStripMenuItem();
            this.msbOrder_1997MonthlyReport = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişDetayıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msbOrderDetail_MostSoldByCount = new System.Windows.Forms.ToolStripMenuItem();
            this.msbOrderDetail_MostSoldByPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.msbOrderDetails_Compare = new System.Windows.Forms.ToolStripMenuItem();
            this.sağlayıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msbSuppliers_All = new System.Windows.Forms.ToolStripMenuItem();
            this.msbSupplier_Swedish = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(12, 27);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(776, 374);
            this.dgvResult.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sorguToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sorguToolStripMenuItem
            // 
            this.sorguToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.siparişToolStripMenuItem,
            this.siparişDetayıToolStripMenuItem,
            this.sağlayıcılarToolStripMenuItem});
            this.sorguToolStripMenuItem.Name = "sorguToolStripMenuItem";
            this.sorguToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sorguToolStripMenuItem.Text = "Sorgu";
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbProduct_Consumed,
            this.msbProducts_Milk,
            this.msbProduct_Beverages,
            this.msbProduct_Expensives,
            this.msbProducts_Discontinued,
            this.toolStripSeparator1,
            this.msbProducts_All});
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            // 
            // msbProduct_Consumed
            // 
            this.msbProduct_Consumed.Name = "msbProduct_Consumed";
            this.msbProduct_Consumed.Size = new System.Drawing.Size(180, 22);
            this.msbProduct_Consumed.Text = "Tükenmiş Ürünler";
            this.msbProduct_Consumed.Click += new System.EventHandler(this.msbProduct_Consumed_Click);
            // 
            // msbProducts_Milk
            // 
            this.msbProducts_Milk.Name = "msbProducts_Milk";
            this.msbProducts_Milk.Size = new System.Drawing.Size(180, 22);
            this.msbProducts_Milk.Text = "Süt Ürünleri";
            this.msbProducts_Milk.Click += new System.EventHandler(this.msbProducts_Milk_Click);
            // 
            // msbProduct_Beverages
            // 
            this.msbProduct_Beverages.Name = "msbProduct_Beverages";
            this.msbProduct_Beverages.Size = new System.Drawing.Size(180, 22);
            this.msbProduct_Beverages.Text = "İçecekler";
            this.msbProduct_Beverages.Click += new System.EventHandler(this.msbProduct_Beverages_Click);
            // 
            // msbProduct_Expensives
            // 
            this.msbProduct_Expensives.Name = "msbProduct_Expensives";
            this.msbProduct_Expensives.Size = new System.Drawing.Size(180, 22);
            this.msbProduct_Expensives.Text = "Pahalı Olanlar";
            this.msbProduct_Expensives.Click += new System.EventHandler(this.msbProduct_Expensives_Click);
            // 
            // msbProducts_Discontinued
            // 
            this.msbProducts_Discontinued.Name = "msbProducts_Discontinued";
            this.msbProducts_Discontinued.Size = new System.Drawing.Size(180, 22);
            this.msbProducts_Discontinued.Text = "Satıştan Kaldırılanlar";
            this.msbProducts_Discontinued.Click += new System.EventHandler(this.msbProducts_Discontinued_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // msbProducts_All
            // 
            this.msbProducts_All.Name = "msbProducts_All";
            this.msbProducts_All.Size = new System.Drawing.Size(180, 22);
            this.msbProducts_All.Text = "Tüm Ürünler";
            this.msbProducts_All.Click += new System.EventHandler(this.msbProducts_All_Click);
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbCustomers_All,
            this.msbCustomers_Orders,
            this.msbCustomersOrderAmounts});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // msbCustomers_All
            // 
            this.msbCustomers_All.Name = "msbCustomers_All";
            this.msbCustomers_All.Size = new System.Drawing.Size(198, 22);
            this.msbCustomers_All.Text = "Müşteriler";
            this.msbCustomers_All.Click += new System.EventHandler(this.msbCustomers_All_Click);
            // 
            // msbCustomers_Orders
            // 
            this.msbCustomers_Orders.Name = "msbCustomers_Orders";
            this.msbCustomers_Orders.Size = new System.Drawing.Size(198, 22);
            this.msbCustomers_Orders.Text = "Müşteri Siparişleri";
            this.msbCustomers_Orders.Click += new System.EventHandler(this.msbCustomers_Orders_Click);
            // 
            // msbCustomersOrderAmounts
            // 
            this.msbCustomersOrderAmounts.Name = "msbCustomersOrderAmounts";
            this.msbCustomersOrderAmounts.Size = new System.Drawing.Size(198, 22);
            this.msbCustomersOrderAmounts.Text = "Müşteri Sipariş Ücretleri";
            this.msbCustomersOrderAmounts.Click += new System.EventHandler(this.msbCustomersOrderAmounts_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbEmployee_All,
            this.msbEmployee_Elders,
            this.msbEmployee_Managers});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // msbEmployee_All
            // 
            this.msbEmployee_All.Name = "msbEmployee_All";
            this.msbEmployee_All.Size = new System.Drawing.Size(187, 22);
            this.msbEmployee_All.Text = "Personel Listesi";
            this.msbEmployee_All.Click += new System.EventHandler(this.msbEmployee_All_Click);
            // 
            // msbEmployee_Elders
            // 
            this.msbEmployee_Elders.Name = "msbEmployee_Elders";
            this.msbEmployee_Elders.Size = new System.Drawing.Size(187, 22);
            this.msbEmployee_Elders.Text = "En Yaşlı 3 Personel";
            this.msbEmployee_Elders.Click += new System.EventHandler(this.msbEmployee_Elders_Click);
            // 
            // msbEmployee_Managers
            // 
            this.msbEmployee_Managers.Name = "msbEmployee_Managers";
            this.msbEmployee_Managers.Size = new System.Drawing.Size(187, 22);
            this.msbEmployee_Managers.Text = "Personel ve Yöneticisi";
            this.msbEmployee_Managers.Click += new System.EventHandler(this.msbEmployee_Managers_Click);
            // 
            // siparişToolStripMenuItem
            // 
            this.siparişToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbOrder_CountOfYearlySell,
            this.msbOrder_Top10Customers,
            this.msbOrder_Top5Date,
            this.msbOrder_1997MonthlyReport});
            this.siparişToolStripMenuItem.Name = "siparişToolStripMenuItem";
            this.siparişToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişToolStripMenuItem.Text = "Siparişler";
            // 
            // msbOrder_CountOfYearlySell
            // 
            this.msbOrder_CountOfYearlySell.Name = "msbOrder_CountOfYearlySell";
            this.msbOrder_CountOfYearlySell.Size = new System.Drawing.Size(318, 22);
            this.msbOrder_CountOfYearlySell.Text = "Yıl Bazlı Toplam Satış Adedi";
            this.msbOrder_CountOfYearlySell.Click += new System.EventHandler(this.msbOrder_CountOfYearlySell_Click);
            // 
            // msbOrder_Top10Customers
            // 
            this.msbOrder_Top10Customers.Name = "msbOrder_Top10Customers";
            this.msbOrder_Top10Customers.Size = new System.Drawing.Size(318, 22);
            this.msbOrder_Top10Customers.Text = "En Çok Alış-Veriş Yapan 10 Müşteri";
            this.msbOrder_Top10Customers.Click += new System.EventHandler(this.msbOrder_Top10Customers_Click);
            // 
            // msbOrder_Top5Date
            // 
            this.msbOrder_Top5Date.Name = "msbOrder_Top5Date";
            this.msbOrder_Top5Date.Size = new System.Drawing.Size(318, 22);
            this.msbOrder_Top5Date.Text = "En Çok Gelir Elde Edilen 5 Tarih ve Gelir Miktarı";
            this.msbOrder_Top5Date.Click += new System.EventHandler(this.msbOrder_Top5Date_Click);
            // 
            // msbOrder_1997MonthlyReport
            // 
            this.msbOrder_1997MonthlyReport.Name = "msbOrder_1997MonthlyReport";
            this.msbOrder_1997MonthlyReport.Size = new System.Drawing.Size(318, 22);
            this.msbOrder_1997MonthlyReport.Text = "1997 Yılı Aylık Ciroları";
            this.msbOrder_1997MonthlyReport.Click += new System.EventHandler(this.msbOrder_1997MonthlyReport_Click);
            // 
            // siparişDetayıToolStripMenuItem
            // 
            this.siparişDetayıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbOrderDetail_MostSoldByCount,
            this.msbOrderDetail_MostSoldByPrice,
            this.msbOrderDetails_Compare});
            this.siparişDetayıToolStripMenuItem.Name = "siparişDetayıToolStripMenuItem";
            this.siparişDetayıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişDetayıToolStripMenuItem.Text = "Sipariş Detayı";
            // 
            // msbOrderDetail_MostSoldByCount
            // 
            this.msbOrderDetail_MostSoldByCount.Name = "msbOrderDetail_MostSoldByCount";
            this.msbOrderDetail_MostSoldByCount.Size = new System.Drawing.Size(439, 22);
            this.msbOrderDetail_MostSoldByCount.Text = "En Çok Satılan Ürün (Adet Bazlı)";
            this.msbOrderDetail_MostSoldByCount.Click += new System.EventHandler(this.msbOrderDetail_MostSoldByCount_Click);
            // 
            // msbOrderDetail_MostSoldByPrice
            // 
            this.msbOrderDetail_MostSoldByPrice.Name = "msbOrderDetail_MostSoldByPrice";
            this.msbOrderDetail_MostSoldByPrice.Size = new System.Drawing.Size(439, 22);
            this.msbOrderDetail_MostSoldByPrice.Text = "En Çok Satılan Ürün (Fiyat Bazlı)";
            this.msbOrderDetail_MostSoldByPrice.Click += new System.EventHandler(this.msbOrderDetail_MostSoldByPrice_Click);
            // 
            // msbOrderDetails_Compare
            // 
            this.msbOrderDetails_Compare.Name = "msbOrderDetails_Compare";
            this.msbOrderDetails_Compare.Size = new System.Drawing.Size(439, 22);
            this.msbOrderDetails_Compare.Text = "Bugüne Kadar Yapılan İndirimsiz Satış Tutarı ile İskonto Karşılaştırması";
            this.msbOrderDetails_Compare.Click += new System.EventHandler(this.msbOrderDetails_Compare_Click);
            // 
            // sağlayıcılarToolStripMenuItem
            // 
            this.sağlayıcılarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbSuppliers_All,
            this.msbSupplier_Swedish});
            this.sağlayıcılarToolStripMenuItem.Name = "sağlayıcılarToolStripMenuItem";
            this.sağlayıcılarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sağlayıcılarToolStripMenuItem.Text = "Sağlayıcılar";
            // 
            // msbSuppliers_All
            // 
            this.msbSuppliers_All.Name = "msbSuppliers_All";
            this.msbSuppliers_All.Size = new System.Drawing.Size(180, 22);
            this.msbSuppliers_All.Text = "Firma Listesi";
            this.msbSuppliers_All.Click += new System.EventHandler(this.msbSuppliers_All_Click);
            // 
            // msbSupplier_Swedish
            // 
            this.msbSupplier_Swedish.Name = "msbSupplier_Swedish";
            this.msbSupplier_Swedish.Size = new System.Drawing.Size(180, 22);
            this.msbSupplier_Swedish.Text = "İsveçli Şirketler";
            this.msbSupplier_Swedish.Click += new System.EventHandler(this.msbSupplier_Swedish_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(713, 415);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Location = new System.Drawing.Point(632, 415);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Örnek Sorgular";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sorguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msbProduct_Consumed;
        private System.Windows.Forms.ToolStripMenuItem msbProducts_Milk;
        private System.Windows.Forms.ToolStripMenuItem msbProduct_Beverages;
        private System.Windows.Forms.ToolStripMenuItem msbProduct_Expensives;
        private System.Windows.Forms.ToolStripMenuItem msbProducts_Discontinued;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişDetayıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sağlayıcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem msbProducts_All;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ToolStripMenuItem msbCustomers_All;
        private System.Windows.Forms.ToolStripMenuItem msbCustomers_Orders;
        private System.Windows.Forms.ToolStripMenuItem msbCustomersOrderAmounts;
        private System.Windows.Forms.ToolStripMenuItem msbEmployee_All;
        private System.Windows.Forms.ToolStripMenuItem msbEmployee_Elders;
        private System.Windows.Forms.ToolStripMenuItem msbEmployee_Managers;
        private System.Windows.Forms.ToolStripMenuItem msbOrder_CountOfYearlySell;
        private System.Windows.Forms.ToolStripMenuItem msbOrder_Top10Customers;
        private System.Windows.Forms.ToolStripMenuItem msbOrder_Top5Date;
        private System.Windows.Forms.ToolStripMenuItem msbOrder_1997MonthlyReport;
        private System.Windows.Forms.ToolStripMenuItem msbOrderDetail_MostSoldByCount;
        private System.Windows.Forms.ToolStripMenuItem msbOrderDetail_MostSoldByPrice;
        private System.Windows.Forms.ToolStripMenuItem msbOrderDetails_Compare;
        private System.Windows.Forms.ToolStripMenuItem msbSuppliers_All;
        private System.Windows.Forms.ToolStripMenuItem msbSupplier_Swedish;
    }
}

