namespace SistemaCensoPET
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuBarra = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            condominiToolStripMenuItem = new ToolStripMenuItem();
            torresToolStripMenuItem = new ToolStripMenuItem();
            apartamentosToolStripMenuItem = new ToolStripMenuItem();
            espéciesToolStripMenuItem = new ToolStripMenuItem();
            petsToolStripMenuItem = new ToolStripMenuItem();
            pesquisarToolStripMenuItem = new ToolStripMenuItem();
            porPetsToolStripMenuItem = new ToolStripMenuItem();
            porApartamentosToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            porPetsToolStripMenuItem1 = new ToolStripMenuItem();
            porApartamentosToolStripMenuItem1 = new ToolStripMenuItem();
            menuBarra.SuspendLayout();
            SuspendLayout();
            // 
            // menuBarra
            // 
            menuBarra.ImageScalingSize = new Size(20, 20);
            menuBarra.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, pesquisarToolStripMenuItem, relatóriosToolStripMenuItem });
            menuBarra.Location = new Point(0, 0);
            menuBarra.Name = "menuBarra";
            menuBarra.Size = new Size(800, 28);
            menuBarra.TabIndex = 1;
            menuBarra.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { condominiToolStripMenuItem, torresToolStripMenuItem, apartamentosToolStripMenuItem, espéciesToolStripMenuItem, petsToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(86, 24);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // condominiToolStripMenuItem
            // 
            condominiToolStripMenuItem.Name = "condominiToolStripMenuItem";
            condominiToolStripMenuItem.Size = new Size(224, 26);
            condominiToolStripMenuItem.Text = "Condominio";
            condominiToolStripMenuItem.Click += condominiToolStripMenuItem_Click;
            // 
            // torresToolStripMenuItem
            // 
            torresToolStripMenuItem.Name = "torresToolStripMenuItem";
            torresToolStripMenuItem.Size = new Size(224, 26);
            torresToolStripMenuItem.Text = "Torres";
            // 
            // apartamentosToolStripMenuItem
            // 
            apartamentosToolStripMenuItem.Name = "apartamentosToolStripMenuItem";
            apartamentosToolStripMenuItem.Size = new Size(224, 26);
            apartamentosToolStripMenuItem.Text = "Apartamentos";
            // 
            // espéciesToolStripMenuItem
            // 
            espéciesToolStripMenuItem.Name = "espéciesToolStripMenuItem";
            espéciesToolStripMenuItem.Size = new Size(224, 26);
            espéciesToolStripMenuItem.Text = "Espécies";
            // 
            // petsToolStripMenuItem
            // 
            petsToolStripMenuItem.Name = "petsToolStripMenuItem";
            petsToolStripMenuItem.Size = new Size(224, 26);
            petsToolStripMenuItem.Text = "Pets";
            // 
            // pesquisarToolStripMenuItem
            // 
            pesquisarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { porPetsToolStripMenuItem, porApartamentosToolStripMenuItem });
            pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            pesquisarToolStripMenuItem.Size = new Size(84, 24);
            pesquisarToolStripMenuItem.Text = "Pesquisar";
            // 
            // porPetsToolStripMenuItem
            // 
            porPetsToolStripMenuItem.Name = "porPetsToolStripMenuItem";
            porPetsToolStripMenuItem.Size = new Size(224, 26);
            porPetsToolStripMenuItem.Text = "Por Pets";
            // 
            // porApartamentosToolStripMenuItem
            // 
            porApartamentosToolStripMenuItem.Name = "porApartamentosToolStripMenuItem";
            porApartamentosToolStripMenuItem.Size = new Size(224, 26);
            porApartamentosToolStripMenuItem.Text = "Por Apartamentos";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { porPetsToolStripMenuItem1, porApartamentosToolStripMenuItem1 });
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(90, 24);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // porPetsToolStripMenuItem1
            // 
            porPetsToolStripMenuItem1.Name = "porPetsToolStripMenuItem1";
            porPetsToolStripMenuItem1.Size = new Size(224, 26);
            porPetsToolStripMenuItem1.Text = "Por Pets";
            // 
            // porApartamentosToolStripMenuItem1
            // 
            porApartamentosToolStripMenuItem1.Name = "porApartamentosToolStripMenuItem1";
            porApartamentosToolStripMenuItem1.Size = new Size(224, 26);
            porApartamentosToolStripMenuItem1.Text = "Por Apartamentos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuBarra);
            IsMdiContainer = true;
            MainMenuStrip = menuBarra;
            Name = "Form1";
            Text = "Sistema CensoPET";
            WindowState = FormWindowState.Maximized;
            menuBarra.ResumeLayout(false);
            menuBarra.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuBarra;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem condominiToolStripMenuItem;
        private ToolStripMenuItem torresToolStripMenuItem;
        private ToolStripMenuItem apartamentosToolStripMenuItem;
        private ToolStripMenuItem espéciesToolStripMenuItem;
        private ToolStripMenuItem petsToolStripMenuItem;
        private ToolStripMenuItem pesquisarToolStripMenuItem;
        private ToolStripMenuItem porPetsToolStripMenuItem;
        private ToolStripMenuItem porApartamentosToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem porPetsToolStripMenuItem1;
        private ToolStripMenuItem porApartamentosToolStripMenuItem1;
    }
}