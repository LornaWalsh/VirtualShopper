<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Product
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product))
        Me.btnCart = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.numUnits = New System.Windows.Forms.NumericUpDown()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.btnList = New System.Windows.Forms.Button()
        Me.pbxMain = New System.Windows.Forms.PictureBox()
        Me.pbxFront = New System.Windows.Forms.PictureBox()
        Me.pbxDetails = New System.Windows.Forms.PictureBox()
        Me.pbxBack = New System.Windows.Forms.PictureBox()
        CType(Me.numUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxFront, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCart
        '
        Me.btnCart.Location = New System.Drawing.Point(650, 50)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(123, 78)
        Me.btnCart.TabIndex = 1
        Me.btnCart.Text = "Add to Cart"
        Me.btnCart.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(650, 231)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(123, 72)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'numUnits
        '
        Me.numUnits.Location = New System.Drawing.Point(442, 77)
        Me.numUnits.Name = "numUnits"
        Me.numUnits.Size = New System.Drawing.Size(120, 26)
        Me.numUnits.TabIndex = 0
        Me.numUnits.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(568, 79)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(46, 20)
        Me.lblUnits.TabIndex = 3
        Me.lblUnits.Text = "Units"
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(650, 145)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(122, 68)
        Me.btnList.TabIndex = 2
        Me.btnList.Text = "Add to Shopping List"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'pbxMain
        '
        Me.pbxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxMain.Location = New System.Drawing.Point(12, 12)
        Me.pbxMain.Name = "pbxMain"
        Me.pbxMain.Size = New System.Drawing.Size(402, 317)
        Me.pbxMain.TabIndex = 5
        Me.pbxMain.TabStop = False
        '
        'pbxFront
        '
        Me.pbxFront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxFront.Location = New System.Drawing.Point(12, 335)
        Me.pbxFront.Name = "pbxFront"
        Me.pbxFront.Size = New System.Drawing.Size(130, 103)
        Me.pbxFront.TabIndex = 6
        Me.pbxFront.TabStop = False
        '
        'pbxDetails
        '
        Me.pbxDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxDetails.Location = New System.Drawing.Point(284, 335)
        Me.pbxDetails.Name = "pbxDetails"
        Me.pbxDetails.Size = New System.Drawing.Size(130, 103)
        Me.pbxDetails.TabIndex = 8
        Me.pbxDetails.TabStop = False
        '
        'pbxBack
        '
        Me.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBack.Location = New System.Drawing.Point(148, 335)
        Me.pbxBack.Name = "pbxBack"
        Me.pbxBack.Size = New System.Drawing.Size(130, 103)
        Me.pbxBack.TabIndex = 9
        Me.pbxBack.TabStop = False
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbxBack)
        Me.Controls.Add(Me.pbxDetails)
        Me.Controls.Add(Me.pbxFront)
        Me.Controls.Add(Me.pbxMain)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.numUnits)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCart)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Details"
        CType(Me.numUnits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxFront, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCart As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents numUnits As NumericUpDown
    Friend WithEvents lblUnits As Label
    Friend WithEvents btnList As Button
    Friend WithEvents pbxMain As PictureBox
    Friend WithEvents pbxFront As PictureBox
    Friend WithEvents pbxDetails As PictureBox
    Friend WithEvents pbxBack As PictureBox
End Class
