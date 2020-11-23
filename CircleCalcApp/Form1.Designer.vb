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
        Me.TBIRadius = New System.Windows.Forms.TextBox()
        Me.BTNCalcArea = New System.Windows.Forms.Button()
        Me.BTNCalcCircumference = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBOResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(76, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Radius"
        '
        'TBIRadius
        '
        Me.TBIRadius.Location = New System.Drawing.Point(143, 57)
        Me.TBIRadius.Name = "TBIRadius"
        Me.TBIRadius.Size = New System.Drawing.Size(100, 23)
        Me.TBIRadius.TabIndex = 1
        Me.TBIRadius.Text = "Radius in cm"
        '
        'BTNCalcArea
        '
        Me.BTNCalcArea.Location = New System.Drawing.Point(124, 113)
        Me.BTNCalcArea.Name = "BTNCalcArea"
        Me.BTNCalcArea.Size = New System.Drawing.Size(75, 23)
        Me.BTNCalcArea.TabIndex = 2
        Me.BTNCalcArea.Text = "Calc Area"
        Me.BTNCalcArea.UseVisualStyleBackColor = True
        '
        'BTNCalcCircumference
        '
        Me.BTNCalcCircumference.Location = New System.Drawing.Point(92, 142)
        Me.BTNCalcCircumference.Name = "BTNCalcCircumference"
        Me.BTNCalcCircumference.Size = New System.Drawing.Size(141, 23)
        Me.BTNCalcCircumference.TabIndex = 3
        Me.BTNCalcCircumference.Text = "Calc Circumference"
        Me.BTNCalcCircumference.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(74, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Result"
        '
        'TBOResult
        '
        Me.TBOResult.Location = New System.Drawing.Point(143, 194)
        Me.TBOResult.Name = "TBOResult"
        Me.TBOResult.Size = New System.Drawing.Size(100, 23)
        Me.TBOResult.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 311)
        Me.Controls.Add(Me.TBOResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTNCalcCircumference)
        Me.Controls.Add(Me.BTNCalcArea)
        Me.Controls.Add(Me.TBIRadius)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Circle Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TBIRadius As TextBox
    Friend WithEvents BTNCalcArea As Button
    Friend WithEvents BTNCalcCircumference As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TBOResult As TextBox
End Class
