namespace Exercício03
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstNames = new System.Windows.Forms.ListBox();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSex = new System.Windows.Forms.GroupBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.grpSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(8, 8);
            this.lstNames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(242, 199);
            this.lstNames.TabIndex = 0;
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.Location = new System.Drawing.Point(8, 209);
            this.chkFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(85, 17);
            this.chkFilter.TabIndex = 1;
            this.chkFilter.Text = "Filtrar Dados";
            this.chkFilter.UseVisualStyleBackColor = true;
            // 
            // txtInitial
            // 
            this.txtInitial.Location = new System.Drawing.Point(45, 227);
            this.txtInitial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInitial.MaxLength = 1;
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(49, 20);
            this.txtInitial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicial";
            // 
            // grpSex
            // 
            this.grpSex.Controls.Add(this.radMale);
            this.grpSex.Controls.Add(this.radFemale);
            this.grpSex.Location = new System.Drawing.Point(96, 209);
            this.grpSex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSex.Name = "grpSex";
            this.grpSex.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSex.Size = new System.Drawing.Size(153, 57);
            this.grpSex.TabIndex = 4;
            this.grpSex.TabStop = false;
            this.grpSex.Text = "Sexo";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(4, 39);
            this.radMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(73, 17);
            this.radMale.TabIndex = 1;
            this.radMale.Text = "Masculino";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Checked = true;
            this.radFemale.Location = new System.Drawing.Point(4, 19);
            this.radFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(67, 17);
            this.radFemale.TabIndex = 0;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Feminino";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(11, 248);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(83, 21);
            this.cmbClass.TabIndex = 5;
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.Location = new System.Drawing.Point(11, 270);
            this.btnShowStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(238, 29);
            this.btnShowStudents.TabIndex = 6;
            this.btnShowStudents.Text = "Exibir Alunos";
            this.btnShowStudents.UseVisualStyleBackColor = true;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 306);
            this.Controls.Add(this.btnShowStudents);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.grpSex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInitial);
            this.Controls.Add(this.chkFilter);
            this.Controls.Add(this.lstNames);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Exercício 03";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSex.ResumeLayout(false);
            this.grpSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.CheckBox chkFilter;
        private System.Windows.Forms.TextBox txtInitial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSex;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Button btnShowStudents;
    }
}

