
Imports System.IO
Imports System.Text
Imports System.Net.Sockets
Imports System.Net
Imports System.Web.Script.Serialization


Module RazerChroma

    Public BaseURI

    Public Function init()

        Dim Title = """title"":""SWTOR in fight"","
        Dim Description = """description"":""Display SWTOR fight status in Razer linkes devices"","
        Dim Author = """author"":{""name"":""tas2580"",""contact"":""https://tas2580.net""},"
        Dim Device = """device_supported"":[""chromalink"",""mousepad"", ""mouse"", ""keyboard"", ""keypad""],"
        Dim Category = """category"":""application"""

        Dim session = SDKRequest("http://localhost:54235/razer/chromasdk", "{" + Title + Description + Author + Device + Category + "}", "POST")
        BaseURI = session("uri")


        System.Threading.Thread.Sleep(2000)
        SetKeybord()
        System.Threading.Thread.Sleep(1000)
        SetKeypad()

        Return BaseURI
    End Function



    Public Function SetKeypad()

        Dim color1 As String = RGB(CStr(My.Settings.RazerKeypadColor1.R), CStr(My.Settings.RazerKeypadColor1.G), CStr(My.Settings.RazerKeypadColor1.B))
        Dim color2 As String = RGB(CStr(My.Settings.RazerKeypadColor2.R), CStr(My.Settings.RazerKeypadColor2.G), CStr(My.Settings.RazerKeypadColor2.B))
        Dim color3 As String = RGB(CStr(My.Settings.RazerKeypadColor3.R), CStr(My.Settings.RazerKeypadColor3.G), CStr(My.Settings.RazerKeypadColor3.B))
        Dim color4 As String = RGB(CStr(My.Settings.RazerKeypadColor4.R), CStr(My.Settings.RazerKeypadColor4.G), CStr(My.Settings.RazerKeypadColor4.B))
        Dim color5 As String = RGB(CStr(My.Settings.RazerKeypadColor5.R), CStr(My.Settings.RazerKeypadColor5.G), CStr(My.Settings.RazerKeypadColor5.B))

        Dim color6 As String = RGB(CStr(My.Settings.RazerKeypadColor6.R), CStr(My.Settings.RazerKeypadColor6.G), CStr(My.Settings.RazerKeypadColor6.B))
        Dim color7 As String = RGB(CStr(My.Settings.RazerKeypadColor7.R), CStr(My.Settings.RazerKeypadColor7.G), CStr(My.Settings.RazerKeypadColor7.B))
        Dim color8 As String = RGB(CStr(My.Settings.RazerKeypadColor8.R), CStr(My.Settings.RazerKeypadColor8.G), CStr(My.Settings.RazerKeypadColor8.B))
        Dim color9 As String = RGB(CStr(My.Settings.RazerKeypadColor9.R), CStr(My.Settings.RazerKeypadColor9.G), CStr(My.Settings.RazerKeypadColor9.B))
        Dim color10 As String = RGB(CStr(My.Settings.RazerKeypadColor10.R), CStr(My.Settings.RazerKeypadColor10.G), CStr(My.Settings.RazerKeypadColor10.B))

        Dim color11 As String = RGB(CStr(My.Settings.RazerKeypadColor11.R), CStr(My.Settings.RazerKeypadColor11.G), CStr(My.Settings.RazerKeypadColor11.B))
        Dim color12 As String = RGB(CStr(My.Settings.RazerKeypadColor12.R), CStr(My.Settings.RazerKeypadColor12.G), CStr(My.Settings.RazerKeypadColor12.B))
        Dim color13 As String = RGB(CStr(My.Settings.RazerKeypadColor13.R), CStr(My.Settings.RazerKeypadColor13.G), CStr(My.Settings.RazerKeypadColor13.B))
        Dim color14 As String = RGB(CStr(My.Settings.RazerKeypadColor14.R), CStr(My.Settings.RazerKeypadColor14.G), CStr(My.Settings.RazerKeypadColor14.B))
        Dim color15 As String = RGB(CStr(My.Settings.RazerKeypadColor15.R), CStr(My.Settings.RazerKeypadColor15.G), CStr(My.Settings.RazerKeypadColor15.B))

        Dim color16 As String = RGB(CStr(My.Settings.RazerKeypadColor16.R), CStr(My.Settings.RazerKeypadColor16.G), CStr(My.Settings.RazerKeypadColor16.B))
        Dim color17 As String = RGB(CStr(My.Settings.RazerKeypadColor17.R), CStr(My.Settings.RazerKeypadColor17.G), CStr(My.Settings.RazerKeypadColor17.B))
        Dim color18 As String = RGB(CStr(My.Settings.RazerKeypadColor18.R), CStr(My.Settings.RazerKeypadColor18.G), CStr(My.Settings.RazerKeypadColor18.B))
        Dim color19 As String = RGB(CStr(My.Settings.RazerKeypadColor19.R), CStr(My.Settings.RazerKeypadColor19.G), CStr(My.Settings.RazerKeypadColor19.B))
        Dim color20 As String = RGB(CStr(My.Settings.RazerKeypadColor20.R), CStr(My.Settings.RazerKeypadColor20.G), CStr(My.Settings.RazerKeypadColor20.B))

        Dim data = "{""effect"":""CHROMA_CUSTOM"",""param"":[
            [" + color1 + "," + color2 + "," + color3 + "," + color4 + "," + color5 + "],
            [" + color6 + "," + color7 + "," + color8 + "," + color9 + "," + color10 + "],
            [" + color11 + "," + color12 + "," + color13 + "," + color14 + "," + color15 + "],
            [" + color16 + "," + color17 + "," + color18 + "," + color19 + "," + color20 + "]
        ]}"
        SDKRequest(RazerChroma.BaseURI + "/keypad", data, "PUT")
    End Function


    Public Function SetKeybord()
        Dim Data = "{""effect"":""CHROMA_CUSTOM"",""param"":[
            [ 0,255,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 ],
            [ 0,0,65535,65535,65535,65535,65535,65535,65535,65535,65535,65535,65535,65535,0,0,0,0,0,0,0,0 ],
            [ 0,16711935,0,16711680,0,0,16776960,0,16776960,16776960,16776960,16776960,0,0,0,0,0,0,0,0,0,0 ],
            [ 0,0,16711680,16711680,16711680,0,16776960,0,16776960,16776960,16776960,0,0,0,0,0,0,0,0,0,0,0 ],
            [ 0,16711935,0,65535,65535,16776960,0,16776960,16776960,16776960,0,0,0,0,0,0,16711680,0,0,0,0,0 ],
            [ 0,16711935,0,0,65535,65535,65535,65535,65535,65535,65535,0,0,0,0,16711680,16711680,16711680,0,0,0,0 ]
        ]}"
        SDKRequest(RazerChroma.BaseURI + "/keyboard", Data, "PUT")
    End Function

    Public Function SetColor(Color)
        Dim ColorArray() As String = Split(Color, ",")
        Dim Value As String = RGB(ColorArray(0), ColorArray(1), ColorArray(2))

        If My.Settings.RazerChromaMouse Then
            SDKRequest(RazerChroma.BaseURI + "/mouse", "{""effect"":""CHROMA_STATIC"", ""param"": {""color"": " + Value + " }}", "PUT")
        End If

        If My.Settings.RazerChromaMousepad Then
            SDKRequest(RazerChroma.BaseURI + "/mousepad", "{""effect"":""CHROMA_STATIC"", ""param"": {""color"": " + Value + " }}", "PUT")
        End If

        If My.Settings.RazerChromaLink Then
            SDKRequest(RazerChroma.BaseURI + "/chromalink", "{""effect"":""CHROMA_STATIC"", ""param"": {""color"": " + Value + " }}", "PUT")
        End If

        If My.Settings.RazerChromaHeadset Then
            SDKRequest(RazerChroma.BaseURI + "/headset", "{""effect"":""CHROMA_STATIC"", ""param"": {""color"": " + Value + " }}", "PUT")
        End If

    End Function

    Public Function TurnOff()
        SDKRequest(RazerChroma.BaseURI + "/chromalink", "{""effect"":""CHROMA_NONE""}", "PUT")
        SDKRequest(RazerChroma.BaseURI + "/keyboard", "{""effect"":""CHROMA_NONE""}", "PUT")
        SDKRequest(RazerChroma.BaseURI + "/keypad", "{""effect"":""CHROMA_NONE""}", "PUT")
        SDKRequest(RazerChroma.BaseURI + "/mousepad", "{""effect"":""CHROMA_NONE""}", "PUT")
        SDKRequest(RazerChroma.BaseURI + "/mouse", "{""effect"":""CHROMA_NONE""}", "PUT")
        SDKRequest(RazerChroma.BaseURI + "/headset", "{""effect"":""CHROMA_NONE""}", "PUT")
    End Function

    Public Function HeartBeat()
        SDKRequest(RazerChroma.BaseURI + "/heartbeat", "{}", "PUT")
    End Function

    Public Function SDKRequest(Uri, Data, Method)
        Dim Request As HttpWebRequest = CType(WebRequest.Create(Uri), HttpWebRequest)
        Request.Method = Method
        Request.ContentType = "application/json"

        Dim byteArray() As Byte = Encoding.UTF8.GetBytes(Data)
        Request.ContentLength = byteArray.Length
        Dim DataStream As Stream = Request.GetRequestStream()
        DataStream.Write(byteArray, 0, byteArray.Length)
        DataStream.Close()

        Dim Response As HttpWebResponse = Request.GetResponse()
        DataStream = Response.GetResponseStream()
        Dim reader As New StreamReader(DataStream)
        Dim ServerResponse As String = reader.ReadToEnd()
        reader.Close()
        DataStream.Close()
        Response.Close()

        Dim j As JavaScriptSerializer = New JavaScriptSerializer()
        Dim json As Object = j.Deserialize(ServerResponse, GetType(Object))

        Return json
    End Function
End Module
