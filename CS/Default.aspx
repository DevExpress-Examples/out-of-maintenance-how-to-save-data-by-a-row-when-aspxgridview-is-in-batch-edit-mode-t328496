<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.2, Version=15.2.20.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="Scripts.js">
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxHiddenField runat="server" ID="RowValuesHf" ClientInstanceName="rowValuesHf"></dx:ASPxHiddenField>
            <dx:ASPxGridView runat="server" ID="Grid" DataSourceID="AccessDataSource1" ClientInstanceName="grid" AutoGenerateColumns="False"
                KeyFieldName="CustomerID" OnCustomCallback="Grid_CustomCallback"   >
                <ClientSideEvents BatchEditStartEditing="OnBatchEditStartEditing" BatchEditEndEditing="OnBatchEditEndEditing" />
                <Settings ShowStatusBar="Hidden" />
                <SettingsEditing>
                    <BatchEditSettings ShowConfirmOnLosingChanges="false" />
                </SettingsEditing>
                <Columns>
                    <dx:GridViewDataColumn FieldName="CommandColumn" UnboundType="String">
                        <DataItemTemplate>
                            <dx:ASPxButton runat="server" ID="UpdateBtn" AutoPostBack="false" OnInit="UpdateBtn_Init" RenderMode="Link"
                                Text="Update" ClientEnabled="false">
                                <ClientSideEvents Click="OnUpdateButton_Click" />
                            </dx:ASPxButton>
                            <dx:ASPxButton runat="server" ID="CancelBtn" AutoPostBack="false" OnInit="CancelBtn_Init" RenderMode="Link"
                                Text="Cancel" ClientEnabled="false">
                                <ClientSideEvents Click="OnCancelButton_Click" />
                            </dx:ASPxButton>
                        </DataItemTemplate>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataTextColumn FieldName="CustomerID" ReadOnly="True" VisibleIndex="11">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="CompanyName" VisibleIndex="1">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ContactName" VisibleIndex="2">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ContactTitle" VisibleIndex="3">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Address" VisibleIndex="4">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="City" VisibleIndex="5">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="PostalCode" VisibleIndex="6">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Country" VisibleIndex="7">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Phone" VisibleIndex="8">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Fax" VisibleIndex="9">
                    </dx:GridViewDataTextColumn>
                </Columns>
                <SettingsEditing Mode="Batch"></SettingsEditing>
                <Styles AdaptiveDetailButtonWidth="22"></Styles>
            </dx:ASPxGridView>
             <asp:AccessDataSource ID="AccessDataSource1" DataFile="~/App_Data/nwind.mdb" SelectCommand="SELECT * FROM [Customers]"
                runat="server" UpdateCommand="UPDATE Customers SET CompanyName=@CompanyName, ContactName=@ContactName, ContactTitle=@ContactTitle, Address=@Address, City=@City, PostalCode=@PostalCode, Country=@Country, Phone=@Phone, Fax=@Fax WHERE CustomerID=@CustomerID">
                <UpdateParameters>
                     <asp:Parameter Name="CustomerID" />
                    <asp:Parameter Name="CompanyName" />
                    <asp:Parameter Name="ContactName" />
                    <asp:Parameter Name="ContactTitle" />
                    <asp:Parameter Name="Address" />
                    <asp:Parameter Name="City" />
                    <asp:Parameter Name="PostalCode" />
                    <asp:Parameter Name="Country" />
                    <asp:Parameter Name="Phone" />
                    <asp:Parameter Name="Fax" />
                </UpdateParameters>
            </asp:AccessDataSource>
        </div>
    </form>
</body>
</html>
