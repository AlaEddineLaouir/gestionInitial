<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ajouterAutomatisme
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ajouterAutomatisme))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.nom = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.detaille = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.imageModele = New System.Windows.Forms.PictureBox()
        Me.selcImage = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.confirmeBTN = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.prix = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Titre = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.imageModele, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.nom)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.detaille)
        Me.Panel1.Controls.Add(Me.imageModele)
        Me.Panel1.Controls.Add(Me.selcImage)
        Me.Panel1.Controls.Add(Me.confirmeBTN)
        Me.Panel1.Controls.Add(Me.BunifuThinButton21)
        Me.Panel1.Controls.Add(Me.prix)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.Titre)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(837, 467)
        Me.Panel1.TabIndex = 0
        '
        'nom
        '
        Me.nom.BorderColor = System.Drawing.Color.SeaGreen
        Me.nom.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.Location = New System.Drawing.Point(190, 144)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(199, 32)
        Me.nom.TabIndex = 70
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(47, 151)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(62, 25)
        Me.BunifuCustomLabel2.TabIndex = 69
        Me.BunifuCustomLabel2.Text = "Nom :"
        '
        'detaille
        '
        Me.detaille.AutoCompleteCustomSource.AddRange(New String() {"unite", "hauteur", "largeur", "surface"})
        Me.detaille.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.detaille.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.detaille.BorderColor = System.Drawing.Color.SeaGreen
        Me.detaille.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detaille.Location = New System.Drawing.Point(190, 272)
        Me.detaille.Multiline = True
        Me.detaille.Name = "detaille"
        Me.detaille.Size = New System.Drawing.Size(199, 166)
        Me.detaille.TabIndex = 66
        '
        'imageModele
        '
        Me.imageModele.BackgroundImage = Global.[Interface].My.Resources.Resources._019_image
        Me.imageModele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imageModele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imageModele.InitialImage = Nothing
        Me.imageModele.Location = New System.Drawing.Point(470, 108)
        Me.imageModele.Name = "imageModele"
        Me.imageModele.Size = New System.Drawing.Size(307, 269)
        Me.imageModele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imageModele.TabIndex = 65
        Me.imageModele.TabStop = False
        '
        'selcImage
        '
        Me.selcImage.ActiveBorderThickness = 1
        Me.selcImage.ActiveCornerRadius = 20
        Me.selcImage.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.selcImage.ActiveForecolor = System.Drawing.Color.White
        Me.selcImage.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.selcImage.BackColor = System.Drawing.Color.White
        Me.selcImage.BackgroundImage = CType(resources.GetObject("selcImage.BackgroundImage"), System.Drawing.Image)
        Me.selcImage.ButtonText = "Selectionner Image"
        Me.selcImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.selcImage.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selcImage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.selcImage.IdleBorderThickness = 2
        Me.selcImage.IdleCornerRadius = 20
        Me.selcImage.IdleFillColor = System.Drawing.Color.White
        Me.selcImage.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.selcImage.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.selcImage.Location = New System.Drawing.Point(550, 50)
        Me.selcImage.Margin = New System.Windows.Forms.Padding(5)
        Me.selcImage.Name = "selcImage"
        Me.selcImage.Size = New System.Drawing.Size(158, 50)
        Me.selcImage.TabIndex = 64
        Me.selcImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.confirmeBTN.Location = New System.Drawing.Point(665, 409)
        Me.confirmeBTN.Margin = New System.Windows.Forms.Padding(5)
        Me.confirmeBTN.Name = "confirmeBTN"
        Me.confirmeBTN.Size = New System.Drawing.Size(158, 50)
        Me.confirmeBTN.TabIndex = 63
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
        Me.BunifuThinButton21.Location = New System.Drawing.Point(474, 409)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(158, 50)
        Me.BunifuThinButton21.TabIndex = 62
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'prix
        '
        Me.prix.BorderColor = System.Drawing.Color.SeaGreen
        Me.prix.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prix.Location = New System.Drawing.Point(190, 205)
        Me.prix.Name = "prix"
        Me.prix.Size = New System.Drawing.Size(199, 32)
        Me.prix.TabIndex = 61
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(47, 277)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(85, 25)
        Me.BunifuCustomLabel5.TabIndex = 60
        Me.BunifuCustomLabel5.Text = "Detaille :"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(47, 212)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(95, 25)
        Me.BunifuCustomLabel4.TabIndex = 59
        Me.BunifuCustomLabel4.Text = "Prix (DA) :"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.[Interface].My.Resources.Resources._028_cancel_1
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(781, 8)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(25, 31)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 58
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(14, 12)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(340, 46)
        Me.Titre.TabIndex = 57
        Me.Titre.Text = "Ajouter Automatisme"
        '
        'ajouterAutomatisme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(841, 471)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ajouterAutomatisme"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Text = "ajouterAutomatisme"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.imageModele, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents nom As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents detaille As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents imageModele As PictureBox
    Friend WithEvents selcImage As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents confirmeBTN As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents prix As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Titre As Bunifu.Framework.UI.BunifuCustomLabel
End Class
