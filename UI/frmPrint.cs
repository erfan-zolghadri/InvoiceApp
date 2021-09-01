using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceApp.UI
{
    public partial class frmPrint : Form
    {
        private DataTable _dataTable = new DataTable();
        public int Param { get; set; }

        public DataTable PrintDataTable
        {
            get { return _dataTable; }
            set { _dataTable = value; }
        }

        public frmPrint()
        {
            InitializeComponent();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            if (Param == 1)
            {
                var crInvoiceMaster = new crystalReportInvoiceMaster();
                crInvoiceMaster.SetDataSource(PrintDataTable);
                crystalReportViewer1.ReportSource = crInvoiceMaster;
            }
        }
    }
}
