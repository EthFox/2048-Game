Public Class frm2048
    Friend GUIarray(3, 3) As Integer
    Dim GUI_Dict As New Dictionary(Of String, Control)
    Dim GameOver As Boolean
    Dim Score As Double
    Dim HighScoreReader As IO.StreamReader
    Dim path As String = My.Application.Info.DirectoryPath
    Private Sub frm2048_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If IO.File.Exists(path & "\HighScore.txt") Then ' if there is a previous high score, show it
            HighScoreReader = IO.File.OpenText(path & "\HighScore.txt")
            lblHighScore.Text = HighScoreReader.ReadLine()
            HighScoreReader.Close()
        End If

        GUI_Dict.Add("x1y1", x1y1)
        GUI_Dict.Add("x2y1", x2y1)
        GUI_Dict.Add("x3y1", x3y1)
        GUI_Dict.Add("x4y1", x4y1)
        GUI_Dict.Add("x1y2", x1y2)
        GUI_Dict.Add("x2y2", x2y2)
        GUI_Dict.Add("x3y2", x3y2)
        GUI_Dict.Add("x4y2", x4y2)
        GUI_Dict.Add("x1y3", x1y3)
        GUI_Dict.Add("x2y3", x2y3)
        GUI_Dict.Add("x3y3", x3y3)
        GUI_Dict.Add("x4y3", x4y3)
        GUI_Dict.Add("x1y4", x1y4)
        GUI_Dict.Add("x2y4", x2y4)
        GUI_Dict.Add("x3y4", x3y4)
        GUI_Dict.Add("x4y4", x4y4) ' dictionary allows use of cancatenation when referencing objects

        Dim RandomNumber As Integer
        Dim RandomNumber2 As Integer

        RandomNumber = Int((3 - 0 + 1) * Rnd() + 0) ' random coordinates for starting number
        Randomize()
        RandomNumber2 = Int((3 - 0 + 1) * Rnd() + 0)
        Randomize()

        GUIarray(RandomNumber, RandomNumber2) = 2

        UpdateGUI()

    End Sub

    Private Sub frm2048_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyPressed As Char
        KeyPressed = e.KeyChar

        If GameOver = False Then
            If KeyPressed = "w" OrElse KeyPressed = "a" OrElse KeyPressed = "s" OrElse KeyPressed = "d" Then
                Select Case KeyPressed ' change array values based on key pressed
                    Case "w"
                        For col As Integer = 0 To 3
                            For row As Integer = 1 To 3 ' for all applicable squares...
                                If GUIarray(row, col) > 0 Then ' if its not blank...
                                    Dim row_counter As Integer = row - 1 ' check square one ahead
                                    Do While row_counter >= 0 AndAlso (GUIarray(row_counter, col) = GUIarray(row, col) OrElse GUIarray(row_counter, col) = 0)
                                        If GUIarray(row_counter, col) = 0 Then ' if next square is empty
                                            If row_counter <> 0 Then ' if its not at the wall
                                                row_counter -= 1 ' check next square
                                            Else ' if it is at the wall
                                                GUIarray(row_counter, col) = GUIarray(row, col) ' move to selected square
                                                GUIarray(row, col) = 0
                                                row_counter -= 1
                                            End If
                                        Else ' else it can merge
                                            GUIarray(row_counter, col) *= 2 ' merge
                                            GUIarray(row, col) = 0
                                            Score += GUIarray(row_counter, col)
                                            lblScore.Text = Score
                                        End If
                                    Loop
                                    If row_counter >= 0 AndAlso GUIarray(row_counter, col) <> GUIarray(row, col) AndAlso GUIarray(row_counter, col) <> 0 Then ' if it ran into another number it can'y merge with...
                                        GUIarray(row_counter + 1, col) = GUIarray(row, col) ' move square to one before the blacking square
                                        If row_counter + 1 <> row Then
                                            GUIarray(row, col) = 0 ' delete previous position if it moved
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Case "a"
                        For row As Integer = 0 To 3
                            For col As Integer = 1 To 3
                                If GUIarray(row, col) > 0 Then
                                    Dim col_counter As Integer = col - 1
                                    Do While col_counter >= 0 AndAlso (GUIarray(row, col_counter) = GUIarray(row, col) OrElse GUIarray(row, col_counter) = 0)
                                        If GUIarray(row, col_counter) = 0 Then
                                            If col_counter <> 0 Then
                                                col_counter -= 1
                                            Else
                                                GUIarray(row, col_counter) = GUIarray(row, col)
                                                GUIarray(row, col) = 0
                                                col_counter -= 1
                                            End If
                                        Else
                                            GUIarray(row, col_counter) *= 2
                                            GUIarray(row, col) = 0
                                            Score += GUIarray(row, col_counter)
                                            lblScore.Text = Score
                                        End If
                                    Loop
                                    If col_counter >= 0 AndAlso GUIarray(row, col_counter) <> GUIarray(row, col) AndAlso GUIarray(row, col_counter) <> 0 Then ' if there another number in the way, move to one before it
                                        GUIarray(row, col_counter + 1) = GUIarray(row, col)
                                        If col_counter + 1 <> col Then ' as long as it moved
                                            GUIarray(row, col) = 0
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Case "s"
                        For col As Integer = 0 To 3
                            For row As Integer = 2 To 0 Step -1
                                If GUIarray(row, col) > 0 Then
                                    Dim row_counter As Integer = row + 1
                                    Do While row_counter <= 3 AndAlso (GUIarray(row_counter, col) = GUIarray(row, col) OrElse GUIarray(row_counter, col) = 0)
                                        If GUIarray(row_counter, col) = 0 Then
                                            If row_counter <> 3 Then
                                                row_counter += 1
                                            Else
                                                GUIarray(row_counter, col) = GUIarray(row, col)
                                                GUIarray(row, col) = 0
                                                row_counter += 1
                                            End If
                                        Else
                                            GUIarray(row_counter, col) *= 2
                                            GUIarray(row, col) = 0
                                            Score += GUIarray(row_counter, col)
                                            lblScore.Text = Score
                                        End If
                                    Loop
                                    If row_counter <= 3 AndAlso GUIarray(row_counter, col) <> GUIarray(row, col) AndAlso GUIarray(row_counter, col) <> 0 Then
                                        GUIarray(row_counter - 1, col) = GUIarray(row, col)
                                        If row_counter - 1 <> row Then
                                            GUIarray(row, col) = 0
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Case "d"
                        For row As Integer = 3 To 0 Step -1
                            For col As Integer = 2 To 0 Step -1
                                If GUIarray(row, col) > 0 Then
                                    Dim col_counter As Integer = col + 1
                                    Do While col_counter <= 3 AndAlso (GUIarray(row, col_counter) = GUIarray(row, col) OrElse GUIarray(row, col_counter) = 0)
                                        If GUIarray(row, col_counter) = 0 Then
                                            If col_counter <> 3 Then
                                                col_counter += 1
                                            Else
                                                GUIarray(row, col_counter) = GUIarray(row, col)
                                                GUIarray(row, col) = 0
                                                col_counter += 1
                                            End If
                                        Else
                                            GUIarray(row, col_counter) *= 2
                                            GUIarray(row, col) = 0
                                            Score += GUIarray(row, col_counter)
                                            lblScore.Text = Score
                                        End If
                                    Loop
                                    If col_counter <= 3 AndAlso GUIarray(row, col_counter) <> GUIarray(row, col) AndAlso GUIarray(row, col_counter) <> 0 Then ' if there another number in the way, move to one before it
                                        GUIarray(row, col_counter - 1) = GUIarray(row, col)
                                        If col_counter - 1 <> col Then ' as long as it moved
                                            GUIarray(row, col) = 0
                                        End If
                                    End If
                                End If
                            Next
                        Next
                End Select


                If IsNumeric(lblHighScore.Text) AndAlso CDbl(lblHighScore.Text) < Score Then
                    Dim HighScoreWriter As New IO.StreamWriter(path & "\HighScore.txt") ' access high score file or generate a new one if one doesnt already exist
                    lblHighScore.Text = Score
                    HighScoreWriter.WriteLine(Score)
                    HighScoreWriter.Close()
                End If


                Dim BlankSpaces() As Point
                Dim BlankCounter As Integer

                For row As Integer = 0 To 3
                    For col As Integer = 0 To 3
                        If GUIarray(row, col) = 0 Then ' get a list of all of the open spaces
                            ReDim Preserve BlankSpaces(BlankCounter)
                            BlankSpaces(BlankCounter) = New Point(row, col)
                            BlankCounter += 1
                        End If
                    Next
                Next
                If BlankSpaces Is Nothing Then
                    MsgBox("Game Over, Please Try Again", MsgBoxStyle.Exclamation, "Game Over!")
                Else
                    Dim RandRow As Integer
                    Dim RandCol As Integer
                    Dim RandomNumber As Integer
                    Dim RandomNumber2 As Integer

                    Randomize()
                    RandomNumber = Int((BlankSpaces.GetUpperBound(0) - 0 + 1) * Rnd() + 0) ' pick a random empty space...

                    RandRow = BlankSpaces(RandomNumber).X
                    RandCol = BlankSpaces(RandomNumber).Y

                    Randomize()
                    RandomNumber2 = Int((10 - 1 + 1) * Rnd() + 1) ' and change its value, get random number between 1 to 10
                    If RandomNumber2 < 10 Then
                        GUIarray(RandRow, RandCol) = 2
                    Else
                        GUIarray(RandRow, RandCol) = 4 ' 10% chance of new number being a 4 instead of a 2
                    End If

                    UpdateGUI()
                End If
                For row As Integer = 0 To 3
                    For col As Integer = 0 To 3
                        If GUIarray(row, col) = 2048 Then
                            MsgBox("Congrats! You win!", MsgBoxStyle.Information, "WIN")
                            GameOver = True
                        End If
                    Next
                Next
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        GameOver = False
        Score = 0
        lblScore.Text = "0"

        For row As Integer = 0 To 3
            For col As Integer = 0 To 3
                GUIarray(row, col) = 0
            Next
        Next

        Dim RandomNumber As Integer
        Dim RandomNumber2 As Integer

        RandomNumber = Int((3 - 0 + 1) * Rnd() + 0)
        Randomize()
        RandomNumber2 = Int((3 - 0 + 1) * Rnd() + 0)
        Randomize()

        GUIarray(RandomNumber, RandomNumber2) = 2

        UpdateGUI()

        DummyLabel.Focus()
    End Sub

    Private Sub UpdateGUI()
        For row As Integer = 1 To 4 ' adjust GUI to match changed values in array
            For col As Integer = 1 To 4
                Select Case GUIarray(row - 1, col - 1)
                    Case 0
                        GUI_Dict("x" & col & "y" & row).BackgroundImage = Nothing
                    Case 2
                        GUI_Dict("x" & col & "y" & row).BackgroundImage = _2048_Game.My.Resources.Resources._2048_2
                    Case 4
                        GUI_Dict("x" & col & "y" & row).BackgroundImage = _2048_Game.My.Resources.Resources._2048_4
                    Case 8
                        GUI_Dict("x" & col & "y" & row).BackgroundImage = _2048_Game.My.Resources.Resources._2048_8
                    Case 16
                        GUI_Dict("x" & col & "y" & row).BackgroundImage = _2048_Game.My.Resources.Resources._2048_16
                    Case 32
                        GUI_Dict("x" & col & "y" & row).BackgroundImage = _2048_Game.My.Resources.Resources._2048_32
                    Case 64
                        GUI_Dict("x" & col & "y" & row).BackgroundImage = _2048_Game.My.Resources.Resources._2048_64
                    Case 128
                        GUI_Dict("x" & col & "y" & row).BackgroundImage = _2048_Game.My.Resources.Resources._2048_128
                    Case 256
                        GUI_Dict("x" & col & "y" & row).BackgroundImage = _2048_Game.My.Resources.Resources._2048_256
                    Case 512
                        GUI_Dict("x" & col & "y" & row).BackgroundImage = _2048_Game.My.Resources.Resources._2048_512
                    Case 1024
                        GUI_Dict("x" & col & "y" & row).BackgroundImage = _2048_Game.My.Resources.Resources._2048_1024
                    Case 2048
                        GUI_Dict("x" & col & "y" & row).BackgroundImage = _2048_Game.My.Resources.Resources._2048_2048
                End Select
            Next
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class