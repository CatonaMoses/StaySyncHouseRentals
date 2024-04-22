Public Class FormReceipts
    Private Sub IconButtonGenerate_Click(sender As Object, e As EventArgs) Handles IconButtonGenerate.Click
        txtResult.Clear()
        txtResult.Text += "   ************************************" & vbCrLf
        txtResult.Text += "   **    House Rent Receipt          **" & vbCrLf
        txtResult.Text += "   ************************************" & vbCrLf
        txtResult.Text += "   Date :" + DateTime.Now + "" & vbCrLf

        txtResult.Text += "   Tenant Name: " + ComboBoxTenant.Text + "" & vbCrLf
        txtResult.Text += "   House Name: " + ComboBoxHouse.Text + "" & vbCrLf
        txtResult.Text += "   Month Of Payment: " + ComboBoxMonth.Text + "" & vbCrLf
        txtResult.Text += "   Amount Paid: " + ComboBoxAmount.Text + "" & vbCrLf

        txtResult.Text += "                          Signature"
    End Sub

    Private Sub IconButtonReset_Click(sender As Object, e As EventArgs) Handles IconButtonReset.Click
        ComboBoxTenant.Text = ""
        ComboBoxHouse.Text = ""
        ComboBoxMonth.Text = ""
        ComboBoxAmount.Text = ""
        txtResult.Text = ""
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(txtResult.Text, New Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, New Point(10, 10))
    End Sub

    Private Sub IconButtonPrint_Click(sender As Object, e As EventArgs) Handles IconButtonPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub TenantsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TenantsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TenantsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TENANTS_REANTALS_BACKUPDataSet1)

    End Sub

    Private Sub FormReceipts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet1.PaymentsTbl' table. You can move, or remove it, as needed.
        Me.PaymentsTblTableAdapter.Fill(Me._TENANTS_REANTALS_BACKUPDataSet1.PaymentsTbl)
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet1.Houses' table. You can move, or remove it, as needed.
        Me.HousesTableAdapter.Fill(Me._TENANTS_REANTALS_BACKUPDataSet1.Houses)
        'TODO: This line of code loads data into the '_TENANTS_REANTALS_BACKUPDataSet1.Tenants' table. You can move, or remove it, as needed.
        Me.TenantsTableAdapter.Fill(Me._TENANTS_REANTALS_BACKUPDataSet1.Tenants)

    End Sub
End Class