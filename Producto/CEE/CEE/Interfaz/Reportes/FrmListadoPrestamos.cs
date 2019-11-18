﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEE.Interfaz.Reportes
{
    public partial class FrmListadoPrestamos : Form
    {
        // EquipoService oEquipoService;
        public FrmListadoPrestamos()
        {
            InitializeComponent();

            ///this.WindowState = FormWindowState.Maximized;

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.CenterToScreen();
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmListadoPrestamos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetListado.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSetListado.DataTable1);
            cargarCombos();
            setTextBoxLimits();


            this.reportViewer1.RefreshReport();
        }

        /// <summary>
        /// Levanta los datos necesarios atraves de servicios para cargar los combos de la interfaz
        /// </summary>
        private void cargarCombos()
        {
            /*
            IList<TipoEquipoDTO> tiposEquipos = new TipoEquipoService().GetTipoEquipoByFilters(new Dictionary<string, object>());
            List<string> content = new List<string>();

            content.Add("Seleccionar");
            foreach (TipoEquipoDTO tipoEquipo in tiposEquipos)
                content.Add(tipoEquipo.NombreTipoEquipo);

            comboBoxTipoEquipo.DataSource = content;

            // ######################################
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("Ambito", "Equipo");
            IList<EstadoDTO> estados = new EstadoService().GetEstadoByFilters(parametros);
            List<string> contentEstados = new List<string>();

            contentEstados.Add("Seleccionar");
            foreach (EstadoDTO estado in estados)
                contentEstados.Add(estado.NombreEstado);

            comboBoxEstado.DataSource = contentEstados;
            */
        }

        /// <summary>
        /// Setea el largo maximo para los campos textBox iguales a los seteados en la BD
        /// </summary>
        private void setTextBoxLimits()
        {
            /*
            textBoxNombre.MaxLength = 20;
            textBoxCodigo.MaxLength = 20;
            */
        }

        // ########################################################################
        // Eventos de los botones
        // ########################################################################
    }
}
