<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        titleLabel = New Label()
        playButton = New Button()
        rulesButton = New Button()
        quitButton = New Button()
        rockGIF = New PictureBox()
        paperGIF = New PictureBox()
        PictureBox1 = New PictureBox()
        CType(rockGIF, ComponentModel.ISupportInitialize).BeginInit()
        CType(paperGIF, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' titleLabel
        ' 
        titleLabel.AutoSize = True
        titleLabel.BackColor = SystemColors.Control
        titleLabel.Font = New Font("MS Reference Sans Serif", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        titleLabel.Location = New Point(156, 80)
        titleLabel.Name = "titleLabel"
        titleLabel.Size = New Size(652, 55)
        titleLabel.TabIndex = 0
        titleLabel.Text = "Rock, Paper, Scissor, Shoot!"
        titleLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' playButton
        ' 
        playButton.Font = New Font("Sans Serif Collection", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        playButton.Location = New Point(380, 222)
        playButton.Name = "playButton"
        playButton.Size = New Size(182, 55)
        playButton.TabIndex = 1
        playButton.Text = "Play"
        playButton.UseVisualStyleBackColor = True
        ' 
        ' rulesButton
        ' 
        rulesButton.Font = New Font("Sans Serif Collection", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rulesButton.Location = New Point(380, 320)
        rulesButton.Name = "rulesButton"
        rulesButton.Size = New Size(182, 54)
        rulesButton.TabIndex = 2
        rulesButton.Text = "Rules"
        rulesButton.UseVisualStyleBackColor = True
        ' 
        ' quitButton
        ' 
        quitButton.Font = New Font("Sans Serif Collection", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        quitButton.Location = New Point(380, 416)
        quitButton.Name = "quitButton"
        quitButton.Size = New Size(182, 53)
        quitButton.TabIndex = 3
        quitButton.Text = "Quit"
        quitButton.UseVisualStyleBackColor = True
        ' 
        ' rockGIF
        ' 
        rockGIF.Image = CType(resources.GetObject("rockGIF.Image"), Image)
        rockGIF.Location = New Point(52, 12)
        rockGIF.Name = "rockGIF"
        rockGIF.Size = New Size(213, 214)
        rockGIF.SizeMode = PictureBoxSizeMode.StretchImage
        rockGIF.TabIndex = 4
        rockGIF.TabStop = False
        ' 
        ' paperGIF
        ' 
        paperGIF.Image = CType(resources.GetObject("paperGIF.Image"), Image)
        paperGIF.Location = New Point(676, 54)
        paperGIF.Name = "paperGIF"
        paperGIF.Size = New Size(239, 234)
        paperGIF.SizeMode = PictureBoxSizeMode.StretchImage
        paperGIF.TabIndex = 5
        paperGIF.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(229, 306)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(198, 222)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(966, 550)
        Controls.Add(quitButton)
        Controls.Add(rulesButton)
        Controls.Add(playButton)
        Controls.Add(titleLabel)
        Controls.Add(rockGIF)
        Controls.Add(paperGIF)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Game"
        CType(rockGIF, ComponentModel.ISupportInitialize).EndInit()
        CType(paperGIF, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents titleLabel As Label
    Friend WithEvents playButton As Button
    Friend WithEvents rulesButton As Button
    Friend WithEvents quitButton As Button
    Friend WithEvents rockGIF As PictureBox
    Friend WithEvents paperGIF As PictureBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
