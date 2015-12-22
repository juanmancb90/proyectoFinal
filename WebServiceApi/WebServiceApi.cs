﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BL;

namespace WebServiceApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class WebServiceApi : IWebServiceApi
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string GetHelloWorld(string name)
        {
            return string.Format("Hello World: {0}",name);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string GetDataBL()
        {
            VendedoresBL context = new VendedoresBL();
            var dataBL = context.test();
            return dataBL;
        }
    }
}
