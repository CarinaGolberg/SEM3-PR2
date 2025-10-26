using PR1_SEM3_LOGIC;
using SEM3_PR1_MODEL;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PR1_SEM3
{
    public partial class EditPlantForm : Form
    {
        private readonly PPLibraryLogic logic;
        private readonly int originalId;

        public EditPlantForm(PoisonousPlant plant, PPLibraryLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
            this.originalId = plant.Id;

            txtId.Text = plant.Id.ToString();
            txtName.Text = plant.Name;
            txtLatinName.Text = plant.LatinName;
            txtToxin.Text = plant.Toxin;
            txtDangerLevel.Text = plant.DangerLevel;
            txtSymptoms.Text = plant.Symptoms;
            txtNativeRegion.Text = plant.NativeRegion;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Некорректный Id!"); txtId.Focus(); return;
            }

            if (logic.ExistsId(id, originalId))
            {
                MessageBox.Show("Такой Id уже существует! Введите другой Id."); txtId.Focus(); txtId.SelectAll(); return;
            }

            // If id changed we will remove old and add new with new id
            bool success = logic.UpdatePlant(originalId,
                                             txtName.Text.Trim(),
                                             txtLatinName.Text.Trim(),
                                             txtToxin.Text.Trim(),
                                             txtDangerLevel.Text.Trim(),
                                             txtSymptoms.Text.Trim(),
                                             txtNativeRegion.Text.Trim());

            if (!success)
            {
                MessageBox.Show("Ошибка при обновлении (оригинальное растение не найдено).");
                return;
            }

            if (originalId != id)
            {
                // copy data, delete old, add new with new id
                var name = txtName.Text.Trim();
                var latin = txtLatinName.Text.Trim();
                var toxin = txtToxin.Text.Trim();
                var danger = txtDangerLevel.Text.Trim();
                var symptoms = txtSymptoms.Text.Trim();
                var region = txtNativeRegion.Text.Trim();

                logic.DeletePlant(originalId);
                logic.AddPlant(id, name, latin, toxin, danger, symptoms, region);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
