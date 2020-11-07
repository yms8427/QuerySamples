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
            this.içeceklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pahalıOlanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satıştanKaldırılanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msbProducts_All = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişDetayıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sağlayıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.müşterilerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriSiparişleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriSiparişÜcretleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enYaşlı3PersonelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelVeYöneticisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yılBazlıToplamSatışAdediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enÇokAlıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enÇokGelirEldeEdilen5TarihVeGelirMiktarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yılıAylıkCirolarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isveçliŞirketlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enÇokSatılanÜrünAdetBazlıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enÇokSAtılanÜrünFiyatBazlıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugüneKadarYapılanİndirimsizSatışTutarıİleİskontoKarşılaştırmasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.içeceklerToolStripMenuItem,
            this.pahalıOlanlarToolStripMenuItem,
            this.satıştanKaldırılanlarToolStripMenuItem,
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
            // içeceklerToolStripMenuItem
            // 
            this.içeceklerToolStripMenuItem.Name = "içeceklerToolStripMenuItem";
            this.içeceklerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.içeceklerToolStripMenuItem.Text = "İçecekler";
            // 
            // pahalıOlanlarToolStripMenuItem
            // 
            this.pahalıOlanlarToolStripMenuItem.Name = "pahalıOlanlarToolStripMenuItem";
            this.pahalıOlanlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pahalıOlanlarToolStripMenuItem.Text = "Pahalı Olanlar";
            // 
            // satıştanKaldırılanlarToolStripMenuItem
            // 
            this.satıştanKaldırılanlarToolStripMenuItem.Name = "satıştanKaldırılanlarToolStripMenuItem";
            this.satıştanKaldırılanlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.satıştanKaldırılanlarToolStripMenuItem.Text = "Satıştan Kaldırılanlar";
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
            this.müşterilerToolStripMenuItem1,
            this.müşteriSiparişleriToolStripMenuItem,
            this.müşteriSiparişÜcretleriToolStripMenuItem});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelListesiToolStripMenuItem,
            this.enYaşlı3PersonelToolStripMenuItem,
            this.personelVeYöneticisiToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // siparişToolStripMenuItem
            // 
            this.siparişToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yılBazlıToplamSatışAdediToolStripMenuItem,
            this.enÇokAlıToolStripMenuItem,
            this.enÇokGelirEldeEdilen5TarihVeGelirMiktarıToolStripMenuItem,
            this.yılıAylıkCirolarıToolStripMenuItem});
            this.siparişToolStripMenuItem.Name = "siparişToolStripMenuItem";
            this.siparişToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişToolStripMenuItem.Text = "Siparişler";
            // 
            // siparişDetayıToolStripMenuItem
            // 
            this.siparişDetayıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enÇokSatılanÜrünAdetBazlıToolStripMenuItem,
            this.enÇokSAtılanÜrünFiyatBazlıToolStripMenuItem,
            this.bugüneKadarYapılanİndirimsizSatışTutarıİleİskontoKarşılaştırmasıToolStripMenuItem});
            this.siparişDetayıToolStripMenuItem.Name = "siparişDetayıToolStripMenuItem";
            this.siparişDetayıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişDetayıToolStripMenuItem.Text = "Sipariş Detayı";
            // 
            // sağlayıcılarToolStripMenuItem
            // 
            this.sağlayıcılarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaListesiToolStripMenuItem,
            this.isveçliŞirketlerToolStripMenuItem});
            this.sağlayıcılarToolStripMenuItem.Name = "sağlayıcılarToolStripMenuItem";
            this.sağlayıcılarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sağlayıcılarToolStripMenuItem.Text = "Sağlayıcılar";
            // 
            // btnNext
            // 
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
            this.btnPrevious.Location = new System.Drawing.Point(632, 415);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // müşterilerToolStripMenuItem1
            // 
            this.müşterilerToolStripMenuItem1.Name = "müşterilerToolStripMenuItem1";
            this.müşterilerToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.müşterilerToolStripMenuItem1.Text = "Müşteriler";
            // 
            // müşteriSiparişleriToolStripMenuItem
            // 
            this.müşteriSiparişleriToolStripMenuItem.Name = "müşteriSiparişleriToolStripMenuItem";
            this.müşteriSiparişleriToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.müşteriSiparişleriToolStripMenuItem.Text = "Müşteri Siparişleri";
            // 
            // müşteriSiparişÜcretleriToolStripMenuItem
            // 
            this.müşteriSiparişÜcretleriToolStripMenuItem.Name = "müşteriSiparişÜcretleriToolStripMenuItem";
            this.müşteriSiparişÜcretleriToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.müşteriSiparişÜcretleriToolStripMenuItem.Text = "Müşteri Sipariş Ücretleri";
            // 
            // personelListesiToolStripMenuItem
            // 
            this.personelListesiToolStripMenuItem.Name = "personelListesiToolStripMenuItem";
            this.personelListesiToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.personelListesiToolStripMenuItem.Text = "Personel Listesi";
            // 
            // enYaşlı3PersonelToolStripMenuItem
            // 
            this.enYaşlı3PersonelToolStripMenuItem.Name = "enYaşlı3PersonelToolStripMenuItem";
            this.enYaşlı3PersonelToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.enYaşlı3PersonelToolStripMenuItem.Text = "En Yaşlı 3 Personel";
            // 
            // personelVeYöneticisiToolStripMenuItem
            // 
            this.personelVeYöneticisiToolStripMenuItem.Name = "personelVeYöneticisiToolStripMenuItem";
            this.personelVeYöneticisiToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.personelVeYöneticisiToolStripMenuItem.Text = "Personel ve Yöneticisi";
            // 
            // yılBazlıToplamSatışAdediToolStripMenuItem
            // 
            this.yılBazlıToplamSatışAdediToolStripMenuItem.Name = "yılBazlıToplamSatışAdediToolStripMenuItem";
            this.yılBazlıToplamSatışAdediToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.yılBazlıToplamSatışAdediToolStripMenuItem.Text = "Yıl Bazlı Toplam Satış Adedi";
            // 
            // enÇokAlıToolStripMenuItem
            // 
            this.enÇokAlıToolStripMenuItem.Name = "enÇokAlıToolStripMenuItem";
            this.enÇokAlıToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.enÇokAlıToolStripMenuItem.Text = "En Çok Alış-Veriş Yapan 10 Müşteri";
            // 
            // enÇokGelirEldeEdilen5TarihVeGelirMiktarıToolStripMenuItem
            // 
            this.enÇokGelirEldeEdilen5TarihVeGelirMiktarıToolStripMenuItem.Name = "enÇokGelirEldeEdilen5TarihVeGelirMiktarıToolStripMenuItem";
            this.enÇokGelirEldeEdilen5TarihVeGelirMiktarıToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.enÇokGelirEldeEdilen5TarihVeGelirMiktarıToolStripMenuItem.Text = "En Çok Gelir Elde Edilen 5 Tarih ve Gelir Miktarı";
            // 
            // yılıAylıkCirolarıToolStripMenuItem
            // 
            this.yılıAylıkCirolarıToolStripMenuItem.Name = "yılıAylıkCirolarıToolStripMenuItem";
            this.yılıAylıkCirolarıToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.yılıAylıkCirolarıToolStripMenuItem.Text = "1997 Yılı Aylık Ciroları";
            // 
            // firmaListesiToolStripMenuItem
            // 
            this.firmaListesiToolStripMenuItem.Name = "firmaListesiToolStripMenuItem";
            this.firmaListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firmaListesiToolStripMenuItem.Text = "Firma Listesi";
            // 
            // isveçliŞirketlerToolStripMenuItem
            // 
            this.isveçliŞirketlerToolStripMenuItem.Name = "isveçliŞirketlerToolStripMenuItem";
            this.isveçliŞirketlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.isveçliŞirketlerToolStripMenuItem.Text = "İsveçli Şirketler";
            // 
            // enÇokSatılanÜrünAdetBazlıToolStripMenuItem
            // 
            this.enÇokSatılanÜrünAdetBazlıToolStripMenuItem.Name = "enÇokSatılanÜrünAdetBazlıToolStripMenuItem";
            this.enÇokSatılanÜrünAdetBazlıToolStripMenuItem.Size = new System.Drawing.Size(439, 22);
            this.enÇokSatılanÜrünAdetBazlıToolStripMenuItem.Text = "En Çok Satılan Ürün (Adet Bazlı)";
            // 
            // enÇokSAtılanÜrünFiyatBazlıToolStripMenuItem
            // 
            this.enÇokSAtılanÜrünFiyatBazlıToolStripMenuItem.Name = "enÇokSAtılanÜrünFiyatBazlıToolStripMenuItem";
            this.enÇokSAtılanÜrünFiyatBazlıToolStripMenuItem.Size = new System.Drawing.Size(439, 22);
            this.enÇokSAtılanÜrünFiyatBazlıToolStripMenuItem.Text = "En Çok Satılan Ürün (Fiyat Bazlı)";
            // 
            // bugüneKadarYapılanİndirimsizSatışTutarıİleİskontoKarşılaştırmasıToolStripMenuItem
            // 
            this.bugüneKadarYapılanİndirimsizSatışTutarıİleİskontoKarşılaştırmasıToolStripMenuItem.Name = "bugüneKadarYapılanİndirimsizSatışTutarıİleİskontoKarşılaştırmasıToolStripMenuItem" +
    "";
            this.bugüneKadarYapılanİndirimsizSatışTutarıİleİskontoKarşılaştırmasıToolStripMenuItem.Size = new System.Drawing.Size(439, 22);
            this.bugüneKadarYapılanİndirimsizSatışTutarıİleİskontoKarşılaştırmasıToolStripMenuItem.Text = "Bugüne Kadar Yapılan İndirimsiz Satış Tutarı ile İskonto Karşılaştırması";
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
        private System.Windows.Forms.ToolStripMenuItem içeceklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pahalıOlanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satıştanKaldırılanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişDetayıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sağlayıcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem msbProducts_All;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem müşteriSiparişleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriSiparişÜcretleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enYaşlı3PersonelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelVeYöneticisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yılBazlıToplamSatışAdediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enÇokAlıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enÇokGelirEldeEdilen5TarihVeGelirMiktarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yılıAylıkCirolarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enÇokSatılanÜrünAdetBazlıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enÇokSAtılanÜrünFiyatBazlıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugüneKadarYapılanİndirimsizSatışTutarıİleİskontoKarşılaştırmasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isveçliŞirketlerToolStripMenuItem;
    }
}

