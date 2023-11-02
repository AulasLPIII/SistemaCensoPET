namespace SistemaCensoPET
{
    partial class FrmCadCondominio
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
            barraFerramentas = new ToolStrip();
            toolStripBtnNovo = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripBtnSalvar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripBtnListar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripBtnApagar = new ToolStripButton();
            LblNome = new Label();
            LblEndereco = new Label();
            LblNumero = new Label();
            LblCep = new Label();
            TxtNome = new TextBox();
            TxtEndereco = new TextBox();
            TxtNumero = new TextBox();
            TxtCep = new TextBox();
            barraFerramentas.SuspendLayout();
            SuspendLayout();
            // 
            // barraFerramentas
            // 
            barraFerramentas.ImageScalingSize = new Size(20, 20);
            barraFerramentas.Items.AddRange(new ToolStripItem[] { toolStripBtnNovo, toolStripSeparator1, toolStripBtnSalvar, toolStripSeparator2, toolStripBtnListar, toolStripSeparator3, toolStripBtnApagar });
            barraFerramentas.Location = new Point(0, 0);
            barraFerramentas.Name = "barraFerramentas";
            barraFerramentas.Size = new Size(691, 71);
            barraFerramentas.TabIndex = 0;
            barraFerramentas.Text = "toolStrip1";
            // 
            // toolStripBtnNovo
            // 
            toolStripBtnNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnNovo.Image = Properties.Resources._new;
            toolStripBtnNovo.ImageScaling = ToolStripItemImageScaling.None;
            toolStripBtnNovo.ImageTransparentColor = Color.Magenta;
            toolStripBtnNovo.Name = "toolStripBtnNovo";
            toolStripBtnNovo.Size = new Size(68, 68);
            toolStripBtnNovo.Text = "Novo";
            toolStripBtnNovo.Click += toolStripBtnNovo_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 71);
            // 
            // toolStripBtnSalvar
            // 
            toolStripBtnSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnSalvar.Image = Properties.Resources.save;
            toolStripBtnSalvar.ImageScaling = ToolStripItemImageScaling.None;
            toolStripBtnSalvar.ImageTransparentColor = Color.Magenta;
            toolStripBtnSalvar.Name = "toolStripBtnSalvar";
            toolStripBtnSalvar.Size = new Size(68, 68);
            toolStripBtnSalvar.Text = "Salvar";
            toolStripBtnSalvar.Click += toolStripBtnSalvar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 71);
            // 
            // toolStripBtnListar
            // 
            toolStripBtnListar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnListar.Image = Properties.Resources.list;
            toolStripBtnListar.ImageScaling = ToolStripItemImageScaling.None;
            toolStripBtnListar.ImageTransparentColor = Color.Magenta;
            toolStripBtnListar.Name = "toolStripBtnListar";
            toolStripBtnListar.Size = new Size(68, 68);
            toolStripBtnListar.Text = "Listar";
            toolStripBtnListar.Click += toolStripBtnListar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 71);
            // 
            // toolStripBtnApagar
            // 
            toolStripBtnApagar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnApagar.Image = Properties.Resources.delete;
            toolStripBtnApagar.ImageScaling = ToolStripItemImageScaling.None;
            toolStripBtnApagar.ImageTransparentColor = Color.Magenta;
            toolStripBtnApagar.Name = "toolStripBtnApagar";
            toolStripBtnApagar.Size = new Size(68, 68);
            toolStripBtnApagar.Text = "Apagar";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblNome.Location = new Point(60, 107);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(79, 26);
            LblNome.TabIndex = 1;
            LblNome.Text = "Nome:";
            // 
            // LblEndereco
            // 
            LblEndereco.AutoSize = true;
            LblEndereco.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblEndereco.Location = new Point(23, 160);
            LblEndereco.Name = "LblEndereco";
            LblEndereco.Size = new Size(116, 26);
            LblEndereco.TabIndex = 2;
            LblEndereco.Text = "Endereço:";
            // 
            // LblNumero
            // 
            LblNumero.AutoSize = true;
            LblNumero.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblNumero.Location = new Point(39, 213);
            LblNumero.Name = "LblNumero";
            LblNumero.Size = new Size(100, 26);
            LblNumero.TabIndex = 3;
            LblNumero.Text = "Número:";
            // 
            // LblCep
            // 
            LblCep.AutoSize = true;
            LblCep.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblCep.Location = new Point(79, 276);
            LblCep.Name = "LblCep";
            LblCep.Size = new Size(60, 26);
            LblCep.TabIndex = 4;
            LblCep.Text = "Cep:";
            // 
            // TxtNome
            // 
            TxtNome.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNome.Location = new Point(161, 100);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(471, 34);
            TxtNome.TabIndex = 5;
            // 
            // TxtEndereco
            // 
            TxtEndereco.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEndereco.Location = new Point(161, 152);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(471, 34);
            TxtEndereco.TabIndex = 6;
            // 
            // TxtNumero
            // 
            TxtNumero.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNumero.Location = new Point(161, 205);
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(188, 34);
            TxtNumero.TabIndex = 7;
            // 
            // TxtCep
            // 
            TxtCep.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCep.Location = new Point(161, 268);
            TxtCep.Name = "TxtCep";
            TxtCep.Size = new Size(188, 34);
            TxtCep.TabIndex = 8;
            // 
            // FrmCadCondominio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 335);
            Controls.Add(TxtCep);
            Controls.Add(TxtNumero);
            Controls.Add(TxtEndereco);
            Controls.Add(TxtNome);
            Controls.Add(LblCep);
            Controls.Add(LblNumero);
            Controls.Add(LblEndereco);
            Controls.Add(LblNome);
            Controls.Add(barraFerramentas);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadCondominio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Condomínios";
            barraFerramentas.ResumeLayout(false);
            barraFerramentas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip barraFerramentas;
        private ToolStripButton toolStripBtnNovo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripBtnSalvar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripBtnListar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripBtnApagar;
        private Label LblNome;
        private Label LblEndereco;
        private Label LblNumero;
        private Label LblCep;
        private TextBox TxtNome;
        private TextBox TxtEndereco;
        private TextBox TxtNumero;
        private TextBox TxtCep;
    }
}