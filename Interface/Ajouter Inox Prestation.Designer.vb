<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajouter_Inox_Prestation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ajouter_Inox_Prestation))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.prixArr = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.prix = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tauxRms = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ttl = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.valider = New Bunifu.Framework.UI.BunifuImageButton()
        Me.spec = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Qt = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.imageModele = New System.Windows.Forms.PictureBox()
        Me.selcImage = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.num = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Titre = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageModele, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.prixArr)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel6)
        Me.Panel1.Controls.Add(Me.prix)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.tauxRms)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.ttl)
        Me.Panel1.Controls.Add(Me.BunifuImageButton2)
        Me.Panel1.Controls.Add(Me.valider)
        Me.Panel1.Controls.Add(Me.spec)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel1.Controls.Add(Me.Qt)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.imageModele)
        Me.Panel1.Controls.Add(Me.selcImage)
        Me.Panel1.Controls.Add(Me.num)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel1.Controls.Add(Me.Titre)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 446)
        Me.Panel1.TabIndex = 0
        '
        'prixArr
        '
        Me.prixArr.BorderColor = System.Drawing.Color.SeaGreen
        Me.prixArr.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prixArr.Location = New System.Drawing.Point(176, 170)
        Me.prixArr.Name = "prixArr"
        Me.prixArr.Size = New System.Drawing.Size(199, 32)
        Me.prixArr.TabIndex = 51
        Me.prixArr.Text = "0"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(31, 175)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(89, 25)
        Me.BunifuCustomLabel6.TabIndex = 50
        Me.BunifuCustomLabel6.Text = "Prix Arr  :"
        '
        'prix
        '
        Me.prix.BorderColor = System.Drawing.Color.SeaGreen
        Me.prix.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prix.Location = New System.Drawing.Point(176, 125)
        Me.prix.Name = "prix"
        Me.prix.ReadOnly = True
        Me.prix.Size = New System.Drawing.Size(199, 32)
        Me.prix.TabIndex = 49
        Me.prix.Text = "0"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(31, 130)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(58, 25)
        Me.BunifuCustomLabel2.TabIndex = 48
        Me.BunifuCustomLabel2.Text = "Prix  :"
        '
        'tauxRms
        '
        Me.tauxRms.AutoSize = True
        Me.tauxRms.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tauxRms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tauxRms.Location = New System.Drawing.Point(493, 407)
        Me.tauxRms.Name = "tauxRms"
        Me.tauxRms.Size = New System.Drawing.Size(38, 25)
        Me.tauxRms.TabIndex = 47
        Me.tauxRms.Text = "0%"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(353, 407)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(123, 25)
        Me.BunifuCustomLabel8.TabIndex = 46
        Me.BunifuCustomLabel8.Text = "Taux Remise :"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(31, 407)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(61, 25)
        Me.BunifuCustomLabel3.TabIndex = 44
        Me.BunifuCustomLabel3.Text = "Total :"
        '
        'ttl
        '
        Me.ttl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ttl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ttl.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ttl.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttl.ForeColor = System.Drawing.Color.Red
        Me.ttl.Location = New System.Drawing.Point(127, 404)
        Me.ttl.Name = "ttl"
        Me.ttl.ReadOnly = True
        Me.ttl.Size = New System.Drawing.Size(180, 32)
        Me.ttl.TabIndex = 45
        Me.ttl.Text = "0"
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = Global.[Interface].My.Resources.Resources._028_cancel_1
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.InitialImage = Global.[Interface].My.Resources.Resources._032_check
        Me.BunifuImageButton2.Location = New System.Drawing.Point(683, 396)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(40, 47)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 43
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'valider
        '
        Me.valider.BackColor = System.Drawing.Color.Transparent
        Me.valider.Image = Global.[Interface].My.Resources.Resources._032_check
        Me.valider.ImageActive = Nothing
        Me.valider.InitialImage = Global.[Interface].My.Resources.Resources._032_check
        Me.valider.Location = New System.Drawing.Point(741, 396)
        Me.valider.Name = "valider"
        Me.valider.Size = New System.Drawing.Size(45, 47)
        Me.valider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.valider.TabIndex = 42
        Me.valider.TabStop = False
        Me.valider.Zoom = 10
        '
        'spec
        '
        Me.spec.BorderColor = System.Drawing.Color.SeaGreen
        Me.spec.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spec.Location = New System.Drawing.Point(176, 261)
        Me.spec.Multiline = True
        Me.spec.Name = "spec"
        Me.spec.Size = New System.Drawing.Size(199, 77)
        Me.spec.TabIndex = 41
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(31, 266)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(129, 25)
        Me.BunifuCustomLabel5.TabIndex = 40
        Me.BunifuCustomLabel5.Text = "Specification :"
        '
        'Qt
        '
        Me.Qt.BorderColor = System.Drawing.Color.SeaGreen
        Me.Qt.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qt.Location = New System.Drawing.Point(176, 213)
        Me.Qt.Name = "Qt"
        Me.Qt.Size = New System.Drawing.Size(199, 32)
        Me.Qt.TabIndex = 37
        Me.Qt.Text = "0"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(31, 218)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(94, 25)
        Me.BunifuCustomLabel1.TabIndex = 36
        Me.BunifuCustomLabel1.Text = "Quantite :"
        '
        'imageModele
        '
        Me.imageModele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imageModele.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imageModele.InitialImage = Nothing
        Me.imageModele.Location = New System.Drawing.Point(459, 22)
        Me.imageModele.Name = "imageModele"
        Me.imageModele.Size = New System.Drawing.Size(307, 269)
        Me.imageModele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imageModele.TabIndex = 35
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
        Me.selcImage.ButtonText = "Afficher Image"
        Me.selcImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.selcImage.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selcImage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.selcImage.IdleBorderThickness = 2
        Me.selcImage.IdleCornerRadius = 20
        Me.selcImage.IdleFillColor = System.Drawing.Color.White
        Me.selcImage.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.selcImage.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.selcImage.Location = New System.Drawing.Point(551, 300)
        Me.selcImage.Margin = New System.Windows.Forms.Padding(5)
        Me.selcImage.Name = "selcImage"
        Me.selcImage.Size = New System.Drawing.Size(158, 50)
        Me.selcImage.TabIndex = 34
        Me.selcImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'num
        '
        Me.num.BorderColor = System.Drawing.Color.SeaGreen
        Me.num.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num.Location = New System.Drawing.Point(176, 79)
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(199, 32)
        Me.num.TabIndex = 32
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(31, 84)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(95, 25)
        Me.BunifuCustomLabel4.TabIndex = 30
        Me.BunifuCustomLabel4.Text = "Numero  :"
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(16, 9)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(255, 46)
        Me.Titre.TabIndex = 28
        Me.Titre.Text = "Ajouter Modele"
        '
        'Ajouter_Inox_Prestation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ajouter_Inox_Prestation"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Text = "Ajouter_Inox_Prestation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageModele, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents spec As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Qt As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents imageModele As PictureBox
    Friend WithEvents selcImage As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents num As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Titre As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents valider As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tauxRms As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ttl As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents prixArr As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents prix As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
