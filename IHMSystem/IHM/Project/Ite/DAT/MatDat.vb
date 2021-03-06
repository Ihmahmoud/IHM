Imports System.Data.SqlClient
Public Class MatDAT
    Dim DAL As New DataAccessLayer
    Dim StoreProcedure_MAX_NUM As String = "ITEM_MAX_NUMBER"
    Dim MAX_NUM As String
    Public Function Get_MAX_NUM() As String
        MAX_NUM = DAL.GetMaxID(StoreProcedure_MAX_NUM)
        Return MAX_NUM
    End Function

    Public Sub ItemSaveRecord(ITEM_NUMBER As Integer, ITEM_CODE As String, ITEM_NAME As String, ITEM_CONSUMER_PRICE As Double)

        DAL.Open()
        Dim parm As SqlParameter() = New SqlParameter(3) {}

        parm(0) = New SqlParameter("@ITEM_NUMBER", SqlDbType.Int)
        parm(0).Value = ITEM_NUMBER

        parm(1) = New SqlParameter("@ITEM_CODE", SqlDbType.VarChar)
        parm(1).Value = ITEM_CODE

        parm(2) = New SqlParameter("@ITEM_NAME", SqlDbType.VarChar)
        parm(2).Value = ITEM_NAME

        parm(3) = New SqlParameter("@ITEM_CONSUMER_PRICE", SqlDbType.Float, 53)
        parm(3).Value = ITEM_CONSUMER_PRICE

        DAL.ExecuteCommand("ITEM_SAVE", parm)
        DAL.Close()
    End Sub
    Public Sub ItemUpdateRecord(ITEM_NUMBER As Integer, ITEM_CODE As String, ITEM_NAME As String, ITEM_CONSUMER_PRICE As Double)

        DAL.Open()
        Dim parm As SqlParameter() = New SqlParameter(3) {}

        parm(0) = New SqlParameter("@ITEM_NUMBER", SqlDbType.Int)
        parm(0).Value = ITEM_NUMBER

        parm(1) = New SqlParameter("@ITEM_CODE", SqlDbType.VarChar)
        parm(1).Value = ITEM_CODE

        parm(2) = New SqlParameter("@ITEM_NAME", SqlDbType.VarChar)
        parm(2).Value = ITEM_NAME

        parm(3) = New SqlParameter("@ITEM_CONSUMER_PRICE", SqlDbType.Float, 53)
        parm(3).Value = ITEM_CONSUMER_PRICE

        DAL.ExecuteCommand("ITEM_UPDATE", parm)
        DAL.Close()
    End Sub

    Public Sub ItemDeleteRecord(ITEM_NUMBER As Integer)
        DAL.Open()
        Dim parm As SqlParameter() = New SqlParameter(0) {}
        parm(0) = New SqlParameter("@ITEM_NUMBER", SqlDbType.Int)
        parm(0).Value = ITEM_NUMBER
        DAL.ExecuteCommand("ITEM_DELETE", parm)
        DAL.Close()
    End Sub
End Class
