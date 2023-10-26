namespace SistemaCensoPET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void condominiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCondominio frm = new FrmCadCondominio();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}