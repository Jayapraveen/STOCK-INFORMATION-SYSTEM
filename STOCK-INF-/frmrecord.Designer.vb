<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrecord
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
        Me.StudentIDLabel1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.STOCKDataSet4 = New STOCK_MANAGEMENT_SYSTEM.STOCKDataSet4()
        Me.RECORDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RECORDTableAdapter = New STOCK_MANAGEMENT_SYSTEM.STOCKDataSet4TableAdapters.RECORDTableAdapter()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AMOUNTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STOCKDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECORDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentIDLabel1
        '
        Me.StudentIDLabel1.AutoSize = True
        Me.StudentIDLabel1.Location = New System.Drawing.Point(509, 35)
        Me.StudentIDLabel1.Name = "StudentIDLabel1"
        Me.StudentIDLabel1.Size = New System.Drawing.Size(176, 31)
        Me.StudentIDLabel1.TabIndex = 9
        Me.StudentIDLabel1.Text = "Customer Name:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 37)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.StudentIDLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(745, 130)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales Record"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.RECORDBindingSource
        Me.ComboBox2.DisplayMember = "ID"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(23, 69)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(223, 39)
        Me.ComboBox2.TabIndex = 15
        Me.ComboBox2.ValueMember = "ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.RECORDBindingSource
        Me.ComboBox1.DisplayMember = "UNAME"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(515, 69)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(205, 39)
        Me.ComboBox1.TabIndex = 14
        Me.ComboBox1.ValueMember = "NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 31)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 31)
        Me.Label1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 597)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 37)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(205, 30)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 37)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Filter"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(620, 597)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(112, 37)
        Me.Button8.TabIndex = 35
        Me.Button8.Text = "Delete"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 31)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Product Name"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(570, 30)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(187, 37)
        Me.Button6.TabIndex = 37
        Me.Button6.Text = "Clear all logs"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.UNAMEDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.AMOUNTDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RECORDBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 224)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(745, 347)
        Me.DataGridView1.TabIndex = 38
        '
        'STOCKDataSet4
        '
        Me.STOCKDataSet4.DataSetName = "STOCKDataSet4"
        Me.STOCKDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RECORDBindingSource
        '
        Me.RECORDBindingSource.DataMember = "RECORD"
        Me.RECORDBindingSource.DataSource = Me.STOCKDataSet4
        '
        'RECORDTableAdapter
        '
        Me.RECORDTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'UNAMEDataGridViewTextBoxColumn
        '
        Me.UNAMEDataGridViewTextBoxColumn.DataPropertyName = "UNAME"
        Me.UNAMEDataGridViewTextBoxColumn.HeaderText = "UNAME"
        Me.UNAMEDataGridViewTextBoxColumn.Name = "UNAMEDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PRODNAME"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PRODNAME"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PURCHASE_DATE"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PURCHASE_DATE"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "QUANTITY"
        Me.DataGridViewTextBoxColumn9.HeaderText = "QUANTITY"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PRICE"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PRICE"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'AMOUNTDataGridViewTextBoxColumn
        '
        Me.AMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT"
        Me.AMOUNTDataGridViewTextBoxColumn.HeaderText = "AMOUNT"
        Me.AMOUNTDataGridViewTextBoxColumn.Name = "AMOUNTDataGridViewTextBoxColumn"
        Me.AMOUNTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmrecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 650)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmrecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALES RECORD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STOCKDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECORDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox


    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents StudentIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
  

    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PURCHASEDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRICEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents STOCKDataSet4 As STOCK_MANAGEMENT_SYSTEM.STOCKDataSet4
    Friend WithEvents RECORDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RECORDTableAdapter As STOCK_MANAGEMENT_SYSTEM.STOCKDataSet4TableAdapters.RECORDTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AMOUNTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
