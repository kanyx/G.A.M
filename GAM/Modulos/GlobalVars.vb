Module GlobalVars
    ' ############################################################
    ' # VARIABLE ConfigParametros:
    ' # DESC: Contiene los datos de configuracion de la aplicacion
    ' # Key - Value
    ' # bdserver : Servidor de base de datos.
    ' # bdport   : Puerto del servidor de base de datos.
    ' # bduser   : Usuario de la base de datos.
    ' # bdpass   : Contraseña de la base de datos.
    ' # bdname   : Nombre de la base de datos.
    ' # path_avatar : ruta donde se almacenaran los avatares.
    ' ###########################################################
    Public ConfigParametros As New Dictionary(Of String, String)
    ' ###########################################################
    ' # VARIABLE UserActive
    ' # DESC: Contiene los valores del uusario activo en a app.
    ' # Key  Value
    ' # id          : Identificador del usuario ebn la bd.
    ' # usuario     : Nombre de usuario en la app.
    ' # password    : Contraseña del usuario en MD5.
    ' # nombres     : Nombre del usuario.
    ' # apellido_p  : Apellido paterno del usuario.
    ' # apellido_m  : Apellido materno del usuario.
    ' # telefono    : Telefono del usuario.
    ' # celular     : Celular del usuario.
    ' # direccion   : Direccion del usuario.
    ' # comuna      : Identificador de la comuna.
    ' # region      : Identificador de la region.
    ' # avatar      : Imagen del usuario.
    ' # rut         : rut del usuario.
    ' # fnac        : fecha de nacimiento.
    ' ############################################################
    Public UserActive As New Dictionary(Of String, String)
End Module
