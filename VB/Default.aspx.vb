Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
    Protected Sub UpdateBtn_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As ASPxButton = TryCast(sender, ASPxButton)
        Dim container As GridViewDataItemTemplateContainer = TryCast(btn.NamingContainer, GridViewDataItemTemplateContainer)
        btn.ClientInstanceName = String.Format("updateBtn_{0}", container.VisibleIndex)
        btn.JSProperties("cpIndex") = container.VisibleIndex
    End Sub
    Protected Sub CancelBtn_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As ASPxButton = TryCast(sender, ASPxButton)
        Dim container As GridViewDataItemTemplateContainer = TryCast(btn.NamingContainer, GridViewDataItemTemplateContainer)
        btn.ClientInstanceName = String.Format("cancelBtn_{0}", container.VisibleIndex)
        btn.JSProperties("cpIndex") = container.VisibleIndex
    End Sub

    Protected Sub Grid_CustomCallback(ByVal sender As Object, ByVal e As ASPxGridViewCustomCallbackEventArgs)
        Throw New CallbackException()
        Dim values As Object = RowValuesHf.Get("Values")
        Dim rowValues() As String = Array.ConvertAll(DirectCast(values, Object()), Function(s) CStr(s))
        AccessDataSource1.UpdateParameters("CustomerID").DefaultValue = rowValues(0)
        AccessDataSource1.UpdateParameters("CompanyName").DefaultValue = rowValues(1)
        AccessDataSource1.UpdateParameters("ContactName").DefaultValue = rowValues(2)
        AccessDataSource1.UpdateParameters("ContactTitle").DefaultValue = rowValues(3)
        AccessDataSource1.UpdateParameters("Address").DefaultValue = rowValues(4)
        AccessDataSource1.UpdateParameters("City").DefaultValue = rowValues(5)
        AccessDataSource1.UpdateParameters("PostalCode").DefaultValue = rowValues(6)
        AccessDataSource1.UpdateParameters("Country").DefaultValue = rowValues(7)
        AccessDataSource1.UpdateParameters("Phone").DefaultValue = rowValues(8)
        AccessDataSource1.UpdateParameters("Fax").DefaultValue = rowValues(9)
        AccessDataSource1.Update()
        Grid.DataBind()
    End Sub

End Class