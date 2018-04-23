using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }
    protected void UpdateBtn_Init(object sender, EventArgs e) {
        ASPxButton btn = sender as ASPxButton;
        GridViewDataItemTemplateContainer container = btn.NamingContainer as GridViewDataItemTemplateContainer;
        btn.ClientInstanceName = String.Format("updateBtn_{0}", container.VisibleIndex);
        btn.JSProperties["cpIndex"] = container.VisibleIndex;
    }
    protected void CancelBtn_Init(object sender, EventArgs e) {
        ASPxButton btn = sender as ASPxButton;
        GridViewDataItemTemplateContainer container = btn.NamingContainer as GridViewDataItemTemplateContainer;
        btn.ClientInstanceName = String.Format("cancelBtn_{0}", container.VisibleIndex);
        btn.JSProperties["cpIndex"] = container.VisibleIndex;
    }

    protected void Grid_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e) {
        throw new CallbackException();
        object values = RowValuesHf.Get("Values");
        string[] rowValues = Array.ConvertAll((object[])values, s => (string)s);
        AccessDataSource1.UpdateParameters["CustomerID"].DefaultValue = rowValues[0];
        AccessDataSource1.UpdateParameters["CompanyName"].DefaultValue = rowValues[1];
        AccessDataSource1.UpdateParameters["ContactName"].DefaultValue = rowValues[2];
        AccessDataSource1.UpdateParameters["ContactTitle"].DefaultValue = rowValues[3];
        AccessDataSource1.UpdateParameters["Address"].DefaultValue = rowValues[4];
        AccessDataSource1.UpdateParameters["City"].DefaultValue = rowValues[5];
        AccessDataSource1.UpdateParameters["PostalCode"].DefaultValue = rowValues[6];
        AccessDataSource1.UpdateParameters["Country"].DefaultValue = rowValues[7];
        AccessDataSource1.UpdateParameters["Phone"].DefaultValue = rowValues[8];
        AccessDataSource1.UpdateParameters["Fax"].DefaultValue = rowValues[9];
        AccessDataSource1.Update();
        Grid.DataBind();
    }

}