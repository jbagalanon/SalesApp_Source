#region Using

using SalesApp.Interfaces;
using System.ComponentModel.DataAnnotations;

#endregion

namespace SalesApp.Models
{
    class SalesPerson : BaseModel, IActive
    {

        #region Active

        /// <summary>Flag indicating the sales person is active or inactive.</summary>
        [Required]
        public bool Active { get; set; }

        #endregion

        #region FirstName

        /// <summary>The first name of the sales person.</summary>
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        #endregion

        #region FullName

        /// <summary>The full name (first and last name) of the sales person.</summary>
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName).Trim();
            }
        }

        #endregion

        #region LastName

        /// <summary>The last name of the sales person.</summary>
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        #endregion

        #region Region

        /// <summary>The sales region of the sales person.</summary>
        public virtual SalesRegion Region { get; set; }

        /// <summary>The database Id of the sales region of the sales person.</summary>
        [Required]
        public int RegionId { get; set; }

        #endregion

        #region Sales

        /// <summary>The sales made by the sales person.</summary>
        public virtual ObservableListSource<Sale> Sales { get; set; }

        #endregion

        #region SalesTarget

        /// <summary>The dollar sales target of the sales person.</summary>
        [Required]
        [Range(0, double.MaxValue)]
        public decimal SalesTarget { get; set; }

        #endregion

    }
}
