using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;
using System.Drawing.Printing;

namespace GameCard_SE172956
{
    partial class StaffForm
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
            lblFormTitle = new Label();
            lblBookList = new Label();
            dgvGameCardList = new DataGridView();
            gbSearch = new GroupBox();
            btnSearch = new Button();
            lblKeyword = new Label();
            txtKeyword = new TextBox();
            gbTask = new GroupBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            gbSunglassInfo = new GroupBox();
            txtPlatForm = new TextBox();
            label3 = new Label();
            cbProvider = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            lblMaterial = new Label();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            dtpCreatedDate = new DateTimePicker();
            txtName = new TextBox();
            txtId = new TextBox();
            lblManufacturer = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblCreatedDate = new Label();
            lblFeature = new Label();
            lblName = new Label();
            lblId = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGameCardList).BeginInit();
            gbSearch.SuspendLayout();
            gbTask.SuspendLayout();
            gbSunglassInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.Yellow;
            lblFormTitle.Location = new Point(37, 60);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(312, 46);
            lblFormTitle.TabIndex = 25;
            lblFormTitle.Text = "Sunglass Manager";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.ForeColor = Color.Yellow;
            lblBookList.Location = new Point(576, 252);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(92, 20);
            lblBookList.TabIndex = 29;
            lblBookList.Text = "Sunglass List";
            // 
            // dgvGameCardList
            // 
            dgvGameCardList.BackgroundColor = Color.White;
            dgvGameCardList.BorderStyle = BorderStyle.Fixed3D;
            dgvGameCardList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGameCardList.Location = new Point(576, 284);
            dgvGameCardList.Name = "dgvGameCardList";
            dgvGameCardList.RowHeadersWidth = 51;
            dgvGameCardList.RowTemplate.Height = 29;
            dgvGameCardList.Size = new Size(523, 371);
            dgvGameCardList.TabIndex = 24;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(lblKeyword);
            gbSearch.Controls.Add(txtKeyword);
            gbSearch.ForeColor = Color.Yellow;
            gbSearch.Location = new Point(576, 132);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(451, 80);
            gbSearch.TabIndex = 28;
            gbSearch.TabStop = false;
            gbSearch.Text = " Search ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 0, 0);
            btnSearch.Location = new Point(331, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(18, 36);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(67, 20);
            lblKeyword.TabIndex = 18;
            lblKeyword.Text = "Keyword";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(91, 35);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(221, 27);
            txtKeyword.TabIndex = 0;
            // 
            // gbTask
            // 
            gbTask.Controls.Add(btnExit);
            gbTask.Controls.Add(btnDelete);
            gbTask.Controls.Add(btnUpdate);
            gbTask.Controls.Add(btnAdd);
            gbTask.ForeColor = Color.Yellow;
            gbTask.Location = new Point(37, 589);
            gbTask.Name = "gbTask";
            gbTask.Size = new Size(501, 80);
            gbTask.TabIndex = 27;
            gbTask.TabStop = false;
            gbTask.Text = " Task ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Location = new Point(389, 35);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(264, 35);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 0, 0);
            btnUpdate.Location = new Point(141, 35);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 0, 0);
            btnAdd.Location = new Point(17, 35);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // gbSunglassInfo
            // 
            gbSunglassInfo.Controls.Add(txtPlatForm);
            gbSunglassInfo.Controls.Add(label3);
            gbSunglassInfo.Controls.Add(cbProvider);
            gbSunglassInfo.Controls.Add(label2);
            gbSunglassInfo.Controls.Add(label1);
            gbSunglassInfo.Controls.Add(lblMaterial);
            gbSunglassInfo.Controls.Add(txtDescription);
            gbSunglassInfo.Controls.Add(txtPrice);
            gbSunglassInfo.Controls.Add(txtQuantity);
            gbSunglassInfo.Controls.Add(dtpCreatedDate);
            gbSunglassInfo.Controls.Add(txtName);
            gbSunglassInfo.Controls.Add(txtId);
            gbSunglassInfo.Controls.Add(lblManufacturer);
            gbSunglassInfo.Controls.Add(lblPrice);
            gbSunglassInfo.Controls.Add(lblQuantity);
            gbSunglassInfo.Controls.Add(lblCreatedDate);
            gbSunglassInfo.Controls.Add(lblFeature);
            gbSunglassInfo.Controls.Add(lblName);
            gbSunglassInfo.Controls.Add(lblId);
            gbSunglassInfo.ForeColor = Color.Yellow;
            gbSunglassInfo.Location = new Point(37, 132);
            gbSunglassInfo.Name = "gbSunglassInfo";
            gbSunglassInfo.Size = new Size(501, 445);
            gbSunglassInfo.TabIndex = 26;
            gbSunglassInfo.TabStop = false;
            gbSunglassInfo.Text = "Sunglass Info ";
            // 
            // txtPlatForm
            // 
            txtPlatForm.Location = new Point(127, 220);
            txtPlatForm.Name = "txtPlatForm";
            txtPlatForm.Size = new Size(353, 27);
            txtPlatForm.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 396);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 18;
            label3.Text = "Provider";
            // 
            // cbProvider
            // 
            cbProvider.FormattingEnabled = true;
            cbProvider.Location = new Point(127, 393);
            cbProvider.Name = "cbProvider";
            cbProvider.Size = new Size(355, 28);
            cbProvider.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 223);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 16;
            label2.Text = "Platform";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 164);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 13;
            label1.Text = "Description";
            // 
            // lblMaterial
            // 
            lblMaterial.Location = new Point(0, 0);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(100, 23);
            lblMaterial.TabIndex = 14;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(129, 164);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(353, 27);
            txtDescription.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(357, 329);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(129, 329);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(153, 27);
            txtQuantity.TabIndex = 4;
            // 
            // dtpCreatedDate
            // 
            dtpCreatedDate.CustomFormat = "dd/MM/yyyy";
            dtpCreatedDate.Format = DateTimePickerFormat.Custom;
            dtpCreatedDate.Location = new Point(129, 273);
            dtpCreatedDate.Name = "dtpCreatedDate";
            dtpCreatedDate.Size = new Size(153, 27);
            dtpCreatedDate.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(127, 113);
            txtName.Name = "txtName";
            txtName.Size = new Size(353, 27);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLightLight;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(127, 60);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 0;
            // 
            // lblManufacturer
            // 
            lblManufacturer.Location = new Point(0, 0);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(100, 23);
            lblManufacturer.TabIndex = 15;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(299, 333);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(19, 333);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Location = new Point(17, 281);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(97, 20);
            lblCreatedDate.TabIndex = 3;
            lblCreatedDate.Text = "Created Date";
            // 
            // lblFeature
            // 
            lblFeature.AutoSize = true;
            lblFeature.Location = new Point(17, 136);
            lblFeature.Name = "lblFeature";
            lblFeature.Size = new Size(0, 20);
            lblFeature.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(19, 116);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.Yellow;
            lblId.Location = new Point(19, 62);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1141, 761);
            Controls.Add(lblFormTitle);
            Controls.Add(lblBookList);
            Controls.Add(dgvGameCardList);
            Controls.Add(gbSearch);
            Controls.Add(gbTask);
            Controls.Add(gbSunglassInfo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StaffForm";
            Text = "StaffForm";
            FormClosed += StaffForm_FormClosed;
            Load += StaffForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGameCardList).EndInit();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            gbTask.ResumeLayout(false);
            gbSunglassInfo.ResumeLayout(false);
            gbSunglassInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private Label lblBookList;
        private DataGridView dgvGameCardList;
        private GroupBox gbSearch;
        private Button btnSearch;
        private Label lblKeyword;
        private TextBox txtKeyword;
        private GroupBox gbTask;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox gbSunglassInfo;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private ComboBox cboManufacture;
        private DateTimePicker dtpCreatedDate;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblManufacturer;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblCreatedDate;
        private Label lblFeature;
        private Label lblName;
        private Label lblId;
        private Label lblShape;
        private TextBox txtMaterial;
        private Label lblMaterial;
        private TextBox txtFeature;
        private TextBox txtShape;
        private Label label1;
        private TextBox txtPlatForm;
        private Label label3;
        private ComboBox cbProvider;
        private Label label2;
    }
}