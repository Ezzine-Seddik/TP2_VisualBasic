<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalculatrice
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
        btn_moins = New Button()
        btn_equal = New Button()
        btn_plus = New Button()
        btn_mlt = New Button()
        btn_reset = New Button()
        btn_div = New Button()
        Label3 = New Label()
        lbl_res = New Label()
        txt_A = New TextBox()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        SuspendLayout()
        ' 
        ' btn_moins
        ' 
        btn_moins.Location = New Point(129, 196)
        btn_moins.Name = "btn_moins"
        btn_moins.Size = New Size(70, 59)
        btn_moins.TabIndex = 2
        btn_moins.Text = "-"
        btn_moins.UseVisualStyleBackColor = True
        ' 
        ' btn_equal
        ' 
        btn_equal.Location = New Point(53, 261)
        btn_equal.Name = "btn_equal"
        btn_equal.Size = New Size(146, 59)
        btn_equal.TabIndex = 3
        btn_equal.Text = "="
        btn_equal.UseVisualStyleBackColor = True
        ' 
        ' btn_plus
        ' 
        btn_plus.BackColor = Color.Snow
        btn_plus.ForeColor = Color.SteelBlue
        btn_plus.Location = New Point(53, 196)
        btn_plus.Name = "btn_plus"
        btn_plus.Size = New Size(70, 59)
        btn_plus.TabIndex = 4
        btn_plus.Text = "+"
        btn_plus.UseVisualStyleBackColor = False
        ' 
        ' btn_mlt
        ' 
        btn_mlt.Location = New Point(205, 196)
        btn_mlt.Name = "btn_mlt"
        btn_mlt.Size = New Size(70, 59)
        btn_mlt.TabIndex = 5
        btn_mlt.Text = "*"
        btn_mlt.UseVisualStyleBackColor = True
        ' 
        ' btn_reset
        ' 
        btn_reset.Location = New Point(205, 261)
        btn_reset.Name = "btn_reset"
        btn_reset.Size = New Size(146, 59)
        btn_reset.TabIndex = 6
        btn_reset.Text = "reset"
        btn_reset.UseVisualStyleBackColor = True
        ' 
        ' btn_div
        ' 
        btn_div.Location = New Point(281, 196)
        btn_div.Name = "btn_div"
        btn_div.Size = New Size(70, 59)
        btn_div.TabIndex = 7
        btn_div.Text = "/"
        btn_div.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(167, 54)
        Label3.Name = "Label3"
        Label3.Size = New Size(21, 20)
        Label3.TabIndex = 8
        Label3.Text = "A"
        ' 
        ' lbl_res
        ' 
        lbl_res.AutoSize = True
        lbl_res.BackColor = Color.Transparent
        lbl_res.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_res.Location = New Point(388, 280)
        lbl_res.MinimumSize = New Size(95, 30)
        lbl_res.Name = "lbl_res"
        lbl_res.Size = New Size(95, 30)
        lbl_res.TabIndex = 9
        ' 
        ' txt_A
        ' 
        txt_A.Location = New Point(247, 51)
        txt_A.Name = "txt_A"
        txt_A.Size = New Size(125, 27)
        txt_A.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(388, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 20)
        Label4.TabIndex = 12
        Label4.Text = "Resultat"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(526, 51)
        Button1.Name = "Button1"
        Button1.Size = New Size(53, 50)
        Button1.TabIndex = 13
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(526, 185)
        Button2.Name = "Button2"
        Button2.Size = New Size(53, 50)
        Button2.TabIndex = 14
        Button2.Text = "7"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(599, 185)
        Button3.Name = "Button3"
        Button3.Size = New Size(53, 50)
        Button3.TabIndex = 15
        Button3.Text = "8"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(672, 185)
        Button4.Name = "Button4"
        Button4.Size = New Size(53, 50)
        Button4.TabIndex = 16
        Button4.Text = "9"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(672, 119)
        Button5.Name = "Button5"
        Button5.Size = New Size(53, 50)
        Button5.TabIndex = 17
        Button5.Text = "6"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(599, 119)
        Button6.Name = "Button6"
        Button6.Size = New Size(53, 50)
        Button6.TabIndex = 18
        Button6.Text = "5"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(526, 119)
        Button7.Name = "Button7"
        Button7.Size = New Size(53, 50)
        Button7.TabIndex = 19
        Button7.Text = "4"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(672, 51)
        Button8.Name = "Button8"
        Button8.Size = New Size(53, 50)
        Button8.TabIndex = 20
        Button8.Text = "3"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(599, 51)
        Button9.Name = "Button9"
        Button9.Size = New Size(53, 50)
        Button9.TabIndex = 21
        Button9.Text = "2"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(599, 250)
        Button10.Name = "Button10"
        Button10.Size = New Size(53, 50)
        Button10.TabIndex = 22
        Button10.Text = "0"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' frmCalculatrice
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button10)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(txt_A)
        Controls.Add(lbl_res)
        Controls.Add(Label3)
        Controls.Add(btn_div)
        Controls.Add(btn_reset)
        Controls.Add(btn_mlt)
        Controls.Add(btn_plus)
        Controls.Add(btn_equal)
        Controls.Add(btn_moins)
        Name = "frmCalculatrice"
        Text = "Calculatrice"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btn_moins As Button
    Friend WithEvents btn_equal As Button
    Friend WithEvents btn_plus As Button
    Friend WithEvents btn_mlt As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_div As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_res As Label
    Friend WithEvents txt_A As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button

End Class
