<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HospitalForm
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
        Me.dtable = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dtable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout
        '
        'dtable
        '
        Me.dtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtable.Location = New System.Drawing.Point(12, 122)
        Me.dtable.Name = "dtable"
        Me.dtable.RowHeadersWidth = 51
        Me.dtable.RowTemplate.Height = 24
        Me.dtable.Size = New System.Drawing.Size(757, 316)
        Me.dtable.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(316, 22)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 50)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(540, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Search Donors"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HospitalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dtable)
        Me.Name = "HospitalForm"
        Me.Text = "HospitalForm"
        CType(Me.dtable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

    End Sub

    Friend WithEvents dtable As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
