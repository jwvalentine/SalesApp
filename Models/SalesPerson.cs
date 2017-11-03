using SalesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Models
{
    [Table("SalesPeople")]
    class SalesPerson : BaseModel, IActive
    {
        [Required]
        public bool Active { get; set; }

        [Required]
        [StringLength(100)]
        [Index("FullName", Order = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        [Index("FullName", Order = 1)]
        public string LastName { get; set; }

        public virtual SalesRegion Region { get; set; }

        [Required]
        public int RegionId { get; set; }

        public virtual ObservableListSource<Sale> Sales { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        [Column("Target")]
        public decimal SalesTarget { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName).Trim();
            }
        }

    }
}
