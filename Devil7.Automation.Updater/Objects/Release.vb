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
    Public Class Release

        Sub New()
            Me.ID = 0
            Me.URL = ""
            Me.TagName = ""
            Me.Name = ""
            Me.Draft = False
            Me.Author = Nothing
            Me.PreRelease = False
            Me.Created = Now
            Me.Published = Now
            Me.Assets = New List(Of Asset)
            Me.Message = ""
        End Sub

        Sub New(ByVal ID As Integer, ByVal URL As String, ByVal TagName As String,
            ByVal Name As String, ByVal Draft As Boolean, ByVal Author As User,
            ByVal PreRelease As Boolean, ByVal Created As DateTime, ByVal Published As DateTime,
            ByVal Assets As List(Of Asset), ByVal Message As String)
            Me.ID = ID
            Me.URL = URL
            Me.TagName = TagName
            Me.Name = Name
            Me.Draft = Draft
            Me.Author = Author
            Me.PreRelease = PreRelease
            Me.Created = Created
            Me.Published = Published
            Me.Assets = Assets
            Me.Message = Message
        End Sub

        Public Property ID As Integer
        <DisplayName("Release URL")>
        Public Property URL As String
        <DisplayName("Release Tag Name")>
        Public Property TagName As String
        <DisplayName("Release Name")>
        Public Property Name As String
        <DisplayName("Is Draft")>
        Public Property Draft As Boolean
        Public Property Author As User
        <DisplayName("Is Pre-release")>
        Public Property PreRelease As Boolean
        <DisplayName("Created at")>
        Public Property Created As DateTime
        <DisplayName("Published at")>
        Public Property Published As DateTime
        <DisplayName("Assets/Files")>
        Public Property Assets As List(Of Asset)
        Public Property Message As String

    End Class
End Namespace