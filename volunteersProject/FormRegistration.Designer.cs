namespace volunteersProject
{
    partial class FormRegistration
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
            panelMain = new Panel();
            textBoxLogin = new TextBox();
            buttonGuest = new Button();
            buttonEnter = new Button();
            textBoxPass = new TextBox();
            labelPass = new Label();
            labelLogin = new Label();
            pictureBox1 = new PictureBox();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(textBoxLogin);
            panelMain.Controls.Add(buttonGuest);
            panelMain.Controls.Add(buttonEnter);
            panelMain.Controls.Add(textBoxPass);
            panelMain.Controls.Add(labelPass);
            panelMain.Controls.Add(labelLogin);
            panelMain.Location = new Point(61, 157);
            panelMain.Margin = new Padding(4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(463, 341);
            panelMain.TabIndex = 2;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(71, 67);
            textBoxLogin.Margin = new Padding(4);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(320, 26);
            textBoxLogin.TabIndex = 6;
            // 
            // buttonGuest
            // 
            buttonGuest.BackColor = Color.FromArgb(76, 175, 80);
            buttonGuest.FlatStyle = FlatStyle.Flat;
            buttonGuest.ForeColor = Color.White;
            buttonGuest.Location = new Point(135, 276);
            buttonGuest.Margin = new Padding(4);
            buttonGuest.Name = "buttonGuest";
            buttonGuest.Size = new Size(193, 38);
            buttonGuest.TabIndex = 5;
            buttonGuest.Text = "Войти как гость";
            buttonGuest.UseVisualStyleBackColor = false;
            buttonGuest.Click += buttonGuest_Click;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.FromArgb(76, 175, 80);
            buttonEnter.FlatStyle = FlatStyle.Flat;
            buttonEnter.ForeColor = Color.White;
            buttonEnter.Location = new Point(135, 218);
            buttonEnter.Margin = new Padding(4);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(193, 38);
            buttonEnter.TabIndex = 4;
            buttonEnter.Text = "Войти";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(71, 165);
            textBoxPass.Margin = new Padding(4);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(320, 26);
            textBoxPass.TabIndex = 3;
            textBoxPass.UseSystemPasswordChar = true;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Location = new Point(194, 120);
            labelPass.Margin = new Padding(4, 0, 4, 0);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(58, 19);
            labelPass.TabIndex = 2;
            labelPass.Text = "Пароль";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(198, 23);
            labelLogin.Margin = new Padding(4, 0, 4, 0);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(52, 19);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Логин";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(242, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 511);
            Controls.Add(pictureBox1);
            Controls.Add(panelMain);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistration";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private TextBox textBoxLogin;
        private Button buttonGuest;
        private Button buttonEnter;
        private TextBox textBoxPass;
        private Label labelPass;
        private Label labelLogin;
        private PictureBox pictureBox1;
    }
}