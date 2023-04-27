Imports Microsoft.Data.SqlClient

Public Class addIngredientCategory

    Dim conn As New SqlConnection("Data Source=DESKTOP-ML536LV\SQLEXPRESS01;integrated security=true;initial catalog=Work;TrustServerCertificate=true;")
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim insertQuery As String = "INSERT INTO tbl_ingredient_categories(category_name,description,user_id,company_id,del_status)
                                    VALUES(@Category_Name,@Description,@User_Id,@Company_Id,@Del_Status)"
        ExecuteQuery(insertQuery)
        MessageBox.Show("Record Insert Successfully", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information)

        DataGrids()
    End Sub
    Public Sub ExecuteQuery(ByVal query As String)
        Dim cmd As New SqlCommand(query, conn)
        conn.Open()
        cmd.Parameters.Add("@Category_Name", SqlDbType.VarChar).Value = txtCategoryName.Text.Trim()
        cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = txtDescription.Text.Trim()
        cmd.Parameters.Add("@User_Id", SqlDbType.VarChar).Value = "1"
        cmd.Parameters.Add("@Company_Id", SqlDbType.VarChar).Value = "1"
        cmd.Parameters.Add("@Del_Status", SqlDbType.VarChar).Value = "Live"
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub addIngredientCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGrids()
    End Sub
    Private Sub DataGrids()

        Dim selectQuery As String = "SELECT category_name,description from tbl_ingredient_categories"

        ExecuteQuery(selectQuery)
        Dim adp As New SqlDataAdapter(selectQuery, conn)

        Dim dt As DataTable
        Dim ds As New DataSet
        adp.Fill(ds)
        dt = ds.Tables(0)

        DataGridView1.DataSource = dt


    End Sub
End Class