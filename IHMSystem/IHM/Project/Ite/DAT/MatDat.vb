Imports System.Data.SqlClient
Public Class MatDAT
    Dim DAL As New DataAccessLayer
    Dim StoreProcedure_MAX_NUM As String = "ITEM_MAX_NUMBER"
    Dim MAX_NUM As String
    Public Function Get_MAX_NUM() As String
        MAX_NUM = DAL.GetMaxID(StoreProcedure_MAX_NUM)
        Return MAX_NUM
    End Function
End Class
