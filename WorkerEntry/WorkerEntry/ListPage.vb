Public Class ListPage

    'TopMenuのインスタンスを生成
    Public TopMenu As New TopMenu

    Private Sub ListPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = WorkerEntry.TopMenu.Job
    End Sub
End Class