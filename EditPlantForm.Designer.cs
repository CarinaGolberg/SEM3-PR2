namespace PR1_SEM3
{
    partial class EditPlantForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLatinName;
        private System.Windows.Forms.TextBox txtToxin;
        private System.Windows.Forms.TextBox txtDangerLevel;
        private System.Windows.Forms.TextBox txtSymptoms;
        private System.Windows.Forms.TextBox txtNativeRegion;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLatinName = new System.Windows.Forms.TextBox();
            this.txtToxin = new System.Windows.Forms.TextBox();
            this.txtDangerLevel = new System.Windows.Forms.TextBox();
            this.txtSymptoms = new System.Windows.Forms.TextBox();
            this.txtNativeRegion = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            int startX = 20, startY = 20, labelWidth = 130, textWidth = 200, height = 25, margin = 35;

            //AddLabelAndTextbox("Id:", ref this.txtId, startX, startY, labelWidth, textWidth, height);
            //AddLabelAndTextbox("Название:", ref this.txtName, startX, startY + margin, labelWidth, textWidth, height);
            //AddLabelAndTextbox("Латинское название:", ref this.txtLatinName, startX, startY + 2 * margin, labelWidth, textWidth, height);
            //AddLabelAndTextbox("Токсин:", ref this.txtToxin, startX, startY + 3 * margin, labelWidth, textWidth, height);
            //AddLabelAndTextbox("Опасность:", ref this.txtDangerLevel, startX, startY + 4 * margin, labelWidth, textWidth, height);
            //AddLabelAndTextbox("Симптомы:", ref this.txtSymptoms, startX, startY + 5 * margin, labelWidth, textWidth, height);
            //AddLabelAndTextbox("Регион:", ref this.txtNativeRegion, startX, startY + 6 * margin, labelWidth, textWidth, height);

            this.btnSave.Text = "Сохранить";
            this.btnSave.Location = new System.Drawing.Point(startX, startY + 8 * margin);
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Отмена";
            this.btnCancel.Location = new System.Drawing.Point(startX + 110, startY + 8 * margin);
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.ClientSize = new System.Drawing.Size(380, 400);
            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this.txtId, this.txtName, this.txtLatinName, this.txtToxin,
                this.txtDangerLevel, this.txtSymptoms, this.txtNativeRegion,
                this.btnSave, this.btnCancel
            });
            this.Text = "Изменение растения";
        }

        private void AddLabelAndTextbox(string labelText, ref System.Windows.Forms.TextBox txtBox,
                                        int x, int y, int labelWidth, int textWidth, int height)
        {
            var label = new System.Windows.Forms.Label();
            label.Text = labelText;
            label.Location = new System.Drawing.Point(x, y);
            label.Size = new System.Drawing.Size(labelWidth, height);
            this.Controls.Add(label);

            txtBox = new System.Windows.Forms.TextBox();
            txtBox.Location = new System.Drawing.Point(x + labelWidth + 5, y);
            txtBox.Size = new System.Drawing.Size(textWidth, height);
            this.Controls.Add(txtBox);
        }
    }
}
