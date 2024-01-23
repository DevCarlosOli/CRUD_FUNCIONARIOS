namespace CestaBasica
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdicionarBtn = new System.Windows.Forms.Button();
            this.AlterarBtn = new System.Windows.Forms.Button();
            this.DeletarBtn = new System.Windows.Forms.Button();
            this.SairBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // AdicionarBtn
            // 
            this.AdicionarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdicionarBtn.Location = new System.Drawing.Point(12, 302);
            this.AdicionarBtn.Name = "AdicionarBtn";
            this.AdicionarBtn.Size = new System.Drawing.Size(100, 30);
            this.AdicionarBtn.TabIndex = 1;
            this.AdicionarBtn.Text = "Adicionar";
            this.AdicionarBtn.UseVisualStyleBackColor = true;
            this.AdicionarBtn.Click += new System.EventHandler(this.AdicionarBtn_Click);
            // 
            // AlterarBtn
            // 
            this.AlterarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlterarBtn.Location = new System.Drawing.Point(229, 301);
            this.AlterarBtn.Name = "AlterarBtn";
            this.AlterarBtn.Size = new System.Drawing.Size(100, 30);
            this.AlterarBtn.TabIndex = 2;
            this.AlterarBtn.Text = "Alterar";
            this.AlterarBtn.UseVisualStyleBackColor = true;
            this.AlterarBtn.Click += new System.EventHandler(this.AlterarBtn_Click);
            // 
            // DeletarBtn
            // 
            this.DeletarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletarBtn.Location = new System.Drawing.Point(446, 300);
            this.DeletarBtn.Name = "DeletarBtn";
            this.DeletarBtn.Size = new System.Drawing.Size(100, 30);
            this.DeletarBtn.TabIndex = 3;
            this.DeletarBtn.Text = "Deletar";
            this.DeletarBtn.UseVisualStyleBackColor = true;
            this.DeletarBtn.Click += new System.EventHandler(this.DeletarBtn_Click);
            // 
            // SairBtn
            // 
            this.SairBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairBtn.Location = new System.Drawing.Point(663, 299);
            this.SairBtn.Name = "SairBtn";
            this.SairBtn.Size = new System.Drawing.Size(100, 30);
            this.SairBtn.TabIndex = 4;
            this.SairBtn.Text = "Sair";
            this.SairBtn.UseVisualStyleBackColor = true;
            this.SairBtn.Click += new System.EventHandler(this.SairBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista de Funcionários";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(776, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SairBtn);
            this.Controls.Add(this.DeletarBtn);
            this.Controls.Add(this.AlterarBtn);
            this.Controls.Add(this.AdicionarBtn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaInicial";
            this.Text = "Tela Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AdicionarBtn;
        private System.Windows.Forms.Button AlterarBtn;
        private System.Windows.Forms.Button DeletarBtn;
        private System.Windows.Forms.Button SairBtn;
        private System.Windows.Forms.Label label1;
    }
}

