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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.NvModeleBTN = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GridModele = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imageModele = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel3.SuspendLayout()
        CType(Me.GridModele, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GridModele
        '
        Me.GridModele.AllowUserToAddRows = False
        Me.GridModele.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridModele.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridModele.BackgroundColor = System.Drawing.Color.White
        Me.GridModele.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridModele.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridModele.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridModele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridModele.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num, Me.prix, Me.Description, Me.imageModele})
        Me.GridModele.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridModele.DoubleBuffered = True
        Me.GridModele.EnableHeadersVisualStyles = False
        Me.GridModele.GridColor = System.Drawing.SystemColors.Highlight
        Me.GridModele.HeaderBgColor = System.Drawing.SystemColors.Highlight
        Me.GridModele.HeaderForeColor = System.Drawing.Color.White
        Me.GridModele.Location = New System.Drawing.Point(0, 74)
        Me.GridModele.Name = "GridModele"
        Me.GridModele.ReadOnly = True
        Me.GridModele.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridModele.Size = New System.Drawing.Size(1160, 760)
        Me.GridModele.TabIndex = 14
        '
        'Num
        '
        Me.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Num.DataPropertyName = "id"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num.DefaultCellStyle = DataGridViewCellStyle3
        Me.Num.HeaderText = "Numero"
        Me.Num.Name = "Num"
        Me.Num.ReadOnly = True
        '
        'prix
        '
        Me.prix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.prix.DataPropertyName = "prix"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.prix.DefaultCellStyle = DataGridViewCellStyle4
        Me.prix.HeaderText = "Prix"
        Me.prix.Name = "prix"
        Me.prix.ReadOnly = True
        '
        'Description
        '
        Me.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Description.DataPropertyName = "description"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Description.DefaultCellStyle = DataGridViewCellStyle5
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'imageModele
        '
        Me.imageModele.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.imageModele.DataPropertyName = "image"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.NullValue = CType(resources.GetObject("DataGridViewCellStyle6.NullValue"), Object)
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.imageModele.DefaultCellStyle = DataGridViewCellStyle6
        Me.imageModele.HeaderText = "Modele"
        Me.imageModele.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.imageModele.Name = "imageModele"
        Me.imageModele.ReadOnly = True
        Me.imageModele.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.imageModele.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Modele_Inox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GridModele)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Modele_Inox"
        Me.Size = New System.Drawing.Size(1160, 834)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.GridModele, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NvModeleBTN As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GridModele As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Num As DataGridViewTextBoxColumn
    Friend WithEvents prix As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents imageModele As DataGridViewImageColumn
End Class
