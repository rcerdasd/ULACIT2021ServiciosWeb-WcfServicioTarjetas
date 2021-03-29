using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServicioTarjetas.Models;

namespace WcfServicioTarjetas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITarjeta
    {

        [OperationContract]
        IEnumerable<TARJETA> ConsultarTarjetas();

        [OperationContract]
        string ObtenerEmisorTarjeta(string NumeroTarjeta);

        [OperationContract]
        TARJETA ObtenerInformacionTarjeta(string NumeroTarjeta);

        [OperationContract]
        string ValidarTarjeta(string NumeroTarjeta);
        

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeTypeT GetDataUsingDataContract(CompositeTypeT composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeTypeT
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
