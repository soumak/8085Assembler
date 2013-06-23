Public Class Form2

    'form load function

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(880, 400)
        Cursor.Position = Me.PointToScreen(New Point(140, 55))

        'select tab
        'MVIR
        If ButtonFlowSignals.Which_Button_clicked = 1 Then
            TabControl1.SelectedTab = TabPage1
            ButtonFlowSignals.Which_Button_clicked = 0
        End If
        'MVIM
        If ButtonFlowSignals.Which_Button_clicked = 2 Then
            TabControl1.SelectedTab = TabPage2
            ButtonFlowSignals.Which_Button_clicked = 0
        End If

        'LDA

        If ButtonFlowSignals.Which_Button_clicked = 3 Then
            TabControl1.SelectedTab = TabPage3
            ButtonFlowSignals.Which_Button_clicked = 0
        End If

        'LXI


        If ButtonFlowSignals.Which_Button_clicked = 4 Then
            TabControl1.SelectedTab = TabPage4
            ButtonFlowSignals.Which_Button_clicked = 0
        End If

        'STA

        If ButtonFlowSignals.Which_Button_clicked = 5 Then
            TabControl1.SelectedTab = TabPage5
            ButtonFlowSignals.Which_Button_clicked = 0
        End If

        'SHLD

        If ButtonFlowSignals.Which_Button_clicked = 6 Then
            TabControl1.SelectedTab = TabPage6
            ButtonFlowSignals.Which_Button_clicked = 0
        End If

        'ADD

        If ButtonFlowSignals.Which_Button_clicked = 7 Then
            TabControl1.SelectedTab = TabPage7
            ButtonFlowSignals.Which_Button_clicked = 0
        End If

        'ADI
        If ButtonFlowSignals.Which_Button_clicked = 8 Then
            TabControl1.SelectedTab = TabPage8
            ButtonFlowSignals.Which_Button_clicked = 0
        End If

        'ADDMM
        If ButtonFlowSignals.Which_Button_clicked = 9 Then
            TabControl1.SelectedTab = TabPage9
            ButtonFlowSignals.Which_Button_clicked = 0
        End If

        'JNZ
        If ButtonFlowSignals.Which_Button_clicked = 10 Then
            TabControl1.SelectedTab = TabPage10
            ButtonFlowSignals.Which_Button_clicked = 0
        End If

        'JMP
        If ButtonFlowSignals.Which_Button_clicked = 11 Then
            TabControl1.SelectedTab = TabPage11
            ButtonFlowSignals.Which_Button_clicked = 0
        End If
        'SBB
        If ButtonFlowSignals.Which_Button_clicked = 12 Then
            TabControl1.SelectedTab = TabPage12
            ButtonFlowSignals.Which_Button_clicked = 0
        End If

        'SBI
        If ButtonFlowSignals.Which_Button_clicked = 13 Then
            TabControl1.SelectedTab = TabPage13
            ButtonFlowSignals.Which_Button_clicked = 0
        End If

        'ADC

        If ButtonFlowSignals.Which_Button_clicked = 14 Then
            TabControl1.SelectedTab = TabPage14
            ButtonFlowSignals.Which_Button_clicked = 0
        End If
        'MOV
        If ButtonFlowSignals.Which_Button_clicked = 15 Then
            TabControl1.SelectedTab = TabPage15
            ButtonFlowSignals.Which_Button_clicked = 0
        End If






    End Sub



    '#######################################################################################################################
    '----------------------------------
    'MVIR button click
    Private Sub MVIR_pb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MVIR_pb.Click

        Form1.RichTextBox1.SelectedText = "MVIR " + MVIR_pcb.Text

        Me.Close()

    End Sub

    Private Sub Cancel_bf2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_bf2.Click
        Me.Close()
        MVIR_p.Visible = False

    End Sub


    '####################################################################################################################
    '-----------------------------------


    '-------------------------------------
    'MVIM button click
    Private Sub MVIM_pb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MVIM_pb.Click
        Form1.RichTextBox1.SelectedText = "MVIM " + MVIM_ptb.Text

        Me.Close()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    '-------------------------------------

    '------------------------------------
    'LDA button click
    Private Sub LDA_pb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LDA_pb.Click
        Form1.RichTextBox1.SelectedText = "LDA " + LDA_ptb.Text

        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    '--------------------------------------

    '--------------------------------------
    'LXI
    Private Sub LXI_pb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LXI_pb.Click
        Form1.RichTextBox1.SelectedText = "LXI h " + LXI_ptb.Text

        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    '--------------------------------------
    'STA
    '--------------------------------------
    Private Sub STA_pb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STA_pb.Click
        Form1.RichTextBox1.SelectedText = "STA " + STA_ptb.Text

        Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()

    End Sub



    '--------------------------------------
    'SHLD
    Private Sub SHLD_pb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHLD_pb.Click
        Form1.RichTextBox1.SelectedText = "SHLD " + SHLD_ptb.Text

        Me.Close()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()

    End Sub


    '----------------------------------------
    'ADD
    Private Sub ADD_pb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADD_pb.Click
        Form1.RichTextBox1.SelectedText = "ADD " + ADD_pcb.Text

        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()

    End Sub
    '---------------------------------------
    'ADI
    Private Sub ADI_pb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADI_pb.Click
        Form1.RichTextBox1.SelectedText = "ADI " + ADI_ptb.Text
        Me.Close()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Close()

    End Sub
    '---------------------------------------
    'ADDMM

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.RichTextBox1.SelectedText = "ADDMM " + ADDMM_ptb3.Text + " " + ADDMM_ptb2.Text + " " + ADDMM_ptb3.Text
        Me.Close()
    End Sub


    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Close()
    End Sub

    '----------------------------------------

    'JNZ
    Private Sub JNZ_pb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JNZ_pb.Click
        Form1.RichTextBox1.SelectedText = "JNZ " + JNZ_ptb.Text
        Me.Close()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    '--------------------------------------------------------------
    'JMP
    Private Sub JMP_pb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JMP_pb.Click
        Form1.RichTextBox1.SelectedText = "JMP " + JMP_ptb.Text
        Me.Close()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    '----------------------------------------------------------------


    'SBB
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Form1.RichTextBox1.SelectedText = "SBB " + SBB_pcb.Text
        Me.Close()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Me.Close()
    End Sub

    '-----------------------------------------------------------------
    'SBI
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Form1.RichTextBox1.SelectedText = "SBI " + SBI_ptb.Text
        Me.Close()

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Me.Close()

    End Sub

    '------------------------------------------------------------------

    'ADC

    Private Sub ADC_pb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADC_pb.Click
        Form1.RichTextBox1.SelectedText = "ADC " + ADC_pcb.Text
        Me.Close()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click, Button17.Click
        Me.Close()

    End Sub
    '--------------------------------------------------------------------

    'MOV

    Private Sub MOV_pb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MOV_pb.Click
        Form1.RichTextBox1.SelectedText = "MOV " + MOV_cb1.Text + " " + MOV_cb2.Text
        Me.Close()
    End Sub
End Class


Public Class ButtonFlowSignals
    Public Shared Which_Button_clicked = 0


End Class
