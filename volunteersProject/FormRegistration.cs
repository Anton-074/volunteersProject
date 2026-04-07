using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using volunteersProject.Models;

namespace volunteersProject
{
    public partial class FormRegistration : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormRegistration()
        {
            InitializeComponent();
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxLogin.Text) || String.IsNullOrWhiteSpace(textBoxPass.Text))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new VolunteersContext())
            {
                var user = db.Users
                    .Where(w => w.Login == textBoxLogin.Text && w.Password == textBoxPass.Text)
                    .FirstOrDefault();

                if (user != null)
                {
                    CurrentUser = user;
                    IsGuest = false;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или парль", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            CurrentUser = null;
            IsGuest = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
