using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfProductManager.Models;

namespace WcfProductManager
{
    [ServiceContract]
    public interface IProductManagerService
    {
        [OperationContract]
        void AddProduct(Product product);
        [OperationContract]
        Product[] GetAllAvaiableProducts();
    }
}
