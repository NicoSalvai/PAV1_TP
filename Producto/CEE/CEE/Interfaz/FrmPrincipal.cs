﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CEE.Negocio;
using CEE.Negocio.DTO;

namespace CEE.Interfaz
{
    public partial class FrmPrincipal : Form
    {
        UsuarioService oUsuarioService;
        MenuService oMenuService;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            oUsuarioService = new UsuarioService();
            oMenuService = new MenuService();

            checkLogin();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Salir de la aplicacion", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
        
        /// <summary>
        /// checkeo si el usuario esta logeado segun el servicio de usuarios
        /// y luego busco sus menus habilitados y procedo a habilitarlos
        /// </summary>
        private void checkLogin()
        {
            FrmLogin login = new FrmLogin(oUsuarioService);
            login.ShowDialog();

            if (oUsuarioService.IdUsuarioLogeado == 0)
                this.Dispose();
            
            HabilitarMenus();
        }

        /// <summary>
        /// Habilitar los menus segun los que tiene habilitados el usuario
        /// </summary>
        /// <param name="usuarioMenus"></param>
        private void HabilitarMenus()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("IdUsuario", oUsuarioService.IdUsuarioLogeado);
            IList<MenuDTO> usuarioMenus = oMenuService.GetMenuByFilters(parametros);

            foreach (ToolStripMenuItem submenu in menuStrip1.Items)
            {
                foreach (ToolStripMenuItem opcion in submenu.DropDownItems)
                {
                    foreach (MenuDTO menu in usuarioMenus)
                    {
                        if (menu.NombreMenu == opcion.Text)
                        {
                            opcion.Enabled = true;
                        }
                    }
                }
            }
        }

        private void Equipos_Click(object sender, EventArgs e)
        {
            new FrmEquipos().Show();
        }
    }
}











/*
        /// <summary>
        /// Carga automatica del menu strip segun los menus en la BD################################# NO ESTA EN USO
        /// </summary>
        /// <param name="usuarioMenus"></param>
        private void cargarMenu(IList<MenuDTO> usuarioMenus)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            IList<MenuDTO> allMenus = oMenuService.GetMenuByFilters(parametros);

            foreach (MenuDTO menu in allMenus)
            {
                if(menu.MenuPadre == "" || menu.MenuPadre == null)
                {
                    
                }
                else if (!menu.EsFinal)
                {
                    ToolStripMenuItem nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                    this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { nuevoToolStripMenuItem });
                    nuevoToolStripMenuItem.Name = menu.NombreMenu + "ToolStripMenuItem";
                    nuevoToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
                    nuevoToolStripMenuItem.Text = menu.NombreMenu;
                }
                else
                {
                    ToolStripMenuItem nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                    ToolStripMenuItem padreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                    foreach (ToolStripMenuItem submenu in menuStrip1.Items)
                    {
                        if (submenu.Text == menu.MenuPadre)
                            padreToolStripMenuItem = submenu;
                    }
                    padreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {nuevoToolStripMenuItem });
                    nuevoToolStripMenuItem.Name = menu.Aplicacion;
                    nuevoToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
                    nuevoToolStripMenuItem.Text = menu.NombreMenu;
                    nuevoToolStripMenuItem.Enabled = false;
                }
            }
        }
     */