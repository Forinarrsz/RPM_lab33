using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab33
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StudentId",
                HeaderText = "№ билета",
                Width = 70
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FullName",
                HeaderText = "ФИО",
                Width = 180
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Group",
                HeaderText = "Группа",
                Width = 70
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Оценки",
                Width = 100
            });
        }

        // 🔹 Добавить студента
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtStudentId.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Заполните обязательные поля!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var student = new Student
                {
                    StudentId = int.Parse(txtStudentId.Text),
                    LastName = txtLastName.Text.Trim(),
                    FirstName = txtFirstName.Text.Trim(),
                    Patronymic = txtPatronymic.Text.Trim(),
                    DateOfBirth = dtpDateOfBirth.Value.Date,
                    Group = txtGroup.Text.Trim().ToUpper(),
                    Grades = new List<int>
                    {
                        int.Parse(txtGrade1.Text),
                        int.Parse(txtGrade2.Text),
                        int.Parse(txtGrade3.Text),
                        int.Parse(txtGrade4.Text)
                    }
                };

                students.Add(student);
                MessageBox.Show("✓ Студент добавлен", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("❌ Проверьте правильность ввода чисел!", "Ошибка формата",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            var query = from s in students
                        select new
                        {
                            s.StudentId,
                            s.FullName,
                            s.Group,
                            Оценки = string.Join(", ", s.Grades)
                        };
            dataGridView1.DataSource = query.ToList();
        }

        // 🔹 Должники (есть оценка 2)
        private void btnDebtors_Click(object sender, EventArgs e)
        {
            var debtors = students
                .Where(s => s.Grades.Any(g => g == 2))
                .Select(s => new
                {
                    ФИО = s.FullName,
                    Группа = s.Group,
                    Оценки = string.Join(", ", s.Grades)
                })
                .ToList();

            if (debtors.Any())
                dataGridView1.DataSource = debtors;
            else
                MessageBox.Show("Должников не найдено ✓", "Информация");
        }

        // 🔹 Младше 20 лет
        private void btnUnder20_Click(object sender, EventArgs e)
        {
            var young = students
                .Where(s => s.Age < 20)
                .OrderBy(s => s.Age)
                .ThenBy(s => s.LastName)
                .Select(s => new
                {
                    ФИО = s.FullName,
                    Возраст = s.Age,
                    Группа = s.Group,
                    Дата_рождения = s.DateOfBirth.ToShortDateString()
                })
                .ToList();

            if (young.Any())
                dataGridView1.DataSource = young;
            else
                MessageBox.Show("Студентов младше 20 лет не найдено", "Информация");
        }

        // 🔹 Поиск по группе
        private void btnShowGroup_Click(object sender, EventArgs e)
        {
            string groupName = txtSearchGroup.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(groupName))
            {
                MessageBox.Show("Введите номер группы", "Предупреждение");
                return;
            }

            var groupStudents = students
                .Where(s => s.Group.ToUpper() == groupName)
                .Select(s => new
                {
                    Номер_билета = s.StudentId,
                    ФИО = s.FullName,
                    s.Group
                })
                .ToList();

            if (groupStudents.Any())
                dataGridView1.DataSource = groupStudents;
            else
                MessageBox.Show($"Группа \"{groupName}\" не найдена", "Информация");
        }

        // Очистка полей
        private void ClearFields()
        {
            txtStudentId.Clear(); txtLastName.Clear(); txtFirstName.Clear();
            txtPatronymic.Clear(); txtGroup.Clear(); txtSearchGroup.Clear();
            txtGrade1.Clear(); txtGrade2.Clear(); txtGrade3.Clear(); txtGrade4.Clear();
            dtpDateOfBirth.Value = DateTime.Today.AddYears(-18);
            txtStudentId.Focus();
        }
    }
}