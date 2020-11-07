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
            this.sütÜrünleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeceklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pahalıOlanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satıştanKaldırılanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişDetayıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sağlayıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tümÜrünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(12, 27);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(776, 411);
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
            this.sütÜrünleriToolStripMenuItem,
            this.içeceklerToolStripMenuItem,
            this.pahalıOlanlarToolStripMenuItem,
            this.satıştanKaldırılanlarToolStripMenuItem,
            this.toolStripSeparator1,
            this.tümÜrünlerToolStripMenuItem});
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
            // sütÜrünleriToolStripMenuItem
            // 
            this.sütÜrünleriToolStripMenuItem.Name = "sütÜrünleriToolStripMenuItem";
            this.sütÜrünleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sütÜrünleriToolStripMenuItem.Text = "Süt Ürünleri";
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
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // siparişToolStripMenuItem
            // 
            this.siparişToolStripMenuItem.Name = "siparişToolStripMenuItem";
            this.siparişToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişToolStripMenuItem.Text = "Siparişler";
            // 
            // siparişDetayıToolStripMenuItem
            // 
            this.siparişDetayıToolStripMenuItem.Name = "siparişDetayıToolStripMenuItem";
            this.siparişDetayıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişDetayıToolStripMenuItem.Text = "Sipariş Detayı";
            // 
            // sağlayıcılarToolStripMenuItem
            // 
            this.sağlayıcılarToolStripMenuItem.Name = "sağlayıcılarToolStripMenuItem";
            this.sağlayıcılarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sağlayıcılarToolStripMenuItem.Text = "Sağlayıcılar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tümÜrünlerToolStripMenuItem
            // 
            this.tümÜrünlerToolStripMenuItem.Name = "tümÜrünlerToolStripMenuItem";
            this.tümÜrünlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tümÜrünlerToolStripMenuItem.Text = "Tüm Ürünler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.ToolStripMenuItem sütÜrünleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeceklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pahalıOlanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satıştanKaldırılanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişDetayıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sağlayıcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tümÜrünlerToolStripMenuItem;
    }
}

