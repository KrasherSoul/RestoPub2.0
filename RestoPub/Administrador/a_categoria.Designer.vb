<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a_categoria
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbFamilia = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RestobarDataSet2 = New RestoPub.restobarDataSet2()
        Me.FamiliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FamiliaTableAdapter = New RestoPub.restobarDataSet2TableAdapters.familiaTableAdapter()
        CType(Me.RestobarDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FamiliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(153, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(128, 32)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre Categoria"
        '
        'CmbFamilia
        '
        Me.CmbFamilia.FormattingEnabled = True
        Me.CmbFamilia.Items.AddRange(New Object() {"Barra", "Cocina"})
        Me.CmbFamilia.Location = New System.Drawing.Point(128, 63)
        Me.CmbFamilia.Name = "CmbFamilia"
        Me.CmbFamilia.Size = New System.Drawing.Size(121, 21)
        Me.CmbFamilia.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Familia"
        '
        'RestobarDataSet2
        '
        Me.RestobarDataSet2.DataSetName = "restobarDataSet2"
        Me.RestobarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FamiliaBindingSource
        '
        Me.FamiliaBindingSource.DataMember = "familia"
        Me.FamiliaBindingSource.DataSource = Me.RestobarDataSet2
        '
        'FamiliaTableAdapter
        '
        Me.FamiliaTableAdapter.ClearBeforeFill = True
        '
        'a_categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 187)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbFamilia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Button1)
        Me.Name = "a_categoria"
        Me.Text = "a_categoria"
        CType(Me.RestobarDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FamiliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbFamilia As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RestobarDataSet2 As restobarDataSet2
    Friend WithEvents FamiliaBindingSource As BindingSource
    Friend WithEvents FamiliaTableAdapter As restobarDataSet2TableAdapters.familiaTableAdapter
End Class
