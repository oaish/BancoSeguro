<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(History))
        Me.HistoryGrid = New System.Windows.Forms.DataGridView()
        Me.DepositLbl = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.PictureBox()
        Me.BancoSeguroDataSet = New BancoSeguro.BancoSeguroDataSet()
        Me.BancoSeguroDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.HistoryGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoSeguroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoSeguroDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HistoryGrid
        '
        Me.HistoryGrid.AutoGenerateColumns = False
        Me.HistoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.HistoryGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.HistoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HistoryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HistoryGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.HistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HistoryGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIDDataGridViewTextBoxColumn, Me.AccNoDataGridViewTextBoxColumn, Me.EmpIDDataGridViewTextBoxColumn, Me.TDateDataGridViewTextBoxColumn, Me.TTypeDataGridViewTextBoxColumn, Me.TAmountDataGridViewTextBoxColumn})
        Me.HistoryGrid.DataMember = "Transactions"
        Me.HistoryGrid.DataSource = Me.BancoSeguroDataSetBindingSource
        Me.HistoryGrid.Location = New System.Drawing.Point(36, 90)
        Me.HistoryGrid.Name = "HistoryGrid"
        Me.HistoryGrid.RowTemplate.Height = 24
        Me.HistoryGrid.Size = New System.Drawing.Size(727, 454)
        Me.HistoryGrid.TabIndex = 0
        '
        'DepositLbl
        '
        Me.DepositLbl.AutoSize = True
        Me.DepositLbl.BackColor = System.Drawing.Color.Transparent
        Me.DepositLbl.Font = New System.Drawing.Font("Agency FB", 30.0!, System.Drawing.FontStyle.Bold)
        Me.DepositLbl.ForeColor = System.Drawing.SystemColors.Window
        Me.DepositLbl.Location = New System.Drawing.Point(25, 26)
        Me.DepositLbl.Name = "DepositLbl"
        Me.DepositLbl.Size = New System.Drawing.Size(372, 61)
        Me.DepositLbl.TabIndex = 5
        Me.DepositLbl.Text = "Transaction History"
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Transparent
        Me.CloseBtn.Image = CType(resources.GetObject("CloseBtn.Image"), System.Drawing.Image)
        Me.CloseBtn.Location = New System.Drawing.Point(718, 39)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(45, 45)
        Me.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseBtn.TabIndex = 20
        Me.CloseBtn.TabStop = False
        '
        'BancoSeguroDataSet
        '
        Me.BancoSeguroDataSet.DataSetName = "BancoSeguroDataSet"
        Me.BancoSeguroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BancoSeguroDataSetBindingSource
        '
        Me.BancoSeguroDataSetBindingSource.DataSource = Me.BancoSeguroDataSet
        Me.BancoSeguroDataSetBindingSource.Position = 0
        '
        'TIDDataGridViewTextBoxColumn
        '
        Me.TIDDataGridViewTextBoxColumn.DataPropertyName = "T_ID"
        Me.TIDDataGridViewTextBoxColumn.HeaderText = "T_ID"
        Me.TIDDataGridViewTextBoxColumn.Name = "TIDDataGridViewTextBoxColumn"
        '
        'AccNoDataGridViewTextBoxColumn
        '
        Me.AccNoDataGridViewTextBoxColumn.DataPropertyName = "Acc_No"
        Me.AccNoDataGridViewTextBoxColumn.HeaderText = "Acc_No"
        Me.AccNoDataGridViewTextBoxColumn.Name = "AccNoDataGridViewTextBoxColumn"
        '
        'EmpIDDataGridViewTextBoxColumn
        '
        Me.EmpIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID"
        Me.EmpIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID"
        Me.EmpIDDataGridViewTextBoxColumn.Name = "EmpIDDataGridViewTextBoxColumn"
        '
        'TDateDataGridViewTextBoxColumn
        '
        Me.TDateDataGridViewTextBoxColumn.DataPropertyName = "T_Date"
        Me.TDateDataGridViewTextBoxColumn.HeaderText = "T_Date"
        Me.TDateDataGridViewTextBoxColumn.Name = "TDateDataGridViewTextBoxColumn"
        '
        'TTypeDataGridViewTextBoxColumn
        '
        Me.TTypeDataGridViewTextBoxColumn.DataPropertyName = "T_Type"
        Me.TTypeDataGridViewTextBoxColumn.HeaderText = "T_Type"
        Me.TTypeDataGridViewTextBoxColumn.Name = "TTypeDataGridViewTextBoxColumn"
        '
        'TAmountDataGridViewTextBoxColumn
        '
        Me.TAmountDataGridViewTextBoxColumn.DataPropertyName = "T_Amount"
        Me.TAmountDataGridViewTextBoxColumn.HeaderText = "T_Amount"
        Me.TAmountDataGridViewTextBoxColumn.Name = "TAmountDataGridViewTextBoxColumn"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 590)
        Me.Panel1.TabIndex = 21
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BackgroundImage = Global.BancoSeguro.My.Resources.Resources.AppBG
        Me.ClientSize = New System.Drawing.Size(800, 590)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.DepositLbl)
        Me.Controls.Add(Me.HistoryGrid)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "History"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History"
        CType(Me.HistoryGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoSeguroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoSeguroDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HistoryGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DepositLbl As System.Windows.Forms.Label
    Friend WithEvents CloseBtn As System.Windows.Forms.PictureBox
    Friend WithEvents TIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BancoSeguroDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BancoSeguroDataSet As BancoSeguro.BancoSeguroDataSet
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
