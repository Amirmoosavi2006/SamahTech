Imports System.Net
Imports System.Net.Sockets
Imports System.IO

Public Class Form1

    Private client As TcpClient
    Public STR As StreamReader
    Public STW As StreamWriter
    Public recieve As String
    Public TextToSend As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim localIP As IPAddress() = Dns.GetHostAddresses(Dns.GetHostName)
        For Each address As IPAddress In localIP
            If address.AddressFamily = AddressFamily.InterNetwork Then
                txt_sip.Text = address.ToString
            End If
        Next

    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click

        If (txt_sport.Text = "") Or (IsNumeric(txt_sport.Text)) = False Then
            MessageBox.Show("Port error!", caption:="ChatApp", vbOKOnly, MessageBoxIcon.Error)
            txt_sport.Focus()
            txt_sport.SelectAll()
            Exit Sub
        End If
        Dim listener As New TcpListener(IPAddress.Any, Integer.Parse(txt_sport.Text))
        Try
            listener.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
            Exit Sub
        End Try
        client = listener.AcceptTcpClient()
        STR = New StreamReader(client.GetStream())
        STW = New StreamWriter(client.GetStream()) With {.AutoFlush = True}
        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker2.WorkerSupportsCancellation = True
    End Sub

    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        client = New TcpClient()
        Dim IPEnd As New IPEndPoint(IPAddress.Parse(txt_cip.Text), Integer.Parse(txt_cport.Text))
        Try
            client.Connect(IPEnd)
            If (client.Connected) Then
                txt_chats.AppendText("Connected to server " + vbNewLine)
                STW = New StreamWriter(client.GetStream()) With {.AutoFlush = True}
                STR = New StreamReader(client.GetStream())
                BackgroundWorker1.RunWorkerAsync()
                BackgroundWorker2.WorkerSupportsCancellation = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        While (client.Connected)
            Try
                recieve = STR.ReadLine
                txt_chats.Invoke(New MethodInvoker(Function()
                                                       txt_chats.AppendText("You: " + recieve + vbNewLine)
                                                   End Function))
                recieve = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try
        End While
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        If (client.Connected) Then
            STW.WriteLine(TextToSend)
            txt_chats.Invoke(New MethodInvoker(Function()
                                                   txt_chats.AppendText("Me: " + TextToSend + vbNewLine)
                                               End Function))
        Else
            MessageBox.Show("Sending Failed!")
        End If
        BackgroundWorker2.CancelAsync()
    End Sub

    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        If (txt_msg.Text <> "") Then
            TextToSend = txt_msg.Text
            BackgroundWorker2.RunWorkerAsync()
        End If
        txt_msg.Clear()
    End Sub
End Class
