// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function btnSearch()
{
    var searchText = document.getElementById('txtSearch');
    var url = window.location.origin;
    url = url + "/Search/Search?searchText=" + searchText.value;
    window.location.href = url;
}
