<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ajouterProduit
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ajouterProduit))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.modifieBTN = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.confirmeBTN = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.desc = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.prix = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.code = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.nom = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Titre = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.modifieBTN)
        Me.Panel1.Controls.Add(Me.confirmeBTN)
        Me.Panel1.Controls.Add(Me.BunifuThinButton21)
        Me.Panel1.Controls.Add(Me.desc)
        Me.Panel1.Controls.Add(Me.prix)
        Me.Panel1.Controls.Add(Me.code)
        Me.Panel1.Controls.Add(Me.nom)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.Titre)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 500)
        Me.Panel1.TabIndex = 0
        '
        'modifieBTN
        '
        Me.modifieBTN.ActiveBorderThickness = 1
        Me.modifieBTN.ActiveCornerRadius = 20
        Me.modifieBTN.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.modifieBTN.ActiveForecolor = System.Drawing.Color.White
        Me.modifieBTN.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.modifieBTN.BackColor = System.Drawing.Color.White
        Me.modifieBTN.BackgroundImage = CType(resources.GetObject("modifieBTN.BackgroundImage"), System.Drawing.Image)
        Me.modifieBTN.ButtonText = "modifie"
        Me.modifieBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modifieBTN.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifieBTN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.modifieBTN.IdleBorderThickness = 2
        Me.modifieBTN.IdleCornerRadius = 20
        Me.modifieBTN.IdleFillColor = System.Drawing.Color.White
        Me.modifieBTN.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.modifieBTN.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.modifieBTN.Location = New System.Drawing.Point(205, 439)
        Me.modifieBTN.Margin = New System.Windows.Forms.Padding(5)
        Me.modifieBTN.Name = "modifieBTN"
        Me.modifieBTN.Size = New System.Drawing.Size(158, 50)
        Me.modifieBTN.TabIndex = 26
        Me.modifieBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.modifieBTN.Visible = False
        '
        'confirmeBTN
        '
        Me.confirmeBTN.ActiveBorderThickness = 1
        Me.confirmeBTN.ActiveCornerRadius = 20
        Me.confirmeBTN.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.confirmeBTN.ActiveForecolor = System.Drawing.Color.White
        Me.confirmeBTN.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.confirmeBTN.BackColor = System.Drawing.Color.White
        Me.confirmeBTN.BackgroundImage = CType(resources.GetObject("confirmeBTN.BackgroundImage"), System.Drawing.Image)
        Me.confirmeBTN.ButtonText = "Enregistrer"
        Me.confirmeBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.confirmeBTN.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmeBTN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.confirmeBTN.IdleBorderThickness = 2
        Me.confirmeBTN.IdleCornerRadius = 20
        Me.confirmeBTN.IdleFillColor = System.Drawing.Color.White
        Me.confirmeBTN.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.confirmeBTN.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.confirmeBTN.Location = New System.Drawing.Point(205, 439)
        Me.confirmeBTN.Margin = New System.Windows.Forms.Padding(5)
        Me.confirmeBTN.Name = "confirmeBTN"
        Me.confirmeBTN.Size = New System.Drawing.Size(158, 50)
        Me.confirmeBTN.TabIndex = 25
        Me.confirmeBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Annuler"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuThinButton21.IdleBorderThickness = 2
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(14, 439)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(158, 50)
        Me.BunifuThinButton21.TabIndex = 24
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'desc
        '
        Me.desc.BorderColor = System.Drawing.Color.SeaGreen
        Me.desc.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc.Location = New System.Drawing.Point(156, 304)
        Me.desc.Multiline = True
        Me.desc.Name = "desc"
        Me.desc.Size = New System.Drawing.Size(199, 127)
        Me.desc.TabIndex = 23
        '
        'prix
        '
        Me.prix.BorderColor = System.Drawing.Color.SeaGreen
        Me.prix.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prix.Location = New System.Drawing.Point(156, 251)
        Me.prix.Name = "prix"
        Me.prix.Size = New System.Drawing.Size(199, 32)
        Me.prix.TabIndex = 22
        '
        'code
        '
        Me.code.BorderColor = System.Drawing.Color.SeaGreen
        Me.code.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.code.Location = New System.Drawing.Point(156, 197)
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(199, 32)
        Me.code.TabIndex = 21
        '
        'nom
        '
        Me.nom.BorderColor = System.Drawing.Color.SeaGreen
        Me.nom.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.Location = New System.Drawing.Point(156, 145)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(199, 32)
        Me.nom.TabIndex = 20
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(11, 309)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(128, 25)
        Me.BunifuCustomLabel5.TabIndex = 19
        Me.BunifuCustomLabel5.Text = "Desc Produit :"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(11, 256)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(120, 25)
        Me.BunifuCustomLabel4.TabIndex = 18
        Me.BunifuCustomLabel4.Text = "Prix Produit :"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(11, 202)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(132, 25)
        Me.BunifuCustomLabel3.TabIndex = 17
        Me.BunifuCustomLabel3.Text = "Code Produit :"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(11, 150)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(129, 25)
        Me.BunifuCustomLabel2.TabIndex = 16
        Me.BunifuCustomLabel2.Text = "Nom Produit :"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.[Interface].My.Resources.Resources._028_cancel_1
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(353, 12)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(25, 31)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 15
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(72, 43)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(250, 46)
        Me.Titre.TabIndex = 14
        Me.Titre.Text = "Ajouter Produit"
        '
        'ajouterProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(393, 504)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ajouterProduit"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ajouterProduit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents modifieBTN As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents confirmeBTN As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents desc As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents prix As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents code As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents nom As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Titre As Bunifu.Framework.UI.BunifuCustomLabel
End Class
