using BackExamen.Models;
using Newtonsoft.Json;
using System.Net;
using System.Text.Json.Serialization;
using System.Linq;

namespace FrontEscritorio
{
    public partial class Form1 : Form
    {
        string url = "https://localhost:7109/examen";
        public Form1()
        {
            InitializeComponent();
            string[] opciones = { "Ventas", "Ventas por articulo", "Articulos mas Vendidos", "Catidad de productos existente" };
            comboBox1.Items.AddRange(opciones);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ventas();
            globales();

        }

        public async Task<string> GetApi(string api)
        {
            WebRequest onRequest = WebRequest.Create(api);
            WebResponse onResponse = await onRequest.GetResponseAsync();
            StreamReader sr = new StreamReader(onResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;

            if (index == 0)
            {
                ventas();
                dataGridView3.DataSource=null;
                label3.Text="Ventas Generales";
                label4.Text="";
            }
            else if (index == 1)
            {
                ventasXarticulo();
                dataGridView3.DataSource=null;
                label3.Text="Ventas Por Articulo";
                label4.Text="";

            }
            else if (index == 2)
            {
                masVendido();
                dataGridView3.DataSource=null;
                label3.Text="Articulos Mas Vedidos";
                label4.Text="";

            }
            else if (index == 3)
            {
                existencias();
                label3.Text="Existencias";

            }
            else
            {
                ventas();
                dataGridView3.DataSource=null;
                label4.Text="";

            }

        }

        private async void ventas()
        {
            string urlVentas = url+ "/mostrarVentas";

            string response = await GetApi(urlVentas);
            List<Ventas> list = JsonConvert.DeserializeObject<List<Ventas>>(response);
            var VentasList = list.Select(venta => new
            {
                venta.IDVentas,
                venta.CantidadVendida,
                venta.Fecha,
                venta.Producto.Titulo,
                venta.Producto.IDProductos,
                venta.Producto.Existencias,
                venta.Producto.Descripcion,
                venta.Producto.PrecioUnitario,
                Total = Convert.ToDouble(venta.Producto.PrecioUnitario) * Convert.ToDouble(venta.CantidadVendida),
            }).ToList();

            dataGridView1.DataSource = VentasList;
        }
        private async void ventasXarticulo()
        {
            string urlProductos = url+ "/mostrarProductos";

            string response = await GetApi(urlProductos);
            List<Productos> list = JsonConvert.DeserializeObject<List<Productos>>(response);
            list = list.OrderByDescending(producto => producto.TotalVendido).ToList();
            var ProductList = list.Select(producto => new
            {
                producto.Titulo,
                producto.PrecioUnitario,
                producto.TotalVendido
            }).ToList();



            double sumaTotalVendido = list.Select(producto => producto.TotalVendido).Sum();

            label2.Text="Las Ventas globales son de: "+sumaTotalVendido.ToString();

            dataGridView1.DataSource = ProductList;
        }
        private async void masVendido()
        {
            string urlProductos = url+ "/mostrarProductos";

            string response = await GetApi(urlProductos);
            List<Productos> list = JsonConvert.DeserializeObject<List<Productos>>(response);
            list = list.OrderByDescending(producto => producto.CantidadVendida).ToList();
            var ProductList = list.Select(producto => new
            {
                producto.Titulo,
                producto.CantidadVendida,

            }).ToList();

            dataGridView1.DataSource = ProductList;
        }
        private async void existencias()
        {
            string urlProductos = url+ "/mostrarProductos";

            string response = await GetApi(urlProductos);
            List<Productos> list = JsonConvert.DeserializeObject<List<Productos>>(response);
            list = list.OrderByDescending(producto => producto.Existencias).ToList();
            var ProductList = list.Select(producto => new
            {
                producto.Titulo,
                producto.Existencias,
            }).ToList();

            dataGridView1.DataSource = ProductList;

            var menorExistenciasA100 = list.Where(producto => producto.Existencias < 100)
                                .Select(producto => new
                                {
                                    producto.Titulo,
                                    producto.Existencias,
                                }).ToList();
            dataGridView3.DataSource = menorExistenciasA100;

            if (menorExistenciasA100 != null)
            {
                label4.Text="Articulos que estan por debajo de las 100 unidades";
                MessageBox.Show("Se ah mostrado una tabla con los articulos menores a las 100 unidades", "Favor de contactar con el proveedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private async void globales()
        {
            string urlProductos = url+ "/mostrarProductos";

            string response = await GetApi(urlProductos);
            List<Productos> list = JsonConvert.DeserializeObject<List<Productos>>(response);

            double sumaTotalVendido = list.Select(producto => producto.TotalVendido).Sum();

            label2.Text="Las Ventas globales son de: "+sumaTotalVendido.ToString()+"$ pesos";

        }
    }
}