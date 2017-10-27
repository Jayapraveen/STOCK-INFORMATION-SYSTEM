Public Class frmrecord

    Public Sub refresh()
        cmd.CommandText = "SELECT * FROM RECORD;"
        cmd.ExecuteNonQuery()
        adp.SelectCommand = cmd
        dt = New DataTable
        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Public Sub formenter()
        ComboBox1.Focus()
    End Sub

    Private Sub frmstdnt_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = False
        frmmain.Show()
    End Sub

    '   Public Sub IMPORT()

    '    cmd.CommandText = "SET IDENTITY_INSERT record Off INSERT INTO RECORD (ID,NAME) SELECT ID,NAME FROM RECORD where id not in (select id from record);"
    '     cmd.ExecuteNonQuery()
    '   End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        cmd.CommandText = "SELECT * FROM RECORD;"
        adp.SelectCommand = cmd
        dt = New DataTable
        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub




    Private Sub frmrecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STOCKDataSet4.RECORD' table. You can move, or remove it, as needed.
        Me.RECORDTableAdapter.Fill(Me.STOCKDataSet4.RECORD)
        'TODO: This line of code loads data into the 'STOCKDataSet9.STOCK' table. You can move, or remove it, as needed.


        TextBox1.TextAlign = HorizontalAlignment.Center
        Me.TextBox1.BorderStyle = BorderStyle.FixedSingle

        Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = FlatStyle.Flat
        Me.ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = FlatStyle.Flat
        Me.BackColor = Color.FromArgb(192, 192, 255)
        'buttons properties
        Button1.BackColor = Color.FromArgb(255, 192, 192)

        Button6.BackColor = Color.FromArgb(255, 192, 255)
        Button8.BackColor = Color.FromArgb(255, 192, 255)
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
        ' IMPORT()
        refresh()
        formenter()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            'if searchbox is empty
            If TextBox1.Text = Nothing Then
                Me.TextBox1.BackColor = Color.FromArgb(255, 192, 255)
                If MsgBox("Enter student name.", MsgBoxStyle.OkOnly) = MsgBoxResult.Ok Then
                    Me.TextBox1.BackColor = Color.White
                End If

            Else
                cmd.CommandText = "SELECT * FROM STOCK WHERE NAME='" & TextBox1.Text & "';"
                cmd.ExecuteNonQuery()
                adp.SelectCommand = cmd
                dt = New DataTable
                adp.Fill(dt)
                DataGridView1.DataSource = dt

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cmd.CommandText = "truncate table RECORD;"
        cmd.ExecuteNonQuery()
        adp.SelectCommand = cmd
        dt = New DataTable
        adp.Fill(dt)
        DataGridView1.DataSource = dt
        MsgBox("CLEARED...")
        refresh()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            'if searchbox is empty
            If ComboBox2.Text = Nothing Then
                Me.ComboBox2.BackColor = Color.FromArgb(255, 192, 255)
                If MsgBox("Enter ID to delete.", MsgBoxStyle.OkOnly) = MsgBoxResult.Ok Then
                    Me.ComboBox2.BackColor = Color.White
                End If

            Else

                cmd.CommandText = "DELETE FROM RECORD WHERE ID='" & ComboBox2.Text & "';"
                cmd.ExecuteNonQuery()
                adp.SelectCommand = cmd
                dt = New DataTable
                adp.Fill(dt)
                DataGridView1.DataSource = dt
                MsgBox("Deleted!...")
                refresh()
            End If


        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmmain.Show()
        Me.Close()
    End Sub
End Class