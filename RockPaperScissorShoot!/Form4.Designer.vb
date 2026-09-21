<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        statusLabel = New Label()
        Label1 = New Label()
        backButton = New Button()
        SuspendLayout()
        ' 
        ' statusLabel
        ' 
        statusLabel.AutoSize = True
        statusLabel.Font = New Font("Sans Serif Collection", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        statusLabel.Location = New Point(419, 9)
        statusLabel.Name = "statusLabel"
        statusLabel.Size = New Size(108, 91)
        statusLabel.TabIndex = 3
        statusLabel.Text = "Rules"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(112, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(752, 476)
        Label1.TabIndex = 4
        Label1.Text = resources.GetString("Label1.Text")
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(12, 525)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 5
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(974, 566)
        Controls.Add(backButton)
        Controls.Add(Label1)
        Controls.Add(statusLabel)
        Name = "Form4"
        Text = "Game"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents statusLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents backButton As Button
End Class
