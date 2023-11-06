Public Class Form1
    Private Sub DisplayWaiting()
        Dim status As String = "Waiting"
        MyQuery("SELECT DISTINCT tNo FROM orders where Status = '" & status & "'")

        ' Clear existing controls in the FlowLayoutPanel
        waitingPanel.Controls.Clear()

        ' Check if the recordset is not empty
        If Not rs.EOF Then
            While Not rs.EOF
                ' Create a label for each result
                Dim label As New Label()
                label.Text = rs.Fields(0).Value.ToString() ' Assuming the result is in the first column

                ' Set the font and font size
                label.Font = New Font("JetBrains Mono", 14)

                ' Set the Margin property to create spacing around the label
                label.Margin = New Padding(5) ' Adjust the value (5 in this example) to your desired spacing

                ' Add the label to the FlowLayoutPanel
                waitingPanel.Controls.Add(label)

                rs.MoveNext() ' Move to the next record
            End While
        Else
            MessageBox.Show("No records with status 'Waiting' found.")
        End If
    End Sub
    Private Sub DisplayServing()
        Dim status As String = "Now Serving"
        MyQuery("SELECT DISTINCT tNo FROM orders where Status = '" & status & "'")

        ' Clear existing controls in the FlowLayoutPanel
        servingPanel.Controls.Clear()

        ' Check if the recordset is not empty
        If Not rs.EOF Then
            While Not rs.EOF
                ' Create a label for each result
                Dim label As New Label()
                label.Text = rs.Fields(0).Value.ToString() ' Assuming the result is in the first column

                ' Set the font and font size
                label.Font = New Font("JetBrains Mono", 14)

                ' Set the Margin property to create spacing around the label
                label.Margin = New Padding(5) ' Adjust the value (5 in this example) to your desired spacing

                ' Add the label to the FlowLayoutPanel
                servingPanel.Controls.Add(label)

                rs.MoveNext() ' Move to the next record
            End While
        Else
            MessageBox.Show("No records with status 'Now Serving' found.")
        End If
    End Sub



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
        DisplayWaiting()
        DisplayServing()

    End Sub

    Private Sub waitingPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles hatdog.Paint

    End Sub

    Private Sub servingPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles servingPanel.Paint

    End Sub
End Class
