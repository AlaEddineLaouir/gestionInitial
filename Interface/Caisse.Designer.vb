<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Caisse
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GridCaisse = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.EtatCaisse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dateDeSelection = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Initial = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GridProduit = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.TotalPrix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fournisseur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateArrivague = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombreproduit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateEn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.heureE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nature = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montatn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GridCaisse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GridProduit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridCaisse
        '
        Me.GridCaisse.AllowUserToAddRows = False
        Me.GridCaisse.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridCaisse.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridCaisse.BackgroundColor = System.Drawing.Color.White
        Me.GridCaisse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridCaisse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridCaisse.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridCaisse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridCaisse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCaisse.DoubleBuffered = True
        Me.GridCaisse.EnableHeadersVisualStyles = False
        Me.GridCaisse.GridColor = System.Drawing.SystemColors.Highlight
        Me.GridCaisse.HeaderBgColor = System.Drawing.SystemColors.Highlight
        Me.GridCaisse.HeaderForeColor = System.Drawing.Color.White
        Me.GridCaisse.Location = New System.Drawing.Point(0, 129)
        Me.GridCaisse.Name = "GridCaisse"
        Me.GridCaisse.ReadOnly = True
        Me.GridCaisse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridCaisse.Size = New System.Drawing.Size(969, 364)
        Me.GridCaisse.TabIndex = 15
        '
        'EtatCaisse
        '
        Me.EtatCaisse.DataPropertyName = "etatCaisse"
        Me.EtatCaisse.HeaderText = "Etat Caisse"
        Me.EtatCaisse.Name = "EtatCaisse"
        Me.EtatCaisse.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Initial)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton2)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.dateDeSelection)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(969, 129)
        Me.Panel1.TabIndex = 13
        '
        'dateDeSelection
        '
        Me.dateDeSelection.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dateDeSelection.BorderRadius = 0
        Me.dateDeSelection.ForeColor = System.Drawing.Color.White
        Me.dateDeSelection.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateDeSelection.FormatCustom = Nothing
        Me.dateDeSelection.Location = New System.Drawing.Point(227, 18)
        Me.dateDeSelection.Name = "dateDeSelection"
        Me.dateDeSelection.Size = New System.Drawing.Size(223, 36)
        Me.dateDeSelection.TabIndex = 12
        Me.dateDeSelection.Value = New Date(2018, 7, 26, 14, 5, 52, 840)
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(9, 24)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(190, 25)
        Me.BunifuCustomLabel1.TabIndex = 13
        Me.BunifuCustomLabel1.Text = "Etat Caisse depuit le :"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.Firebrick
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Firebrick
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Debiter"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(730, 18)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Firebrick
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Firebrick
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(102, 36)
        Me.BunifuFlatButton1.TabIndex = 14
        Me.BunifuFlatButton1.Text = "Debiter"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Crediter"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(854, 18)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(95, 36)
        Me.BunifuFlatButton2.TabIndex = 15
        Me.BunifuFlatButton2.Text = "Crediter"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(568, 89)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(126, 25)
        Me.BunifuCustomLabel2.TabIndex = 16
        Me.BunifuCustomLabel2.Text = "Initialemant  :"
        '
        'Initial
        '
        Me.Initial.AutoSize = True
        Me.Initial.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Initial.ForeColor = System.Drawing.Color.Firebrick
        Me.Initial.Location = New System.Drawing.Point(849, 84)
        Me.Initial.Name = "Initial"
        Me.Initial.Size = New System.Drawing.Size(42, 30)
        Me.Initial.TabIndex = 17
        Me.Initial.Text = "0,0"
        '
        'GridProduit
        '
        Me.GridProduit.AllowUserToAddRows = False
        Me.GridProduit.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridProduit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.GridProduit.BackgroundColor = System.Drawing.Color.White
        Me.GridProduit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridProduit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridProduit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridProduit.DoubleBuffered = True
        Me.GridProduit.EnableHeadersVisualStyles = False
        Me.GridProduit.GridColor = System.Drawing.SystemColors.Highlight
        Me.GridProduit.HeaderBgColor = System.Drawing.SystemColors.Highlight
        Me.GridProduit.HeaderForeColor = System.Drawing.Color.White
        Me.GridProduit.Location = New System.Drawing.Point(0, 0)
        Me.GridProduit.Name = "GridProduit"
        Me.GridProduit.ReadOnly = True
        Me.GridProduit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridProduit.Size = New System.Drawing.Size(969, 493)
        Me.GridProduit.TabIndex = 14
        '
        'TotalPrix
        '
        Me.TotalPrix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TotalPrix.DataPropertyName = "total"
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.TotalPrix.DefaultCellStyle = DataGridViewCellStyle5
        Me.TotalPrix.DividerWidth = 1
        Me.TotalPrix.HeaderText = "TotalPrix"
        Me.TotalPrix.MinimumWidth = 50
        Me.TotalPrix.Name = "TotalPrix"
        Me.TotalPrix.ReadOnly = True
        '
        'Fournisseur
        '
        Me.Fournisseur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Fournisseur.DataPropertyName = "four"
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.Fournisseur.DefaultCellStyle = DataGridViewCellStyle6
        Me.Fournisseur.HeaderText = "Fournisseur"
        Me.Fournisseur.Name = "Fournisseur"
        Me.Fournisseur.ReadOnly = True
        '
        'DateArrivague
        '
        Me.DateArrivague.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateArrivague.DataPropertyName = "date"
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.DateArrivague.DefaultCellStyle = DataGridViewCellStyle7
        Me.DateArrivague.HeaderText = "Date "
        Me.DateArrivague.Name = "DateArrivague"
        Me.DateArrivague.ReadOnly = True
        '
        'Nombreproduit
        '
        Me.Nombreproduit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombreproduit.DataPropertyName = "nombre"
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.Nombreproduit.DefaultCellStyle = DataGridViewCellStyle8
        Me.Nombreproduit.HeaderText = "Nombre Produit"
        Me.Nombreproduit.Name = "Nombreproduit"
        Me.Nombreproduit.ReadOnly = True
        '
        'dateEn
        '
        Me.dateEn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dateEn.DataPropertyName = "ladate"
        Me.dateEn.HeaderText = "Date"
        Me.dateEn.Name = "dateEn"
        Me.dateEn.ReadOnly = True
        '
        'heureE
        '
        Me.heureE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.heureE.DataPropertyName = "heure"
        Me.heureE.HeaderText = "Heure"
        Me.heureE.Name = "heureE"
        Me.heureE.ReadOnly = True
        '
        'nature
        '
        Me.nature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nature.DataPropertyName = "nature"
        Me.nature.HeaderText = "Nature"
        Me.nature.Name = "nature"
        Me.nature.ReadOnly = True
        '
        'type
        '
        Me.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.type.DataPropertyName = "type"
        Me.type.HeaderText = "Action"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        Me.type.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'montatn
        '
        Me.montatn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.montatn.DataPropertyName = "montant"
        Me.montatn.HeaderText = "Montant"
        Me.montatn.Name = "montatn"
        Me.montatn.ReadOnly = True
        '
        'obs
        '
        Me.obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.obs.DataPropertyName = "obs"
        Me.obs.HeaderText = "Obs"
        Me.obs.MinimumWidth = 250
        Me.obs.Name = "obs"
        Me.obs.ReadOnly = True
        '
        'Caisse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GridCaisse)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridProduit)
        Me.Name = "Caisse"
        Me.Size = New System.Drawing.Size(969, 493)
        CType(Me.GridCaisse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridProduit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridCaisse As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents EtatCaisse As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Initial As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dateDeSelection As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents GridProduit As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents TotalPrix As DataGridViewTextBoxColumn
    Friend WithEvents Fournisseur As DataGridViewTextBoxColumn
    Friend WithEvents DateArrivague As DataGridViewTextBoxColumn
    Friend WithEvents Nombreproduit As DataGridViewTextBoxColumn
    Friend WithEvents dateEn As DataGridViewTextBoxColumn
    Friend WithEvents heureE As DataGridViewTextBoxColumn
    Friend WithEvents nature As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents montatn As DataGridViewTextBoxColumn
    Friend WithEvents obs As DataGridViewTextBoxColumn
End Class
