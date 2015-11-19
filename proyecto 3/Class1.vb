Public Class mapa

    Dim _position As Point 'control where we are in the map
    Dim srcmouse, dstmouse As Rectangle 'two rectangles that controle the image display in the picture box

    Public Property Pos() As Point 'check the position of the cursor
        Get
            Return _position
        End Get
        Set(ByVal value As Point)
            _position = value
        End Set
    End Property

   
    Public Function distancia(ByVal po As Point, ByRef here As Point) 'set the distance between the city and the cursor
        Dim dist As Double
        dist = Math.Sqrt((po.X - here.X) ^ 2 + (po.Y - here.Y) ^ 2)
        Return dist
    End Function
  
End Class
