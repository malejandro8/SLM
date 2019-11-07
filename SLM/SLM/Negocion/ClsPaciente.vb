Imports System.Data.SqlClient

Public Class ClsPaciente
    Dim primer_nombre, segundo_nombre, primer_apellido, segundo_apellido As String
    'Constructor
    Public Sub New()

    End Sub

    Public Property Primer_nombre1 As String
        Get
            Return primer_nombre
        End Get
        Set(value As String)
            primer_nombre = value
        End Set
    End Property

    Public Property Segundo_nombre1 As String
        Get
            Return segundo_nombre
        End Get
        Set(value As String)
            segundo_nombre = "Javier"
        End Set
    End Property

    Public Property Primer_apellido1 As String
        Get
            Return primer_apellido
        End Get
        Set(value As String)
            primer_apellido = value
        End Set
    End Property

    Public Property Segundo_apellido1 As String
        Get
            Return segundo_apellido
        End Get
        Set(value As String)
            segundo_apellido = value
        End Set
    End Property


    Public Function RegistrarNuevoPaciente() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "NuevoPaciente"


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "primer_nombre"
        sqlpar.Value = Primer_nombre1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salida"
        sqlpar.Value = ""
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        sqlcom.Connection = New ClsConnection().getConexion
        sqlcom.ExecuteNonQuery()

        par_sal = sqlcom.Parameters("Salida").Value

        Return par_sal

    End Function
End Class
