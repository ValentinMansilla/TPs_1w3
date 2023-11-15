using Entidades;
using FarmaciaPantallas.Back;


namespace RayApp
{
    public partial class form : Form
    {
        HelperDB helper = new HelperDB();
        public form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTipo.DataSource = helper.TraerTipos();
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //dgvTipo.Rows.Clear();
            List<Parametro> lParametros = new List<Parametro>();
            lParametros.Add(new Parametro("@tipo", cboTipo.SelectedIndex + 1));
            dgvTipo.DataSource = helper.Consultar("SP_facturscion_suministro", lParametros);

        }
    }
}