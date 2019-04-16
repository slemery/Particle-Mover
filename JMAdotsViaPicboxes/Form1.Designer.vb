<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.tmrA = New System.Windows.Forms.Timer(Me.components)
        Me.Btnstop = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStep = New System.Windows.Forms.Button()
        Me.btnMake = New System.Windows.Forms.Button()
        Me.picBall = New System.Windows.Forms.PictureBox()
        Me.PicA = New System.Windows.Forms.PictureBox()
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(35, 13)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(37, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'tmrA
        '
        Me.tmrA.Interval = 500
        '
        'Btnstop
        '
        Me.Btnstop.Location = New System.Drawing.Point(78, 13)
        Me.Btnstop.Name = "Btnstop"
        Me.Btnstop.Size = New System.Drawing.Size(38, 23)
        Me.Btnstop.TabIndex = 3
        Me.Btnstop.Text = "stop"
        Me.Btnstop.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(514, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'btnStep
        '
        Me.btnStep.Location = New System.Drawing.Point(342, 13)
        Me.btnStep.Name = "btnStep"
        Me.btnStep.Size = New System.Drawing.Size(59, 23)
        Me.btnStep.TabIndex = 8
        Me.btnStep.Text = "Step"
        Me.btnStep.UseVisualStyleBackColor = True
        '
        'btnMake
        '
        Me.btnMake.Location = New System.Drawing.Point(144, 10)
        Me.btnMake.Name = "btnMake"
        Me.btnMake.Size = New System.Drawing.Size(93, 28)
        Me.btnMake.TabIndex = 9
        Me.btnMake.Text = "Make Particle"
        Me.btnMake.UseVisualStyleBackColor = True
        '
        'picBall
        '
        Me.picBall.Image = Global.SimTest1.My.Resources.Resources.ball2
        Me.picBall.Location = New System.Drawing.Point(666, 87)
        Me.picBall.Name = "picBall"
        Me.picBall.Size = New System.Drawing.Size(20, 20)
        Me.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBall.TabIndex = 7
        Me.picBall.TabStop = False
        Me.picBall.Visible = False
        '
        'PicA
        '
        Me.PicA.BackColor = System.Drawing.Color.Beige
        Me.PicA.Location = New System.Drawing.Point(12, 55)
        Me.PicA.Name = "PicA"
        Me.PicA.Size = New System.Drawing.Size(715, 464)
        Me.PicA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicA.TabIndex = 0
        Me.PicA.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 482)
        Me.Controls.Add(Me.btnMake)
        Me.Controls.Add(Me.btnStep)
        Me.Controls.Add(Me.picBall)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnstop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.PicA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicA As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents tmrA As Timer
    Friend WithEvents Btnstop As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents picBall As PictureBox
    Friend WithEvents btnStep As Button
    Friend WithEvents btnMake As Button
End Class
