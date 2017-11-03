using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesApp.Data;
using SalesApp.Models;

namespace SalesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetLists();
        }

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

        private void refreshSalesButton_Click(object sender, EventArgs e)
        {
            GetSales();
        }

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

        private void salesTargetButton_Click(object sender, EventArgs e)
        {
            var personId = (int)peopleComboBox.SelectedValue;

            using (var context = new SalesContext())
            {
                var person = context.People.SingleOrDefault(p => p.Id == personId);

                if (person != null)
                {
                    MessageBox.Show(string.Format("{0} has a sales target of {1:C}", person.FullName, person.SalesTarget));
                }
            }
        }

        private void peopleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void regionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void salesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                var salesId = (int)salesDataGridView.Rows[e.RowIndex].Cells[0].Value;
                var amount = (decimal)salesDataGridView.Rows[e.RowIndex].Cells[1].Value;

                using (var context = new SalesContext())
                {
                    var sale = context.Sales.SingleOrDefault(p => p.Id == salesId);

                    if (sale != null)
                    {
                        sale.Amount = amount;
                        var result = context.SaveChanges();
                        MessageBox.Show(string.Format("{0} has been updated", result));
                        GetSales();
                    }
                }

            }
        }

        private void salesDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this sale?", "Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            var salesId = (int)e.Row.Cells[0].Value;

            using (var context = new SalesContext())
            {
                var sale = context.Sales.SingleOrDefault(p => p.Id == salesId);

                if (sale != null)
                {
                    context.Sales.Remove(sale);
                    var result = context.SaveChanges();

                    MessageBox.Show(string.Format("{0} has been deleted!", result));
                }
            }

        }

        private void newSaleButton_Click_1(object sender, EventArgs e)
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
                MessageBox.Show(string.Format("{0} sales created!", result));
                GetSales();
            }
        }
    }
}
