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
Imports System.Drawing
Imports System.Reflection
Imports System.Threading.Tasks

<DefaultEvent("StatusChanged")>
Public Class UpdaterEx : Inherits Component

#Region "Variables"
    Dim Icon_ As Icon = Nothing
    Dim BaseURL As String = "https://api.github.com/repos/{0}/{1}"
#End Region

#Region "Properties"
    <Category("GitHub Details")>
    <DisplayName("User/Organization Name")>
    <Description("Github User or Organization name where target repo is placed/hosted.")>
    Property UserName As String

    <Category("GitHub Details")>
    <DisplayName("Repository Name")>
    <Description("Github Repository name which is hosted in given User or Organization.")>
    Property RepoName As String

    <Category("Dialogs")>
    <DisplayName("Icon/Logo")>
    <Description("Icon or Logo  to display in dialogs invoked from updater.")>
    Property Icon As Icon
        Get
            If Icon_ Is Nothing AndAlso AssociatedAssembly IsNot Nothing Then
                Return Icon.ExtractAssociatedIcon(AssociatedAssembly.Location)
            Else
                Return Icon_
            End If
        End Get
        Set(value As Icon)
            Icon_ = Icon
        End Set
    End Property

    <Browsable(False)>
    Property AssociatedAssembly As Assembly

    ReadOnly Property ReleaseURL
        Get
            Return String.Join("/", String.Format(BaseURL, UserName, RepoName), "releases")
        End Get
    End Property

    ReadOnly Property LatestReleaseURL
        Get
            Return String.Join("/", String.Format(BaseURL, UserName, RepoName), "releases/latest")
        End Get
    End Property

    <Browsable(False)>
    Dim Status_ As String
    Property Status As String
        Get
            Return Status_
        End Get
        Set(value As String)
            Status_ = value
            RaiseEvent StatusChanged(Me, value, 0, False)
        End Set
    End Property
#End Region

#Region "Functions"

    Async Function GetReleases() As Task(Of List(Of Objects.Release))
        Dim R As New List(Of Objects.Release)
        Dim Reader As New Classes.URLReader
        AddHandler Reader.ProgressChanged, AddressOf ProgressChanged
        Status = "Fetching data from remote..."
        Dim RawJson As String = Await Reader.ReadURL(ReleaseURL)
        If Not String.IsNullOrWhiteSpace(RawJson) Then
            Status = "Parsing JSON..."
            R = Classes.JSON.ReadReleasesJson(RawJson)
        End If
        Return R
    End Function

    Async Function GetLatestRelease() As Task(Of Objects.Release)
        Dim R As Objects.Release = Nothing
        Dim Reader As New Classes.URLReader
        AddHandler Reader.ProgressChanged, AddressOf ProgressChanged
        Status = "Fetching data from remote..."
        Dim RawJson As String = Await Reader.ReadURL(LatestReleaseURL)
        If Not String.IsNullOrWhiteSpace(RawJson) Then
            Status = "Parsing JSON..."
            R = Classes.JSON.ReadReleaseJson(RawJson)
        End If
        Return R
    End Function

#End Region

#Region "Event Handlers"
    Sub ProgressChanged(ByVal Progress As Integer)
        RaiseEvent StatusChanged(Me, Status, Progress, True)
    End Sub
#End Region

#Region "Events"

    Event StatusChanged(ByVal Sender As Object, ByVal StatusText As String, ByVal Progress As Integer, ByVal UpdateProgress As Boolean)

#End Region

End Class