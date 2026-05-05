namespace lab33
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtStudentId = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtPatronymic = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            txtSearchGroup = new TextBox();
            btnAddStudent = new Button();
            btnShowAll = new Button();
            btnDebtors = new Button();
            btnUnder20 = new Button();
            btnShowGroup = new Button();
            dataGridView1 = new DataGridView();
            txtGroup = new TextBox();
            txtGrade1 = new TextBox();
            txtGrade2 = new TextBox();
            txtGrade3 = new TextBox();
            txtGrade4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // Labels
            label1.Text = "№ билета:"; label1.Location = new Point(12, 31); label1.Size = new Size(50, 15);
            label2.Text = "Фамилия:"; label2.Location = new Point(12, 60); label2.Size = new Size(50, 15);
            label3.Text = "Имя:"; label3.Location = new Point(12, 89); label3.Size = new Size(50, 15);
            label4.Text = "Отчество:"; label4.Location = new Point(12, 118); label4.Size = new Size(50, 15);
            label5.Text = "Дата рожд.:"; label5.Location = new Point(12, 150); label5.Size = new Size(60, 15);
            label6.Text = "Группа:"; label6.Location = new Point(12, 208); label6.Size = new Size(50, 15);
            label7.Text = "Поиск группы:"; label7.Location = new Point(12, 179); label7.Size = new Size(80, 15);
            label8.Text = "Оценки:"; label8.Location = new Point(550, 31); label8.Size = new Size(50, 15);

            // txtStudentId
            txtStudentId.Location = new Point(90, 28);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(100, 23);
            txtStudentId.TabIndex = 0;

            // txtLastName
            txtLastName.Location = new Point(90, 57);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 1;

            // txtFirstName
            txtFirstName.Location = new Point(90, 86);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 2;

            // txtPatronymic
            txtPatronymic.Location = new Point(90, 115);
            txtPatronymic.Name = "txtPatronymic";
            txtPatronymic.Size = new Size(100, 23);
            txtPatronymic.TabIndex = 3;

            // dtpDateOfBirth
            dtpDateOfBirth.Location = new Point(90, 147);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(150, 23);
            dtpDateOfBirth.TabIndex = 4;
            dtpDateOfBirth.Value = DateTime.Today.AddYears(-18);

            // txtSearchGroup
            txtSearchGroup.Location = new Point(90, 176);
            txtSearchGroup.Name = "txtSearchGroup";
            txtSearchGroup.Size = new Size(100, 23);
            txtSearchGroup.TabIndex = 5;

            // txtGroup
            txtGroup.Location = new Point(90, 205);
            txtGroup.Name = "txtGroup";
            txtGroup.Size = new Size(100, 23);
            txtGroup.TabIndex = 6;

            // Grades
            txtGrade1.Location = new Point(550, 28); txtGrade1.Name = "txtGrade1"; txtGrade1.Size = new Size(50, 23); txtGrade1.TabIndex = 7;
            txtGrade2.Location = new Point(550, 57); txtGrade2.Name = "txtGrade2"; txtGrade2.Size = new Size(50, 23); txtGrade2.TabIndex = 8;
            txtGrade3.Location = new Point(550, 86); txtGrade3.Name = "txtGrade3"; txtGrade3.Size = new Size(50, 23); txtGrade3.TabIndex = 9;
            txtGrade4.Location = new Point(550, 115); txtGrade4.Name = "txtGrade4"; txtGrade4.Size = new Size(50, 23); txtGrade4.TabIndex = 10;

            // Buttons
            btnAddStudent.Location = new Point(280, 28); btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(110, 23); btnAddStudent.Text = "Добавить";
            btnAddStudent.TabIndex = 11; btnAddStudent.Click += btnAddStudent_Click;

            btnShowAll.Location = new Point(280, 57); btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(110, 23); btnShowAll.Text = "Показать всех";
            btnShowAll.TabIndex = 12; btnShowAll.Click += btnShowAll_Click;

            btnDebtors.Location = new Point(280, 86); btnDebtors.Name = "btnDebtors";
            btnDebtors.Size = new Size(110, 23); btnDebtors.Text = "Должники";
            btnDebtors.TabIndex = 13; btnDebtors.Click += btnDebtors_Click;

            btnUnder20.Location = new Point(280, 115); btnUnder20.Name = "btnUnder20";
            btnUnder20.Size = new Size(110, 23); btnUnder20.Text = "Младше 20";
            btnUnder20.TabIndex = 14; btnUnder20.Click += btnUnder20_Click;

            btnShowGroup.Location = new Point(280, 176); btnShowGroup.Name = "btnShowGroup";
            btnShowGroup.Size = new Size(110, 23); btnShowGroup.Text = "Показать группу";
            btnShowGroup.TabIndex = 15; btnShowGroup.Click += btnShowGroup_Click;

            // DataGridView
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(420, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(350, 200);
            dataGridView1.TabIndex = 16;
            // 👇 УДАЛЕНО: dataGridView1.CellContentClick += ... (не требуется)

            // Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 250);
            Controls.Add(dataGridView1);
            Controls.Add(btnShowGroup);
            Controls.Add(btnUnder20);
            Controls.Add(btnDebtors);
            Controls.Add(btnShowAll);
            Controls.Add(btnAddStudent);
            Controls.Add(txtGrade4); Controls.Add(txtGrade3); Controls.Add(txtGrade2); Controls.Add(txtGrade1);
            Controls.Add(label8);
            Controls.Add(txtGroup); Controls.Add(label6);
            Controls.Add(txtSearchGroup); Controls.Add(label7);
            Controls.Add(dtpDateOfBirth); Controls.Add(label5);
            Controls.Add(txtPatronymic); Controls.Add(label4);
            Controls.Add(txtFirstName); Controls.Add(label3);
            Controls.Add(txtLastName); Controls.Add(label2);
            Controls.Add(txtStudentId); Controls.Add(label1);
            Name = "Form1";
            Text = "LINQ — Студенты (Лаб. №33)";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentId, txtLastName, txtFirstName, txtPatronymic, txtGroup, txtSearchGroup;
        private TextBox txtGrade1, txtGrade2, txtGrade3, txtGrade4;
        private DateTimePicker dtpDateOfBirth;
        private Button btnAddStudent, btnShowAll, btnDebtors, btnUnder20, btnShowGroup;
        private DataGridView dataGridView1;
        private Label label1, label2, label3, label4, label5, label6, label7, label8;
    }
}