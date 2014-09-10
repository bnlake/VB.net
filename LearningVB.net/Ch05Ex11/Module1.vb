#Region "Initialization"
Option Strict On
Option Explicit On

Imports System
#End Region

#Region "Creation Info"
'Author: Brian Lake
'Date Created: 30AUG14
'Contact: bnlake@gmail.com
'Description: Using the ByVal and ByRef parameters
#End Region

Public Class Tester

	Public Sub Run()
		Dim theVar As Integer = 5
		Console.WriteLine("In Run. theVar: {0}", theVar)

		Doubler(theVar)
		Console.WriteLine("Back in Run. theVar: {0}", theVar)
	End Sub

	Public Sub Doubler(ByRef param As Integer)
		Console.WriteLine("In Method1. Received param: {0}", param)

		param *= 2

		Console.WriteLine("Updated param. Returning new value: {0}", param)
	End Sub

End Class 'Tester

Module Module1

	Sub Main()
		Dim t As New Tester
		t.Run()

		Console.ReadKey()	'Used to prevent console from automatically closing 
	End Sub

End Module
