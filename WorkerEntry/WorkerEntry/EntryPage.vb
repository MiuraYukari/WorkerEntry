

Public Class EntryPage

    Private Sub EntryPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '性別判定結果
    Private GenderResult As String
    '職種名
    Private Job As String

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
        Dim Ln As String
        Ln = LastNameBox.Text
        StrLastName(Ln)

        '名データ
        Dim Fn As String
        Fn = FirstNameBox.Text
        StrFirstName(Fn)

        '生年月日データ
        Dim Era As String
        Dim Birth As String
        Era = JpCalComboBox.Text
        Birth = BirthMaskedBox.Text
        StrBirth(Era, Birth)

        '従業員番号
        Dim SelectNumber As String
        If MemberNumber() = True Then
            SelectNumber = NumberAddLabel.Text
        End If
        SelectNumber = NumberAddLabel.Text

        '性別データ
        Gender()
        Dim GenderJudge As String
        GenderJudge = Gender()

        '職種データ
        Job = JobType()

        '登録完了メッセージを表示
        MessageBox.Show("登録が完了しました。" & Environment.NewLine &
                        "従業員番号：" & SelectNumber & Environment.NewLine &
                        "氏名：" & Ln & "" & Fn & Environment.NewLine &
                        "生年月日：" & Era & Birth & Environment.NewLine &
                        "性別：" & GenderJudge & Environment.NewLine &
                        "職種：" & Job & Environment.NewLine)

        'DataList(Ln, Fn, Era, Birth, SelectNumber, GenderJudge, Job)

        '次の従業員番号を表示する
        'If AfterDisplay() = True Then

        Dim Number As Integer
        Dim PlusNumber As Integer
        Dim OutNumber As String

        '現在Labelに表示されている従業員番号を代入
        OutNumber = NumberAddLabel.Text
        '従業員番号をStringからIntegerに変換
        If Integer.TryParse(OutNumber, Number) = True Then
            '従業員番号+1
            Number = OutNumber
            Number += 1
            PlusNumber = Number
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
    Private Function StrLastName(ByVal Ln As String) As String

        '姓に入力されたデータ
        Ln.Substring(0)
        'テキストボックスに表示
        Dim LastName As String = Ln
        LastNameBox.Text = LastName
        Return LastName

    End Function

    ''' <summary>
    ''' 名入力処理
    ''' </summary>
    ''' <returns></returns>
    Private Function StrFirstName(ByVal Fn As String) As String

        '名に入力されたデータ
        Fn.Substring(0)
        'テキストボックスに表示
        Dim FirstName As String = Fn
        FirstNameBox.Text = FirstName
        Return FirstName

    End Function

    ''' <summary>
    ''' 生年月日処理
    ''' </summary>
    ''' <returns></returns>
    Private Function StrBirth(ByVal Era As String, ByVal Birth As String) As String

        '元号
        Dim dtEra As String
        dtEra = JpCalComboBox.SelectedItem
        '和暦年
        Dim dtYear As String
        dtYear = Birth.Substring(0, 2)
        '月
        Dim dtMonth As String
        dtMonth = Birth.Substring(3, 2)
        '日
        Dim dtDay As String
        dtDay = Birth.Substring(6, 2)
        '年/月/日
        Dim dtBirth As String = dtYear & "年" & dtMonth & "月" & dtDay & "日"
        '元号/年/月/日
        Dim dtEraBirth As String = dtEra & dtYear & "年" & dtMonth & "月" & dtDay & "日"

        '入力した生年月日をテキストボックスに表示
        JpCalComboBox.Text = dtEra
        BirthMaskedBox.Text = dtBirth

        '※※別画面で和暦→西暦に変換して表示※※
        '※※後で処理する※※

        '和暦→西暦に変換
        Dim dt As DateTime
        DateTime.TryParse(dtEraBirth, dt)

        Return dtEra
        Return dtBirth

    End Function

    ''' <summary>
    ''' 従業員番号採番
    ''' </summary>
    ''' <returns></returns>
    Private Function MemberNumber() As Boolean

        ''受け取った従業員番号
        Dim Number As Integer
        ''従業員番号+1
        'Dim PlusNumber As Integer
        '採番した従業員番号
        Dim OutNumber As String
        OutNumber = NumberAddLabel.Text

        'NumberAddLabelに表示されている従業員番号を受け取る
        If Integer.TryParse(OutNumber, Number) Then
            '受け取った従業員番号に1足す
            'Number += 1
            'PlusNumber = Number
            '従業員番号を4桁で表示する
            OutNumber = String.Format("{0:0000}", Number)
            'Labelに代入する
            NumberAddLabel.Text = OutNumber
            Return True
        End If

        Return False

    End Function

    ''' <summary>
    ''' 性別処理
    ''' </summary>
    ''' <returns></returns>
    Private Function Gender() As String

        Dim GenderResult As String

        If MenRadioButton.Checked = True Then
            MenRadioButton.Text = "男性"
            GenderResult = MenRadioButton.Text
            Return GenderResult
        ElseIf LadyRadioButton.Checked = True Then
            LadyRadioButton.Text = "女性"
            GenderResult = LadyRadioButton.Text
            Return GenderResult
        End If

        Return False

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
    Private Sub strJobComboBox_DropDown(sender As Object, e As EventArgs) Handles JobComboBox.DropDown

        'コンボボックスの項目をクリアする
        JobComboBox.Items.Clear()

        '職種コードをコンボボックスに追加する
        Dim JobCode() As Integer = {10, 20, 30, 40}
        Dim i As Integer

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
        Dim JobId As Integer
        Dim JobName As String
        JobId = JobComboBox.SelectedItem

        Select Case JobId
            Case 10
                JobName = "営業職"
                Return JobName
            Case 20
                JobName = "事務職"
                Return JobName
            Case 30
                JobName = "経理職"
                Return JobName
            Case 40
                JobName = "開発職"
                Return JobName
        End Select

        Return False

    End Function

    'Private Sub ReferenceButton_Click(sender As Object, e As EventArgs) Handles ReferenceButton.Click

    '    Dim f As New ListPage
    '    f.ShowDialog(Me)
    '    f.Dispose()

    '    MsgBox(ArData)

    'End Sub
End Class