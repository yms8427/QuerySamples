using BilgeAdam.EF.Contracts;
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
    public partial class frmGraphic : Form
    {
        public frmGraphic(List<MonthlyReportOfYearDto> data)
        {
            InitializeComponent();
            Data = data;
        }

        public List<MonthlyReportOfYearDto> Data { get; }

        private void frmGraphic_Load(object sender, EventArgs e)
        {
            foreach (var monthData in Data)
            {
                chart.Series[0].Points.AddXY(monthData.Month, monthData.Summary);
            }
        }
    }
}
