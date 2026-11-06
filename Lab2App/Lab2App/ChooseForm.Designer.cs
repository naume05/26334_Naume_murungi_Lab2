namespace Lab2App
{
    partial class ChooseForm
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
            btnBicycle = new Button();
            btnMushroom = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.DarkCyan;
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(236, 41);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(146, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Choose an Option";
            lblTitle.Click += label1_Click;
            // 
            // btnBicycle
            // 
            btnBicycle.BackColor = Color.DarkCyan;
            btnBicycle.Location = new Point(101, 182);
            btnBicycle.Margin = new Padding(4);
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Size = new Size(138, 52);
            btnBicycle.TabIndex = 1;
            btnBicycle.Text = "Bicycle";
            btnBicycle.UseVisualStyleBackColor = false;
            btnBicycle.Click += btnBicycle_Click;
            // 
            // btnMushroom
            // 
            btnMushroom.BackColor = Color.DarkCyan;
            btnMushroom.Location = new Point(384, 182);
            btnMushroom.Name = "btnMushroom";
            btnMushroom.Size = new Size(137, 52);
            btnMushroom.TabIndex = 2;
            btnMushroom.Text = "Mushroom";
            btnMushroom.UseVisualStyleBackColor = false;
            btnMushroom.Click += btnMushroom_Click;
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(695, 323);
            Controls.Add(btnMushroom);
            Controls.Add(btnBicycle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ChooseForm";
            Text = "ChooseForm";
            Load += ChooseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnBicycle;
        private Button btnMushroom;
    }
}