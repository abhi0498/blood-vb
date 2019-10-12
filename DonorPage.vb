Public Class DonorPage
    Public Uname As String
    Public SQL As New SqlControl


    Private Sub DonorDetails_Enter(sender As Object, e As EventArgs) Handles DonorDetails.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DonorPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label10.Text = Uname
        Me.TopMost = True
        If SQL.DBDS IsNot Nothing Then
            SQL.DBDS.Clear()

        End If
        Try
            SQL.RunQuery("Select *" &
"From donor " &
" Where UserName='" & Uname & "'")
            fname.Text = SQL.DBDS.Tables(0).Rows(0).Item("fname")
            lname.Text = SQL.DBDS.Tables(0).Rows(0).Item("lname")
            city.Text = SQL.DBDS.Tables(0).Rows(0).Item("city")
            phno.Text = SQL.DBDS.Tables(0).Rows(0).Item("phone")
            loc.Text = SQL.DBDS.Tables(0).Rows(0).Item("locality")
            bgroup.Text = SQL.DBDS.Tables(0).Rows(0).Item("blood_group")

            SQL.DBCon.Close()

        Catch ex As Exception
            MsgBox(ex.ToString())

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Query As String
        Query = "update Donor
set Donor.fname='" & fname.Text & "'
        ,Donor.lname='" & lname.Text &
        "',Donor.blood_group='" & bgroup.Text &
        "',Donor.city='" & city.Text &
        "',Donor.locality='" & loc.Text &
        "',Donor.phone='" & phno.Text & "'
        where Donor.Username='" & Uname & "';"


        Form3.UpdateQuery(Query)

    End Sub
End Class