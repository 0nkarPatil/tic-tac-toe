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
        Me.A1 = New System.Windows.Forms.Button()
        Me.A2 = New System.Windows.Forms.Button()
        Me.A3 = New System.Windows.Forms.Button()
        Me.B1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.C1 = New System.Windows.Forms.Button()
        Me.C2 = New System.Windows.Forms.Button()
        Me.C3 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'A1
        '
        Me.A1.Location = New System.Drawing.Point(12, 37)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(54, 56)
        Me.A1.TabIndex = 0
        Me.A1.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.Location = New System.Drawing.Point(72, 37)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(54, 56)
        Me.A2.TabIndex = 1
        Me.A2.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.Location = New System.Drawing.Point(132, 37)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(54, 56)
        Me.A3.TabIndex = 2
        Me.A3.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(12, 100)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(54, 56)
        Me.B1.TabIndex = 3
        Me.B1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Location = New System.Drawing.Point(72, 99)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(54, 56)
        Me.B2.TabIndex = 4
        Me.B2.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Location = New System.Drawing.Point(132, 100)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(54, 56)
        Me.B3.TabIndex = 5
        Me.B3.UseVisualStyleBackColor = True
        '
        'C1
        '
        Me.C1.Location = New System.Drawing.Point(12, 162)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(54, 56)
        Me.C1.TabIndex = 6
        Me.C1.UseVisualStyleBackColor = True
        '
        'C2
        '
        Me.C2.Location = New System.Drawing.Point(72, 162)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(54, 56)
        Me.C2.TabIndex = 7
        Me.C2.UseVisualStyleBackColor = True
        '
        'C3
        '
        Me.C3.Location = New System.Drawing.Point(132, 162)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(54, 56)
        Me.C3.TabIndex = 8
        Me.C3.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(200, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 237)
        Me.Controls.Add(Me.C3)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.A3)
        Me.Controls.Add(Me.A2)
        Me.Controls.Add(Me.A1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents A1 As System.Windows.Forms.Button
    Friend WithEvents A2 As System.Windows.Forms.Button
    Friend WithEvents A3 As System.Windows.Forms.Button
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents B2 As System.Windows.Forms.Button
    Friend WithEvents B3 As System.Windows.Forms.Button
    Friend WithEvents C1 As System.Windows.Forms.Button
    Friend WithEvents C2 As System.Windows.Forms.Button
    Friend WithEvents C3 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
