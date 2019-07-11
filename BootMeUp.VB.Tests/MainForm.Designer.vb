<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BootMeUp1 = New WK.Libraries.BootMeUpNS.BootMeUp(Me.components)
        Me.SuspendLayout()
        '
        'BootMeUp1
        '
        Me.BootMeUp1.BootArea = WK.Libraries.BootMeUpNS.BootMeUp.BootAreas.Registry
        Me.BootMeUp1.ContainerControl = Me
        Me.BootMeUp1.Enabled = True
        Me.BootMeUp1.ParentForm = Me
        Me.BootMeUp1.RunWhenDebugging = False
        Me.BootMeUp1.ShortcutOptions.Arguments = Nothing
        Me.BootMeUp1.ShortcutOptions.Hotkey = System.Windows.Forms.Keys.None
        Me.BootMeUp1.Successful = False
        Me.BootMeUp1.Tag = Nothing
        Me.BootMeUp1.TargetUser = WK.Libraries.BootMeUpNS.BootMeUp.TargetUsers.CurrentUser
        Me.BootMeUp1.UseAlternativeOnFail = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BootMeUp1 As WK.Libraries.BootMeUpNS.BootMeUp
End Class
