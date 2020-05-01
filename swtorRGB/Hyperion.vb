
Imports System.IO
Imports System.Text
Imports System.Net.Sockets
Imports System.Net
Imports System.Web.Script.Serialization

Module Hyperion

    Dim serverStream As NetworkStream

    Public Function SetColor(color)
        Dim clientSocket As New System.Net.Sockets.TcpClient()
        clientSocket.Connect(My.Settings.HyperionIP, CInt(My.Settings.HyperionPort))
        serverStream = clientSocket.GetStream()

        Dim com = "{""command"":""color"",""color" + Chr(34) + ":[" + color + "],""priority"":" + CStr(My.Settings.HyperionPriority) + "}" + vbCrLf
        Dim outStream As Byte() = System.Text.Encoding.UTF8.GetBytes(com)
        serverStream.Write(outStream, 0, outStream.Length)

        clientSocket.Close()
        serverStream.Close()
        Return True
    End Function


    Public Function TurnOff()
        Dim clientSocket As New System.Net.Sockets.TcpClient()
        clientSocket.Connect(My.Settings.HyperionIP, CInt(My.Settings.HyperionPort))
        serverStream = clientSocket.GetStream()

        Dim com = "{""command"":""clear"",""priority"":" + CStr(My.Settings.HyperionPriority) + "}" + vbCrLf
        Dim outStream As Byte() = System.Text.Encoding.UTF8.GetBytes(com)
        serverStream.Write(outStream, 0, outStream.Length)

        clientSocket.Close()
        serverStream.Close()
        Return True
    End Function


End Module
