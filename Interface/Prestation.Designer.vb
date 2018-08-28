<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prestation
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prestation))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GridPrestation = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dateSelec = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateRealisation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.infoClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GridPrestation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridPrestation
        '
        Me.GridPrestation.AllowUserToAddRows = False
        Me.GridPrestation.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridPrestation.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridPrestation.BackgroundColor = System.Drawing.Color.White
        Me.GridPrestation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridPrestation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPrestation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridPrestation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPrestation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.dateRealisation, Me.DataGridViewTextBoxColumn3, Me.infoClient, Me.numm})
        Me.GridPrestation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPrestation.DoubleBuffered = True
        Me.GridPrestation.EnableHeadersVisualStyles = False
        Me.GridPrestation.GridColor = System.Drawing.SystemColors.Highlight
        Me.GridPrestation.HeaderBgColor = System.Drawing.SystemColors.Highlight
        Me.GridPrestation.HeaderForeColor = System.Drawing.Color.White
        Me.GridPrestation.Location = New System.Drawing.Point(0, 73)
        Me.GridPrestation.Name = "GridPrestation"
        Me.GridPrestation.ReadOnly = True
        Me.GridPrestation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridPrestation.Size = New System.Drawing.Size(939, 456)
        Me.GridPrestation.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel2.Controls.Add(Me.dateSelec)
        Me.Panel2.Controls.Add(Me.BunifuThinButton21)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(939, 73)
        Me.Panel2.TabIndex = 17
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(34, 22)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(351, 30)
        Me.BunifuCustomLabel1.TabIndex = 13
        Me.BunifuCustomLabel1.Text = "Les Prestation commander Apres le :"
        '
        'dateSelec
        '
        Me.dateSelec.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dateSelec.BorderRadius = 0
        Me.dateSelec.ForeColor = System.Drawing.Color.White
        Me.dateSelec.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateSelec.FormatCustom = Nothing
        Me.dateSelec.Location = New System.Drawing.Point(442, 16)
        Me.dateSelec.Name = "dateSelec"
        Me.dateSelec.Size = New System.Drawing.Size(247, 36)
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
        Me.BunifuThinButton21.ButtonText = "Nouvelle Prestation"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuThinButton21.IdleBorderThickness = 2
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(758, 0)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(181, 73)
        Me.BunifuThinButton21.TabIndex = 3
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "totalPayer"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.DividerWidth = 1
        Me.DataGridViewTextBoxColumn1.FillWeight = 41.87817!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Total Payer"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'dateRealisation
        '
        Me.dateRealisation.HeaderText = "Date Realisation"
        Me.dateRealisation.MinimumWidth = 140
        Me.dateRealisation.Name = "dateRealisation"
        Me.dateRealisation.ReadOnly = True
        Me.dateRealisation.Width = 140
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "dateCommande"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.FillWeight = 41.87817!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date Commande"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 140
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'infoClient
        '
        Me.infoClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.infoClient.DataPropertyName = "info"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.infoClient.DefaultCellStyle = DataGridViewCellStyle5
        Me.infoClient.FillWeight = 216.2437!
        Me.infoClient.HeaderText = "Info Client"
        Me.infoClient.MinimumWidth = 340
        Me.infoClient.Name = "infoClient"
        Me.infoClient.ReadOnly = True
        '
        'numm
        '
        Me.numm.DataPropertyName = "num"
        Me.numm.HeaderText = "Numero De Vente"
        Me.numm.MinimumWidth = 200
        Me.numm.Name = "numm"
        Me.numm.ReadOnly = True
        Me.numm.Width = 200
        '
        'Prestation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GridPrestation)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Prestation"
        Me.Size = New System.Drawing.Size(939, 529)
        CType(Me.GridPrestation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridPrestation As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dateSelec As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents dateRealisation As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents infoClient As DataGridViewTextBoxColumn
    Friend WithEvents numm As DataGridViewTextBoxColumn
End Class
