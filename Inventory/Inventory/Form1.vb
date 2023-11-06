Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim user As String = txtUser.Text.Trim()
        Dim pass As String = txtPass.Text.Trim()

        If user = "" Or pass = "" Then
            MsgBox("Please fill the empty fields!", MsgBoxStyle.Information)
        Else
            MyQuery("SELECT * FROM admintbl Where name = '" & user & "' And password = '" & pass & "'")

            If rs.RecordCount = 1 Then
                Me.Hide()
                Dashboard.Show()

                MsgBox("Login Succesfully!", MsgBoxStyle.Information)
            Else
                MsgBox("Invalid Account! Please try again.")
            End If
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()

    End Sub
End Class
