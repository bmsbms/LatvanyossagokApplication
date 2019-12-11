namespace LatvanyossagokApplication
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kivalasztottVarosUpdate_textBox = new System.Windows.Forms.TextBox();
            this.LatvanyossagNevUpdate_textBox = new System.Windows.Forms.TextBox();
            this.LatvanyossagLeirasUpdate_textbox = new System.Windows.Forms.TextBox();
            this.form3_modositasButton = new System.Windows.Forms.Button();
            this.vissza_f3 = new System.Windows.Forms.Button();
            this.LatvanyossagArUpdate_numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.LatvanyossagArUpdate_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kivalasztott város:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Látványosság neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Látványosság leírása:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Látványosság ára:";
            // 
            // kivalasztottVarosUpdate_textBox
            // 
            this.kivalasztottVarosUpdate_textBox.Location = new System.Drawing.Point(366, 72);
            this.kivalasztottVarosUpdate_textBox.Name = "kivalasztottVarosUpdate_textBox";
            this.kivalasztottVarosUpdate_textBox.Size = new System.Drawing.Size(100, 20);
            this.kivalasztottVarosUpdate_textBox.TabIndex = 4;
            // 
            // LatvanyossagNevUpdate_textBox
            // 
            this.LatvanyossagNevUpdate_textBox.Location = new System.Drawing.Point(366, 99);
            this.LatvanyossagNevUpdate_textBox.Name = "LatvanyossagNevUpdate_textBox";
            this.LatvanyossagNevUpdate_textBox.Size = new System.Drawing.Size(100, 20);
            this.LatvanyossagNevUpdate_textBox.TabIndex = 5;
            // 
            // LatvanyossagLeirasUpdate_textbox
            // 
            this.LatvanyossagLeirasUpdate_textbox.Location = new System.Drawing.Point(366, 126);
            this.LatvanyossagLeirasUpdate_textbox.Name = "LatvanyossagLeirasUpdate_textbox";
            this.LatvanyossagLeirasUpdate_textbox.Size = new System.Drawing.Size(100, 20);
            this.LatvanyossagLeirasUpdate_textbox.TabIndex = 6;
            // 
            // form3_modositasButton
            // 
            this.form3_modositasButton.Location = new System.Drawing.Point(224, 220);
            this.form3_modositasButton.Name = "form3_modositasButton";
            this.form3_modositasButton.Size = new System.Drawing.Size(75, 23);
            this.form3_modositasButton.TabIndex = 8;
            this.form3_modositasButton.Text = "Módosítás";
            this.form3_modositasButton.UseVisualStyleBackColor = true;
            this.form3_modositasButton.Click += new System.EventHandler(this.form3_modositasButton_Click);
            // 
            // vissza_f3
            // 
            this.vissza_f3.Location = new System.Drawing.Point(386, 219);
            this.vissza_f3.Name = "vissza_f3";
            this.vissza_f3.Size = new System.Drawing.Size(75, 23);
            this.vissza_f3.TabIndex = 9;
            this.vissza_f3.Text = "Vissza";
            this.vissza_f3.UseVisualStyleBackColor = true;
            // 
            // LatvanyossagArUpdate_numericUpDown
            // 
            this.LatvanyossagArUpdate_numericUpDown.Location = new System.Drawing.Point(366, 153);
            this.LatvanyossagArUpdate_numericUpDown.Name = "LatvanyossagArUpdate_numericUpDown";
            this.LatvanyossagArUpdate_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.LatvanyossagArUpdate_numericUpDown.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LatvanyossagArUpdate_numericUpDown);
            this.Controls.Add(this.vissza_f3);
            this.Controls.Add(this.form3_modositasButton);
            this.Controls.Add(this.LatvanyossagLeirasUpdate_textbox);
            this.Controls.Add(this.LatvanyossagNevUpdate_textBox);
            this.Controls.Add(this.kivalasztottVarosUpdate_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.LatvanyossagArUpdate_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kivalasztottVarosUpdate_textBox;
        private System.Windows.Forms.TextBox LatvanyossagNevUpdate_textBox;
        private System.Windows.Forms.TextBox LatvanyossagLeirasUpdate_textbox;
        private System.Windows.Forms.Button form3_modositasButton;
        private System.Windows.Forms.Button vissza_f3;
        private System.Windows.Forms.NumericUpDown LatvanyossagArUpdate_numericUpDown;
    }
}