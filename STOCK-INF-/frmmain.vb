Public Class frmmain

    Private Sub frmmain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Me.Hide()

        Else

            e.Cancel = True
        End If


    End Sub

    Private Sub frmmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each item As Control In GroupBox1.Controls
            If TypeOf item Is Button Then
                DirectCast(item, Button).FlatStyle = FlatStyle.Flat
                DirectCast(item, Button).TabStop = False
                DirectCast(item, Button).Cursor = Cursors.Hand
                DirectCast(item, Button).BackColor = Color.White
            End If

            Me.BackColor = Color.FromArgb(192, 192, 255)
            Me.Text = "ADMIN PANEL"
        Next

        Me.MaximizeBox = False

        Label9.Visible = False
        Label12.Visible = False
        Label13.Visible = False

    End Sub

    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Label9.Visible = True
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Label9.Visible = False
    End Sub



    Private Sub Button4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseHover
        Label12.Visible = True
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Label12.Visible = False
    End Sub

    Private Sub Button3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        Label13.Visible = True
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Label13.Visible = False

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmstdnt.Show()
        Me.Hide()
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmrecord.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmgrades.Show()
        Me.Hide()

    End Sub





    Private Sub InformationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformationsToolStripMenuItem.Click
        frmstdnt.Show()
        Me.Hide()
    End Sub

    Private Sub GradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradesToolStripMenuItem.Click
        frmgrades.Show()
    End Sub

    Private Sub RecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordsToolStripMenuItem.Click
        frmrecord.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Try
            Process.Start("calc.exe")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub WordpadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Process.Start("wordpad.exe")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        Try
            Process.Start("notepad.exe")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        MsgBox("You are now succesfully logged out")
        login.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class