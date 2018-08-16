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

Imports System.ComponentModel

Namespace Objects
    Public Class Asset

        Sub New()
            Me.ID = 0
            Me.FileName = ""
            Me.ContentType = ""
            Me.Size = 0
            Me.Downloaded = True
            Me.Created = Now
            Me.Updated = Now
            Me.URL = URL
        End Sub

        Sub New(ByVal ID As Integer, ByVal FileName As String, ByVal ContentType As String,
            ByVal Size As Integer, ByVal Downloaded As Integer, ByVal Created As DateTime,
            ByVal Updated As DateTime, ByVal URL As String)
            Me.ID = ID
            Me.FileName = FileName
            Me.ContentType = ContentType
            Me.Size = Size
            Me.Downloaded = Downloaded
            Me.Created = Now
            Me.Updated = Updated
            Me.URL = URL
        End Sub

        Public Property ID As Integer
        <DisplayName("File Name")>
        Public Property FileName As String
        <DisplayName("File Type")>
        Public Property ContentType As String
        <DisplayName("Size (bytes)")>
        Public Property Size As Integer
        <DisplayName("No. of Downloads")>
        Public Property Downloaded As Integer
        <DisplayName("Created at")>
        Public Property Created As DateTime
        <DisplayName("Update at")>
        Public Property Updated As DateTime
        Public Property URL As String

        Public Overrides Function ToString() As String
            Return FileName
        End Function

    End Class
End Namespace