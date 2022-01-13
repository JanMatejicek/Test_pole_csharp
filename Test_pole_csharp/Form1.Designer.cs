
namespace Test_pole_csharp
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label_heslo = new System.Windows.Forms.Label();
            this.radioButton_kratke = new System.Windows.Forms.RadioButton();
            this.radioButton_stredni = new System.Windows.Forms.RadioButton();
            this.radioButton_dlouhe = new System.Windows.Forms.RadioButton();
            this.checkBox_cisla = new System.Windows.Forms.CheckBox();
            this.checkBox_znaky = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(270, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Vygenerovat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_heslo
            // 
            this.label_heslo.AutoSize = true;
            this.label_heslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_heslo.ForeColor = System.Drawing.Color.White;
            this.label_heslo.Location = new System.Drawing.Point(155, 177);
            this.label_heslo.Name = "label_heslo";
            this.label_heslo.Size = new System.Drawing.Size(24, 32);
            this.label_heslo.TabIndex = 6;
            this.label_heslo.Text = "-";
            // 
            // radioButton_kratke
            // 
            this.radioButton_kratke.AutoSize = true;
            this.radioButton_kratke.ForeColor = System.Drawing.Color.White;
            this.radioButton_kratke.Location = new System.Drawing.Point(161, 38);
            this.radioButton_kratke.Name = "radioButton_kratke";
            this.radioButton_kratke.Size = new System.Drawing.Size(70, 21);
            this.radioButton_kratke.TabIndex = 7;
            this.radioButton_kratke.TabStop = true;
            this.radioButton_kratke.Text = "Krátké";
            this.radioButton_kratke.UseVisualStyleBackColor = true;
            // 
            // radioButton_stredni
            // 
            this.radioButton_stredni.AutoSize = true;
            this.radioButton_stredni.ForeColor = System.Drawing.Color.White;
            this.radioButton_stredni.Location = new System.Drawing.Point(161, 74);
            this.radioButton_stredni.Name = "radioButton_stredni";
            this.radioButton_stredni.Size = new System.Drawing.Size(74, 21);
            this.radioButton_stredni.TabIndex = 8;
            this.radioButton_stredni.TabStop = true;
            this.radioButton_stredni.Text = "Střední";
            this.radioButton_stredni.UseVisualStyleBackColor = true;
            // 
            // radioButton_dlouhe
            // 
            this.radioButton_dlouhe.AutoSize = true;
            this.radioButton_dlouhe.ForeColor = System.Drawing.Color.White;
            this.radioButton_dlouhe.Location = new System.Drawing.Point(161, 116);
            this.radioButton_dlouhe.Name = "radioButton_dlouhe";
            this.radioButton_dlouhe.Size = new System.Drawing.Size(74, 21);
            this.radioButton_dlouhe.TabIndex = 9;
            this.radioButton_dlouhe.TabStop = true;
            this.radioButton_dlouhe.Text = "Dlouhé";
            this.radioButton_dlouhe.UseVisualStyleBackColor = true;
            // 
            // checkBox_cisla
            // 
            this.checkBox_cisla.AutoSize = true;
            this.checkBox_cisla.ForeColor = System.Drawing.Color.White;
            this.checkBox_cisla.Location = new System.Drawing.Point(57, 40);
            this.checkBox_cisla.Name = "checkBox_cisla";
            this.checkBox_cisla.Size = new System.Drawing.Size(60, 21);
            this.checkBox_cisla.TabIndex = 10;
            this.checkBox_cisla.Text = "Čísla";
            this.checkBox_cisla.UseVisualStyleBackColor = true;
            // 
            // checkBox_znaky
            // 
            this.checkBox_znaky.AutoSize = true;
            this.checkBox_znaky.ForeColor = System.Drawing.Color.White;
            this.checkBox_znaky.Location = new System.Drawing.Point(57, 81);
            this.checkBox_znaky.Name = "checkBox_znaky";
            this.checkBox_znaky.Size = new System.Drawing.Size(69, 21);
            this.checkBox_znaky.TabIndex = 11;
            this.checkBox_znaky.Text = "Znaky";
            this.checkBox_znaky.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "HESLO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(452, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_znaky);
            this.Controls.Add(this.checkBox_cisla);
            this.Controls.Add(this.radioButton_dlouhe);
            this.Controls.Add(this.radioButton_stredni);
            this.Controls.Add(this.radioButton_kratke);
            this.Controls.Add(this.label_heslo);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(470, 295);
            this.MinimumSize = new System.Drawing.Size(470, 295);
            this.Name = "Form1";
            this.Text = "Test pole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_heslo;
        private System.Windows.Forms.RadioButton radioButton_kratke;
        private System.Windows.Forms.RadioButton radioButton_stredni;
        private System.Windows.Forms.RadioButton radioButton_dlouhe;
        private System.Windows.Forms.CheckBox checkBox_cisla;
        private System.Windows.Forms.CheckBox checkBox_znaky;
        private System.Windows.Forms.Label label1;
    }
}

