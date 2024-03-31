namespace CarsManagement.FormsApp
{
    partial class ManufacturersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManufacturersForm));
            btnCars = new Button();
            cmbOrder = new ComboBox();
            label8 = new Label();
            lblPages = new Label();
            lblCount = new Label();
            label6 = new Label();
            label5 = new Label();
            btnAction = new Button();
            panel1 = new Panel();
            rbDelete = new RadioButton();
            rbUpdate = new RadioButton();
            rbAdd = new RadioButton();
            label1 = new Label();
            txtName = new TextBox();
            btnNext = new Button();
            btnPrevious = new Button();
            dataGridView1 = new DataGridView();
            ImageUrl = new DataGridViewTextBoxColumn();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCars
            // 
            btnCars.Font = new Font("Segoe UI", 18F);
            btnCars.Location = new Point(202, 398);
            btnCars.Name = "btnCars";
            btnCars.Size = new Size(117, 95);
            btnCars.TabIndex = 46;
            btnCars.Text = "Cars";
            btnCars.UseVisualStyleBackColor = true;
            btnCars.Click += btnCars_Click;
            // 
            // cmbOrder
            // 
            cmbOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrder.FormattingEnabled = true;
            cmbOrder.Items.AddRange(new object[] { "ASC", "DESC" });
            cmbOrder.Location = new Point(645, 440);
            cmbOrder.Name = "cmbOrder";
            cmbOrder.Size = new Size(105, 23);
            cmbOrder.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(602, 443);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 44;
            label8.Text = "Order";
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.ForeColor = SystemColors.ButtonFace;
            lblPages.Location = new Point(901, 481);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(38, 15);
            lblPages.TabIndex = 40;
            lblPages.Text = "label7";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.ForeColor = SystemColors.ButtonFace;
            lblCount.Location = new Point(901, 443);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(38, 15);
            lblCount.TabIndex = 39;
            lblCount.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(854, 481);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 38;
            label6.Text = "Pages:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(774, 443);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 37;
            label5.Text = "Manufacturers count:";
            // 
            // btnAction
            // 
            btnAction.Font = new Font("Segoe UI", 18F);
            btnAction.Location = new Point(9, 398);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(183, 95);
            btnAction.TabIndex = 36;
            btnAction.Text = "Add";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbDelete);
            panel1.Controls.Add(rbUpdate);
            panel1.Controls.Add(rbAdd);
            panel1.Font = new Font("Segoe UI", 18F);
            panel1.Location = new Point(8, 291);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 51);
            panel1.TabIndex = 35;
            // 
            // rbDelete
            // 
            rbDelete.AutoSize = true;
            rbDelete.ForeColor = SystemColors.ButtonFace;
            rbDelete.Location = new Point(205, 3);
            rbDelete.Name = "rbDelete";
            rbDelete.Size = new Size(102, 36);
            rbDelete.TabIndex = 2;
            rbDelete.TabStop = true;
            rbDelete.Text = "Delete";
            rbDelete.UseVisualStyleBackColor = true;
            // 
            // rbUpdate
            // 
            rbUpdate.AutoSize = true;
            rbUpdate.ForeColor = SystemColors.ButtonFace;
            rbUpdate.Location = new Point(92, 3);
            rbUpdate.Name = "rbUpdate";
            rbUpdate.Size = new Size(109, 36);
            rbUpdate.TabIndex = 1;
            rbUpdate.TabStop = true;
            rbUpdate.Text = "Update";
            rbUpdate.UseVisualStyleBackColor = true;
            // 
            // rbAdd
            // 
            rbAdd.AutoSize = true;
            rbAdd.ForeColor = SystemColors.ButtonFace;
            rbAdd.Location = new Point(11, 3);
            rbAdd.Name = "rbAdd";
            rbAdd.Size = new Size(75, 36);
            rbAdd.TabIndex = 0;
            rbAdd.TabStop = true;
            rbAdd.Text = "Add";
            rbAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(8, 76);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 28;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 18F);
            txtName.Location = new Point(101, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(218, 39);
            txtName.TabIndex = 27;
            // 
            // btnNext
            // 
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(467, 435);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(107, 95);
            btnNext.TabIndex = 26;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click_1;
            // 
            // btnPrevious
            // 
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrevious.Location = new Point(356, 435);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(105, 95);
            btnPrevious.TabIndex = 25;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ImageUrl });
            dataGridView1.Location = new Point(356, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(603, 394);
            dataGridView1.TabIndex = 24;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // ImageUrl
            // 
            ImageUrl.DataPropertyName = "ImageUrl";
            ImageUrl.HeaderText = "ImageUrl";
            ImageUrl.MinimumWidth = 6;
            ImageUrl.Name = "ImageUrl";
            ImageUrl.Visible = false;
            ImageUrl.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(9, 161);
            label3.Name = "label3";
            label3.Size = new Size(58, 32);
            label3.TabIndex = 31;
            label3.Text = "Year";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.Font = new Font("Segoe UI", 18F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(101, 158);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(218, 39);
            dateTimePicker1.TabIndex = 32;
            // 
            // ManufacturersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(989, 537);
            Controls.Add(btnCars);
            Controls.Add(cmbOrder);
            Controls.Add(label8);
            Controls.Add(lblPages);
            Controls.Add(lblCount);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnAction);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(dataGridView1);
            Name = "ManufacturersForm";
            Text = "ManufacturersForm";
            Load += ManufacturersForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCars;
        private ComboBox cmbOrder;
        private Label label8;
        private Label lblPages;
        private Label lblCount;
        private Label label6;
        private Label label5;
        private Button btnAction;
        private Panel panel1;
        private RadioButton rbDelete;
        private RadioButton rbUpdate;
        private RadioButton rbAdd;
        private Label label1;
        private TextBox txtName;
        private Button btnNext;
        private Button btnPrevious;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ImageUrl;
        private Label label3;
        private DateTimePicker dateTimePicker1;
    }
}