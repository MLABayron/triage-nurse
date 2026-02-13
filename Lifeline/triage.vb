Public Class form_triage
    Private Sub form_triage_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.MinimumSize = New System.Drawing.Size(Me.Width, Me.Height)

        Me.MaximumSize = New System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)

        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
    End Sub
End Class
