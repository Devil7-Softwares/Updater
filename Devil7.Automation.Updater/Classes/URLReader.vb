'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'=========================================================================='

Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Threading.Tasks

Namespace Classes
    Public Class URLReader : Implements IDisposable
        Private Client As HttpClient
        Public Delegate Sub ProgressChangedHandler(ByVal progressPercentage As Double?)
        Public Event ProgressChanged As ProgressChangedHandler

        Public Async Function ReadURL(ByVal URL As String) As Task(Of String)
            ServicePointManager.Expect100Continue = True
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            Client = New HttpClient With {.Timeout = TimeSpan.FromHours(1)}
            Client.DefaultRequestHeaders.Add("User-Agent", "Devil7 Updater Library")
            Dim R As String = ""
            Using response = Await Client.GetAsync(URL, HttpCompletionOption.ResponseHeadersRead)
                R = Await DownloadFileFromHttpResponseMessage(response)
            End Using
            Return R
        End Function

        Private Async Function DownloadFileFromHttpResponseMessage(ByVal response As HttpResponseMessage) As Task(Of String)
            response.EnsureSuccessStatusCode()
            Dim totalBytes = response.Content.Headers.ContentLength
            Dim R As String = ""
            Using contentStream = Await response.Content.ReadAsStreamAsync()
                R = Await ProcessContentStream(totalBytes, contentStream)
            End Using
            Return R
        End Function

        Private Async Function ProcessContentStream(ByVal totalDownloadSize As Long?, ByVal contentStream As Stream) As Task(Of String)
            Dim totalBytesRead = 0L
            Dim readCount = 0L
            Dim buffer = New Byte(8191) {}
            Dim isMoreToRead = True

            Dim R As String = ""
            Using stream = New MemoryStream

                Do
                    Dim bytesRead = Await contentStream.ReadAsync(buffer, 0, buffer.Length)

                    If bytesRead = 0 Then
                        isMoreToRead = False
                        TriggerProgressChanged(totalDownloadSize, totalBytesRead)
                        Continue Do
                    End If

                    Await stream.WriteAsync(buffer, 0, bytesRead)
                    totalBytesRead += bytesRead
                    readCount += 1
                    If readCount Mod 100 = 0 Then TriggerProgressChanged(totalDownloadSize, totalBytesRead)
                Loop While isMoreToRead
                R = Text.Encoding.ASCII.GetString(stream.ToArray)
            End Using
            Return R
        End Function

        Private Sub TriggerProgressChanged(ByVal totalDownloadSize As Long?, ByVal totalBytesRead As Long)
            Dim progressPercentage As Double = 0
            If totalDownloadSize.HasValue Then progressPercentage = Math.Round(CDbl(totalBytesRead) / totalDownloadSize.Value * 100, 2)
            RaiseEvent ProgressChanged(progressPercentage)
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Client?.Dispose()
        End Sub

    End Class
End Namespace