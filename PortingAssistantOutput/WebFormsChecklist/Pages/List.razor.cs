using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.AspNetCore.Components;

namespace WebFormsChecklist
{
    public partial class List : ComponentBase
    {
        const string ItemsStateName = "Items";
        public string PageTitle { get; set; }

        public List<TodoItem> TodoItems { get; set; }

        protected void AddItem(object sender, EventArgs e)
        {
            TodoItems.Add(new TodoItem{Id = Guid.NewGuid(), CompletedTime = null, Description = txtNewItem.Text});
            Session[ItemsStateName] = TodoItems;
            RefreshTable();
        }

        private void RefreshTable()
        {
            PageTitle = $"ToDo List ({TodoItems.Count} items)";
            var dataTable = new DataTable();
            dataTable.Columns.AddRange(new[]{new DataColumn("ID", typeof(Guid)), new DataColumn("Description", typeof(string)), new DataColumn("CompletedTime", typeof(string))});
            foreach (var item in TodoItems)
            {
                dataTable.Rows.Add(item.Id, item.Description, item.CompletedTime?.ToString("MM/dd/yy H:mm:ss") ?? "Incomplete");
            }

            var dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);
            dgTodoList.DataSource = dataSet;
            dgTodoList.DataBind();
            foreach (DataGridItem grdRw in dgTodoList.Items)
            {
                Button deleteButton = (Button)grdRw.Cells[3].Controls[0];
                deleteButton.ID = "btnDelete_" + grdRw.ItemIndex.ToString();
                if (grdRw.Cells[2].Text != "Incomplete")
                {
                    deleteButton.Enabled = false;
                    deleteButton.Visible = false;
                }
            }
        }

        protected void dgTodoList_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName == "Complete")
            {
                var id = Guid.Parse(e.Item.Cells[0].Text);
                var item = TodoItems.FirstOrDefault(i => i.Id == id);
                if (item != null)
                {
                    item.CompletedTime = DateTime.Now;
                    Session[ItemsStateName] = TodoItems;
                    RefreshTable();
                }
            }
        }

        protected override void OnInitialized()
        {
            // This code replaces the original handling
            // of the Load event
            TodoItems = Session[ItemsStateName] as List<TodoItem> ?? new List<TodoItem>();
            RefreshTable();
        }
    }
}