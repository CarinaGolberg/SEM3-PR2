using PR1_SEM3_LOGIC;
using SEM3_PR1_MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace PR1_SEM3_WinForm
{
    public partial class MainForm : Form
    {
        private readonly PPLibraryLogic logic = new PPLibraryLogic();
        public MainForm()
        {
            InitializeComponent();
            logic = new PPLibraryLogic();
            UpdatePlantList();
        }

        //Это событие формы, которое вызывается один раз при запуске окна.
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_SEM3_PR1_DataDataSet1.PoisonousPlantsDB". При необходимости она может быть перемещена или удалена.
            this.poisonousPlantsDBTableAdapter1.Fill(this._SEM3_PR1_DataDataSet1.PoisonousPlantsDB);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_SEM3_PR1_DataDataSet.PoisonousPlantsDB". При необходимости она может быть перемещена или удалена.
            this.poisonousPlantsDBTableAdapter.Fill(this._SEM3_PR1_DataDataSet.PoisonousPlantsDB);
            // Список частей растения
            cbToxins.Items.AddRange(new string[]
            {
                "Корень",
                "Стебель",
                "Листья",
                "Цветок",
                "Плод",
                "Семена"
            });

            // Список частей растения для поиска
            cbSearchToxin.Items.AddRange(new string[]
            {
                "Корень",
                "Стебель",
                "Листья",
                "Цветок",
                "Плод",
                "Семена"
            });

            // Уровень токсичности
            cbDangerLevel.Items.AddRange(new string[]
            {
                "Низкий",
                "Средний",
                "Высокий",
            });
            UpdatePlantList();
        }

        private void UpdatePlantList()
        {
            dgvPlants.DataSource = null;
            dgvPlants.DataSource = logic.GetAllPlants().ToList();
        }

        private void ClearInputs()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                    textBox.Clear();
            }
        }

        //Создание растения.
        public void CreatePlant()
        {
            string toxin = cbToxins.SelectedItem?.ToString() ?? "";
            string dangerLevel = cbDangerLevel.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(toxin) || string.IsNullOrEmpty(dangerLevel))
            {
                MessageBox.Show("Выберите токсин и регион!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtLatinName.Text) ||
                string.IsNullOrWhiteSpace(txtNativeRegion.Text) ||
                string.IsNullOrWhiteSpace(txtSymptoms.Text))
            {
                MessageBox.Show("Заполните все поля корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = int.Parse(txtId.Text.Trim());
            logic.AddPlant(id, txtName.Text.Trim(), txtLatinName.Text.Trim(), txtNativeRegion.Text.Trim(), cbToxins.Text.Trim(),
                cbDangerLevel.Text.Trim(), txtSymptoms.Text.Trim()); //Trim() удаляет пробельные символы.
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Некорректный Id!");
                txtId.Focus();
                return;
            }

            if (id <= 0)
            {
                MessageBox.Show("Некорректный Id! Введите положительное число.");
                txtId.Focus();
                return;
            }

            if (logic.ExistsId(id))
            {
                MessageBox.Show("Такой Id уже существует! Введите уникальный Id.");
                txtId.Focus();
                txtId.SelectAll();
                return;
            }

            CreatePlant();
            UpdatePlantList();
            ClearInputs();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNativeRegion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdatePlantList();
        }

        private void btnSearchToxin_Click(object sender, EventArgs e)
        {
            string toxin = cbSearchToxin.Text.Trim();
            if (string.IsNullOrWhiteSpace(toxin))
            {
                MessageBox.Show("Выберите основную ядовитую часть для поиска!");
                return;
            }

            var results = logic.FindByToxin(toxin);

            if (results.Count == 0)
            {
                MessageBox.Show("Такие растения не найдены.");
                return;
            }

            string message = "Найденные растения:\n\n";
            foreach (var plant in results)
            {
                message += $"{plant.Id}. {plant.Name}\n" + "------------------------\n";
            }

            MessageBox.Show(message, "Результаты поиска");
        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchId.Text, out int id))
            {
                var plant = logic.GetPlantById(id);
                MessageBox.Show(plant != null ? plant.ToString() : "Растение не найдено", "Результат");
            }
            else MessageBox.Show("Введите корректный Id!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            dgvPlants.DataSource = null;
            dgvPlants.Rows.Clear();
            dgvPlants.Columns.Clear();
            dgvPlants.Columns.Add("Info", "Информация");

            var groups = logic.GroupByDangerLevel();
            foreach (var g in groups)
            {
                dgvPlants.Rows.Add($"Уровень токсичности: {g.Key}");
                foreach (var b in g.Value)
                    dgvPlants.Rows.Add($"   {b}");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPlants.CurrentRow?.DataBoundItem is PoisonousPlant plant)
            {
                var res = MessageBox.Show($"Вы действительно хотите удалить растение '{plant.Name}'?", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    logic.DeletePlant(plant.Id);
                    UpdatePlantList();
                }
            }
            else MessageBox.Show("Выберите растение для удаления!", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPlants.CurrentRow?.DataBoundItem is PoisonousPlant plant)
            {
                using (var form = new EditPlantForm(plant, logic))
                if (form.ShowDialog() == DialogResult.OK)
                {
                   UpdatePlantList();
                }
            }
            else MessageBox.Show("Выберите растение для редактирования!", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void poisonousPlantsDBBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void poisonousPlantsDBBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
