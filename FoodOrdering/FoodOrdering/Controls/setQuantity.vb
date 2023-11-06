Public Class setQuantity
    Public Property ItemName As String
    Public Property ItemPrice As Integer

    Private Sub txtQuan_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuan.GotFocus
        If txtQuan.Text = "Quantity " Then
            txtQuan.Text = ""
        End If
    End Sub

    Private Sub txtQuan_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuan.LostFocus
        If String.IsNullOrWhiteSpace(txtQuan.Text) Then
            txtQuan.Text = "Quantity"
        End If
    End Sub
    Private Sub txtQuan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuan.TextChanged

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        If MsgBox("Would you like to cancel this order?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Hide()
        Else
            Return

        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim quantity As Integer
        If Integer.TryParse(txtQuan.Text, quantity) Then
            Dim result As Integer = ItemPrice * quantity

            ' Create a new ListViewItem with the item details
            Dim newItem As New ListViewItem(ItemName)
            newItem.SubItems.Add(quantity.ToString())
            newItem.SubItems.Add(ItemPrice.ToString())
            newItem.SubItems.Add(result.ToString())

            ' Add the new ListViewItem to the ListView
            POS.orderList.Items.Add(newItem)

            ' Update the total
            POS.DisplayTotal()
            Me.Hide()
        Else
            MessageBox.Show("Invalid quantity. Please enter a valid number.")
        End If
    End Sub

    Private Sub txtQuan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuan.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub setQuantity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class