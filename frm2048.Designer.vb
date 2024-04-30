<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm2048
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.x4y4 = New System.Windows.Forms.PictureBox()
        Me.x3y4 = New System.Windows.Forms.PictureBox()
        Me.x2y4 = New System.Windows.Forms.PictureBox()
        Me.x1y4 = New System.Windows.Forms.PictureBox()
        Me.x4y3 = New System.Windows.Forms.PictureBox()
        Me.x3y3 = New System.Windows.Forms.PictureBox()
        Me.x2y3 = New System.Windows.Forms.PictureBox()
        Me.x1y3 = New System.Windows.Forms.PictureBox()
        Me.x4y2 = New System.Windows.Forms.PictureBox()
        Me.x3y2 = New System.Windows.Forms.PictureBox()
        Me.x2y2 = New System.Windows.Forms.PictureBox()
        Me.x1y2 = New System.Windows.Forms.PictureBox()
        Me.x4y1 = New System.Windows.Forms.PictureBox()
        Me.x3y1 = New System.Windows.Forms.PictureBox()
        Me.x2y1 = New System.Windows.Forms.PictureBox()
        Me.x1y1 = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.DummyLabel = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblScoreText = New System.Windows.Forms.Label()
        Me.lblHighScoreText = New System.Windows.Forms.Label()
        Me.lblHighScore = New System.Windows.Forms.Label()
        CType(Me.x4y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x3y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x2y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x1y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x4y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x3y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x2y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x1y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x4y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x3y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x2y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x1y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x4y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x3y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x2y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x1y1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'x4y4
        '
        Me.x4y4.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.x4y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.x4y4.Location = New System.Drawing.Point(340, 340)
        Me.x4y4.Name = "x4y4"
        Me.x4y4.Size = New System.Drawing.Size(100, 100)
        Me.x4y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.x4y4.TabIndex = 15
        Me.x4y4.TabStop = False
        '
        'x3y4
        '
        Me.x3y4.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.x3y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.x3y4.Location = New System.Drawing.Point(230, 340)
        Me.x3y4.Name = "x3y4"
        Me.x3y4.Size = New System.Drawing.Size(100, 100)
        Me.x3y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.x3y4.TabIndex = 14
        Me.x3y4.TabStop = False
        '
        'x2y4
        '
        Me.x2y4.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.x2y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.x2y4.Location = New System.Drawing.Point(120, 340)
        Me.x2y4.Name = "x2y4"
        Me.x2y4.Size = New System.Drawing.Size(100, 100)
        Me.x2y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.x2y4.TabIndex = 13
        Me.x2y4.TabStop = False
        '
        'x1y4
        '
        Me.x1y4.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.x1y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.x1y4.Location = New System.Drawing.Point(10, 340)
        Me.x1y4.Name = "x1y4"
        Me.x1y4.Size = New System.Drawing.Size(100, 100)
        Me.x1y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.x1y4.TabIndex = 12
        Me.x1y4.TabStop = False
        '
        'x4y3
        '
        Me.x4y3.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.x4y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.x4y3.Location = New System.Drawing.Point(340, 230)
        Me.x4y3.Name = "x4y3"
        Me.x4y3.Size = New System.Drawing.Size(100, 100)
        Me.x4y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.x4y3.TabIndex = 11
        Me.x4y3.TabStop = False
        '
        'x3y3
        '
        Me.x3y3.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.x3y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.x3y3.Location = New System.Drawing.Point(230, 230)
        Me.x3y3.Name = "x3y3"
        Me.x3y3.Size = New System.Drawing.Size(100, 100)
        Me.x3y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.x3y3.TabIndex = 10
        Me.x3y3.TabStop = False
        '
        'x2y3
        '
        Me.x2y3.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.x2y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.x2y3.Location = New System.Drawing.Point(120, 230)
        Me.x2y3.Name = "x2y3"
        Me.x2y3.Size = New System.Drawing.Size(100, 100)
        Me.x2y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.x2y3.TabIndex = 9
        Me.x2y3.TabStop = False
        '
        'x1y3
        '
        Me.x1y3.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.x1y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.x1y3.Location = New System.Drawing.Point(10, 230)
        Me.x1y3.Name = "x1y3"
        Me.x1y3.Size = New System.Drawing.Size(100, 100)
        Me.x1y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.x1y3.TabIndex = 8
        Me.x1y3.TabStop = False
        '
        'x4y2
        '
        Me.x4y2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.x4y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.x4y2.Location = New System.Drawing.Point(340, 120)
        Me.x4y2.Name = "x4y2"
        Me.x4y2.Size = New System.Drawing.Size(100, 100)
        Me.x4y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.x4y2.TabIndex = 7
        Me.x4y2.TabStop = False
        '
        'x3y2
        '
        Me.x3y2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.x3y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.x3y2.Location = New System.Drawing.Point(230, 120)
        Me.x3y2.Name = "x3y2"
        Me.x3y2.Size = New System.Drawing.Size(100, 100)
        Me.x3y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.x3y2.TabIndex = 6
        Me.x3y2.TabStop = False
        '
        'x2y2
        '
        Me.x2y2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.x2y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.x2y2.Location = New System.Drawing.Point(120, 120)
        Me.x2y2.Name = "x2y2"
        Me.x2y2.Size = New System.Drawing.Size(100, 100)
        Me.x2y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.x2y2.TabIndex = 5
        Me.x2y2.TabStop = False
        '
        'x1y2
        '
        Me.x1y2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.x1y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.x1y2.Location = New System.Drawing.Point(10, 120)
        Me.x1y2.Name = "x1y2"
        Me.x1y2.Size = New System.Drawing.Size(100, 100)
        Me.x1y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.x1y2.TabIndex = 4
        Me.x1y2.TabStop = False
        '
        'x4y1
        '
        Me.x4y1.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.x4y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.x4y1.Location = New System.Drawing.Point(340, 10)
        Me.x4y1.Name = "x4y1"
        Me.x4y1.Size = New System.Drawing.Size(100, 100)
        Me.x4y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.x4y1.TabIndex = 3
        Me.x4y1.TabStop = False
        '
        'x3y1
        '
        Me.x3y1.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.x3y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.x3y1.Location = New System.Drawing.Point(230, 10)
        Me.x3y1.Name = "x3y1"
        Me.x3y1.Size = New System.Drawing.Size(100, 100)
        Me.x3y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.x3y1.TabIndex = 2
        Me.x3y1.TabStop = False
        '
        'x2y1
        '
        Me.x2y1.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.x2y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.x2y1.Location = New System.Drawing.Point(120, 10)
        Me.x2y1.Name = "x2y1"
        Me.x2y1.Size = New System.Drawing.Size(100, 100)
        Me.x2y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.x2y1.TabIndex = 1
        Me.x2y1.TabStop = False
        '
        'x1y1
        '
        Me.x1y1.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.x1y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.x1y1.Location = New System.Drawing.Point(10, 10)
        Me.x1y1.Name = "x1y1"
        Me.x1y1.Size = New System.Drawing.Size(100, 100)
        Me.x1y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.x1y1.TabIndex = 0
        Me.x1y1.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderSize = 3
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(120, 450)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 40)
        Me.btnReset.TabIndex = 0
        Me.btnReset.TabStop = False
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'DummyLabel
        '
        Me.DummyLabel.AutoSize = True
        Me.DummyLabel.Location = New System.Drawing.Point(25, 475)
        Me.DummyLabel.Name = "DummyLabel"
        Me.DummyLabel.Size = New System.Drawing.Size(0, 13)
        Me.DummyLabel.TabIndex = 23
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 3
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(230, 450)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 40)
        Me.btnExit.TabIndex = 24
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(10, 468)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(100, 23)
        Me.lblScore.TabIndex = 25
        Me.lblScore.Text = "0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScoreText
        '
        Me.lblScoreText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreText.Location = New System.Drawing.Point(10, 445)
        Me.lblScoreText.Name = "lblScoreText"
        Me.lblScoreText.Size = New System.Drawing.Size(100, 23)
        Me.lblScoreText.TabIndex = 26
        Me.lblScoreText.Text = "Score:"
        Me.lblScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHighScoreText
        '
        Me.lblHighScoreText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScoreText.Location = New System.Drawing.Point(340, 445)
        Me.lblHighScoreText.Name = "lblHighScoreText"
        Me.lblHighScoreText.Size = New System.Drawing.Size(100, 23)
        Me.lblHighScoreText.TabIndex = 28
        Me.lblHighScoreText.Text = "High Score:"
        Me.lblHighScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHighScore
        '
        Me.lblHighScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScore.Location = New System.Drawing.Point(340, 468)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(100, 23)
        Me.lblHighScore.TabIndex = 27
        Me.lblHighScore.Text = "0"
        Me.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm2048
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(450, 500)
        Me.Controls.Add(Me.lblHighScoreText)
        Me.Controls.Add(Me.lblHighScore)
        Me.Controls.Add(Me.lblScoreText)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.DummyLabel)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.x4y4)
        Me.Controls.Add(Me.x3y4)
        Me.Controls.Add(Me.x2y4)
        Me.Controls.Add(Me.x1y4)
        Me.Controls.Add(Me.x4y3)
        Me.Controls.Add(Me.x3y3)
        Me.Controls.Add(Me.x2y3)
        Me.Controls.Add(Me.x1y3)
        Me.Controls.Add(Me.x4y2)
        Me.Controls.Add(Me.x3y2)
        Me.Controls.Add(Me.x2y2)
        Me.Controls.Add(Me.x1y2)
        Me.Controls.Add(Me.x4y1)
        Me.Controls.Add(Me.x3y1)
        Me.Controls.Add(Me.x2y1)
        Me.Controls.Add(Me.x1y1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frm2048"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2048"
        CType(Me.x4y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x3y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x2y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x1y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x4y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x3y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x2y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x1y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x4y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x3y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x2y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x1y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x4y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x3y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x2y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x1y1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents x1y1 As PictureBox
    Friend WithEvents x4y4 As PictureBox
    Friend WithEvents x3y4 As PictureBox
    Friend WithEvents x2y4 As PictureBox
    Friend WithEvents x1y4 As PictureBox
    Friend WithEvents x4y3 As PictureBox
    Friend WithEvents x3y3 As PictureBox
    Friend WithEvents x2y3 As PictureBox
    Friend WithEvents x1y3 As PictureBox
    Friend WithEvents x4y2 As PictureBox
    Friend WithEvents x3y2 As PictureBox
    Friend WithEvents x2y2 As PictureBox
    Friend WithEvents x1y2 As PictureBox
    Friend WithEvents x4y1 As PictureBox
    Friend WithEvents x3y1 As PictureBox
    Friend WithEvents x2y1 As PictureBox
    Friend WithEvents btnReset As Button
    Friend WithEvents DummyLabel As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents lblScoreText As Label
    Friend WithEvents lblHighScoreText As Label
    Friend WithEvents lblHighScore As Label
End Class
