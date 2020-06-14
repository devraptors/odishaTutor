using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Entities
{
    public class ProductCategories : BaseEntity
    {
        public string Name { get; set; }

        public bool Categoriesflag { get; set; }
    }
}
