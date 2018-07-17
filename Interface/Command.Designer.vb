<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Command
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Command))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.brandMin = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ProduitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vb_testDataSet = New [Interface].vb_testDataSet()
        Me.ProduitTableAdapter = New [Interface].vb_testDataSetTableAdapters.produitTableAdapter()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.GridCommand = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProduit = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.nomProduit = New Bunifu.Framework.UI.BunifuMetroTextbox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vb_testDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCommand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'brandMin
        '
        Me.brandMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.brandMin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.brandMin.Enabled = False
        Me.brandMin.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brandMin.ForeColor = System.Drawing.SystemColors.Info
        Me.brandMin.Location = New System.Drawing.Point(73, 18)
        Me.brandMin.Name = "brandMin"
        Me.brandMin.Size = New System.Drawing.Size(181, 36)
        Me.brandMin.TabIndex = 4
        Me.brandMin.Text = "Commande"
        Me.brandMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(887, 82)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(65, 58)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 6
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10

        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(842, 210)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(71, 71)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 8
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'GridCommand
        '
        Me.GridCommand.AllowUserToAddRows = False
        Me.GridCommand.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridCommand.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridCommand.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.GridCommand.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridCommand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridCommand.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridCommand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridCommand.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nom})
        Me.GridCommand.DoubleBuffered = True
        Me.GridCommand.EnableHeadersVisualStyles = False
        Me.GridCommand.GridColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GridCommand.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GridCommand.HeaderForeColor = System.Drawing.Color.White
        Me.GridCommand.Location = New System.Drawing.Point(73, 210)
        Me.GridCommand.Name = "GridCommand"
        Me.GridCommand.ReadOnly = True
        Me.GridCommand.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridCommand.Size = New System.Drawing.Size(681, 315)
        Me.GridCommand.TabIndex = 9
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id.DataPropertyName = "id"
        Me.id.DividerWidth = 5
        Me.id.HeaderText = "IdProduit"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'nom
        '
        Me.nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nom.DataPropertyName = "nom"
        Me.nom.DividerWidth = 5
        Me.nom.HeaderText = "Nom Produit"
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
        '
        'idProduit
        '
        Me.idProduit.BorderColorFocused = System.Drawing.Color.Blue
        Me.idProduit.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.idProduit.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.idProduit.BorderThickness = 3
        Me.idProduit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idProduit.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.idProduit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.idProduit.isPassword = False
        Me.idProduit.Location = New System.Drawing.Point(414, 96)
        Me.idProduit.Margin = New System.Windows.Forms.Padding(4)
        Me.idProduit.Name = "idProduit"
        Me.idProduit.Size = New System.Drawing.Size(183, 44)
        Me.idProduit.TabIndex = 10
        Me.idProduit.Text = "Id"
        Me.idProduit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'nomProduit
        '
        Me.nomProduit.BorderColorFocused = System.Drawing.Color.Blue
        Me.nomProduit.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nomProduit.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.nomProduit.BorderThickness = 3
        Me.nomProduit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nomProduit.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.nomProduit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nomProduit.isPassword = False
        Me.nomProduit.Location = New System.Drawing.Point(642, 96)
        Me.nomProduit.Margin = New System.Windows.Forms.Padding(4)
        Me.nomProduit.Name = "nomProduit"
        Me.nomProduit.Size = New System.Drawing.Size(183, 44)
        Me.nomProduit.TabIndex = 11
        Me.nomProduit.Text = "Nom Produit"
        Me.nomProduit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Command
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.nomProduit)
        Me.Controls.Add(Me.idProduit)
        Me.Controls.Add(Me.GridCommand)
        Me.Controls.Add(Me.BunifuImageButton2)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.brandMin)
        Me.Name = "Command"
        Me.Size = New System.Drawing.Size(993, 589)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vb_testDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCommand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents brandMin As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ProduitBindingSource As BindingSource
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents GridCommand As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nom As DataGridViewTextBoxColumn
    Friend WithEvents idProduit As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents nomProduit As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Vb_testDataSet As Object
    Friend WithEvents ProduitTableAdapter As Object
End Class
