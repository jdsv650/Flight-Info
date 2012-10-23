Public Class FlightDetails
    Implements IComparable(Of FlightDetails)

    Public Property depart_station As String
    Public Property depart_time As DateTime
    Public Property arrive_station As String
    Public Property arrive_time As DateTime
    Public Property price As Double
    Public Property airline_company As String
    Public Property flight_no As String

    Public Sub New(d_sta As String, d_time As DateTime, a_sta As String, a_time As DateTime, price As Double, comp As String, flight_no As String)
        depart_station = d_sta
        depart_time = d_time
        arrive_station = a_sta
        arrive_time = a_time
        Me.price = price
        airline_company = comp
        Me.flight_no = flight_no
    End Sub

    Public Function CompareTo(other As FlightDetails) As Integer Implements System.IComparable(Of FlightDetails).CompareTo
        If airline_company = other.airline_company Then
            Return 0
        Else
            If airline_company < other.airline_company Then
                Return -1
            Else
                Return 1
            End If
        End If
    End Function
End Class
