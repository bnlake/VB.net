#Region "Initialization"
Option Strict On
Option Explicit On

Imports System
#End Region

Public Class Time

	Private year As Integer
	Private month As Integer
	Private day As Integer
	Private hour As Integer
	Private minute As Integer
	Private second As Integer = 30	'Represents an iniitializer (Default value)


	'///////////////// Constructor (To accept input values instead of default values /////////////////'
	Public Sub New( _
				  ByVal theYear As Integer, _
				  ByVal theMonth As Integer, _
				  ByVal theDay As Integer, _
				  ByVal theHour As Integer, _
				  ByVal theMinute As Integer)
		year = theYear
		month = theMonth
		day = theDay
		hour = theHour
		minute = theMinute
	End Sub

	Public Sub New(ByVal dt As DateTime)
		'------------ METHOD INFORMATION ------------'
		' This method demonstrates 'overloading' of a method.
		' This provides quick, multiple ways of accessing variants of a method.
		'--------------------------------------------'
		year = dt.Year
		month = dt.Month
		day = dt.Day
		hour = dt.Hour
		minute = dt.Minute
		second = dt.Second

	End Sub

	'///////////////// Method to return class info /////////////////'
	Public Sub DisplayCurrentTime()
		Console.WriteLine("{0}/{1}/{2} {3}:{4}:{5}", month, day, year, hour, minute, second)
	End Sub
End Class

Module Module1

	Sub Main()
		Dim currentTime As DateTime = DateTime.Now	'Variable established to use system time automatically
		'----------------- Two time objects to demonstrate how overloaded methods are utilized -----------------'
		Dim time1 As New Time(currentTime)
		Dim time2 As New Time(2014, 9, 22, 9, 45)

		time1.DisplayCurrentTime()
		time2.DisplayCurrentTime()

		Console.ReadKey()	'Used to prevent console from automatically closing
	End Sub

End Module
