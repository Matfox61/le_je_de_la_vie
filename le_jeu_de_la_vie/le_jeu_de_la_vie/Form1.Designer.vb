<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.panel = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLecture = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnAleatoire = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMinVivants = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNbVivantes = New System.Windows.Forms.Label()
        Me.txtMaxVivants = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnValider = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.panel.ColumnCount = 20
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.panel.Location = New System.Drawing.Point(247, 155)
        Me.panel.Margin = New System.Windows.Forms.Padding(4)
        Me.panel.Name = "panel"
        Me.panel.RowCount = 20
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.panel.Size = New System.Drawing.Size(583, 516)
        Me.panel.TabIndex = 0
        '
        'btnLecture
        '
        Me.btnLecture.Location = New System.Drawing.Point(280, 68)
        Me.btnLecture.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLecture.Name = "btnLecture"
        Me.btnLecture.Size = New System.Drawing.Size(100, 28)
        Me.btnLecture.TabIndex = 1
        Me.btnLecture.Text = "Lecture"
        Me.btnLecture.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(688, 68)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(100, 28)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Stop !"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnAleatoire
        '
        Me.btnAleatoire.Location = New System.Drawing.Point(680, 709)
        Me.btnAleatoire.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAleatoire.Name = "btnAleatoire"
        Me.btnAleatoire.Size = New System.Drawing.Size(100, 28)
        Me.btnAleatoire.TabIndex = 3
        Me.btnAleatoire.Text = "Aléatoire"
        Me.btnAleatoire.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(243, 709)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre de cellules pour devenir vivant :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(244, 762)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Si la cellule est vivante "
        '
        'txtMinVivants
        '
        Me.txtMinVivants.Location = New System.Drawing.Point(432, 759)
        Me.txtMinVivants.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMinVivants.Name = "txtMinVivants"
        Me.txtMinVivants.Size = New System.Drawing.Size(35, 22)
        Me.txtMinVivants.TabIndex = 7
        Me.txtMinVivants.Text = "2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(653, 777)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cellules vivantes : "
        '
        'lblNbVivantes
        '
        Me.lblNbVivantes.AutoSize = True
        Me.lblNbVivantes.Location = New System.Drawing.Point(788, 777)
        Me.lblNbVivantes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNbVivantes.Name = "lblNbVivantes"
        Me.lblNbVivantes.Size = New System.Drawing.Size(0, 17)
        Me.lblNbVivantes.TabIndex = 10
        '
        'txtMaxVivants
        '
        Me.txtMaxVivants.Location = New System.Drawing.Point(501, 759)
        Me.txtMaxVivants.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaxVivants.Name = "txtMaxVivants"
        Me.txtMaxVivants.Size = New System.Drawing.Size(37, 22)
        Me.txtMaxVivants.TabIndex = 11
        Me.txtMaxVivants.Text = "3"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnValider
        '
        Me.btnValider.Location = New System.Drawing.Point(562, 740)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(75, 60)
        Me.btnValider.TabIndex = 14
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 878)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.txtMaxVivants)
        Me.Controls.Add(Me.lblNbVivantes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMinVivants)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAleatoire)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnLecture)
        Me.Controls.Add(Me.panel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel As TableLayoutPanel
    Friend WithEvents btnLecture As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnAleatoire As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMinVivants As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNbVivantes As Label
    Friend WithEvents txtMaxVivants As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnValider As Button
End Class
