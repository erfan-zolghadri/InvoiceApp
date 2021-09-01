using InvoiceApp.BLL;
using InvoiceApp.DAL;
using System;
using System.Windows.Forms;

namespace InvoiceApp.UI
{
    //dgInvoiceMaster.CurrentRow.Cells[0].Value.ToString()
    public partial class frmInvoice : Form
    {
        private readonly InvoiceMasterHandler _invoiceMasterHandler = new InvoiceMasterHandler();
        private readonly InvoiceDetailHandler _invoiceDetailHandler = new InvoiceDetailHandler();
        private readonly DateTimeFormatter _dateTimeFormatter = new DateTimeFormatter();

        public frmInvoice()
        {
            InitializeComponent();
        }

        private void UpdateGridInvoiceMaster()
        {
            dgInvoiceMaster.DataSource = _invoiceMasterHandler.GetInvoiceMaster();
        }

        private void UpdateGridInvoiceDetail()
        {
            var invoiceDetail = new InvoiceDetail()
            {
                MasterId = Convert.ToInt64(dgInvoiceMaster.CurrentRow.Cells[0].Value.ToString())
            };

            dgInvoiceDetail.DataSource = _invoiceDetailHandler.GetInvoiceDetail(invoiceDetail);
        }

        // Events
        private void frmInvoice_Load(object sender, EventArgs e)
        {
            cmbInvoiceType.DataSource = _invoiceMasterHandler.GetInvoiceType();
            cmbInvoiceType.DisplayMember = "InvoiceType";
            cmbInvoiceType.ValueMember = "InvoiceTypeId";

            cmbCompany.DataSource = _invoiceMasterHandler.GetCompany();
            cmbCompany.DisplayMember = "CompanyName";
            cmbCompany.ValueMember = "CompanyId";

            cmbPerson.DataSource = _invoiceMasterHandler.GetPerson();
            cmbPerson.DisplayMember = "PersonName";
            cmbPerson.ValueMember = "PersonId";

            UpdateGridInvoiceMaster();

            cmbUnit.DataSource = _invoiceDetailHandler.GetUnit();
            cmbUnit.DisplayMember = "UnitName";
            cmbUnit.ValueMember = "UnitId";
        }

        // Fill invoice date fields
        private void txtInvoiceYear_TextChanged(object sender, EventArgs e)
        {
            txtInvoiceDate.Text = _dateTimeFormatter.GetDateFormat(
                txtInvoiceYear.Text.Trim(),
                cmbInvoiceMonth.SelectedItem.ToString(),
                cmbInvoiceDay.SelectedItem.ToString());
        }

        private void cmbInvoiceMonth_SelectedValueChanged(object sender, EventArgs e)
        {
            txtInvoiceDate.Text = _dateTimeFormatter.GetDateFormat(
                txtInvoiceYear.Text.Trim(),
                cmbInvoiceMonth.SelectedItem.ToString(),
                cmbInvoiceDay.SelectedItem.ToString());
        }

        private void cmbInvoiceDay_SelectedValueChanged(object sender, EventArgs e)
        {
            txtInvoiceDate.Text = _dateTimeFormatter.GetDateFormat(
                txtInvoiceYear.Text.Trim(),
                cmbInvoiceMonth.SelectedItem.ToString(),
                cmbInvoiceDay.SelectedItem.ToString());
        }
        // Ending of fill invoice date fields

        // Fill invoice register date fields
        private void txtInvoiceRegisterYear_TextChanged(object sender, EventArgs e)
        {
            txtInvoiceRegisterDate.Text = _dateTimeFormatter.GetDateFormat(
                txtInvoiceRegisterYear.Text.Trim(),
                cmbInvoiceRegisterMonth.SelectedItem.ToString(),
                cmbInvoiceRegisterDay.SelectedItem.ToString());
        }

        private void cmbInvoiceRegisterMonth_SelectedValueChanged(object sender, EventArgs e)
        {
            txtInvoiceRegisterDate.Text = _dateTimeFormatter.GetDateFormat(
                txtInvoiceRegisterYear.Text.Trim(),
                cmbInvoiceRegisterMonth.SelectedItem.ToString(),
                cmbInvoiceRegisterDay.SelectedItem.ToString());
        }

        private void cmbInvoiceRegisterDay_SelectedValueChanged(object sender, EventArgs e)
        {
            txtInvoiceRegisterDate.Text = _dateTimeFormatter.GetDateFormat(
                txtInvoiceRegisterYear.Text.Trim(),
                cmbInvoiceRegisterMonth.SelectedItem.ToString(),
                cmbInvoiceRegisterDay.SelectedItem.ToString());
        }
        // Ending of fill invoice register date fields

        // Fill invoice register time fields
        private void cmbInvoiceRegisterHour_SelectedValueChanged(object sender, EventArgs e)
        {
            txtInvoiceRegisterTime.Text = _dateTimeFormatter.GetTimeFormat(
                cmbInvoiceRegisterHour.SelectedItem.ToString(),
                cmbInvoiceRegisterMinute.SelectedItem.ToString());
        }

        private void cmbInvoiceRegisterMinute_SelectedValueChanged(object sender, EventArgs e)
        {
            txtInvoiceRegisterTime.Text = _dateTimeFormatter.GetTimeFormat(
                cmbInvoiceRegisterHour.SelectedItem.ToString(),
                cmbInvoiceRegisterMinute.SelectedItem.ToString());
        }
        // Ending of fill invoice register time fields

        private void dgInvoiceMaster_SelectionChanged(object sender, EventArgs e)
        {
            txtInvoiceMasterId.Text = dgInvoiceMaster.CurrentRow.Cells[0].Value.ToString();
            txtInvoiceNumber.Text = dgInvoiceMaster.CurrentRow.Cells[1].Value.ToString();
            cmbInvoiceType.SelectedValue = dgInvoiceMaster.CurrentRow.Cells[9].Value.ToString();

            var invoiceDateComponents = _dateTimeFormatter.GetDateComponents(dgInvoiceMaster.CurrentRow.Cells[3].Value.ToString());
            txtInvoiceYear.Text = invoiceDateComponents[0];
            cmbInvoiceMonth.SelectedItem = invoiceDateComponents[1];
            cmbInvoiceDay.SelectedItem = invoiceDateComponents[2];

            cmbCompany.SelectedValue = dgInvoiceMaster.CurrentRow.Cells[10].Value.ToString();
            cmbPerson.SelectedValue = dgInvoiceMaster.CurrentRow.Cells[11].Value.ToString();

            var invoiceRegisterDateComponents = _dateTimeFormatter.GetDateComponents(dgInvoiceMaster.CurrentRow.Cells[6].Value.ToString());
            txtInvoiceRegisterYear.Text = invoiceRegisterDateComponents[0];
            cmbInvoiceRegisterMonth.SelectedItem = invoiceRegisterDateComponents[1];
            cmbInvoiceRegisterDay.SelectedItem = invoiceRegisterDateComponents[2];

            var invoiceRegisterTimeComponents = _dateTimeFormatter.GetTimeComponents(dgInvoiceMaster.CurrentRow.Cells[7].Value.ToString());
            cmbInvoiceRegisterHour.SelectedItem = invoiceRegisterTimeComponents[0];
            cmbInvoiceRegisterMinute.SelectedItem = invoiceRegisterTimeComponents[1];

            txtInvoiceDescription.Text = string.Empty;

            UpdateGridInvoiceDetail();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var invoiceMaster = new InvoiceMaster()
            {
                Id = Convert.ToInt64(txtInvoiceMasterId.Text),
                Number = txtInvoiceNumber.Text.Trim(),
                TypeId = Convert.ToInt64(cmbInvoiceType.SelectedValue),
                Date = txtInvoiceDate.Text,
                CompanyId = Convert.ToInt64(cmbCompany.SelectedValue),
                PersonId = Convert.ToInt64(cmbPerson.SelectedValue),
                RegisterDate = txtInvoiceRegisterDate.Text,
                RegisterTime = txtInvoiceRegisterTime.Text,
                Description = txtInvoiceDescription.Text,
            };

            _invoiceMasterHandler.InsertInvoiceMaster(invoiceMaster);
            UpdateGridInvoiceMaster();
            dgInvoiceMaster.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var invoiceMaster = new InvoiceMaster()
            {
                Id = Convert.ToInt64(dgInvoiceMaster.CurrentRow.Cells[0].Value.ToString())
            };

            int invoiceDetailCount = _invoiceMasterHandler.GetInvoiceDetailCount(invoiceMaster);

            if (invoiceDetailCount == 0)
            {
                _invoiceMasterHandler.DeleteInvoiceMaster(invoiceMaster);
                UpdateGridInvoiceMaster();
            }
            else
            {
                MessageBox.Show("قبل از حذف فاکتور، ابتدا جزئیات فاکتور را حذف کنید");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var invoiceMaster = new InvoiceMaster()
            {
                Id = Convert.ToInt64(txtInvoiceMasterId.Text),
                Number = txtInvoiceNumber.Text.Trim(),
                TypeId = Convert.ToInt64(cmbInvoiceType.SelectedValue),
                Date = txtInvoiceDate.Text,
                CompanyId = Convert.ToInt64(cmbCompany.SelectedValue),
                PersonId = Convert.ToInt64(cmbPerson.SelectedValue),
                RegisterDate = txtInvoiceRegisterDate.Text,
                RegisterTime = txtInvoiceRegisterTime.Text,
                Description = txtInvoiceDescription.Text,
            };

            _invoiceMasterHandler.UpdateInvoiceMaster(invoiceMaster);
            UpdateGridInvoiceMaster();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtInvoiceMasterId.Text = _invoiceMasterHandler.GetMaxInvoiceMasterId().ToString();
            txtInvoiceNumber.Text = string.Empty;
            cmbInvoiceType.SelectedValue = 1;
            txtInvoiceYear.Text = "1400";
            cmbInvoiceMonth.SelectedItem = "01";
            cmbInvoiceDay.SelectedItem = "01";
            cmbCompany.SelectedValue = 1;
            cmbPerson.SelectedValue = 1;
            txtInvoiceRegisterYear.Text = "1400";
            cmbInvoiceRegisterMonth.SelectedItem = "01";
            cmbInvoiceRegisterDay.SelectedItem = "01";
            cmbInvoiceRegisterHour.SelectedItem = "00";
            cmbInvoiceRegisterMinute.SelectedItem = "00";
            txtInvoiceDescription.Text = string.Empty;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dgInvoiceMaster.Enabled = true;
        }

        private void dgInvoiceDetail_SelectionChanged(object sender, EventArgs e)
        {
            txtInvoiceDetailId.Text = dgInvoiceDetail.CurrentRow.Cells[0].Value.ToString();
            txtProductCode.Text = dgInvoiceDetail.CurrentRow.Cells[1].Value.ToString();
            txtProductBriefDescription.Text = dgInvoiceDetail.CurrentRow.Cells[2].Value.ToString();
            txtProductQantity.Text = dgInvoiceDetail.CurrentRow.Cells[3].Value.ToString();
            cmbUnit.SelectedValue = dgInvoiceDetail.CurrentRow.Cells[10].Value.ToString();
            txtProductPrice.Text = dgInvoiceDetail.CurrentRow.Cells[5].Value.ToString();
            txtProductTotalPrice.Text = dgInvoiceDetail.CurrentRow.Cells[6].Value.ToString();
            txtProductSpecifications.Text = dgInvoiceDetail.CurrentRow.Cells[7].Value.ToString();
            txtProductDescription.Text = dgInvoiceDetail.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnSaveDetail_Click(object sender, EventArgs e)
        {
            var invoiceDetail = new InvoiceDetail()
            {
                Id = Convert.ToInt64(txtInvoiceDetailId.Text),
                MasterId = Convert.ToInt64(dgInvoiceMaster.CurrentRow.Cells[0].Value.ToString()),
                ProductCode = txtProductCode.Text.Trim(),
                ProductBriefDescription = txtProductBriefDescription.Text.Trim(),
                ProductQuantity = float.Parse(txtProductQantity.Text.Trim()),
                UnitId = Convert.ToInt64(cmbUnit.SelectedValue),
                ProductPrice = Convert.ToInt64(txtProductPrice.Text.Trim()),
                ProductTotalPrice = Convert.ToInt64(txtProductTotalPrice.Text.Trim()),
                ProductSpecification = txtProductSpecifications.Text.Trim(),
                ProductDescription = txtProductDescription.Text.Trim()
            };

            _invoiceDetailHandler.InsertInvoiceDetail(invoiceDetail);
            UpdateGridInvoiceDetail();
        }

        private void btnEditDetail_Click(object sender, EventArgs e)
        {
            var invoiceDetail = new InvoiceDetail()
            {
                Id = Convert.ToInt64(txtInvoiceDetailId.Text),
                ProductCode = txtProductCode.Text.Trim(),
                ProductBriefDescription = txtProductBriefDescription.Text.Trim(),
                ProductQuantity = float.Parse(txtProductQantity.Text.Trim()),
                UnitId = Convert.ToInt64(cmbUnit.SelectedValue),
                ProductPrice = Convert.ToInt64(txtProductPrice.Text.Trim()),
                ProductTotalPrice = Convert.ToInt64(txtProductTotalPrice.Text.Trim()),
                ProductSpecification = txtProductSpecifications.Text.Trim(),
                ProductDescription = txtProductDescription.Text.Trim()
            };

            _invoiceDetailHandler.UpdateInvoiceDetail(invoiceDetail);
            UpdateGridInvoiceDetail();
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            var invoiceDetail = new InvoiceDetail()
            {
                Id = Convert.ToInt64(txtInvoiceDetailId.Text),
            };

            _invoiceDetailHandler.DeleteInvoiceDetail(invoiceDetail);
            UpdateGridInvoiceDetail();
        }

        private void btnNewDetail_Click(object sender, EventArgs e)
        {
            txtInvoiceDetailId.Text = _invoiceDetailHandler.GetMaxInvoiceDetailId().ToString();
            txtProductCode.Text = string.Empty;
            txtProductBriefDescription.Text = string.Empty;
            txtProductQantity.Text = string.Empty;
            cmbUnit.SelectedValue = 1;
            txtProductPrice.Text = string.Empty;
            txtProductTotalPrice.Text = string.Empty;
            txtProductSpecifications.Text = string.Empty;
            txtProductDescription.Text = string.Empty;
        }

        
    }
}
