

Class spTareas
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[TareasSelect]", "[dbo].[TareasInsert]", _
                   "[dbo].[TareasUpdate]", "[dbo].[TareasDelete]", _
                   "TareasSelectDgv", "TareasSelectDgvByID")
    End Sub

    Public Function Select_Record(ByVal TareaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Tareas
        dtb.Conectar()
        Dim DBO_Tareas As New DBO_Tareas

        Dim selectProcedure As String = "[dbo].[TareasSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@TareaID", TareaID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_Tareas.TareaID = If(reader("TareaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("TareaID")))
                DBO_Tareas.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_Tareas.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_Tareas.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_Tareas.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                DBO_Tareas = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_Tareas
    End Function

    Public Function TareasInsert(ByVal dbo_Tareas As DBO_Tareas, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[TareasInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure

        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_Tareas.Descripcion)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_Tareas.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_Tareas.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_Tareas.UsuarioModificacion)

        insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            insertCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function TareasUpdate(ByVal newDBO_Tareas As DBO_Tareas, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[TareasUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_Tareas.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_Tareas.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_Tareas.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_Tareas.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldTareaID", newDBO_Tareas.TareaID)
        '<Tag=[Three][End]> -- please do not remove this line
        updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            updateCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(updateCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en UpdateTareas" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function TareasDelete(ByVal TareaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[TareasDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldTareaID", TareaID)
        '<Tag=[Four][End]> -- please do not remove this line
        deleteCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        deleteCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            deleteCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(deleteCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Sub GrabarTareas(ByVal dbo_Tareas As DBO_Tareas, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dbo_Tareas.FechaModificacion = System.DateTime.Now.Date
        dbo_Tareas.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_Tareas.TareaID = 0 Then
            TareasInsert(dbo_Tareas, dtb)
        Else
            TareasUpdate(dbo_Tareas, dtb)
        End If
    End Sub

End Class
