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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lboxAC = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radKg = New System.Windows.Forms.RadioButton()
        Me.radLbs = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPAX = New System.Windows.Forms.Label()
        Me.trkMult = New System.Windows.Forms.TrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMult = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtW2 = New System.Windows.Forms.TextBox()
        Me.lblCG1 = New System.Windows.Forms.Label()
        Me.lblCG2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtPAX = New System.Windows.Forms.TextBox()
        Me.trkPct = New System.Windows.Forms.TrackBar()
        Me.lblPcn1 = New System.Windows.Forms.Label()
        Me.txtW1 = New System.Windows.Forms.TextBox()
        Me.lblPcn2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.trkMult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkPct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter PAX# -"
        '
        'lboxAC
        '
        Me.lboxAC.FormattingEnabled = True
        Me.lboxAC.Items.AddRange(New Object() {"736", "73W", "738"})
        Me.lboxAC.Location = New System.Drawing.Point(102, 9)
        Me.lboxAC.Name = "lboxAC"
        Me.lboxAC.Size = New System.Drawing.Size(100, 43)
        Me.lboxAC.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select Aircraft:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radKg)
        Me.GroupBox1.Controls.Add(Me.radLbs)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(271, 273)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(109, 71)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "lbs / kg"
        '
        'radKg
        '
        Me.radKg.AutoSize = True
        Me.radKg.Location = New System.Drawing.Point(6, 45)
        Me.radKg.Name = "radKg"
        Me.radKg.Size = New System.Drawing.Size(91, 17)
        Me.radKg.TabIndex = 1
        Me.radKg.Text = "Kilograms (kg)"
        Me.radKg.UseVisualStyleBackColor = True
        '
        'radLbs
        '
        Me.radLbs.AutoSize = True
        Me.radLbs.Checked = True
        Me.radLbs.Location = New System.Drawing.Point(6, 22)
        Me.radLbs.Name = "radLbs"
        Me.radLbs.Size = New System.Drawing.Size(83, 17)
        Me.radLbs.TabIndex = 0
        Me.radLbs.TabStop = True
        Me.radLbs.Text = "Pounds (lbs)"
        Me.radLbs.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Max PAX = "
        '
        'lblPAX
        '
        Me.lblPAX.AutoSize = True
        Me.lblPAX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPAX.Location = New System.Drawing.Point(277, 64)
        Me.lblPAX.Name = "lblPAX"
        Me.lblPAX.Size = New System.Drawing.Size(27, 15)
        Me.lblPAX.TabIndex = 8
        Me.lblPAX.Text = "119"
        '
        'trkMult
        '
        Me.trkMult.LargeChange = 50
        Me.trkMult.Location = New System.Drawing.Point(39, 300)
        Me.trkMult.Maximum = 200
        Me.trkMult.Minimum = 100
        Me.trkMult.Name = "trkMult"
        Me.trkMult.Size = New System.Drawing.Size(120, 45)
        Me.trkMult.SmallChange = 10
        Me.trkMult.TabIndex = 9
        Me.trkMult.TickFrequency = 10
        Me.trkMult.Value = 120
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "PAX/Cargo Multiplier = "
        '
        'lblMult
        '
        Me.lblMult.AutoSize = True
        Me.lblMult.Location = New System.Drawing.Point(160, 332)
        Me.lblMult.Name = "lblMult"
        Me.lblMult.Size = New System.Drawing.Size(28, 13)
        Me.lblMult.TabIndex = 11
        Me.lblMult.Text = "1.20"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(208, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "(Optional)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WJPayload.My.Resources.Resources.plane737
        Me.PictureBox1.Location = New System.Drawing.Point(12, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(374, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'txtW2
        '
        Me.txtW2.Location = New System.Drawing.Point(203, 133)
        Me.txtW2.Name = "txtW2"
        Me.txtW2.Size = New System.Drawing.Size(57, 20)
        Me.txtW2.TabIndex = 18
        '
        'lblCG1
        '
        Me.lblCG1.AutoSize = True
        Me.lblCG1.Location = New System.Drawing.Point(59, 136)
        Me.lblCG1.Name = "lblCG1"
        Me.lblCG1.Size = New System.Drawing.Size(20, 13)
        Me.lblCG1.TabIndex = 21
        Me.lblCG1.Text = "lbs"
        '
        'lblCG2
        '
        Me.lblCG2.AutoSize = True
        Me.lblCG2.Location = New System.Drawing.Point(180, 136)
        Me.lblCG2.Name = "lblCG2"
        Me.lblCG2.Size = New System.Drawing.Size(20, 13)
        Me.lblCG2.TabIndex = 22
        Me.lblCG2.Text = "lbs"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(237, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(149, 13)
        Me.LinkLabel1.TabIndex = 24
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://www.virtualwestjet.org/"
        '
        'txtPAX
        '
        Me.txtPAX.Location = New System.Drawing.Point(102, 61)
        Me.txtPAX.Name = "txtPAX"
        Me.txtPAX.Size = New System.Drawing.Size(100, 20)
        Me.txtPAX.TabIndex = 25
        '
        'trkPct
        '
        Me.trkPct.Location = New System.Drawing.Point(39, 222)
        Me.trkPct.Maximum = 100
        Me.trkPct.Name = "trkPct"
        Me.trkPct.Size = New System.Drawing.Size(299, 45)
        Me.trkPct.TabIndex = 26
        Me.trkPct.TickFrequency = 5
        Me.trkPct.Value = 45
        '
        'lblPcn1
        '
        Me.lblPcn1.AutoSize = True
        Me.lblPcn1.Location = New System.Drawing.Point(103, 117)
        Me.lblPcn1.Name = "lblPcn1"
        Me.lblPcn1.Size = New System.Drawing.Size(36, 13)
        Me.lblPcn1.TabIndex = 27
        Me.lblPcn1.Text = "45.0%"
        '
        'txtW1
        '
        Me.txtW1.Location = New System.Drawing.Point(82, 133)
        Me.txtW1.Name = "txtW1"
        Me.txtW1.Size = New System.Drawing.Size(57, 20)
        Me.txtW1.TabIndex = 17
        '
        'lblPcn2
        '
        Me.lblPcn2.AutoSize = True
        Me.lblPcn2.Location = New System.Drawing.Point(224, 117)
        Me.lblPcn2.Name = "lblPcn2"
        Me.lblPcn2.Size = New System.Drawing.Size(36, 13)
        Me.lblPcn2.TabIndex = 28
        Me.lblPcn2.Text = "55.0%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(133, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Center Of Balance"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 353)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.trkPct)
        Me.Controls.Add(Me.lblPcn2)
        Me.Controls.Add(Me.lblPcn1)
        Me.Controls.Add(Me.txtPAX)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblCG2)
        Me.Controls.Add(Me.lblCG1)
        Me.Controls.Add(Me.txtW2)
        Me.Controls.Add(Me.txtW1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblMult)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.trkMult)
        Me.Controls.Add(Me.lblPAX)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lboxAC)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "WJA PAX/Cargo Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.trkMult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkPct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lboxAC As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radKg As System.Windows.Forms.RadioButton
    Friend WithEvents radLbs As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPAX As System.Windows.Forms.Label
    Friend WithEvents trkMult As System.Windows.Forms.TrackBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblMult As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtW2 As System.Windows.Forms.TextBox
    Friend WithEvents lblCG1 As System.Windows.Forms.Label
    Friend WithEvents lblCG2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtPAX As System.Windows.Forms.TextBox
    Friend WithEvents trkPct As System.Windows.Forms.TrackBar
    Friend WithEvents lblPcn1 As System.Windows.Forms.Label
    Friend WithEvents txtW1 As System.Windows.Forms.TextBox
    Friend WithEvents lblPcn2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList

End Class
