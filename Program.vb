﻿Imports Desharp

Module Program

    Sub Main()

        Program._demoDumpAndLog()
        Program._demoException()
        'Program._runTests()

        Console.ReadLine()
    End Sub

    Private Sub _demoDumpAndLog()
        Console.Write("Press enter key to dump demo data and write it to HDD.")
        Console.ReadLine()
        Console.WriteLine()

        Dim demoObject = New Dictionary(Of String, Object)() From {
            {"clark", New With {
                .name = "Clark",
                .surname = "Kent",
                .tshirtIdol = "chuck"
            }},
            {"chuck", New With {
                .name = "Chuck",
                .surname = "Noris",
                .tshirtIdol = "bud"
            }},
            {"bud", New With {
                .name = "Bud",
                .surname = "Spencer",
                .tshirtIdol = ""
            }}
        }
        Debug.Dump(demoObject)
        Debug.Log(demoObject)

        Console.WriteLine()
        Console.WriteLine()
    End Sub

    Private Sub _demoException()
        Console.Write("Press enter key to dump catched demo exception and write it to HDD.")
        Console.ReadLine()
        Console.WriteLine()

        Try
            Throw New Exception("Demo exception:-)")
        Catch ex As Exception
            Debug.Dump(ex)
            Debug.Log(ex)
        End Try

        Console.WriteLine()
    End Sub

    Private Sub _runTests()
        Console.Write("Pres enter key to start duping test objects.")
        Console.ReadLine()
        Console.WriteLine()

		Dim dlTest = New Desharp.Tests.DumpingAndLoging()
		dlTest.TestAll()

		Dim eTest = New Desharp.Tests.ExceptionsRendering()
		eTest.TestAll()
    End Sub

End Module
