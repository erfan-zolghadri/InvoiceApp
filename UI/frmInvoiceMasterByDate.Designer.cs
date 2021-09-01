
namespace InvoiceApp.UI
{
    partial class frmInvoiceMasterByDate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlInvoiceDate = new System.Windows.Forms.Panel();
            this.cmbFromDay = new System.Windows.Forms.ComboBox();
            this.cmbFromMonth = new System.Windows.Forms.ComboBox();
            this.txtFromYear = new System.Windows.Forms.TextBox();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbToDay = new System.Windows.Forms.ComboBox();
            this.cmbToMonth = new System.Windows.Forms.ComboBox();
            this.txtToYear = new System.Windows.Forms.TextBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgReport = new System.Windows.Forms.DataGridView();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.InvoiceMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceRegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceRegisterTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInvoiceDate.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInvoiceDate
            // 
            this.pnlInvoiceDate.Controls.Add(this.cmbFromDay);
            this.pnlInvoiceDate.Controls.Add(this.cmbFromMonth);
            this.pnlInvoiceDate.Controls.Add(this.txtFromYear);
            this.pnlInvoiceDate.Location = new System.Drawing.Point(779, 9);
            this.pnlInvoiceDate.Name = "pnlInvoiceDate";
            this.pnlInvoiceDate.Size = new System.Drawing.Size(130, 30);
            this.pnlInvoiceDate.TabIndex = 28;
            // 
            // cmbFromDay
            // 
            this.cmbFromDay.Font = new System.Drawing.Font("IRANSansX", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFromDay.FormattingEnabled = true;
            this.cmbFromDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbFromDay.Location = new System.Drawing.Point(90, 2);
            this.cmbFromDay.Name = "cmbFromDay";
            this.cmbFromDay.Size = new System.Drawing.Size(36, 26);
            this.cmbFromDay.TabIndex = 27;
            this.cmbFromDay.Text = "01";
            this.cmbFromDay.SelectedValueChanged += new System.EventHandler(this.cmbFromDay_SelectedValueChanged);
            // 
            // cmbFromMonth
            // 
            this.cmbFromMonth.Font = new System.Drawing.Font("IRANSansX", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFromMonth.FormattingEnabled = true;
            this.cmbFromMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbFromMonth.Location = new System.Drawing.Point(52, 2);
            this.cmbFromMonth.Name = "cmbFromMonth";
            this.cmbFromMonth.Size = new System.Drawing.Size(36, 26);
            this.cmbFromMonth.TabIndex = 1;
            this.cmbFromMonth.Text = "01";
            this.cmbFromMonth.SelectedValueChanged += new System.EventHandler(this.cmbFromMonth_SelectedValueChanged);
            // 
            // txtFromYear
            // 
            this.txtFromYear.Font = new System.Drawing.Font("IRANSansX", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromYear.Location = new System.Drawing.Point(3, 3);
            this.txtFromYear.Name = "txtFromYear";
            this.txtFromYear.Size = new System.Drawing.Size(47, 25);
            this.txtFromYear.TabIndex = 0;
            this.txtFromYear.Text = "1400";
            this.txtFromYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromYear.TextChanged += new System.EventHandler(this.txtFromYear_TextChanged);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(907, 14);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(48, 20);
            this.lblFromDate.TabIndex = 27;
            this.lblFromDate.Text = "از تاریخ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbToDay);
            this.panel1.Controls.Add(this.cmbToMonth);
            this.panel1.Controls.Add(this.txtToYear);
            this.panel1.Location = new System.Drawing.Point(506, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 30);
            this.panel1.TabIndex = 30;
            // 
            // cmbToDay
            // 
            this.cmbToDay.Font = new System.Drawing.Font("IRANSansX", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbToDay.FormattingEnabled = true;
            this.cmbToDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbToDay.Location = new System.Drawing.Point(90, 2);
            this.cmbToDay.Name = "cmbToDay";
            this.cmbToDay.Size = new System.Drawing.Size(36, 26);
            this.cmbToDay.TabIndex = 27;
            this.cmbToDay.Text = "01";
            this.cmbToDay.SelectedValueChanged += new System.EventHandler(this.cmbToDay_SelectedValueChanged);
            // 
            // cmbToMonth
            // 
            this.cmbToMonth.Font = new System.Drawing.Font("IRANSansX", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbToMonth.FormattingEnabled = true;
            this.cmbToMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbToMonth.Location = new System.Drawing.Point(52, 2);
            this.cmbToMonth.Name = "cmbToMonth";
            this.cmbToMonth.Size = new System.Drawing.Size(36, 26);
            this.cmbToMonth.TabIndex = 1;
            this.cmbToMonth.Text = "01";
            this.cmbToMonth.SelectedValueChanged += new System.EventHandler(this.cmbToMonth_SelectedValueChanged);
            // 
            // txtToYear
            // 
            this.txtToYear.Font = new System.Drawing.Font("IRANSansX", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToYear.Location = new System.Drawing.Point(3, 3);
            this.txtToYear.Name = "txtToYear";
            this.txtToYear.Size = new System.Drawing.Size(47, 25);
            this.txtToYear.TabIndex = 0;
            this.txtToYear.Text = "1400";
            this.txtToYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToYear.TextChanged += new System.EventHandler(this.txtToYear_TextChanged);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(634, 13);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(50, 20);
            this.lblToDate.TabIndex = 29;
            this.lblToDate.Text = "تا تاریخ";
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.Font = new System.Drawing.Font("IRANSansX DemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(93, 11);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 30);
            this.btnView.TabIndex = 32;
            this.btnView.Text = "مشاهده";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = true;
            this.btnPrint.Font = new System.Drawing.Font("IRANSansX DemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(12, 11);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 30);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgReport
            // 
            this.dgReport.AllowUserToAddRows = false;
            this.dgReport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            this.dgReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("IRANSansX DemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceMasterId,
            this.InvoiceNumber,
            this.InvoiceType,
            this.InvoiceDate,
            this.CompanyName,
            this.PersonName,
            this.InvoiceRegisterDate,
            this.InvoiceRegisterTime,
            this.InvoiceDescription,
            this.InvoiceTypeId,
            this.CompanyId,
            this.PersonId});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReport.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgReport.EnableHeadersVisualStyles = false;
            this.dgReport.Location = new System.Drawing.Point(0, 198);
            this.dgReport.Name = "dgReport";
            this.dgReport.ReadOnly = true;
            this.dgReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("IRANSansX DemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgReport.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgReport.Size = new System.Drawing.Size(967, 283);
            this.dgReport.TabIndex = 33;
            // 
            // txtFromDate
            // 
            this.txtFromDate.Font = new System.Drawing.Font("IRANSansX", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromDate.Location = new System.Drawing.Point(298, 15);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFromDate.Size = new System.Drawing.Size(77, 24);
            this.txtFromDate.TabIndex = 38;
            this.txtFromDate.Text = "1400/01/01";
            this.txtFromDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromDate.Visible = false;
            // 
            // txtToDate
            // 
            this.txtToDate.Font = new System.Drawing.Font("IRANSansX", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToDate.Location = new System.Drawing.Point(215, 15);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtToDate.Size = new System.Drawing.Size(77, 24);
            this.txtToDate.TabIndex = 37;
            this.txtToDate.Text = "1400/01/01";
            this.txtToDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToDate.Visible = false;
            // 
            // InvoiceMasterId
            // 
            this.InvoiceMasterId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceMasterId.DataPropertyName = "InvoiceMasterId";
            this.InvoiceMasterId.HeaderText = "سریال";
            this.InvoiceMasterId.Name = "InvoiceMasterId";
            this.InvoiceMasterId.ReadOnly = true;
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceNumber.DataPropertyName = "InvoiceNumber";
            this.InvoiceNumber.HeaderText = "شماره فاکتور";
            this.InvoiceNumber.Name = "InvoiceNumber";
            this.InvoiceNumber.ReadOnly = true;
            // 
            // InvoiceType
            // 
            this.InvoiceType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceType.DataPropertyName = "InvoiceType";
            this.InvoiceType.HeaderText = "نوع فاکتور";
            this.InvoiceType.Name = "InvoiceType";
            this.InvoiceType.ReadOnly = true;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceDate.DataPropertyName = "InvoiceDate";
            this.InvoiceDate.HeaderText = "تاریخ فاکتور";
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "ارسال کننده";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // PersonName
            // 
            this.PersonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PersonName.DataPropertyName = "PersonName";
            this.PersonName.HeaderText = "ثبت کننده";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            // 
            // InvoiceRegisterDate
            // 
            this.InvoiceRegisterDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceRegisterDate.DataPropertyName = "InvoiceRegisterDate";
            this.InvoiceRegisterDate.HeaderText = "تاریخ ثبت";
            this.InvoiceRegisterDate.Name = "InvoiceRegisterDate";
            this.InvoiceRegisterDate.ReadOnly = true;
            // 
            // InvoiceRegisterTime
            // 
            this.InvoiceRegisterTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceRegisterTime.DataPropertyName = "InvoiceRegisterTime";
            this.InvoiceRegisterTime.HeaderText = "ساعت ثبت";
            this.InvoiceRegisterTime.Name = "InvoiceRegisterTime";
            this.InvoiceRegisterTime.ReadOnly = true;
            // 
            // InvoiceDescription
            // 
            this.InvoiceDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceDescription.DataPropertyName = "InvoiceDescription";
            this.InvoiceDescription.HeaderText = "توضیحات";
            this.InvoiceDescription.Name = "InvoiceDescription";
            this.InvoiceDescription.ReadOnly = true;
            // 
            // InvoiceTypeId
            // 
            this.InvoiceTypeId.DataPropertyName = "InvoiceTypeId";
            this.InvoiceTypeId.HeaderText = "InvoiceTypeId";
            this.InvoiceTypeId.Name = "InvoiceTypeId";
            this.InvoiceTypeId.ReadOnly = true;
            this.InvoiceTypeId.Visible = false;
            // 
            // CompanyId
            // 
            this.CompanyId.DataPropertyName = "CompanyId";
            this.CompanyId.HeaderText = "CompanyId";
            this.CompanyId.Name = "CompanyId";
            this.CompanyId.ReadOnly = true;
            this.CompanyId.Visible = false;
            // 
            // PersonId
            // 
            this.PersonId.DataPropertyName = "PersonId";
            this.PersonId.HeaderText = "PersonId";
            this.PersonId.Name = "PersonId";
            this.PersonId.ReadOnly = true;
            this.PersonId.Visible = false;
            // 
            // frmInvoiceMasterByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(967, 481);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.dgReport);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.pnlInvoiceDate);
            this.Controls.Add(this.lblFromDate);
            this.Name = "frmInvoiceMasterByDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش فاکتورها به تفکیک تاریخ";
            this.pnlInvoiceDate.ResumeLayout(false);
            this.pnlInvoiceDate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInvoiceDate;
        private System.Windows.Forms.ComboBox cmbFromDay;
        private System.Windows.Forms.ComboBox cmbFromMonth;
        private System.Windows.Forms.TextBox txtFromYear;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbToDay;
        private System.Windows.Forms.ComboBox cmbToMonth;
        private System.Windows.Forms.TextBox txtToYear;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgReport;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceRegisterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceRegisterTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonId;
    }
}