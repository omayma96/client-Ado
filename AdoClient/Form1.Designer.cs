
namespace AdoClient
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pclientDataSet1 = new AdoClient.pclientDataSet1();
            this.clientTableAdapter1 = new AdoClient.pclientDataSet1TableAdapters.clientTableAdapter();
            this.Nom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.Label();
            this.Ville = new System.Windows.Forms.Label();
            this.box_Nom = new System.Windows.Forms.TextBox();
            this.box_Prenom = new System.Windows.Forms.TextBox();
            this.box_Adress = new System.Windows.Forms.TextBox();
            this.box_Ville = new System.Windows.Forms.TextBox();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbvilleFilter = new System.Windows.Forms.ComboBox();
            this.pclientDataSet2 = new AdoClient.pclientDataSet2();
            this.villesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villesTableAdapter = new AdoClient.pclientDataSet2TableAdapters.villesTableAdapter();
            this.villesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pclientDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclientDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclientDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclientDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.DataSource = this.bindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(122, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 45;
            this.dataGridView2.Size = new System.Drawing.Size(689, 142);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "client";
            this.bindingSource1.DataSource = this.pclientDataSet1;
            // 
            // pclientDataSet1
            // 
            this.pclientDataSet1.DataSetName = "pclientDataSet1";
            this.pclientDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(203, 195);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(34, 15);
            this.Nom.TabIndex = 1;
            this.Nom.Text = "Nom";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(204, 224);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(51, 15);
            this.prenom.TabIndex = 2;
            this.prenom.Text = "Prenom";
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Location = new System.Drawing.Point(206, 253);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(44, 15);
            this.Adress.TabIndex = 3;
            this.Adress.Text = "Adress";
            // 
            // Ville
            // 
            this.Ville.AutoSize = true;
            this.Ville.Location = new System.Drawing.Point(209, 284);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(30, 15);
            this.Ville.TabIndex = 4;
            this.Ville.Text = "Ville";
            // 
            // box_Nom
            // 
            this.box_Nom.Location = new System.Drawing.Point(264, 192);
            this.box_Nom.Name = "box_Nom";
            this.box_Nom.Size = new System.Drawing.Size(306, 20);
            this.box_Nom.TabIndex = 5;
            // 
            // box_Prenom
            // 
            this.box_Prenom.Location = new System.Drawing.Point(264, 223);
            this.box_Prenom.Name = "box_Prenom";
            this.box_Prenom.Size = new System.Drawing.Size(306, 20);
            this.box_Prenom.TabIndex = 6;
            // 
            // box_Adress
            // 
            this.box_Adress.Location = new System.Drawing.Point(264, 253);
            this.box_Adress.Name = "box_Adress";
            this.box_Adress.Size = new System.Drawing.Size(306, 20);
            this.box_Adress.TabIndex = 7;
            // 
            // box_Ville
            // 
            this.box_Ville.Location = new System.Drawing.Point(263, 282);
            this.box_Ville.Name = "box_Ville";
            this.box_Ville.Size = new System.Drawing.Size(306, 20);
            this.box_Ville.TabIndex = 8;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Ajouter.Location = new System.Drawing.Point(661, 180);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(127, 42);
            this.btn_Ajouter.TabIndex = 9;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = false;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.Red;
            this.btn_supprimer.Location = new System.Drawing.Point(664, 232);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(123, 43);
            this.btn_supprimer.TabIndex = 10;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Gold;
            this.btn_update.Location = new System.Drawing.Point(665, 284);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(123, 43);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "modifier";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "nom";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "prenom";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "adress";
            this.dataGridViewTextBoxColumn4.HeaderText = "adress";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 220;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ville";
            this.dataGridViewTextBoxColumn5.HeaderText = "ville";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Aqua;
            this.btnSave.Location = new System.Drawing.Point(348, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(218, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbvilleFilter
            // 
            this.cbvilleFilter.DataSource = this.villesBindingSource2;
            this.cbvilleFilter.DisplayMember = "ville";
            this.cbvilleFilter.FormattingEnabled = true;
            this.cbvilleFilter.Location = new System.Drawing.Point(818, 27);
            this.cbvilleFilter.Name = "cbvilleFilter";
            this.cbvilleFilter.Size = new System.Drawing.Size(79, 21);
            this.cbvilleFilter.TabIndex = 13;
            this.cbvilleFilter.ValueMember = "ville";
            this.cbvilleFilter.SelectedIndexChanged += new System.EventHandler(this.cbvilleFilter_SelectedIndexChanged);
            // 
            // pclientDataSet2
            // 
            this.pclientDataSet2.DataSetName = "pclientDataSet2";
            this.pclientDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // villesBindingSource
            // 
            this.villesBindingSource.DataMember = "villes";
            this.villesBindingSource.DataSource = this.pclientDataSet2;
            // 
            // villesTableAdapter
            // 
            this.villesTableAdapter.ClearBeforeFill = true;
            // 
            // villesBindingSource1
            // 
            this.villesBindingSource1.DataMember = "villes";
            this.villesBindingSource1.DataSource = this.pclientDataSet2;
            // 
            // pclientDataSet2BindingSource
            // 
            this.pclientDataSet2BindingSource.DataSource = this.pclientDataSet2;
            this.pclientDataSet2BindingSource.Position = 0;
            // 
            // villesBindingSource2
            // 
            this.villesBindingSource2.DataMember = "villes";
            this.villesBindingSource2.DataSource = this.pclientDataSet2BindingSource;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(910, 359);
            this.Controls.Add(this.cbvilleFilter);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.box_Ville);
            this.Controls.Add(this.box_Adress);
            this.Controls.Add(this.box_Prenom);
            this.Controls.Add(this.box_Nom);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclientDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclientDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclientDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


    
        private System.Windows.Forms.DataGridView dataGridView2;
        private pclientDataSet1 pclientDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private pclientDataSet1TableAdapters.clientTableAdapter clientTableAdapter1;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.Label Ville;
        private System.Windows.Forms.TextBox box_Nom;
        private System.Windows.Forms.TextBox box_Prenom;
        private System.Windows.Forms.TextBox box_Adress;
        private System.Windows.Forms.TextBox box_Ville;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbvilleFilter;
        private pclientDataSet2 pclientDataSet2;
        private System.Windows.Forms.BindingSource villesBindingSource;
        private pclientDataSet2TableAdapters.villesTableAdapter villesTableAdapter;
        private System.Windows.Forms.BindingSource villesBindingSource2;
        private System.Windows.Forms.BindingSource pclientDataSet2BindingSource;
        private System.Windows.Forms.BindingSource villesBindingSource1;
    }
}

