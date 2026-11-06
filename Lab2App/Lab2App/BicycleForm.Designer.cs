namespace Lab2App
{
    partial class BicycleForm
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
            lblTitle = new Label();
            lblStart = new Label();
            txtStart = new TextBox();
            lblEnd = new Label();
            txtEnd = new TextBox();
            btnCalculate = new Button();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnBack = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.DarkCyan;
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(335, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(80, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bicycle Rental";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.BackColor = Color.DarkCyan;
            lblStart.ForeColor = Color.Black;
            lblStart.Location = new Point(87, 75);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(78, 15);
            lblStart.TabIndex = 1;
            lblStart.Text = "Starting Time";
            lblStart.Click += lblStart_Click;
            // 
            // txtStart
            // 
            txtStart.ForeColor = Color.DarkCyan;
            txtStart.Location = new Point(186, 72);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(100, 23);
            txtStart.TabIndex = 2;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.BackColor = Color.DarkCyan;
            lblEnd.Location = new Point(91, 127);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(74, 15);
            lblEnd.TabIndex = 3;
            lblEnd.Text = "Ending Time";
            lblEnd.Click += lblEnd_Click;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(186, 124);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(100, 23);
            txtEnd.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.DarkCyan;
            btnCalculate.ForeColor = Color.Black;
            btnCalculate.Location = new Point(199, 175);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.DarkCyan;
            lblTotal.Location = new Point(112, 230);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total";
            lblTotal.Click += lblTotal_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(186, 222);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkCyan;
            btnBack.Location = new Point(56, 300);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkCyan;
            btnLogout.Location = new Point(225, 300);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // BicycleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnBack);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(btnCalculate);
            Controls.Add(txtEnd);
            Controls.Add(lblEnd);
            Controls.Add(txtStart);
            Controls.Add(lblStart);
            Controls.Add(lblTitle);
            Name = "BicycleForm";
            Text = "BicycleForm";
            Load += BicycleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStart;
        private TextBox txtStart;
        private Label lblEnd;
        private TextBox txtEnd;
        private Button btnCalculate;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnBack;
        private Button btnLogout;
    }
}