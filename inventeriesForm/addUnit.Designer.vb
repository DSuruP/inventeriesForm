<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addUnit
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
        txtDescription = New TextBox()
        txtUnitName = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        btnBack = New Button()
        btnSave = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(204, 50)
        txtDescription.Name = "txtDescription"
        txtDescription.PlaceholderText = "Description"
        txtDescription.Size = New Size(192, 29)
        txtDescription.TabIndex = 20
        ' 
        ' txtUnitName
        ' 
        txtUnitName.Location = New Point(6, 50)
        txtUnitName.Name = "txtUnitName"
        txtUnitName.PlaceholderText = "Unit Name"
        txtUnitName.Size = New Size(192, 29)
        txtUnitName.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(204, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 21)
        Label3.TabIndex = 18
        Label3.Text = "Description"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 21)
        Label2.TabIndex = 17
        Label2.Text = "Unit Name *"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(42, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 32)
        Label1.TabIndex = 21
        Label1.Text = "Add Unit"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtDescription)
        Panel1.Controls.Add(txtUnitName)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(42, 66)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(409, 102)
        Panel1.TabIndex = 22
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(42, 208)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(409, 150)
        DataGridView1.TabIndex = 23
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(246, 173)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(113, 29)
        btnBack.TabIndex = 49
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(127, 174)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(113, 29)
        btnSave.TabIndex = 48
        btnSave.Text = "Submit"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' addUnit
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(498, 370)
        Controls.Add(btnBack)
        Controls.Add(btnSave)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "addUnit"
        Text = "addUnit"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtUnitName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSave As Button
End Class
