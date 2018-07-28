<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nouveauApro
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nouveauApro))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.idFournisseur = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuDatepicker1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GridProduit = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.TotalPrix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombreproduit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ttl = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.cd = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.slider = New System.Windows.Forms.PictureBox()
        Me.qt = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.prx = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.GridProduit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(12, 14)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(226, 45)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Nouveau Apro"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(59, 90)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(119, 25)
        Me.BunifuCustomLabel2.TabIndex = 1
        Me.BunifuCustomLabel2.Text = "Fournisseur :"
        '
        'idFournisseur
        '
        Me.idFournisseur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.idFournisseur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.idFournisseur.BorderColor = System.Drawing.Color.SeaGreen
        Me.idFournisseur.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idFournisseur.Location = New System.Drawing.Point(210, 87)
        Me.idFournisseur.Name = "idFournisseur"
        Me.idFournisseur.Size = New System.Drawing.Size(180, 32)
        Me.idFournisseur.TabIndex = 2
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(456, 90)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(60, 25)
        Me.BunifuCustomLabel3.TabIndex = 3
        Me.BunifuCustomLabel3.Text = "Date :"
        '
        'BunifuDatepicker1
        '
        Me.BunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuDatepicker1.BorderRadius = 0
        Me.BunifuDatepicker1.ForeColor = System.Drawing.Color.White
        Me.BunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.BunifuDatepicker1.FormatCustom = Nothing
        Me.BunifuDatepicker1.Location = New System.Drawing.Point(571, 83)
        Me.BunifuDatepicker1.Name = "BunifuDatepicker1"
        Me.BunifuDatepicker1.Size = New System.Drawing.Size(303, 36)
        Me.BunifuDatepicker1.TabIndex = 4
        Me.BunifuDatepicker1.Value = New Date(2018, 7, 26, 16, 19, 16, 291)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.prx)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel7)
        Me.Panel1.Controls.Add(Me.qt)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel6)
        Me.Panel1.Controls.Add(Me.slider)
        Me.Panel1.Controls.Add(Me.cd)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel1.Controls.Add(Me.BunifuImageButton3)
        Me.Panel1.Controls.Add(Me.BunifuThinButton21)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.BunifuDatepicker1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.idFournisseur)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(897, 214)
        Me.Panel1.TabIndex = 5
        '
        'GridProduit
        '
        Me.GridProduit.AllowUserToAddRows = False
        Me.GridProduit.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridProduit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridProduit.BackgroundColor = System.Drawing.Color.White
        Me.GridProduit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridProduit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridProduit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TotalPrix, Me.Quantite, Me.Nombreproduit})
        Me.GridProduit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridProduit.DoubleBuffered = True
        Me.GridProduit.EnableHeadersVisualStyles = False
        Me.GridProduit.GridColor = System.Drawing.SystemColors.Highlight
        Me.GridProduit.HeaderBgColor = System.Drawing.SystemColors.Highlight
        Me.GridProduit.HeaderForeColor = System.Drawing.Color.White
        Me.GridProduit.Location = New System.Drawing.Point(2, 216)
        Me.GridProduit.Name = "GridProduit"
        Me.GridProduit.ReadOnly = True
        Me.GridProduit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridProduit.Size = New System.Drawing.Size(897, 274)
        Me.GridProduit.TabIndex = 15
        '
        'TotalPrix
        '
        Me.TotalPrix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TotalPrix.DataPropertyName = "nomoCloture"
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.TotalPrix.DefaultCellStyle = DataGridViewCellStyle3
        Me.TotalPrix.DividerWidth = 1
        Me.TotalPrix.HeaderText = "Code"
        Me.TotalPrix.MinimumWidth = 100
        Me.TotalPrix.Name = "TotalPrix"
        Me.TotalPrix.ReadOnly = True
        '
        'Quantite
        '
        Me.Quantite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Quantite.DataPropertyName = "quantite"
        Me.Quantite.HeaderText = "Quantite"
        Me.Quantite.MinimumWidth = 100
        Me.Quantite.Name = "Quantite"
        Me.Quantite.ReadOnly = True
        '
        'Nombreproduit
        '
        Me.Nombreproduit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombreproduit.DataPropertyName = "prix"
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.Nombreproduit.DefaultCellStyle = DataGridViewCellStyle4
        Me.Nombreproduit.HeaderText = "Prix Produit"
        Me.Nombreproduit.MinimumWidth = 100
        Me.Nombreproduit.Name = "Nombreproduit"
        Me.Nombreproduit.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.BunifuImageButton2)
        Me.Panel2.Controls.Add(Me.BunifuImageButton1)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel2.Controls.Add(Me.ttl)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(2, 419)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(897, 71)
        Me.Panel2.TabIndex = 16
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(27, 24)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(61, 25)
        Me.BunifuCustomLabel4.TabIndex = 3
        Me.BunifuCustomLabel4.Text = "Total :"
        '
        'ttl
        '
        Me.ttl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ttl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ttl.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ttl.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttl.Location = New System.Drawing.Point(123, 21)
        Me.ttl.Name = "ttl"
        Me.ttl.ReadOnly = True
        Me.ttl.Size = New System.Drawing.Size(180, 32)
        Me.ttl.TabIndex = 4
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = Global.[Interface].My.Resources.Resources._028_cancel_1
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.InitialImage = Global.[Interface].My.Resources.Resources._032_check
        Me.BunifuImageButton2.Location = New System.Drawing.Point(786, 12)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(40, 47)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 6
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.[Interface].My.Resources.Resources._032_check
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.InitialImage = Global.[Interface].My.Resources.Resources._032_check
        Me.BunifuImageButton1.Location = New System.Drawing.Point(844, 12)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(45, 47)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 5
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.Image = Global.[Interface].My.Resources.Resources._028_cancel_1
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.InitialImage = Global.[Interface].My.Resources.Resources._032_check
        Me.BunifuImageButton3.Location = New System.Drawing.Point(856, 3)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(33, 35)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 7
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
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
        Me.BunifuThinButton21.ButtonText = "Ajouter Produit"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuThinButton21.IdleBorderThickness = 2
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(702, 136)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(181, 73)
        Me.BunifuThinButton21.TabIndex = 5
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cd
        '
        Me.cd.BorderColor = System.Drawing.Color.SeaGreen
        Me.cd.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cd.Location = New System.Drawing.Point(20, 176)
        Me.cd.Name = "cd"
        Me.cd.Size = New System.Drawing.Size(199, 32)
        Me.cd.TabIndex = 20
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(46, 148)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(132, 25)
        Me.BunifuCustomLabel5.TabIndex = 19
        Me.BunifuCustomLabel5.Text = "Code Produit :"
        '
        'slider
        '
        Me.slider.BackColor = System.Drawing.SystemColors.Highlight
        Me.slider.Location = New System.Drawing.Point(0, 132)
        Me.slider.Name = "slider"
        Me.slider.Size = New System.Drawing.Size(902, 3)
        Me.slider.TabIndex = 21
        Me.slider.TabStop = False
        '
        'qt
        '
        Me.qt.BorderColor = System.Drawing.Color.SeaGreen
        Me.qt.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qt.Location = New System.Drawing.Point(239, 176)
        Me.qt.Name = "qt"
        Me.qt.Size = New System.Drawing.Size(199, 32)
        Me.qt.TabIndex = 23
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(292, 148)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(94, 25)
        Me.BunifuCustomLabel6.TabIndex = 22
        Me.BunifuCustomLabel6.Text = "Quantite :"
        '
        'prx
        '
        Me.prx.BorderColor = System.Drawing.Color.SeaGreen
        Me.prx.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prx.Location = New System.Drawing.Point(458, 176)
        Me.prx.Name = "prx"
        Me.prx.Size = New System.Drawing.Size(199, 32)
        Me.prx.TabIndex = 25
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(505, 148)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(103, 25)
        Me.BunifuCustomLabel7.TabIndex = 24
        Me.BunifuCustomLabel7.Text = "Prix Unité :"
        '
        'nouveauApro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(901, 492)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GridProduit)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "nouveauApro"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Text = "Fournisseur :"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridProduit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents idFournisseur As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuDatepicker1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GridProduit As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ttl As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents TotalPrix As DataGridViewTextBoxColumn
    Friend WithEvents Quantite As DataGridViewTextBoxColumn
    Friend WithEvents Nombreproduit As DataGridViewTextBoxColumn
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents cd As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents slider As PictureBox
    Friend WithEvents qt As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents prx As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
