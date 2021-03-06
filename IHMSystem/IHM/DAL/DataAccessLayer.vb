Imports System.Data.SqlClient

Public Class DataAccessLayer
    Dim ConSetting As String = Application.StartupPath & "\LinkConnection.tmp"
    Dim Lines() As String = System.IO.File.ReadAllLines(ConSetting)
    Dim SqlCon = New SqlConnection("Server=" & Lines(0).Substring(7) & ";Database=" & Lines(1).Substring(9) & "; Integrated Security=false; User ID=" & Lines(2).Substring(3) & ";password=" & Lines(3).Substring(9) & "")
    Dim SqlCmd As SqlCommand



    'Method to Open the Connection
    Public Sub Open()
        If SqlCon.State <> ConnectionState.Open Then
            SqlCon.Open()
        End If
    End Sub


    'Method to Close the Connection
    Public Sub Close()
        If SqlCon.State = ConnectionState.Open Then
            SqlCon.Close()
        End If
    End Sub

    'Method to Insert, Update, and Delete Data From Database
    Public Sub ExecuteCommand(Store_Procedure As String, Param As SqlParameter())
        'Dim SqlCmd As SqlCommand = New SqlCommand("", SqlCon)
        SqlCmd = New SqlCommand("", SqlCon)
        SqlCmd.CommandType = CommandType.StoredProcedure
        SqlCmd.CommandText = Store_Procedure
        If Param IsNot Nothing Then
            SqlCmd.Parameters.AddRange(Param)
        End If
        SqlCmd.ExecuteNonQuery()
    End Sub

    Public Function GetMaxID(Store_Procedure As String) As String
        SqlCmd = New SqlCommand("", SqlCon)
        SqlCmd.CommandType = CommandType.StoredProcedure
        SqlCmd.CommandText = Store_Procedure
        Open()
        Dim IDMAX As Integer = SqlCmd.ExecuteScalar + "1"
        Close()
        Return IDMAX
    End Function
End Class
