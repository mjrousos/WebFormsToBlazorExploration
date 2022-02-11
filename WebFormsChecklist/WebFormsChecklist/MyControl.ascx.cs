using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsChecklist
{
    public partial class MyControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstList.Items.Clear();
            foreach (ListItem item in chkList.Items)
            {
                if (item.Selected)
                {
                    lstList.Items.Add(item.Value);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cellResult.Text = drpList.SelectedValue;
        }
    }
}