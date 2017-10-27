Public Class splash



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim oForm As login
        oForm = New login()
        oForm.Show()
        oForm = Nothing
        Me.Close()



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connect()
            MsgBox("Connection succeeded...!!!")
        Catch ex As Exception
            MsgBox("Connection failed...!!!")
        End Try


    End Sub
End Class