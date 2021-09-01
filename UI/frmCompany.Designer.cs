
namespace InvoiceApp.UI
{
    partial class frmCompany
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.cmbCompanyType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgCompany = new System.Windows.Forms.DataGridView();
            this.CompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCompanyType = new System.Windows.Forms.Label();
            this.txtCompanyTel = new System.Windows.Forms.TextBox();
            this.lblCompanyTel = new System.Windows.Forms.Label();
            this.txtCompanyFax = new System.Windows.Forms.TextBox();
            this.lblCompanyFax = new System.Windows.Forms.Label();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtCompanyId = new System.Windows.Forms.TextBox();
            this.lblCompanyId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(672, 49);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(61, 20);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "نام شرکت";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(511, 46);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCompanyName.Size = new System.Drawing.Size(141, 27);
            this.txtCompanyName.TabIndex = 1;
            // 
            // cmbCompanyType
            // 
            this.cmbCompanyType.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompanyType.FormattingEnabled = true;
            this.cmbCompanyType.Location = new System.Drawing.Point(511, 84);
            this.cmbCompanyType.Name = "cmbCompanyType";
            this.cmbCompanyType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCompanyType.Size = new System.Drawing.Size(141, 28);
            this.cmbCompanyType.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("IRANSansX DemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(658, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgCompany
            // 
            this.dgCompany.AllowUserToAddRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightCyan;
            this.dgCompany.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgCompany.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCompany.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("IRANSansX DemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCompany.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyId,
            this.CompanyName,
            this.CompanyType,
            this.CompanyTel,
            this.CompanyFax,
            this.CompanyAddress,
            this.CompanyTypeId});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCompany.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgCompany.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgCompany.EnableHeadersVisualStyles = false;
            this.dgCompany.Location = new System.Drawing.Point(0, 232);
            this.dgCompany.Name = "dgCompany";
            this.dgCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgCompany.Size = new System.Drawing.Size(745, 218);
            this.dgCompany.TabIndex = 4;
            this.dgCompany.SelectionChanged += new System.EventHandler(this.dgCompnay_SelectionChanged);
            // 
            // CompanyId
            // 
            this.CompanyId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompanyId.DataPropertyName = "CompanyId";
            this.CompanyId.HeaderText = "سریال";
            this.CompanyId.Name = "CompanyId";
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "نام شرکت";
            this.CompanyName.Name = "CompanyName";
            // 
            // CompanyType
            // 
            this.CompanyType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompanyType.DataPropertyName = "CompanyType";
            this.CompanyType.HeaderText = "نوع شرکت";
            this.CompanyType.Name = "CompanyType";
            // 
            // CompanyTel
            // 
            this.CompanyTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompanyTel.DataPropertyName = "CompanyTel";
            this.CompanyTel.HeaderText = "تلفن";
            this.CompanyTel.Name = "CompanyTel";
            // 
            // CompanyFax
            // 
            this.CompanyFax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompanyFax.DataPropertyName = "CompanyFax";
            this.CompanyFax.HeaderText = "فکس";
            this.CompanyFax.Name = "CompanyFax";
            // 
            // CompanyAddress
            // 
            this.CompanyAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompanyAddress.DataPropertyName = "CompanyAddress";
            this.CompanyAddress.HeaderText = "آدرس";
            this.CompanyAddress.Name = "CompanyAddress";
            // 
            // CompanyTypeId
            // 
            this.CompanyTypeId.DataPropertyName = "CompanyTypeId";
            this.CompanyTypeId.HeaderText = "CompanyTypeId";
            this.CompanyTypeId.Name = "CompanyTypeId";
            this.CompanyTypeId.Visible = false;
            // 
            // lblCompanyType
            // 
            this.lblCompanyType.AutoSize = true;
            this.lblCompanyType.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyType.Location = new System.Drawing.Point(668, 88);
            this.lblCompanyType.Name = "lblCompanyType";
            this.lblCompanyType.Size = new System.Drawing.Size(65, 20);
            this.lblCompanyType.TabIndex = 5;
            this.lblCompanyType.Text = "نوع شرکت";
            // 
            // txtCompanyTel
            // 
            this.txtCompanyTel.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyTel.Location = new System.Drawing.Point(165, 6);
            this.txtCompanyTel.Name = "txtCompanyTel";
            this.txtCompanyTel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCompanyTel.Size = new System.Drawing.Size(136, 27);
            this.txtCompanyTel.TabIndex = 7;
            // 
            // lblCompanyTel
            // 
            this.lblCompanyTel.AutoSize = true;
            this.lblCompanyTel.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyTel.Location = new System.Drawing.Point(307, 9);
            this.lblCompanyTel.Name = "lblCompanyTel";
            this.lblCompanyTel.Size = new System.Drawing.Size(33, 20);
            this.lblCompanyTel.TabIndex = 6;
            this.lblCompanyTel.Text = "تلفن";
            // 
            // txtCompanyFax
            // 
            this.txtCompanyFax.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyFax.Location = new System.Drawing.Point(165, 46);
            this.txtCompanyFax.Name = "txtCompanyFax";
            this.txtCompanyFax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCompanyFax.Size = new System.Drawing.Size(136, 27);
            this.txtCompanyFax.TabIndex = 9;
            // 
            // lblCompanyFax
            // 
            this.lblCompanyFax.AutoSize = true;
            this.lblCompanyFax.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyFax.Location = new System.Drawing.Point(307, 50);
            this.lblCompanyFax.Name = "lblCompanyFax";
            this.lblCompanyFax.Size = new System.Drawing.Size(38, 20);
            this.lblCompanyFax.TabIndex = 8;
            this.lblCompanyFax.Text = "فکس";
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyAddress.Location = new System.Drawing.Point(12, 122);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCompanyAddress.Size = new System.Drawing.Size(640, 27);
            this.txtCompanyAddress.TabIndex = 11;
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyAddress.Location = new System.Drawing.Point(697, 125);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(36, 20);
            this.lblCompanyAddress.TabIndex = 10;
            this.lblCompanyAddress.Text = "آدرس";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Font = new System.Drawing.Font("IRANSansX DemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(577, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.Font = new System.Drawing.Font("IRANSansX DemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(415, 155);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 30);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "جدید";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Font = new System.Drawing.Font("IRANSansX DemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(496, 155);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtCompanyId
            // 
            this.txtCompanyId.BackColor = System.Drawing.Color.Azure;
            this.txtCompanyId.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyId.Location = new System.Drawing.Point(577, 6);
            this.txtCompanyId.Name = "txtCompanyId";
            this.txtCompanyId.ReadOnly = true;
            this.txtCompanyId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCompanyId.Size = new System.Drawing.Size(75, 27);
            this.txtCompanyId.TabIndex = 16;
            // 
            // lblCompanyId
            // 
            this.lblCompanyId.AutoSize = true;
            this.lblCompanyId.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyId.Location = new System.Drawing.Point(693, 9);
            this.lblCompanyId.Name = "lblCompanyId";
            this.lblCompanyId.Size = new System.Drawing.Size(40, 20);
            this.lblCompanyId.TabIndex = 15;
            this.lblCompanyId.Text = "سریال";
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.txtCompanyId);
            this.Controls.Add(this.lblCompanyId);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtCompanyAddress);
            this.Controls.Add(this.lblCompanyAddress);
            this.Controls.Add(this.txtCompanyFax);
            this.Controls.Add(this.lblCompanyFax);
            this.Controls.Add(this.txtCompanyTel);
            this.Controls.Add(this.lblCompanyTel);
            this.Controls.Add(this.lblCompanyType);
            this.Controls.Add(this.dgCompany);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbCompanyType);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.MaximumSize = new System.Drawing.Size(761, 489);
            this.MinimumSize = new System.Drawing.Size(761, 489);
            this.Name = "frmCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت اطلاعات شرکت";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.ComboBox cmbCompanyType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgCompany;
        private System.Windows.Forms.Label lblCompanyType;
        private System.Windows.Forms.TextBox txtCompanyTel;
        private System.Windows.Forms.Label lblCompanyTel;
        private System.Windows.Forms.TextBox txtCompanyFax;
        private System.Windows.Forms.Label lblCompanyFax;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyTypeId;
        private System.Windows.Forms.TextBox txtCompanyId;
        private System.Windows.Forms.Label lblCompanyId;
    }
}