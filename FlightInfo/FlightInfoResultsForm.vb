Imports System.Windows.Forms.DataVisualization

Public Class FlightInfoResultsForm

    Private minPrice As Integer = 0
    Private maxPrice As Integer = 1000

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Private Sub FlightInfoResultsForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        FlightInfoMainForm.flightsFound.flightL.Clear()
        FlightChart.Titles.Clear()
    End Sub

    Private Sub FlightInfoResultsForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim depart_station(69) As String
        Dim flight_num(69) As String
        Dim flight_label(69) As String
        Dim i As Integer = 0
        Dim price(69) As Double
        Dim flight_series(69) As Charting.Series
        Dim title1 As Charting.Title = New Charting.Title

        'reset min, max
        MinTrackBar.Value = 0
        MaxTrackBar.Value = 1000

        'reset all airlines selected
        AmericanCheckBox.Checked = True
        UnitedCheckBox.Checked = True
        DeltaCheckBox.Checked = True

        'MessageBox.Show("Found " + CType(FlightInfoMainForm.flightsFound.flightL.Count, String) + " Flights")
        FlightChart.ChartAreas(0).AxisX.Maximum = 24
        FlightChart.ChartAreas(0).AxisX.Minimum = 1
        FlightChart.ChartAreas(0).AxisX.Interval = 1
        FlightChart.ChartAreas(0).AxisY.Interval = 1
        FlightChart.ChartAreas(0).AxisX.Title = "Time: 24 Hour"
        FlightChart.ChartAreas(0).AxisY.Title = "Airline"

        'set title 
        title1.Text = "From " + FlightInfoMainForm.DepartComboBox.Text + " to " + FlightInfoMainForm.ArriveComboBox.Text
        FlightChart.Titles.Add(title1)


        For Each flight In FlightInfoMainForm.flightsFound.flightL
            ' depart_station(i) = flight.depart_station

            flight_series(i) = New Charting.Series
            FlightChart.Series.Add(flight_series(i))

            FlightChart.Series(i).ChartType = Charting.SeriesChartType.Line

            FlightChart.Series(i).BorderWidth = flight.price * 0.015 ' Scale price -- same as line width ***
            FlightChart.Series(i).MarkerSize = flight.price * 0.015  ' Scale price -- adjust width of line here ***

            'Create Label flight-price
            flight_num(i) = flight.flight_no
            price(i) = flight.price
            flight_label(i) = flight_num(i) + " $" + price(i).ToString

            FlightChart.Series(i).Points.AddXY(flight.depart_time.Hour + (flight.depart_time.Minute / 60), i) ' y stays same straight line
            FlightChart.Series(i).Points(0).Label = flight_label(i) 'only label first point
            FlightChart.ChartAreas(0).AxisY.CustomLabels.Add(i, i + 0.75, flight.airline_company) 'custom y-axis label

            FlightChart.Series(i).Points.AddXY(flight.arrive_time.Hour, i)
            ' FlightChart.Series(i).IsValueShownAsLabel = True

            i = i + 1
        Next


    End Sub


    Private Sub AmericanCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles AmericanCheckBox.CheckedChanged
        updateFlightList()
    End Sub

    Private Sub DeltaCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles DeltaCheckBox.CheckedChanged
        updateFlightList()
    End Sub

    Private Sub UnitedCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles UnitedCheckBox.CheckedChanged
        updateFlightList()
    End Sub

    Private Sub updateFlightList()

        Dim depart_station(69) As String
        Dim flight_num(69) As String
        Dim flight_label(69) As String
        Dim i As Integer = 0
        Dim price(69) As Double
        Dim flight_series(69) As Charting.Series
        Dim title1 As Charting.Title = New Charting.Title

        'Clear the chart series, airline labels and legend 
        FlightChart.Series.Clear()
        FlightChart.ChartAreas(0).AxisY.CustomLabels.Clear()
        FlightChart.Legends.Clear()
        'FlightChart.Titles.Clear()

        For Each flight In FlightInfoMainForm.flightsFound.flightL

            If AmericanCheckBox.Checked = False And String.Compare(flight.airline_company, "American Airline") = 0 Then
                'do nothing
            ElseIf DeltaCheckBox.Checked = False And String.Compare(flight.airline_company, "Delta Airline") = 0 Then
                'do nothing
            ElseIf UnitedCheckBox.Checked = False And String.Compare(flight.airline_company, "United Airline") = 0 Then
                'do nothing
            Else
                'add flight to display only if it is in price range
                If flight.price >= minPrice And flight.price <= maxPrice Then
                    flight_series(i) = New Charting.Series
                    FlightChart.Series.Add(flight_series(i))

                    FlightChart.Series(i).ChartType = Charting.SeriesChartType.Line

                    FlightChart.Series(i).BorderWidth = flight.price * 0.015 ' Scale price -- same as line width ***
                    FlightChart.Series(i).MarkerSize = flight.price * 0.015  ' Scale price -- adjust width of line here ***

                    'Create Label flight-price
                    flight_num(i) = flight.flight_no
                    price(i) = flight.price
                    flight_label(i) = flight_num(i) + " $" + price(i).ToString

                    FlightChart.Series(i).Points.AddXY(flight.depart_time.Hour + (flight.depart_time.Minute / 60), i) ' y stays same straight line
                    FlightChart.Series(i).Points(0).Label = flight_label(i) 'only label first point
                    FlightChart.ChartAreas(0).AxisY.CustomLabels.Add(i, i + 0.75, flight.airline_company) 'custom y-axis label

                    FlightChart.Series(i).Points.AddXY(flight.arrive_time.Hour, i)
                    ' FlightChart.Series(i).IsValueShownAsLabel = True

                    i = i + 1  'added flight so go to next series
                End If
            End If

        Next

        FlightChart.Update()
    End Sub




    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub MinTrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles MinTrackBar.Scroll
        If MaxTrackBar.Value < MinTrackBar.Value Then
            MaxTrackBar.Value = MinTrackBar.Value
        End If

        'get min price selected
        minPrice = MinTrackBar.Value

        updateFlightList()

    End Sub

    Private Sub MaxTrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles MaxTrackBar.Scroll
        If MaxTrackBar.Value < MinTrackBar.Value Then
            MinTrackBar.Value = MaxTrackBar.Value
        End If
        'get max price selected
        maxPrice = MaxTrackBar.Value

        updateFlightList()

    End Sub
End Class