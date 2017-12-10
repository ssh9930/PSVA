Public Class Sstring   'secure string

    Private sstr As String

    Sub New(str_ As String)
        sstr = Convert.ToBase64String(Text.Encoding.Unicode.GetBytes(Convert.ToBase64String(Text.Encoding.Unicode.GetBytes(str_)))).Replace("=", Chr(0))
    End Sub

    Public Overrides Function ToString() As String
        Return sstr
    End Function

    Public Function DecodedString() As String
        Return Text.Encoding.Unicode.GetChars(Convert.FromBase64String(Text.Encoding.Unicode.GetChars((Convert.FromBase64String(sstr.Replace(Chr(0), "="))))))
    End Function

    Shared Function DecodeString(str As String) As String
        Return Text.Encoding.Unicode.GetChars(Convert.FromBase64String(Text.Encoding.Unicode.GetChars((Convert.FromBase64String(str.ToString.Replace(Chr(0), "="))))))
    End Function

    Shared Function EncodeString(str As String) As Sstring
        Return New Sstring(str)
    End Function



End Class
