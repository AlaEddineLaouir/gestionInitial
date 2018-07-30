<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detailleApro
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dateApro = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.nomFour = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.prenomFour = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.telephoneFour = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.adressFour = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GridProduit = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.TotalPrix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombreproduit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1.SuspendLayout()
        CType(Me.GridProduit, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.dateApro)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.nomFour)
        Me.Panel1.Controls.Add(Me.prenomFour)
        Me.Panel1.Controls.Add(Me.telephoneFour)
        Me.Panel1.Controls.Add(Me.adressFour)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 220)
        Me.Panel1.TabIndex = 14
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(455, 140)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(60, 25)
        Me.BunifuCustomLabel3.TabIndex = 19
        Me.BunifuCustomLabel3.Text = "Date :"
        '
        'dateApro
        '
        Me.dateApro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dateApro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.dateApro.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dateApro.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateApro.ForeColor = System.Drawing.Color.Red
        Me.dateApro.Location = New System.Drawing.Point(562, 137)
        Me.dateApro.Name = "dateApro"
        Me.dateApro.ReadOnly = True
        Me.dateApro.Size = New System.Drawing.Size(180, 32)
        Me.dateApro.TabIndex = 18
        Me.dateApro.Text = "0"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(10, 95)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(222, 45)
        Me.BunifuCustomLabel2.TabIndex = 17
        Me.BunifuCustomLabel2.Text = "Detaille Apro :"
        '
        'nomFour
        '
        Me.nomFour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.nomFour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.nomFour.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.nomFour.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomFour.ForeColor = System.Drawing.Color.Red
        Me.nomFour.Location = New System.Drawing.Point(21, 55)
        Me.nomFour.Name = "nomFour"
        Me.nomFour.ReadOnly = True
        Me.nomFour.Size = New System.Drawing.Size(180, 32)
        Me.nomFour.TabIndex = 16
        Me.nomFour.Text = "0"
        '
        'prenomFour
        '
        Me.prenomFour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.prenomFour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.prenomFour.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.prenomFour.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenomFour.ForeColor = System.Drawing.Color.Red
        Me.prenomFour.Location = New System.Drawing.Point(219, 55)
        Me.prenomFour.Name = "prenomFour"
        Me.prenomFour.ReadOnly = True
        Me.prenomFour.Size = New System.Drawing.Size(180, 32)
        Me.prenomFour.TabIndex = 15
        Me.prenomFour.Text = "0"
        '
        'telephoneFour
        '
        Me.telephoneFour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.telephoneFour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.telephoneFour.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.telephoneFour.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telephoneFour.ForeColor = System.Drawing.Color.Red
        Me.telephoneFour.Location = New System.Drawing.Point(418, 55)
        Me.telephoneFour.Name = "telephoneFour"
        Me.telephoneFour.ReadOnly = True
        Me.telephoneFour.Size = New System.Drawing.Size(180, 32)
        Me.telephoneFour.TabIndex = 14
        Me.telephoneFour.Text = "0"
        '
        'adressFour
        '
        Me.adressFour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.adressFour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.adressFour.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.adressFour.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adressFour.ForeColor = System.Drawing.Color.Red
        Me.adressFour.Location = New System.Drawing.Point(604, 55)
        Me.adressFour.Name = "adressFour"
        Me.adressFour.ReadOnly = True
        Me.adressFour.Size = New System.Drawing.Size(180, 32)
        Me.adressFour.TabIndex = 13
        Me.adressFour.Text = "0"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(13, 5)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(265, 45)
        Me.BunifuCustomLabel1.TabIndex = 12
        Me.BunifuCustomLabel1.Text = "Info Fournisseur :"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(12, 168)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(228, 45)
        Me.BunifuCustomLabel4.TabIndex = 20
        Me.BunifuCustomLabel4.Text = "Liste Produits :"
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
        Me.GridProduit.Location = New System.Drawing.Point(2, 222)
        Me.GridProduit.Name = "GridProduit"
        Me.GridProduit.ReadOnly = True
        Me.GridProduit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridProduit.Size = New System.Drawing.Size(796, 226)
        Me.GridProduit.TabIndex = 16
        '
        'TotalPrix
        '
        Me.TotalPrix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TotalPrix.DataPropertyName = "produit"
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
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.[Interface].My.Resources.Resources._028_cancel_1
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(755, 12)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(29, 31)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 21
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'detailleApro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GridProduit)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "detailleApro"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Text = "detailleApro"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridProduit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dateApro As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents nomFour As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents prenomFour As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents telephoneFour As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents adressFour As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GridProduit As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents TotalPrix As DataGridViewTextBoxColumn
    Friend WithEvents Quantite As DataGridViewTextBoxColumn
    Friend WithEvents Nombreproduit As DataGridViewTextBoxColumn
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
End Class
