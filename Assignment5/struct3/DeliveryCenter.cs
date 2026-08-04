using Assignment5.struct2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.struct3
{
    #region Q5

    

    // internal struct DeliveryCenter
    //    {
    //        private Shipment[] shipments;
    //        private int count;
    //        public Shipment this[int index]
    //        {
    //            get
    //            {
    //                if (index >= 0 && index < count)
    //                {
    //                    return shipments[index];
    //                }
    //                return default;
    //            }
    //            set
    //            {
    //                if (index >= 0 && index < count)
    //                {
    //                    shipments[index] = value;
    //                }
    //            }
    //        }

    //        public Shipment this[string trackingCode]
    //        {
    //            get
    //            {
    //                for (int i = 0; i < count; i++)
    //                {
    //                    if (shipments[i].trackingcode == trackingCode)
    //                    {
    //                        return shipments[i];
    //                    }
    //                }
    //                return default;
    //            }
    //        }

    //        public bool AddShipment(Shipment shipment)
    //        {
    //            if (shipments == null)
    //            {
    //                shipments = new Shipment[10];
    //            }

    //            if (count < 10)
    //            {
    //                shipments[count] = shipment;
    //                count++;
    //                return true;
    //            }
    //            return false;
}
// }
//}

#endregion