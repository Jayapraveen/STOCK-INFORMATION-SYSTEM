<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmgrades
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StudentIDLabel = New System.Windows.Forms.Label()
        Me.SubjectLabel = New System.Windows.Forms.Label()
        Me.AssessmentDateLabel = New System.Windows.Forms.Label()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SubjectTextBox = New System.Windows.Forms.TextBox()
        Me.AssessmentDateTextBox = New System.Windows.Forms.TextBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AMOUNTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOCKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STOCKDataSet3 = New STOCK_MANAGEMENT_SYSTEM.STOCKDataSet3()
        Me.STOCKTableAdapter = New STOCK_MANAGEMENT_SYSTEM.STOCKDataSet3TableAdapters.STOCKTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STOCKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STOCKDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentIDLabel
        '
        Me.StudentIDLabel.AutoSize = True
        Me.StudentIDLabel.Location = New System.Drawing.Point(24, 71)
        Me.StudentIDLabel.Name = "StudentIDLabel"
        Me.StudentIDLabel.Size = New System.Drawing.Size(65, 26)
        Me.StudentIDLabel.TabIndex = 2
        Me.StudentIDLabel.Text = "Name:"
        '
        'SubjectLabel
        '
        Me.SubjectLabel.AutoSize = True
        Me.SubjectLabel.Location = New System.Drawing.Point(24, 129)
        Me.SubjectLabel.Name = "SubjectLabel"
        Me.SubjectLabel.Size = New System.Drawing.Size(84, 26)
        Me.SubjectLabel.TabIndex = 4
        Me.SubjectLabel.Text = "Quantity:"
        '
        'AssessmentDateLabel
        '
        Me.AssessmentDateLabel.AutoSize = True
        Me.AssessmentDateLabel.Location = New System.Drawing.Point(24, 182)
        Me.AssessmentDateLabel.Name = "AssessmentDateLabel"
        Me.AssessmentDateLabel.Size = New System.Drawing.Size(94, 26)
        Me.AssessmentDateLabel.TabIndex = 6
        Me.AssessmentDateLabel.Text = "MFDDate:"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(356, 36)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(71, 26)
        Me.GradeLabel.TabIndex = 8
        Me.GradeLabel.Text = "PRICE:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 32)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search by Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.StudentIDLabel)
        Me.GroupBox1.Controls.Add(Me.SubjectLabel)
        Me.GroupBox1.Controls.Add(Me.SubjectTextBox)
        Me.GroupBox1.Controls.Add(Me.AssessmentDateLabel)
        Me.GroupBox1.Controls.Add(Me.AssessmentDateTextBox)
        Me.GroupBox1.Controls.Add(Me.GradeLabel)
        Me.GroupBox1.Controls.Add(Me.GradeTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 259)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Order details"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(30, 99)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(175, 32)
        Me.TextBox2.TabIndex = 19
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(294, 116)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(326, 44)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "Show Lesser Quantity Products"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DisplayMember = "ID"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(69, 39)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(136, 34)
        Me.ComboBox2.TabIndex = 17
        Me.ComboBox2.ValueMember = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 26)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "ID"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(221, 212)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(117, 26)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Today's Date"
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.Location = New System.Drawing.Point(28, 152)
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.Size = New System.Drawing.Size(177, 32)
        Me.SubjectTextBox.TabIndex = 5
        '
        'AssessmentDateTextBox
        '
        Me.AssessmentDateTextBox.Location = New System.Drawing.Point(28, 207)
        Me.AssessmentDateTextBox.Name = "AssessmentDateTextBox"
        Me.AssessmentDateTextBox.Size = New System.Drawing.Size(177, 32)
        Me.AssessmentDateTextBox.TabIndex = 7
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(458, 36)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(162, 32)
        Me.GradeTextBox.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(516, 551)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(154, 37)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Cancel Order"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(225, 551)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(241, 37)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Make Order Changes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 551)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 37)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Place Order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(203, 30)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 37)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "Filter"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(552, 30)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(118, 37)
        Me.Button6.TabIndex = 37
        Me.Button6.Text = "Erase Entry"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.AMOUNTDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.STOCKBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 332)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(654, 194)
        Me.DataGridView1.TabIndex = 39
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NAME"
        Me.DataGridViewTextBoxColumn8.HeaderText = "NAME"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "MFDDATE"
        Me.DataGridViewTextBoxColumn9.HeaderText = "MFDDATE"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "QUANTITY"
        Me.DataGridViewTextBoxColumn10.HeaderText = "QUANTITY"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PRICE"
        Me.DataGridViewTextBoxColumn11.HeaderText = "PRICE"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'AMOUNTDataGridViewTextBoxColumn
        '
        Me.AMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT"
        Me.AMOUNTDataGridViewTextBoxColumn.HeaderText = "AMOUNT"
        Me.AMOUNTDataGridViewTextBoxColumn.Name = "AMOUNTDataGridViewTextBoxColumn"
        Me.AMOUNTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'STOCKBindingSource
        '
        Me.STOCKBindingSource.DataMember = "STOCK"
        Me.STOCKBindingSource.DataSource = Me.STOCKDataSet3
        '
        'STOCKDataSet3
        '
        Me.STOCKDataSet3.DataSetName = "STOCKDataSet3"
        Me.STOCKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STOCKTableAdapter
        '
        Me.STOCKTableAdapter.ClearBeforeFill = True
        '
        'frmgrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 600)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmgrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ORDER PRODUCTS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STOCKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STOCKDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GradeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AssessmentDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GradeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents StudentIDLabel As System.Windows.Forms.Label
    Friend WithEvents SubjectLabel As System.Windows.Forms.Label
    Friend WithEvents AssessmentDateLabel As System.Windows.Forms.Label
    Friend WithEvents GradeLabel As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox


    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MFDDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRICEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STOCKDataSet3 As STOCK_MANAGEMENT_SYSTEM.STOCKDataSet3
    Friend WithEvents STOCKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STOCKTableAdapter As STOCK_MANAGEMENT_SYSTEM.STOCKDataSet3TableAdapters.STOCKTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AMOUNTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
