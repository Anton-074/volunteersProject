namespace volunteersProject
{
    partial class FormAdd
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
            panelFill = new Panel();
            dateTimePickerDate = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            comboBoxStatuse = new ComboBox();
            label2 = new Label();
            comboBoxVolunteer = new ComboBox();
            textBoxCountVolunteers = new TextBox();
            label1 = new Label();
            textBoxName = new TextBox();
            labelIName = new Label();
            labelGPalce = new Label();
            comboBoxPlace = new ComboBox();
            labelCategory = new Label();
            comboBoxCategory = new ComboBox();
            panelBottom = new Panel();
            buttonCancel = new Button();
            buttonSave = new Button();
            panelTop = new Panel();
            labelAddEvent = new Label();
            panelFill.SuspendLayout();
            panelBottom.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(dateTimePickerDate);
            panelFill.Controls.Add(label4);
            panelFill.Controls.Add(label3);
            panelFill.Controls.Add(comboBoxStatuse);
            panelFill.Controls.Add(label2);
            panelFill.Controls.Add(comboBoxVolunteer);
            panelFill.Controls.Add(textBoxCountVolunteers);
            panelFill.Controls.Add(label1);
            panelFill.Controls.Add(textBoxName);
            panelFill.Controls.Add(labelIName);
            panelFill.Controls.Add(labelGPalce);
            panelFill.Controls.Add(comboBoxPlace);
            panelFill.Controls.Add(labelCategory);
            panelFill.Controls.Add(comboBoxCategory);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 72);
            panelFill.Margin = new Padding(4);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(13);
            panelFill.Size = new Size(718, 466);
            panelFill.TabIndex = 5;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(72, 424);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(575, 26);
            dateTimePickerDate.TabIndex = 13;
            // 
            // label4
            // 
            label4.Location = new Point(72, 375);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(575, 34);
            label4.TabIndex = 12;
            label4.Text = "Дата";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(406, 266);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(239, 34);
            label3.TabIndex = 11;
            label3.Text = "Статус";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxStatuse
            // 
            comboBoxStatuse.FormattingEnabled = true;
            comboBoxStatuse.Location = new Point(407, 304);
            comboBoxStatuse.Margin = new Padding(4);
            comboBoxStatuse.Name = "comboBoxStatuse";
            comboBoxStatuse.Size = new Size(238, 27);
            comboBoxStatuse.TabIndex = 10;
            // 
            // label2
            // 
            label2.Location = new Point(72, 266);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(239, 34);
            label2.TabIndex = 9;
            label2.Text = "Главный волонтер";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxVolunteer
            // 
            comboBoxVolunteer.FormattingEnabled = true;
            comboBoxVolunteer.Location = new Point(73, 304);
            comboBoxVolunteer.Margin = new Padding(4);
            comboBoxVolunteer.Name = "comboBoxVolunteer";
            comboBoxVolunteer.Size = new Size(238, 27);
            comboBoxVolunteer.TabIndex = 8;
            // 
            // textBoxCountVolunteers
            // 
            textBoxCountVolunteers.Location = new Point(407, 186);
            textBoxCountVolunteers.Margin = new Padding(4);
            textBoxCountVolunteers.Name = "textBoxCountVolunteers";
            textBoxCountVolunteers.Size = new Size(238, 26);
            textBoxCountVolunteers.TabIndex = 7;
            // 
            // label1
            // 
            label1.Location = new Point(407, 148);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(239, 34);
            label1.TabIndex = 6;
            label1.Text = "Количество волонтеров";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(73, 77);
            textBoxName.Margin = new Padding(4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(238, 26);
            textBoxName.TabIndex = 5;
            // 
            // labelIName
            // 
            labelIName.Location = new Point(73, 39);
            labelIName.Margin = new Padding(4, 0, 4, 0);
            labelIName.Name = "labelIName";
            labelIName.Size = new Size(239, 34);
            labelIName.TabIndex = 4;
            labelIName.Text = "Название";
            labelIName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelGPalce
            // 
            labelGPalce.Location = new Point(72, 148);
            labelGPalce.Margin = new Padding(4, 0, 4, 0);
            labelGPalce.Name = "labelGPalce";
            labelGPalce.Size = new Size(239, 34);
            labelGPalce.TabIndex = 3;
            labelGPalce.Text = "Место";
            labelGPalce.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxPlace
            // 
            comboBoxPlace.FormattingEnabled = true;
            comboBoxPlace.Location = new Point(73, 186);
            comboBoxPlace.Margin = new Padding(4);
            comboBoxPlace.Name = "comboBoxPlace";
            comboBoxPlace.Size = new Size(238, 27);
            comboBoxPlace.TabIndex = 2;
            // 
            // labelCategory
            // 
            labelCategory.Location = new Point(408, 39);
            labelCategory.Margin = new Padding(4, 0, 4, 0);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(239, 34);
            labelCategory.TabIndex = 1;
            labelCategory.Text = "Категория";
            labelCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(408, 77);
            comboBoxCategory.Margin = new Padding(4);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(238, 27);
            comboBoxCategory.TabIndex = 0;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.White;
            panelBottom.Controls.Add(buttonCancel);
            panelBottom.Controls.Add(buttonSave);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 538);
            panelBottom.Margin = new Padding(4);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(718, 103);
            panelBottom.TabIndex = 4;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(76, 175, 80);
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(399, 16);
            buttonCancel.Margin = new Padding(4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(297, 67);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(76, 175, 80);
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(23, 16);
            buttonSave.Margin = new Padding(4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(297, 67);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(labelAddEvent);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(13);
            panelTop.Size = new Size(718, 72);
            panelTop.TabIndex = 3;
            // 
            // labelAddEvent
            // 
            labelAddEvent.Dock = DockStyle.Fill;
            labelAddEvent.Location = new Point(13, 13);
            labelAddEvent.Margin = new Padding(4, 0, 4, 0);
            labelAddEvent.Name = "labelAddEvent";
            labelAddEvent.Size = new Size(692, 46);
            labelAddEvent.TabIndex = 0;
            labelAddEvent.Text = "Добавить мероприятие";
            labelAddEvent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 641);
            Controls.Add(panelFill);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdd";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            panelBottom.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        public TextBox textBoxName;
        private Label labelIName;
        private Label labelGPalce;
        public ComboBox comboBoxPlace;
        private Label labelCategory;
        public ComboBox comboBoxCategory;
        private Panel panelBottom;
        private Button buttonCancel;
        private Button buttonSave;
        private Panel panelTop;
        public Label labelAddEvent;
        private Label label2;
        public ComboBox comboBoxVolunteer;
        public TextBox textBoxCountVolunteers;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        public ComboBox comboBoxStatuse;
        public DateTimePicker dateTimePickerDate;
    }
}