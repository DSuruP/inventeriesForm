Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient
Imports Microsoft.EntityFrameworkCore.DbLoggerCategory.Database

Public Class addIngredients

    Dim conn As New SqlConnection("Data Source=DESKTOP-ML536LV\SQLEXPRESS01;integrated security=true;initial catalog=Work;TrustServerCertificate=true;")
    Private Sub addIngredients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListUnit()
        ListCategories()
        DataGrids()
    End Sub
    Private Sub DataGrids()

        Dim selectQuery As String = "SELECT * from tbl_ingredients"

        ExecuteQuery(selectQuery)
        Dim adp As New SqlDataAdapter(selectQuery, conn)

        Dim dt As DataTable
        Dim ds As New DataSet
        adp.Fill(ds)
        dt = ds.Tables(0)

        DataGridView1.DataSource = dt


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Dim insertQuery As String = "INSERT INTO tbl_ingredients(code,name,category_id,purchase_price,alert_quantity,
        '                            unit_id,user_id,company_id,del_status,purchase_unit_id,conversion_rate,consumption_unit_cost,
        '                            average_consumption_per_unit,is_direct_food,food_id,ing_type,unit_type)

        '                            VALUES(@Code,@Name,@Category_Id,@Purchase_Price,@Alert_Quantity,@Unit_Id,@User_Id,@Company_Id,
        '                            @Del_Status,@Purchase_Unit_Id,@Conversion_Rate,@Consumption_Unit_Cost,@Average_Consumption_Per_Unit,
        '                            @Is_Direct_Food,@Food_Id,@Ing_Type,@Unit_Type)"
        Dim insertQuery As String = "INSERT INTO tbl_ingredients(code,name,purchase_price,alert_quantity,
                                    user_id,company_id,del_status,conversion_rate,consumption_unit_cost)
                                    VALUES(@Code,@Name,@Purchase_Price,@Alert_Quantity,@User_Id,@Company_Id,
                                    @Del_Status,@Conversion_Rate,@Consumption_Unit_Cost)"
        ExecuteQuery(insertQuery)
        MessageBox.Show("Record Insert Successfully", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information)

        DataGrids()
    End Sub
    Public Sub ExecuteQuery(ByVal query As String)
        Dim cmd As New SqlCommand(query, conn)
        conn.Open()
        cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = txtCode.Text.Trim()
        cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtCode.Text.Trim()
        cmd.Parameters.Add("@Conversion_Rate", SqlDbType.VarChar).Value = txtConversionRate.Text.Trim()
        cmd.Parameters.Add("@Purchase_Price", SqlDbType.VarChar).Value = txtPurchasePrice.Text.Trim()
        cmd.Parameters.Add("@Consumption_Unit_Cost", SqlDbType.VarChar).Value = txtCostPerUnit.Text.Trim()
        cmd.Parameters.Add("@Alert_Quantity", SqlDbType.VarChar).Value = txtLowQty.Text.Trim()
        cmd.Parameters.Add("@User_Id", SqlDbType.VarChar).Value = "1"
        cmd.Parameters.Add("@Company_Id", SqlDbType.VarChar).Value = "1"
        cmd.Parameters.Add("@Del_Status", SqlDbType.VarChar).Value = "Live"
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub txtPurchasePrice_TextChanged(sender As Object, e As EventArgs) Handles txtPurchasePrice.TextChanged
        txtCostPerUnit.Text = Val(txtPurchasePrice.Text) / Val(txtConversionRate.Text)
    End Sub

    Private Sub ListUnit()
        Dim command As New SqlCommand("select * from tbl_units", conn)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        cboxPurchaseUnit.DataSource = table

        cboxPurchaseUnit.DisplayMember = "unit_name"
        cboxPurchaseUnit.ValueMember = "id"

    End Sub

    Private Sub ListCategories()
        Dim command As New SqlCommand("select * from tbl_ingredient_categories", conn)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        cboxCategory.DataSource = table

        cboxCategory.DisplayMember = "category_name"
        cboxCategory.ValueMember = "id"

    End Sub
End Class