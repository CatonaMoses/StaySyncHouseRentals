Public Class FormTenants
    Private Sub TenantsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TenantsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TENANTS_REANTALS_BACKUPDataSet)

    End Sub

    Private Sub FormTenants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet.Tenants' table. You can move, or remove it, as needed.
        Me.TenantsTableAdapter.Fill(Me._TENANTS_REANTALS_BACKUPDataSet.Tenants)
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet.Tenants' table. You can move, or remove it, as needed.
        Me.TenantsTableAdapter.Fill(Me._TENANTS_REANTALS_BACKUPDataSet.Tenants)

    End Sub

    Private Sub IconBtnAdd_Click(sender As Object, e As EventArgs) Handles IconBtnAdd.Click
        TenantsBindingSource.AddNew()
    End Sub

    Private Sub IconButton1save_Click(sender As Object, e As EventArgs) Handles IconButton1save.Click

        Try
            TenantsBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(_TENANTS_REANTALS_BACKUPDataSet)
            MsgBox("Data saved")
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub IconButtonDelete_Click(sender As Object, e As EventArgs) Handles IconButtonDelete.Click
        TenantsBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(_TENANTS_REANTALS_BACKUPDataSet)
        MsgBox("record deleted succefully")
    End Sub

    Private Sub TenantsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles TenantsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TenantsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TENANTS_REANTALS_BACKUPDataSet)

    End Sub


End Class