using DataFarmacia.Entidades;
using Newtonsoft.Json;
using PantallaFarmacia.HTTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaFarmacia
{
    public partial class FrmFactura : Form
    {
        private int aux;
        private Factura nuevo;
        int proxFactura = 0;
        public FrmFactura()
        {
            InitializeComponent();
            nuevo = new Factura();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            CargarComboSuministrosAsync();
            CargarComboEmpleadosAsync();
            CargarComboClientesAsync();
            CargarComboSucursalAsync();// Guille, llamada al metodo
            CargarNumeroFactura();
        }

        private async Task CargarNumeroFactura() //Guille, carga el numero de factura siguiente
        {
            string url = "https://localhost:7050/ObtenerProximaFactura";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            if (!string.IsNullOrEmpty(result))
            {
                proxFactura = JsonConvert.DeserializeObject<int>(result);
                lbl_facturanumero.Text = "Factura N° " + proxFactura.ToString();
            }
        }

        //-------METODOS QUE CARGAN LOS COMBOS-----------
        private async Task CargarComboSucursalAsync()
        {
            try
            {
                string url = "https://localhost:7050/ObtenerComboSucursal";
                var result = await ClientSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(result))
                {
                    var lstSucursal = JsonConvert.DeserializeObject<List<Sucursal>>(result);
                    cbo_sucursal.DataSource = lstSucursal;
                    cbo_sucursal.DisplayMember = "Descripcion";
                    cbo_sucursal.ValueMember = "Id";
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar clientes: {ex.Message}");
            }
        }

        private async Task CargarComboClientesAsync()
        {
            try
            {
                string url = "https://localhost:7050/ObtenerComboClientes";
                var result = await ClientSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(result))
                {
                    var lstClientes = JsonConvert.DeserializeObject<List<Cliente>>(result);
                    cbo_cliente.DataSource = lstClientes;
                    cbo_cliente.DisplayMember = "NombreCompleto";
                    cbo_cliente.ValueMember = "id";
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar clientes: {ex.Message}");
            }
        }

        private async Task CargarComboEmpleadosAsync()
        {
            try
            {
                string url = "https://localhost:7050/ObtenerComboSuministro";
                var result = await ClientSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(result))
                {
                    var lstSuministros = JsonConvert.DeserializeObject<List<Suministro>>(result);
                    cbo_suministros.DataSource = lstSuministros;
                    cbo_suministros.DisplayMember = "nombre";
                    cbo_suministros.ValueMember = "id";
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar suministros: {ex.Message}");
            }
        }

        private async Task CargarComboSuministrosAsync()
        {
            try
            {
                string url = "https://localhost:7050/ObtenerComboEmpleado";
                var result = await ClientSingleton.GetInstance().GetAsync(url);

                if (!string.IsNullOrEmpty(result))
                {
                    var lstEmpleados = JsonConvert.DeserializeObject<List<Empleado>>(result);
                    cbo_vendedor.DataSource = lstEmpleados;
                    cbo_vendedor.DisplayMember = "NombreCompleto";
                    cbo_vendedor.ValueMember = "legajo";
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar empleados: {ex.Message}");
            }
        }
        //-------FIN DE METODOS QUE CARGAN LOS COMBOS----


        private void btn_agregar_Click(object sender, EventArgs e) //AGREGAR DETALLES A LA FACTURA
        {
            int cantidad = Convert.ToInt32(nudCantidad.Value);
            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["colDesc"].Value.ToString().Equals(cbo_suministros.Text))
                {
                    MessageBox.Show("Suministro: " + cbo_suministros.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
            }
            if (cantidad > 0)
            {
                Suministro s = (Suministro)cbo_suministros.SelectedItem;
                double subtotal = s.Precio * double.Parse((nudCantidad.Value).ToString());
                dgvDetalles.Rows.Add(new object[] { s.Id, s.Nombre, s.CodigoDeBarras, s.Precio, nudCantidad.Value, subtotal });
                CalcularTotal();
            }
            else { MessageBox.Show("La cantidad debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void CalcularTotal() //Guille
        {
            double total = 0;
            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {
                double subtotal = Convert.ToDouble(fila.Cells["ColSubtotal"].Value);
                total += subtotal;
            }
            txtTotal.Text = total.ToString("C");
        }
        private void btn_cancelar_Click(object sender, EventArgs e) //SALIR DEL FORM
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private async void btn_aceptar_Click(object sender, EventArgs e) //CARGAR FACTURA A LA DB
        {
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un suministro!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            await GuardarFacturaAsync();
        }
        private async Task GuardarFacturaAsync() //Guille
        {
            //datos de la factura:
            nuevo.Numero = proxFactura;
            nuevo.Fecha = dtp_fecha.Value;
            Cliente c = new Cliente();
            c.ID = Convert.ToInt32(cbo_cliente.SelectedValue);
            nuevo.Cliente = c;
            Sucursal s = new Sucursal();
            s.Id = Convert.ToInt32(cbo_sucursal.SelectedValue);
            nuevo.Sucursal = s;
            Empleado e = new Empleado();
            e.Legajo = Convert.ToInt32(cbo_vendedor.SelectedValue);
            nuevo.Empleado = e;
            nuevo.Pagado = true;

            // Guardar detalles en la lista de detalles
            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {
                int id = Convert.ToInt32(fila.Cells["colId"].Value);
                int cantidad = Convert.ToInt32(fila.Cells["colCantiddad"].Value);
                Suministro suministro = new Suministro();
                suministro.Id = id;
                double precio = Convert.ToDouble(fila.Cells["colSubtotal"].Value);
                Detalle detalle = new Detalle(suministro, cantidad, precio);
                nuevo.AddDetalle(detalle);
            }


            string bodyContent = JsonConvert.SerializeObject(nuevo);
            string url = "https://localhost:7050/api/Factura/Postfactura";
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Factura registrada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // throw new NotImplementedException("El método aún no ha sido implementado");

        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDetalles.Columns["colQuitar"].Index)
            {
                if (e.RowIndex < dgvDetalles.Rows.Count)
                {
                    nuevo.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                    dgvDetalles.Rows.RemoveAt(e.RowIndex);
                    CalcularTotal();
                }
            }
        }
    }
}
