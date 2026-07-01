Imports System.ComponentModel

Public Class Form1
    Private txtEmpName As Object
    Private cboDept As Object
    Private txtEmpCode As Object
    Private dtpStart As Object

    Public Sub New(txtEmpName As Object, cboDept As Object, txtEmpCode As Object, dtpStart As Object, components As IContainer, btnAdd As Button, btnDelete As Button, txtEmployeeId As TextBox, txtName As TextBox, label1 As Label, label2 As Label, cboGender As ComboBox, label3 As Label, label4 As Label, cboDepartment As ComboBox, dtpStartDate As DateTimePicker, label5 As Label, dataGridView1 As DataGridView, column1 As DataGridViewTextBoxColumn, column2 As DataGridViewTextBoxColumn, 2olumn3 As DataGridViewTextBoxColumn, column4 As DataGridViewTextBoxColumn, column5 As DataGridViewTextBoxColumn)
        ArgumentNullException.ThrowIfNull(column5)
        Me.txtEmpName = txtEmpName
        Me.cboDept = cboDept
        Me.txtEmpCode = txtEmpCode
        Me.dtpStart = dtpStart
        Me.components = components
        Me.btnAdd = btnAdd
        Me.btnDelete = btnDelete
        Me.txtEmployeeId = txtEmployeeId
        Me.txtName = txtName
        Me.Label1 = label1
        Me.Label2 = label2
        Me.cboGender = cboGender
        Me.Label3 = label3
        Me.Label4 = label4
        Me.cboDepartment = cboDepartment
        Me.dtpStartDate = dtpStartDate
        Me.Label5 = label5
        Me.dataGridView1 = dataGridView1
        Me.Column1 = column1
        Me.Column2 = column2
        Me.Column3 = Column3
        Me.Column4 = column4
        Me.Column5 = column5
    End Sub

    ' โหลดฟอร์ม
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' สร้างคอลัมน์ให้ DataGridView1
        dataGridView1.ColumnCount = 5
        dataGridView1.Columns(0).Name = "ชื่อ"
        dataGridView1.Columns(1).Name = "รหัส"
        dataGridView1.Columns(2).Name = "แผนก"
        dataGridView1.Columns(3).Name = "วันที่เริ่มงาน"
        dataGridView1.Columns(4).Name = "เพศ"

        ' ตั้งค่าให้คอลัมน์แรกอ่านอย่างเดียว (ห้ามแก้ไข)
        dataGridView1.Columns(0).ReadOnly = True

        ' ตั้งค่าการแสดงผลเพิ่มเติม
        dataGridView1.AllowUserToAddRows = False   ' ไม่ให้ผู้ใช้เพิ่มแถวเอง
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect ' เลือกทั้งแถว
        dataGridView1.MultiSelect = False          ' เลือกได้ทีละแถว
    End Sub


    ' ปุ่มเพิ่มข้อมูล
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' ตรวจสอบว่ากรอกข้อมูลครบหรือไม่
        If txtEmpName.Text = "" Or txtEmpCode.Text = "" Or cboDept.Text = "" Or cboGender.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' เพิ่มข้อมูลลง DataGridView1
        dataGridView1.Rows.Add(
            txtEmpName.Text,
            txtEmpCode.Text,
            cboDept.Text,
            dtpStart.Value.ToShortDateString(),
            cboGender.Text
        )

        ' ล้างค่าหลังเพิ่ม
        txtEmpName.Clear()
        txtEmpCode.Clear()
        cboDept.SelectedIndex = -1
        cboGender.SelectedIndex = -1
    End Sub

    ' ปุ่มลบข้อมูล
    Private Sub 6btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dataGridView1.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dataGridView1.SelectedRows
                If Not row.IsNewRow Then
                    dataGridView1.Rows.Remove(row)
                End If
            Next
        Else
            MessageBox.Show("กรุณาเลือกแถวที่ต้องการลบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellContentClick
        ' สร้างคอลัมน์ใน DataGridView1
        dataGridView1.ColumnCount = 5
        dataGridView1.Columns(0).Name = "ชื่อ"
        dataGridView1.Columns(1).Name = "รหัส"
        dataGridView1.Columns(2).Name = "แผนก"
        dataGridView1.Columns(3).Name = "วันที่เริ่มงาน"
        dataGridView1.Columns(4).Name = "เพศ"

        ' กำหนดไม่ให้แก้ไขคอลัมน์ชื่อ
        dataGridView1.Columns(0).ReadOnly = True
    End Sub
End Class
