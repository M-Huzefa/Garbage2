using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridView
{
    public partial class SearchResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            searchGrid.DataSource = Session["search"];
            searchGrid.DataBind();
        }

        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //Change the pageindex & update session & table
            searchGrid.PageIndex = e.NewPageIndex;
            Session["searchIndex"] = e.NewPageIndex;
            Session["searchPageSize"] = searchGrid.PageSize;


            UpdateTable();

        }

        protected void UpdateTable()
        {
            //Uses session list to bind table
            searchGrid.DataSource = Session["search"];
            searchGrid.DataBind();
        }
    }
}