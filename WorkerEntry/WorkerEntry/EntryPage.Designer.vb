<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntryPage
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
        Me.NumberLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.JobLabel = New System.Windows.Forms.Label()
        Me.BirthLabel = New System.Windows.Forms.Label()
        Me.GenderLabel = New System.Windows.Forms.Label()
        Me.MenRadioButton = New System.Windows.Forms.RadioButton()
        Me.LadyRadioButton = New System.Windows.Forms.RadioButton()
        Me.BirthMaskedBox = New System.Windows.Forms.MaskedTextBox()
        Me.JobComboBox = New System.Windows.Forms.ComboBox()
        Me.LastNameBox = New System.Windows.Forms.TextBox()
        Me.FirstNameBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EntryButton = New System.Windows.Forms.Button()
        Me.NumberAddLabel = New System.Windows.Forms.Label()
        Me.JpCalComboBox = New System.Windows.Forms.ComboBox()
        Me.ReferenceButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumberLabel
        '
        Me.NumberLabel.AutoSize = True
        Me.NumberLabel.Location = New System.Drawing.Point(63, 63)
        Me.NumberLabel.Name = "NumberLabel"
        Me.NumberLabel.Size = New System.Drawing.Size(98, 18)
        Me.NumberLabel.TabIndex = 0
        Me.NumberLabel.Text = "従業員番号"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(176, 163)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(26, 18)
        Me.LastNameLabel.TabIndex = 1
        Me.LastNameLabel.Text = "姓"
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(505, 163)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(26, 18)
        Me.FirstNameLabel.TabIndex = 2
        Me.FirstNameLabel.Text = "名"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(63, 196)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(44, 18)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "氏名"
        '
        'JobLabel
        '
        Me.JobLabel.AutoSize = True
        Me.JobLabel.Location = New System.Drawing.Point(63, 462)
        Me.JobLabel.Name = "JobLabel"
        Me.JobLabel.Size = New System.Drawing.Size(44, 18)
        Me.JobLabel.TabIndex = 4
        Me.JobLabel.Text = "職種"
        '
        'BirthLabel
        '
        Me.BirthLabel.AutoSize = True
        Me.BirthLabel.Location = New System.Drawing.Point(63, 329)
        Me.BirthLabel.Name = "BirthLabel"
        Me.BirthLabel.Size = New System.Drawing.Size(80, 18)
        Me.BirthLabel.TabIndex = 5
        Me.BirthLabel.Text = "生年月日"
        '
        'GenderLabel
        '
        Me.GenderLabel.AutoSize = True
        Me.GenderLabel.Location = New System.Drawing.Point(49, 33)
        Me.GenderLabel.Name = "GenderLabel"
        Me.GenderLabel.Size = New System.Drawing.Size(44, 18)
        Me.GenderLabel.TabIndex = 6
        Me.GenderLabel.Text = "性別"
        '
        'MenRadioButton
        '
        Me.MenRadioButton.AutoSize = True
        Me.MenRadioButton.Location = New System.Drawing.Point(52, 88)
        Me.MenRadioButton.Name = "MenRadioButton"
        Me.MenRadioButton.Size = New System.Drawing.Size(69, 22)
        Me.MenRadioButton.TabIndex = 7
        Me.MenRadioButton.TabStop = True
        Me.MenRadioButton.Text = "男性"
        Me.MenRadioButton.UseVisualStyleBackColor = True
        '
        'LadyRadioButton
        '
        Me.LadyRadioButton.AutoSize = True
        Me.LadyRadioButton.Location = New System.Drawing.Point(185, 88)
        Me.LadyRadioButton.Name = "LadyRadioButton"
        Me.LadyRadioButton.Size = New System.Drawing.Size(69, 22)
        Me.LadyRadioButton.TabIndex = 8
        Me.LadyRadioButton.TabStop = True
        Me.LadyRadioButton.Text = "女性"
        Me.LadyRadioButton.UseVisualStyleBackColor = True
        '
        'BirthMaskedBox
        '
        Me.BirthMaskedBox.Location = New System.Drawing.Point(286, 326)
        Me.BirthMaskedBox.Mask = "90年90月90日"
        Me.BirthMaskedBox.Name = "BirthMaskedBox"
        Me.BirthMaskedBox.Size = New System.Drawing.Size(193, 25)
        Me.BirthMaskedBox.TabIndex = 9
        Me.BirthMaskedBox.ValidatingType = GetType(Date)
        '
        'JobComboBox
        '
        Me.JobComboBox.FormattingEnabled = True
        Me.JobComboBox.Location = New System.Drawing.Point(179, 459)
        Me.JobComboBox.Name = "JobComboBox"
        Me.JobComboBox.Size = New System.Drawing.Size(300, 26)
        Me.JobComboBox.TabIndex = 10
        '
        'LastNameBox
        '
        Me.LastNameBox.Location = New System.Drawing.Point(179, 196)
        Me.LastNameBox.Name = "LastNameBox"
        Me.LastNameBox.Size = New System.Drawing.Size(300, 25)
        Me.LastNameBox.TabIndex = 11
        '
        'FirstNameBox
        '
        Me.FirstNameBox.Location = New System.Drawing.Point(508, 196)
        Me.FirstNameBox.Name = "FirstNameBox"
        Me.FirstNameBox.Size = New System.Drawing.Size(300, 25)
        Me.FirstNameBox.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LadyRadioButton)
        Me.Panel1.Controls.Add(Me.MenRadioButton)
        Me.Panel1.Controls.Add(Me.GenderLabel)
        Me.Panel1.Location = New System.Drawing.Point(500, 326)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(308, 159)
        Me.Panel1.TabIndex = 13
        '
        'EntryButton
        '
        Me.EntryButton.Location = New System.Drawing.Point(668, 539)
        Me.EntryButton.Name = "EntryButton"
        Me.EntryButton.Size = New System.Drawing.Size(140, 70)
        Me.EntryButton.TabIndex = 14
        Me.EntryButton.Text = "登録"
        Me.EntryButton.UseVisualStyleBackColor = True
        '
        'NumberAddLabel
        '
        Me.NumberAddLabel.AutoSize = True
        Me.NumberAddLabel.Location = New System.Drawing.Point(176, 63)
        Me.NumberAddLabel.Name = "NumberAddLabel"
        Me.NumberAddLabel.Size = New System.Drawing.Size(44, 18)
        Me.NumberAddLabel.TabIndex = 15
        Me.NumberAddLabel.Text = "0000"
        '
        'JpCalComboBox
        '
        Me.JpCalComboBox.FormattingEnabled = True
        Me.JpCalComboBox.Location = New System.Drawing.Point(179, 325)
        Me.JpCalComboBox.Name = "JpCalComboBox"
        Me.JpCalComboBox.Size = New System.Drawing.Size(101, 26)
        Me.JpCalComboBox.TabIndex = 16
        '
        'ReferenceButton
        '
        Me.ReferenceButton.Location = New System.Drawing.Point(508, 539)
        Me.ReferenceButton.Name = "ReferenceButton"
        Me.ReferenceButton.Size = New System.Drawing.Size(140, 70)
        Me.ReferenceButton.TabIndex = 17
        Me.ReferenceButton.Text = "参照"
        Me.ReferenceButton.UseVisualStyleBackColor = True
        '
        'EntryPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 644)
        Me.Controls.Add(Me.ReferenceButton)
        Me.Controls.Add(Me.JpCalComboBox)
        Me.Controls.Add(Me.NumberAddLabel)
        Me.Controls.Add(Me.EntryButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LastNameLabel)
        Me.Controls.Add(Me.FirstNameBox)
        Me.Controls.Add(Me.LastNameBox)
        Me.Controls.Add(Me.JobComboBox)
        Me.Controls.Add(Me.BirthMaskedBox)
        Me.Controls.Add(Me.BirthLabel)
        Me.Controls.Add(Me.JobLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Controls.Add(Me.NumberLabel)
        Me.Name = "EntryPage"
        Me.Text = "従業員登録画面"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumberLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents JobLabel As Label
    Friend WithEvents BirthLabel As Label
    Friend WithEvents GenderLabel As Label
    Friend WithEvents MenRadioButton As RadioButton
    Friend WithEvents LadyRadioButton As RadioButton
    Friend WithEvents BirthMaskedBox As MaskedTextBox
    Friend WithEvents JobComboBox As ComboBox
    Friend WithEvents LastNameBox As TextBox
    Friend WithEvents FirstNameBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EntryButton As Button
    Friend WithEvents NumberAddLabel As Label
    Friend WithEvents JpCalComboBox As ComboBox
    Friend WithEvents ReferenceButton As Button
End Class
