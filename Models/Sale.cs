#region Using

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace SalesApp.Models
{
    class Sale : BaseModel
    {

        #region Amount

        /// <summary>The dollar amount of the sale.</summary>
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }

        #endregion

        #region Date

        /// <summary>The date the sale was made.</summary>
        [Required]
        public DateTime Date { get; set; }

        #endregion

        #region Person

        /// <summary>The sales person who made the sale.</summary>
        public virtual SalesPerson Person { get; set; }

        /// <summary>The database Id of the sales person who made the sale.</summary>
        [Required]
        public int PersonId { get; set; }

        #endregion

        #region Region

        /// <summary>The sales region where the sale was made.</summary>
        public virtual SalesRegion Region { get; set; }

        /// <summary>The database Id of the sales region where the sale was made.</summary>
        [Required]
        public int RegionId { get; set; }

        #endregion

    }
}
