Imports System.Text.RegularExpressions

Public Module ValidationConstants
    Public ReadOnly REGEX_CEDULA As New Regex("^\d{3}-\d{6}-\d{4}[A-Z]$")
End Module
