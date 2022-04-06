<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.pbxIn = New System.Windows.Forms.PictureBox()
        Me.lblClick = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.btnCam1 = New System.Windows.Forms.Button()
        Me.btnCam2 = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CartToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShoppingListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblIfItWorks = New System.Windows.Forms.Label()
        Me.lblTesting = New System.Windows.Forms.Label()
        Me.lblSavedImage = New System.Windows.Forms.Label()
        Me.btnCam1Image = New System.Windows.Forms.Button()
        Me.btnCam2Image = New System.Windows.Forms.Button()
        Me.lblCameraFeed = New System.Windows.Forms.Label()
        CType(Me.pbxIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbxIn
        '
        Me.pbxIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxIn.InitialImage = CType(resources.GetObject("pbxIn.InitialImage"), System.Drawing.Image)
        Me.pbxIn.Location = New System.Drawing.Point(19, 62)
        Me.pbxIn.Name = "pbxIn"
        Me.pbxIn.Size = New System.Drawing.Size(703, 560)
        Me.pbxIn.TabIndex = 0
        Me.pbxIn.TabStop = False
        '
        'lblClick
        '
        Me.lblClick.AutoSize = True
        Me.lblClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClick.Location = New System.Drawing.Point(12, 22)
        Me.lblClick.Name = "lblClick"
        Me.lblClick.Size = New System.Drawing.Size(327, 37)
        Me.lblClick.TabIndex = 1
        Me.lblClick.Text = "Click on item to select"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(744, 90)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(102, 20)
        Me.lblX.TabIndex = 2
        Me.lblX.Text = "X Coordinate"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(941, 90)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(102, 20)
        Me.lblY.TabIndex = 3
        Me.lblY.Text = "Y Coordinate"
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(748, 113)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(140, 26)
        Me.txtX.TabIndex = 7
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(903, 113)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(140, 26)
        Me.txtY.TabIndex = 8
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(744, 265)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(41, 20)
        Me.lblItem.TabIndex = 7
        Me.lblItem.Text = "Item"
        '
        'btnCam1
        '
        Me.btnCam1.Location = New System.Drawing.Point(731, 447)
        Me.btnCam1.Name = "btnCam1"
        Me.btnCam1.Size = New System.Drawing.Size(140, 42)
        Me.btnCam1.TabIndex = 3
        Me.btnCam1.Text = "Camera 1"
        Me.btnCam1.UseVisualStyleBackColor = True
        '
        'btnCam2
        '
        Me.btnCam2.Location = New System.Drawing.Point(902, 448)
        Me.btnCam2.Name = "btnCam2"
        Me.btnCam2.Size = New System.Drawing.Size(124, 41)
        Me.btnCam2.TabIndex = 4
        Me.btnCam2.Text = "Camera 2"
        Me.btnCam2.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(825, 305)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(133, 48)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "Select Item"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CartToolStripMenuItem1, Me.ShoppingListToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1052, 33)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CartToolStripMenuItem1
        '
        Me.CartToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CartToolStripMenuItem1.Name = "CartToolStripMenuItem1"
        Me.CartToolStripMenuItem1.Size = New System.Drawing.Size(60, 29)
        Me.CartToolStripMenuItem1.Text = "Cart"
        '
        'ShoppingListToolStripMenuItem1
        '
        Me.ShoppingListToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ShoppingListToolStripMenuItem1.Name = "ShoppingListToolStripMenuItem1"
        Me.ShoppingListToolStripMenuItem1.Size = New System.Drawing.Size(137, 29)
        Me.ShoppingListToolStripMenuItem1.Text = "Shopping List"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(913, 525)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(130, 48)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Exit Application"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblIfItWorks
        '
        Me.lblIfItWorks.AutoSize = True
        Me.lblIfItWorks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIfItWorks.Location = New System.Drawing.Point(730, 382)
        Me.lblIfItWorks.Name = "lblIfItWorks"
        Me.lblIfItWorks.Size = New System.Drawing.Size(313, 22)
        Me.lblIfItWorks.TabIndex = 18
        Me.lblIfItWorks.Text = "If a connection to cameras is possible:"
        '
        'lblTesting
        '
        Me.lblTesting.AutoSize = True
        Me.lblTesting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTesting.Location = New System.Drawing.Point(850, 62)
        Me.lblTesting.Name = "lblTesting"
        Me.lblTesting.Size = New System.Drawing.Size(95, 22)
        Me.lblTesting.TabIndex = 19
        Me.lblTesting.Text = "For testing"
        '
        'lblSavedImage
        '
        Me.lblSavedImage.AutoSize = True
        Me.lblSavedImage.Location = New System.Drawing.Point(821, 170)
        Me.lblSavedImage.Name = "lblSavedImage"
        Me.lblSavedImage.Size = New System.Drawing.Size(138, 20)
        Me.lblSavedImage.TabIndex = 20
        Me.lblSavedImage.Text = "Load saved image"
        '
        'btnCam1Image
        '
        Me.btnCam1Image.Location = New System.Drawing.Point(748, 209)
        Me.btnCam1Image.Name = "btnCam1Image"
        Me.btnCam1Image.Size = New System.Drawing.Size(140, 37)
        Me.btnCam1Image.TabIndex = 0
        Me.btnCam1Image.Text = "Camera 1"
        Me.btnCam1Image.UseVisualStyleBackColor = True
        '
        'btnCam2Image
        '
        Me.btnCam2Image.Location = New System.Drawing.Point(903, 209)
        Me.btnCam2Image.Name = "btnCam2Image"
        Me.btnCam2Image.Size = New System.Drawing.Size(140, 37)
        Me.btnCam2Image.TabIndex = 1
        Me.btnCam2Image.Text = "Camera 2"
        Me.btnCam2Image.UseVisualStyleBackColor = True
        '
        'lblCameraFeed
        '
        Me.lblCameraFeed.AutoSize = True
        Me.lblCameraFeed.Location = New System.Drawing.Point(799, 414)
        Me.lblCameraFeed.Name = "lblCameraFeed"
        Me.lblCameraFeed.Size = New System.Drawing.Size(207, 20)
        Me.lblCameraFeed.TabIndex = 23
        Me.lblCameraFeed.Text = "Capture Live Camera Image"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 807)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCameraFeed)
        Me.Controls.Add(Me.btnCam2Image)
        Me.Controls.Add(Me.btnCam1Image)
        Me.Controls.Add(Me.lblSavedImage)
        Me.Controls.Add(Me.lblTesting)
        Me.Controls.Add(Me.lblIfItWorks)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnCam2)
        Me.Controls.Add(Me.btnCam1)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.txtY)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.lblClick)
        Me.Controls.Add(Me.pbxIn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Virtual Shopper"
        CType(Me.pbxIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxIn As PictureBox
    Friend WithEvents lblClick As Label
    Friend WithEvents lblX As Label
    Friend WithEvents lblY As Label
    Friend WithEvents txtX As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtY As TextBox
    Friend WithEvents lblItem As Label
    Friend WithEvents btnCam1 As Button
    Friend WithEvents btnCam2 As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CartToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ShoppingListToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btnClose As Button
    Friend WithEvents lblIfItWorks As Label
    Friend WithEvents lblTesting As Label
    Friend WithEvents lblSavedImage As Label
    Friend WithEvents btnCam1Image As Button
    Friend WithEvents btnCam2Image As Button
    Friend WithEvents lblCameraFeed As Label
End Class
