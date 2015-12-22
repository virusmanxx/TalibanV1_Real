<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Taliban
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Taliban))
        Me.FeaturesBox = New System.Windows.Forms.GroupBox()
        Me.Triggerbot = New System.Windows.Forms.CheckBox()
        Me.BunnyHop = New System.Windows.Forms.CheckBox()
        Me.Radar = New System.Windows.Forms.CheckBox()
        Me.updateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FeaturesBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'FeaturesBox
        '
        Me.FeaturesBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.FeaturesBox.Controls.Add(Me.Triggerbot)
        Me.FeaturesBox.Controls.Add(Me.BunnyHop)
        Me.FeaturesBox.Controls.Add(Me.Radar)
        Me.FeaturesBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeaturesBox.ForeColor = System.Drawing.Color.Black
        Me.FeaturesBox.Location = New System.Drawing.Point(-1, 2)
        Me.FeaturesBox.Name = "FeaturesBox"
        Me.FeaturesBox.Size = New System.Drawing.Size(109, 71)
        Me.FeaturesBox.TabIndex = 2
        Me.FeaturesBox.TabStop = False
        Me.FeaturesBox.Text = "Taliban V1"
        '
        'Triggerbot
        '
        Me.Triggerbot.AutoSize = True
        Me.Triggerbot.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Triggerbot.Location = New System.Drawing.Point(9, 48)
        Me.Triggerbot.Name = "Triggerbot"
        Me.Triggerbot.Size = New System.Drawing.Size(93, 20)
        Me.Triggerbot.TabIndex = 0
        Me.Triggerbot.Text = "Triggerbot"
        Me.Triggerbot.UseVisualStyleBackColor = True
        '
        'BunnyHop
        '
        Me.BunnyHop.AutoSize = True
        Me.BunnyHop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BunnyHop.Location = New System.Drawing.Point(9, 32)
        Me.BunnyHop.Name = "BunnyHop"
        Me.BunnyHop.Size = New System.Drawing.Size(95, 20)
        Me.BunnyHop.TabIndex = 2
        Me.BunnyHop.Text = "Bunny Hop"
        Me.BunnyHop.UseVisualStyleBackColor = True
        '
        'Radar
        '
        Me.Radar.AutoSize = True
        Me.Radar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Radar.Location = New System.Drawing.Point(9, 16)
        Me.Radar.Name = "Radar"
        Me.Radar.Size = New System.Drawing.Size(62, 20)
        Me.Radar.TabIndex = 1
        Me.Radar.Text = "Radar"
        Me.Radar.UseVisualStyleBackColor = True
        '
        'updateTimer
        '
        Me.updateTimer.Enabled = True
        '
        'Taliban
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(107, 74)
        Me.Controls.Add(Me.FeaturesBox)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Taliban"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Taliban"
        Me.FeaturesBox.ResumeLayout(False)
        Me.FeaturesBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FeaturesBox As System.Windows.Forms.GroupBox
    Friend WithEvents BunnyHop As System.Windows.Forms.CheckBox
    Friend WithEvents Radar As System.Windows.Forms.CheckBox
    Friend WithEvents Triggerbot As System.Windows.Forms.CheckBox
    Friend WithEvents updateTimer As System.Windows.Forms.Timer
End Class
