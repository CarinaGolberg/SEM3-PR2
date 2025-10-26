using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PR1_SEM3_LOGIC;
using SEM3_PR1_MODEL;

namespace PR1_SEM3_WinForm
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
            txtNativeRegion.Text = plant.NativeRegion;
            cbToxins.Text = plant.Toxin;
            cbDangerLevel.Text = plant.DangerLevel;
            txtSymptoms.Text = plant.Symptoms;
        }

        private void txtLatinName_TextChanged(object sender, EventArgs e)
        {

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

            bool success = logic.UpdatePlant(originalId,
                                             txtName.Text.Trim(),
                                             txtLatinName.Text.Trim(),
                                             txtNativeRegion.Text.Trim(),
                                             cbToxins.Text.Trim(),
                                             cbDangerLevel.Text.Trim(),
                                             txtSymptoms.Text.Trim());

            if (!success)
            {
                MessageBox.Show("Ошибка при обновлении (оригинальное растение не найдено).");
                return;
            }

            if (originalId != id)
            {
                var name = txtName.Text.Trim();
                var latin = txtLatinName.Text.Trim();
                var region = txtNativeRegion.Text.Trim();
                var toxin = cbToxins.Text.Trim();
                var danger = cbDangerLevel.Text.Trim();
                var symptoms = txtSymptoms.Text.Trim();

                logic.DeletePlant(originalId);
                logic.AddPlant(id, name, latin, region, toxin, danger, symptoms);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void EditPlantForm_Load(object sender, EventArgs e)
        {
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

            // Уровень токсичности
            cbDangerLevel.Items.AddRange(new string[]
            {
                "Низкий",
                "Средний",
                "Высокий",
            });
        }
    }
}
