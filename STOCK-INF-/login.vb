Public Class login


    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'items properties
        Me.TextBox2.PasswordChar = "*"
        Me.BackColor = Color.FromArgb(192, 192, 255)
        Button1.FlatStyle = FlatStyle.Flat
        Button1.BackColor = Color.FromArgb(192, 255, 255)
        Button1.Cursor = Cursors.Hand
        Me.MaximizeBox = False
        For Each item As Control In GroupBox1.Controls
            If TypeOf item Is TextBox Then
                DirectCast(item, TextBox).BorderStyle = BorderStyle.FixedSingle
                DirectCast(item, TextBox).TextAlign = HorizontalAlignment.Center
            End If
        Next
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "b" And TextBox2.Text = "" Then
            MsgBox("You are Now Logged In", MsgBoxStyle.Information, "Login")
            frmmain.Show()
            Me.Close()
        Else
            If TextBox1.Text = "u" And TextBox2.Text = "" Then
                MsgBox("You are Now Logged In", MsgBoxStyle.Information, "Login")
                usermain.Show()
                Me.Close()
            Else
                If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
                    MsgBox("You are Now Logged In", MsgBoxStyle.Information, "Login")
                    frmmain.Show()
                    Me.Close()
                Else
                    If TextBox1.Text = "user" And TextBox2.Text = "user" Then
                        MsgBox("You are Now Logged In", MsgBoxStyle.Information, "Login")
                        usermain.Show()
                        Me.Close()
                    Else
                        If TextBox1.Text = "" And TextBox2.Text = "" Then
                            MsgBox("No Username and/or Password Found!", MsgBoxStyle.Critical, "Error")
                        Else
                            If TextBox1.Text = "" Then
                                MsgBox("No Username Found!", MsgBoxStyle.Critical, "Error")
                            Else
                                If TextBox2.Text = "" Then
                                    MsgBox("No Password Found!", MsgBoxStyle.Critical, "Error")
                                Else
                                    MsgBox("Invalid Username And/Or Password!", MsgBoxStyle.Critical, "Error")

                                End If
                            End If
                        End If
                    End If
                End If
            End If
    End if
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class