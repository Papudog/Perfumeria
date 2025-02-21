Module ErrorMessages
    Public ReadOnly ErrorDictionary As New Dictionary(Of String, String) From {
        {ErrorConstants.IS_EMPTY, ErrorConstants.IS_EMPTY_MESSAGE},
        {ErrorConstants.INVALID_CEDULA, ErrorConstants.INVALID_CEDULA_MESSAGE},
        {ErrorConstants.MIN_PRICE, ErrorConstants.MIN_PRICE_MESSAGE},
        {ErrorConstants.MIN_PRODUCTOS, ErrorConstants.MIN_PRODUCTOS_MESSAGE}
    }
End Module
