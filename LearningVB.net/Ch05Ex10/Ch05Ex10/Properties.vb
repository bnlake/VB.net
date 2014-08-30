#Region "Initialization"
Option Strict On
Option Explicit On

Imports System
#End Region

#Region "Creation Info"
'Author: Brian Lake
'Date Created: 29AUG14
'Contact: bnlake@gmail.com
'Description: This example demonstrates the use of Properties. Properties seperate the client from the class.
'				Which allows the class to be updated and not break the client connection.
#End Region

Public Class time
	'Private variables. m prefix indicates they are used for this member only
	Private mYear As Integer, mMonth As Integer, mDay As Integer	'Date
	Private mHour As Integer, mMinute As Integer, mSecond As Integer	'Time

	Property Hour() As Integer
		'----------------- Declaring a propery this way allows the set, get and let to be established all in one property -----------------' 
		Get
			Return mHour
		End Get
		Set(value As Integer)
			mHour = value
		End Set
	End Property

	'----------------- Accessor Methods -----------------' 
	Public Sub DisplayCurrentTime()
		Console.WriteLine("{0}/{1}/{2} {3}:{4}:{5}", mMonth, mDay, mYear, mHour, mMinute, mSecond)
	End Sub

	'----------------- Constructor Methods -----------------' 
	Public Sub New(ByVal dt As DateTime)
		mYear = dt.Year
		mMonth = dt.Month
		mDay = dt.Day
		mHour = dt.Hour
		mMinute = dt.Minute
		mSecond = dt.Second
	End Sub

	Public Sub New( _
				  ByVal mYear As Integer, _
				  ByVal mMonth As Integer, _
				  ByVal mDay As Integer, _
				  ByVal mHour As Integer, _
				  ByVal mMinute As Integer, _
				  ByVal mSecond As Integer)
		'Me.xxxxx is referring to the private variables established for the entire module.
		Me.mYear = mYear
		Me.mMonth = mMonth
		Me.mDay = mDay
		Me.mHour = mHour
		Me.mMinute = mMinute
		Me.mSecond = mSecond
	End Sub

End Class 'Time

Module Properties

	Sub Main()
		Dim currentTime As DateTime = DateTime.Now
		Dim time1 As New time(currentTime)
		time1.DisplayCurrentTime()

		Dim theHour As Integer = time1.Hour		'demonstrates the get property
		Console.WriteLine("Retrieved the hour: {0}", theHour)

		theHour += 1
		time1.Hour = theHour	'demonstrates the let property
		Console.WriteLine("Updated the hour to: {0}", time1.Hour)
		time1.DisplayCurrentTime()

		Console.ReadKey()	'Used to prevent console from automatically closing
	End Sub

End Module
