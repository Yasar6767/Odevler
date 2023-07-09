using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        private MernisServiceAdapter mernisServiceAdapter;

        public NeroCustomerManager(MernisServiceAdapter mernisServiceAdapter)
        {
            this.mernisServiceAdapter = mernisServiceAdapter;
        }
    }
}

