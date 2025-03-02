Public Class DBO_AguaPotableAnaliticasCloro
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_PuntoMuestreoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_AnalistaID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_VerificadorID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Verificado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Fecha As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Valor As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Correcto As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Ruta As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@AnaliticaCloroID","AnaliticaCloroID")
       m_PuntoMuestreoID= New BasesParaCompatibilidad.DataBussinesParameter("@PuntoMuestreoID","PuntoMuestreoID")
       m_AnalistaID= New BasesParaCompatibilidad.DataBussinesParameter("@AnalistaID","AnalistaID")
       m_VerificadorID= New BasesParaCompatibilidad.DataBussinesParameter("@VerificadorID","VerificadorID")
       m_Verificado= New BasesParaCompatibilidad.DataBussinesParameter("@Verificado","Verificado")
       m_Fecha= New BasesParaCompatibilidad.DataBussinesParameter("@Fecha","Fecha")
       m_Valor= New BasesParaCompatibilidad.DataBussinesParameter("@Valor","Valor")
       m_Correcto= New BasesParaCompatibilidad.DataBussinesParameter("@Correcto","Correcto")
       m_Ruta= New BasesParaCompatibilidad.DataBussinesParameter("@Ruta","Ruta")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       MyBase.primaryKey = m_Id
       aņadirParametros()
   End Sub


   Public Property ID() As Int32
       Get
           Return if(isdbnull(m_id.value), Nothing, m_id.value)
       End Get
       Set(ByVal value As Int32)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Public Property PuntoMuestreoID() As Int32
       Get
           Return if(isdbnull(m_PuntoMuestreoID.value), Nothing, m_PuntoMuestreoID.value)
       End Get
       Set(ByVal value As Int32)
           m_PuntoMuestreoID.value = value
       End Set
   End Property

   Public Property AnalistaID() As Int32
       Get
           Return if(isdbnull(m_AnalistaID.value), Nothing, m_AnalistaID.value)
       End Get
       Set(ByVal value As Int32)
           m_AnalistaID.value = value
       End Set
   End Property

   Public Property VerificadorID() As Int32
       Get
           Return if(isdbnull(m_VerificadorID.value), Nothing, m_VerificadorID.value)
       End Get
       Set(ByVal value As Int32)
           m_VerificadorID.value = value
       End Set
   End Property

   Public Property Verificado() As Boolean
       Get
           Return if(isdbnull(m_Verificado.value), false, m_Verificado.value)
       End Get
       Set(ByVal value As Boolean)
           m_Verificado.value = value
       End Set
   End Property

    Public Property Fecha() As Date
        Get
            Return If(IsDBNull(m_Fecha.value), Today.Date, m_Fecha.value)
        End Get
        Set(ByVal value As Date)
            m_Fecha.value = value
        End Set
    End Property

    Public Property Valor() As Double
        Get
            Return If(isdbnull(m_Valor.value), Nothing, m_Valor.value)
        End Get
        Set(ByVal value As Double)
            m_Valor.value = value
        End Set
    End Property

   Public Property Correcto() As Boolean
       Get
           Return if(isdbnull(m_Correcto.value), false, m_Correcto.value)
       End Get
       Set(ByVal value As Boolean)
           m_Correcto.value = value
       End Set
   End Property

   Public Property Ruta() As String
       Get
           Return if(isdbnull(m_Ruta.value), String.empty, m_Ruta.value)
       End Get
       Set(ByVal value As String)
           m_Ruta.value = value
       End Set
   End Property

   Public Property Observaciones() As String
       Get
           Return if(isdbnull(m_Observaciones.value), String.empty, m_Observaciones.value)
       End Get
       Set(ByVal value As String)
           m_Observaciones.value = value
       End Set
   End Property



   Private Sub aņadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_PuntoMuestreoID, m_PuntoMuestreoID.sqlName)
       MyBase.atributos.Add(m_AnalistaID, m_AnalistaID.sqlName)
       MyBase.atributos.Add(m_VerificadorID, m_VerificadorID.sqlName)
       MyBase.atributos.Add(m_Verificado, m_Verificado.sqlName)
       MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
       MyBase.atributos.Add(m_Valor, m_Valor.sqlName)
       MyBase.atributos.Add(m_Correcto, m_Correcto.sqlName)
       MyBase.atributos.Add(m_Ruta, m_Ruta.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
   End Sub
End Class
