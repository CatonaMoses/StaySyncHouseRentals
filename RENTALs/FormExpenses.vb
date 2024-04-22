Public Class FormExpenses
    Private Sub ExpensesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ExpensesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TENANTS_REANTALS_BACKUPDataSet)

    End Sub

    Private Sub FormExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet.Houses' table. You can move, or remove it, as needed.
        Me.HousesTableAdapter.Fill(Me._TENANTS_REANTALS_BACKUPDataSet.Houses)
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet.Expenses' table. You can move, or remove it, as needed.
        Me.ExpensesTableAdapter.Fill(Me._TENANTS_REANTALS_BACKUPDataSet.Expenses)
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet.Expenses' table. You can move, or remove it, as needed.
        Me.ExpensesTableAdapter.Fill(Me._TENANTS_REANTALS_BACKUPDataSet.Expenses)

    End Sub

    Private Sub IconBtnAdd_Click(sender As Object, e As EventArgs) Handles IconBtnAdd.Click
        ExpensesBindingSource.AddNew()
    End Sub

    Private Sub IconButton1save_Click(sender As Object, e As EventArgs) Handles IconButton1save.Click
        Try
            ExpensesBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(_TENANTS_REANTALS_BACKUPDataSet)
            MsgBox("Record saved succefully")
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub IconButtonDelete_Click(sender As Object, e As EventArgs) Handles IconButtonDelete.Click
        ExpensesBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(_TENANTS_REANTALS_BACKUPDataSet)
        MsgBox("Record removed succefully")
    End Sub

    Private Sub ExpensesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ExpensesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ExpensesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TENANTS_REANTALS_BACKUPDataSet)

    End Sub
End Class