<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        Button1 = New Button()
        SC = New SplitContainer()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Panel1.SuspendLayout()
        CType(SC, ComponentModel.ISupportInitialize).BeginInit()
        SC.Panel1.SuspendLayout()
        SC.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 41)
        Panel1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(3, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(60, 41)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = True
        ' 
        ' SC
        ' 
        SC.Dock = DockStyle.Fill
        SC.Location = New Point(0, 0)
        SC.Name = "SC"
        ' 
        ' SC.Panel1
        ' 
        SC.Panel1.BackColor = Color.Gray
        SC.Panel1.Controls.Add(Button4)
        SC.Panel1.Controls.Add(Button3)
        SC.Panel1.Controls.Add(Button2)
        SC.Size = New Size(800, 450)
        SC.SplitterDistance = 206
        SC.TabIndex = 5
        ' 
        ' Button4
        ' 
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = SystemColors.ActiveCaptionText
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(3, 230)
        Button4.Name = "Button4"
        Button4.Size = New Size(160, 41)
        Button4.TabIndex = 3
        Button4.Text = "Add Ingredient"
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = SystemColors.ActiveCaptionText
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(3, 183)
        Button3.Name = "Button3"
        Button3.Size = New Size(217, 41)
        Button3.TabIndex = 2
        Button3.Text = "Add Ingredient Category"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(3, 136)
        Button2.Name = "Button2"
        Button2.Size = New Size(160, 41)
        Button2.TabIndex = 1
        Button2.Text = "Add Unit"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(SC)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        SC.Panel1.ResumeLayout(False)
        CType(SC, ComponentModel.ISupportInitialize).EndInit()
        SC.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents SC As SplitContainer
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
