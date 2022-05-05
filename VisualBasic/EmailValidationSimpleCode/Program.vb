Imports System

Module Program
    ''' <summary>
    ''' Can email address have double dots?
    ''' https://quick-adviser.com/can-email-address-have-double-dots/
    ''' </summary>
    ''' <param name="args"></param>
    Sub Main(args As String())
        Console.Title = "Code sample - Email valid"
        Dim List As New List(Of String) From
                {
                "jack@gmail.com",
                "mary:comcast.net",
                "Mike@amazon.net",
                "Abc.example.com",
                "A@b@c@example.com",
                "ma...ma@jjf.co",
                "ma@@jjf.com",
                "@majjf.com",
                "ma.@jjf.com",
                "ma@hostname.comcom",
                "MA@hostname.coMCom"}

        For Each emailAddress As String In List
            Console.WriteLine($"{emailAddress,-20}{Annotations.ValidEmail(emailAddress)}")
        Next

        Dim example As New Example With {.EmailAddress = "mary:comcast.net"}
        Dim validationResult = SimpleValidator.IsModelValid(example)
        Console.WriteLine(validationResult)
        Console.ReadLine()
    End Sub
End Module