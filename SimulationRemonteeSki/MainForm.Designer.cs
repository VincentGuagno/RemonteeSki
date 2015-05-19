namespace SimulationRemonteeSki
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.gpbParametresEntree = new System.Windows.Forms.GroupBox();
            this.numStations = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numCadenceEntree = new System.Windows.Forms.NumericUpDown();
            this.numCadenceSortie = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.lbA = new System.Windows.Forms.Label();
            this.lbDateDebut = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSortie = new System.Windows.Forms.DataGridView();
            this.dgvNomValeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSimule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCalcule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnScroll2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnScroll = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbHistorique = new System.Windows.Forms.RichTextBox();
            this.timerIntervalle = new System.Windows.Forms.Timer(this.components);
            this.uc_Evenement1 = new SimulationRemonteeSki.Uc_Evenement();
            this.uc_PopulationFileAttente1 = new SimulationRemonteeSki.Uc_PopulationFileAttente();
            this.gpbParametresEntree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCadenceEntree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCadenceSortie)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortie)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnScroll2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnScroll.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbParametresEntree
            // 
            this.gpbParametresEntree.Controls.Add(this.numStations);
            this.gpbParametresEntree.Controls.Add(this.label5);
            this.gpbParametresEntree.Controls.Add(this.button1);
            this.gpbParametresEntree.Controls.Add(this.label4);
            this.gpbParametresEntree.Controls.Add(this.label3);
            this.gpbParametresEntree.Controls.Add(this.numCadenceEntree);
            this.gpbParametresEntree.Controls.Add(this.numCadenceSortie);
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
            this.gpbParametresEntree.Size = new System.Drawing.Size(599, 172);
            this.gpbParametresEntree.TabIndex = 0;
            this.gpbParametresEntree.TabStop = false;
            this.gpbParametresEntree.Text = "Paramètres d\'entrées";
            // 
            // numStations
            // 
            this.numStations.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.numStations.Location = new System.Drawing.Point(168, 117);
            this.numStations.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStations.Name = "numStations";
            this.numStations.Size = new System.Drawing.Size(42, 25);
            this.numStations.TabIndex = 12;
            this.numStations.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numStations.ValueChanged += new System.EventHandler(this.numStations_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre de stations :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Lancer la simulation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(216, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "par heures";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(216, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "par heures";
            // 
            // numCadenceEntree
            // 
            this.numCadenceEntree.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.numCadenceEntree.Location = new System.Drawing.Point(168, 87);
            this.numCadenceEntree.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCadenceEntree.Name = "numCadenceEntree";
            this.numCadenceEntree.Size = new System.Drawing.Size(42, 25);
            this.numCadenceEntree.TabIndex = 7;
            this.numCadenceEntree.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numCadenceEntree.ValueChanged += new System.EventHandler(this.numCadenceEntree_ValueChanged);
            // 
            // numCadenceSortie
            // 
            this.numCadenceSortie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.numCadenceSortie.Location = new System.Drawing.Point(168, 55);
            this.numCadenceSortie.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCadenceSortie.Name = "numCadenceSortie";
            this.numCadenceSortie.Size = new System.Drawing.Size(42, 25);
            this.numCadenceSortie.TabIndex = 6;
            this.numCadenceSortie.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numCadenceSortie.ValueChanged += new System.EventHandler(this.numCadenceSortie_ValueChanged);
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
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFin.Location = new System.Drawing.Point(171, 26);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.ShowUpDown = true;
            this.dtpFin.Size = new System.Drawing.Size(79, 25);
            this.dtpFin.TabIndex = 3;
            this.dtpFin.Value = new System.DateTime(2015, 5, 11, 17, 0, 0, 0);
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
            this.dtpDebut.Value = new System.DateTime(2015, 5, 11, 8, 0, 0, 0);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSortie);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 442);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valeurs de sortie";
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
            this.dgvSortie.RowHeadersVisible = false;
            this.dgvSortie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSortie.Size = new System.Drawing.Size(593, 414);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.gpbParametresEntree);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 614);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(599, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 614);
            this.panel2.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(666, 369);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Processus";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnScroll2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(660, 164);
            this.panel4.TabIndex = 2;
            // 
            // pnScroll2
            // 
            this.pnScroll2.AutoScroll = true;
            this.pnScroll2.Controls.Add(this.uc_Evenement1);
            this.pnScroll2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnScroll2.Location = new System.Drawing.Point(0, 0);
            this.pnScroll2.Name = "pnScroll2";
            this.pnScroll2.Size = new System.Drawing.Size(473, 164);
            this.pnScroll2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnScroll);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 177);
            this.panel3.TabIndex = 1;
            // 
            // pnScroll
            // 
            this.pnScroll.AutoScroll = true;
            this.pnScroll.Controls.Add(this.uc_PopulationFileAttente1);
            this.pnScroll.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnScroll.Location = new System.Drawing.Point(0, 0);
            this.pnScroll.Name = "pnScroll";
            this.pnScroll.Size = new System.Drawing.Size(473, 177);
            this.pnScroll.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbHistorique);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(0, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 245);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historique";
            // 
            // rtbHistorique
            // 
            this.rtbHistorique.BackColor = System.Drawing.SystemColors.Control;
            this.rtbHistorique.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbHistorique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbHistorique.Location = new System.Drawing.Point(3, 25);
            this.rtbHistorique.Name = "rtbHistorique";
            this.rtbHistorique.Size = new System.Drawing.Size(660, 217);
            this.rtbHistorique.TabIndex = 0;
            this.rtbHistorique.Text = "";
            // 
            // timerIntervalle
            // 
            this.timerIntervalle.Interval = 500;
            this.timerIntervalle.Tick += new System.EventHandler(this.timerIntervalle_Tick);
            // 
            // uc_Evenement1
            // 
            this.uc_Evenement1.DefinitionVerticale = 6;
            this.uc_Evenement1.Hauteur = 30;
            this.uc_Evenement1.Location = new System.Drawing.Point(5, 4);
            this.uc_Evenement1.Margin = new System.Windows.Forms.Padding(4);
            this.uc_Evenement1.Name = "uc_Evenement1";
            this.uc_Evenement1.PixelParUT = 200;
            this.uc_Evenement1.Size = new System.Drawing.Size(298, 150);
            this.uc_Evenement1.TabIndex = 0;
            this.uc_Evenement1.TailleGraduationHorizontale = 0.5D;
            // 
            // uc_PopulationFileAttente1
            // 
            this.uc_PopulationFileAttente1.DefinitionVerticale = 6;
            this.uc_PopulationFileAttente1.Hauteur = 30;
            this.uc_PopulationFileAttente1.Location = new System.Drawing.Point(5, 6);
            this.uc_PopulationFileAttente1.Margin = new System.Windows.Forms.Padding(5);
            this.uc_PopulationFileAttente1.Name = "uc_PopulationFileAttente1";
            this.uc_PopulationFileAttente1.PixelParUT = 200;
            this.uc_PopulationFileAttente1.Size = new System.Drawing.Size(463, 148);
            this.uc_PopulationFileAttente1.TabIndex = 0;
            this.uc_PopulationFileAttente1.TailleGraduationHorizontale = 0.5D;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1265, 614);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Remontée de ski";
            this.gpbParametresEntree.ResumeLayout(false);
            this.gpbParametresEntree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCadenceEntree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCadenceSortie)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortie)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnScroll2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnScroll.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCadenceEntree;
        private System.Windows.Forms.NumericUpDown numCadenceSortie;
        private System.Windows.Forms.RichTextBox rtbHistorique;
        private System.Windows.Forms.GroupBox groupBox3;
        private Uc_PopulationFileAttente uc_PopulationFileAttente1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnScroll;
        private System.Windows.Forms.Timer timerIntervalle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnScroll2;
        private Uc_Evenement uc_Evenement1;
        private System.Windows.Forms.NumericUpDown numStations;
        private System.Windows.Forms.Label label5;
    }
}