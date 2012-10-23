Public Class FlightInfoMainForm

    Public flights As New FlightList
    Public flightsFound As New FlightList
    Dim deptStation(4) As String
    Dim arriveStation(4) As String


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        flights.BuildList()  ' only call BuildList on ONE list opens workbook

        ' Add any initialization after the InitializeComponent() call.
        EarlyDateTimePicker.Format = DateTimePickerFormat.Custom
        EarlyDateTimePicker.CustomFormat = "hh:mm tt"
        LateDateTimePicker.Format = DateTimePickerFormat.Custom
        LateDateTimePicker.CustomFormat = "hh:mm tt"

        AddStations()

        DepartComboBox.DataSource = deptStation
        ArriveComboBox.DataSource = arriveStation

       
    End Sub

    Private Sub AddStations()
        deptStation(0) = "Atlanta, Georgia (ATL)"
        deptStation(1) = "Baltimore Washington Intl (BWI)"
        deptStation(2) = "Newark, NJ (EWR)"
        deptStation(3) = "Orlando, Florida (MCO)"

        arriveStation(0) = "Atlanta, Georgia (ATL)"
        arriveStation(1) = "Baltimore Washington Intl (BWI)"
        arriveStation(2) = "Newark, NJ (EWR)"
        arriveStation(3) = "Orlando, Florida (MCO)"
    End Sub


    Private Sub EarlyDateTimePicker_ValueChanged(sender As System.Object, e As System.EventArgs) Handles EarlyDateTimePicker.ValueChanged
    End Sub

    Private Sub LateDateTimePicker_ValueChanged(sender As System.Object, e As System.EventArgs) Handles LateDateTimePicker.ValueChanged
    End Sub

    Private Sub DepartComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles DepartComboBox.SelectedIndexChanged
    End Sub

    Private Sub ArriveComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ArriveComboBox.SelectedIndexChanged
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'find list of matching flights
        flightsFound.flightL.Clear()
        FlightInfoResultsForm.FlightChart.Series.Clear()
        FlightInfoResultsForm.FlightChart.ChartAreas(0).AxisY.CustomLabels.Clear()
        FlightInfoResultsForm.FlightChart.Legends.Clear()

        addFlightsFound()
        FlightInfoResultsForm.ShowDialog()
    End Sub

    Private Sub addFlightsFound()
        Dim selStringDept As String
        Dim flightStringDept As String
        Dim selStringArr As String
        Dim flightStringArr As String
        Dim d1 As DateTime = New DateTime

        flightsFound.flightL.Clear()

        selStringDept = deptStation(DepartComboBox.SelectedIndex).Replace(" ", "")
        selStringArr = arriveStation(ArriveComboBox.SelectedIndex).Replace(" ", "")
        ' MessageBox.Show("Selected string in combobox = " + selStringDept)

        For Each flight In flights.flightL
            flightStringDept = flight.depart_station.Replace(" ", "")
            flightStringArr = flight.arrive_station.Replace(" ", "")

            ' MessageBox.Show("time picker  = " + EarlyDateTimePicker.Value)
            ' MessageBox.Show("xlsx read time  = " + flight.depart_time)

            If String.Compare(selStringDept, flightStringDept) = 0 And
               String.Compare(selStringArr, flightStringArr) = 0 And
                 flight.depart_time.TimeOfDay > EarlyDateTimePicker.Value.TimeOfDay And
                 flight.depart_time.TimeOfDay <= LateDateTimePicker.Value.TimeOfDay Then

                flightsFound.flightL.Add(flight)
            End If

        Next
    End Sub



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' EarlyDateTimePicker.Value = "9:00:00 AM"
        'LateDateTimePicker.Value = "5:00:00 PM"

        EarlyDateTimePicker.Value = DateTime.Now

        LateDateTimePicker.Value = Date.Now.AddHours(2)

        flightsFound.flightL.Clear()
        DepartComboBox.SelectedIndex = 0
        ArriveComboBox.SelectedIndex = 1

        FlightInfoResultsForm.FlightChart.Series.Clear()
        FlightInfoResultsForm.FlightChart.ChartAreas(0).AxisY.CustomLabels.Clear()
        FlightInfoResultsForm.FlightChart.Legends.Clear()
        'FlightInfoResultsForm.FlightChart.Titles.Clear()

    End Sub
End Class
