﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ulatina.Electiva.WCFArticulos
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IArticulosPerdidos
    {
        [OperationContract]
        int IngresarArticuloPerdido(ArticuloPerdido elArticulo);

        [OperationContract]
        string GetData(int elValor);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }

    [DataContract]
    public class ArticuloPerdido
    {
        public DateTime FechaIngreso;
        public String UbicacionDondeSeEncontro;
        public DateTime FechaDeHallazgo;
        public MiColor color;
        public String Senas;
        public String Marca;
    }
    [DataContract]
    public enum MiColor
    {
        Verde = 1,
        Azul = 2,
        Negro = 3,
        Blanco = 4,
        Amarillo = 5
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
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
