namespace CarsManagement.FormsApp
{
    partial class ManufacturerCarsForm
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
            btnExit = new Button();
            btnUpdateCars = new Button();
            checkedListBox1 = new CheckedListBox();
            lblYear = new Label();
            lblName = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14.25F);
            btnExit.Location = new Point(1, 330);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(153, 60);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdateCars
            // 
            btnUpdateCars.Font = new Font("Segoe UI", 14.25F);
            btnUpdateCars.Location = new Point(1, 223);
            btnUpdateCars.Name = "btnUpdateCars";
            btnUpdateCars.Size = new Size(153, 64);
            btnUpdateCars.TabIndex = 8;
            btnUpdateCars.Text = "Update";
            btnUpdateCars.UseVisualStyleBackColor = true;
            btnUpdateCars.Click += btnUpdateCars_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(208, 26);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(352, 364);
            checkedListBox1.TabIndex = 7;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 14.25F);
            lblYear.Location = new Point(33, 110);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(63, 25);
            lblYear.TabIndex = 6;
            lblYear.Text = "label1";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14.25F);
            lblName.Location = new Point(33, 60);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 25);
            lblName.TabIndex = 5;
            lblName.Text = "label1";
            // 
            // ManufacturerCarsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 450);
            Controls.Add(btnExit);
            Controls.Add(btnUpdateCars);
            Controls.Add(checkedListBox1);
            Controls.Add(lblYear);
            Controls.Add(lblName);
            Name = "ManufacturerCarsForm";
            Text = "ManufacturerCarsForm";
            Load += ManufacturerCarsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnUpdateCars;
        private CheckedListBox checkedListBox1;
        private Label lblYear;
        private Label lblName;
    }
}