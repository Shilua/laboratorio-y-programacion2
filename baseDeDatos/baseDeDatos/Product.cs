using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseDeDatos
{
    public class Product
    {
        #region Fields
        protected int productId;
        protected string name;
        protected int daysToManufacture;
        #endregion

        public int ProductId
        {
            get
            {
                return this.productId;
            }
        }
        public string Name
        {
            get { return this.name; }
        }
        public int DaysToManufacture
        {
            get
            {
                return this.daysToManufacture;
            }
        }

        public Product(string productNumber, int daysToManufacture)
        {
            this.name = productNumber;
            this.daysToManufacture = daysToManufacture;
        }


        public Product(int productId, string productNumber, int daysToManufacture)
            :this(productNumber,daysToManufacture)
        {
            this.productId = productId;
            
        }
        
    }
}
