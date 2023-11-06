Public Class Form1
    Private Sub View()
        Dim status As String = "Waiting"
        orderList.Items.Clear()
        MyQuery("SELECT * FROM orders WHERE status = '" & status & "'")

        While Not rs.EOF
            Dim lv As New ListViewItem(rs.Fields(0).Value.ToString())
            lv.SubItems.Add(rs.Fields(3).Value.ToString())
            lv.SubItems.Add(rs.Fields(4).Value.ToString())
            lv.SubItems.Add(rs.Fields(6).Value.ToString())
            lv.SubItems.Add(rs.Fields(7).Value.ToString())
            orderList.Items.Add(lv)
            rs.MoveNext()
        End While
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
        View()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim status As String = "Now Serving"
        If orderList.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = orderList.SelectedItems(0)
            Dim itemID As Integer = Integer.Parse(selectedItem.SubItems(0).Text)
            MyQuery("UPDATE orders SET Status = '" & status & "' WHERE order_id = " & itemID)
            View()
        Else
            MessageBox.Show("No item selected for status update.")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim status As String = "Now Serving"
        If orderList.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = orderList.SelectedItems(0)

            Dim itemID As Integer = Integer.Parse(selectedItem.SubItems(0).Text)
            MyQuery("DELETE FROM orders WHERE order_id = " & itemID)
            View()
        Else
            MessageBox.Show("No item selected for deletion.")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub
End Class
