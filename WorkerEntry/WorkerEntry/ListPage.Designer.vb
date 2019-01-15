<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListPage
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListDataGridView = New System.Windows.Forms.DataGridView()
        Me.NumberColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.ListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListDataGridView
        '
        Me.ListDataGridView.AllowUserToAddRows = False
        Me.ListDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumberColumn, Me.LastNameColumn, Me.FirstNameColumn, Me.AgeColumn, Me.GenderColumn})
        Me.ListDataGridView.GridColor = System.Drawing.Color.Black
        Me.ListDataGridView.Location = New System.Drawing.Point(34, 29)
        Me.ListDataGridView.Name = "ListDataGridView"
        Me.ListDataGridView.RowHeadersVisible = False
        Me.ListDataGridView.RowTemplate.Height = 27
        Me.ListDataGridView.Size = New System.Drawing.Size(805, 501)
        Me.ListDataGridView.TabIndex = 0
        '
        'NumberColumn
        '
        Me.NumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NumberColumn.HeaderText = "従業員番号"
        Me.NumberColumn.Name = "NumberColumn"
        Me.NumberColumn.Width = 150
        '
        'LastNameColumn
        '
        Me.LastNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastNameColumn.HeaderText = "姓"
        Me.LastNameColumn.Name = "LastNameColumn"
        '
        'FirstNameColumn
        '
        Me.FirstNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FirstNameColumn.HeaderText = "名"
        Me.FirstNameColumn.Name = "FirstNameColumn"
        '
        'AgeColumn
        '
        Me.AgeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.AgeColumn.HeaderText = "年齢"
        Me.AgeColumn.Name = "AgeColumn"
        Me.AgeColumn.Width = 80
        '
        'GenderColumn
        '
        Me.GenderColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.GenderColumn.HeaderText = "性別"
        Me.GenderColumn.Name = "GenderColumn"
        Me.GenderColumn.Width = 80
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(191, 571)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(204, 25)
        Me.TextBox1.TabIndex = 1
        '
        'ListPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 644)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListDataGridView)
        Me.Name = "ListPage"
        Me.Text = "従業員一覧画面"
        CType(Me.ListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListDataGridView As DataGridView
    Friend WithEvents NumberColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
End Class
