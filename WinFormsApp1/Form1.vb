Imports System.IO
Imports System.Windows.Forms.AxHost

Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Columns(0).HeaderText = ("Name")
        DataGridView1.Columns(1).HeaderText = ("ID Number")
        DataGridView1.Columns(2).HeaderText = ("State")
        DataGridView1.Columns(3).HeaderText = ("Country")
        DataGridView1.Columns(4).HeaderText = ("Flight Stops")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vals() As String
        Dim lines() As String = IO.File.ReadAllLines("C:\Users\karac\source\repos\WinFormsApp1\TTM.txt")
        Dim k As Integer = lines.Count()
        Dim idata As List(Of CxEyeAlarmMessage) = New List(Of CxEyeAlarmMessage)
        For z As Integer = 0 To lines.Length - 1 Step +1
            vals = lines(z).ToString().Split(",")
            Dim row(vals.Length - 1) As String
            For j As Integer = 0 To vals.Length - 1 Step +1
                row(j) = vals(j).Trim()
            Next j
            DataGridView1.Rows.Add(row)
        Next z
    End Sub
End Class
