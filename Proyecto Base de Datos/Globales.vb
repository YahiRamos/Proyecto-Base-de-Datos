Imports Oracle.DataAccess.Client
' Oracle.ManagedDataAccess.Client

Module Globales

    'Para trabajar con una base de datos ORACLE, es requerida
    ' para poder abrir y cerrar la BD

    Public cnx As OracleConnection

    'Estas variables son de MI AUTORIA, la razón para sarlas de manera global
    ' es que las uso en diferentes formularios, y así evito tener que definirlas
    ' o declararlas en cada formulario. la palabra clave para que trabaje como 
    ' global es Public, el tipo de datos, pues ya ustedes lo definen de acuerdo 
    ' a su necesidad

    Public idCuenta As String
    Public idContraseña As String
    Public idNombre As String
    Public idPaterno As String
    Public idMaterno As String
    Public idPais As String
    Public miPais As Integer
    Public idEstado As String
    Public miEstado As Integer
    Public idCiudad As String
    Public miCiudad As Integer
    Public idColonia As String
    Public miColonia As Integer
    Public colNueva As String
    Public UsuarioConectado As String
    Public El_Nombre As String
    Public ElCorreo As String
    Public idClase As String
    Public idEquipo As String
    Public Eldbms As String

End Module


