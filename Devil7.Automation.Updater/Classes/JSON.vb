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

Imports Newtonsoft.Json.Linq

Namespace Classes
    Public Class JSON

        Shared Function ReadReleasesJson(ByVal JSON_Data As String) As List(Of Objects.Release)
            Dim Releases As New List(Of Objects.Release)
            Dim JReleases As JArray = JArray.Parse(JSON_Data)
            For Each i As JToken In JReleases
                Releases.Add(ReadReleaseJson(i.Value(Of JObject)))
            Next
            Return Releases
        End Function

        Shared Function ReadReleaseJson(ByVal JSON_Data As String) As Objects.Release
            Return ReadReleaseJson(JObject.Parse(JSON_Data))
        End Function

        Shared Function ReadReleaseJson(ByVal json As JObject) As Objects.Release
            On Error Resume Next
            Dim Release As New Objects.Release

            Release.ID = json.SelectToken("id")
            Release.Name = json.SelectToken("name")
            Release.Draft = Convert.ToBoolean(json.SelectToken("draft"))
            Release.PreRelease = Convert.ToBoolean(json.SelectToken("prerelease"))
            Release.URL = json.SelectToken("html_url")
            Release.Author = ReadUserJson(json.SelectToken("author").Value(Of JObject))
            Release.TarURL = json.SelectToken("tarball_url")
            Release.ZipURL = json.SelectToken("zipball_url")
            Release.Message = json.SelectToken("body")
            Release.Created = DateTime.Parse(json.SelectToken("created_at"))
            Release.Published = DateTime.Parse(json.SelectToken("published_at"))
            Release.TagName = json.SelectToken("tag_name")

            Dim JAssets As JArray = json.SelectToken("assets").Value(Of JArray)()
            For Each i As JToken In JAssets
                Release.Assets.Add(ReadAssetJson(i.Value(Of JObject)))
            Next

            Return Release
        End Function

        Shared Function ReadUserJson(ByVal JSON_Data As String) As Objects.User
            Return ReadUserJson(JObject.Parse(JSON_Data))
        End Function

        Shared Function ReadUserJson(ByVal json As JObject) As Objects.User
            On Error Resume Next
            Dim User As New Objects.User
            User.ID = json.SelectToken("id")
            User.Name = json.SelectToken("login")
            User.AvatarURL = json.SelectToken("avatar_url")
            User.URL = json.SelectToken("html_url")
            Return User
        End Function

        Shared Function ReadAssetJson(ByVal JSON_Data As String) As Objects.Asset
            Return ReadAssetJson(JObject.Parse(JSON_Data))
        End Function

        Shared Function ReadAssetJson(ByVal json As JObject) As Objects.Asset
            On Error Resume Next
            Dim Asset As New Objects.Asset
            Asset.ID = json.SelectToken("id")
            Asset.FileName = json.SelectToken("name")
            Asset.ContentType = json.SelectToken("content_type")
            Asset.Size = json.SelectToken("size")
            Asset.Downloaded = json.SelectToken("download_count")
            Asset.Created = DateTime.Parse(json.SelectToken("created_at"))
            Asset.Updated = DateTime.Parse(json.SelectToken("updated_at"))
            Asset.URL = json.SelectToken("browser_download_url")
            Return Asset
        End Function

    End Class
End Namespace