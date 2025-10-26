using PR1_SEM3_LOGIC;
using SEM3_PR1_MODEL;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PR1_SEM3
{
    public partial class Form1 : Form
    {
        private readonly PPLibraryLogic logic = new PPLibraryLogic();

        public Form1()
        {
            InitializeComponent();
            UpdatePlantList();
            dgvPlants.SelectionChanged += DgvPlants_SelectionChanged;
        }

        private void DgvPlants_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlants.CurrentRow == null) return;
            // fill right-side inputs with selected row values
            txtId.Text = dgvPlants.CurrentRow.Cells["Id"].Value?.ToString() ?? "";
            txtName.Text = dgvPlants.CurrentRow.Cells["Name"].Value?.ToString() ?? "";
            txtLatinName.Text = dgvPlants.CurrentRow.Cells["LatinName"].Value?.ToString() ?? "";
            txtToxin.Text = dgvPlants.CurrentRow.Cells["Toxin"].Value?.ToString() ?? "";
            txtDangerLevel.Text = dgvPlants.CurrentRow.Cells["DangerLevel"].Value?.ToString() ?? "";
            txtSymptoms.Text = dgvPlants.CurrentRow.Cells["Symptoms"].Value?.ToString() ?? "";
            txtNativeRegion.Text = dgvPlants.CurrentRow.Cells["NativeRegion"].Value?.ToString() ?? "";
        }

        private void UpdatePlantList()
        {
            dgvPlants.Rows.Clear();
            foreach (var plant in logic.GetAllPlants())
            {
                dgvPlants.Rows.Add(plant.Id, plant.Name, plant.LatinName, plant.Toxin,
                                   plant.DangerLevel, plant.Symptoms, plant.NativeRegion);
            }
        }

        private void ClearInputs()
        {
            foreach (Control c in this.Controls)
                if (c is TextBox t) t.Clear();
            txtId.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Некорректный Id!");
                txtId.Focus();
                return;
            }

            if (logic.ExistsId(id))
            {
                MessageBox.Show("Растение с таким Id уже существует! Введите уникальный Id.");
                txtId.Focus();
                txtId.SelectAll();
                return;
            }

            logic.AddPlant(id,
                           txtName.Text.Trim(),
                           txtLatinName.Text.Trim(),
                           txtToxin.Text.Trim(),
                           txtDangerLevel.Text.Trim(),
                           txtSymptoms.Text.Trim(),
                           txtNativeRegion.Text.Trim());
            UpdatePlantList();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPlants.CurrentRow == null)
            {
                MessageBox.Show("Выберите растение для изменения!"); return;
            }

            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Некорректный Id!"); txtId.Focus(); return;
            }

            int currentId = Convert.ToInt32(dgvPlants.CurrentRow.Cells["Id"].Value);

            if (logic.ExistsId(id, currentId))
            {
                MessageBox.Show("Растение с таким Id уже существует! Введите уникальный Id."); txtId.Focus(); txtId.SelectAll(); return;
            }

            bool success = logic.UpdatePlant(currentId,
                                             txtName.Text.Trim(),
                                             txtLatinName.Text.Trim(),
                                             txtToxin.Text.Trim(),
                                             txtDangerLevel.Text.Trim(),
                                             txtSymptoms.Text.Trim(),
                                             txtNativeRegion.Text.Trim());

            if (success)
            {
                // if id was changed, we need to perform an update that preserves new id:
                if (currentId != id)
                {
                    // create new plant with new id and delete old one (since logic.UpdatePlant updates by id)
                    var name = txtName.Text.Trim();
                    var latin = txtLatinName.Text.Trim();
                    var toxin = txtToxin.Text.Trim();
                    var danger = txtDangerLevel.Text.Trim();
                    var symptoms = txtSymptoms.Text.Trim();
                    var region = txtNativeRegion.Text.Trim();

                    logic.DeletePlant(currentId);
                    logic.AddPlant(id, name, latin, toxin, danger, symptoms, region);
                }

                UpdatePlantList();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Растение не найдено!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPlants.CurrentRow == null)
            {
                MessageBox.Show("Выберите растение для удаления!"); return;
            }

            int id = Convert.ToInt32(dgvPlants.CurrentRow.Cells["Id"].Value);
            if (logic.DeletePlant(id))
                UpdatePlantList();
            else
                MessageBox.Show("Растение не найдено!");
        }

        private void btnShowAll_Click(object sender, EventArgs e) => UpdatePlantList();

        private void btnSearchToxin_Click(object sender, EventArgs e)
        {
            var toxin = txtSearchToxin.Text.Trim();
            if (string.IsNullOrWhiteSpace(toxin)) { MessageBox.Show("Введите токсин для поиска!"); return; }
            var results = logic.FindByToxin(toxin);
            dgvPlants.Rows.Clear();
            foreach (var plant in results)
                dgvPlants.Rows.Add(plant.Id, plant.Name, plant.LatinName, plant.Toxin,
                                   plant.DangerLevel, plant.Symptoms, plant.NativeRegion);
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            dgvPlants.Rows.Clear();
            var groups = logic.GroupByDangerLevel();
            foreach (var g in groups)
            {
                foreach (var p in g.Value)
                    dgvPlants.Rows.Add(p.Id, p.Name, p.LatinName, p.Toxin, p.DangerLevel, p.Symptoms, p.NativeRegion);
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => this.Close();

        private void dgvPlants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtLatinName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
