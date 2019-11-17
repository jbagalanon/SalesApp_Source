#region Using

using SalesApp.Data;
using SalesApp.Models;

using System;
using System.Linq;
using System.Windows.Forms;

#endregion

namespace SalesApp
{
    public partial class SalesForm : Form
    {

        #region Constructor

        public SalesForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Load

        private void SalesForm_Load(object sender, EventArgs e)
        {
            GetLists();
        }

        #endregion


        #region DeleteSale

        /// <summary>
        /// Delete an existing Sale.
        /// </summary>
        /// <param name="row">
        /// The row of the Sale to delete.
        /// </param>
        private void DeleteSale(DataGridViewRow row)
        {
            var salesId = (int)row.Cells[0].Value;

            using (var context = new SalesContext())
            {
                var sale = context.Sales.SingleOrDefault(p => p.Id == salesId);

                if (sale != null)
                {
                    context.Sales.Remove(sale);
                    var result = context.SaveChanges();

                    MessageBox.Show(string.Format("{0} sales deleted.", result));
                }
            }
        }

        #endregion

        #region EditSale

        /// <summary>
        /// Edit an existing Sale.
        /// </summary>
        /// <param name="rowIndex">The row of the Sale to edit.</param>
        private void EditSale(int rowIndex)
        {
            var salesId = (int)salesDataGridView.Rows[rowIndex].Cells[0].Value;
            var amount = (decimal)salesDataGridView.Rows[rowIndex].Cells[1].Value;

            using (var context = new SalesContext())
            {
                var sale = context.Sales.SingleOrDefault(p => p.Id == salesId);

                if (sale != null)
                {
                    sale.Amount = amount;
                    var result = context.SaveChanges();

                    MessageBox.Show(string.Format("{0} sales updated.", result));
                    GetSales();
                }
            }
        }

        #endregion

        #region GetLists

        /// <summary>
        /// Get the Sales People and Sales Regions lists.
        /// </summary>
        private void GetLists()
        {
            using (var context = new SalesContext())
            {
                salesPersonBindingSource.DataSource = context.People
                    .Where(e => e.Active)
                    .OrderBy(e => e.FirstName)
                    .ThenBy(e => e.LastName)
                    .ToList();

                salesRegionBindingSource.DataSource = context.Regions
                    .Where(e => e.Active)
                    .OrderBy(e => e.Name)
                    .ToList();
            }
        }

        #endregion

        #region GetSales

        /// <summary>
        /// Get the list of Sales based on the selected Sales Person and Sales Region.
        /// </summary>
        private void GetSales()
        {
            var personId = (int)peopleComboBox.SelectedValue;
            var regionId = (int)regionComboBox.SelectedValue;

            using (var context = new SalesContext())
            {
                saleBindingSource.DataSource = context.Sales
                    .Where(s => s.PersonId == personId &&
                                s.RegionId == regionId)
                    .OrderBy(s => s.Date)
                    .ToList();
            }
        }

        #endregion

        #region GetSalesTarget

        /// <summary>
        /// Display the Sales Target for a single Sales Person.
        /// </summary>
        private void GetSalesTarget()
        {
            var personId = (int)peopleComboBox.SelectedValue;

            using (var context = new SalesContext())
            {
                var person = context.People.SingleOrDefault(p => p.Id == personId);

                if (person != null)
                {
                    MessageBox.Show(string.Format("{0} has a sales target of {1:C}",
                        person.FullName, person.SalesTarget));
                }
            }
        }

        #endregion

        #region NewSale

        /// <summary>
        /// Create a new Sale.
        /// </summary>
        private void NewSale()
        {
            var personId = (int)peopleComboBox.SelectedValue;
            var regionId = (int)regionComboBox.SelectedValue;

            var sale = new Sale
            {
                Amount = newAmountNumericUpDown.Value,
                Date = newDateDateTimePicker.Value,
                PersonId = personId,
                RegionId = regionId
            };

            using (var context = new SalesContext())
            {
                context.Sales.Add(sale);
                var result = context.SaveChanges();

                MessageBox.Show(string.Format("{0} sales created.", result));
                GetSales();
            }
        }

        #endregion


        #region newSaleButton Click

        private void newSaleButton_Click(object sender, EventArgs e)
        {
            NewSale();
        }

        #endregion

        #region refreshSalesButton Click

        private void refreshSalesButton_Click(object sender, EventArgs e)
        {
            GetSales();
        }

        #endregion

        #region salesDataGridView CellEndEdit

        private void salesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                EditSale(e.RowIndex);
            }
        }

        #endregion

        #region salesDataGridView UserDeletingRow

        private void salesDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show(@"Are you really sure you want to deleted this sale?", @"Delete",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            DeleteSale(e.Row);
        }

        #endregion

        #region salesTargetButton Click

        private void salesTargetButton_Click(object sender, EventArgs e)
        {
            GetSalesTarget();
        }

        #endregion

    }
}
