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

Public Class UpdaterEx : Inherits Component

#Region "Variables"
    Dim Icon_ As Icon = Nothing
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
            If Icon_ Is Nothing Then
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
#End Region

End Class