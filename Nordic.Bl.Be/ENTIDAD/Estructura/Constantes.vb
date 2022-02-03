Public Class Constantes

    Public Const produccion As String = "http://grupobarboza.com/api/"
    Public Const produccionprueba As String = "http://grupobarboza.com/api-pruebas/"
    Public Const local As String = "http://192.168.1.31:8080/api/"
    Public Const endpoint = produccionprueba
    Public Const Nuevo As String = "REGISTRAR"
    Public Const MensajeRealizado As String = "Tarea Realizada Con Exito"
    Public Const MensajeNORealizado As String = "Tarea No Realizada, Intente Nuevamente"
    Public Const Modificar As String = "MODIFICAR"
    Public Const Eliminar As String = "ELIMINAR"
    Public Const Detalle As String = "DETALLE"
    Public Const Desestimar As String = "DESESTIMAR"
    Public Const LlamarDetraccion As String = "DETRACCION"
    Public Const ValorEnteroInicial As Integer = 0
    Public Const ValorEntero1 As Integer = 1
    Public Const ValorEnteroNegativo As Integer = -1
    Public Const MensajeErrorServer As String = "Fallo en el servidor, comunicarse con el proveedor"
    Public Const MensajeNoRecuperado As String = "No se pudieron recuperar datos, comunicarse con el proveedor"
    Public Const TipoListadoTrabajador = "T"
    Public Const MensajeSeleccioneCentroCosto As String = "Seleccionar Centro Costos"


#Region "Tipos Trabajador"
    Public Const idtipoadministrador As Integer = 1
    Public Const idtiporesidente As Integer = 2
    Public Const idtipologistico As Integer = 3
    Public Const idtipotesorero As Integer = 4
    Public Const idtipoadmin As Integer = 1
    Public Const idtipoalmacenero As Integer = 5
    Public Const idtipogerente As Integer = 6
    Public Const idtipoproyectos As Integer = 7
#End Region

    Public Const idtipoordencompra As Integer = 1
    Public Const idtipoordenservicio As Integer = 2I
    Public Const idtipocontrato As Integer = 3
    Public Const idformpagotransferencia As Integer = 2
    Public Const idformpagoefectivo As Integer = 1
    Public Const idformpagocredito As Integer = 3
    Public Const iditemcreado As Integer = 1
    Public Const iditemprocesado As Integer = 2
    Public Const iditempendiente As Integer = 3
    Public Const iditemdesestimaro As Integer = 4
    Public Const IGV As Decimal = 0.18

    Public Const idestadorqsolicitado As Integer = 1
    Public Const idestadorqprocesado As Integer = 2
    Public Const idestadorqdesestimado As Integer = 3
    Public Const idestadorqparcial As Integer = 4

    Public Const idestadopendienteordencompra As Integer = 1

    Public Const idtipooperacionentrada As Integer = 1
    Public Const idtipooperacionsalida As Integer = 2

    Public Const errorexcel As Integer = -2147024864

    Public Const idordenpagoParcial As Integer = 3
    Public Const idordenpagoCompleta As Integer = 2

#Region "TIPO ORDEN PAGO"
    Public Const idtipoordenpagoplanillaobra As Integer = 5
    Public Const idtipoordenpagogastosobraporautorizacion As Integer = 8
#End Region

#Region "TIPO CUENTA POR PAGAR"
    Public Const idtipocuentaporcobrarvalorizacion As Integer = 1
#End Region

#Region "Estado Pago"
    Public Const idestadopagoPendiente = 1
    Public Const idestadopagoPagado = 2
#End Region

#Region "TIPO PROCESO MASIVO"
    Public Const tipoprocesomasivoplanillaobra = 2
#End Region


#Region "Tipo Empresa"
    Public Const idtipoempresainterna As Integer = 1
    Public Const idtipoempresaexterna As Integer = 2
#End Region
End Class
