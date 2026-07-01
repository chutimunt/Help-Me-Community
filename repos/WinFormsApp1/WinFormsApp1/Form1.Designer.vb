<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnAdd = New Button()
        btnDelete = New Button()
        txtid = New TextBox()
        txtName = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        cboGender = New ComboBox()
        Label3 = New Label()
        Label4 = New Label()
        cboDepartment = New ComboBox()
        dtpStartDate = New DateTimePicker()
        Label5 = New Label()
        dataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        CType(dataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(630, 104)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(102, 31)
        btnAdd.TabIndex = 0
        btnAdd.Text = "เพิ่ม"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(788, 104)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(102, 31)
        btnDelete.TabIndex = 1
        btnDelete.Text = "ลบ"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(250, 106)
        txtid.Name = "txtid"
        txtid.Size = New Size(135, 29)
        txtid.TabIndex = 2
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(458, 106)
        txtName.Name = "txtName"
        txtName.Size = New Size(135, 29)
        txtName.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(260, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 21)
        Label1.TabIndex = 4
        Label1.Text = "รหัสพนักงาน"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(463, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 21)
        Label2.TabIndex = 5
        Label2.Text = "ชื่อพนักงาน"
        ' 
        ' cboGender
        ' 
        cboGender.FormattingEnabled = True
        cboGender.Items.AddRange(New Object() {"ผู้ชาย", "ผู้หญิง"})
        cboGender.Location = New Point(246, 175)
        cboGender.Name = "cboGender"
        cboGender.Size = New Size(164, 29)
        cboGender.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(246, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 21)
        Label3.TabIndex = 7
        Label3.Text = "เพศ"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(233, 227)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 21)
        Label4.TabIndex = 8
        Label4.Text = "แผนก"
        ' 
        ' cboDepartment
        ' 
        cboDepartment.FormattingEnabled = True
        cboDepartment.Items.AddRange(New Object() {"ประธานฝ่ายสารสนเทศ", "ผู้จัดการฝ่ายไอที", "ผู้จัดการโครงการ", "นักวิเคราะห์ระบบ", "นักออกแบบติดต่อประสาน", "ผู้ดูแลระบบฐานข้อมูล (คนที่ 1)", "ที่ปรึกษาด้านไอที", "นักวิเคราะห์ความปลอดภัยทางข้อมูล", "ผู้ดูแลระบบฐานข้อมูล (คนที่ 2)", "การเงินการบัญชี", "ฝ่ายบุคคล it", "ฝ่ายการขายและประชาสัมพันธ์", "ผู้ดูแลระบบฐานข้อมูล (คนที่ 3)"})
        cboDepartment.Location = New Point(246, 251)
        cboDepartment.Name = "cboDepartment"
        cboDepartment.Size = New Size(164, 29)
        cboDepartment.TabIndex = 9
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Location = New Point(448, 172)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(271, 29)
        dtpStartDate.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(448, 148)
        Label5.Name = "Label5"
        Label5.RightToLeft = RightToLeft.Yes
        Label5.Size = New Size(79, 21)
        Label5.TabIndex = 11
        Label5.Text = "วันที่เริ่มงาน"
        ' 
        ' dataGridView1
        ' 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dataGridView1.Location = New Point(212, 301)
        dataGridView1.Name = "dataGridView1"
        dataGridView1.RowHeadersWidth = 56
        dataGridView1.Size = New Size(731, 203)
        dataGridView1.TabIndex = 12
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ชื่อ"
        Column1.MinimumWidth = 7
        Column1.Name = "Column1"
        Column1.Width = 135
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "รหัส"
        Column2.MinimumWidth = 7
        Column2.Name = "Column2"
        Column2.Width = 135
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "แผนก"
        Column3.MinimumWidth = 7
        Column3.Name = "Column3"
        Column3.Width = 135
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "วันที่เริ่ทงาน"
        Column4.MinimumWidth = 7
        Column4.Name = "Column4"
        Column4.Width = 135
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "เพศ"
        Column5.MinimumWidth = 7
        Column5.Name = "Column5"
        Column5.Width = 135
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1298, 552)
        Controls.Add(dataGridView1)
        Controls.Add(Label5)
        Controls.Add(dtpStartDate)
        Controls.Add(cboDepartment)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(cboGender)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtName)
        Controls.Add(txtid)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Name = "Form1"
        Text = "Form1"
        CType(dataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtEmployeeId As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboDepartment As ComboBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents txtid As TextBox

End Class
