using InvoiceApp.BLL;
using InvoiceApp.DAL;
using System;
using System.Windows.Forms;

namespace InvoiceApp.UI
{
    public partial class frmCompany : Form
    {
        private readonly CompanyHandler _companyHandler = new CompanyHandler();

        public frmCompany()
        {
            InitializeComponent();
        }

        private void UpdateComboBoxCompanyType()
        {
            cmbCompanyType.DataSource = _companyHandler.GetCompanyType();
            cmbCompanyType.DisplayMember = "CompanyType";
            cmbCompanyType.ValueMember = "CompanyTypeId";
        }

        private void UpdateGridCompany()
        {
            dgCompany.DataSource = _companyHandler.GetCompany();
        }

        private void UpdateTextBoxCompanyId()
        {
            txtCompanyId.Text = _companyHandler.GetMaxCompanyId().ToString();
        }

        private void ResetCompanyFields()
        {
            txtCompanyName.Text = string.Empty;
            cmbCompanyType.SelectedValue = 1;
            txtCompanyTel.Text = string.Empty;
            txtCompanyFax.Text = string.Empty;
            txtCompanyAddress.Text = string.Empty;
        }

        private void UpdateCompanyFields()
        {
            txtCompanyId.Text = dgCompany.CurrentRow.Cells[0].Value.ToString();
            txtCompanyName.Text = dgCompany.CurrentRow.Cells[1].Value.ToString();
            cmbCompanyType.SelectedValue = dgCompany.CurrentRow.Cells[6].Value.ToString();
            txtCompanyTel.Text = dgCompany.CurrentRow.Cells[3].Value.ToString();
            txtCompanyFax.Text = dgCompany.CurrentRow.Cells[4].Value.ToString();
            txtCompanyAddress.Text = dgCompany.CurrentRow.Cells[5].Value.ToString();
        }

        // Events
        private void frmCompany_Load(object sender, EventArgs e)
        {
            UpdateComboBoxCompanyType();
            UpdateGridCompany();
            UpdateTextBoxCompanyId();
        }

        private void dgCompnay_SelectionChanged(object sender, EventArgs e)
        {
            UpdateCompanyFields();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UpdateTextBoxCompanyId();
            ResetCompanyFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var company = new Company()
            {
                Id = Convert.ToInt64(txtCompanyId.Text),
                Name = txtCompanyName.Text.Trim(),
                TypeId = Convert.ToInt64(cmbCompanyType.SelectedValue.ToString()),
                Tel = txtCompanyTel.Text.Trim(),
                Fax = txtCompanyFax.Text.Trim(),
                Address = txtCompanyAddress.Text.Trim()
            };
            _companyHandler.InsertCompany(company);
            UpdateGridCompany();
            UpdateTextBoxCompanyId();
            ResetCompanyFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var company = new Company()
            {
                Id = Convert.ToInt64(dgCompany.CurrentRow.Cells[0].Value),
            };

            _companyHandler.DeleteCompany(company);
            UpdateGridCompany();
            UpdateTextBoxCompanyId();
            ResetCompanyFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var company = new Company()
            {
                Id = Convert.ToInt64(txtCompanyId.Text),
                Name = txtCompanyName.Text.Trim(),
                TypeId = Convert.ToInt64(cmbCompanyType.SelectedValue.ToString()),
                Tel = txtCompanyTel.Text.Trim(),
                Fax = txtCompanyFax.Text.Trim(),
                Address = txtCompanyAddress.Text.Trim()
            };

            _companyHandler.UpdateCompany(company);
            UpdateGridCompany();
            UpdateTextBoxCompanyId();
            ResetCompanyFields();
        }
    }
}
