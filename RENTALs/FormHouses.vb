Public Class FormHouses
    Private Sub HousesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.HousesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TENANTS_REANTALS_BACKUPDataSet)

    End Sub

    Private Sub FormHouses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet.Houses' table. You can move, or remove it, as needed.
        Me.HousesTableAdapter.Fill(Me._TENANTS_REANTALS_BACKUPDataSet.Houses)
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet.Houses' table. You can move, or remove it, as needed.
        Me.HousesTableAdapter.Fill(Me._TENANTS_REANTALS_BACKUPDataSet.Houses)

    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs)
        HousesBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Try
            HousesBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(_TENANTS_REANTALS_BACKUPDataSet)
            MsgBox("Saved")
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        HousesBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(_TENANTS_REANTALS_BACKUPDataSet)
        MsgBox("record deleted succefully")
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles IconBtnAdd.Click
        HousesBindingSource.AddNew()
    End Sub

    Private Sub IconButton1save_Click(sender As Object, e As EventArgs) Handles IconButton1save.Click
        Try
            HousesBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(_TENANTS_REANTALS_BACKUPDataSet)
            MsgBox("Saved")
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub IconButtonDelete_Click(sender As Object, e As EventArgs) Handles IconButtonDelete.Click
        HousesBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(_TENANTS_REANTALS_BACKUPDataSet)
        MsgBox("record deleted succefully")
    End Sub

    Private Sub HousesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles HousesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HousesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TENANTS_REANTALS_BACKUPDataSet)

    End Sub
End Class