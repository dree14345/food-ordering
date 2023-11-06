Imports ADODB


Module modConnection
    Public con As New ADODB.Connection

    Public rs As New ADODB.Recordset
    Public lv As New ListViewItem
    Public Sub MyQuery(ByVal sql As String)
        If rs.State = ObjectStateEnum.adStateOpen Then rs.Close()
        rs.Open(sql, con, 1, 2)
    End Sub
    Public Sub Connect()
        On Error GoTo Err
        If con.State = ObjectStateEnum.adStateOpen Then con.Close()
        con.ConnectionString = "Driver={MySQL ODBC 8.1 ANSI Driver};Server=localhost;Port=3307;Database=foodordering;User=root;Password=dree14345;"


        con.ConnectionTimeout = 5
        con.CursorLocation = CursorLocationEnum.adUseClient
        con.Open()
        Exit Sub
Err:
        MsgBox(Err.Description, MsgBoxStyle.Information + MsgBoxStyle.Critical)
    End Sub
End Module
