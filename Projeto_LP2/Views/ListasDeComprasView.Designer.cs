﻿namespace Projeto_LP2.Views
{
    partial class ListasDeComprasView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnNovaLista = new System.Windows.Forms.Button();
            this.dataGridViewItensLista = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnAdicionarProdutoLista = new System.Windows.Forms.Button();
            this.dataGridViewListas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItensLista)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.txtFiltro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 47);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(500, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 44);
            this.button5.TabIndex = 4;
            this.button5.Text = "Filtrar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(230, 15);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(260, 20);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dataGridViewItensLista);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridViewListas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 594);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRemover);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.btnNovaLista);
            this.panel4.Location = new System.Drawing.Point(0, 288);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 47);
            this.panel4.TabIndex = 3;
            // 
            // btnRemover
            // 
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Location = new System.Drawing.Point(447, 0);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 47);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(366, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 47);
            this.button8.TabIndex = 9;
            this.button8.Text = "Editar lista";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btnNovaLista
            // 
            this.btnNovaLista.FlatAppearance.BorderSize = 0;
            this.btnNovaLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNovaLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNovaLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaLista.Location = new System.Drawing.Point(285, 0);
            this.btnNovaLista.Name = "btnNovaLista";
            this.btnNovaLista.Size = new System.Drawing.Size(75, 47);
            this.btnNovaLista.TabIndex = 8;
            this.btnNovaLista.Text = "Nova lista";
            this.btnNovaLista.UseVisualStyleBackColor = true;
            this.btnNovaLista.Click += new System.EventHandler(this.btnNovaLista_Click);
            // 
            // dataGridViewItensLista
            // 
            this.dataGridViewItensLista.AllowUserToAddRows = false;
            this.dataGridViewItensLista.AllowUserToDeleteRows = false;
            this.dataGridViewItensLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItensLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewItensLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItensLista.Location = new System.Drawing.Point(-5, 341);
            this.dataGridViewItensLista.MultiSelect = false;
            this.dataGridViewItensLista.Name = "dataGridViewItensLista";
            this.dataGridViewItensLista.ReadOnly = true;
            this.dataGridViewItensLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItensLista.Size = new System.Drawing.Size(800, 200);
            this.dataGridViewItensLista.TabIndex = 2;
            this.dataGridViewItensLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItensLista_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRemoverProduto);
            this.panel3.Controls.Add(this.btnAdicionarProdutoLista);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 547);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 47);
            this.panel3.TabIndex = 1;
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.FlatAppearance.BorderSize = 0;
            this.btnRemoverProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRemoverProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRemoverProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverProduto.Location = new System.Drawing.Point(403, 0);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(75, 47);
            this.btnRemoverProduto.TabIndex = 10;
            this.btnRemoverProduto.Text = "Remover produto";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // btnAdicionarProdutoLista
            // 
            this.btnAdicionarProdutoLista.FlatAppearance.BorderSize = 0;
            this.btnAdicionarProdutoLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdicionarProdutoLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdicionarProdutoLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProdutoLista.Location = new System.Drawing.Point(322, 0);
            this.btnAdicionarProdutoLista.Name = "btnAdicionarProdutoLista";
            this.btnAdicionarProdutoLista.Size = new System.Drawing.Size(75, 47);
            this.btnAdicionarProdutoLista.TabIndex = 9;
            this.btnAdicionarProdutoLista.Text = "Adicionar produto";
            this.btnAdicionarProdutoLista.UseVisualStyleBackColor = true;
            this.btnAdicionarProdutoLista.Click += new System.EventHandler(this.btnAdicionarProdutoLista_Click);
            // 
            // dataGridViewListas
            // 
            this.dataGridViewListas.AllowUserToAddRows = false;
            this.dataGridViewListas.AllowUserToDeleteRows = false;
            this.dataGridViewListas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewListas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewListas.MultiSelect = false;
            this.dataGridViewListas.Name = "dataGridViewListas";
            this.dataGridViewListas.ReadOnly = true;
            this.dataGridViewListas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListas.Size = new System.Drawing.Size(800, 282);
            this.dataGridViewListas.TabIndex = 0;
            this.dataGridViewListas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListas_CellClick);
            this.dataGridViewListas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListas_CellContentClick);
            // 
            // ListasDeComprasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListasDeComprasView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListasDeComprasView";
            this.Load += new System.EventHandler(this.ListasDeComprasView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItensLista)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewListas;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnAdicionarProdutoLista;
        private System.Windows.Forms.DataGridView dataGridViewItensLista;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnNovaLista;
    }
}