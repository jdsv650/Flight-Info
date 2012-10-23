Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel


Public Class FlightList
    Public flightL As New Collection
    Dim oExcel As Excel.Application
    Dim wkbObj As Workbook
    ' Dim arr(0 To 8) As Integer
    Dim flight As FlightDetails

    Public Sub New()


    End Sub

    Public Sub BuildList()
        Dim depart_station As String
        Dim depart_time As DateTime
        Dim arrive_station As String
        Dim arrive_time As DateTime
        Dim price As Double
        Dim airline_company As String
        Dim flight_no As String

        'oExcel = CreateObject("Excel.Application")
        Try
            '  oExcel.Workbooks.Open("\flights.xlsx", , True)
            wkbObj = GetObject("C:\Users\James\Documents\Visual Studio 2010\Projects\FlightInfo\FlightInfo\flights.xlsx")
        Catch ex As Exception
            MessageBox.Show("Can't Open flights.xlsx")

        Finally
            ' oExcel.Workbooks.Close()
        End Try

        'Populate array from workbook cells D14-D22

        Dim i As Integer


        For i = 2 To 69
            depart_station = wkbObj.Worksheets(1).Range("A" & i).Value
            '  MessageBox.Show(DateTime.FromOADate(wkbObj.Worksheets(1).Range("B" & i).Value))

            depart_time = DateTime.FromOADate(wkbObj.Worksheets(1).Range("B" & i).Value)
            'MessageBox.Show("depart_time = " + depart_time)

            arrive_station = wkbObj.Worksheets(1).Range("C" & i).Value
            arrive_time = DateTime.FromOADate(wkbObj.Worksheets(1).Range("D" & i).Value)
            price = wkbObj.Worksheets(1).Range("E" & i).Value
            airline_company = wkbObj.Worksheets(1).Range("F" & i).Value
            flight_no = wkbObj.Worksheets(1).Range("G" & i).Value


            flight = New FlightDetails(depart_station, depart_time, arrive_station, arrive_time, price, airline_company, flight_no)
            flightL.Add(flight)
        Next i

        wkbObj.Close()



    End Sub

End Class

