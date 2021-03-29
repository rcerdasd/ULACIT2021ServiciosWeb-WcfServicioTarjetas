using System;
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

        protected void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (ddlOpcion.SelectedItem.Value.Equals("1"))
            {
                using (ServiceReference1.TarjetaClient cliente = new ServiceReference1.TarjetaClient())
                {
                    lblResultado.Text = String.Concat("El emisor de la tarjeta es ",cliente.ObtenerEmisorTarjeta(txtCardNum.Text.Trim()));
                    lblResultado.Visible = true;
                }
            }
            else if (ddlOpcion.SelectedItem.Value.Equals("2"))
            {                
                lblInfoCard.Visible = true;
                using (ServiceReference1.TarjetaClient cliente = new ServiceReference1.TarjetaClient())
                { 
                    lblCod.Text = cliente.ObtenerInformacionTarjeta(txtCardNum.Text.Trim()).TAR_CODIGO.ToString();
                    lblCod.Visible = true;
                }

                using (ServiceReference1.TarjetaClient cliente = new ServiceReference1.TarjetaClient())
                {
                    lblNum.Text = cliente.ObtenerInformacionTarjeta(txtCardNum.Text.Trim()).TAR_NUMERO.ToString();
                    lblNum.Visible = true;
                }
                using (ServiceReference1.TarjetaClient cliente = new ServiceReference1.TarjetaClient())
                {
                    lblTipo.Text = cliente.ObtenerInformacionTarjeta(txtCardNum.Text.Trim()).TAR_TIPO.ToString();
                    lblTipo.Visible = true;
                }
                using (ServiceReference1.TarjetaClient cliente = new ServiceReference1.TarjetaClient())
                {
                    lblSaldo.Text = cliente.ObtenerInformacionTarjeta(txtCardNum.Text.Trim()).TAR_SALDO.ToString();
                    lblSaldo.Visible = true;
                }
                using (ServiceReference1.TarjetaClient cliente = new ServiceReference1.TarjetaClient())
                {
                    lblFechaEmi.Text = cliente.ObtenerInformacionTarjeta(txtCardNum.Text.Trim()).TAR_FECHA_EMISION.ToString();
                    lblFechaEmi.Visible = true;
                }
                using (ServiceReference1.TarjetaClient cliente = new ServiceReference1.TarjetaClient())
                {
                    lblFechaVe.Text = cliente.ObtenerInformacionTarjeta(txtCardNum.Text.Trim()).TAR_FECHA_VENCIMIENTO.ToString();
                    lblFechaVe.Visible = true;
                }
                using (ServiceReference1.TarjetaClient cliente = new ServiceReference1.TarjetaClient())
                {
                    lblEstado.Text = cliente.ObtenerInformacionTarjeta(txtCardNum.Text.Trim()).TAR_ESTADO.ToString();
                    lblEstado.Visible = true;
                }
                using (ServiceReference1.TarjetaClient cliente = new ServiceReference1.TarjetaClient())
                {
                    lblCodCliente.Text = cliente.ObtenerInformacionTarjeta(txtCardNum.Text.Trim()).TAR_CODIGO_CLIENTE.ToString();
                    lblCodCliente.Visible = true;
                }
                using (ServiceReference1.TarjetaClient cliente = new ServiceReference1.TarjetaClient())
                {
                    lblNombreClient.Text = cliente.ObtenerInformacionTarjeta(txtCardNum.Text.Trim()).TAR_NOMBRE_CLIENTE.ToString();
                    lblNombreClient.Visible = true;
                }
                using (ServiceReference1.TarjetaClient cliente = new ServiceReference1.TarjetaClient())
                {
                    lblEmisorTar.Text = cliente.ObtenerInformacionTarjeta(txtCardNum.Text.Trim()).EMISOR.EMI_DESCRIPCION.ToString();
                    lblEmisorTar.Visible = true;

                }
            }
            else if (ddlOpcion.SelectedItem.Value.Equals("3"))
            {
                using (ServiceReference1.TarjetaClient cliente = new ServiceReference1.TarjetaClient())
                {
                    lblResultado.Text = cliente.ValidarTarjeta(txtCardNum.Text.Trim());
                    lblResultado.Visible = true;
                }
            }
        }
    }
}