<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Modele_Inox
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modele_Inox))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.NvModeleBTN = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Milieu = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel7)
        Me.Panel3.Controls.Add(Me.NvModeleBTN)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1160, 74)
        Me.Panel3.TabIndex = 5
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(75, 14)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(307, 45)
        Me.BunifuCustomLabel7.TabIndex = 4
        Me.BunifuCustomLabel7.Text = "Modele Rampe Inox"
        '
        'NvModeleBTN
        '
        Me.NvModeleBTN.ActiveBorderThickness = 1
        Me.NvModeleBTN.ActiveCornerRadius = 20
        Me.NvModeleBTN.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NvModeleBTN.ActiveForecolor = System.Drawing.Color.White
        Me.NvModeleBTN.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NvModeleBTN.BackColor = System.Drawing.Color.White
        Me.NvModeleBTN.BackgroundImage = CType(resources.GetObject("NvModeleBTN.BackgroundImage"), System.Drawing.Image)
        Me.NvModeleBTN.ButtonText = "Nouveau Modele"
        Me.NvModeleBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NvModeleBTN.Dock = System.Windows.Forms.DockStyle.Right
        Me.NvModeleBTN.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NvModeleBTN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NvModeleBTN.IdleBorderThickness = 2
        Me.NvModeleBTN.IdleCornerRadius = 20
        Me.NvModeleBTN.IdleFillColor = System.Drawing.Color.White
        Me.NvModeleBTN.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NvModeleBTN.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NvModeleBTN.Location = New System.Drawing.Point(979, 0)
        Me.NvModeleBTN.Margin = New System.Windows.Forms.Padding(5)
        Me.NvModeleBTN.Name = "NvModeleBTN"
        Me.NvModeleBTN.Size = New System.Drawing.Size(181, 74)
        Me.NvModeleBTN.TabIndex = 3
        Me.NvModeleBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Milieu
        '
        Me.Milieu.AutoScroll = True
        Me.Milieu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Milieu.Location = New System.Drawing.Point(0, 74)
        Me.Milieu.Name = "Milieu"
        Me.Milieu.Size = New System.Drawing.Size(1160, 760)
        Me.Milieu.TabIndex = 6
        '
        'Modele_Inox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Milieu)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Modele_Inox"
        Me.Size = New System.Drawing.Size(1160, 834)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NvModeleBTN As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Milieu As Panel
End Class
