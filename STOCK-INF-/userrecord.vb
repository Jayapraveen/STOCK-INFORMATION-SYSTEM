Public Class userrecord


    Public Sub refresh()
        cmd.CommandText = "SELECT * FROM RECORD where UNAME= '" & order.Label4.Text & "';"
        cmd.ExecuteNonQuery()
        adp.SelectCommand = cmd
        dt = New DataTable
        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Public Sub formenter()
        TextBox1.Focus()
    End Sub

    Private Sub frmstdnt_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = False
        usermain.Show()
    End Sub

    Private Sub frmrecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STOCKDataSet4.RECORD' table. You can move, or remove it, as needed.
        Me.RECORDTableAdapter.Fill(Me.STOCKDataSet4.RECORD)
        'TODO: This line of code loads data into the 'STOCKDataSet9.STOCK' table. You can move, or remove it, as needed.


        TextBox1.TextAlign = HorizontalAlignment.Center
        Me.TextBox1.BorderStyle = BorderStyle.FixedSingle

       
        Me.BackColor = Color.FromArgb(192, 192, 255)
        'buttons properties
        Button1.BackColor = Color.FromArgb(255, 192, 192)

        Button4.BackColor = Color.FromArgb(192, 255, 192)

        AcceptButton = Button4
        'Me.ComboBox1.DropDownHeight = 150
        'Me.ComboBox2.DropDownHeight = 150
        Me.MaximizeBox = False


        'textbox as type of item in groupbox
        For Each item As Control In GroupBox1.Controls
            If TypeOf item Is TextBox Then
                DirectCast(item, TextBox).BorderStyle = BorderStyle.FixedSingle
                'DirectCast(item, TextBox).TextAlign = HorizontalAlignment.Center
            End If
        Next

        'button as type of item in a form
        For Each item As Control In Me.Controls
            If TypeOf item Is Button Then
                DirectCast(item, Button).FlatStyle = FlatStyle.Flat
                DirectCast(item, Button).Cursor = Cursors.Hand
                DirectCast(item, Button).TabStop = False
            End If
        Next

        connect()
        refresh()
        formenter()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            'if searchbox is empty
            If TextBox1.Text = Nothing Then
                Me.TextBox1.BackColor = Color.FromArgb(255, 192, 255)
                If MsgBox("Enter Product name.", MsgBoxStyle.OkOnly) = MsgBoxResult.Ok Then
                    Me.TextBox1.BackColor = Color.White
                End If

            Else
                cmd.CommandText = "SELECT * FROM RECORD WHERE PRODNAME='" & TextBox1.Text & "' minus SELECT * FROM RECORD WHERE UNAME='" & order.Label4.Text & "';"
                cmd.ExecuteNonQuery()
                adp.SelectCommand = cmd
                dt = New DataTable
                adp.Fill(dt)
                DataGridView1.DataSource = dt

            End If


        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub



End Class