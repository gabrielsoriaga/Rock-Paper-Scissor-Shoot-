<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Label1 = New Label()
        Label2 = New Label()
        statusLabel = New Label()
        retryButton = New Button()
        backButton = New Button()
        rockGIF = New PictureBox()
        paperGIF = New PictureBox()
        scissorGIF = New PictureBox()
        rockGIFBot = New PictureBox()
        paperGIFBot = New PictureBox()
        scissorGIFBot = New PictureBox()
        rockpaperscissortimer = New Timer(components)
        showStatusTimer = New Timer(components)
        shootTimer = New Timer(components)
        CType(rockGIF, ComponentModel.ISupportInitialize).BeginInit()
        CType(paperGIF, ComponentModel.ISupportInitialize).BeginInit()
        CType(scissorGIF, ComponentModel.ISupportInitialize).BeginInit()
        CType(rockGIFBot, ComponentModel.ISupportInitialize).BeginInit()
        CType(paperGIFBot, ComponentModel.ISupportInitialize).BeginInit()
        CType(scissorGIFBot, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(171, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 102)
        Label1.TabIndex = 0
        Label1.Text = "You"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sans Serif Collection", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(697, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 102)
        Label2.TabIndex = 1
        Label2.Text = "Bot"
        ' 
        ' statusLabel
        ' 
        statusLabel.AutoSize = True
        statusLabel.BackColor = Color.Transparent
        statusLabel.Font = New Font("Sans Serif Collection", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        statusLabel.ForeColor = SystemColors.ActiveCaptionText
        statusLabel.Location = New Point(361, 133)
        statusLabel.Name = "statusLabel"
        statusLabel.Size = New Size(262, 204)
        statusLabel.TabIndex = 2
        statusLabel.Text = "Status"
        statusLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' retryButton
        ' 
        retryButton.Font = New Font("Sans Serif Collection", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        retryButton.Location = New Point(406, 296)
        retryButton.Name = "retryButton"
        retryButton.Size = New Size(161, 58)
        retryButton.TabIndex = 3
        retryButton.Text = "Play Again"
        retryButton.UseVisualStyleBackColor = True
        ' 
        ' backButton
        ' 
        backButton.Font = New Font("Sans Serif Collection", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backButton.Location = New Point(406, 394)
        backButton.Name = "backButton"
        backButton.Size = New Size(161, 58)
        backButton.TabIndex = 4
        backButton.Text = "Back to Main "
        backButton.UseVisualStyleBackColor = True
        ' 
        ' rockGIF
        ' 
        rockGIF.Image = CType(resources.GetObject("rockGIF.Image"), Image)
        rockGIF.Location = New Point(85, 162)
        rockGIF.Name = "rockGIF"
        rockGIF.Size = New Size(265, 265)
        rockGIF.SizeMode = PictureBoxSizeMode.StretchImage
        rockGIF.TabIndex = 6
        rockGIF.TabStop = False
        ' 
        ' paperGIF
        ' 
        paperGIF.Image = CType(resources.GetObject("paperGIF.Image"), Image)
        paperGIF.Location = New Point(85, 164)
        paperGIF.Name = "paperGIF"
        paperGIF.Size = New Size(270, 263)
        paperGIF.SizeMode = PictureBoxSizeMode.StretchImage
        paperGIF.TabIndex = 7
        paperGIF.TabStop = False
        ' 
        ' scissorGIF
        ' 
        scissorGIF.Image = CType(resources.GetObject("scissorGIF.Image"), Image)
        scissorGIF.Location = New Point(85, 145)
        scissorGIF.Name = "scissorGIF"
        scissorGIF.Size = New Size(260, 290)
        scissorGIF.SizeMode = PictureBoxSizeMode.StretchImage
        scissorGIF.TabIndex = 8
        scissorGIF.TabStop = False
        ' 
        ' rockGIFBot
        ' 
        rockGIFBot.Image = CType(resources.GetObject("rockGIFBot.Image"), Image)
        rockGIFBot.Location = New Point(634, 164)
        rockGIFBot.Name = "rockGIFBot"
        rockGIFBot.Size = New Size(265, 265)
        rockGIFBot.SizeMode = PictureBoxSizeMode.StretchImage
        rockGIFBot.TabIndex = 9
        rockGIFBot.TabStop = False
        ' 
        ' paperGIFBot
        ' 
        paperGIFBot.Image = CType(resources.GetObject("paperGIFBot.Image"), Image)
        paperGIFBot.Location = New Point(629, 162)
        paperGIFBot.Name = "paperGIFBot"
        paperGIFBot.Size = New Size(270, 263)
        paperGIFBot.SizeMode = PictureBoxSizeMode.StretchImage
        paperGIFBot.TabIndex = 10
        paperGIFBot.TabStop = False
        ' 
        ' scissorGIFBot
        ' 
        scissorGIFBot.Image = CType(resources.GetObject("scissorGIFBot.Image"), Image)
        scissorGIFBot.Location = New Point(629, 145)
        scissorGIFBot.Name = "scissorGIFBot"
        scissorGIFBot.Size = New Size(260, 290)
        scissorGIFBot.SizeMode = PictureBoxSizeMode.StretchImage
        scissorGIFBot.TabIndex = 11
        scissorGIFBot.TabStop = False
        ' 
        ' rockpaperscissortimer
        ' 
        ' 
        ' showStatusTimer
        ' 
        ' 
        ' shootTimer
        ' 
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(969, 550)
        Controls.Add(retryButton)
        Controls.Add(statusLabel)
        Controls.Add(backButton)
        Controls.Add(scissorGIFBot)
        Controls.Add(paperGIFBot)
        Controls.Add(rockGIFBot)
        Controls.Add(scissorGIF)
        Controls.Add(paperGIF)
        Controls.Add(rockGIF)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Game"
        CType(rockGIF, ComponentModel.ISupportInitialize).EndInit()
        CType(paperGIF, ComponentModel.ISupportInitialize).EndInit()
        CType(scissorGIF, ComponentModel.ISupportInitialize).EndInit()
        CType(rockGIFBot, ComponentModel.ISupportInitialize).EndInit()
        CType(paperGIFBot, ComponentModel.ISupportInitialize).EndInit()
        CType(scissorGIFBot, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents statusLabel As Label
    Friend WithEvents retryButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents rockGIF As PictureBox
    Friend WithEvents paperGIF As PictureBox
    Friend WithEvents scissorGIF As PictureBox
    Friend WithEvents rockGIFBot As PictureBox
    Friend WithEvents paperGIFBot As PictureBox
    Friend WithEvents scissorGIFBot As PictureBox
    Friend WithEvents rockpaperscissortimer As Timer
    Friend WithEvents showStatusTimer As Timer
    Friend WithEvents shootTimer As Timer
End Class
