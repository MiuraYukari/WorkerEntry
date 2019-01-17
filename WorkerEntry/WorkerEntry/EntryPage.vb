

Public Class EntryPage

    '=======メンバ変数=======

    '姓データ
    Private _lastName As String
    '名データ
    Private _firstName As String
    '生年月日データ
    Private _birth As String
    '従業員番号データ
    Private _number As Integer
    '性別データ
    Private _genderResult As String
    '職種データ
    Private _job As String

    '=======プロパティ=======

    '姓データ
    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property

    '名データ
    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    '生年月日データ
    Public Property Birth() As String
        Get
            Return _birth
        End Get
        Set(value As String)
            _birth = value
        End Set
    End Property

    '従業員番号データ
    Public Property Number() As Integer
        Get
            Return _number
        End Get
        Set(value As Integer)
            _number = value
        End Set
    End Property

    '性別データ
    Public Property GenderResult() As String
        Get
            Return _genderResult
        End Get
        Set(value As String)
            _genderResult = value
        End Set
    End Property

    '職種データ
    Public Property Job() As String
        Get
            Return _job
        End Get
        Set(value As String)
            _job = value
        End Set
    End Property

    ''' <summary>
    ''' 登録ボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EntryButton_Click(sender As Object, e As EventArgs) Handles EntryButton.Click

        'エラーチェック
        If ErrorMessage() = False Then
            Exit Sub
        End If

        '姓データ
        WorkerEntry.TopMenu.LastName = StrLastName()

        '名データ
        WorkerEntry.TopMenu.FirstName = StrFirstName()

        '生年月日データ
        WorkerEntry.TopMenu.Birth = StrBirth()

        '従業員番号
        WorkerEntry.TopMenu.Number = MemberNumber()

        '性別データ
        WorkerEntry.TopMenu.GenderResult = Gender()

        '職種データ
        WorkerEntry.TopMenu.Job = JobType()

        '登録完了メッセージを表示
        MessageBox.Show("登録が完了しました。" & Environment.NewLine &
                        "従業員番号：" & _number & Environment.NewLine &
                        "氏名：" & _lastName & "" & _firstName & Environment.NewLine &
                        "生年月日：" & _birth & Environment.NewLine &
                        "性別：" & _genderResult & Environment.NewLine &
                        "職種：" & _job & Environment.NewLine)

        'DataList(Ln, Fn, Era, Birth, SelectNumber, GenderJudge, Job)

        '次の従業員番号を表示する
        'If AfterDisplay() = True Then

        Dim Num As Integer
        Dim PlusNumber As Integer
        Dim OutNumber As String

        '現在Labelに表示されている従業員番号を代入し、1足す
        OutNumber = NumberAddLabel.Text
        '従業員番号をStringからIntegerに変換
        If Integer.TryParse(OutNumber, Num) = True Then
            '従業員番号+1
            Num = OutNumber
            Num += 1
            PlusNumber = Num
            'IntegerからStringに変換
            OutNumber = String.Format("{0:0000}", PlusNumber)
            '1足した従業員番号をLabelに表示
            NumberAddLabel.Text = OutNumber
        End If

        'End If

        AfterDisplay()

    End Sub

    'Private Function DataList(Ln As String, Fn As String, Era As String, Birth As String, SelectNumber As String, GenderJudge As String, Job As String) As Boolean

    '    '登録された従業員情報を配列に入れる
    '    WorkerData = {Ln, Fn, Era, Birth, SelectNumber, GenderJudge, Job}
    '    ''一行ずつ配列に入れる
    '    'Dim ArData As New ArrayList(WorkerData)

    '    Return True

    'End Function

    ''' <summary>
    ''' 登録完了後の画面表示処理
    ''' </summary>
    Private Sub AfterDisplay()

        '入力された各項目をリセットする
        LastNameBox.ResetText()
        FirstNameBox.ResetText()
        JpCalComboBox.ResetText()
        BirthMaskedBox.ResetText()
        JobComboBox.ResetText()

    End Sub

    ''' <summary>
    ''' 姓入力処理
    ''' </summary>
    ''' <returns></returns>
    Private Function StrLastName() As String

        Dim Ln As String
        Ln = LastNameBox.Text

        '姓に入力されたデータ
        Ln.Substring(0)
        'テキストボックスに表示
        Dim strLn As String = Ln
        LastNameBox.Text = strLn
        _lastName = strLn
        Return _lastName

    End Function

    ''' <summary>
    ''' 名入力処理
    ''' </summary>
    ''' <returns></returns>
    Private Function StrFirstName() As String

        Dim Fn As String
        Fn = FirstNameBox.Text

        '名に入力されたデータ
        Fn.Substring(0)
        'テキストボックスに表示
        Dim strFn As String = Fn
        FirstNameBox.Text = strFn
        _firstName = FirstNameBox.Text
        Return strFn

    End Function

    ''' <summary>
    ''' 生年月日処理
    ''' </summary>
    ''' <returns></returns>
    Private Function StrBirth() As String

        'Dim Era As String
        Dim BirthDay As String

        'Era = JpCalComboBox.Text
        BirthDay = BirthMaskedBox.Text

        '元号
        Dim dtEra As String
        dtEra = JpCalComboBox.SelectedItem
        '和暦年
        Dim dtYear As String
        dtYear = BirthDay.Substring(0, 2)
        '月
        Dim dtMonth As String
        dtMonth = BirthDay.Substring(3, 2)
        '日
        Dim dtDay As String
        dtDay = BirthDay.Substring(6, 2)
        '年/月/日
        Dim dtBirth As String = dtYear & "/" & dtMonth & "/" & dtDay & "/"
        '元号/年/月/日
        Dim dtEraBirth As String = dtEra & dtYear & "年" & dtMonth & "月" & dtDay & "日"

        '入力した生年月日をテキストボックスに表示
        JpCalComboBox.Text = dtEra
        BirthMaskedBox.Text = dtBirth

        'ja-JPカルチャで、現地時間として、文字列をDateTime値に変換する
        Dim ci As New System.Globalization.CultureInfo("ja-JP")

        Dim dt As DateTime = DateTime.Parse(dtEraBirth, ci,
        System.Globalization.DateTimeStyles.AssumeLocal)

        '和暦→西暦に変換
        'Dim dt As DateTime
        'DateTime.TryParse(dtEraBirth, dt)

        _birth = dt
        Return _birth
        'Return dtBirth

    End Function

    ''' <summary>
    ''' 従業員番号採番
    ''' </summary>
    ''' <returns></returns>
    Private Function MemberNumber() As String

        '受け取った従業員番号
        Dim Num As Integer
        '従業員番号+1
        ''Dim PlusNumber As Integer
        '採番した従業員番号
        Dim OutNumber As String
        OutNumber = NumberAddLabel.Text

        'NumberAddLabelに表示されている従業員番号を受け取る
        If Integer.TryParse(OutNumber, Num) Then
            '受け取った従業員番号に1足す
            'Number += 1
            'PlusNumber = Number
            '従業員番号を4桁で表示する
            OutNumber = String.Format("{0:0000}", Num)
            'Labelに代入する
            NumberAddLabel.Text = OutNumber
            Return OutNumber
        End If

        Return False

    End Function

    ''' <summary>
    ''' 性別処理
    ''' </summary>
    ''' <returns></returns>
    Private Function Gender() As String

        If MenRadioButton.Checked = True Then
            _genderResult = MenRadioButton.Text
            Return _genderResult
        ElseIf LadyRadioButton.Checked = True Then
            _genderResult = LadyRadioButton.Text
            Return _genderResult
        End If

        Return ""

    End Function

    ''' <summary>
    ''' 年号 コンボボックスを開く
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub JpCalComboBox_DropDown(sender As Object, e As EventArgs) Handles JpCalComboBox.DropDown

        'Comboboxの項目をクリアする
        JpCalComboBox.Items.Clear()

        'Comboboxに項目を追加する
        Dim strEraName() As String = {"", "大正", "昭和", "平成"}
        Dim i As String

        For Each i In strEraName
            JpCalComboBox.Items.Add(i)
        Next

    End Sub

    ''' <summary>
    ''' エラーメッセージ
    ''' </summary>
    ''' <returns></returns>
    Private Function ErrorMessage() As Boolean

        '性別
        '男性 女性どちらにもチェックが入っていなかった場合、エラーメッセージを表示する
        If MenRadioButton.Checked = False And
                LadyRadioButton.Checked = False Then
            MessageBox.Show("性別にチェックを入れてください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        '名前
        If LastNameBox.Text = Nothing Then
            MessageBox.Show("姓を入力して下さい", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf FirstNameBox.Text = Nothing Then
            MessageBox.Show("名を入力して下さい", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True

    End Function

    ''' <summary>
    ''' 職種 コンボボックスを開く
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub JobComboBox_DropDown(sender As Object, e As EventArgs) Handles JobComboBox.DropDown

        'コンボボックスの項目をクリアする
        JobComboBox.Items.Clear()

        '職種コードをコンボボックスに追加する
        Dim JobCode() As String = {"営業職", "事務職", "経理職", "開発職"}
        Dim i As String

        For Each i In JobCode
            JobComboBox.Items.Add(i)
        Next

    End Sub

    ''' <summary>
    ''' 職種名
    ''' </summary>
    ''' <returns></returns>
    Private Function JobType() As String

        'コンボボックスで選択した項目を受け取る
        '職種ID
        Dim JobId As String
        JobId = JobComboBox.SelectedItem

        Select Case JobId
            Case "営業職"
                _job = "営業職"
                Return _job
            Case "事務職"
                _job = "事務職"
                Return _job
            Case "経理職"
                _job = "経理職"
                Return _job
            Case "開発職"
                _job = "開発職"
                Return _job
        End Select

        Return ""

    End Function

    'Private Sub ReferenceButton_Click(sender As Object, e As EventArgs) Handles ReferenceButton.Click

    '    Dim f As New ListPage
    '    f.ShowDialog(Me)
    '    f.Dispose()

    '    MsgBox(ArData)

    'End Sub
End Class