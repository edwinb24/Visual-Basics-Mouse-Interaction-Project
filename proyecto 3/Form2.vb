Public Class Form2
    Public myimg As Image 'take the picture and put it in the form
    Dim src, dst As Rectangle 'set the sources of the picture, what we want of it and where to put it

    Private f1 As Main_Form 'control the main form options


    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles CityPicture.Paint
        Dim working_dir As String 'set the direction where we are working 
        working_dir = System.IO.Directory.GetCurrentDirectory() 'take the direction where is the executable

        src = New Rectangle(0, 0, myimg.Width, myimg.Height) 'set the rectangle that say that we wabnt all the image
        dst = New Rectangle(0, 0, CityPicture.Width, CityPicture.Height) 'set the rectangle that say we want to ocupate all the picture espace we have

        e.Graphics.DrawImage(myimg, dst, src, GraphicsUnit.Pixel) 'draw the picture of the city
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide() 'hide the form2 when click in the return to map button
    End Sub

End Class