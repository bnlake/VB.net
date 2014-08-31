#Region "Initialization"
Option Strict On
Option Explicit On

Imports System
#End Region

Namespace PassingReference


	Public Class Cat
		'----------------- This property was established using code snippets. USE THEM!! -----------------' 
		Private mWeight As Integer

		'----------------- CONSTRUCTOR: allows you to instantiate an object with a parameter -----------------' 
		Public Sub New(ByVal weight As Integer)
			mWeight = weight
		End Sub

		'----------------- Public Properties -----------------' 
		Public Property Weight() As Integer
			Get
				Return mWeight
			End Get
			Set(ByVal value As Integer)
				mWeight = value
			End Set
		End Property

		'----------------- This function intercepts the request to print to string. Allows the class to define what it being output based on request -----------------' 
		Public Overrides Function ToString() As String
			Return mWeight.ToString()
		End Function

	End Class

	Public Class Tester

		Public Sub Run()
			'Decare a cat object and initialize it to 5
			Dim theVar As New Cat(5)

			Console.WriteLine("In Run. theVar: {0}", theVar)

			Doubler(theVar)

			Console.WriteLine("Back in Run. theVar: {0}", theVar)
		End Sub

		Public Sub Doubler(ByVal param As Cat)	'Accepts the parameter as a cat object. (Basically a ByRef but using a class instead)
			Console.WriteLine("In Method1. Received param: {0}", param)

			param.Weight *= 2

			Console.WriteLine("Updated param. Returning new value: {0}", param)
		End Sub
	End Class	'Tester

	Module PassingReference

		Sub Main()
			Dim t As New Tester
			t.Run()

			Console.ReadKey()	'Used to prevent console from automatically closing 
		End Sub

	End Module
End Namespace