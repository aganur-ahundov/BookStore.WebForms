<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GenreList.ascx.cs" Inherits="BookStore.Control.GenreList" %>


<%= CreateHomeLinkHtml() %>


<%

    foreach(string genre in GetGenreList())
    {
        Response.Write(
            CreateGenreLinkHtml(genre)
           );
    }


 %>