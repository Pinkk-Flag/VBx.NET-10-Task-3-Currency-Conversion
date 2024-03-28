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
        cmbBox = New ComboBox()
        btnexit = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtAustralia = New TextBox()
        txtForeign = New TextBox()
        SuspendLayout()
        ' 
        ' cmbBox
        ' 
        cmbBox.FormattingEnabled = True
        cmbBox.Items.AddRange(New Object() {"US Dollars", "Yen", "Pounds"})
        cmbBox.Location = New Point(12, 14)
        cmbBox.Name = "cmbBox"
        cmbBox.Size = New Size(182, 33)
        cmbBox.TabIndex = 0
        ' 
        ' btnexit
        ' 
        btnexit.Location = New Point(676, 12)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(112, 34)
        btnexit.TabIndex = 1
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(558, 13)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 2
        Button1.Text = "Update"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(216, 157)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 25)
        Label1.TabIndex = 3
        Label1.Text = "Australian Dollars: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(131, 224)
        Label2.Name = "Label2"
        Label2.Size = New Size(244, 25)
        Label2.TabIndex = 4
        Label2.Text = "Amount in Foreign Currency: "
        ' 
        ' txtAustralia
        ' 
        txtAustralia.Location = New Point(381, 157)
        txtAustralia.Name = "txtAustralia"
        txtAustralia.Size = New Size(150, 31)
        txtAustralia.TabIndex = 5
        ' 
        ' txtForeign
        ' 
        txtForeign.Location = New Point(381, 224)
        txtForeign.Name = "txtForeign"
        txtForeign.Size = New Size(150, 31)
        txtForeign.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtForeign)
        Controls.Add(txtAustralia)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(btnexit)
        Controls.Add(cmbBox)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbBox As ComboBox
    Friend WithEvents btnexit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAustralia As TextBox
    Friend WithEvents txtForeign As TextBox

End Class
