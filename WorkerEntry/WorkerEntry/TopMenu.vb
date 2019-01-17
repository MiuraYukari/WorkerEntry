Public Class TopMenu

    '=======メンバ変数=======

    '姓データ
    Public LastName As String
    '名データ
    Public FirstName As String
    '生年月日データ
    Public Birth As String
    '従業員番号データ
    Public Number As String
    '性別データ
    Public GenderResult As String
    '職種データ
    Public Job As String

    'MemberProperty型のリスト定義 + インスタンス生成
    Public MemberProperty As New List(Of MemberProperty)

    ''' <summary>
    ''' 従業員登録画面を開く
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EntryPageLinkButton_Click(sender As Object, e As EventArgs) Handles EntryPageLinkButton.Click

        '従業員登録画面を開く
        Dim WindowEntryPage As New EntryPage()
        WindowEntryPage.ShowDialog(Me)
        WindowEntryPage.Dispose()

    End Sub

    ''' <summary>
    ''' 従業員一覧画面を開く
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ListPageLinkButton_Click(sender As Object, e As EventArgs) Handles ListPageLinkButton.Click

        '従業員一覧画面を開く
        Dim WindowEntryPage As New ListPage()
        WindowEntryPage.ShowDialog(Me)
        WindowEntryPage.Dispose()

    End Sub

End Class
