
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
            this.btnSave = new System.Windows.Forms.Button();
            this.cbvilleFilter = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pclientDataSet4 = new AdoClient.pclientDataSet4();
            this.villeTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pclientDataSet3 = new AdoClient.pclientDataSet3();
            this.villesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.villesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.villesBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.villeTTableAdapter = new AdoClient.pclientDataSet3TableAdapters.villeTTableAdapter();
            this.clientTableAdapter = new AdoClient.pclientDataSet4TableAdapters.clientTableAdapter();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btn_noFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclientDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclientDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(77, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 45;
            this.dataGridView2.Size = new System.Drawing.Size(658, 142);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
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
            this.btn_Ajouter.Text = "Enregistrer";
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
            this.btn_update.Text = "Mettre à jour";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Aqua;
            this.btnSave.Location = new System.Drawing.Point(313, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(218, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbvilleFilter
            // 
            this.cbvilleFilter.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientBindingSource, "ville", true));
            this.cbvilleFilter.DataSource = this.villeTBindingSource;
            this.cbvilleFilter.DisplayMember = "nameV";
            this.cbvilleFilter.FormattingEnabled = true;
            this.cbvilleFilter.Location = new System.Drawing.Point(775, 86);
            this.cbvilleFilter.Name = "cbvilleFilter";
            this.cbvilleFilter.Size = new System.Drawing.Size(111, 21);
            this.cbvilleFilter.TabIndex = 13;
            this.cbvilleFilter.ValueMember = "nameV";
            this.cbvilleFilter.Visible = false;
            this.cbvilleFilter.SelectedIndexChanged += new System.EventHandler(this.cbvilleFilter_SelectedIndexChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.pclientDataSet4;
            // 
            // pclientDataSet4
            // 
            this.pclientDataSet4.DataSetName = "pclientDataSet4";
            this.pclientDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // villeTBindingSource
            // 
            this.villeTBindingSource.DataMember = "villeT";
            this.villeTBindingSource.DataSource = this.pclientDataSet3;
            // 
            // pclientDataSet3
            // 
            this.pclientDataSet3.DataSetName = "pclientDataSet3";
            this.pclientDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // villeTTableAdapter
            // 
            this.villeTTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.MediumPurple;
            this.btnFilter.Location = new System.Drawing.Point(775, 24);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(111, 55);
            this.btnFilter.TabIndex = 14;
            this.btnFilter.Text = "filtrer";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btn_noFilter
            // 
            this.btn_noFilter.BackColor = System.Drawing.Color.Magenta;
            this.btn_noFilter.Location = new System.Drawing.Point(775, 116);
            this.btn_noFilter.Name = "btn_noFilter";
            this.btn_noFilter.Size = new System.Drawing.Size(110, 50);
            this.btn_noFilter.TabIndex = 15;
            this.btn_noFilter.Text = "No filtre";
            this.btn_noFilter.UseVisualStyleBackColor = false;
            this.btn_noFilter.Visible = false;
            this.btn_noFilter.Click += new System.EventHandler(this.btn_noFilter_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(910, 359);
            this.Controls.Add(this.btn_noFilter);
            this.Controls.Add(this.btnFilter);
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
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclientDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclientDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


    
        private System.Windows.Forms.DataGridView dataGridView2;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbvilleFilter;
        private System.Windows.Forms.BindingSource villesBindingSource3;
        private System.Windows.Forms.BindingSource villesBindingSource4;
        private System.Windows.Forms.BindingSource villesBindingSource5;
        private pclientDataSet3 pclientDataSet3;
        private System.Windows.Forms.BindingSource villeTBindingSource;
        private pclientDataSet3TableAdapters.villeTTableAdapter villeTTableAdapter;
        private pclientDataSet4 pclientDataSet4;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private pclientDataSet4TableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btn_noFilter;
    }
}

