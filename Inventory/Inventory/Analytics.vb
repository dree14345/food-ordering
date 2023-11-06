Imports System.Windows.Forms.DataVisualization.Charting


Public Class Analytics
    Private Sub DisplaySalesQuarterly()
        ' Clear existing series in the chartBS
        chartBS.Series.Clear()

        MyQuery("SELECT pname, SUM(qty) as total_sum FROM orders GROUP BY pname")

        ' Create a DataTable to store the results
        Dim dt As New DataTable()

        ' Loop through the ADODB Recordset and populate the DataTable
        For i As Integer = 0 To rs.Fields.Count - 1
            dt.Columns.Add(rs.Fields(i).Name, GetType(Object))
        Next

        Do Until rs.EOF
            Dim newRow As DataRow = dt.NewRow()
            For i As Integer = 0 To rs.Fields.Count - 1
                newRow(i) = rs.Fields(i).Value
            Next
            dt.Rows.Add(newRow)
            rs.MoveNext()
        Loop

        ' Bind the data to the chartBS control
        chartBS.DataSource = dt

        ' Create a series and add it to the chart
        Dim series1 As New Series("SeriesName")

        ' Set the chart type to Bar
        series1.ChartType = SeriesChartType.Bar

        chartBS.Series.Add(series1)

        ' Set the X and Y values for the series
        series1.XValueMember = "pname"
        series1.YValueMembers = "total_sum"

        ' Refresh the chart to display the data
        chartBS.DataBind()
    End Sub



    Private Sub Analytics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect()
        DisplaySalesQuarterly()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
End Class