Imports System.Data.SqlClient

Public Class ClsConnection

    'esta clase sirve para abrir una conexxion en la base de datos 

    Private sqlcon As SqlConnection
    Public str_con As String
    'String Conexion

    Public Sub New()
        str_con = "Data Source=10.172.3.10;Initial Catalog=slm_test;User Id=sa;Password=Lbm2019;"




    End Sub

    Public Function getConexion() As SqlConnection

        sqlcon = New SqlConnection(str_con)
        ''se conecta a la base de datos
        sqlcon.Open()
        ''abre la conexión a la base de datos
        Return sqlcon
        ''retorna la conexión abierta

    End Function

End Class
