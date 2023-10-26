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
            barraFerramentas.SuspendLayout();
            SuspendLayout();
            // 
            // barraFerramentas
            // 
            barraFerramentas.ImageScalingSize = new Size(20, 20);
            barraFerramentas.Items.AddRange(new ToolStripItem[] { toolStripBtnNovo, toolStripSeparator1, toolStripBtnSalvar, toolStripSeparator2, toolStripBtnListar, toolStripSeparator3, toolStripBtnApagar });
            barraFerramentas.Location = new Point(0, 0);
            barraFerramentas.Name = "barraFerramentas";
            barraFerramentas.Size = new Size(800, 71);
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
            // FrmCadCondominio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}