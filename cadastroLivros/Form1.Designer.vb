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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnNao = New System.Windows.Forms.RadioButton()
        Me.rbtnSim = New System.Windows.Forms.RadioButton()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.lsvLivros = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Título:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Autor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ano:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnNao)
        Me.GroupBox1.Controls.Add(Me.rbtnSim)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 58)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Disponível?"
        '
        'rbtnNao
        '
        Me.rbtnNao.AutoSize = True
        Me.rbtnNao.Location = New System.Drawing.Point(117, 25)
        Me.rbtnNao.Name = "rbtnNao"
        Me.rbtnNao.Size = New System.Drawing.Size(45, 17)
        Me.rbtnNao.TabIndex = 1
        Me.rbtnNao.TabStop = True
        Me.rbtnNao.Text = "Não"
        Me.rbtnNao.UseVisualStyleBackColor = True
        '
        'rbtnSim
        '
        Me.rbtnSim.AutoSize = True
        Me.rbtnSim.Location = New System.Drawing.Point(47, 25)
        Me.rbtnSim.Name = "rbtnSim"
        Me.rbtnSim.Size = New System.Drawing.Size(42, 17)
        Me.rbtnSim.TabIndex = 0
        Me.rbtnSim.TabStop = True
        Me.rbtnSim.Text = "Sim"
        Me.rbtnSim.UseVisualStyleBackColor = True
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Location = New System.Drawing.Point(25, 187)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(204, 40)
        Me.btnCadastrar.TabIndex = 4
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(66, 22)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(163, 20)
        Me.txtTitulo.TabIndex = 5
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(66, 53)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(163, 20)
        Me.txtAno.TabIndex = 6
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(66, 86)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(163, 20)
        Me.txtAutor.TabIndex = 7
        '
        'lsvLivros
        '
        Me.lsvLivros.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lsvLivros.FullRowSelect = True
        Me.lsvLivros.GridLines = True
        Me.lsvLivros.Location = New System.Drawing.Point(253, 22)
        Me.lsvLivros.Name = "lsvLivros"
        Me.lsvLivros.Size = New System.Drawing.Size(432, 205)
        Me.lsvLivros.TabIndex = 8
        Me.lsvLivros.UseCompatibleStateImageBehavior = False
        Me.lsvLivros.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Título"
        Me.ColumnHeader1.Width = 132
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Ano"
        Me.ColumnHeader2.Width = 64
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Autor"
        Me.ColumnHeader3.Width = 159
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Disponível"
        Me.ColumnHeader4.Width = 145
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 257)
        Me.Controls.Add(Me.lsvLivros)
        Me.Controls.Add(Me.txtAutor)
        Me.Controls.Add(Me.txtAno)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Biblioteca"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnNao As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSim As System.Windows.Forms.RadioButton
    Friend WithEvents btnCadastrar As System.Windows.Forms.Button
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents txtAutor As System.Windows.Forms.TextBox
    Friend WithEvents lsvLivros As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader

End Class
