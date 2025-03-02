Public Class DBO_FamliaProductos_TiposProductos
Inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_FamiliaProducto As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_TipoProducto As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_FamiliaProducto= New BasesParaCompatibilidad.DataBussinesParameter("@Id_FamiliaProducto","Id_FamiliaProducto")
       m_Id_TipoProducto= New BasesParaCompatibilidad.DataBussinesParameter("@Id_TipoProducto","Id_TipoProducto")
       MyBase.primaryKey = m_Id
       aņadirParametros()
   End Sub

   Public Property ID() As Integer
       Get
           if m_id.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id.value,integer)
       End Get
       Set(ByVal value As Integer)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Public Property Id_FamiliaProducto() As Integer
       Get
           if m_Id_FamiliaProducto.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_FamiliaProducto.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Id_FamiliaProducto.value = value
       End Set
   End Property

   Public Property Id_TipoProducto() As Integer
       Get
           if m_Id_TipoProducto.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_TipoProducto.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Id_TipoProducto.value = value
       End Set
   End Property

   Private Sub aņadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_FamiliaProducto, m_Id_FamiliaProducto.sqlName)
       MyBase.atributos.Add(m_Id_TipoProducto, m_Id_TipoProducto.sqlName)
   End Sub
End Class
