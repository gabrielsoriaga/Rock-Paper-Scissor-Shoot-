<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        rockGIF = New PictureBox()
        paperGIF = New PictureBox()
        scissorGIF = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(rockGIF, ComponentModel.ISupportInitialize).BeginInit()
        CType(paperGIF, ComponentModel.ISupportInitialize).BeginInit()
        CType(scissorGIF, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' rockGIF
        ' 
        rockGIF.Image = CType(resources.GetObject("rockGIF.Image"), Image)
        rockGIF.Location = New Point(41, 135)
        rockGIF.Name = "rockGIF"
        rockGIF.Size = New Size(265, 265)
        rockGIF.SizeMode = PictureBoxSizeMode.StretchImage
        rockGIF.TabIndex = 5
        rockGIF.TabStop = False
        ' 
        ' paperGIF
        ' 
        paperGIF.Image = CType(resources.GetObject("paperGIF.Image"), Image)
        paperGIF.Location = New Point(347, 137)
        paperGIF.Name = "paperGIF"
        paperGIF.Size = New Size(270, 263)
        paperGIF.SizeMode = PictureBoxSizeMode.StretchImage
        paperGIF.TabIndex = 6
        paperGIF.TabStop = False
        ' 
        ' scissorGIF
        ' 
        scissorGIF.Image = CType(resources.GetObject("scissorGIF.Image"), Image)
        scissorGIF.Location = New Point(669, 110)
        scissorGIF.Name = "scissorGIF"
        scissorGIF.Size = New Size(260, 290)
        scissorGIF.SizeMode = PictureBoxSizeMode.StretchImage
        scissorGIF.TabIndex = 7
        scissorGIF.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Sans Serif Collection", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(418, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 136)
        Label1.TabIndex = 8
        Label1.Text = "Pick"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Sans Serif Collection", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(95, 389)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 136)
        Label2.TabIndex = 9
        Label2.Text = "Rock"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Sans Serif Collection", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(702, 389)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 136)
        Label3.TabIndex = 10
        Label3.Text = "Scissor"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Control
        Label4.Font = New Font("Sans Serif Collection", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(407, 389)
        Label4.Name = "Label4"
        Label4.Size = New Size(173, 136)
        Label4.TabIndex = 11
        Label4.Text = "Paper"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(964, 551)
        Controls.Add(paperGIF)
        Controls.Add(Label1)
        Controls.Add(scissorGIF)
        Controls.Add(rockGIF)
        Controls.Add(Label2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Name = "Form2"
        Text = "Game"
        CType(rockGIF, ComponentModel.ISupportInitialize).EndInit()
        CType(paperGIF, ComponentModel.ISupportInitialize).EndInit()
        CType(scissorGIF, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rockGIF As PictureBox
    Friend WithEvents paperGIF As PictureBox
    Friend WithEvents scissorGIF As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
