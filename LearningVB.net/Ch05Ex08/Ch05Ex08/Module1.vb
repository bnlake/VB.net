#Region "Initialization"
Option Strict On
Option Explicit On

Imports System
#End Region

#Region "Creation Info"
'Author: Brian Lake
'Date Created: 28AUG14
'Contact: bnlake@gmail.com
'Description: Shared Fields
#End Region

Module Module1
	Class Cat
		'------------ METHOD INFORMATION ------------'
		' All methods and variables in a class do not exist until
		' the class is instantiated. At that point the class always
		' exists until the program has been terminated.
		'--------------------------------------------'

		Private Shared instances As Integer = 0	'Since the class exists forever, this class variable will forever exist
		Private weight As Integer
		Private name As String

		Public Sub New(ByVal name As String, ByVal weight As Integer)
			'------------ METHOD INFORMATION ------------'
			''"New" as the method name is a special name. Runs when a Cat class is instantiated
			'--------------------------------------------'

			instances += 1	'Increases the class level variable as to be a counter everytime this method is executed.
			Me.name = name
			Me.weight = weight
		End Sub

		Public Shared Sub HowManyCats()
			'------------ METHOD INFORMATION ------------'
			' Extremely basic but effective method to return class level information
			' (1+ objects of said class)
			'--------------------------------------------'

			Console.WriteLine("{0} cats adopted", instances)
		End Sub

		Public Sub TellInfo()
			Console.WriteLine("{0} is {1} pounds", name, weight)
		End Sub

	End Class 'Cat


	Sub Main()
		Cat.HowManyCats()

		Dim frisky As New Cat("Frisky", 5)	'Utilizes the 'New' method when instantiated
		frisky.TellInfo()
		Cat.HowManyCats()

		Dim whiskers As New Cat("Whiskers", 7)
		whiskers.TellInfo()
		Cat.HowManyCats()

		Console.ReadKey()	'Used to prevent console from automatically closing
	End Sub

End Module
