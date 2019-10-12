Public Class HospitalForm
    Private Sub HospitalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtable.CellContentClick


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Form3.ExecQuery("select * from Donor where blood_group='" & TextBox1.Text & "';")

            dtable.DataSource = Form3.DBDT
            dtable.Columns(0).Width = 300
            dtable.Columns(1).Width = 300
            dtable.Columns(2).Width = 300
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class