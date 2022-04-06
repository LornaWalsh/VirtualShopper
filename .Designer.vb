<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class Login
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
    Friend WithEvents pbxlogo As System.Windows.Forms.PictureBox
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.pbxlogo = New System.Windows.Forms.PictureBox()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnok = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lblfogotten = New System.Windows.Forms.LinkLabel()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btnreg = New System.Windows.Forms.Button()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxlogo
        '
        Me.pbxlogo.Image = CType(resources.GetObject("pbxlogo.Image"), System.Drawing.Image)
        Me.pbxlogo.Location = New System.Drawing.Point(12, 12)
        Me.pbxlogo.Name = "pbxlogo"
        Me.pbxlogo.Size = New System.Drawing.Size(324, 273)
        Me.pbxlogo.TabIndex = 0
        Me.pbxlogo.TabStop = False
        '
        'lbluser
        '
        Me.lbluser.Location = New System.Drawing.Point(383, 45)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(220, 23)
        Me.lbluser.TabIndex = 0
        Me.lbluser.Text = "&Username"
        Me.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblpassword
        '
        Me.lblpassword.Location = New System.Drawing.Point(383, 102)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(220, 23)
        Me.lblpassword.TabIndex = 2
        Me.lblpassword.Text = "&Password"
        Me.lblpassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(385, 65)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(220, 26)
        Me.txtuser.TabIndex = 1
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(385, 122)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(220, 26)
        Me.txtpassword.TabIndex = 3
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(411, 165)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(94, 37)
        Me.btnok.TabIndex = 4
        Me.btnok.Text = "&OK"
        '
        'btncancel
        '
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.Location = New System.Drawing.Point(511, 165)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(92, 37)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "&Cancel"
        '
        'lblfogotten
        '
        Me.lblfogotten.AutoSize = True
        Me.lblfogotten.Location = New System.Drawing.Point(428, 220)
        Me.lblfogotten.Name = "lblfogotten"
        Me.lblfogotten.Size = New System.Drawing.Size(175, 20)
        Me.lblfogotten.TabIndex = 7
        Me.lblfogotten.TabStop = True
        Me.lblfogotten.Text = "Forgotten login details?"
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(366, 150)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(139, 66)
        Me.btnlogin.TabIndex = 8
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'btnreg
        '
        Me.btnreg.Location = New System.Drawing.Point(511, 150)
        Me.btnreg.Name = "btnreg"
        Me.btnreg.Size = New System.Drawing.Size(140, 66)
        Me.btnreg.TabIndex = 9
        Me.btnreg.Text = "Register"
        Me.btnreg.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AcceptButton = Me.btnok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btncancel
        Me.ClientSize = New System.Drawing.Size(708, 309)
        Me.Controls.Add(Me.btnreg)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.lblfogotten)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.pbxlogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Virtual Shopper"
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblfogotten As LinkLabel
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnreg As Button
End Class
