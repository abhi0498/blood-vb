<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.AdminBtn = New System.Windows.Forms.Button()
        Me.DonorBtn = New System.Windows.Forms.Button()
        Me.HospitalBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.User = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AdminFP = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'AdminBtn
        '
        Me.AdminBtn.Location = New System.Drawing.Point(43, 333)
        Me.AdminBtn.Name = "AdminBtn"
        Me.AdminBtn.Size = New System.Drawing.Size(121, 40)
        Me.AdminBtn.TabIndex = 0
        Me.AdminBtn.Text = "Admin Login"
        Me.AdminBtn.UseVisualStyleBackColor = True
        '
        'DonorBtn
        '
        Me.DonorBtn.Location = New System.Drawing.Point(730, 333)
        Me.DonorBtn.Name = "DonorBtn"
        Me.DonorBtn.Size = New System.Drawing.Size(120, 40)
        Me.DonorBtn.TabIndex = 2
        Me.DonorBtn.Text = "Donor Login"
        Me.DonorBtn.UseVisualStyleBackColor = True
        '
        'HospitalBtn
        '
        Me.HospitalBtn.Location = New System.Drawing.Point(421, 333)
        Me.HospitalBtn.Name = "HospitalBtn"
        Me.HospitalBtn.Size = New System.Drawing.Size(116, 40)
        Me.HospitalBtn.TabIndex = 3
        Me.HospitalBtn.Text = "Hospital Login"
        Me.HospitalBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(136, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 29)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Login Details"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(338, 208)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.ShortcutsEnabled = False
        Me.Password.Size = New System.Drawing.Size(169, 22)
        Me.Password.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Password"
        '
        'User
        '
        Me.User.Location = New System.Drawing.Point(338, 139)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(169, 22)
        Me.User.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(184, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Username"
        '
        'AdminFP
        '
        Me.AdminFP.Location = New System.Drawing.Point(720, 30)
        Me.AdminFP.Name = "AdminFP"
        Me.AdminFP.Size = New System.Drawing.Size(153, 36)
        Me.AdminFP.TabIndex = 16
        Me.AdminFP.Text = "Forgot Password"
        Me.AdminFP.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1048, 625)
        Me.Controls.Add(Me.AdminFP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.HospitalBtn)
        Me.Controls.Add(Me.DonorBtn)
        Me.Controls.Add(Me.AdminBtn)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout

    End Sub

    Friend WithEvents AdminBtn As Button
    Friend WithEvents DonorBtn As Button
    Friend WithEvents HospitalBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents User As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AdminFP As Button
End Class
