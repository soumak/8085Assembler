Public Class Form3

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Top -= 1
        If Label1.Top = -(Me.Height - 250) Then

            Me.Close()
            'Form1.Show()

        End If
    End Sub

   
    Private Sub Form3_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Form1.Show()
        Timer1.Enabled = False
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Label1.Top = Me.Height - 100
    End Sub

    
End Class