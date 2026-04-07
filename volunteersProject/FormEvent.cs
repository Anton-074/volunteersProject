using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using volunteersProject.Models;
using static System.Windows.Forms.DataFormats;

namespace volunteersProject
{
    public partial class FormEvent : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormEvent(User currentUser, bool isGuest)
        {
            InitializeComponent();


            CurrentUser = currentUser;
            IsGuest = isGuest;
            if(IsGuest == false)
            {
                buttonAdd.Visible = true;
                buttonEdit.Visible = true;
                buttonDelete.Visible = true;
            }

            labelName.Text = IsGuest ? "Гость" : $"{CurrentUser.FullName} ";


            using (var db = new VolunteersContext())
            {
                //if (CurrentUser?.IdRoleNavigation.RoleName != "Администратор")
                //{
                //    foreach (Button button in pnTop.Controls)
                //    {
                //        button.Visible = false;
                //    }
                //}
            }

            // Скрытый столбец ID
            var colId = new DataGridViewTextBoxColumn();
            colId.Name = "colId";
            colId.Visible = false;
            colId.ReadOnly = true;

            // Столбец 1: Название мероприятия
            var colName = new DataGridViewTextBoxColumn();
            colName.Name = "colName";
            colName.HeaderText = "Название";
            colName.FillWeight = 25;
            colName.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            colName.DefaultCellStyle.Font = new Font(dataGridViewEvent.Font, FontStyle.Bold);

            // Столбец 2: Основная информация
            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.HeaderText = "Информация";
            colInfo.FillWeight = 55;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            colInfo.DefaultCellStyle.Font = new Font(dataGridViewEvent.Font, FontStyle.Regular);

            // Столбец 3: Статус
            var colStatus = new DataGridViewTextBoxColumn();
            colStatus.Name = "colStatus";
            colStatus.HeaderText = "Статус";
            colStatus.FillWeight = 20;
            colStatus.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            colStatus.DefaultCellStyle.Font = new Font(dataGridViewEvent.Font, FontStyle.Bold);

            dataGridViewEvent.Columns.AddRange([colId, colName, colInfo, colStatus]);
            LoadEvents();
        }

        private void LoadEvents()
        {
            try
            {
                using (var db = new VolunteersContext())
                {
                    var events = db.Doings
                        .Include(i => i.Category)
                        .Include(i => i.Place)
                        .Include(i => i.User)
                        .Include(i => i.StatusesEvent)
                        .ToList();

                    foreach (var doing in events)
                    {
                        int rowIndex = dataGridViewEvent.Rows.Add();
                        var row = dataGridViewEvent.Rows[rowIndex];

                        row.Cells["colId"].Value = doing.Id;
                        row.Cells["colName"].Value = doing.DoingName;
                        row.Cells["colInfo"].Value = FormatEventInfo(doing);
                        row.Cells["colStatus"].Value = doing.StatusesEvent.StatusName;

                        ApplyRowStyles(row, doing);
                    }
                    dataGridViewEvent.ResumeLayout();
                    dataGridViewEvent.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatEventInfo(Doing doing)
        {
            return $"Категория: {doing.Category.CategoryName}" + Environment.NewLine +
                   $"Дата: {doing.Date}" + Environment.NewLine +
                   $"Место: {doing.Place.PlaceName}" + Environment.NewLine +
                   $"Волонтёров: {doing.CountVolunteer}" + Environment.NewLine +
                   $"Координатор: {doing.User.FullName}";
        }

        private void ApplyRowStyles(DataGridViewRow row, Doing doing)
        {
            string status = doing.StatusesEvent.StatusName;

            // Цвет фона строки
            if (status == "В процессе" || status == "Запланировано")
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFE5B4");
            }
            else if (status == "Завершено")
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#90EE90");
            }
            else if (status == "Отменено")
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. Создаем экземпляр формы добавления
            FormAdd form = new FormAdd();
            form.Text = "Добавить новое мероприятие";

            try
            {
                using (var db = new VolunteersContext())
                {
                    // 2. Загружаем справочники для выпадающих списков
                    var categories = db.Categories.ToList();
                    var places = db.Places.ToList();
                    var statuses = db.StatusesEvents.ToList();
                    var users = db.Users.ToList(); // Координаторы

                    // 3. Заполняем ComboBox-ы в форме добавления данными из БД
                    foreach (var c in categories) form.comboBoxCategory.Items.Add(c.CategoryName);
                    foreach (var p in places) form.comboBoxPlace.Items.Add(p.PlaceName);
                    foreach (var s in statuses) form.comboBoxStatuse.Items.Add(s.StatusName);
                    foreach (var u in users) form.comboBoxVolunteer.Items.Add(u.FullName);

                    // 4. Показываем форму и ждем результат
                    DialogResult result = form.ShowDialog(this);

                    // Если пользователь нажал "Отмена" или закрыл крестиком — выходим
                    if (result == DialogResult.Cancel)
                        return;

                    // 5. Ищем ID выбранных элементов по их названиям из ComboBox
                    // (Используем FirstOrDefault для безопасности)
                    int categoryId = categories.FirstOrDefault(c => c.CategoryName == form.comboBoxCategory.Text)?.Id ?? 1;
                    int placeId = places.FirstOrDefault(p => p.PlaceName == form.comboBoxPlace.Text)?.Id ?? 1;
                    int statusId = statuses.FirstOrDefault(s => s.StatusName == form.comboBoxStatuse.Text)?.Id ?? 1;
                    int userId = users.FirstOrDefault(u => u.FullName == form.comboBoxVolunteer.Text)?.Id ?? CurrentUser.Id;

                    // 6. Создаем новый объект мероприятия (Doing)
                    Doing newDoing = new Doing
                    {
                        DoingName = form.textBoxName.Text,
                        IdCategory = categoryId,
                        IdPlace = placeId,
                        IdStatusEvent = statusId,
                        IdUser = userId,
                        Date = DateOnly.FromDateTime(form.dateTimePickerDate.Value), // Используем значение из календаря
                        CountVolunteer = int.TryParse(form.textBoxCountVolunteers.Text, out int count) ? count : 0
                    };

                    // 7. Сохраняем в базу данных
                    db.Doings.Add(newDoing);
                    db.SaveChanges();

                    MessageBox.Show("Мероприятие успешно добавлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 8. Обновляем основную таблицу на форме
                    dataGridViewEvent.Rows.Clear(); // Очищаем старые строки
                    LoadEvents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // 1. Проверяем, выбрана ли строка в таблице
            if (dataGridViewEvent.CurrentRow == null)
            {
                MessageBox.Show("Выберите мероприятие для редактирования.");
                return;
            }

            // 2. Получаем ID из скрытой колонки (как мы делали в методе удаления)
            int eventId = (int)dataGridViewEvent.CurrentRow.Cells["colId"].Value;

            try
            {
                using (var db = new VolunteersContext())
                {
                    // 3. Находим мероприятие в БД (вместе со связанными данными)
                    var doing = db.Doings
                        .Include(d => d.Category)
                        .Include(d => d.Place)
                        .Include(d => d.StatusesEvent)
                        .Include(d => d.User)
                        .FirstOrDefault(d => d.Id == eventId);

                    if (doing == null)
                    {
                        MessageBox.Show("Мероприятие не найдено в базе данных.");
                        return;
                    }

                    // 4. Подготавливаем форму
                    FormAdd form = new FormAdd();
                    form.Text = "Редактирование мероприятия";
                    form.labelAddEvent.Text = "Редактировать мероприятие";
                    // 5. Загружаем справочники (как в Add)
                    var categories = db.Categories.ToList();
                    var places = db.Places.ToList();
                    var statuses = db.StatusesEvents.ToList();
                    var users = db.Users.ToList();

                    foreach (var c in categories) form.comboBoxCategory.Items.Add(c.CategoryName);
                    foreach (var p in places) form.comboBoxPlace.Items.Add(p.PlaceName);
                    foreach (var s in statuses) form.comboBoxStatuse.Items.Add(s.StatusName);
                    foreach (var u in users) form.comboBoxVolunteer.Items.Add(u.FullName);

                    // 6. ЗАПОЛНЯЕМ поля формы текущими данными объекта
                    form.textBoxName.Text = doing.DoingName;
                    form.comboBoxCategory.Text = doing.Category.CategoryName;
                    form.comboBoxPlace.Text = doing.Place.PlaceName;
                    form.comboBoxStatuse.Text = doing.StatusesEvent.StatusName;
                    form.comboBoxVolunteer.Text = doing.User.FullName;
                    form.textBoxCountVolunteers.Text = doing.CountVolunteer.ToString();

                    // Превращаем DateOnly обратно в DateTime для компонента
                    form.dateTimePickerDate.Value = doing.Date.ToDateTime(TimeOnly.MinValue);

                    // 7. Показываем форму
                    if (form.ShowDialog(this) == DialogResult.Cancel)
                        return;

                    // 8. Обновляем данные в найденном объекте
                    doing.DoingName = form.textBoxName.Text;
                    doing.IdCategory = categories.FirstOrDefault(c => c.CategoryName == form.comboBoxCategory.Text)?.Id ?? doing.IdCategory;
                    doing.IdPlace = places.FirstOrDefault(p => p.PlaceName == form.comboBoxPlace.Text)?.Id ?? doing.IdPlace;
                    doing.IdStatusEvent = statuses.FirstOrDefault(s => s.StatusName == form.comboBoxStatuse.Text)?.Id ?? doing.IdStatusEvent;
                    doing.IdUser = users.FirstOrDefault(u => u.FullName == form.comboBoxVolunteer.Text)?.Id ?? doing.IdUser;
                    doing.Date = DateOnly.FromDateTime(form.dateTimePickerDate.Value);
                    doing.CountVolunteer = int.TryParse(form.textBoxCountVolunteers.Text, out int count) ? count : 0;

                    // 9. Сохраняем изменения
                    db.SaveChanges();

                    MessageBox.Show("Изменения сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 10. Обновляем таблицу
                    dataGridViewEvent.Rows.Clear();
                    LoadEvents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при редактировании: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 1. Проверяем, выбрана ли строка
            if (dataGridViewEvent.CurrentRow == null || dataGridViewEvent.CurrentRow.Index < 0)
            {
                MessageBox.Show("Пожалуйста, выберите мероприятие для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Подтверждение удаления
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить это мероприятие?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            try
            {
                // 3. Получаем ID из скрытой колонки colId
                var selectedRow = dataGridViewEvent.CurrentRow;
                if (selectedRow.Cells["colId"].Value == null) return;

                int eventId = (int)selectedRow.Cells["colId"].Value;

                using (var db = new VolunteersContext())
                {
                    // 4. Поиск объекта в БД
                    var eventToDelete = db.Doings.Find(eventId);

                    if (eventToDelete != null)
                    {
                        db.Doings.Remove(eventToDelete);
                        db.SaveChanges();

                        MessageBox.Show("Мероприятие успешно удалено.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 5. Обновляем таблицу
                        dataGridViewEvent.Rows.Clear(); // Очищаем старые строки перед перезагрузкой
                        LoadEvents();
                    }
                    else
                    {
                        MessageBox.Show("Мероприятие не найдено в базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
