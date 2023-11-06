Imports System.Windows.Forms


Public Class ProductList
    Public Property fileName As String
    Private opf As New OpenFileDialog()

    Private Sub View()
        productListView.Items.Clear()
        MyQuery("SELECT * FROM menutbl")
        While rs.EOF = False
            lv = productListView.Items.Add(rs.Fields(0).Value)
            lv.SubItems.Add(rs.Fields(1).Value)
            lv.SubItems.Add(rs.Fields(2).Value)
            lv.SubItems.Add(rs.Fields(3).Value)
            lv.SubItems.Add(rs.Fields(4).Value)
            rs.MoveNext()
        End While
    End Sub
    Private Sub ProductList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
        View()

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim search As String = txtSearch.Text.Trim()

        productListView.Items.Clear()
        MyQuery("SELECT * FROM menuTbl WHERE Name LIKE '%" & search & "%' OR Price LIKE '%" & search & "%' OR Picture LIKE '%" & search & "%'")

        While rs.EOF = False
            lv = productListView.Items.Add(rs.Fields(0).Value)
            lv.SubItems.Add(rs.Fields(1).Value)
            lv.SubItems.Add(rs.Fields(2).Value)
            lv.SubItems.Add(rs.Fields(3).Value)
            lv.SubItems.Add(rs.Fields(4).Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            MyQuery("SELECT * FROM menutbl")
            rs.AddNew()
            rs.Fields(1).Value = txtProduct.Text
            rs.Fields(2).Value = txtPrice.Value
            rs.Fields(4).Value = cbTag.Text
            If Not PictureBox1.Image Is Nothing Then
                Dim imagePath As String = opf.FileName ' You need to have opf defined globally or somehow accessible here
                Dim fileName As String = System.IO.Path.GetFileName(imagePath)
                rs.Fields(3).Value = fileName
            End If
            rs.Update()
            MsgBox("Data added sucessfully!", MsgBoxStyle.Information)
            View()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog() = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub productListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles productListView.SelectedIndexChanged
        If productListView.SelectedItems.Count > 0 Then
            txtProduct.Text = productListView.SelectedItems(0).SubItems(1).Text
            txtPrice.Value = Decimal.Parse(productListView.SelectedItems(0).SubItems(2).Text) ' Use Decimal.Parse for parsing price
            fileName = productListView.SelectedItems(0).SubItems(3).Text
            cbTag.Text = productListView.SelectedItems(0).SubItems(4).Text
        Else
            txtProduct.Clear()
            txtPrice.Value = 0
            fileName = ""
            cbTag.SelectedIndex = -1
        End If
    End Sub

    Private Sub DeleteItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteItemToolStripMenuItem.Click
        If productListView.SelectedItems.Count > 0 Then

            Dim selectedItem As ListViewItem = productListView.SelectedItems(0)

            Dim itemID As Integer = Integer.Parse(selectedItem.SubItems(0).Text)

            MyQuery("DELETE FROM menuTbl WHERE ID = '" & itemID & "'")
        Else
            MessageBox.Show("No item selected for deletion.")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim selectedItem As ListViewItem = productListView.SelectedItems(0)
        Dim itemID As Integer = Integer.Parse(selectedItem.SubItems(0).Text)
        Dim prod As String = txtProduct.Text.Trim()
        Dim price As Integer = txtPrice.Value
        Dim tag As String = cbTag.Text.Trim()


        If productListView.SelectedItems.Count > 0 Then
            MyQuery("Select * FROM menutbl where MID = '" & itemID & "'")
            rs.Fields(1).Value = prod
            rs.Fields(2).Value = price
            rs.Fields(4).Value = tag
            If Not PictureBox1.Image Is Nothing Then
                Dim imagePath As String = opf.FileName ' You need to have opf defined globally or somehow accessible here
                fileName = System.IO.Path.GetFileName(imagePath)
                rs.Fields(3).Value = fileName
            End If
            rs.Update()

            View()

        End If
    End Sub
End Class