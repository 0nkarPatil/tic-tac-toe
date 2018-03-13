Public Class Form1
    Dim turn As Boolean = True
    Dim turn_count As Integer = 0
    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.Click, A2.Click, A3.Click, C3.Click, C2.Click, C1.Click, B3.Click, B2.Click, B1.Click
        Dim bttn As Button = sender
        Dim againstcomp As Boolean = True
        If (turn) Then
            bttn.Text = "X"
        Else
            bttn.Text = "O"
        End If
        turn = Not turn
        bttn.Enabled = False
        turn_count = turn_count + 1
        CheckBo()
        If (Not turn And againstcomp) Then
            computer_make_move()
        End If
    End Sub
    Private Function CheckBo()
        Dim winner As Boolean = False
        Dim ans As String
        If ((A1.Text = A2.Text) And (A2.Text = A3.Text) And (Not A1.Enabled)) Then
            winner = True
        ElseIf ((B1.Text = B2.Text) And (B2.Text = B3.Text) And (Not B1.Enabled)) Then
            winner = True
        ElseIf ((C1.Text = C2.Text) And (C2.Text = C3.Text) And (Not C1.Enabled)) Then
            winner = True
        ElseIf ((A1.Text = B1.Text) And (B1.Text = C1.Text) And (Not A1.Enabled)) Then
            winner = True
        ElseIf ((A2.Text = B2.Text) And (B2.Text = C2.Text) And (Not A2.Enabled)) Then
            winner = True
        ElseIf ((A3.Text = B3.Text) And (B3.Text = C3.Text) And (Not A3.Enabled)) Then
            winner = True
        ElseIf ((A1.Text = B2.Text) And (B2.Text = C3.Text) And (Not A1.Enabled)) Then
            winner = True
        ElseIf ((A3.Text = B2.Text) And (B2.Text = C1.Text) And (Not C1.Enabled)) Then
            winner = True
        End If
        If (winner) Then
            disable()
            If (turn) Then
                ans = "O"
            Else
                ans = "X"
            End If
            MessageBox.Show(ans + " is winner")
        ElseIf turn_count = 9 Then
            MessageBox.Show("Draw!! No one wins")
        End If

    End Function

    Private Function disable()
        Dim c As Control
        Dim btn As Button
        Try
            For Each c In Controls
                btn = c
                btn.Enabled = False
            Next
        Catch
        End Try
    End Function

    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click
        Dim c As Control
        turn = True
        turn_count = 0
        Dim btn As Button
        Try
            For Each c In Controls
                btn = c
                btn.Enabled = True
                btn.Text = ""
            Next
        Catch
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Multiplayer tic tac toe game")
    End Sub

    Private Function computer_make_move()
        Dim move As Button = Nothing
        Move = look_for_win_or_block("O")
        If (move Is Nothing) Then
            move = look_for_win_or_block("X")
            If (move Is Nothing) Then
                move = look_for_corner()
                If (move Is Nothing) Then
                    move = look_for_open_space()
                End If
            End If
        End If
        Try
            move.PerformClick()
        Catch null As NullReferenceException
        End Try
    End Function

    Private Function look_for_open_space() As Button
        Console.WriteLine("Looking for open space")
        Dim b As Button = Nothing
        Dim c As Control
        Try
            For Each c In Controls
                b = c
                If b IsNot Nothing Then
                    If b.Text = "" Then
                        Return b
                    End If
                End If
            Next
        Catch
        End Try
        Return Nothing
    End Function


    Private Function look_for_corner() As Button
        Console.WriteLine("Looking for corner")
        If A1.Text = "O" Then
            If (A3.Text = "") Then
                Return A3
            End If
            If (C3.Text = "") Then
                Return C3
            End If
            If (C1.Text = "") Then
                Return C1
            End If
        End If

        If (A3.Text = "O") Then
            If (A1.Text = "") Then
                Return A1
            End If
            If (C3.Text = "") Then
                Return C3
            End If
            If (C1.Text = "") Then
                Return C1
            End If
        End If

        If (C3.Text = "O") Then

            If (A1.Text = "") Then
                Return A3
            End If
            If (A3.Text = "") Then
                Return A3
            End If
            If (C1.Text = "") Then
                Return C1
            End If
        End If

        If (C1.Text = "O") Then
            If (A1.Text = "") Then
                Return A3
            End If
            If (A3.Text = "") Then
                Return A3
            End If
            If (C3.Text = "") Then
                Return C3
            End If
        End If

        If (A1.Text = "") Then
            Return A1
        End If
        If (A3.Text = "") Then
            Return A3
        End If
        If (C1.Text = "") Then
            Return C1
        End If
        If (C3.Text = "") Then
            Return C3
        End If
        Return Nothing
    End Function

    Private Function look_for_win_or_block(ByVal mark As String) As Button
        Console.WriteLine("Looking for win or block:  " + mark)
        If ((A1.Text = mark) And (A2.Text = mark) And (A3.Text = "")) Then
            Return A3
        End If
        If ((A2.Text = mark) And (A3.Text = mark) And (A1.Text = "")) Then
            Return A1
        End If
        If ((A1.Text = mark) And (A3.Text = mark) And (A2.Text = "")) Then
            Return A2
        End If
        If ((B1.Text = mark) And (B2.Text = mark) And (B3.Text = "")) Then
            Return B3
        End If
        If ((B2.Text = mark) And (B3.Text = mark) And (B1.Text = "")) Then
            Return B1
        End If
        If ((B1.Text = mark) And (B3.Text = mark) And (B2.Text = "")) Then
            Return B2
        End If
        If ((C1.Text = mark) And (C2.Text = mark) And (C3.Text = "")) Then
            Return C3
        End If
        If ((C2.Text = mark) And (C3.Text = mark) And (C1.Text = "")) Then
            Return C1
        End If
        If ((C1.Text = mark) And (C3.Text = mark) And (C1.Text = "")) Then
            Return C2
        End If


        If ((A1.Text = mark) And (B1.Text = mark) And (C1.Text = "")) Then
            Return C1
        End If
        If ((B1.Text = mark) And (C1.Text = mark) And (A1.Text = "")) Then
            Return A1
        End If
        If ((A1.Text = mark) And (C1.Text = mark) And (B1.Text = "")) Then
            Return B1
        End If
        If ((A2.Text = mark) And (B2.Text = mark) And (C2.Text = "")) Then
            Return C2
        End If
        If ((B2.Text = mark) And (C2.Text = mark) And (A2.Text = "")) Then
            Return A2
        End If
        If ((A2.Text = mark) And (C2.Text = mark) And (B2.Text = "")) Then
            Return B2
        End If
        If ((A3.Text = mark) And (B3.Text = mark) And (C3.Text = "")) Then
            Return C3
        End If
        If ((B3.Text = mark) And (C3.Text = mark) And (A3.Text = "")) Then
            Return A3
        End If
        If ((A3.Text = mark) And (C3.Text = mark) And (B3.Text = "")) Then
            Return B3
        End If

        If ((A1.Text = mark) And (B2.Text = mark) And (C3.Text = "")) Then
            Return C3
        End If
        If ((B2.Text = mark) And (C3.Text = mark) And (A1.Text = "")) Then
            Return A1
        End If
        If ((A1.Text = mark) And (C3.Text = mark) And (B2.Text = "")) Then
            Return B2
        End If
        If ((A3.Text = mark) And (B2.Text = mark) And (C1.Text = "")) Then
            Return C1
        End If
        If ((B2.Text = mark) And (C1.Text = mark) And (A3.Text = "")) Then
            Return A3
        End If
        If ((A3.Text = mark) And (C1.Text = mark) And (B2.Text = "")) Then
            Return B2
        End If
            Return Nothing
    End Function

End Class
