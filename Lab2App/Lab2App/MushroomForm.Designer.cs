namespace Lab2App
{
    partial class MushroomForm
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
            lblInfo = new Label();
            lblQuestion = new Label();
            btnYes = new Button();
            btnNo = new Button();
            btnBack = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(334, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mushroom Guess";
            // 
            // lblInfo
            // 
            lblInfo.Location = new Point(180, 60);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(405, 46);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Think of one of these mushrooms: Agaric Jaunissant, Amanite tue-mouche, Cepe de bordeaux, Coprin chevelu, Girolle, Pied bleu";
            // 
            // lblQuestion
            // 
            lblQuestion.BackColor = Color.DarkGoldenrod;
            lblQuestion.Location = new Point(180, 126);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(366, 23);
            lblQuestion.TabIndex = 2;
            lblQuestion.Click += lblQuestion_Click;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.DarkGoldenrod;
            btnYes.Location = new Point(167, 184);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(88, 33);
            btnYes.TabIndex = 3;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.DarkGoldenrod;
            btnNo.Location = new Point(462, 184);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(84, 33);
            btnNo.TabIndex = 4;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkGoldenrod;
            btnBack.Location = new Point(12, 311);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 35);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkGoldenrod;
            btnLogout.Location = new Point(700, 311);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(88, 35);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // MushroomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnBack);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(lblQuestion);
            Controls.Add(lblInfo);
            Controls.Add(lblTitle);
            Name = "MushroomForm";
            Text = "MushroomForm";
            Load += MushroomForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInfo;
        private Label lblQuestion;
        private Button btnYes;
        private Button btnNo;
        private Button btnBack;
        private Button btnLogout;
    }
}