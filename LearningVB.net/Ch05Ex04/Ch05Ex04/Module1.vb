Option Strict On
Option Explicit On

Imports System

Public Class TestClass
	Sub someMethod(ByVal firstParam As Integer, ByVal secondParam As Single)
		Console.WriteLine("Here are the parameters received: {0} {1}",firstParam,secondParam)
	End Sub
End Class

Module Module1

	Sub Main()
		Dim howManyPeople As Integer = 5
		Dim pi As Single = 3.14F

		Dim tc As New TestClass()
		tc.someMethod(howManyPeople, pi)
		Console.ReadKey()	'Used to prevent console from automatically closing
	End Sub

End Module
