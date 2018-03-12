Public Class frm_AddGSTIN

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Dim Items2Search_ As New List(Of Item2Search)
    ReadOnly Property Items2Search As List(Of Item2Search)
        Get
            Return Items2Search_
        End Get
    End Property
    Private Sub btn_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ok.Click
        txt_GSTIN.Text = txt_GSTIN.Text.Trim
        If txt_GSTIN.Text = "" Then
            MsgBox("GSTINs to search can't be empty", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        Else
            For Each i As String In txt_GSTIN.Lines
                Items2Search_.Add(New Item2Search(i))
            Next
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class