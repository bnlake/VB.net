Option Strict On
Option Explicit On

Imports System
'Author: Brian Lake
'Date Created: 28AUG14
'Contact: bnlake@gmail.com
'Description: First console app which teaches to use a class and instances of classes


Module Module1

	Public Class Dog
		Public weight As Integer
	End Class

	Public Class Tester

		Public Shared Sub Main()
			Dim testObject As New Tester()
			testObject.Run()
			Console.ReadKey()	'Used to prevent console from automatically closing
		End Sub


		Public Sub Run()
			Dim firstInt As Integer = 5	'Create an integer
			Dim secondInt As Integer = firstInt	'Create an integer by reference

			Console.WriteLine("firstInt: {0}, secondInt: {1}", firstInt, secondInt)

			secondInt = 7
			Console.WriteLine("firstInt: {0}, secondInt: {1}", firstInt, secondInt)

			Dim milo As New Dog		'Creates a new dog (This is using a reference)
			milo.weight = 5

			Dim fido As Dog = milo	'A new dog instance mirrored of previous dog
			Console.WriteLine("Milo: {0}, Fido: {1}", milo.weight, fido.weight)

			fido.weight = 23	'Since mirrored; milo gets a weight change also
			Console.WriteLine("Milo: {0}, Fido: {1}", milo.weight, fido.weight)
		End Sub

	End Class

End Module
