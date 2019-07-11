Imports WK.Libraries.BootMeUpNS

Public Class MainForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim bootMeUp As New BootMeUp

        bootMeUp.UseAlternativeOnFail = True
        bootMeUp.BootArea = BootMeUp.BootAreas.Registry
        bootMeUp.TargetUser = BootMeUp.TargetUsers.CurrentUser

        bootMeUp.Enabled = True

        If bootMeUp.Successful = True Then
            MsgBox("The program will launch on startup.")
        Else
            MsgBox("There was an issue. Please try launching as Admin.")
        End If

        ' VB: Check If the program was successfully set to boot...
        If bootMeUp.Successful = True Then
            ' Inform user...
        Else

            ' We will use the 'AdministrativeMode' property
            ' to check whether the program was launched
            ' with Admin privileges.
            If bootMeUp.AdministrativeMode = False Then

                ' If the task requires one to run with Admin privileges,
                ' direct the user to do so And complete the action.
                MsgBox("Please try launching as Admin...")

            Else

                ' If true, then there's a serious issue.
                ' Display an Exception message to the user.
                ' You may also direct the user to a webpage to fix it.
                MsgBox("There was an issue: \n" + bootMeUp.Exception.Message)

            End If

        End If

    End Sub

End Class
