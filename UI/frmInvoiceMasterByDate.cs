using InvoiceApp.BLL;
using InvoiceApp.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace InvoiceApp.UI
{
    public partial class frmInvoiceMasterByDate : Form
    {
        private readonly InvoiceMasterByDateHandler _invoiceMasterByDateHandler = new InvoiceMasterByDateHandler();
        private readonly DateTimeFormatter _dateTimeFormatter = new DateTimeFormatter();
        private DataTable _dataTable = new DataTable();

        public frmInvoiceMasterByDate()
        {
            InitializeComponent();
        }

        private void txtFromYear_TextChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = _dateTimeFormatter.GetDateFormat(
                txtFromYear.Text.Trim(),
                cmbFromMonth.SelectedItem.ToString(),
                cmbFromDay.SelectedItem.ToString());
        }

        private void cmbFromMonth_SelectedValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = _dateTimeFormatter.GetDateFormat(
                txtFromYear.Text.Trim(),
                cmbFromMonth.SelectedItem.ToString(),
                cmbFromDay.SelectedItem.ToString());
        }

        private void cmbFromDay_SelectedValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = _dateTimeFormatter.GetDateFormat(
                txtFromYear.Text.Trim(),
                cmbFromMonth.SelectedItem.ToString(),
                cmbFromDay.SelectedItem.ToString());
        }

        private void txtToYear_TextChanged(object sender, EventArgs e)
        {
            txtToDate.Text = _dateTimeFormatter.GetDateFormat(
                txtToYear.Text.Trim(),
                cmbToMonth.SelectedItem.ToString(),
                cmbToDay.SelectedItem.ToString());
        }

        private void cmbToMonth_SelectedValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = _dateTimeFormatter.GetDateFormat(
                txtToYear.Text.Trim(),
                cmbToMonth.SelectedItem.ToString(),
                cmbToDay.SelectedItem.ToString());
        }

        private void cmbToDay_SelectedValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = _dateTimeFormatter.GetDateFormat(
                txtToYear.Text.Trim(),
                cmbToMonth.SelectedItem.ToString(),
                cmbToDay.SelectedItem.ToString());
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var invoiceMasterByDate = new InvoiceMasterByDate()
            {
                FromDate = txtFromDate.Text,
                ToDate = txtToDate.Text
            };

            _dataTable = _invoiceMasterByDateHandler.GetInvoiceMasterByDate(invoiceMasterByDate);
            dgReport.DataSource = _dataTable;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var formPrint = new frmPrint();
            formPrint.PrintDataTable = _dataTable;
            formPrint.Param = 1;
            formPrint.Show();
        }
    }
}
