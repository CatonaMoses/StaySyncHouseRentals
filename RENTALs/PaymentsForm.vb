Public Class PaymentsForm
    Private Sub PaymentsTblBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PaymentsTblBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PaymentsTblBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TENANTS_REANTALS_BACKUPDataSet1)

    End Sub

    Private Sub PaymentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet1.MonthsTBL' table. You can move, or remove it, as needed.
        Me.MonthsTBLTableAdapter.Fill(Me._TENANTS_REANTALS_BACKUPDataSet1.MonthsTBL)
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet1.Houses' table. You can move, or remove it, as needed.
        Me.HousesTableAdapter.Fill(Me._TENANTS_REANTALS_BACKUPDataSet1.Houses)
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet1.Tenants' table. You can move, or remove it, as needed.
        Me.TenantsTableAdapter.Fill(Me._TENANTS_REANTALS_BACKUPDataSet1.Tenants)
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet1.PaymentsTbl' table. You can move, or remove it, as needed.
        Me.PaymentsTblTableAdapter.Fill(Me._TENANTS_REANTALS_BACKUPDataSet1.PaymentsTbl)

    End Sub

    Private Sub IconBtnAdd_Click(sender As Object, e As EventArgs) Handles IconBtnAdd.Click
        PaymentsTblBindingSource.AddNew()
    End Sub

    Private Sub IconButtonSave_Click(sender As Object, e As EventArgs) Handles IconButtonSave.Click
        Try
            PaymentsTblBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(_TENANTS_REANTALS_BACKUPDataSet1)
            MsgBox("Data saved")
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub IconButtonDelete_Click(sender As Object, e As EventArgs) Handles IconButtonDelete.Click
        PaymentsTblBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(_TENANTS_REANTALS_BACKUPDataSet1)
        MsgBox("record deleted succefully")
    End Sub
End Class