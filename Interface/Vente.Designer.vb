<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dateSelec = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GridVente = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.GridVente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dateSelec
        '
        Me.dateSelec.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dateSelec.BorderRadius = 0
        Me.dateSelec.ForeColor = System.Drawing.Color.White
        Me.dateSelec.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateSelec.FormatCustom = Nothing
        Me.dateSelec.Location = New System.Drawing.Point(473, 16)
        Me.dateSelec.Name = "dateSelec"
        Me.dateSelec.Size = New System.Drawing.Size(303, 36)
        Me.dateSelec.TabIndex = 12
        Me.dateSelec.Value = New Date(2018, 7, 26, 14, 5, 52, 840)
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
        Me.Panel2.Controls.Add(Me.dateSelec)
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
        'GridVente
        '
        Me.GridVente.AllowUserToAddRows = False
        Me.GridVente.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridVente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.GridVente.BackgroundColor = System.Drawing.Color.White
        Me.GridVente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridVente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridVente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.GridVente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridVente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.GridVente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVente.DoubleBuffered = True
        Me.GridVente.EnableHeadersVisualStyles = False
        Me.GridVente.GridColor = System.Drawing.SystemColors.Highlight
        Me.GridVente.HeaderBgColor = System.Drawing.SystemColors.Highlight
        Me.GridVente.HeaderForeColor = System.Drawing.Color.White
        Me.GridVente.Location = New System.Drawing.Point(0, 73)
        Me.GridVente.Name = "GridVente"
        Me.GridVente.ReadOnly = True
        Me.GridVente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridVente.Size = New System.Drawing.Size(993, 516)
        Me.GridVente.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "total"
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn1.DividerWidth = 1
        Me.DataGridViewTextBoxColumn1.FillWeight = 41.87817!
        Me.DataGridViewTextBoxColumn1.HeaderText = "TotalPrix"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "date"
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn3.FillWeight = 41.87817!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date "
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "info"
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn4.FillWeight = 216.2437!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Info Client"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 340
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Vente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GridVente)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Vente"
        Me.Size = New System.Drawing.Size(993, 589)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GridVente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dateSelec As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GridVente As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
