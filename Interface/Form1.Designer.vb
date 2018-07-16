<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.brandMin = New System.Windows.Forms.TextBox()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton6 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.brandMax = New System.Windows.Forms.TextBox()
        Me.Command1 = New [Interface].Command()
        Me.Vente1 = New [Interface].Vente()
        Me.Panel3.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SidePanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.brandMin)
        Me.Panel3.Controls.Add(Me.BunifuImageButton3)
        Me.Panel3.Controls.Add(Me.BunifuImageButton2)
        Me.Panel3.Controls.Add(Me.BunifuImageButton1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1225, 43)
        Me.Panel3.TabIndex = 3
        '
        'brandMin
        '
        Me.brandMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.brandMin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.brandMin.Enabled = False
        Me.brandMin.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brandMin.ForeColor = System.Drawing.SystemColors.Info
        Me.brandMin.Location = New System.Drawing.Point(63, 4)
        Me.brandMin.Name = "brandMin"
        Me.brandMin.Size = New System.Drawing.Size(212, 36)
        Me.brandMin.TabIndex = 3
        Me.brandMin.Text = "ETS M . ALI"
        Me.brandMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(1152, 6)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(28, 31)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 2
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(1186, 6)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(28, 31)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 1
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(12, 8)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(36, 27)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 0
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.White
        Me.SidePanel.Controls.Add(Me.BunifuFlatButton6)
        Me.SidePanel.Controls.Add(Me.BunifuFlatButton5)
        Me.SidePanel.Controls.Add(Me.BunifuFlatButton4)
        Me.SidePanel.Controls.Add(Me.BunifuFlatButton3)
        Me.SidePanel.Controls.Add(Me.BunifuFlatButton2)
        Me.SidePanel.Controls.Add(Me.BunifuFlatButton1)
        Me.SidePanel.Controls.Add(Me.Panel2)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidePanel.Location = New System.Drawing.Point(0, 43)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(232, 589)
        Me.SidePanel.TabIndex = 6
        '
        'BunifuFlatButton6
        '
        Me.BunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuFlatButton6.BackColor = System.Drawing.Color.White
        Me.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton6.BorderRadius = 0
        Me.BunifuFlatButton6.ButtonText = "Ouvrier"
        Me.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Iconimage = CType(resources.GetObject("BunifuFlatButton6.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton6.Iconimage_right = Nothing
        Me.BunifuFlatButton6.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton6.Iconimage_Selected = Nothing
        Me.BunifuFlatButton6.IconMarginLeft = 0
        Me.BunifuFlatButton6.IconMarginRight = 0
        Me.BunifuFlatButton6.IconRightVisible = True
        Me.BunifuFlatButton6.IconRightZoom = 0R
        Me.BunifuFlatButton6.IconVisible = True
        Me.BunifuFlatButton6.IconZoom = 50.0R
        Me.BunifuFlatButton6.IsTab = False
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(0, 538)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.Color.White
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.White
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.SystemColors.Highlight
        Me.BunifuFlatButton6.selected = False
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(229, 48)
        Me.BunifuFlatButton6.TabIndex = 6
        Me.BunifuFlatButton6.Text = "Ouvrier"
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "Client"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = CType(resources.GetObject("BunifuFlatButton5.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 50.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(0, 484)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.White
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.White
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.SystemColors.Highlight
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(229, 48)
        Me.BunifuFlatButton5.TabIndex = 5
        Me.BunifuFlatButton5.Text = "Client"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "Stock"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = CType(resources.GetObject("BunifuFlatButton4.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 50.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(0, 430)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.SystemColors.Highlight
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(229, 48)
        Me.BunifuFlatButton4.TabIndex = 4
        Me.BunifuFlatButton4.Text = "Stock"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Commande"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 50.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(0, 376)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.SystemColors.Highlight
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(229, 48)
        Me.BunifuFlatButton3.TabIndex = 3
        Me.BunifuFlatButton3.Text = "Commande"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Vente"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 50.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(0, 322)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.SystemColors.Highlight
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(229, 48)
        Me.BunifuFlatButton2.TabIndex = 2
        Me.BunifuFlatButton2.Text = "Vente"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Caisse"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 50.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 271)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.SystemColors.Highlight
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(229, 48)
        Me.BunifuFlatButton1.TabIndex = 1
        Me.BunifuFlatButton1.Text = "Caisse"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel2.Controls.Add(Me.logo)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.brandMax)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(232, 265)
        Me.Panel2.TabIndex = 0
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(55, 28)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(123, 72)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 2
        Me.logo.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Location = New System.Drawing.Point(46, 156)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(134, 83)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "Aménagement" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Automatisme" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inox General"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'brandMax
        '
        Me.brandMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.brandMax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.brandMax.Enabled = False
        Me.brandMax.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brandMax.ForeColor = System.Drawing.SystemColors.Info
        Me.brandMax.Location = New System.Drawing.Point(7, 106)
        Me.brandMax.Name = "brandMax"
        Me.brandMax.Size = New System.Drawing.Size(214, 54)
        Me.brandMax.TabIndex = 0
        Me.brandMax.Text = "ETS M . ALI"
        Me.brandMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Command1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Command1.Location = New System.Drawing.Point(232, 43)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(993, 589)
        Me.Command1.TabIndex = 7
        '
        'Vente1
        '
        Me.Vente1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Vente1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vente1.Location = New System.Drawing.Point(232, 43)
        Me.Vente1.Name = "Vente1"
        Me.Vente1.Size = New System.Drawing.Size(993, 589)
        Me.Vente1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1225, 632)
        Me.Controls.Add(Me.Vente1)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.Panel3)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SidePanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents SidePanel As Panel
    Friend WithEvents BunifuFlatButton6 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents brandMax As TextBox
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents brandMin As TextBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents Command1 As Object
    Friend WithEvents Vente1 As Object
End Class
