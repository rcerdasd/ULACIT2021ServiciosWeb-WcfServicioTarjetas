﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionTarjetas
{
    public partial class frmPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            using (ServicioTarjetas.EmisorClient cliente = new ServicioTarjetas.EmisorClient())
            {
                gdvEmisores.DataSource = cliente.ConsultarEmisores();
                gdvEmisores.DataBind();
            }
        }
    }
}