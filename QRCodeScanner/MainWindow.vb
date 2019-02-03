Imports WebCam_Capture
Imports MessagingToolkit.QRCode.Codec

Public Class MainWindow

    'Declarations

    WithEvents MyWebcam As WebCamCapture
    Dim Reader As QRCodeDecoder


    'Buttons

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        StartWebcam()
        tb_output.Clear()
    End Sub

    Private Sub btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click
        StopWebcam()
    End Sub
    Private Sub btn_detect_Click(sender As Object, e As EventArgs) Handles btn_detect.Click
        'Scans the received image
        Try
            StopWebcam()
            Reader = New QRCodeDecoder
            tb_output.Text = Reader.decode(New Data.QRCodeBitmapImage(pb_scanner.Image))
            MsgBox("QR code is detected!")
        Catch ex As Exception
            StartWebcam()
        End Try
    End Sub

    Private Sub btn_saveImage_Click(sender As Object, e As EventArgs) Handles btn_saveImage.Click

    End Sub

    'Functions

    Private Sub MyWebcam_ImageCaptured(source As Object, e As WebcamEventArgs) Handles MyWebcam.ImageCaptured
        pb_scanner.Image = e.WebCamImage
    End Sub

    Private Sub StartWebcam()
        Try
            StopWebcam()
            MyWebcam = New WebCamCapture
            MyWebcam.Start(0)
            MyWebcam.Start(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub StopWebcam()
        Try
            MyWebcam.Stop()
            MyWebcam.Dispose()
        Catch ex As Exception

        End Try
    End Sub
End Class
