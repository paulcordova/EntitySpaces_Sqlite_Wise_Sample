
using System;
using Wisej.Web;
using BusinessObjects;
using EntitySpaces;
using static Wisej.Web.Shape;
using Wisej.Web.Ext.ColumnFilter;
using System.Data.Entity.Core.Objects.DataClasses;
using EntitySpaces.Core;
using System.Reflection;
using EntitySpaces.DynamicQuery;
using EntitySpaces.Interfaces;
using System.Collections.ObjectModel;

namespace ES_Sqlite_Wisej
{
    public partial class Window1 : Form
    {
        private ColumnFilter SimpleColumnFilter = new ColumnFilter();
        private ColumnFilter WhereColumnFilter = new ColumnFilter();

        public Window1()
        {
            InitializeComponent();

            // 
            // SimpleColumnFilter
            // 
            this.SimpleColumnFilter.FilteredImageSource = "icon-search?color=#FF1700";
            this.SimpleColumnFilter.FilterPanelType = typeof(Wisej.Web.Ext.ColumnFilter.SimpleColumnFilterPanel);
            this.SimpleColumnFilter.ImageSource = "icon-search";

            this.WhereColumnFilter.FilteredImageSource = "table-row-editing?color=#FF1700";
            this.WhereColumnFilter.FilterPanelType = typeof(Wisej.Web.Ext.ColumnFilter.WhereColumnFilterPanel);
            this.WhereColumnFilter.ImageSource = "table-row-editing";

            SimpleColumnFilter.RowsFiltered += SimpleColumnFilter_RowsFiltered;
            WhereColumnFilter.RowsFiltered += WhereColumnFilter_RowsFiltered;
        }
             

        #region "Gui events"
        private void button1_Click(object sender, EventArgs e)
        {
            UnCheckFilter();
            label_TableSelected.Text = "Category";

            LoadAndBindData(dataGridView1, new CategoryCollection(), new Category());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UnCheckFilter();
            label_TableSelected.Text = "Customer";

            LoadAndBindData(dataGridView1, new CustomerCollection(), new Customer());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UnCheckFilter();
            label_TableSelected.Text = "Employee";

            LoadAndBindData(dataGridView1, new EmployeeCollection(), new Employee());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UnCheckFilter();
            label_TableSelected.Text = "Employee Territory ";

            LoadAndBindData(dataGridView1, new EmployeeTerritoryCollection(), new EmployeeTerritory());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UnCheckFilter();
            label_TableSelected.Text = "Order";

            LoadAndBindData(dataGridView1, new OrderCollection(), new Order());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UnCheckFilter();
            label_TableSelected.Text = "Order Detail";

            LoadAndBindData(dataGridView1, new OrderDetailCollection(), new OrderDetail());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UnCheckFilter();
            label_TableSelected.Text = "Product";

            LoadAndBindData(dataGridView1, new ProductCollection(), new Product());
        }

        private void button8_Click(object sender, EventArgs e)

        {
            UnCheckFilter();
            label_TableSelected.Text = "Region";

            LoadAndBindData(dataGridView1, new RegionCollection(), new Region());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UnCheckFilter();
            label_TableSelected.Text = "Shipper";

            LoadAndBindData(dataGridView1, new ShipperCollection(), new Shipper());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            UnCheckFilter();
            label_TableSelected.Text = "Supplier";

            LoadAndBindData(dataGridView1, new SupplierCollection(), new Supplier());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            UnCheckFilter();
            label_TableSelected.Text = "Territory";

            LoadAndBindData(dataGridView1, new TerritoryCollection(), new Territory());
        }

        private void pictureBox_WisejSite_Click(object sender, EventArgs e)
        {
            OpenUrlInNewTab("https://www.wisej.com");
        }

        private void pictureBox_EntiSpaceSite_Click(object sender, EventArgs e)
        {
            OpenUrlInNewTab("https://github.com/MikeGriffinReborn/EntitySpaces");
        }

        private void pictureBox_GitHubCodeSite_Click(object sender, EventArgs e)
        {
            // My code repo for this proyect
            OpenUrlInNewTab("https://github.com/paulcordova");
        }

        private void pictureBox_LinkedInProfile_Click(object sender, EventArgs e)
        {
            OpenUrlInNewTab("https://www.linkedin.com/in/paul-cordova-4b081411/");
        }


        private void checkBox_FilterGrid_CheckedChanged(object sender, EventArgs e)
        {
            ToggleColumnFilters((CheckBox)sender, dataGridView1, SimpleColumnFilter);
        }

        private void checkBox_FilterWhere_CheckedChanged(object sender, EventArgs e)
        {
            ToggleColumnFilters((CheckBox)sender, dataGridView1, WhereColumnFilter);
        }

        #endregion

        #region "Wisej controls manipulation"

        private void ToggleColumnFilters(CheckBox checkBox, DataGridView grid, ColumnFilter filter)
        {
            // Uncheck the other filter checkbox
            UncheckOtherFilter(checkBox);


            // Check if the CheckBox is checked
            if (checkBox.Checked)
            {
                // Add the ColumnFilter to each column in the grid
                foreach (DataGridViewColumn column in grid.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                    filter.SetShowFilter(column, true);
                }
            }
            else
            {
                // Remove the ColumnFilter from each column if the CheckBox is unchecked
                foreach (DataGridViewColumn column in grid.Columns)
                {
                    var columnFilterPanel = column.UserData?.FilterPanel as ColumnFilterPanel;
                    if (columnFilterPanel != null)
                    {
                        columnFilterPanel.Clear();
                    }
                }
               
            }
            
        }

        private void UncheckOtherFilter(CheckBox currentCheckBox)
        {
            if (currentCheckBox == checkBox_FilterGrid)
            {
                checkBox_FilterWhere.Checked = false;
            }
            else if (currentCheckBox == checkBox_FilterWhere)
            {
                checkBox_FilterGrid.Checked = false;
            }
        }

        #endregion


        #region "EntitySpaces data manipualation"
        private void LoadAndBindData<TCollection, TEntity>(DataGridView grid,
                                                         TCollection collection,
                                                         TEntity entity)
        where TCollection : esEntityCollectionBase, new()
        where TEntity : esEntity, new()
        {
            // Create columns based on the entity
            CreateColumnsGridFromEntity(grid, entity);

            // Measure execution time for loading data and binding it
            decimal seconds = MeasureExecutionTime(() =>
            {
                // Load database data through EntitySpaces collection
                collection.LoadAll();

                // Bind data to DataGridView
                grid.DataSource = collection;

                // Display record count
                ShowRecordCount(collection.Count);
            });

            // Display the elapsed time
            textBox_Time.Text = seconds.ToString("0.00"); // Format as decimal with two decimal places
        }

        public void CreateColumnsGridFromEntity(DataGridView grid, esEntity entity)
        {
            // Clear existing columns
            grid.Columns.Clear();

            // Check if the entity is not null
            if (entity != null)
            {
                // Get the metadata of the EntitySpace object columns
                var columnsMetadata = entity.es.Meta.Columns;

                // Iterate over the EntitySpace object properties
                foreach (esColumnMetadata column in columnsMetadata)
                {
                    // Create a new column for the property
                    var col = new DataGridViewTextBoxColumn
                    {
                        HeaderText = column.Name,
                        DataPropertyName = column.Name,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    };
                }
            }
        }

        #endregion

        #region "Utility" 

        private void UnCheckFilter()
        {
            if (checkBox_FilterGrid.Checked)
            {
                checkBox_FilterGrid.Checked = false;
            }

            if (checkBox_FilterWhere.Checked)
            {
                checkBox_FilterWhere.Checked = false; 
            }
        }

        private void WhereColumnFilter_RowsFiltered(object sender, ColumnFilter.RowsFilteredEventArg e)
        {
            // Display GridView record count
            ShowRecordCount(e.FilteredRowCount);
        }

        private void SimpleColumnFilter_RowsFiltered(object sender, ColumnFilter.RowsFilteredEventArg e)
        {
            // Display GridView record count
            ShowRecordCount(e.FilteredRowCount);
        }

        private void ShowRecordCount(int recordCount)
        {
            textBox_Records.Text = recordCount.ToString("N0");
        }

        private decimal MeasureExecutionTime(Action action)
        {
            // Record the start time
            DateTime startTime = DateTime.Now;

            // Execute the provided action
            action();

            // Calculate the elapsed time
            decimal seconds = (decimal)(DateTime.Now - startTime).TotalSeconds;

            return seconds;
        }

        private void OpenUrlInNewTab(string url)
        {
            // Open the URL in a new tab
            Application.Navigate(url, "_blank");
        }

        #endregion

 
    } //end class
} // end namespace
