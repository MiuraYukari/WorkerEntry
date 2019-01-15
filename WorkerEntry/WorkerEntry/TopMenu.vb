Public Class Menu

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

        'メニュー画面を閉じる
        Me.Close()

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

        'メニュー画面を閉じる
        Me.Close()

    End Sub

End Class
