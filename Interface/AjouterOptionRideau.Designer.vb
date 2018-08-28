<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjouterOptionRideau
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AjouterOptionRideau))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.imageModele = New System.Windows.Forms.PictureBox()
        Me.selcImage = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.confirmeBTN = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.prix = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Titre = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dependence = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.multipliciter = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.nom = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.imageModele, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'imageModele
        '
        Me.imageModele.BackgroundImage = Global.[Interface].My.Resources.Resources._019_image
        Me.imageModele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imageModele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imageModele.InitialImage = Nothing
        Me.imageModele.Location = New System.Drawing.Point(507, 105)
        Me.imageModele.Name = "imageModele"
        Me.imageModele.Size = New System.Drawing.Size(307, 269)
        Me.imageModele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imageModele.TabIndex = 37
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
        Me.selcImage.Location = New System.Drawing.Point(586, 47)
        Me.selcImage.Margin = New System.Windows.Forms.Padding(5)
        Me.selcImage.Name = "selcImage"
        Me.selcImage.Size = New System.Drawing.Size(158, 50)
        Me.selcImage.TabIndex = 36
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
        Me.confirmeBTN.Location = New System.Drawing.Point(709, 406)
        Me.confirmeBTN.Margin = New System.Windows.Forms.Padding(5)
        Me.confirmeBTN.Name = "confirmeBTN"
        Me.confirmeBTN.Size = New System.Drawing.Size(158, 50)
        Me.confirmeBTN.TabIndex = 35
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
        Me.BunifuThinButton21.Location = New System.Drawing.Point(518, 406)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(158, 50)
        Me.BunifuThinButton21.TabIndex = 34
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'prix
        '
        Me.prix.BorderColor = System.Drawing.Color.SeaGreen
        Me.prix.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prix.Location = New System.Drawing.Point(180, 202)
        Me.prix.Name = "prix"
        Me.prix.Size = New System.Drawing.Size(199, 32)
        Me.prix.TabIndex = 32
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(35, 272)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(127, 25)
        Me.BunifuCustomLabel5.TabIndex = 31
        Me.BunifuCustomLabel5.Text = "Dependence :"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(35, 207)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(95, 25)
        Me.BunifuCustomLabel4.TabIndex = 30
        Me.BunifuCustomLabel4.Text = "Prix (DA) :"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.[Interface].My.Resources.Resources._028_cancel_1
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(825, 5)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(25, 31)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 29
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(18, 7)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(255, 46)
        Me.Titre.TabIndex = 28
        Me.Titre.Text = "Ajouter Modele"
        '
        'dependence
        '
        Me.dependence.AutoCompleteCustomSource.AddRange(New String() {"unite", "hauteur", "largeur", "surface"})
        Me.dependence.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dependence.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.dependence.BorderColor = System.Drawing.Color.SeaGreen
        Me.dependence.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dependence.Location = New System.Drawing.Point(180, 269)
        Me.dependence.Name = "dependence"
        Me.dependence.Size = New System.Drawing.Size(199, 32)
        Me.dependence.TabIndex = 38
        '
        'multipliciter
        '
        Me.multipliciter.BorderColor = System.Drawing.Color.SeaGreen
        Me.multipliciter.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multipliciter.Location = New System.Drawing.Point(180, 335)
        Me.multipliciter.Name = "multipliciter"
        Me.multipliciter.Size = New System.Drawing.Size(199, 32)
        Me.multipliciter.TabIndex = 40
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(35, 340)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(123, 25)
        Me.BunifuCustomLabel1.TabIndex = 39
        Me.BunifuCustomLabel1.Text = "Multipliciter :"
        '
        'nom
        '
        Me.nom.BorderColor = System.Drawing.Color.SeaGreen
        Me.nom.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.Location = New System.Drawing.Point(180, 141)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(199, 32)
        Me.nom.TabIndex = 42
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(35, 146)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(62, 25)
        Me.BunifuCustomLabel2.TabIndex = 41
        Me.BunifuCustomLabel2.Text = "Nom :"
        '
        'AjouterOptionRideau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(871, 484)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.multipliciter)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.dependence)
        Me.Controls.Add(Me.imageModele)
        Me.Controls.Add(Me.selcImage)
        Me.Controls.Add(Me.confirmeBTN)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.prix)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.Titre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AjouterOptionRideau"
        Me.Text = "AjouterOptionRideau"
        CType(Me.imageModele, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents imageModele As PictureBox
    Friend WithEvents selcImage As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents confirmeBTN As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents prix As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Titre As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents nom As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents multipliciter As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dependence As WindowsFormsControlLibrary1.BunifuCustomTextbox
End Class
