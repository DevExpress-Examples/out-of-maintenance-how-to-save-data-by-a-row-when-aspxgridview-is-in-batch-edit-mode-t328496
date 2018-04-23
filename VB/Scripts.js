var currentRow;
function OnBatchEditStartEditing(s, e) {
    currentRow = e.visibleIndex;
    if (e.focusedColumn.fieldName == "CommandColumn")
        e.cancel = true;
    else {
        var index = e.visibleIndex;
        SetButtonsEnabled(index, true);
    }
}

function OnCancelButton_Click(s, e) {
    grid.batchEditApi.ResetChanges(currentRow);
    s.SetEnabled(false);
    var updateBtn = eval("updateBtn_" + s.cpIndex);
    updateBtn.SetEnabled(false);

}

function OnUpdateButton_Click(s, e) {
    grid.PerformCallback();
}

function OnBatchEditEndEditing(s, e) {
    var valies = [];
    valies[0] = e.rowValues[(s.GetColumnByField("CustomerID").index)].value;
    valies[1] = e.rowValues[(s.GetColumnByField("CompanyName").index)].value;
    valies[2] = e.rowValues[(s.GetColumnByField("ContactName").index)].value;
    valies[3] = e.rowValues[(s.GetColumnByField("ContactTitle").index)].value;
    valies[4] = e.rowValues[(s.GetColumnByField("Address").index)].value;
    valies[5] = e.rowValues[(s.GetColumnByField("City").index)].value;
    valies[6] = e.rowValues[(s.GetColumnByField("PostalCode").index)].value;
    valies[7] = e.rowValues[(s.GetColumnByField("Country").index)].value;
    valies[8] = e.rowValues[(s.GetColumnByField("Phone").index)].value;
    valies[9] = e.rowValues[(s.GetColumnByField("Fax").index)].value;
    rowValuesHf.Set("Values", valies);
    setTimeout(function (param) {
        if (s.batchEditApi.HasChanges(currentRow))
            SetButtonsEnabled(currentRow, true);
        else
            SetButtonsEnabled(currentRow, false);
    }, 0);
}

function SetButtonsEnabled(index, state) {
    var updateBtn = eval("updateBtn_" + index);
    var cancelBtn = eval("cancelBtn_" + index);
    updateBtn.SetEnabled(state);
    cancelBtn.SetEnabled(state);
}
