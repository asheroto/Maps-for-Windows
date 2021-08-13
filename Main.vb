Imports Microsoft.Win32

Public Class Main

    Public Function HaveInternetConnection() As Boolean
        Try
            Return My.Computer.Network.Ping("maps.google.com")
        Catch
            Return False
        End Try
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Configures compatibility mode
        'https://blogs.msdn.microsoft.com/patricka/2015/01/12/controlling-webbrowser-control-compatibility/
        Try
            Dim x As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", True)
            x.SetValue("MapsForWindows.exe", 10001, RegistryValueKind.DWord)
        Catch ex As Exception

        End Try

        If HaveInternetConnection() = False Then
            MsgBox("An Internet connection was not detected. Please reconnect to the Internet and launch Maps for Windows again.", vbInformation)
            End
        End If

        Try
            'Get command line arguments
            Dim args() As String = Environment.GetCommandLineArgs()
            Dim query = Nothing
            If args.Count >= 2 Then
                query = args(1)

                'If the app is called with the map: prefix, remove it from the query
                Dim queryArg As String = LCase(Mid(query, 1, 4))
                If queryArg = "map:" Or queryArg = "geo:" Then
                    query = Mid(query, 5)
                End If
            End If

            'Navigate web browser
            maps.Navigate("https://maps.google.com/?q=" + query)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenInBrowser_Click(sender As Object, e As EventArgs) Handles OpenInBrowser.Click
        Try
            Process.Start(maps.Url.AbsoluteUri)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetAsDefaultMapsHandler_Click(sender As Object, e As EventArgs) Handles SetAsDefaultMapsHandler.Click
        Try
            Process.Start(Application.StartupPath & "\SetMapProtocolHandler.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        Try
            Process.Start("https://asher.tools/maps-for-windows")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReportABug_Click(sender As Object, e As EventArgs) Handles ReportABug.Click
        Try
            MsgBox("Hello!" + vbNewLine + vbNewLine + "If you are experiencing an issue with Maps for Windows, please email us at mapsforwindows@asher.tools" + vbNewLine + vbNewLine + "Thank you!", vbInformation, "Maps for Windows")
        Catch ex As Exception

        End Try
    End Sub

End Class