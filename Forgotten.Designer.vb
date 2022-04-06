<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Forgotten
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forgotten))
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnok = New System.Windows.Forms.Button()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.pbxlogo = New System.Windows.Forms.PictureBox()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.Location = New System.Drawing.Point(511, 138)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(94, 37)
        Me.btncancel.TabIndex = 14
        Me.btncancel.Text = "&Cancel"
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(385, 138)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(94, 37)
        Me.btnok.TabIndex = 13
        Me.btnok.Text = "&OK"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(385, 65)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(220, 26)
        Me.txtemail.TabIndex = 10
        '
        'lblemail
        '
        Me.lblemail.Location = New System.Drawing.Point(383, 45)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(220, 23)
        Me.lblemail.TabIndex = 8
        Me.lblemail.Text = "&Email"
        Me.lblemail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxlogo
        '
        Me.pbxlogo.Image = CType(resources.GetObject("pbxlogo.Image"), System.Drawing.Image)
        Me.pbxlogo.Location = New System.Drawing.Point(12, 12)
        Me.pbxlogo.Name = "pbxlogo"
        Me.pbxlogo.Size = New System.Drawing.Size(324, 273)
        Me.pbxlogo.TabIndex = 9
        Me.pbxlogo.TabStop = False
        '
        'Forgotten
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 305)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.pbxlogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Forgotten"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgottrn"
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncancel As Button
    Friend WithEvents btnok As Button
    Friend WithEvents txtemail As TextBox
    Friend WithEvents lblemail As Label
    Friend WithEvents pbxlogo As PictureBox
End Class
