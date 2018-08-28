<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class automatisme
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(automatisme))
        Me.GridAuto = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.NvModeleBTN = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.depende = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imageModele = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.GridAuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridAuto
        '
        Me.GridAuto.AllowUserToAddRows = False
        Me.GridAuto.AllowUserToDeleteRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridAuto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.GridAuto.BackgroundColor = System.Drawing.Color.White
        Me.GridAuto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridAuto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridAuto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.GridAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridAuto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num, Me.noom, Me.depende, Me.prix, Me.imageModele})
        Me.GridAuto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAuto.DoubleBuffered = True
        Me.GridAuto.EnableHeadersVisualStyles = False
        Me.GridAuto.GridColor = System.Drawing.SystemColors.Highlight
        Me.GridAuto.HeaderBgColor = System.Drawing.SystemColors.Highlight
        Me.GridAuto.HeaderForeColor = System.Drawing.Color.White
        Me.GridAuto.Location = New System.Drawing.Point(0, 74)
        Me.GridAuto.Name = "GridAuto"
        Me.GridAuto.ReadOnly = True
        Me.GridAuto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridAuto.Size = New System.Drawing.Size(1011, 460)
        Me.GridAuto.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel7)
        Me.Panel3.Controls.Add(Me.NvModeleBTN)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1011, 74)
        Me.Panel3.TabIndex = 17
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(75, 14)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(295, 45)
        Me.BunifuCustomLabel7.TabIndex = 4
        Me.BunifuCustomLabel7.Text = "Automatisme Porte"
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
        Me.NvModeleBTN.ButtonText = "Nouveau Automatisme"
        Me.NvModeleBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NvModeleBTN.Dock = System.Windows.Forms.DockStyle.Right
        Me.NvModeleBTN.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NvModeleBTN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NvModeleBTN.IdleBorderThickness = 2
        Me.NvModeleBTN.IdleCornerRadius = 20
        Me.NvModeleBTN.IdleFillColor = System.Drawing.Color.White
        Me.NvModeleBTN.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NvModeleBTN.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NvModeleBTN.Location = New System.Drawing.Point(830, 0)
        Me.NvModeleBTN.Margin = New System.Windows.Forms.Padding(5)
        Me.NvModeleBTN.Name = "NvModeleBTN"
        Me.NvModeleBTN.Size = New System.Drawing.Size(181, 74)
        Me.NvModeleBTN.TabIndex = 3
        Me.NvModeleBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Num
        '
        Me.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Num.DataPropertyName = "id"
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.Num.DefaultCellStyle = DataGridViewCellStyle10
        Me.Num.HeaderText = "Numero"
        Me.Num.Name = "Num"
        Me.Num.ReadOnly = True
        '
        'noom
        '
        Me.noom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.noom.DataPropertyName = "nom"
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        Me.noom.DefaultCellStyle = DataGridViewCellStyle11
        Me.noom.HeaderText = "Nom"
        Me.noom.Name = "noom"
        Me.noom.ReadOnly = True
        '
        'depende
        '
        Me.depende.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.depende.DataPropertyName = "detaille"
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.depende.DefaultCellStyle = DataGridViewCellStyle12
        Me.depende.HeaderText = "Detaille"
        Me.depende.Name = "depende"
        Me.depende.ReadOnly = True
        '
        'prix
        '
        Me.prix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.prix.DataPropertyName = "prix"
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        Me.prix.DefaultCellStyle = DataGridViewCellStyle13
        Me.prix.HeaderText = "Prix"
        Me.prix.Name = "prix"
        Me.prix.ReadOnly = True
        '
        'imageModele
        '
        Me.imageModele.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.imageModele.DataPropertyName = "image"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.NullValue = CType(resources.GetObject("DataGridViewCellStyle14.NullValue"), Object)
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.imageModele.DefaultCellStyle = DataGridViewCellStyle14
        Me.imageModele.HeaderText = "Modele"
        Me.imageModele.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.imageModele.Name = "imageModele"
        Me.imageModele.ReadOnly = True
        Me.imageModele.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.imageModele.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'automatisme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GridAuto)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "automatisme"
        Me.Size = New System.Drawing.Size(1011, 534)
        CType(Me.GridAuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridAuto As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Num As DataGridViewTextBoxColumn
    Friend WithEvents noom As DataGridViewTextBoxColumn
    Friend WithEvents depende As DataGridViewTextBoxColumn
    Friend WithEvents prix As DataGridViewTextBoxColumn
    Friend WithEvents imageModele As DataGridViewImageColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents NvModeleBTN As Bunifu.Framework.UI.BunifuThinButton2
End Class
