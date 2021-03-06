Imports System.Data.SqlClient

Public Class SupDat
    Dim DAL As New DataAccessLayer
    Dim StoreProcedure_MAX_SERIAL As String = "SUPPLIERS_MAX_SERIAL"
    Dim MAX_SERIAL As String
    Public Function Get_MAX_NUM() As String
        MAX_SERIAL = DAL.GetMaxID(StoreProcedure_MAX_SERIAL)
        Return MAX_SERIAL
    End Function
    Public Sub SupplierSaveRecord(SUPPLIER_SERIAL As Integer, SUPPLIER_NAME As String, SUPPLIER_PHONE_NUMBER As String)
        DAL.Open()
        Dim parm As SqlParameter() = New SqlParameter(2) {}

        parm(0) = New SqlParameter("@SUPPLIER_SERIAL", SqlDbType.Int)
        Parm(0).Value = SUPPLIER_SERIAL

        parm(1) = New SqlParameter("@SUPPLIER_NAME", SqlDbType.VarChar)
        parm(1).Value = SUPPLIER_NAME

        parm(2) = New SqlParameter("@SUPPLIER_PHONE_NUMBER", SqlDbType.VarChar)
        Parm(2).Value = SUPPLIER_PHONE_NUMBER

        DAL.ExecuteCommand("SUPPLIER_SAVE", parm)
        DAL.Close()
    End Sub
    Public Sub SupplierUpdateRecord(SUPPLIER_SERIAL As Integer, SUPPLIER_NAME As String, SUPPLIER_PHONE_NUMBER As String)
        DAL.Open()
        Dim parm As SqlParameter() = New SqlParameter(2) {}

        parm(0) = New SqlParameter("@SUPPLIER_SERIAL", SqlDbType.Int)
        parm(0).Value = SUPPLIER_SERIAL

        parm(1) = New SqlParameter("@SUPPLIER_NAME", SqlDbType.VarChar)
        parm(1).Value = SUPPLIER_NAME

        parm(2) = New SqlParameter("@SUPPLIER_PHONE_NUMBER", SqlDbType.VarChar)
        parm(2).Value = SUPPLIER_PHONE_NUMBER

        DAL.ExecuteCommand("SUPPLIER_UPDATE", parm)
        DAL.Close()
    End Sub

    Public Sub SupplierDeleteRecord(SUPPLIER_SERIAL As Integer)
        DAL.Open()
        Dim parm As SqlParameter() = New SqlParameter(0) {}
        parm(0) = New SqlParameter("@SUPPLIER_SERIAL", SqlDbType.Int)
        parm(0).Value = SUPPLIER_SERIAL
        DAL.ExecuteCommand("SUPPLIER_DELETE", parm)
        DAL.Close()
    End Sub
End Class
