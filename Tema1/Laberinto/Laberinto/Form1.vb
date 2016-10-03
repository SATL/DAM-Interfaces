Public Class Form1

    Dim startSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\chord.wav")
    Dim finishSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\tada.wav")
    Dim soundPLayer2 = New System.Media.SoundPlayer("C:\Windows\Media\notify.wav")

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub finishLabel_MouseEnter(sender As Object, e As EventArgs) Handles finishLabel.MouseEnter
        finishSoundPlayer.Play()
        MessageBox.Show("Felicidades!")
        Close()
    End Sub

    ''' <summary>
    ''' Mover el raton a un punto situado 10 px abajo y la derecha del punto de inicio situado en la esquina superior izquierda del laberinto
    ''' </summary>
    Private Sub MoveToStart()
        Dim startingPoint = Panel1.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub


    Private Sub wall_MouseEnter(sender As Object, e As EventArgs) Handles Label43.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter

        startSoundPlayer.Play()
        MoveToStart()
    End Sub

    Private Sub wall_MouseEnter2(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
        soundPLayer2.Play()
        MoveToStart()
    End Sub
End Class
