using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPicashNetCore.Models
{
    public class Collection
    {
        public string CollectionId { get; set; }

        [Display(Prompt = "Fecha Cobranza", Name = "Fecha Cobranza")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CollectionDate { get; set; }

        public decimal TotalAmountCollection { get; set; }

        public Collection()
        {
        }
    }
}
