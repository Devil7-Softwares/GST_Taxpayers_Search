<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AddGSTIN
    Inherits XtraFormTemp

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
        Me.lbl_EnterGSTIN = New DevExpress.XtraEditors.LabelControl()
        Me.txt_GSTIN = New System.Windows.Forms.TextBox()
        Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Ok = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'lbl_EnterGSTIN
        '
        Me.lbl_EnterGSTIN.Location = New System.Drawing.Point(12, 12)
        Me.lbl_EnterGSTIN.Name = "lbl_EnterGSTIN"
        Me.lbl_EnterGSTIN.Size = New System.Drawing.Size(216, 13)
        Me.lbl_EnterGSTIN.TabIndex = 0
        Me.lbl_EnterGSTIN.Text = "GSTIN(s) to seach (Enter one GSTIN per line)"
        '
        'txt_GSTIN
        '
        Me.txt_GSTIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_GSTIN.Location = New System.Drawing.Point(12, 31)
        Me.txt_GSTIN.Multiline = True
        Me.txt_GSTIN.Name = "txt_GSTIN"
        Me.txt_GSTIN.Size = New System.Drawing.Size(400, 246)
        Me.txt_GSTIN.TabIndex = 1
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.Location = New System.Drawing.Point(256, 283)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 2
        Me.btn_Cancel.Text = "Cancel"
        '
        'btn_Ok
        '
        Me.btn_Ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Ok.Location = New System.Drawing.Point(337, 283)
        Me.btn_Ok.Name = "btn_Ok"
        Me.btn_Ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_Ok.TabIndex = 2
        Me.btn_Ok.Text = "Ok"
        '
        'frm_AddGSTIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 324)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Ok)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.txt_GSTIN)
        Me.Controls.Add(Me.lbl_EnterGSTIN)
        Me.Name = "frm_AddGSTIN"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add GSTIN to Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lbl_EnterGSTIN As DevExpress.XtraEditors.LabelControl
    Private WithEvents txt_GSTIN As System.Windows.Forms.TextBox
    Private WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
    Private WithEvents btn_Ok As DevExpress.XtraEditors.SimpleButton
End Class
