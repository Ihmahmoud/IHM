
Imports MySql.Data.MySqlClient


Public Class Form1
    Private mysqlConnection As New MySqlConnection


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeConnection()
    End Sub

    Private Sub InitializeConnection()
        mysqlConnection = New MySqlConnection("Server=localhost;UID=root;Database=mydatabase;Pwd=Pa$$w0rd")
        AddHandler mysqlConnection.StateChange, AddressOf mysqlConnection_StateChange

        Try
            mysqlConnection.Open()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub mysqlConnection_StateChange(sender As Object, e As StateChangeEventArgs)
        Select Case e.CurrentState
            Case ConnectionState.Closed
                TSSL_ConnectionStatus.Text = "Disconnect"
            Case ConnectionState.Open
                TSSL_ConnectionStatus.Text = "Connect"
        End Select
    End Sub

End Class
