Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arguments As String() = System.Environment.GetCommandLineArgs()

        Dim filename = arguments(1).ToString

        Dim myFile As New FileInfo(filename)
        Dim sizeInBytes As Long = myFile.Length

        Dim actualsize = sizeInBytes

        Dim hexvalue = ""

        Dim str As String = "0" & Hex(actualsize)
        Dim parts(str.Length \ 2 - 1) As String
        For x As Integer = 0 To str.Length - 1 Step 2
            parts(x \ 2) = str.Substring(x, 2)
        Next

        hexvalue &= String.Join("", parts.Reverse)

        hexvalue &= "000000000000524D534B494E00"

        Dim hexstring = HexToString(hexvalue)
        AppendByteToDisk(filename, System.Text.Encoding.Default.GetBytes(hexstring))

        My.Computer.FileSystem.CopyFile(filename, filename.Replace(".zip", ".rmskin"), True)


        Me.Close()
        End


    End Sub

    Private Sub AppendByteToDisk(ByVal FilepathToAppendTo As String, ByRef Content() As Byte)
        Dim s As New System.IO.FileStream(FilepathToAppendTo, System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite)
        s.Write(Content, 0, Content.Length)
        s.Close()
    End Sub



    Function HexToString(ByVal hex As String) As String
        Dim text As New System.Text.StringBuilder(hex.Length \ 2)
        For i As Integer = 0 To hex.Length - 2 Step 2
            text.Append(Chr(Convert.ToByte(hex.Substring(i, 2), 16)))
        Next
        Return text.ToString
    End Function
End Class
