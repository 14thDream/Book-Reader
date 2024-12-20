﻿Imports System.Drawing.Text
Imports MySql.Data.MySqlClient

Public Class FormMain
    Public ConnectionString As String = "server=localhost;database=BookReader;userid=root"
    Public BookId As Integer

    Private ChapterNumber As Integer

    Public Sub LoadBooks()
        TableLayoutPanelDashboard.Controls.Clear()
        Using SqlConnection As New MySqlConnection(ConnectionString)
            SqlConnection.Open()
            Dim Command As New MySqlCommand("SELECT Id, Title, ImagePath FROM books", SqlConnection)

            Using Reader = Command.ExecuteReader()
                While Reader.Read
                    Dim Id = Reader.GetInt32("Id")
                    Dim Title = Reader.GetString("Title")
                    Dim ImagePath = Reader.GetString("ImagePath")

                    Dim b As New Book(Me, Id, Title, ImagePath) With {
                        .Dock = DockStyle.Fill
                    }

                    TableLayoutPanelDashboard.Controls.Add(b)
                End While
            End Using

            Dim AddButton = New AddBookButton With {
                .Dock = DockStyle.Fill
            }

            AddHandler AddButton.PictureBoxIcon.Click, AddressOf AddBook
            TableLayoutPanelDashboard.Controls.Add(AddButton)

            SqlConnection.Close()
        End Using
    End Sub
    Public Sub LoadChapters(id As Integer)
        Dim Chapters As New DataTable

        Using SqlConnection As New MySqlConnection(ConnectionString)
            SqlConnection.Open()

            Dim QueryChapters As New MySqlCommand("SELECT Id, ChapterNumber AS Chapter, Title FROM Chapters WHERE BookId = @Id ORDER BY Chapter", SqlConnection)
            QueryChapters.Parameters.AddWithValue("@Id", id)

            Dim DataAdapter As New MySqlDataAdapter With {
                .SelectCommand = QueryChapters
            }

            DataAdapter.Fill(Chapters)

            SqlConnection.Close()
        End Using

        ' The DataSource is first set to nothing to ensure that its properties get reset.
        ' This is to fix a bug caused by the first column slowly disappearing evey time this method is called.
        DataGridViewChapters.DataSource = Nothing
        DataGridViewChapters.DataSource = Chapters

        Dim ColumnChapterId = DataGridViewChapters.Columns.GetFirstColumn(DataGridViewElementStates.Visible)
        ColumnChapterId.Visible = False

        Dim ColumnChapter = DataGridViewChapters.Columns.GetFirstColumn(DataGridViewElementStates.Visible)
        Dim ColumnTitle = DataGridViewChapters.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None)

        ColumnChapter.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        ColumnChapter.SortMode = DataGridViewColumnSortMode.NotSortable
        ColumnTitle.SortMode = DataGridViewColumnSortMode.NotSortable

    End Sub

    Private Function AnyChaptersLeft(isNext As Boolean) As Boolean
        Dim Symbol As String
        If isNext Then
            Symbol = ">"
        Else
            Symbol = "<"
        End If

        Dim ChaptersRemain As Boolean

        Using SqlConnection As New MySqlConnection(ConnectionString)
            SqlConnection.Open()

            Dim Command As New MySqlCommand($"SELECT Content FROM Chapters WHERE BookId = @Id AND ChapterNumber {Symbol} {ChapterNumber}", SqlConnection)
            Command.Parameters.AddWithValue("@Id", BookId)

            Dim Reader = Command.ExecuteReader()
            ChaptersRemain = Reader.Read

            SqlConnection.Close()
        End Using

        Return ChaptersRemain
    End Function

    Private Sub LoadChapterMovementButtons()
        PictureBoxBack.Visible = AnyChaptersLeft(False)
        PictureBoxNext.Visible = AnyChaptersLeft(True)
    End Sub

    Private Sub LoadChapter(id As Integer)
        Using SqlConnection As New MySqlConnection(ConnectionString)
            SqlConnection.Open()

            Dim Command As New MySqlCommand("SELECT Title, Content FROM Chapters WHERE Id = @Id", SqlConnection)
            Command.Parameters.AddWithValue("@Id", id)

            Dim Reader = Command.ExecuteReader()
            Reader.Read()

            LabelChapterNumber.Text = $"{ChapterNumber}."
            LabelChapterTitle.Text = Reader.GetString("Title")
            RichTextBoxChapterContent.Text = Reader.GetString("Content")

            SqlConnection.Close()
        End Using

        LoadChapterMovementButtons()
    End Sub

    Private Sub LoadAdjacentChapter(id As Integer, chapter As Integer, isNext As Boolean)
        Dim Symbol As String
        If isNext Then
            Symbol = ">"
            ChapterNumber += 1
        Else
            Symbol = "<"
            ChapterNumber -= 1
        End If

        Using SqlConnection As New MySqlConnection(ConnectionString)
            SqlConnection.Open()

            Dim Command As New MySqlCommand($"SELECT Title, Content FROM Chapters WHERE BookId = @Id AND ChapterNumber {Symbol} {chapter}", SqlConnection)
            Command.Parameters.AddWithValue("@Id", id)

            Dim Reader = Command.ExecuteReader()
            Reader.Read()

            LabelChapterNumber.Text = $"{ChapterNumber}."
            LabelChapterTitle.Text = Reader.GetString("Title")
            RichTextBoxChapterContent.Text = Reader.GetString("Content")

            SqlConnection.Close()
        End Using

        LoadChapterMovementButtons()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadBooks()
    End Sub


    Private Sub ButtonBackDetails_Click(sender As Object, e As EventArgs) Handles ButtonBackDetails.Click
        PanelDetails.Visible = False
    End Sub

    Private Sub AddBook(sender As Object, e As EventArgs)
        Dim AddBookForm As New FormSaveBook(ConnectionString, Me)
        AddBookForm.Show()
    End Sub

    Private Sub ButtonAddChapter_Click(sender As Object, e As EventArgs) Handles ButtonAddChapter.Click
        Dim LastIndex = DataGridViewChapters.Rows.GetLastRow(DataGridViewElementStates.Visible)
        Dim ChapterNumber = 0
        If DataGridViewChapters.RowCount > 0 Then
            Dim Row = DataGridViewChapters.Rows(LastIndex)
            ChapterNumber = Row.Cells("Chapter").Value
        End If
        Dim SaveChapterForm As New FormSaveChapter(Me, BookId, ChapterNumber, False)
        SaveChapterForm.Show()
    End Sub
    Private Sub EditChapter_Button_Click(sender As Object, e As EventArgs) Handles EditChapter_Button.Click
        Dim SelectedRow = DataGridViewChapters.CurrentRow

        If SelectedRow IsNot Nothing Then
            Try
                Dim id = SelectedRow.Cells("id").Value
                Using SqlConnection As New MySqlConnection(ConnectionString)
                    SqlConnection.Open()
                    Dim Command As New MySqlCommand("SELECT * FROM CHAPTERS WHERE id = @id", SqlConnection)
                    Command.Parameters.AddWithValue("@id", id)
                    Using Reader = Command.ExecuteReader
                        Reader.Read()
                        Dim ChapterNumber = Reader.GetInt32("ChapterNumber")
                        Dim SaveChapterForm As New FormSaveChapter(Me, BookId, ChapterNumber, True)
                        SaveChapterForm.Show()
                    End Using
                    SqlConnection.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Invalid Operation! Chapter Does Not Exist!")
        End If

    End Sub

    Private Sub DeleteChapter_Button_Click(sender As Object, e As EventArgs) Handles DeleteChapter_Button.Click
        Dim SelectedRow = DataGridViewChapters.CurrentRow
        If SelectedRow IsNot Nothing Then
            Dim Id = SelectedRow.Cells("Id").Value
            Using SqlConnection As New MySqlConnection(ConnectionString)
                SqlConnection.Open()
                Dim Command As New MySqlCommand("DELETE FROM CHAPTERS WHERE Id = @ChapterId", SqlConnection)
                Command.Parameters.AddWithValue("@ChapterId", Id)
                Using Reader = Command.ExecuteReader
                    LoadChapters(BookId)
                End Using
                SqlConnection.Close()
            End Using
            RefreshChapterCount()
        Else
            MessageBox.Show("Invalid Operation! Chapter Does Not Exist!")
        End If
    End Sub
    Private Sub RefreshChapterCount()
        For i As Integer = 0 To DataGridViewChapters.RowCount - 1
            Dim CurrentChapterNumber = DataGridViewChapters.Rows(i).Cells("Chapter").Value
            Using SqlConnection As New MySqlConnection(ConnectionString)

                SqlConnection.Open()
                Dim Command As New MySqlCommand("UPDATE CHAPTERS SET ChapterNumber = @NewChapterNumber WHERE BookId = @BookId AND ChapterNumber = @ChapterNumber", SqlConnection)
                Command.Parameters.AddWithValue("@ChapterNumber", CurrentChapterNumber)
                Command.Parameters.AddWithValue("@NewChapterNumber", i + 1)
                Command.Parameters.AddWithValue("@BookId", BookId)
                Command.ExecuteNonQuery()
                SqlConnection.Close()
            End Using
        Next
        LoadChapters(BookId)
    End Sub

    Private Sub ButtonBackChapter_Click(sender As Object, e As EventArgs) Handles ButtonBackChapter.Click
        PanelReadChapter.Visible = False
    End Sub

    Private Sub DataGridViewChapters_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewChapters.CellDoubleClick
        Try
            Dim Row = DataGridViewChapters.Rows(e.RowIndex)
            ChapterNumber = Row.Cells("Chapter").Value

            Dim ChapterId = Row.Cells("Id").Value
            LoadChapter(ChapterId)

            PanelReadChapter.Visible = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBoxBack_Click(sender As Object, e As EventArgs) Handles PictureBoxBack.Click
        LoadAdjacentChapter(BookId, ChapterNumber, False)
    End Sub

    Private Sub PictureBoxNext_Click(sender As Object, e As EventArgs) Handles PictureBoxNext.Click
        LoadAdjacentChapter(BookId, ChapterNumber, True)
    End Sub

    Private Sub PanelReadChapter_Paint(sender As Object, e As PaintEventArgs) Handles PanelReadChapter.Paint

    End Sub



    Private Sub RichTextBoxChapterContent_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxChapterContent.TextChanged

    End Sub

    Private Sub LabelChapterTitle_Click(sender As Object, e As EventArgs) Handles LabelChapterTitle.Click

    End Sub
End Class
