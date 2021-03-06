
Imports System.Data.SqlClient

Public Class CusDat
    Dim DAL As New DataAccessLayer
    Dim StoreProcedure_MAX_SERIAL As String = "CUSTOMER_MAX_SERIAL"
    Dim StorrProcedure_MAX_SAVE_CUSTOMER As String = "CUSTOMER_SAVE"
    Dim MAX_SERIAL As String
    Public Function Get_MAX_Serial() As String
        MAX_Serial = DAL.GetMaxID(StoreProcedure_MAX_SERIAL)
        Return MAX_SERIAL
    End Function
    Public Sub CustomerSaveRecord(CUSTOMER_SERIAL As Integer, CUSTOMER_FIRST_NAME As String, CUSTOMER_SECOUND_NAME As String, CUSTOMER_LAST_NAME As String, _
                                   CUSTOMER_CIVIL_ID As String, CUSTOMER_PHONE_NUMBER As String)
        DAL.Open()
        Dim Parm As SqlParameter() = New SqlParameter(5) {}
        Parm(0) = New SqlParameter("@CUSTOMER_SERIAL", SqlDbType.Int)
        Parm(0).Value = CUSTOMER_SERIAL

        Parm(1) = New SqlParameter("@CUSTOMER_FIRST_NAME", SqlDbType.VarChar)
        Parm(1).Value = CUSTOMER_FIRST_NAME

        Parm(2) = New SqlParameter("@CUSTOEMR_SECOND_NAME", SqlDbType.VarChar)
        Parm(2).Value = CUSTOMER_SECOUND_NAME

        Parm(3) = New SqlParameter("@CUSTOMER_LAST_NAME", SqlDbType.VarChar)
        Parm(3).Value = CUSTOMER_LAST_NAME

        Parm(4) = New SqlParameter("@CUSTOMER_CIVIL_ID", SqlDbType.VarChar)
        Parm(4).Value = CUSTOMER_CIVIL_ID

        Parm(5) = New SqlParameter("@CUSTOMER_PHONE_NUMBER", SqlDbType.VarChar)
        Parm(5).Value = CUSTOMER_PHONE_NUMBER

        DAL.ExecuteCommand("CUSTOMER_SAVE", Parm)
        DAL.Close()
    End Sub
    Public Sub CustomerUpdateRecord(CUSTOMER_SERIAL As Integer, CUSTOMER_FIRST_NAME As String, CUSTOMER_SECOUND_NAME As String, CUSTOMER_LAST_NAME As String, _
                               CUSTOMER_CIVIL_ID As String, CUSTOMER_PHONE_NUMBER As String)
        DAL.Open()
        Dim Parm As SqlParameter() = New SqlParameter(5) {}
        Parm(0) = New SqlParameter("@CUSTOMER_SERIAL", SqlDbType.Int)
        Parm(0).Value = CUSTOMER_SERIAL

        Parm(1) = New SqlParameter("@CUSTOMER_FIRST_NAME", SqlDbType.VarChar)
        Parm(1).Value = CUSTOMER_FIRST_NAME

        Parm(2) = New SqlParameter("@CUSTOEMR_SECOND_NAME", SqlDbType.VarChar)
        Parm(2).Value = CUSTOMER_SECOUND_NAME

        Parm(3) = New SqlParameter("@CUSTOMER_LAST_NAME", SqlDbType.VarChar)
        Parm(3).Value = CUSTOMER_LAST_NAME

        Parm(4) = New SqlParameter("@CUSTOMER_CIVIL_ID", SqlDbType.VarChar)
        Parm(4).Value = CUSTOMER_CIVIL_ID

        Parm(5) = New SqlParameter("@CUSTOMER_PHONE_NUMBER", SqlDbType.VarChar)
        Parm(5).Value = CUSTOMER_PHONE_NUMBER

        DAL.ExecuteCommand("CUSTOMER_UPDATE", Parm)
        DAL.Close()
    End Sub
    Public Sub CustomerDeleteRecord(CUSTOMER_SERIAL As Integer)
        DAL.Open()
        Dim parm As SqlParameter() = New SqlParameter(0) {}
        parm(0) = New SqlParameter("@CUSTOMER_SERIAL", SqlDbType.Int)
        parm(0).Value = CUSTOMER_SERIAL
        DAL.ExecuteCommand("CUSTOMER_DELETE", parm)
        DAL.Close()
    End Sub
End Class
