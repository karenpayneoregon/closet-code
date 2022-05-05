Imports System.ComponentModel.DataAnnotations

Public Module SimpleValidator
    ''' <summary>
    ''' Validate the model and return a response, which includes any validation messages and an IsValid bit.
    ''' </summary>
    Public Function Validate(model As Object) As ValidationResponse
        Dim results = New List(Of ValidationResult)()
        Dim context = New ValidationContext(model)

        Dim isValid = Validator.TryValidateObject(model, context, results, True)

        Return New ValidationResponse() With {
            .IsValid = isValid,
            .Results = results
            }
    End Function

    ''' <summary>
    ''' Validate the model and return a bit indicating whether the model is valid or not.
    ''' </summary>
    Public Function IsModelValid(model As Object) As Boolean
        Dim response = Validate(model)

        Return response.IsValid
    End Function
End Module