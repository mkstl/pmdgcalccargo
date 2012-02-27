Public Class Form1
    Private Const B736 As Byte = 119
    Private Const B73W As Byte = 136
    Private Const B738 As Byte = 166
    Private kgsTolbs As Single = 25
    Private MAX As Byte
    Private Mult As Single = 1.2
    Private pcn As Single = 0.45

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lboxAC.SelectedItem = "736"
    End Sub

    Private Sub lboxAC_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lboxAC.SelectedIndexChanged
        If lboxAC.SelectedItem = "736" Then
            MAX = B736
            lblPAX.Text = B736
        ElseIf lboxAC.SelectedItem = "73W" Then
            MAX = B73W
            lblPAX.Text = B73W
        Else
            MAX = B738
            lblPAX.Text = B738
        End If
    End Sub

    Private Sub trkMult_Scroll(sender As System.Object, e As System.EventArgs) Handles trkMult.Scroll
        Mult = trkMult.Value / 100
        lblMult.Text = trkMult.Value / 100
        Calculate_Cargo()
    End Sub

    Private Sub radLbs_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radLbs.CheckedChanged
        If radLbs.Checked = True Then
            kgsTolbs = 25
            lblCG1.Text = "lbs"
            lblCG2.Text = "lbs"
        Else
            kgsTolbs = 11
            lblCG1.Text = "kgs"
            lblCG2.Text = "kgs"
        End If
        Calculate_Cargo()
    End Sub

    Private Sub txtPAX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPAX.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
          Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtPAX_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPAX.TextChanged
        Calculate_Cargo()
    End Sub

    Private Sub Calculate_Cargo()
        Dim pax As Integer
        Dim w1 As Single
        Dim w2 As Single

        If IsNumeric(txtPAX.Text) Then
            pax = Convert.ToInt16(txtPAX.Text)

            w1 = pax * Mult * kgsTolbs * pcn
            w2 = pax * Mult * kgsTolbs * (1 - pcn)

            txtW1.Text = FormatNumber(w1, 0)
            txtW2.Text = FormatNumber(w2, 0)
        End If
    End Sub

    Private Sub trkPct_Scroll(sender As System.Object, e As System.EventArgs) Handles trkPct.Scroll
        pcn = trkPct.Value / 100
        lblPcn1.Text = FormatPercent(pcn, 1)
        lblPcn2.Text = FormatPercent((1 - pcn), 1)
        Calculate_Cargo()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.virtualwestjet.org/")
    End Sub
End Class
