namespace CarsManagement.FormsApp
{
    partial class CarsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsForm));
            listBox1 = new ListBox();
            btnPreviousPage = new Button();
            btnNextPage = new Button();
            lblCurrentPage = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            rbDesc = new RadioButton();
            rbAsc = new RadioButton();
            label1 = new Label();
            lblHP = new Label();
            lblYear = new Label();
            txtModel = new TextBox();
            txtID = new TextBox();
            panel2 = new Panel();
            rbDelete = new RadioButton();
            rbUpdate = new RadioButton();
            rbAdd = new RadioButton();
            btnAction = new Button();
            lblID = new Label();
            lblModel = new Label();
            lblColor = new Label();
            txtColor = new TextBox();
            txtHP = new TextBox();
            txtYear = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(496, 17);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(395, 454);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Image = (Image)resources.GetObject("btnPreviousPage.Image");
            btnPreviousPage.ImageAlign = ContentAlignment.MiddleLeft;
            btnPreviousPage.Location = new Point(50, 35);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(118, 74);
            btnPreviousPage.TabIndex = 2;
            btnPreviousPage.Text = "<<";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Image = (Image)resources.GetObject("btnNextPage.Image");
            btnNextPage.ImageAlign = ContentAlignment.MiddleRight;
            btnNextPage.Location = new Point(189, 35);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(118, 74);
            btnNextPage.TabIndex = 3;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // lblCurrentPage
            // 
            lblCurrentPage.AutoSize = true;
            lblCurrentPage.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblCurrentPage.ForeColor = SystemColors.ButtonFace;
            lblCurrentPage.Location = new Point(359, 53);
            lblCurrentPage.Name = "lblCurrentPage";
            lblCurrentPage.Size = new Size(20, 24);
            lblCurrentPage.TabIndex = 4;
            lblCurrentPage.Text = "0";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(347, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(90, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbDesc);
            panel1.Controls.Add(rbAsc);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(496, 477);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 73);
            panel1.TabIndex = 7;
            // 
            // rbDesc
            // 
            rbDesc.AutoSize = true;
            rbDesc.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbDesc.ForeColor = SystemColors.ButtonFace;
            rbDesc.Location = new Point(295, 16);
            rbDesc.Name = "rbDesc";
            rbDesc.Size = new Size(95, 44);
            rbDesc.TabIndex = 2;
            rbDesc.TabStop = true;
            rbDesc.Text = "Desc";
            rbDesc.UseVisualStyleBackColor = true;
            rbDesc.CheckedChanged += rbDesc_CheckedChanged;
            // 
            // rbAsc
            // 
            rbAsc.AutoSize = true;
            rbAsc.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbAsc.ForeColor = SystemColors.ButtonFace;
            rbAsc.Location = new Point(146, 16);
            rbAsc.Name = "rbAsc";
            rbAsc.Size = new Size(79, 44);
            rbAsc.TabIndex = 1;
            rbAsc.TabStop = true;
            rbAsc.Text = "Asc";
            rbAsc.UseVisualStyleBackColor = true;
            rbAsc.CheckedChanged += rbAsc_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(75, 40);
            label1.TabIndex = 0;
            label1.Text = "Sort:";
            // 
            // lblHP
            // 
            lblHP.AutoSize = true;
            lblHP.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblHP.ForeColor = SystemColors.ButtonFace;
            lblHP.Location = new Point(50, 287);
            lblHP.Name = "lblHP";
            lblHP.Size = new Size(125, 24);
            lblHP.TabIndex = 8;
            lblHP.Text = "Horse Power:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblYear.ForeColor = SystemColors.ButtonFace;
            lblYear.Location = new Point(50, 322);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(54, 24);
            lblYear.TabIndex = 9;
            lblYear.Text = "Year:";
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Microsoft Sans Serif", 14.25F);
            txtModel.Location = new Point(198, 208);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(237, 29);
            txtModel.TabIndex = 10;
            // 
            // txtID
            // 
            txtID.Font = new Font("Microsoft Sans Serif", 14.25F);
            txtID.Location = new Point(198, 174);
            txtID.Name = "txtID";
            txtID.Size = new Size(237, 29);
            txtID.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(rbDelete);
            panel2.Controls.Add(rbUpdate);
            panel2.Controls.Add(rbAdd);
            panel2.Location = new Point(50, 397);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 73);
            panel2.TabIndex = 12;
            // 
            // rbDelete
            // 
            rbDelete.AutoSize = true;
            rbDelete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbDelete.ForeColor = SystemColors.ButtonFace;
            rbDelete.Location = new Point(261, 20);
            rbDelete.Name = "rbDelete";
            rbDelete.Size = new Size(102, 36);
            rbDelete.TabIndex = 2;
            rbDelete.TabStop = true;
            rbDelete.Text = "Delete";
            rbDelete.UseVisualStyleBackColor = true;
            rbDelete.CheckedChanged += rbDelete_CheckedChanged;
            // 
            // rbUpdate
            // 
            rbUpdate.AutoSize = true;
            rbUpdate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbUpdate.ForeColor = SystemColors.ButtonFace;
            rbUpdate.Location = new Point(124, 20);
            rbUpdate.Name = "rbUpdate";
            rbUpdate.Size = new Size(109, 36);
            rbUpdate.TabIndex = 1;
            rbUpdate.TabStop = true;
            rbUpdate.Text = "Update";
            rbUpdate.UseVisualStyleBackColor = true;
            rbUpdate.CheckedChanged += rbUpdate_CheckedChanged;
            // 
            // rbAdd
            // 
            rbAdd.AutoSize = true;
            rbAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbAdd.ForeColor = SystemColors.ButtonFace;
            rbAdd.Location = new Point(23, 20);
            rbAdd.Name = "rbAdd";
            rbAdd.Size = new Size(75, 36);
            rbAdd.TabIndex = 0;
            rbAdd.TabStop = true;
            rbAdd.Text = "Add";
            rbAdd.UseVisualStyleBackColor = true;
            rbAdd.CheckedChanged += rbAdd_CheckedChanged;
            // 
            // btnAction
            // 
            btnAction.Location = new Point(50, 476);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(385, 74);
            btnAction.TabIndex = 3;
            btnAction.Text = "button1";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblID.ForeColor = SystemColors.ButtonFace;
            lblID.Location = new Point(50, 177);
            lblID.Name = "lblID";
            lblID.Size = new Size(32, 24);
            lblID.TabIndex = 13;
            lblID.Text = "ID:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblModel.ForeColor = SystemColors.ButtonFace;
            lblModel.Location = new Point(50, 213);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(68, 24);
            lblModel.TabIndex = 14;
            lblModel.Text = "Model:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblColor.ForeColor = SystemColors.ButtonFace;
            lblColor.Location = new Point(50, 247);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(60, 24);
            lblColor.TabIndex = 15;
            lblColor.Text = "Color:";
            // 
            // txtColor
            // 
            txtColor.Font = new Font("Microsoft Sans Serif", 14.25F);
            txtColor.Location = new Point(198, 244);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(237, 29);
            txtColor.TabIndex = 16;
            // 
            // txtHP
            // 
            txtHP.Font = new Font("Microsoft Sans Serif", 14.25F);
            txtHP.Location = new Point(198, 282);
            txtHP.Name = "txtHP";
            txtHP.Size = new Size(237, 29);
            txtHP.TabIndex = 17;
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Microsoft Sans Serif", 14.25F);
            txtYear.Location = new Point(198, 317);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(237, 29);
            txtYear.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(69, 112);
            label7.Name = "label7";
            label7.Size = new Size(80, 21);
            label7.TabIndex = 19;
            label7.Text = "Next page";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(194, 112);
            label8.Name = "label8";
            label8.Size = new Size(108, 21);
            label8.TabIndex = 20;
            label8.Text = "Previous page";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(347, 94);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 23;
            label9.Text = "Items per page:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(359, 35);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 24;
            label11.Text = "Page:";
            // 
            // CarsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(931, 571);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtYear);
            Controls.Add(txtHP);
            Controls.Add(txtColor);
            Controls.Add(lblColor);
            Controls.Add(lblModel);
            Controls.Add(lblID);
            Controls.Add(btnAction);
            Controls.Add(panel2);
            Controls.Add(txtID);
            Controls.Add(txtModel);
            Controls.Add(lblYear);
            Controls.Add(lblHP);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(lblCurrentPage);
            Controls.Add(btnNextPage);
            Controls.Add(btnPreviousPage);
            Controls.Add(listBox1);
            Name = "CarsForm";
            Text = "CarsForm";
            Load += CarsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private Button btnPreviousPage;
        private Button btnNextPage;
        private Label lblCurrentPage;
        private ComboBox comboBox1;
        private Panel panel1;
        private RadioButton rbDesc;
        private RadioButton rbAsc;
        private Label label1;
        private Label lblHP;
        private Label lblYear;
        private TextBox txtModel;
        private TextBox txtID;
        private Panel panel2;
        private RadioButton rbDelete;
        private RadioButton rbUpdate;
        private RadioButton rbAdd;
        private Button btnAction;
        private Label lblID;
        private Label lblModel;
        private Label lblColor;
        private TextBox txtColor;
        private TextBox txtHP;
        private TextBox txtYear;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label2;
    }
}