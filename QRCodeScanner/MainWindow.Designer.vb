<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.btn_detect = New System.Windows.Forms.Button()
        Me.btn_saveImage = New System.Windows.Forms.Button()
        Me.pb_scanner = New System.Windows.Forms.PictureBox()
        Me.tb_output = New System.Windows.Forms.TextBox()
        CType(Me.pb_scanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(344, 12)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(75, 23)
        Me.btn_start.TabIndex = 0
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.Location = New System.Drawing.Point(344, 41)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(75, 23)
        Me.btn_stop.TabIndex = 1
        Me.btn_stop.Text = "Stop"
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'btn_detect
        '
        Me.btn_detect.Location = New System.Drawing.Point(344, 70)
        Me.btn_detect.Name = "btn_detect"
        Me.btn_detect.Size = New System.Drawing.Size(75, 23)
        Me.btn_detect.TabIndex = 2
        Me.btn_detect.Text = "Detect"
        Me.btn_detect.UseVisualStyleBackColor = True
        '
        'btn_saveImage
        '
        Me.btn_saveImage.Location = New System.Drawing.Point(344, 99)
        Me.btn_saveImage.Name = "btn_saveImage"
        Me.btn_saveImage.Size = New System.Drawing.Size(75, 23)
        Me.btn_saveImage.TabIndex = 3
        Me.btn_saveImage.Text = "Save Image"
        Me.btn_saveImage.UseVisualStyleBackColor = True
        '
        'pb_scanner
        '
        Me.pb_scanner.Location = New System.Drawing.Point(12, 12)
        Me.pb_scanner.Name = "pb_scanner"
        Me.pb_scanner.Size = New System.Drawing.Size(326, 265)
        Me.pb_scanner.TabIndex = 4
        Me.pb_scanner.TabStop = False
        '
        'tb_output
        '
        Me.tb_output.Location = New System.Drawing.Point(12, 283)
        Me.tb_output.Multiline = True
        Me.tb_output.Name = "tb_output"
        Me.tb_output.ReadOnly = True
        Me.tb_output.Size = New System.Drawing.Size(326, 71)
        Me.tb_output.TabIndex = 5
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 360)
        Me.Controls.Add(Me.tb_output)
        Me.Controls.Add(Me.pb_scanner)
        Me.Controls.Add(Me.btn_saveImage)
        Me.Controls.Add(Me.btn_detect)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.btn_start)
        Me.Name = "MainWindow"
        Me.Text = "QR Code Scanner"
        CType(Me.pb_scanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_start As Button
    Friend WithEvents btn_stop As Button
    Friend WithEvents btn_detect As Button
    Friend WithEvents btn_saveImage As Button
    Friend WithEvents pb_scanner As PictureBox
    Friend WithEvents tb_output As TextBox
End Class
