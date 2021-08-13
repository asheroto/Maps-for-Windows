Imports Microsoft.Win32

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim appString = """" & Application.StartupPath & "\MapsForWindows.exe" & """"
            Registry.CurrentUser.OpenSubKey("Software\Classes", True).CreateSubKey("maps")
            Dim x As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Classes\maps", True)
            x.SetValue("", "Maps for Windows")
            x.SetValue("URL Protocol", "")
            x.CreateSubKey("DefaultIcon")
            x.OpenSubKey("DefaultIcon", True).SetValue("", appString & ",1")
            x.CreateSubKey("shell")
            x.OpenSubKey("shell", True).SetValue("", "open")
            x.OpenSubKey("shell", True).CreateSubKey("open")
            x.OpenSubKey("shell", True).OpenSubKey("open", True).CreateSubKey("command")
            Dim zCommand As String = appString & " " & """" & "%1" & """"
            x.OpenSubKey("shell", True).OpenSubKey("open", True).OpenSubKey("command", True).SetValue("", zCommand)

            Dim appString2 = """" & Application.StartupPath & "\MapsForWindows.exe" & """"
            Registry.CurrentUser.OpenSubKey("Software\Classes", True).CreateSubKey("geo")
            Dim y As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Classes\geo", True)
            y.SetValue("", "Maps for Windows")
            y.SetValue("URL Protocol", "")
            y.CreateSubKey("DefaultIcon")
            y.OpenSubKey("DefaultIcon", True).SetValue("", appString2 & ",1")
            y.CreateSubKey("shell")
            y.OpenSubKey("shell", True).SetValue("", "open")
            y.OpenSubKey("shell", True).CreateSubKey("open")
            y.OpenSubKey("shell", True).OpenSubKey("open", True).CreateSubKey("command")
            Dim zCommand2 As String = appString2 & " " & """" & "%1" & """"
            y.OpenSubKey("shell", True).OpenSubKey("open", True).OpenSubKey("command", True).SetValue("", zCommand2)

            MsgBox("Maps for Windows is now the default Maps/Geo handler. Clicking a link that starts with ""maps:"" or ""geo:"" will launch Maps for Windows now.", vbInformation, "Maps for Windows", vbInformation)

        Catch ex As Exception
            MsgBox("There was an error setting the Maps handler. If you clicked ""No"" on the User Account Control prompt, please click ""Yes"" to give permission to set the Maps handler." + vbNewLine + vbNewLine + ex.Message, vbExclamation, "Maps for Windows", vbInformation)
        End Try
        End
    End Sub
End Class
