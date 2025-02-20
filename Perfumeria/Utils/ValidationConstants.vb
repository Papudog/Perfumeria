Imports System.Text.RegularExpressions

Public Module ValidationConstants
    Public ReadOnly Property REGEX_CEDULA As Regex = New Regex("^\d{3}-\d{6}-\d{4}[A-Z]$")
End Module
