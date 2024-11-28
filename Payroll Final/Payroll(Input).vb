Imports MySql.Data.MySqlClient

Public Class Payroll_Input_

    Dim connectionString As String = "Server=localhost;Database=payroll;Uid=root;Pwd=;"

    ' This method runs when the form loads
    Private Sub Payroll_Input__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into the DataGridView
        LoadData()

        ' Populate the Occu ComboBox with choices
        Occu.Items.AddRange(New String() {"Manager", "Senior Programmer", "Junior Programmer", "Paid Intern"})

        ' Populate TS (Normal hours) ComboBox
        TS.Items.AddRange(New String() {"5", "6", "7", "8"})

        ' Populate OT (Overtime hours) ComboBox
        OT.Items.AddRange(New String() {"1", "2", "3", "4"})
    End Sub

    ' Method to load data from the database and bind it to the DataGridView
    Private Sub LoadData()
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "SELECT * FROM employee"

                Dim dataAdapter As New MySqlDataAdapter(query, connection)

                Dim dataTable As New DataTable()

                dataAdapter.Fill(dataTable)

                PayrollDB.DataSource = dataTable
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Add Button Click Event
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles add.Click
        ' Validation for required fields
        If String.IsNullOrWhiteSpace(FName.Text) OrElse String.IsNullOrWhiteSpace(MName.Text) OrElse String.IsNullOrWhiteSpace(LName.Text) OrElse Occu.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all fields and select an occupation.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validation for TS (Normal hours) and OT (Overtime hours) selection
        If TS.SelectedIndex = -1 OrElse OT.SelectedIndex = -1 Then
            MessageBox.Show("Please select TS (Normal hours) and OT (Overtime hours).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Convert selected values to integer (ensure that SelectedItem is a string)
        Dim normalHours As Integer = Convert.ToInt32(TS.SelectedItem.ToString())
        Dim overtimeHours As Integer = Convert.ToInt32(OT.SelectedItem.ToString())

        ' Calculate Gross Income
        Dim grossIncome As Decimal = normalHours * 175 ' Base rate
        grossIncome += (overtimeHours * grossIncome * 0.2) ' Add 20% for overtime

        ' Initialize deductions
        Dim totalDeductions As Decimal = 0

        ' Calculate deductions based on checkbox selections
        If SSS.Checked Then
            totalDeductions += grossIncome * 0.05 ' 5% for SSS
        End If

        If PhilHealth.Checked Then
            totalDeductions += grossIncome * 0.04 ' 4% for PhilHealth
        End If

        If PAGIBIG.Checked Then
            totalDeductions += grossIncome * 0.02 ' 2% for PAG-IBIG
        End If

        ' Calculate Net Income
        Dim netIncome As Decimal = grossIncome - totalDeductions

        ' Insert data into database
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' SQL query to insert data into the employee table
                Dim query As String = "INSERT INTO employee (FName, MName, LName, Occupation, Gross_Income, Net_Income) " &
                                      "VALUES (@FName, @MName, @LName, @Occupation, @GrossIncome, @NetIncome)"

                ' Create MySQL command
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@FName", FName.Text)
                    command.Parameters.AddWithValue("@MName", MName.Text)
                    command.Parameters.AddWithValue("@LName", LName.Text)
                    command.Parameters.AddWithValue("@Occupation", Occu.SelectedItem.ToString())
                    command.Parameters.AddWithValue("@GrossIncome", grossIncome)
                    command.Parameters.AddWithValue("@NetIncome", netIncome)

                    ' Execute the query
                    Dim result As Integer = command.ExecuteNonQuery()

                    ' Notify user about success
                    If result > 0 Then
                        MessageBox.Show("Data successfully added to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Clear textboxes, ComboBoxes and reset checkboxes
                        FName.Text = ""
                        MName.Text = ""
                        LName.Text = ""
                        Occu.SelectedIndex = -1
                        TS.SelectedIndex = -1
                        OT.SelectedIndex = -1
                        SSS.Checked = False
                        PhilHealth.Checked = False
                        PAGIBIG.Checked = False

                        ' Reload the data grid
                        LoadData()
                    Else
                        MessageBox.Show("Failed to add data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        ' Validation to ensure the employee's first and last name are provided
        If String.IsNullOrWhiteSpace(FName.Text) OrElse String.IsNullOrWhiteSpace(LName.Text) Then
            MessageBox.Show("Please enter the First Name and Last Name to delete the record.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirmation before deleting the record
        Dim confirmResult = MessageBox.Show("Are you sure you want to delete this employee's record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirmResult = DialogResult.Yes Then
            Using connection As New MySqlConnection(connectionString)
                Try
                    connection.Open()

                    ' SQL query to delete an employee based on their First and Last Name
                    Dim query As String = "DELETE FROM employee WHERE FName = @FName AND LName = @LName"

                    ' Create MySQL command
                    Using command As New MySqlCommand(query, connection)
                        ' Add parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@FName", FName.Text)
                        command.Parameters.AddWithValue("@LName", LName.Text)

                        ' Execute the query
                        Dim result As Integer = command.ExecuteNonQuery()

                        ' Notify user about success
                        If result > 0 Then
                            MessageBox.Show("Record successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Clear textboxes and reset fields
                            FName.Text = ""
                            MName.Text = ""
                            LName.Text = ""
                            Occu.SelectedIndex = -1
                            TS.SelectedIndex = -1
                            OT.SelectedIndex = -1
                            SSS.Checked = False
                            PhilHealth.Checked = False
                            PAGIBIG.Checked = False

                            ' Reload the data grid
                            LoadData()
                        Else
                            MessageBox.Show("Failed to delete data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        ' Close the current form (Payroll_Input_)
        Me.Close()

        ' Show the Login form
        Dim loginForm As New LogIn()
        loginForm.Show()
    End Sub
End Class
