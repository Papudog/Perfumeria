﻿Module ErrorConstants
    ' Keys
    Public Const IS_EMPTY As String = "isEmpty"
    Public Const INVALID_CEDULA As String = "invalidCedula"
    Public Const MIN_PRICE As String = "minPrice"
    Public Const MIN_PRODUCTOS As String = "minProductos"

    ' Values
    Public Const IS_EMPTY_MESSAGE As String = "El campo no puede estar vacío"
    Public Const INVALID_CEDULA_MESSAGE As String = "Formato de cédula inválido"
    Public Const MIN_PRICE_MESSAGE As String = "El precio no puede ser 0"
    Public Const MIN_PRODUCTOS_MESSAGE As String = "Debe haber al menos un producto en la canasta"
End Module
