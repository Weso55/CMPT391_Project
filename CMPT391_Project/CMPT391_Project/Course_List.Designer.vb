<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Course_List
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
        Me.CourseTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SectionTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.SemesterComboBox = New System.Windows.Forms.ComboBox()
        Me.CourseDataGridView = New System.Windows.Forms.DataGridView()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.YearComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.CourseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CourseTextBox
        '
        Me.CourseTextBox.Location = New System.Drawing.Point(12, 82)
        Me.CourseTextBox.Name = "CourseTextBox"
        Me.CourseTextBox.Size = New System.Drawing.Size(276, 20)
        Me.CourseTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(487, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Course List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Course Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(472, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Section"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(910, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Semester"
        '
        'SectionTextBox
        '
        Me.SectionTextBox.Location = New System.Drawing.Point(475, 82)
        Me.SectionTextBox.Name = "SectionTextBox"
        Me.SectionTextBox.Size = New System.Drawing.Size(250, 20)
        Me.SectionTextBox.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(910, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Department"
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Items.AddRange(New Object() {"Anthropology", "Biological Sciences", "Computer Science", "Economics", "English", "Humanities", "Mathematics", "Physical Sciences", "Political Science", "Psychology", "Sociology"})
        Me.DepartmentComboBox.Location = New System.Drawing.Point(913, 82)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(166, 21)
        Me.DepartmentComboBox.TabIndex = 8
        '
        'SemesterComboBox
        '
        Me.SemesterComboBox.AutoCompleteCustomSource.AddRange(New String() {"Fall", "Summer", "Winter", "Spring"})
        Me.SemesterComboBox.FormattingEnabled = True
        Me.SemesterComboBox.Items.AddRange(New Object() {"Fall", "Winter", "Spring/Summer"})
        Me.SemesterComboBox.Location = New System.Drawing.Point(913, 147)
        Me.SemesterComboBox.Name = "SemesterComboBox"
        Me.SemesterComboBox.Size = New System.Drawing.Size(166, 21)
        Me.SemesterComboBox.TabIndex = 9
        '
        'CourseDataGridView
        '
        Me.CourseDataGridView.AllowUserToAddRows = False
        Me.CourseDataGridView.AllowUserToDeleteRows = False
        Me.CourseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CourseDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.CourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CourseDataGridView.Location = New System.Drawing.Point(12, 219)
        Me.CourseDataGridView.MultiSelect = False
        Me.CourseDataGridView.Name = "CourseDataGridView"
        Me.CourseDataGridView.RowTemplate.ReadOnly = True
        Me.CourseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CourseDataGridView.Size = New System.Drawing.Size(1067, 473)
        Me.CourseDataGridView.TabIndex = 10
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(12, 145)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(108, 39)
        Me.SearchButton.TabIndex = 11
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(1039, 713)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(114, 23)
        Me.BackButton.TabIndex = 17
        Me.BackButton.Text = "Back to Enrolled"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'YearComboBox
        '
        Me.YearComboBox.FormattingEnabled = True
        Me.YearComboBox.Items.AddRange(New Object() {"2016", "2017", "2018", "2019", "2020"})
        Me.YearComboBox.Location = New System.Drawing.Point(475, 145)
        Me.YearComboBox.Name = "YearComboBox"
        Me.YearComboBox.Size = New System.Drawing.Size(250, 21)
        Me.YearComboBox.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(475, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Year"
        '
        'Course_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 748)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.YearComboBox)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.CourseDataGridView)
        Me.Controls.Add(Me.SemesterComboBox)
        Me.Controls.Add(Me.DepartmentComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SectionTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CourseTextBox)
        Me.Name = "Course_List"
        Me.Text = "Course_List"
        CType(Me.CourseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CourseTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SectionTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DepartmentComboBox As ComboBox
    Friend WithEvents SemesterComboBox As ComboBox
    Friend WithEvents CourseDataGridView As DataGridView
    Friend WithEvents SearchButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents YearComboBox As ComboBox
    Friend WithEvents Label6 As Label
End Class
