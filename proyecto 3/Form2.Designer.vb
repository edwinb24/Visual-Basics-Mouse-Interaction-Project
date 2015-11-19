<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.namelabel = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.statebox = New System.Windows.Forms.TextBox
        Me.populbox = New System.Windows.Forms.TextBox
        Me.ubicbox = New System.Windows.Forms.TextBox
        Me.commentbox = New System.Windows.Forms.TextBox
        Me.CityPicture = New System.Windows.Forms.PictureBox
        CType(Me.CityPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'namelabel
        '
        Me.namelabel.AutoSize = True
        Me.namelabel.BackColor = System.Drawing.Color.Transparent
        Me.namelabel.Font = New System.Drawing.Font("Minya Nouvelle", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelabel.ForeColor = System.Drawing.Color.White
        Me.namelabel.Location = New System.Drawing.Point(145, 47)
        Me.namelabel.Name = "namelabel"
        Me.namelabel.Size = New System.Drawing.Size(147, 34)
        Me.namelabel.TabIndex = 1
        Me.namelabel.Text = "city name"
        Me.namelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Minya Nouvelle", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(94, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "State"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Minya Nouvelle", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(40, 339)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Popullation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Minya Nouvelle", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(53, 381)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ubication"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Minya Nouvelle", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(13, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "The nearest city is:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Minya Nouvelle", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(13, 547)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "at of the clicked point..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Olive
        Me.Button2.Location = New System.Drawing.Point(290, 532)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 34)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "back to Map..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'statebox
        '
        Me.statebox.BackColor = System.Drawing.Color.White
        Me.statebox.Enabled = False
        Me.statebox.Font = New System.Drawing.Font("Minya Nouvelle", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statebox.Location = New System.Drawing.Point(169, 294)
        Me.statebox.Multiline = True
        Me.statebox.Name = "statebox"
        Me.statebox.Size = New System.Drawing.Size(197, 26)
        Me.statebox.TabIndex = 10
        '
        'populbox
        '
        Me.populbox.Enabled = False
        Me.populbox.Font = New System.Drawing.Font("Minya Nouvelle", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.populbox.Location = New System.Drawing.Point(169, 339)
        Me.populbox.Multiline = True
        Me.populbox.Name = "populbox"
        Me.populbox.Size = New System.Drawing.Size(197, 26)
        Me.populbox.TabIndex = 11
        '
        'ubicbox
        '
        Me.ubicbox.Enabled = False
        Me.ubicbox.Font = New System.Drawing.Font("Minya Nouvelle", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubicbox.Location = New System.Drawing.Point(169, 381)
        Me.ubicbox.Multiline = True
        Me.ubicbox.Name = "ubicbox"
        Me.ubicbox.Size = New System.Drawing.Size(197, 26)
        Me.ubicbox.TabIndex = 12
        '
        'commentbox
        '
        Me.commentbox.Enabled = False
        Me.commentbox.Font = New System.Drawing.Font("Minya Nouvelle", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commentbox.Location = New System.Drawing.Point(45, 431)
        Me.commentbox.Multiline = True
        Me.commentbox.Name = "commentbox"
        Me.commentbox.Size = New System.Drawing.Size(321, 93)
        Me.commentbox.TabIndex = 13
        '
        'CityPicture
        '
        Me.CityPicture.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CityPicture.Image = CType(resources.GetObject("CityPicture.Image"), System.Drawing.Image)
        Me.CityPicture.InitialImage = Nothing
        Me.CityPicture.Location = New System.Drawing.Point(103, 84)
        Me.CityPicture.Name = "CityPicture"
        Me.CityPicture.Size = New System.Drawing.Size(231, 187)
        Me.CityPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CityPicture.TabIndex = 0
        Me.CityPicture.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(433, 588)
        Me.ControlBox = False
        Me.Controls.Add(Me.commentbox)
        Me.Controls.Add(Me.ubicbox)
        Me.Controls.Add(Me.populbox)
        Me.Controls.Add(Me.statebox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.namelabel)
        Me.Controls.Add(Me.CityPicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "City"
        CType(Me.CityPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CityPicture As System.Windows.Forms.PictureBox
    Friend WithEvents namelabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents populbox As System.Windows.Forms.TextBox
    Friend WithEvents ubicbox As System.Windows.Forms.TextBox
    Friend WithEvents commentbox As System.Windows.Forms.TextBox
    Friend WithEvents statebox As System.Windows.Forms.TextBox
End Class
