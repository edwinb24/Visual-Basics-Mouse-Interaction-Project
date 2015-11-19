Public Class Main_Form
    Dim closer As New Messageform 'control the close form
    Dim help_m As New Help_me 'control and help show the help form
    Dim cred As New Form4 'control and help show the credits form
    Dim map As New mapa 'manage the map 
    Dim m As Integer = 0 'prevent the execution of paint when debut the program from first time
    Dim i As Integer ' control the list when try to look for especific values
    Dim newloc As New Point 'variable that content the value of the actual position of the cursor
    Dim ciudad As LinkedList(Of City) 'list that have all the cities
    Dim working_dir As String 'take the direction where the program is
    Public cur As LinkedListNode(Of City) 'node that control and help looking at the list
    ' Dim f2 As New Form2
    Dim f2 As New Form2 'control the form2 and help put the values on it
    Dim myfile As New IO.FileStream("cities.txt", IO.FileMode.Open) 'content the file who bring all the values
    Dim p As Point 'control the position in the screem



    Private Sub Main_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        p.X = 128 ' set the position of the form in the screem
        p.Y = 200 ' set the position of the form in the screem
        Me.Location = p 'put the position of the screem
        working_dir = System.IO.Directory.GetCurrentDirectory() 'take the direction from what we are running the program
        Dim myreader As New IO.StreamReader(myfile) 'read the file with the datas
        ciudad = New LinkedList(Of City) 'start the list and prepare it for the first round of values
        Dim strayuda As String 'help taking the values and putting them in the list
        Dim dblayuda As Double 'help the double numbers to take the position of the city
        Dim dblayuda2 As Double 'help the double numbers to take the position of the city

        strayuda = myreader.ReadLine 'read the first line of the field
        While (Not myreader.EndOfStream) 'check if the text is ended to stop reading

            Dim ciu As New City 'create an instance of the class city to put the values of the first round of the list
            ciu.nombre = strayuda 'give the value of the city name to the node
            ciu.estado = myreader.ReadLine() 'give the value of the city estate to the node
            ciu.pobla = CInt(myreader.ReadLine()) 'give the value of the city poblation to the node
            dblayuda = CDbl(myreader.ReadLine()) 'give the value of the ubication in longitude to a variable that help to calculate the ubication and distance
            ciu.lon = dblayuda 'give the value of the longitude to the city list
            dblayuda2 = CDbl(myreader.ReadLine()) 'give the value of the ubication in latitude to a variable that help to calculate the ubication and distance
            ciu.lat = dblayuda2 'give the value of the longitude to the city list
            ciu.coment = myreader.ReadLine() 'give the coment of the city to the list
            strayuda = myreader.ReadLine 'read the first value
            If (strayuda <> "<none>") Then 'verified if there is a picture
                ciu.sw = True 'check if there is an picture of the city or not

                ciu.imag = Image.FromFile(strayuda) 'take the image
            Else
                ciu.sw = False 'check if there is an picture of the city or not
            End If
            myreader.ReadLine() 'read the line that separate one city form the next one
            ciudad.AddFirst(ciu) 'move to the next value in the list

            strayuda = myreader.ReadLine 'read the first line of the next city, the name of it
            ciu.ubica = ciu.ubicar(ciu.lon, ciu.lat, PictureBox1.Width, PictureBox1.Height)
        End While

    End Sub



    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click

        help_m.ShowDialog() 'show the help of the program
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        closer.ShowDialog() 'show the form that say if the user is sure that he want to leave the program
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        closer.ShowDialog() 'show the form that say if the user is sure that he want to leave the program
    End Sub


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim menor_dist As Double 'control the minor of the distances
        Dim act_dist As Double 'take the distance of the city that is actually being compared 
        Dim p As Point 'have the point of the position of hte form
        Dim ciudad_cercana As String 'take the name of the nearest city
        Dim working_dir As String 'take the direction on where we are working
        working_dir = System.IO.Directory.GetCurrentDirectory() 'take all the direction where we are running the program

        ciudad_cercana = " " 'start the value of the city that is more near to space
        i = 0 'initialize i, that control the value and show the nearest

        cur = ciudad.Last() 'set the node to the position of the last value of the list
        While cur IsNot Nothing 'check when we have look at all the values of the list
            act_dist = map.distancia(cur.Value().ubica, newloc) 'calculate the distance to the city
            If i <> 0 Then 'check if it is the first time we enter to the loop
                If menor_dist > act_dist Then 'check if the distance of the city  is least that the one that is the shorter actually
                    menor_dist = act_dist 'set the shorter distance
                    ciudad_cercana = cur.Value().nombre 'take the name of the city
                    i = i + 1 'set the value of i to the city number to identified which city is the nearest
                End If
            Else 'if it the first time in enter in the loop set by  default the distance to the shorter
                menor_dist = act_dist 'set the shorter distance
                  ciudad_cercana = cur.Value().nombre 'take the name of the city
                i = i + 1 'add 1 to the number of the list object we want
            End If
              cur = cur.Previous() 'go to the before value of the list
        End While

        cur = ciudad.Last() 'start the looking for the values in the orden from the last to the first

        For j As Integer = 2 To i
              cur = cur.Previous() 'go to the value before in the list

        Next
        '                   --- Setting all the values of the form that is showed with the city information ----
        f2.namelabel.Text = cur.Value().nombre
        f2.statebox.Text = cur.Value().estado
        f2.populbox.Text = cur.Value().pobla
        f2.ubicbox.Text = CStr(cur.Value().lon) & " , " & CStr(cur.Value().lat)
        f2.commentbox.Text = cur.Value().coment
        '  f2.myimg = cur.Value().imag

        '                   --- calculate the distance from the clicked point to the city (in terms of longitude and latitude ---
        f2.Label7.Text = "At " & Math.Sqrt(((124 - 57.0 * cur.Value.ubica.X / f2.CityPicture.Width()) - _
        (124 - 57.0 * newloc.X / f2.CityPicture.Width())) ^ 2 + _
        ((23.5 + 27.7 * (f2.CityPicture.Height - cur.Value.ubica.Y) / f2.CityPicture.Height) - _
          (23.5 + 27.7 * (f2.CityPicture.Height - newloc.Y) / f2.CityPicture.Height)) ^ 2).ToString("F2") & " of the clicked point..."

        If cur.Value.sw Then 'check if the city has a picture
            f2.myimg = cur.Value().imag 'set the picture of the nearest city
        Else
            f2.myimg = Image.FromFile(working_dir & "\enblanco.png") 'take the picture of the city as default picture setted in the form
        End If
        Refresh() 'repain the picture to add the point where we click and where is the city




        p.X = 800 'set the position of the form2
        p.Y = 100 'set the position of the form2

        f2.Location = p 'give the position to form2

        f2.Refresh() 'repaint the form to put the image on it
        f2.Show() 'show the form2 in the screem

    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        newloc.X = e.X 'take the position of the mouse in X
        newloc.Y = e.Y 'take the position of the mouse in Y
        map.Pos() = newloc 'give the position to the class

    End Sub



    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        Dim pintado, pintado2 As Image 'images of where we click and where is the city
        Dim working_dir2 As String 'bring the direction of the debuging of the program
        Dim srcpinta, dstpinta, srcpinta2, dstpinta2 As Rectangle 'take the rectangles of how is set the image and where
        If m <> 0 Then 'check and avoid the 1st execution of paint


            cur = ciudad.Last() 'set the node to the last value of the list
            For k As Integer = 2 To i 'look at the value in the list
               cur = cur.Previous()
            Next

            working_dir2 = System.IO.Directory.GetCurrentDirectory() 'set the direction where is debuging the program
            pintado = Image.FromFile(working_dir2 & "\myciu.png") 'take a picture of where is the city
            pintado2 = Image.FromFile(working_dir2 & "\star.png") 'take the picture of where we click

            srcpinta = New Rectangle(0, 0, pintado.Width, pintado.Height) 'make the rectangle to put the image on
            dstpinta = New Rectangle(cur.Value.ubica.X, cur.Value.ubica.Y - 10, 30, 20) 'rectangle that is the destination of the image
            srcpinta2 = New Rectangle(0, 0, pintado.Width, pintado.Height) 'make the rectangle to put the image on
            dstpinta2 = New Rectangle(newloc.X, newloc.Y - 5, 25, 25) 'rectangle that is the destination of the image

            e.Graphics.DrawImage(pintado, dstpinta, srcpinta, GraphicsUnit.Pixel) 'draw the picture of the city in the map
            e.Graphics.DrawImage(pintado2, dstpinta2, srcpinta2, GraphicsUnit.Pixel) 'draw the picture of where we click

        Else
            m = 1 'prepare to execute the next time it enter into the paint subrutine
        End If
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditsToolStripMenuItem.Click
        cred.ShowDialog()
    End Sub
End Class
