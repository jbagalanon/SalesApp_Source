#region Using

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace SalesApp.Models
{
    /// <summary>
    /// The base model that contains all the core data for all other models.
    /// </summary>
    abstract class BaseModel
    {

        #region Id

        /// <summary>The unique database Id of the model.</summary>
        [Key]
        [Required]
        public int Id { get; set; }

        #endregion

        #region CreatedBy

        /// <summary>The user who created the model.</summary>
        [Required]
        [StringLength(100)]
        public string CreatedBy { get; set; }

        #endregion

        #region CreatedDate

        /// <summary>The date the model was created.</summary>
        [Required]
        public DateTime CreatedDate { get; set; }

        #endregion

        #region UpdatedBy

        /// <summary>The user who last updated the model.</summary>
        [Required]
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        #endregion

        #region UpdatedDate

        /// <summary>The date the model was last updated.</summary>
        [Required]
        public DateTime UpdatedDate { get; set; }

        #endregion

    }
}
