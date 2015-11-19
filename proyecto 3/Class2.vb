Public Class City
    Public lon As Double = 0
    Public lat As Double
    Public nombre As String
    Public pobla As Integer
    Public imag As Image
    Public estado As String
    Public coment As String
    Public ubica As Point
    Public sw As Boolean

    Public Function ubicar(ByRef lon As Double, ByRef lat As Double, ByRef width As Double, ByRef height As Double)
        ubica.X = (124 - lon) * width / 57.0
        ubica.Y = height - (lat - 23.5) * height / 27.7
        Return ubica
    End Function

    Public Sub pintar(ByRef on_me As Graphics)
       
    End Sub

    ' Public Sub colocarlon(ByRef lon_2 As Double)
    '    lon = lon_2
    ' End Sub
    'Public Sub colocarlat(ByRef lat_2 As Double)
    '   lat = lat_2
    ' End Sub
    'Public Sub colocarnombre(ByRef nombre_2 As String)
    '   nombre = nombre_2
    ' End Sub
    'Public Sub colocarpobla(ByRef pobla_2 As Integer)
    '   pobla = pobla_2
    ' End Sub
    'Public Sub colocarimag(ByRef imag_2 As Image)
    '   imag = imag_2
    'End Sub
    'Public Sub colocarestado(ByRef estado_2 As String)
    '   estado = estado_2
    'End Sub
    'Public Sub colocarcoment(ByRef coment_2 As String)
    '   coment = coment_2
    'End Sub
    ' Public Sub colocarubica(ByRef ubica_2 As Point)
    '    ubica = ubica_2
    'End Sub



    'Public Function asignarlon()
    '   Return lon
    ' End Function
    'Public Function asignarlat()
    '   Return lat
    'End Function
    ' Public Function asignarnombre()
    '    Return lon
    ' End Function
    'Public Function asignarpobla()
    '   Return pobla
    ' End Function
    'Public Function asignarimag()
    '   Return imag
    ' End Function
    'Public Function asignarestado()
    '   Return estado
    'End Function
    'Public Function asignarcoment()
    '    Return coment
    'End Function

    'Public Function asignarubica()
    '   Return ubica
    'End Function
End Class
