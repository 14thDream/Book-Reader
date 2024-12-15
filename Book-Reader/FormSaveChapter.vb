Public Class FormSaveChapter
    Private MainForm As FormMain
    Private BookId As Integer
    Private ChapterNumber As Integer

    Public Sub New(form As FormMain, id As Integer, chapter As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        MainForm = form
        BookId = id
        ChapterNumber = chapter

    End Sub
End Class