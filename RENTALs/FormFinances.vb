Public Class FormFinances
    Private Sub FinancesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FinancesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FinancesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TENANTS_REANTALS_BACKUPDataSet)

    End Sub

    Private Sub FormFinances_Load(sender As Object, e As EventArgs)
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet.Finances' table. You can move, or remove it, as needed.
        Me.FinancesTableAdapter.Fill(Me._TENANTS_REANTALS_BACKUPDataSet.Finances)

    End Sub

    Private Sub IconBtnAdd_Click(sender As Object, e As EventArgs) Handles IconBtnAdd.Click
        FinancesBindingSource.AddNew()
    End Sub

    Private Sub IconButton1save_Click(sender As Object, e As EventArgs) Handles IconButton1save.Click
        Try
            FinancesBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(_TENANTS_REANTALS_BACKUPDataSet)
            MsgBox("Record saved succefully")
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub IconButtonDelete_Click(sender As Object, e As EventArgs) Handles IconButtonDelete.Click
        FinancesBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(_TENANTS_REANTALS_BACKUPDataSet)
        MsgBox("Record removed succefully")
    End Sub

    Private Sub FormFinances_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet1.Tenants' table. You can move, or remove it, as needed.
        Me.TenantsTableAdapter.Fill(Me._TENANTS_REANTALS_BACKUPDataSet1.Tenants)
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet1.Houses' table. You can move, or remove it, as needed.
        Me.HousesTableAdapter.Fill(Me._TENANTS_REANTALS_BACKUPDataSet1.Houses)
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet1.Finances' table. You can move, or remove it, as needed.
        Me.FinancesTableAdapter1.Fill(Me._TENANTS_REANTALS_BACKUPDataSet1.Finances)
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet1.Finances' table. You can move, or remove it, as needed.
        Me.FinancesTableAdapter1.Fill(Me._TENANTS_REANTALS_BACKUPDataSet1.Finances)

    End Sub

    Private Sub FinancesBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FinancesBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me._TENANTS_REANTALS_BACKUPDataSet1)

    End Sub

    Private Sub IconButtonAdd_Click(sender As Object, e As EventArgs) Handles IconButtonAdd.Click
        FinancesBindingSource1.AddNew()
    End Sub

    Private Sub IconButtoNSave_Click(sender As Object, e As EventArgs) Handles IconButtoNSave.Click
        Try
            FinancesBindingSource1.EndEdit()
            TableAdapterManager1.UpdateAll(_TENANTS_REANTALS_BACKUPDataSet1)
            MsgBox("Record saved succefully")
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub IconButtonDeletee_Click(sender As Object, e As EventArgs) Handles IconButtonDeletee.Click
        FinancesBindingSource1.RemoveCurrent()
        TableAdapterManager1.UpdateAll(_TENANTS_REANTALS_BACKUPDataSet1)
        MsgBox("Record removed succefully")
    End Sub

    Private Sub FinancesBindingSource1BindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles FinancesBindingSource1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FinancesBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me._TENANTS_REANTALS_BACKUPDataSet1)

    End Sub

End Class