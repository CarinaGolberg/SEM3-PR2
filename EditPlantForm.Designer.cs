namespace PR1_SEM3_WinForm
{
    partial class EditPlantForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLatinName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSymptoms = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNativeRegion = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbToxins = new System.Windows.Forms.ComboBox();
            this.cbDangerLevel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Cornsilk;
            this.txtId.Location = new System.Drawing.Point(15, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(49, 22);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Cornsilk;
            this.txtName.Location = new System.Drawing.Point(12, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(247, 22);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Латинское название:";
            // 
            // txtLatinName
            // 
            this.txtLatinName.BackColor = System.Drawing.Color.Cornsilk;
            this.txtLatinName.Location = new System.Drawing.Point(15, 138);
            this.txtLatinName.Name = "txtLatinName";
            this.txtLatinName.Size = new System.Drawing.Size(244, 22);
            this.txtLatinName.TabIndex = 5;
            this.txtLatinName.TextChanged += new System.EventHandler(this.txtLatinName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Основная ядовитая часть:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Tan;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Уровень токсичности:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Tan;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Симптомы отравления:";
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.BackColor = System.Drawing.Color.Cornsilk;
            this.txtSymptoms.Location = new System.Drawing.Point(12, 376);
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(247, 22);
            this.txtSymptoms.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Tan;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Семейство:";
            // 
            // txtNativeRegion
            // 
            this.txtNativeRegion.BackColor = System.Drawing.Color.Cornsilk;
            this.txtNativeRegion.Location = new System.Drawing.Point(12, 198);
            this.txtNativeRegion.Name = "txtNativeRegion";
            this.txtNativeRegion.Size = new System.Drawing.Size(247, 22);
            this.txtNativeRegion.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSave.Location = new System.Drawing.Point(15, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 34);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.BurlyWood;
            this.btnCancel.Location = new System.Drawing.Point(155, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 34);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PR1_SEM3_WinForm.Properties.Resources._91iKtIWhxOL;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::PR1_SEM3_WinForm.Properties.Resources.EditForm;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 452);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // cbToxins
            // 
            this.cbToxins.BackColor = System.Drawing.Color.Cornsilk;
            this.cbToxins.FormattingEnabled = true;
            this.cbToxins.Location = new System.Drawing.Point(12, 257);
            this.cbToxins.Name = "cbToxins";
            this.cbToxins.Size = new System.Drawing.Size(247, 24);
            this.cbToxins.TabIndex = 17;
            // 
            // cbDangerLevel
            // 
            this.cbDangerLevel.BackColor = System.Drawing.Color.Cornsilk;
            this.cbDangerLevel.FormattingEnabled = true;
            this.cbDangerLevel.Location = new System.Drawing.Point(15, 318);
            this.cbDangerLevel.Name = "cbDangerLevel";
            this.cbDangerLevel.Size = new System.Drawing.Size(244, 24);
            this.cbDangerLevel.TabIndex = 18;
            // 
            // EditPlantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.cbDangerLevel);
            this.Controls.Add(this.cbToxins);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNativeRegion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSymptoms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLatinName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EditPlantForm";
            this.Text = "EditPlantForm";
            this.Load += new System.EventHandler(this.EditPlantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLatinName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSymptoms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNativeRegion;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbToxins;
        private System.Windows.Forms.ComboBox cbDangerLevel;
    }
}