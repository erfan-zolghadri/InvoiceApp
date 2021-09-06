using System;
using System.Windows.Forms;

namespace InvoiceApp.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ثبتاطلاعاتشرکتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCompany = new frmCompany();
            formCompany.Show();
        }

        private void ثبتفاکتورهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formInvoice = new frmInvoice();
            formInvoice.Show();
        }

        private void گزراشبهتفکیکتاریخفاکتورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formInvoiceByDate = new frmInvoiceMasterByDate();
            formInvoiceByDate.Show();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
