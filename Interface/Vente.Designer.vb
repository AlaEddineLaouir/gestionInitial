﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vente))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuDatepicker1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GridProduit = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.TotalPrix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fournisseur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateArrivague = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombreproduit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuCustomDataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.GridProduit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuDatepicker1
        '
        Me.BunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuDatepicker1.BorderRadius = 0
        Me.BunifuDatepicker1.ForeColor = System.Drawing.Color.White
        Me.BunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.BunifuDatepicker1.FormatCustom = Nothing
        Me.BunifuDatepicker1.Location = New System.Drawing.Point(473, 16)
        Me.BunifuDatepicker1.Name = "BunifuDatepicker1"
        Me.BunifuDatepicker1.Size = New System.Drawing.Size(303, 36)
        Me.BunifuDatepicker1.TabIndex = 12
        Me.BunifuDatepicker1.Value = New Date(2018, 7, 26, 14, 5, 52, 840)
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
        Me.BunifuThinButton21.ButtonText = "Nouvelle Vente"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuThinButton21.IdleBorderThickness = 2
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(812, 0)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(181, 73)
        Me.BunifuThinButton21.TabIndex = 3
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel2.Controls.Add(Me.BunifuDatepicker1)
        Me.Panel2.Controls.Add(Me.BunifuThinButton21)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(993, 73)
        Me.Panel2.TabIndex = 14
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(232, 22)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(174, 25)
        Me.BunifuCustomLabel1.TabIndex = 13
        Me.BunifuCustomLabel1.Text = "Les Vente Apres le :"
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
        Me.GridProduit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TotalPrix, Me.Fournisseur, Me.DateArrivague, Me.Nombreproduit})
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
        Me.GridProduit.Size = New System.Drawing.Size(993, 589)
        Me.GridProduit.TabIndex = 15
        '
        'TotalPrix
        '
        Me.TotalPrix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TotalPrix.DataPropertyName = "total"
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.TotalPrix.DefaultCellStyle = DataGridViewCellStyle3
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
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.Fournisseur.DefaultCellStyle = DataGridViewCellStyle4
        Me.Fournisseur.HeaderText = "Fournisseur"
        Me.Fournisseur.Name = "Fournisseur"
        Me.Fournisseur.ReadOnly = True
        '
        'DateArrivague
        '
        Me.DateArrivague.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateArrivague.DataPropertyName = "date"
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DateArrivague.DefaultCellStyle = DataGridViewCellStyle5
        Me.DateArrivague.HeaderText = "Date "
        Me.DateArrivague.Name = "DateArrivague"
        Me.DateArrivague.ReadOnly = True
        '
        'Nombreproduit
        '
        Me.Nombreproduit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombreproduit.DataPropertyName = "nombre"
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.Nombreproduit.DefaultCellStyle = DataGridViewCellStyle6
        Me.Nombreproduit.HeaderText = "Nombre Produit"
        Me.Nombreproduit.Name = "Nombreproduit"
        Me.Nombreproduit.ReadOnly = True
        '
        'BunifuCustomDataGrid1
        '
        Me.BunifuCustomDataGrid1.AllowUserToAddRows = False
        Me.BunifuCustomDataGrid1.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.BunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.GridColor = System.Drawing.SystemColors.Highlight
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.SystemColors.Highlight
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(0, 73)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.ReadOnly = True
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(993, 516)
        Me.BunifuCustomDataGrid1.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "total"
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn1.DividerWidth = 1
        Me.DataGridViewTextBoxColumn1.HeaderText = "TotalPrix"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "four"
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fournisseur"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "date"
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date "
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nombre"
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre Produit"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Vente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GridProduit)
        Me.Name = "Vente"
        Me.Size = New System.Drawing.Size(993, 589)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GridProduit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuDatepicker1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GridProduit As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents TotalPrix As DataGridViewTextBoxColumn
    Friend WithEvents Fournisseur As DataGridViewTextBoxColumn
    Friend WithEvents DateArrivague As DataGridViewTextBoxColumn
    Friend WithEvents Nombreproduit As DataGridViewTextBoxColumn
    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
