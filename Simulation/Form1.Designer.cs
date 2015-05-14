namespace SimulationRemonteeSki
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbParametresEntree = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSortie = new System.Windows.Forms.DataGridView();
            this.dgvNomValeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSimule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCalcule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panelProcessus = new System.Windows.Forms.TabPage();
            this.panelRepresentation = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDateDebut = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gpbParametresEntree.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortie)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbParametresEntree
            // 
            this.gpbParametresEntree.Controls.Add(this.button1);
            this.gpbParametresEntree.Controls.Add(this.label4);
            this.gpbParametresEntree.Controls.Add(this.label3);
            this.gpbParametresEntree.Controls.Add(this.numericUpDown2);
            this.gpbParametresEntree.Controls.Add(this.numericUpDown1);
            this.gpbParametresEntree.Controls.Add(this.label2);
            this.gpbParametresEntree.Controls.Add(this.label1);
            this.gpbParametresEntree.Controls.Add(this.dtpFin);
            this.gpbParametresEntree.Controls.Add(this.dtpDebut);
            this.gpbParametresEntree.Controls.Add(this.lbA);
            this.gpbParametresEntree.Controls.Add(this.lbDateDebut);
            this.gpbParametresEntree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbParametresEntree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbParametresEntree.Location = new System.Drawing.Point(0, 0);
            this.gpbParametresEntree.Name = "gpbParametresEntree";
            this.gpbParametresEntree.Size = new System.Drawing.Size(450, 369);
            this.gpbParametresEntree.TabIndex = 0;
            this.gpbParametresEntree.TabStop = false;
            this.gpbParametresEntree.Text = "Parametres d\'entrées";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSortie);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valeurs de sortie";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gpbParametresEntree);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 614);
            this.panel1.TabIndex = 2;
            // 
            // dgvSortie
            // 
            this.dgvSortie.AllowUserToAddRows = false;
            this.dgvSortie.AllowUserToDeleteRows = false;
            this.dgvSortie.AllowUserToResizeColumns = false;
            this.dgvSortie.AllowUserToResizeRows = false;
            this.dgvSortie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSortie.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSortie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSortie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSortie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSortie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNomValeur,
            this.dgvSimule,
            this.dgvCalcule});
            this.dgvSortie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSortie.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSortie.EnableHeadersVisualStyles = false;
            this.dgvSortie.Location = new System.Drawing.Point(3, 25);
            this.dgvSortie.MultiSelect = false;
            this.dgvSortie.Name = "dgvSortie";
            this.dgvSortie.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSortie.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSortie.RowHeadersVisible = false;
            this.dgvSortie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSortie.Size = new System.Drawing.Size(444, 217);
            this.dgvSortie.TabIndex = 0;
            // 
            // dgvNomValeur
            // 
            this.dgvNomValeur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNomValeur.FillWeight = 60F;
            this.dgvNomValeur.HeaderText = "";
            this.dgvNomValeur.Name = "dgvNomValeur";
            this.dgvNomValeur.ReadOnly = true;
            // 
            // dgvSimule
            // 
            this.dgvSimule.FillWeight = 20F;
            this.dgvSimule.HeaderText = "Simulé";
            this.dgvSimule.Name = "dgvSimule";
            this.dgvSimule.ReadOnly = true;
            // 
            // dgvCalcule
            // 
            this.dgvCalcule.FillWeight = 20F;
            this.dgvCalcule.HeaderText = "Calculé";
            this.dgvCalcule.Name = "dgvCalcule";
            this.dgvCalcule.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.panelProcessus);
            this.tabControl1.Controls.Add(this.panelRepresentation);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 369);
            this.tabControl1.TabIndex = 3;
            // 
            // panelProcessus
            // 
            this.panelProcessus.Location = new System.Drawing.Point(4, 26);
            this.panelProcessus.Name = "panelProcessus";
            this.panelProcessus.Padding = new System.Windows.Forms.Padding(3);
            this.panelProcessus.Size = new System.Drawing.Size(590, 339);
            this.panelProcessus.TabIndex = 0;
            this.panelProcessus.Text = "Processus";
            this.panelProcessus.UseVisualStyleBackColor = true;
            // 
            // panelRepresentation
            // 
            this.panelRepresentation.Location = new System.Drawing.Point(4, 26);
            this.panelRepresentation.Name = "panelRepresentation";
            this.panelRepresentation.Padding = new System.Windows.Forms.Padding(3);
            this.panelRepresentation.Size = new System.Drawing.Size(785, 333);
            this.panelRepresentation.TabIndex = 1;
            this.panelRepresentation.Text = "Représentation";
            this.panelRepresentation.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(450, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 614);
            this.panel2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(0, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 245);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historique";
            // 
            // lbDateDebut
            // 
            this.lbDateDebut.AutoSize = true;
            this.lbDateDebut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbDateDebut.Location = new System.Drawing.Point(13, 29);
            this.lbDateDebut.Name = "lbDateDebut";
            this.lbDateDebut.Size = new System.Drawing.Size(35, 19);
            this.lbDateDebut.TabIndex = 0;
            this.lbDateDebut.Text = "De :";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbA.Location = new System.Drawing.Point(140, 29);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(25, 19);
            this.lbA.TabIndex = 1;
            this.lbA.Text = "à :";
            // 
            // dtpDebut
            // 
            this.dtpDebut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDebut.Location = new System.Drawing.Point(54, 26);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.ShowUpDown = true;
            this.dtpDebut.Size = new System.Drawing.Size(79, 25);
            this.dtpDebut.TabIndex = 2;
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFin.Location = new System.Drawing.Point(171, 26);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.ShowUpDown = true;
            this.dtpFin.Size = new System.Drawing.Size(79, 25);
            this.dtpFin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadence de sortie :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cadence d\'entrée :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.numericUpDown1.Location = new System.Drawing.Point(157, 55);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 25);
            this.numericUpDown1.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.numericUpDown2.Location = new System.Drawing.Point(157, 87);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(42, 25);
            this.numericUpDown2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(205, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "par minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(205, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "par minutes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Lancer la simulation";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(592, 217);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 614);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbParametresEntree.ResumeLayout(false);
            this.gpbParametresEntree.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortie)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbParametresEntree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbDateDebut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSortie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNomValeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSimule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCalcule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage panelProcessus;
        private System.Windows.Forms.TabPage panelRepresentation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}