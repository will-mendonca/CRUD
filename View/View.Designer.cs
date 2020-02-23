namespace CRUD
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gpCadastro = new System.Windows.Forms.GroupBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpLista = new System.Windows.Forms.GroupBox();
            this.dtLista = new System.Windows.Forms.DataGridView();
            this.gpCadastro.SuspendLayout();
            this.gpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.AccessibleName = "";
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(55, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(40, 40);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Tag = "";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.BackgroundImage")));
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Location = new System.Drawing.Point(101, 12);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(40, 40);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemover.BackgroundImage")));
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.Location = new System.Drawing.Point(147, 12);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(40, 40);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Location = new System.Drawing.Point(193, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(40, 40);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gpCadastro
            // 
            this.gpCadastro.Controls.Add(this.txtEndereco);
            this.gpCadastro.Controls.Add(this.txtEmail);
            this.gpCadastro.Controls.Add(this.label4);
            this.gpCadastro.Controls.Add(this.label3);
            this.gpCadastro.Controls.Add(this.txtIdade);
            this.gpCadastro.Controls.Add(this.txtNome);
            this.gpCadastro.Controls.Add(this.label2);
            this.gpCadastro.Controls.Add(this.label1);
            this.gpCadastro.Location = new System.Drawing.Point(55, 73);
            this.gpCadastro.Name = "gpCadastro";
            this.gpCadastro.Size = new System.Drawing.Size(590, 219);
            this.gpCadastro.TabIndex = 4;
            this.gpCadastro.TabStop = false;
            this.gpCadastro.Text = "Cadastro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(208, 165);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(216, 22);
            this.txtEndereco.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(208, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "ENDEREÇO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "EMAIL:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(208, 77);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(51, 22);
            this.txtIdade.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(208, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(216, 22);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDADE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME:";
            // 
            // gpLista
            // 
            this.gpLista.Controls.Add(this.dtLista);
            this.gpLista.Location = new System.Drawing.Point(55, 322);
            this.gpLista.Name = "gpLista";
            this.gpLista.Size = new System.Drawing.Size(590, 286);
            this.gpLista.TabIndex = 5;
            this.gpLista.TabStop = false;
            this.gpLista.Text = "Lista";
            // 
            // dtLista
            // 
            this.dtLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(128)))));
            this.dtLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtLista.Location = new System.Drawing.Point(3, 18);
            this.dtLista.Name = "dtLista";
            this.dtLista.RowHeadersWidth = 51;
            this.dtLista.RowTemplate.Height = 24;
            this.dtLista.Size = new System.Drawing.Size(584, 265);
            this.dtLista.TabIndex = 0;
            this.dtLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLista_CellContentClick);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(698, 620);
            this.Controls.Add(this.gpLista);
            this.Controls.Add(this.gpCadastro);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoas";
            this.gpCadastro.ResumeLayout(false);
            this.gpCadastro.PerformLayout();
            this.gpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gpCadastro;
        private System.Windows.Forms.GroupBox gpLista;
        private System.Windows.Forms.DataGridView dtLista;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

