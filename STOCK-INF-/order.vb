Public Class order

    Private Sub frmstdnt_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        MsgBox("You can only close this window by checking out !")
    End Sub
    Public Sub formenter()
        TextBox1.Focus()
    End Sub
    Public Sub EmptyTxt(ByVal Frm As Form)
        Dim Ctl As Control
        For Each Ctl In Frm.Controls
            If TypeOf Ctl Is TextBox Then Ctl.Text = ""
            If TypeOf Ctl Is GroupBox Then
                Dim Ctl1 As Control
                For Each Ctl1 In Ctl.Controls
                    If TypeOf Ctl1 Is TextBox Then
                        Ctl1.Text = ""
                    End If
                Next
            End If
        Next
    End Sub
    Public Sub refresh()
        cmd.CommandText = "SELECT * FROM CUST;"
        cmd.ExecuteNonQuery()
        adp.SelectCommand = cmd
        dt = New DataTable
        adp.Fill(dt)
        DataGridView1.DataSource = dt

        ComboBox2.DataSource = dt
        TextBox1.Focus()
    End Sub
    Public Sub clear()
        cmd.CommandText = "TRUNCATE table CUST;"
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub IMPORT()
        cmd.CommandText = "SET IDENTITY_INSERT STOCK ON INSERT INTO STOCK (ID,NAME) SELECT ID,NAME FROM STOCK where id not in (select id from STOCK);"
        cmd.ExecuteNonQuery()
        refresh()

    End Sub


  



    Private Sub frmgrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STOCKDataSet5.STOCK' table. You can move, or remove it, as needed.

        Me.STOCKTableAdapter.Fill(Me.STOCKDataSet9.STOCK)
        'TODO: This line of code loads data into the 'STOCKDataSet1.CUST' table. You can move, or remove it, as needed.
        Me.CUSTTableAdapter.Fill(Me.STOCKDataSet1.CUST)
        'TODO: This line of code loads data into the 'STOCKDataSet.CUST' table. You can move, or remove it, as needed.

        

        TextBox1.TextAlign = HorizontalAlignment.Center
        Me.TextBox1.BorderStyle = BorderStyle.FixedSingle

        'Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Me.BackColor = Color.FromArgb(192, 192, 255)
        Me.ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = FlatStyle.Flat
        'buttons properties
        Button1.BackColor = Color.FromArgb(255, 192, 192)
        Button2.BackColor = Color.FromArgb(255, 192, 255)
        Button3.BackColor = Color.FromArgb(255, 192, 255)
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

        For Each item As Control In Me.Controls
            If TypeOf item Is Button Then
                DirectCast(item, Button).FlatStyle = FlatStyle.Flat
                DirectCast(item, Button).Cursor = Cursors.Hand
                DirectCast(item, Button).TabStop = False
            End If
        Next

       
        connect()
        IMPORT()
        clear()
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

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        cmd.CommandText = "SELECT * FROM STOCK;"
        adp.SelectCommand = cmd
        dt = New DataTable
        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        cmd.CommandText = "truncate table CUST;"
        cmd.ExecuteNonQuery()
        adp.SelectCommand = cmd
        dt = New DataTable
        adp.Fill(dt)
        DataGridView1.DataSource = dt
        MsgBox("CLEARED...")
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            'if searchbox is empty
            If ComboBox2.Text = Nothing Then
                Me.ComboBox2.BackColor = Color.FromArgb(255, 192, 255)
                If MsgBox("Enter ID to delete.", MsgBoxStyle.OkOnly) = MsgBoxResult.Ok Then
                    Me.ComboBox2.BackColor = Color.White
                End If

            Else

                cmd.CommandText = "UPDATE STOCK SET QUANTITY= QUANTITY + (SELECT QUANTITY FROM CUST WHERE ID = '" & ComboBox2.Text & "') WHERE NAME = (SELECT NAME FROM CUST WHERE ID = '" & ComboBox2.Text & "');DELETE FROM CUST WHERE ID = '" & ComboBox2.Text & "';"
                cmd.ExecuteNonQuery()
                adp.SelectCommand = cmd
                dt = New DataTable
                adp.Fill(dt)
                DataGridView1.DataSource = dt
                MsgBox("Order Cancelled!...")
                refresh()
            End If

        Catch ex As Exception

        End Try

    End Sub

  

   



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try

        
            If SubjectTextBox.Text = Nothing Then
                Me.SubjectTextBox.BackColor = Color.FromArgb(255, 192, 255)
                If MsgBox("Select Product quantity.", MsgBoxStyle.OkOnly) = MsgBoxResult.Ok Then
                    Me.SubjectTextBox.BackColor = Color.White
                End If


            Else

               

                cmd.CommandText = "SET IDENTITY_INSERT STOCK Off INSERT INTO CUST VALUES ('" & ComboBox1.Text & "','" & ComboBox4.Text & "','" & SubjectTextBox.Text & "','" & ListBox1.Text & "');UPDATE STOCK SET QUANTITY= QUANTITY - '" & SubjectTextBox.Text & "' WHERE NAME = '" & ComboBox1.Text & "';"
                cmd.ExecuteNonQuery()
                MsgBox("Order Placed!...")
                refresh()
                EmptyTxt(Me)
                TextBox1.Focus()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Try
            If ComboBox2.Text = Nothing Then
                Me.ComboBox2.BackColor = Color.FromArgb(255, 192, 255)
                If MsgBox("Selct Product Id.", MsgBoxStyle.OkOnly) = MsgBoxResult.Ok Then
                    Me.ComboBox2.BackColor = Color.White
                End If

            Else
                cmd.CommandText = "UPDATE CUST SET NAME='" & ComboBox1.Text & "',QUANTITY='" & SubjectTextBox.Text & "',MFDDATE='" & ComboBox4.Text & "',PRICE='" & ListBox1.Text & "', WHERE id=" & ComboBox2.Text & ";"
                cmd.ExecuteNonQuery()
                adp.SelectCommand = cmd
                dt = New DataTable
                adp.Fill(dt)
                DataGridView1.DataSource = dt
                MsgBox("Updated!...")
                refresh()
                EmptyTxt(Me)
                TextBox1.Focus()
            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SubjectLabel_Click(sender As Object, e As EventArgs) Handles SubjectLabel.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        cmd.CommandText = "INSERT INTO RECORD(UNAME,PRODNAME,PURCHASE_DATE,QUANTITY,PRICE) SELECT '" & Label4.Text & "',NAME,MFDDATE,QUANTITY,PRICE FROM CUST"
        cmd.ExecuteNonQuery()
        MsgBox("Check Out Complete !")
        refresh()
        EmptyTxt(Me)
        Me.Hide()
        usermain.Show()

    End Sub


    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class