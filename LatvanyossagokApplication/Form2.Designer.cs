namespace LatvanyossagokApplication
{
    partial class Form2
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
            this.varosUpdate_textBox = new System.Windows.Forms.TextBox();
            this.lakossagUpdate_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.modositas_button_form2 = new System.Windows.Forms.Button();
            this.vissza_Button_f2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lakossagUpdate_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Város neve:";
            // 
            // varosUpdate_textBox
            // 
            this.varosUpdate_textBox.Location = new System.Drawing.Point(364, 93);
            this.varosUpdate_textBox.Name = "varosUpdate_textBox";
            this.varosUpdate_textBox.Size = new System.Drawing.Size(122, 20);
            this.varosUpdate_textBox.TabIndex = 1;
            // 
            // lakossagUpdate_numericUpDown
            // 
            this.lakossagUpdate_numericUpDown.Location = new System.Drawing.Point(364, 128);
            this.lakossagUpdate_numericUpDown.Name = "lakossagUpdate_numericUpDown";
            this.lakossagUpdate_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.lakossagUpdate_numericUpDown.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lakosság száma:";
            // 
            // modositas_button_form2
            // 
            this.modositas_button_form2.Location = new System.Drawing.Point(255, 168);
            this.modositas_button_form2.Name = "modositas_button_form2";
            this.modositas_button_form2.Size = new System.Drawing.Size(75, 23);
            this.modositas_button_form2.TabIndex = 4;
            this.modositas_button_form2.Text = "Modosítás";
            this.modositas_button_form2.UseVisualStyleBackColor = true;
            this.modositas_button_form2.Click += new System.EventHandler(this.modositas_button_form2_Click);
            // 
            // vissza_Button_f2
            // 
            this.vissza_Button_f2.Location = new System.Drawing.Point(379, 167);
            this.vissza_Button_f2.Name = "vissza_Button_f2";
            this.vissza_Button_f2.Size = new System.Drawing.Size(75, 23);
            this.vissza_Button_f2.TabIndex = 5;
            this.vissza_Button_f2.Text = "Vissza";
            this.vissza_Button_f2.UseVisualStyleBackColor = true;
            this.vissza_Button_f2.Click += new System.EventHandler(this.vissza_Button_f2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vissza_Button_f2);
            this.Controls.Add(this.modositas_button_form2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lakossagUpdate_numericUpDown);
            this.Controls.Add(this.varosUpdate_textBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.lakossagUpdate_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox varosUpdate_textBox;
        private System.Windows.Forms.NumericUpDown lakossagUpdate_numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button modositas_button_form2;
        private System.Windows.Forms.Button vissza_Button_f2;
    }
}