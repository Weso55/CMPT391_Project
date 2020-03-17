<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enrolled
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SemComboBox = New System.Windows.Forms.ComboBox()
        Me.CMPT391DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewCourses = New System.Windows.Forms.Button()
        Me.EnrollData = New System.Windows.Forms.DataGridView()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.YearLabel = New System.Windows.Forms.Label()
        Me.YearComboBox = New System.Windows.Forms.ComboBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.DropButton = New System.Windows.Forms.Button()
        CType(Me.CMPT391DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnrollData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(322, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enrolled Courses"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Semester"
        '
        'SemComboBox
        '
        Me.SemComboBox.FormattingEnabled = True
        Me.SemComboBox.Items.AddRange(New Object() {"Winter", "Fall", "Spring", "Summer"})
        Me.SemComboBox.Location = New System.Drawing.Point(73, 55)
        Me.SemComboBox.Name = "SemComboBox"
        Me.SemComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SemComboBox.TabIndex = 2
        '
        'ViewCourses
        '
        Me.ViewCourses.Location = New System.Drawing.Point(517, 326)
        Me.ViewCourses.Name = "ViewCourses"
        Me.ViewCourses.Size = New System.Drawing.Size(171, 44)
        Me.ViewCourses.TabIndex = 3
        Me.ViewCourses.Text = "View Courses"
        Me.ViewCourses.UseVisualStyleBackColor = True
        '
        'EnrollData
        '
        Me.EnrollData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EnrollData.Location = New System.Drawing.Point(73, 93)
        Me.EnrollData.Name = "EnrollData"
        Me.EnrollData.Size = New System.Drawing.Size(615, 201)
        Me.EnrollData.TabIndex = 4
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(555, 39)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(133, 37)
        Me.RefreshButton.TabIndex = 5
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'YearLabel
        '
        Me.YearLabel.AutoSize = True
        Me.YearLabel.Location = New System.Drawing.Point(305, 39)
        Me.YearLabel.Name = "YearLabel"
        Me.YearLabel.Size = New System.Drawing.Size(29, 13)
        Me.YearLabel.TabIndex = 6
        Me.YearLabel.Text = "Year"
        '
        'YearComboBox
        '
        Me.YearComboBox.FormattingEnabled = True
        Me.YearComboBox.Items.AddRange(New Object() {"2015", "2016", "2017", "2018", "2019", "2020"})
        Me.YearComboBox.Location = New System.Drawing.Point(308, 56)
        Me.YearComboBox.Name = "YearComboBox"
        Me.YearComboBox.Size = New System.Drawing.Size(121, 21)
        Me.YearComboBox.TabIndex = 7
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(674, 415)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(114, 23)
        Me.BackButton.TabIndex = 18
        Me.BackButton.Text = "Back to Sign-In"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'DropButton
        '
        Me.DropButton.Location = New System.Drawing.Point(308, 326)
        Me.DropButton.Name = "DropButton"
        Me.DropButton.Size = New System.Drawing.Size(154, 44)
        Me.DropButton.TabIndex = 19
        Me.DropButton.Text = "Drop Course"
        Me.DropButton.UseVisualStyleBackColor = True
        '
        'enrolled
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DropButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.YearComboBox)
        Me.Controls.Add(Me.YearLabel)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.EnrollData)
        Me.Controls.Add(Me.ViewCourses)
        Me.Controls.Add(Me.SemComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "enrolled"
        Me.Text = "Form2"
        CType(Me.CMPT391DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnrollData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SemComboBox As ComboBox
    Friend WithEvents CMPT391DataSet As CMPT391DataSet
    Friend WithEvents CMPT391DataSetBindingSource As BindingSource
    Friend WithEvents ViewCourses As Button
    Friend WithEvents EnrollData As DataGridView
    Friend WithEvents RefreshButton As Button
    Friend WithEvents YearLabel As Label
    Friend WithEvents YearComboBox As ComboBox
    Friend WithEvents BackButton As Button
    Friend WithEvents DropButton As Button
End Class
