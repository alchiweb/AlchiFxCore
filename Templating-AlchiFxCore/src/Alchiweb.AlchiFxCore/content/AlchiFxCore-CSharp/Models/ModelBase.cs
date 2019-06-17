using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.WebApplication1.Models
{
    public abstract class ModelBase
    {
        [NotMapped]
        public string DisplayValue => ToString();
    }
}
