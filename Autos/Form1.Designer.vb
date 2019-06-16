<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.VehicleCategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutosDataSet = New Autos.autosDataSet()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.Vehicle_CategoriesTableAdapter = New Autos.autosDataSetTableAdapters.Vehicle_CategoriesTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VehicleCategoryCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleCategoryDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.VehicleCategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleCategoriesBindingSource, "Vehicle_Category_Code", True))
        Me.txtCode.Location = New System.Drawing.Point(125, 23)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(145, 20)
        Me.txtCode.TabIndex = 0
        '
        'VehicleCategoriesBindingSource
        '
        Me.VehicleCategoriesBindingSource.DataMember = "Vehicle_Categories"
        Me.VehicleCategoriesBindingSource.DataSource = Me.AutosDataSet
        '
        'AutosDataSet
        '
        Me.AutosDataSet.DataSetName = "autosDataSet"
        Me.AutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDescription
        '
        Me.txtDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleCategoriesBindingSource, "Vehicle_Category_Description", True))
        Me.txtDescription.Location = New System.Drawing.Point(125, 69)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(145, 20)
        Me.txtDescription.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Description"
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.VehicleCategoriesBindingSource
        Me.ListBox1.DisplayMember = "Vehicle_Category_Description"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(351, 30)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(247, 121)
        Me.ListBox1.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClean)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 133)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data"
        '
        'btnClean
        '
        Me.btnClean.Location = New System.Drawing.Point(123, 104)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(147, 23)
        Me.btnClean.TabIndex = 9
        Me.btnClean.Text = "Clean"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'Vehicle_CategoriesTableAdapter
        '
        Me.Vehicle_CategoriesTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VehicleCategoryCodeDataGridViewTextBoxColumn, Me.VehicleCategoryDescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VehicleCategoriesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(23, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(575, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'VehicleCategoryCodeDataGridViewTextBoxColumn
        '
        Me.VehicleCategoryCodeDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Category_Code"
        Me.VehicleCategoryCodeDataGridViewTextBoxColumn.HeaderText = "Vehicle_Category_Code"
        Me.VehicleCategoryCodeDataGridViewTextBoxColumn.Name = "VehicleCategoryCodeDataGridViewTextBoxColumn"
        Me.VehicleCategoryCodeDataGridViewTextBoxColumn.Width = 146
        '
        'VehicleCategoryDescriptionDataGridViewTextBoxColumn
        '
        Me.VehicleCategoryDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Category_Description"
        Me.VehicleCategoryDescriptionDataGridViewTextBoxColumn.HeaderText = "Vehicle_Category_Description"
        Me.VehicleCategoryDescriptionDataGridViewTextBoxColumn.Name = "VehicleCategoryDescriptionDataGridViewTextBoxColumn"
        Me.VehicleCategoryDescriptionDataGridViewTextBoxColumn.Width = 174
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 326)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Categories"
        CType(Me.VehicleCategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AutosDataSet As autosDataSet
    Friend WithEvents VehicleCategoriesBindingSource As BindingSource
    Friend WithEvents Vehicle_CategoriesTableAdapter As autosDataSetTableAdapters.Vehicle_CategoriesTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VehicleCategoryCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleCategoryDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnClean As Button
End Class
