namespace volunteersProject
{
    partial class FormEvent
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
            panel2 = new Panel();
            textBoxSearch = new TextBox();
            labelPo = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxSort = new ComboBox();
            comboBoxFilterCategory = new ComboBox();
            dataGridViewEvent = new DataGridView();
            panel1 = new Panel();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            labelName = new Label();
            buttonExit = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvent).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBoxSearch);
            panel2.Controls.Add(labelPo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(comboBoxSort);
            panel2.Controls.Add(comboBoxFilterCategory);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 64);
            panel2.TabIndex = 5;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(742, 32);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(235, 26);
            textBoxSearch.TabIndex = 5;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // labelPo
            // 
            labelPo.Location = new Point(742, 5);
            labelPo.Name = "labelPo";
            labelPo.Size = new Size(235, 24);
            labelPo.TabIndex = 4;
            labelPo.Text = "Поиск";
            labelPo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(406, 5);
            label2.Name = "label2";
            label2.Size = new Size(188, 24);
            label2.TabIndex = 3;
            label2.Text = "Сортировка";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(33, 5);
            label1.Name = "label1";
            label1.Size = new Size(188, 24);
            label1.TabIndex = 2;
            label1.Text = "Фильтрация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxSort
            // 
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Location = new Point(406, 32);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(188, 27);
            comboBoxSort.TabIndex = 1;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // comboBoxFilterCategory
            // 
            comboBoxFilterCategory.FormattingEnabled = true;
            comboBoxFilterCategory.Location = new Point(33, 32);
            comboBoxFilterCategory.Name = "comboBoxFilterCategory";
            comboBoxFilterCategory.Size = new Size(188, 27);
            comboBoxFilterCategory.TabIndex = 0;
            comboBoxFilterCategory.SelectedIndexChanged += comboBoxFilterCategory_SelectedIndexChanged;
            // 
            // dataGridViewEvent
            // 
            dataGridViewEvent.AllowUserToAddRows = false;
            dataGridViewEvent.AllowUserToDeleteRows = false;
            dataGridViewEvent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEvent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewEvent.BackgroundColor = Color.White;
            dataGridViewEvent.BorderStyle = BorderStyle.None;
            dataGridViewEvent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvent.ColumnHeadersVisible = false;
            dataGridViewEvent.Dock = DockStyle.Bottom;
            dataGridViewEvent.Location = new Point(10, 135);
            dataGridViewEvent.MultiSelect = false;
            dataGridViewEvent.Name = "dataGridViewEvent";
            dataGridViewEvent.ReadOnly = true;
            dataGridViewEvent.RowHeadersVisible = false;
            dataGridViewEvent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEvent.Size = new Size(1009, 425);
            dataGridViewEvent.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(buttonExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1009, 60);
            panel1.TabIndex = 3;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(76, 175, 80);
            buttonDelete.Dock = DockStyle.Left;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(284, 10);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(137, 40);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Visible = false;
            buttonDelete.Click += btnDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(76, 175, 80);
            buttonEdit.Dock = DockStyle.Left;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(147, 10);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(137, 40);
            buttonEdit.TabIndex = 12;
            buttonEdit.Text = "Редактированить";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Visible = false;
            buttonEdit.Click += btnEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(76, 175, 80);
            buttonAdd.Dock = DockStyle.Left;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(10, 10);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(137, 40);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Visible = false;
            buttonAdd.Click += btnAdd_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Right;
            labelName.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(813, 10);
            labelName.Name = "labelName";
            labelName.Size = new Size(36, 17);
            labelName.TabIndex = 8;
            labelName.Text = "Имя";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(76, 175, 80);
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(849, 10);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(150, 40);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Выйти";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += btnLogin_Click;
            // 
            // FormEvent
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 570);
            Controls.Add(panel2);
            Controls.Add(dataGridViewEvent);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormEvent";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEvent";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvent).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox textBoxSearch;
        private Label labelPo;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxSort;
        private ComboBox comboBoxFilterCategory;
        private DataGridView dataGridViewEvent;
        private Panel panel1;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private Label labelName;
        private Button buttonExit;
    }
}