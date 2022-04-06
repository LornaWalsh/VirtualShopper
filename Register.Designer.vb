<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnok = New System.Windows.Forms.Button()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.pbxlogo = New System.Windows.Forms.PictureBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblreg = New System.Windows.Forms.Label()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.Location = New System.Drawing.Point(509, 254)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(94, 31)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "&Cancel"
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(411, 254)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(94, 31)
        Me.btnok.TabIndex = 4
        Me.btnok.Text = "&OK"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(387, 191)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(220, 26)
        Me.txtemail.TabIndex = 3
        '
        'lblemail
        '
        Me.lblemail.Location = New System.Drawing.Point(385, 171)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(220, 23)
        Me.lblemail.TabIndex = 15
        Me.lblemail.Text = "&Email"
        Me.lblemail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxlogo
        '
        Me.pbxlogo.Image = CType(resources.GetObject("pbxlogo.Image"), System.Drawing.Image)
        Me.pbxlogo.Location = New System.Drawing.Point(12, 12)
        Me.pbxlogo.Name = "pbxlogo"
        Me.pbxlogo.Size = New System.Drawing.Size(324, 273)
        Me.pbxlogo.TabIndex = 16
        Me.pbxlogo.TabStop = False
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(385, 132)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(220, 26)
        Me.txtpassword.TabIndex = 2
        '
        'lblpassword
        '
        Me.lblpassword.Location = New System.Drawing.Point(383, 112)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(220, 23)
        Me.lblpassword.TabIndex = 20
        Me.lblpassword.Text = "Password"
        Me.lblpassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(385, 71)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(220, 26)
        Me.txtuser.TabIndex = 1
        '
        'lbluser
        '
        Me.lbluser.Location = New System.Drawing.Point(383, 51)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(220, 23)
        Me.lbluser.TabIndex = 22
        Me.lbluser.Text = "Username"
        Me.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblreg
        '
        Me.lblreg.Location = New System.Drawing.Point(342, 12)
        Me.lblreg.Name = "lblreg"
        Me.lblreg.Size = New System.Drawing.Size(277, 27)
        Me.lblreg.TabIndex = 24
        Me.lblreg.Text = "Register New Account"
        Me.lblreg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 305)
        Me.Controls.Add(Me.lblreg)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.pbxlogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Register"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm1"
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncancel As Button
    Friend WithEvents btnok As Button
    Friend WithEvents txtemail As TextBox
    Friend WithEvents lblemail As Label
    Friend WithEvents pbxlogo As PictureBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents lblpassword As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents lbluser As Label
    Friend WithEvents lblreg As Label
End Class
