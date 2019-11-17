#region Using

using SalesApp.Interfaces;
using System.ComponentModel.DataAnnotations;

#endregion

namespace SalesApp.Models
{
    class SalesRegion : BaseModel, IActive
    {

        #region Active

        /// <summary>Flag indicating the sales region is active or inactive.</summary>
        [Required]
        public bool Active { get; set; }

        #endregion

        #region Code

        /// <summary>The unique code of the sales region.</summary>
        [Required]
        [StringLength(3)]
        public string Code { get; set; }

        #endregion

        #region Name

        /// <summary>The name of the sales region.</summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        #endregion

        #region People

        /// <summary>The sales people in this sales region.</summary>
        public ObservableListSource<SalesPerson> People { get; set; }

        #endregion

        #region Sales

        /// <summary>The sales made in this sales region.</summary>
        public ObservableListSource<Sale> Sales { get; set; }

        #endregion

        #region SalesTarget

        /// <summary>The dollar sales target of the sales region.</summary>
        [Required]
        [Range(0, double.MaxValue)]
        public decimal SalesTarget { get; set; }

        #endregion

    }
}
