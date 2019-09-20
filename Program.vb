Imports Desharp

Module Program

	Sub Main()

		Dim dlTest = New Tests.DumpingAndLoging()
		dlTest.TestAll()

		Dim eTest = New Tests.ExceptionsRendering()
		eTest.TestAll()

		Console.ReadLine()

	End Sub

End Module
