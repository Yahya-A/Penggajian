Imports System.Data.Odbc
Imports System.Text

Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Sub checkLogin(username, pass)
        Call Konek()
        CMD = New OdbcCommand("Select * from user where username = '" & username & "'", Conn)
        RD = CMD.ExecuteReader
        If RD.HasRows Then
            If Not GetHash(pass) = RD.Item("password") Then
                MsgBox("Password Salah!")
            Else
                My.Settings.Username = RD.Item("username")
                My.Settings.Name = RD.Item("name")
                My.Settings.isLogin = True
                My.Settings.Role = RD.Item("role")
                My.Settings.Save()
                My.Settings.Reload()
                Main.Show()
                Me.Close()

                MsgBox("Login Berhasil")
            End If
        Else
            MsgBox("Username salah!")
        End If
    End Sub

    Private Function GetHash(strToHash As String) As String

        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As New StringBuilder

        For Each b As Byte In bytesToHash
            strResult.Append(b.ToString("x2"))
        Next

        Return strResult.ToString

    End Function

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim username, pass As String
        username = txtusername.Text
        pass = txtpassword.Text
        checkLogin(username, pass)
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim isLogin As Boolean
        isLogin = My.Settings.isLogin
        If isLogin Then
            Main.Show()
            Me.Close()
        End If
    End Sub
End Class
