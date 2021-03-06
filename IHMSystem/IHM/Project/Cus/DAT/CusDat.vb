Imports System.Data.SqlClient

Public Class CusDat
        Dim DAL As New DataAccessLayer
    Dim StoreProcedure_MAX_SERIAL As String = "CUSTOMER_MAX_SERIAL"
    Dim MAX_SERIAL As String
    Public Function Get_MAX_Serial() As String
        MAX_Serial = DAL.GetMaxID(StoreProcedure_MAX_SERIAL)
        Return MAX_SERIAL
    End Function
    End Class
