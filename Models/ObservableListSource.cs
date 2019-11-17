#region Using

using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;

#endregion

namespace SalesApp.Models
{
    /// <summary>
    /// A list that can be used for data binding on Windows Forms.
    /// For web applications use ICollection instead.
    /// </summary>
    /// <typeparam name="T">A model that derives from BaseModel.</typeparam>
    class ObservableListSource<T> : ObservableCollection<T>, IListSource where T : BaseModel
    {
        private IBindingList _bindingList;

        bool IListSource.ContainsListCollection { get { return false; } }

        IList IListSource.GetList()
        {
            return _bindingList ?? (_bindingList = this.ToBindingList());
        }
    }
}
