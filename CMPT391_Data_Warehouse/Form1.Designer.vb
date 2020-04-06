<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GoButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SemesterComboBox = New System.Windows.Forms.ComboBox()
        Me.YearComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InstructorTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FacultyComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ValueCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(750, 178)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(95, 38)
        Me.GoButton.TabIndex = 1
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(379, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Find Total Courses Taught:"
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Items.AddRange(New Object() {"Department of Animal Science", "Department of Anthropology", "Department of Geography", "Department of Physical Education", "Department of Plant Science", "Department of Sciences and Forestry"})
        Me.DepartmentComboBox.Location = New System.Drawing.Point(75, 146)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(193, 21)
        Me.DepartmentComboBox.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "In"
        '
        'SemesterComboBox
        '
        Me.SemesterComboBox.FormattingEnabled = True
        Me.SemesterComboBox.Items.AddRange(New Object() {"Fall", "Winter", "Spring", "Summer"})
        Me.SemesterComboBox.Location = New System.Drawing.Point(382, 146)
        Me.SemesterComboBox.Name = "SemesterComboBox"
        Me.SemesterComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SemesterComboBox.TabIndex = 8
        '
        'YearComboBox
        '
        Me.YearComboBox.FormattingEnabled = True
        Me.YearComboBox.Items.AddRange(New Object() {"2020", "2021", "2022"})
        Me.YearComboBox.Location = New System.Drawing.Point(581, 149)
        Me.YearComboBox.Name = "YearComboBox"
        Me.YearComboBox.Size = New System.Drawing.Size(121, 21)
        Me.YearComboBox.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(421, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Semester"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(624, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Year"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 301)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(802, 390)
        Me.DataGridView1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(163, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Or"
        '
        'InstructorTextBox
        '
        Me.InstructorTextBox.Location = New System.Drawing.Point(75, 235)
        Me.InstructorTextBox.Name = "InstructorTextBox"
        Me.InstructorTextBox.Size = New System.Drawing.Size(193, 20)
        Me.InstructorTextBox.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(134, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Instructor ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(137, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Department"
        '
        'FacultyComboBox
        '
        Me.FacultyComboBox.FormattingEnabled = True
        Me.FacultyComboBox.Items.AddRange(New Object() {"Faculty of Agriculture and Food Sciences", "Faculty of Forestry, Geography and Geomatics", "Faculty of Educational Sciences", "Faculty of Social Sciences"})
        Me.FacultyComboBox.Location = New System.Drawing.Point(75, 66)
        Me.FacultyComboBox.Name = "FacultyComboBox"
        Me.FacultyComboBox.Size = New System.Drawing.Size(193, 21)
        Me.FacultyComboBox.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(165, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Or"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(137, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Faculty"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(295, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Where"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(527, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "and"
        '
        'ValueCheckBox
        '
        Me.ValueCheckBox.AutoSize = True
        Me.ValueCheckBox.Location = New System.Drawing.Point(750, 45)
        Me.ValueCheckBox.Name = "ValueCheckBox"
        Me.ValueCheckBox.Size = New System.Drawing.Size(83, 17)
        Me.ValueCheckBox.TabIndex = 22
        Me.ValueCheckBox.Text = "Show Value"
        Me.ValueCheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 750)
        Me.Controls.Add(Me.ValueCheckBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.FacultyComboBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.InstructorTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.YearComboBox)
        Me.Controls.Add(Me.SemesterComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DepartmentComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GoButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GoButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DepartmentComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SemesterComboBox As ComboBox
    Friend WithEvents YearComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents InstructorTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents FacultyComboBox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ValueCheckBox As CheckBox
End Class
