Public Class ReviewItem
    Public Sub SetearDatosDeReview(username As String, review As String, review_date As String)
        lbl_username.Text = $"{username} - {review_date}"
        lbl_review.Text = $"{review}"
    End Sub
End Class
