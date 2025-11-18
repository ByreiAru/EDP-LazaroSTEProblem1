Public Class Form1
    Dim ArtworkList As New List(Of String)
    Private Sub AddArtwork_Click(sender As Object, e As EventArgs) Handles AddArtwork.Click
        Try
            Dim artworkTitle As String = TBArtworkTitle.Text
            Dim artist As String = ArtistName.Text
            Dim category As String = CategoryComboBox.Text
            Dim price As Double
            Dim check As Boolean = Double.TryParse(ArtworkPrice.Text, price)

            If String.IsNullOrEmpty(artworkTitle) Or String.IsNullOrEmpty(artist) Or Not check Or String.IsNullOrEmpty(category) Then
                MsgBox("Try Again: Empty Field or Invalid Price")
                Return
            End If

            ArtworkList.Add(artworkTitle & " | " & artist & " | " & category & " | " & price)

            TBArtworkTitle.Clear()
            ArtistName.Clear()
            CategoryComboBox.SelectedIndex = -1
            ArtworkPrice.Clear()

        Catch ex As Exception
            MsgBox("Something Went Wrong: " & ex.Message)
        End Try
    End Sub
    Private Sub ResetData_Click(sender As Object, e As EventArgs) Handles ResetData.Click
        ArtworkList.Clear()
        Exhibit.Items.Clear()
    End Sub
    Private Sub AnalyzeExhibit_Click(sender As Object, e As EventArgs) Handles AnalyzeExhibit.Click
        Exhibit.Items.Clear()

        If ArtworkList.Count = 0 Then
            Outputs.Text = "No artworks recorded."
            Return
        End If

        Dim totalArtworks As Integer = ArtworkList.Count
        Dim totalPrice As Double = 0
        Dim highestPrice As Double = Double.MinValue
        Dim lowestPrice As Double = Double.MaxValue
        Dim categoryCounts As New Dictionary(Of String, Integer)

        For Each art As String In ArtworkList
            Exhibit.Items.Add(art)

            Dim parts() As String = art.Split("|"c)
            Dim category As String = parts(2).Trim()
            Dim price As Double = Double.Parse(parts(3).Trim())

            totalPrice += price
            If price > highestPrice Then highestPrice = price
            If price < lowestPrice Then lowestPrice = price

            If categoryCounts.ContainsKey(category) Then
                categoryCounts(category) += 1
            Else
                categoryCounts(category) = 1
            End If
        Next

        Dim outputText As String = "Total Artworks: " & totalArtworks & Environment.NewLine
        outputText &= "Average Price: " & (totalPrice / totalArtworks).ToString("F2") & Environment.NewLine
        outputText &= "Highest Price: " & highestPrice.ToString("F2") & Environment.NewLine
        outputText &= "Lowest Price: " & lowestPrice.ToString("F2") & Environment.NewLine
        outputText &= "Artworks per Category:" & Environment.NewLine

        For Each kvp In categoryCounts
            outputText &= kvp.Key & ": " & kvp.Value & Environment.NewLine
        Next

        Outputs.Text = outputText
    End Sub
End Class
