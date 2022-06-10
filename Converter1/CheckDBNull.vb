Module CheckDBNull
    <Runtime.CompilerServices.Extension>
    Public Function CheckDBNull(Of T)(ByVal DbField As Object) As T
        If DbField Is Nothing OrElse DbField Is DBNull.Value Then
            Return Nothing
        Else
            Return CType(DbField, T)
        End If

    End Function

End Module
