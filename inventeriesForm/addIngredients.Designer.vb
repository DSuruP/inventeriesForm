<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addIngredients
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtLowQty = New TextBox()
        Label8 = New Label()
        txtCostPerUnit = New TextBox()
        txtPurchasePrice = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        cboxCategory = New ComboBox()
        DataGridView1 = New DataGridView()
        txtCode = New TextBox()
        txtName = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        cboxConsumptionUnit = New ComboBox()
        cboxPurchaseUnit = New ComboBox()
        btnBack = New Button()
        btnSave = New Button()
        txtConversionRate = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label7 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtLowQty
        ' 
        txtLowQty.Location = New Point(14, 194)
        txtLowQty.Name = "txtLowQty"
        txtLowQty.PlaceholderText = "Low Qty"
        txtLowQty.Size = New Size(257, 29)
        txtLowQty.TabIndex = 44
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(14, 170)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 21)
        Label8.TabIndex = 43
        Label8.Text = "Low Qty *"
        ' 
        ' txtCostPerUnit
        ' 
        txtCostPerUnit.Location = New Point(787, 94)
        txtCostPerUnit.Name = "txtCostPerUnit"
        txtCostPerUnit.PlaceholderText = "Cost Per Unit"
        txtCostPerUnit.Size = New Size(251, 29)
        txtCostPerUnit.TabIndex = 42
        ' 
        ' txtPurchasePrice
        ' 
        txtPurchasePrice.Location = New Point(530, 94)
        txtPurchasePrice.Name = "txtPurchasePrice"
        txtPurchasePrice.PlaceholderText = "Purchase Price"
        txtPurchasePrice.Size = New Size(251, 29)
        txtPurchasePrice.TabIndex = 41
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(787, 70)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 21)
        Label5.TabIndex = 39
        Label5.Text = "Cost Per Unit *"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(528, 70)
        Label6.Name = "Label6"
        Label6.Size = New Size(122, 21)
        Label6.TabIndex = 38
        Label6.Text = "Purchase Price *"
        ' 
        ' cboxCategory
        ' 
        cboxCategory.FormattingEnabled = True
        cboxCategory.Location = New Point(535, 82)
        cboxCategory.Name = "cboxCategory"
        cboxCategory.Size = New Size(251, 29)
        cboxCategory.TabIndex = 36
        cboxCategory.Text = "Select"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(5, 233)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(1051, 228)
        DataGridView1.TabIndex = 35
        ' 
        ' txtCode
        ' 
        txtCode.Location = New Point(276, 82)
        txtCode.Name = "txtCode"
        txtCode.PlaceholderText = "Code"
        txtCode.Size = New Size(253, 29)
        txtCode.TabIndex = 34
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(13, 81)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Name"
        txtName.Size = New Size(257, 29)
        txtName.TabIndex = 33
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(535, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 21)
        Label4.TabIndex = 32
        Label4.Text = "Category *"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(276, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 21)
        Label3.TabIndex = 31
        Label3.Text = "Code *"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 21)
        Label2.TabIndex = 30
        Label2.Text = "Name *"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(14, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 32)
        Label1.TabIndex = 29
        Label1.Text = "Add Ingredients"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(cboxConsumptionUnit)
        Panel1.Controls.Add(cboxPurchaseUnit)
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(txtConversionRate)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(txtCostPerUnit)
        Panel1.Controls.Add(txtPurchasePrice)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(5, 44)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1051, 183)
        Panel1.TabIndex = 45
        ' 
        ' cboxConsumptionUnit
        ' 
        cboxConsumptionUnit.FormattingEnabled = True
        cboxConsumptionUnit.Location = New Point(8, 94)
        cboxConsumptionUnit.Name = "cboxConsumptionUnit"
        cboxConsumptionUnit.Size = New Size(257, 29)
        cboxConsumptionUnit.TabIndex = 48
        cboxConsumptionUnit.Text = "Select"
        ' 
        ' cboxPurchaseUnit
        ' 
        cboxPurchaseUnit.FormattingEnabled = True
        cboxPurchaseUnit.Location = New Point(787, 37)
        cboxPurchaseUnit.Name = "cboxPurchaseUnit"
        cboxPurchaseUnit.Size = New Size(251, 29)
        cboxPurchaseUnit.TabIndex = 46
        cboxPurchaseUnit.Text = "Select"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(390, 149)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(113, 29)
        btnBack.TabIndex = 47
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(271, 150)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(113, 29)
        btnSave.TabIndex = 46
        btnSave.Text = "Submit"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtConversionRate
        ' 
        txtConversionRate.Location = New Point(272, 94)
        txtConversionRate.Name = "txtConversionRate"
        txtConversionRate.PlaceholderText = "Purchase Price"
        txtConversionRate.Size = New Size(252, 29)
        txtConversionRate.TabIndex = 44
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(272, 70)
        Label10.Name = "Label10"
        Label10.Size = New Size(135, 21)
        Label10.TabIndex = 43
        Label10.Text = "Conversion Rate *"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(9, 70)
        Label9.Name = "Label9"
        Label9.Size = New Size(148, 21)
        Label9.TabIndex = 41
        Label9.Text = "Consumption Unit *"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(787, 14)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 21)
        Label7.TabIndex = 37
        Label7.Text = "Purchase Unit *"
        ' 
        ' addIngredients
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1064, 492)
        Controls.Add(txtLowQty)
        Controls.Add(Label8)
        Controls.Add(cboxCategory)
        Controls.Add(DataGridView1)
        Controls.Add(txtCode)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "addIngredients"
        Text = "addIngredients"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtLowQty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCostPerUnit As TextBox
    Friend WithEvents txtPurchasePrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboxCategory As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtConversionRate As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboxConsumptionUnit As ComboBox
    Friend WithEvents cboxPurchaseUnit As ComboBox
End Class
