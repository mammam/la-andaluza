Public Class DBO_Idiomas
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Traduccion As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@IdiomaID","IdiomaID")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_Traduccion= New BasesParaCompatibilidad.DataBussinesParameter("@Traduccion","Traduccion")
       MyBase.primaryKey = m_Id
       aņadirParametros()
   End Sub

   Public Property ID() As Int32
       Get
           if m_id.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id.value,int32)
       End Get
       Set(ByVal value As Int32)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Public Property Descripcion() As String
       Get
           if m_Descripcion.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Descripcion.value,string)
       End Get
       Set(ByVal value As String)
           m_Descripcion.value = value
       End Set
   End Property

   Public Property Traduccion() As Boolean
       Get
           if m_Traduccion.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_Traduccion.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_Traduccion.value = value
       End Set
   End Property

   Private Sub aņadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_Traduccion, m_Traduccion.sqlName)
   End Sub
End Class
