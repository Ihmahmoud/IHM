Imports System.Data.SqlClient

Public Class SupDat
    Dim DAL As New DataAccessLayer
    Dim StoreProcedure_MAX_SERIAL As String = "SUPPLIERS_MAX_SERIAL"
    Dim MAX_SERIAL As String
    Public Function Get_MAX_NUM() As String
        MAX_SERIAL = DAL.GetMaxID(StoreProcedure_MAX_SERIAL)
        Return MAX_SERIAL
    End Function
End Class
