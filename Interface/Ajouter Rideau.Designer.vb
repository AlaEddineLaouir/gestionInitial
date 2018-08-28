<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajouter_Rideau
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ajouter_Rideau))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GridComposant = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.QtRideau = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.totalArr = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.tauxRms = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.annuler = New Bunifu.Framework.UI.BunifuImageButton()
        Me.valider = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ttl = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.numCompo = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lg = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ht = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.prx = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dep = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.multi = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.slider = New System.Windows.Forms.PictureBox()
        Me.nomC = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.ajouterComposant = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.numeroCompo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombreproduit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixDebut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.GridComposant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.annuler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.slider, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GridComposant)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(903, 446)
        Me.Panel1.TabIndex = 0
        '
        'GridComposant
        '
        Me.GridComposant.AllowUserToAddRows = False
        Me.GridComposant.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridComposant.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridComposant.BackgroundColor = System.Drawing.Color.White
        Me.GridComposant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridComposant.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridComposant.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridComposant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridComposant.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numeroCompo, Me.TotalPrix, Me.Quantite, Me.Nombreproduit, Me.PrixDebut, Me.Cout})
        Me.GridComposant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridComposant.DoubleBuffered = True
        Me.GridComposant.EnableHeadersVisualStyles = False
        Me.GridComposant.GridColor = System.Drawing.SystemColors.Highlight
        Me.GridComposant.HeaderBgColor = System.Drawing.SystemColors.Highlight
        Me.GridComposant.HeaderForeColor = System.Drawing.Color.White
        Me.GridComposant.Location = New System.Drawing.Point(0, 188)
        Me.GridComposant.Name = "GridComposant"
        Me.GridComposant.ReadOnly = True
        Me.GridComposant.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridComposant.Size = New System.Drawing.Size(903, 170)
        Me.GridComposant.TabIndex = 19
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel7)
        Me.Panel3.Controls.Add(Me.QtRideau)
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel6)
        Me.Panel3.Controls.Add(Me.totalArr)
        Me.Panel3.Controls.Add(Me.tauxRms)
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel3.Controls.Add(Me.annuler)
        Me.Panel3.Controls.Add(Me.valider)
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel3.Controls.Add(Me.ttl)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 358)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(903, 88)
        Me.Panel3.TabIndex = 3
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(18, 14)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(178, 23)
        Me.BunifuCustomLabel7.TabIndex = 38
        Me.BunifuCustomLabel7.Text = "Nombre des Rideaux :"
        '
        'QtRideau
        '
        Me.QtRideau.BorderColor = System.Drawing.Color.SeaGreen
        Me.QtRideau.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtRideau.Location = New System.Drawing.Point(14, 47)
        Me.QtRideau.Name = "QtRideau"
        Me.QtRideau.Size = New System.Drawing.Size(185, 32)
        Me.QtRideau.TabIndex = 37
        Me.QtRideau.Text = "1"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(240, 50)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(95, 25)
        Me.BunifuCustomLabel6.TabIndex = 16
        Me.BunifuCustomLabel6.Text = "Arréter à :"
        '
        'totalArr
        '
        Me.totalArr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.totalArr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.totalArr.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.totalArr.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalArr.ForeColor = System.Drawing.Color.Red
        Me.totalArr.Location = New System.Drawing.Point(342, 47)
        Me.totalArr.Name = "totalArr"
        Me.totalArr.Size = New System.Drawing.Size(180, 32)
        Me.totalArr.TabIndex = 17
        Me.totalArr.Text = "0"
        '
        'tauxRms
        '
        Me.tauxRms.AutoSize = True
        Me.tauxRms.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tauxRms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tauxRms.Location = New System.Drawing.Point(683, 29)
        Me.tauxRms.Name = "tauxRms"
        Me.tauxRms.Size = New System.Drawing.Size(38, 25)
        Me.tauxRms.TabIndex = 15
        Me.tauxRms.Text = "0%"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(543, 29)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(123, 25)
        Me.BunifuCustomLabel8.TabIndex = 14
        Me.BunifuCustomLabel8.Text = "Taux Remise :"
        '
        'annuler
        '
        Me.annuler.BackColor = System.Drawing.Color.Transparent
        Me.annuler.Image = Global.[Interface].My.Resources.Resources._028_cancel_1
        Me.annuler.ImageActive = Nothing
        Me.annuler.InitialImage = Global.[Interface].My.Resources.Resources._032_check
        Me.annuler.Location = New System.Drawing.Point(779, 21)
        Me.annuler.Name = "annuler"
        Me.annuler.Size = New System.Drawing.Size(40, 47)
        Me.annuler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.annuler.TabIndex = 13
        Me.annuler.TabStop = False
        Me.annuler.Zoom = 10
        '
        'valider
        '
        Me.valider.BackColor = System.Drawing.Color.Transparent
        Me.valider.Image = Global.[Interface].My.Resources.Resources._032_check
        Me.valider.ImageActive = Nothing
        Me.valider.InitialImage = Global.[Interface].My.Resources.Resources._032_check
        Me.valider.Location = New System.Drawing.Point(837, 21)
        Me.valider.Name = "valider"
        Me.valider.Size = New System.Drawing.Size(45, 47)
        Me.valider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.valider.TabIndex = 12
        Me.valider.TabStop = False
        Me.valider.Zoom = 10
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(275, 11)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(61, 25)
        Me.BunifuCustomLabel4.TabIndex = 10
        Me.BunifuCustomLabel4.Text = "Total :"
        '
        'ttl
        '
        Me.ttl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ttl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ttl.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ttl.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttl.ForeColor = System.Drawing.Color.Red
        Me.ttl.Location = New System.Drawing.Point(343, 8)
        Me.ttl.Name = "ttl"
        Me.ttl.ReadOnly = True
        Me.ttl.Size = New System.Drawing.Size(180, 32)
        Me.ttl.TabIndex = 11
        Me.ttl.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel12)
        Me.Panel2.Controls.Add(Me.numCompo)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel11)
        Me.Panel2.Controls.Add(Me.lg)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel10)
        Me.Panel2.Controls.Add(Me.ht)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel9)
        Me.Panel2.Controls.Add(Me.prx)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel2.Controls.Add(Me.dep)
        Me.Panel2.Controls.Add(Me.multi)
        Me.Panel2.Controls.Add(Me.slider)
        Me.Panel2.Controls.Add(Me.nomC)
        Me.Panel2.Controls.Add(Me.ajouterComposant)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(903, 188)
        Me.Panel2.TabIndex = 2
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(615, 104)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New System.Drawing.Size(82, 23)
        Me.BunifuCustomLabel12.TabIndex = 44
        Me.BunifuCustomLabel12.Text = "Numero :"
        '
        'numCompo
        '
        Me.numCompo.BorderColor = System.Drawing.Color.SeaGreen
        Me.numCompo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCompo.Location = New System.Drawing.Point(585, 136)
        Me.numCompo.Name = "numCompo"
        Me.numCompo.ReadOnly = True
        Me.numCompo.Size = New System.Drawing.Size(128, 32)
        Me.numCompo.TabIndex = 43
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(580, 47)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(77, 23)
        Me.BunifuCustomLabel11.TabIndex = 42
        Me.BunifuCustomLabel11.Text = "Largeur :"
        '
        'lg
        '
        Me.lg.BorderColor = System.Drawing.Color.SeaGreen
        Me.lg.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lg.Location = New System.Drawing.Point(665, 43)
        Me.lg.Name = "lg"
        Me.lg.Size = New System.Drawing.Size(154, 32)
        Me.lg.TabIndex = 41
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(321, 47)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(81, 23)
        Me.BunifuCustomLabel10.TabIndex = 40
        Me.BunifuCustomLabel10.Text = "Hauteur :"
        '
        'ht
        '
        Me.ht.BorderColor = System.Drawing.Color.SeaGreen
        Me.ht.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ht.Location = New System.Drawing.Point(406, 43)
        Me.ht.Name = "ht"
        Me.ht.Size = New System.Drawing.Size(154, 32)
        Me.ht.TabIndex = 39
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(493, 104)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(47, 23)
        Me.BunifuCustomLabel9.TabIndex = 38
        Me.BunifuCustomLabel9.Text = "Prix :"
        '
        'prx
        '
        Me.prx.BorderColor = System.Drawing.Color.SeaGreen
        Me.prx.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prx.Location = New System.Drawing.Point(446, 136)
        Me.prx.Name = "prx"
        Me.prx.ReadOnly = True
        Me.prx.Size = New System.Drawing.Size(128, 32)
        Me.prx.TabIndex = 37
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(327, 104)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(112, 23)
        Me.BunifuCustomLabel3.TabIndex = 36
        Me.BunifuCustomLabel3.Text = "Depende de :"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(191, 104)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(103, 23)
        Me.BunifuCustomLabel2.TabIndex = 35
        Me.BunifuCustomLabel2.Text = "Multiplicite :"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(10, 104)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(150, 23)
        Me.BunifuCustomLabel5.TabIndex = 34
        Me.BunifuCustomLabel5.Text = "Nom Composant :"
        '
        'dep
        '
        Me.dep.BorderColor = System.Drawing.Color.SeaGreen
        Me.dep.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dep.Location = New System.Drawing.Point(322, 136)
        Me.dep.Name = "dep"
        Me.dep.ReadOnly = True
        Me.dep.Size = New System.Drawing.Size(117, 32)
        Me.dep.TabIndex = 32
        '
        'multi
        '
        Me.multi.BorderColor = System.Drawing.Color.SeaGreen
        Me.multi.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multi.Location = New System.Drawing.Point(168, 136)
        Me.multi.Name = "multi"
        Me.multi.ReadOnly = True
        Me.multi.Size = New System.Drawing.Size(147, 32)
        Me.multi.TabIndex = 31
        '
        'slider
        '
        Me.slider.BackColor = System.Drawing.SystemColors.Highlight
        Me.slider.Location = New System.Drawing.Point(-1, 90)
        Me.slider.Name = "slider"
        Me.slider.Size = New System.Drawing.Size(902, 3)
        Me.slider.TabIndex = 30
        Me.slider.TabStop = False
        '
        'nomC
        '
        Me.nomC.BorderColor = System.Drawing.Color.SeaGreen
        Me.nomC.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomC.Location = New System.Drawing.Point(7, 136)
        Me.nomC.Name = "nomC"
        Me.nomC.Size = New System.Drawing.Size(154, 32)
        Me.nomC.TabIndex = 29
        '
        'ajouterComposant
        '
        Me.ajouterComposant.ActiveBorderThickness = 1
        Me.ajouterComposant.ActiveCornerRadius = 20
        Me.ajouterComposant.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ajouterComposant.ActiveForecolor = System.Drawing.Color.White
        Me.ajouterComposant.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ajouterComposant.BackColor = System.Drawing.Color.White
        Me.ajouterComposant.BackgroundImage = CType(resources.GetObject("ajouterComposant.BackgroundImage"), System.Drawing.Image)
        Me.ajouterComposant.ButtonText = "Ajouter Composant"
        Me.ajouterComposant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ajouterComposant.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ajouterComposant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ajouterComposant.IdleBorderThickness = 2
        Me.ajouterComposant.IdleCornerRadius = 20
        Me.ajouterComposant.IdleFillColor = System.Drawing.Color.White
        Me.ajouterComposant.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ajouterComposant.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ajouterComposant.Location = New System.Drawing.Point(731, 104)
        Me.ajouterComposant.Margin = New System.Windows.Forms.Padding(5)
        Me.ajouterComposant.Name = "ajouterComposant"
        Me.ajouterComposant.Size = New System.Drawing.Size(162, 73)
        Me.ajouterComposant.TabIndex = 28
        Me.ajouterComposant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(32, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(231, 45)
        Me.BunifuCustomLabel1.TabIndex = 1
        Me.BunifuCustomLabel1.Text = "Ajouter Rideau"
        '
        'numeroCompo
        '
        Me.numeroCompo.HeaderText = "Numero"
        Me.numeroCompo.MinimumWidth = 50
        Me.numeroCompo.Name = "numeroCompo"
        Me.numeroCompo.ReadOnly = True
        Me.numeroCompo.Width = 50
        '
        'TotalPrix
        '
        Me.TotalPrix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.TotalPrix.DefaultCellStyle = DataGridViewCellStyle3
        Me.TotalPrix.DividerWidth = 1
        Me.TotalPrix.HeaderText = "Nom"
        Me.TotalPrix.MinimumWidth = 100
        Me.TotalPrix.Name = "TotalPrix"
        Me.TotalPrix.ReadOnly = True
        '
        'Quantite
        '
        Me.Quantite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Quantite.DefaultCellStyle = DataGridViewCellStyle4
        Me.Quantite.HeaderText = "Multiplicite"
        Me.Quantite.MinimumWidth = 100
        Me.Quantite.Name = "Quantite"
        Me.Quantite.ReadOnly = True
        '
        'Nombreproduit
        '
        Me.Nombreproduit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.Nombreproduit.DefaultCellStyle = DataGridViewCellStyle5
        Me.Nombreproduit.HeaderText = "Depend de"
        Me.Nombreproduit.MinimumWidth = 100
        Me.Nombreproduit.Name = "Nombreproduit"
        Me.Nombreproduit.ReadOnly = True
        '
        'PrixDebut
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PrixDebut.DefaultCellStyle = DataGridViewCellStyle6
        Me.PrixDebut.HeaderText = "Prix "
        Me.PrixDebut.Name = "PrixDebut"
        Me.PrixDebut.ReadOnly = True
        '
        'Cout
        '
        Me.Cout.HeaderText = "Cout"
        Me.Cout.Name = "Cout"
        Me.Cout.ReadOnly = True
        '
        'Ajouter_Rideau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(907, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ajouter_Rideau"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Text = "Ajouter_Rideau"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridComposant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.annuler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.slider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dep As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents multi As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents slider As PictureBox
    Friend WithEvents nomC As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents ajouterComposant As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tauxRms As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents annuler As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents valider As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ttl As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents GridComposant As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents QtRideau As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents totalArr As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents prx As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lg As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ht As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents numCompo As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents numeroCompo As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrix As DataGridViewTextBoxColumn
    Friend WithEvents Quantite As DataGridViewTextBoxColumn
    Friend WithEvents Nombreproduit As DataGridViewTextBoxColumn
    Friend WithEvents PrixDebut As DataGridViewTextBoxColumn
    Friend WithEvents Cout As DataGridViewTextBoxColumn
End Class
