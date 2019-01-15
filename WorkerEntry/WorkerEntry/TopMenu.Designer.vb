<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.EntryPageLinkButton = New System.Windows.Forms.Button()
        Me.ListPageLinkButton = New System.Windows.Forms.Button()
        Me.CsvOutputButton = New System.Windows.Forms.Button()
        Me.CsvInputButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EntryPageLinkButton
        '
        Me.EntryPageLinkButton.Location = New System.Drawing.Point(258, 102)
        Me.EntryPageLinkButton.Name = "EntryPageLinkButton"
        Me.EntryPageLinkButton.Size = New System.Drawing.Size(377, 77)
        Me.EntryPageLinkButton.TabIndex = 0
        Me.EntryPageLinkButton.Text = "従業員登録画面"
        Me.EntryPageLinkButton.UseVisualStyleBackColor = True
        '
        'ListPageLinkButton
        '
        Me.ListPageLinkButton.Location = New System.Drawing.Point(258, 217)
        Me.ListPageLinkButton.Name = "ListPageLinkButton"
        Me.ListPageLinkButton.Size = New System.Drawing.Size(377, 77)
        Me.ListPageLinkButton.TabIndex = 1
        Me.ListPageLinkButton.Text = "従業員一覧画面"
        Me.ListPageLinkButton.UseVisualStyleBackColor = True
        '
        'CsvOutputButton
        '
        Me.CsvOutputButton.Location = New System.Drawing.Point(258, 332)
        Me.CsvOutputButton.Name = "CsvOutputButton"
        Me.CsvOutputButton.Size = New System.Drawing.Size(377, 77)
        Me.CsvOutputButton.TabIndex = 2
        Me.CsvOutputButton.Text = "従業員一覧CSV出力"
        Me.CsvOutputButton.UseVisualStyleBackColor = True
        '
        'CsvInputButton
        '
        Me.CsvInputButton.Location = New System.Drawing.Point(258, 447)
        Me.CsvInputButton.Name = "CsvInputButton"
        Me.CsvInputButton.Size = New System.Drawing.Size(377, 77)
        Me.CsvInputButton.TabIndex = 3
        Me.CsvInputButton.Text = "従業員一覧CSV入力"
        Me.CsvInputButton.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 644)
        Me.Controls.Add(Me.CsvInputButton)
        Me.Controls.Add(Me.CsvOutputButton)
        Me.Controls.Add(Me.ListPageLinkButton)
        Me.Controls.Add(Me.EntryPageLinkButton)
        Me.Name = "Menu"
        Me.Text = "メニュー画面"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EntryPageLinkButton As Button
    Friend WithEvents ListPageLinkButton As Button
    Friend WithEvents CsvOutputButton As Button
    Friend WithEvents CsvInputButton As Button
End Class
