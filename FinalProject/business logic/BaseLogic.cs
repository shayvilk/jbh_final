using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Logic
{
    public class BaseLogic : IDisposable
    {
        protected PeretzRentsEntities DB = new PeretzRentsEntities();

        public void Dispose()
        {
            DB.Dispose();
        }
    }
}