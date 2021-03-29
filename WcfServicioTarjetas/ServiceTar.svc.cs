using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServicioTarjetas.Models;

namespace WcfServicioTarjetas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceTar" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceTar.svc or ServiceTar.svc.cs at the Solution Explorer and start debugging.
    public class ServiceTar : ITarjeta
    {
        public IEnumerable<TARJETA> ConsultarTarjetas()
        {
            using (TARJETAS_ULACITEntities modelo = new TARJETAS_ULACITEntities())
                return modelo.TARJETA.ToList();
        }

        public string ObtenerEmisorTarjeta(string NumeroTarjeta)
        {
            using (TARJETAS_ULACITEntities modelo = new TARJETAS_ULACITEntities())
            {
                string tipoTarjeta = modelo.TARJETA.Single(t => t.TAR_NUMERO == NumeroTarjeta).EMISOR.EMI_DESCRIPCION;
                return tipoTarjeta;
            }
        }

        public TARJETA ObtenerInformacionTarjeta(string NumeroTarjeta)
        {
            using (TARJETAS_ULACITEntities modelo = new TARJETAS_ULACITEntities())
            {
                TARJETA tarjeta = modelo.TARJETA.Single(t => t.TAR_NUMERO == NumeroTarjeta);
                return tarjeta;
            }
                
        }

        public string ValidarTarjeta(string NumeroTarjeta)
        {
            using (TARJETAS_ULACITEntities modelo = new TARJETAS_ULACITEntities())
            {
                bool validarFecha = false;
                bool validarEstado = false;
                int comp = DateTime.Now.CompareTo(modelo.TARJETA.Single(t => t.TAR_NUMERO == NumeroTarjeta).TAR_FECHA_VENCIMIENTO);

                if (comp < 0)
                {
                    validarFecha = true;
                }
                if (modelo.TARJETA.Single(t => t.TAR_NUMERO == NumeroTarjeta).TAR_ESTADO.ToLower() == "a")
                {
                    validarEstado = true;
                }
                if (validarEstado == true && validarFecha == true)
                {
                    return "Tarjeta valida";
                }
                else
                {
                    return "Tarjeta invalida";
                }
            }
        }


        public void DoWork()
        {
        }

        public string GetData(int value)
        {
            throw new NotImplementedException();
        }

        public CompositeTypeT GetDataUsingDataContract(CompositeTypeT composite)
        {
            throw new NotImplementedException();
        }


    }
}
