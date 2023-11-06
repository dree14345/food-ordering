<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Widget
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.Label()
        Me.productPic = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.productPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtPrice)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.productPic)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 187)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(78, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.AutoSize = True
        Me.txtPrice.Location = New System.Drawing.Point(20, 142)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(28, 13)
        Me.txtPrice.TabIndex = 4
        Me.txtPrice.Text = "1.65"
        '
        'txtName
        '
        Me.txtName.AutoSize = True
        Me.txtName.Location = New System.Drawing.Point(20, 22)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(28, 13)
        Me.txtName.TabIndex = 1
        Me.txtName.Text = "Yum"
        '
        'productPic
        '
        Me.productPic.Location = New System.Drawing.Point(208, 15)
        Me.productPic.Name = "productPic"
        Me.productPic.Size = New System.Drawing.Size(107, 140)
        Me.productPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.productPic.TabIndex = 0
        Me.productPic.TabStop = False
        '
        'Widget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Widget"
        Me.Size = New System.Drawing.Size(334, 203)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.productPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents productPic As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtPrice As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.Label

End Class
