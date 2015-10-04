'*****************************************************************************************
'                           LICENSE INFORMATION
'*****************************************************************************************
' All Copyrights related to Allomani Programming Services 
'                    www.allomani.com                       
'*****************************************************************************************

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb

Public Class Form1
    Private comm As New CommManager()
    Private transType As String = String.Empty

    Dim cnn As New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet

    Dim colors_types(0) As String
    Dim bases(4) As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        '------- COMM Config ----------
        commLoadValues()
        cboPort.SelectedIndex = 0
        ' CommSetDefaults()
        '------------------------

        bases(1) = "A"
        bases(2) = "B"
        bases(3) = "C"

        Dim a As New OleDbCommand
        Dim m As OleDbDataReader
        Dim i As Integer
        cnn.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=c:\despenser\allomani.mdb;"


        '   Try
        cnn.Open()



        a.Connection = cnn
        a.CommandText = "select * from colors_types"
        m = a.ExecuteReader()

        While m.Read()

            list1.Items.Add(m!Code)


        End While
        list1.SelectedIndex = 0
        '----------- Load Companies ---------------------
        a = New OleDbCommand
        a.Connection = cnn
        a.CommandText = "select * from companies"
        m = a.ExecuteReader()


        While m.Read()

            list2.Items.Add(m!Code)
        End While
        list2.SelectedIndex = 0
        '----------- Load Colors ---------------------



        a = New OleDbCommand
        a.Connection = cnn
        a.CommandText = "select * from components"
        m = a.ExecuteReader()
        ReDim colors_types(m.FieldCount + 10)

        While m.Read()
            i = m!ID
            colors_types(i) = m!Code & " : " & m!Description
            ' colors_types.SetValue(m!Code & " : " & m!Description, i)
        End While

        quant.SelectedIndex = 0

        '  cnn.Close()
        '     Catch ex As Exception
        '         MsgBox("Can not open connection ! " + ex.ToString)
        '    End Try

    End Sub




    Private Sub grid3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid3.CellContentClick
        Dim x As Array
        Dim m As Integer
        Dim n As String = 0
        Dim color_ltrs As Double



        If e.RowIndex >= 0 Then
            color_name_id.Text = grid3.Rows(e.RowIndex).Cells(1).Value
            base_name.Text = bases(grid3.Rows(e.RowIndex).Cells(3).Value)
            quant_txt.Text = quant.Text & " Ltr."
            color_type_txt.Text = list1.Text
            grid4.RowCount = 0
            txtSend.Text = ""
            x = Split(grid3.Rows(e.RowIndex).Cells(2).Value, ";")
            For i = 0 To x.Length - 1
                If m = 0 Then
                    n = x(i)
                    m = 1
                Else

                    color_ltrs = ((quant.Text * 1000) / grid3.Rows(e.RowIndex).Cells(4).Value) * x(i)
                    color_ltrs = FormatNumber(color_ltrs, 3)
                    '   color_ltrs = String.Format("##.###", color_ltrs)

                    grid4.RowCount += 1
                    grid4.Rows(grid4.RowCount - 1).Cells(0).Value = n
                    grid4.Rows(grid4.RowCount - 1).Cells(1).Value = colors_types(n)
                    grid4.Rows(grid4.RowCount - 1).Cells(2).Value = color_ltrs & " Ltr"
                    '  MessageBox.Show(Len(color_ltrs))
                    txtSend.Text &= IIf(Len(n) < 2, "0" & n, n) & ":" & Format(color_ltrs, "00.000") & ";"
                    ' & IIf(Len(color_ltrs) < 6, "0" & color_ltrs, color_ltrs) & ";"
                  

                    m = 0
                End If


            Next
            txtSend.Text &= "A"
        End If
    End Sub


    Private Sub list2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list2.SelectedIndexChanged
        company_id.Text = list2.SelectedIndex + 1
    End Sub

    Private Sub gtclrsbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gtclrsbtn.Click
        '  Dim a As New OleDbCommand
        '  Dim m As OleDbDataReader


        cnn = New OleDbConnection
        cnn.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=c:\despenser\DB\SF" & color_type_id.Text & "\SF" & company_id.Text & "\Formulas.mdb;"
        cnn.Open()

        'where company='" & company_id.Text & "' and color='" & color_type_id.Text & "'"
        '  a.Connection = cnn
        '  a.CommandText = "select * from colors where company like '" & company_id.Text & "' and color_type like '" & color_type_id.Text & "'"
        ' a.CommandText = "select * from colors"
        da = New OleDbDataAdapter("select ID,Key1 as Name,Formula,Base_ID,Base_Quantity from Formulas", cnn)
        ds = New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            grid3.DataSource = ds.Tables(0)
            grid3.Columns(2).Visible = False
            grid3.Columns(3).Visible = False
            grid3.Columns(4).Visible = False


            ' End While
            grid3.Columns(0).Width = 50
            grid3.Columns(1).Width = 137

        Else
            MessageBox.Show("No Match Found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If
    End Sub
    Private Sub get_grid_data()

        '   da = New OleDbDataAdapter("select ID,Key1 as Name,Formula,Base_ID,Base_Quantity from Formulas", cnn)

        ' da.SelectCommand = a.ExecuteScalar


        ' m = a.ExecuteReader()


        '  grid3.RowCount = 0
        '  Dim i As Integer = 0
        '  grid3.RowCount = ds.Tables(0).Rows.Count
        '    For i = 0 To (ds.Tables(0).Rows.Count - 1)
        ' While m.Read()
        'grid3.RowCount += 1
        ' grid3.Rows(i).Cells(0).Value = m!ID
        '  grid3.Rows(i).Cells(0).Value = i
        '   grid3.Rows(i).Cells(0).Value = ds.Tables(0).Rows(i).Item("ID")
        '   grid3.Rows(i).Cells(1).Value = bases(ds.Tables(0).Rows(i).Item("Base_ID"))

        '   grid3.Rows(i).Cells(2).Value = ds.Tables(0).Rows(i).Item("Key1")
        '  grid3.Rows(i).Cells(3).Value = ds.Tables(0).Rows(i).Item("Formula")

        '   TextBox1.Text += vbNewLine + m!name

        '  Application.DoEvents()
        '    Next i


    End Sub
    Private Sub list1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list1.SelectedIndexChanged
        color_type_id.Text = list1.SelectedIndex + 1
    End Sub



    Private Sub commLoadValues()
        cboPort.Items.Clear()

        comm.SetPortNameValues(cboPort)
        cboPort.SelectedIndex = 0
        '  comm.SetParityValues(cboParity)
        '  comm.SetStopBitValues(cboStop)
    End Sub



    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        comm.ClosePort()
        ' CommSetDefaults()

        rdoText.Checked = True
        cmdSend.Enabled = False
        cmdClose.Enabled = False
        cmdOpen.Enabled = True
        commLoadValues()
    End Sub

    Private Sub cmdOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpen.Click
        comm.Parity = "None"
        comm.StopBits = "One"
        comm.DataBits = "8"
        comm.BaudRate = "1200"
        comm.DisplayWindow = rtbDisplay
        comm.PortName = cboPort.Text()
        comm.OpenPort()

        cmdOpen.Enabled = False
        cmdClose.Enabled = True
        cmdSend.Enabled = True
    End Sub

    Private Sub cmdSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSend.Click
        ' For i = 0 To 1000
        comm.Message = txtSend.Text
        comm.Type = CommManager.MessageType.Normal
        comm.WriteData(txtSend.Text & Chr(13))
        txtSend.Text = String.Empty
        txtSend.Focus()
        '  next 
    End Sub

    Private Sub rdoHex_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoHex.CheckedChanged
        If rdoHex.Checked() Then

            comm.CurrentTransmissionType = CommManager.TransmissionType.Hex
        Else
            comm.CurrentTransmissionType = CommManager.TransmissionType.Text
        End If
    End Sub



    Private Sub cboPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPort.SelectedIndexChanged
        comm.PortName = cboPort.Text()
    End Sub


    Private Sub search_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search_btn.Click
        Dim no_match As Boolean
        Dim m As Integer

        If Len(search_txt.Text) >= 4 Then
            no_match = True
            '    For m = 1 To 11
            m = 1
            cnn = New OleDbConnection
            cnn.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=c:\despenser\DB\SF" & color_type_id.Text & "\SF" & m & "\Formulas.mdb;"
            cnn.Open()

            'where company='" & company_id.Text & "' and color='" & color_type_id.Text & "'"
            '  a.Connection = cnn
            '  a.CommandText = "select * from colors where company like '" & company_id.Text & "' and color_type like '" & color_type_id.Text & "'"
            ' a.CommandText = "select * from colors"
            da = New OleDbDataAdapter("select ID,Key1 as Name,Formula,Base_ID,Base_Quantity from Formulas where Key1 like '%" & search_txt.Text & "%'", cnn)
            ds = New DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                grid3.DataSource = ds.Tables(0)
                grid3.Columns(2).Visible = False
                grid3.Columns(3).Visible = False
                grid3.Columns(4).Visible = False

                no_match = False
                '    Exit For
                ' End While

            End If


            '     Next m

            If no_match = True Then
                MessageBox.Show("No Match Found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("Please Type 4 Or More Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'grid4.AutoSize = false
        grid4.Size = New Size(Me.Width - 292, 148)
        grid3.Size = New Size(248, Me.Height - 188)
        PictureBox1.Size = New Size(Me.Width - 664, Me.Height - 337)

        grid4.Columns(1).Width = Me.Width - 450

    End Sub

    Private Sub grid4_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid4.CellContentClick

    End Sub
End Class
