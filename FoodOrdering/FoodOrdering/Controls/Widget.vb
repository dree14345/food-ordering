Imports System.Globalization
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Widget
    Private Sub CirclePictureBox()
        Dim cornerPath As New GraphicsPath()
        Dim cornerRadius As Integer = 20 ' Adjust this value to control the border radius

        Dim rect As New RectangleF(0, 0, Panel1.Width, Panel1.Height)
        cornerPath.AddArc(rect.Left, rect.Top, cornerRadius * 2, cornerRadius * 2, 180, 90) ' Top-left corner
        cornerPath.AddArc(rect.Right - cornerRadius * 2, rect.Top, cornerRadius * 2, cornerRadius * 2, 270, 90) ' Top-right corner
        cornerPath.AddArc(rect.Right - cornerRadius * 2, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90) ' Bottom-right corner
        cornerPath.AddArc(rect.Left, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90) ' Bottom-left corner
        cornerPath.CloseFigure()

        ' Set the created GraphicsPath as the Region of the UserControl
        Me.Region = New Region(cornerPath)

        ' Create a GraphicsPath for the circular shape of the PictureBox
        Dim circularPath As New GraphicsPath()
        Dim radius As Integer = Math.Min(productPic.Width, productPic.Height) / 2

        circularPath.AddEllipse(0, 0, radius * 2, radius * 2)

        ' Set the created GraphicsPath as the Region of the PictureBox
        productPic.Region = New Region(circularPath)
    End Sub

    Private Sub Widget_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CirclePictureBox()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim quanForm As New setQuantity()

        ' Set the properties with the data you want to pass
        quanForm.ItemName = txtName.Text

        Dim priceText As String = txtPrice.Text

        ' Remove currency symbols and formatting characters
        priceText = priceText.Replace("₱", "").Replace("Php", "").Replace(",", "")

        Dim itemPrice As Decimal
        If Decimal.TryParse(priceText, NumberStyles.Currency, CultureInfo.CurrentCulture, itemPrice) Then
            quanForm.ItemPrice = itemPrice

            ' Show the setQuantity form
            quanForm.Show()
        Else
            MessageBox.Show("Invalid price. Please enter a valid number.")
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
