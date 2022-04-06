<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewListCart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewListCart))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblListCart = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Delete = New System.Windows.Forms.Button()
        Me.btnAddOut = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(76, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(614, 256)
        Me.DataGridView1.TabIndex = 0
        '
        'lblListCart
        '
        Me.lblListCart.AutoSize = True
        Me.lblListCart.Location = New System.Drawing.Point(72, 27)
        Me.lblListCart.Name = "lblListCart"
        Me.lblListCart.Size = New System.Drawing.Size(0, 20)
        Me.lblListCart.TabIndex = 1
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(256, 403)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(44, 20)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Total"
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(449, 395)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(92, 49)
        Me.Delete.TabIndex = 3
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'btnAddOut
        '
        Me.btnAddOut.Location = New System.Drawing.Point(569, 395)
        Me.btnAddOut.Name = "btnAddOut"
        Me.btnAddOut.Size = New System.Drawing.Size(113, 49)
        Me.btnAddOut.TabIndex = 4
        Me.btnAddOut.Text = "Check Out"
        Me.btnAddOut.UseVisualStyleBackColor = True
        '
        'ViewListCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 477)
        Me.Controls.Add(Me.btnAddOut)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblListCart)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewListCart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblListCart As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Delete As Button
    Friend WithEvents btnAddOut As Button
End Class
