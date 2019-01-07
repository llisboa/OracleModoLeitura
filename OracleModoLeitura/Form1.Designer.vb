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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grd = New Icraft.IcftFGrid2
        Me.btnAtualiza = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtSENHA = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUSU = New System.Windows.Forms.TextBox
        Me.Usu = New System.Windows.Forms.Label
        Me.txtCONN = New System.Windows.Forms.TextBox
        Me.con = New System.Windows.Forms.Label
        Me.btnLiberar = New System.Windows.Forms.Button
        Me.btnTravar = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd
        '
        Me.grd.AutoBind = False
        Me.grd.AutoRedimCell = Icraft.IcftFGrid2.AutoRedimCellTipo.AreaCelula
        Me.grd.BindContainer = Nothing
        Me.grd.Campos = Nothing
        Me.grd.CamposExtend = Nothing
        Me.grd.CamposFixos = ""
        Me.grd.Chave = Nothing
        Me.grd.ColunaNomes = ""
        Me.grd.Defs = Nothing
        Me.grd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd.EsquemaGerador = ""
        Me.grd.EsquemaPrinc = ""
        Me.grd.Filtro = Nothing
        Me.grd.IncluiCamposSys = False
        Me.grd.Info = "Informações..."
        Me.grd.Location = New System.Drawing.Point(0, 0)
        Me.grd.MostraNumReg = False
        Me.grd.Name = "grd"
        Me.grd.Ocultar = Nothing
        Me.grd.Params = CType(resources.GetObject("grd.Params"), System.Collections.ArrayList)
        Me.grd.Sistema = ""
        Me.grd.Size = New System.Drawing.Size(621, 365)
        Me.grd.SomenteLeitura = False
        Me.grd.SQL = ""
        Me.grd.StrConn = Nothing
        Me.grd.Tabela = ""
        Me.grd.TabIndex = 0
        Me.grd.Totaliza = ""
        Me.grd.Usuario = ""
        Me.grd.ValorPadrao = CType(resources.GetObject("grd.ValorPadrao"), System.Collections.ArrayList)
        '
        'btnAtualiza
        '
        Me.btnAtualiza.Location = New System.Drawing.Point(22, 135)
        Me.btnAtualiza.Name = "btnAtualiza"
        Me.btnAtualiza.Size = New System.Drawing.Size(111, 40)
        Me.btnAtualiza.TabIndex = 3
        Me.btnAtualiza.Text = "Atualizar"
        Me.btnAtualiza.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtSENHA)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtUSU)
        Me.Panel1.Controls.Add(Me.Usu)
        Me.Panel1.Controls.Add(Me.txtCONN)
        Me.Panel1.Controls.Add(Me.con)
        Me.Panel1.Controls.Add(Me.btnLiberar)
        Me.Panel1.Controls.Add(Me.btnTravar)
        Me.Panel1.Controls.Add(Me.btnAtualiza)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(621, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(145, 365)
        Me.Panel1.TabIndex = 2
        '
        'txtSENHA
        '
        Me.txtSENHA.Location = New System.Drawing.Point(32, 103)
        Me.txtSENHA.Name = "txtSENHA"
        Me.txtSENHA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSENHA.Size = New System.Drawing.Size(88, 20)
        Me.txtSENHA.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Senha"
        '
        'txtUSU
        '
        Me.txtUSU.Location = New System.Drawing.Point(32, 65)
        Me.txtUSU.Name = "txtUSU"
        Me.txtUSU.Size = New System.Drawing.Size(88, 20)
        Me.txtUSU.TabIndex = 1
        '
        'Usu
        '
        Me.Usu.AutoSize = True
        Me.Usu.Location = New System.Drawing.Point(30, 50)
        Me.Usu.Name = "Usu"
        Me.Usu.Size = New System.Drawing.Size(43, 13)
        Me.Usu.TabIndex = 3
        Me.Usu.Text = "Usuário"
        '
        'txtCONN
        '
        Me.txtCONN.Location = New System.Drawing.Point(32, 28)
        Me.txtCONN.Name = "txtCONN"
        Me.txtCONN.Size = New System.Drawing.Size(88, 20)
        Me.txtCONN.TabIndex = 0
        '
        'con
        '
        Me.con.AutoSize = True
        Me.con.Location = New System.Drawing.Point(30, 13)
        Me.con.Name = "con"
        Me.con.Size = New System.Drawing.Size(49, 13)
        Me.con.TabIndex = 3
        Me.con.Text = "Conexão"
        '
        'btnLiberar
        '
        Me.btnLiberar.Location = New System.Drawing.Point(22, 255)
        Me.btnLiberar.Name = "btnLiberar"
        Me.btnLiberar.Size = New System.Drawing.Size(111, 40)
        Me.btnLiberar.TabIndex = 5
        Me.btnLiberar.Text = "Liberar"
        Me.btnLiberar.UseVisualStyleBackColor = True
        '
        'btnTravar
        '
        Me.btnTravar.Location = New System.Drawing.Point(22, 209)
        Me.btnTravar.Name = "btnTravar"
        Me.btnTravar.Size = New System.Drawing.Size(111, 40)
        Me.btnTravar.TabIndex = 4
        Me.btnTravar.Text = "Travar"
        Me.btnTravar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 365)
        Me.Controls.Add(Me.grd)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "OracleModoLeitura - Intercraft Solutions - 2012"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grd As Icraft.IcftFGrid2
    Friend WithEvents btnAtualiza As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnTravar As System.Windows.Forms.Button
    Friend WithEvents btnLiberar As System.Windows.Forms.Button
    Friend WithEvents txtSENHA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUSU As System.Windows.Forms.TextBox
    Friend WithEvents Usu As System.Windows.Forms.Label
    Friend WithEvents txtCONN As System.Windows.Forms.TextBox
    Friend WithEvents con As System.Windows.Forms.Label

End Class
