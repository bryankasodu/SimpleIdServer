@model SimpleIdServer.OpenID.UI.ViewModels.RevokeSessionViewModel
@using $rootnamespace$.Resources

@{
    ViewBag.Title = OpenIdGlobal.revoke_session_title;
    Layout = "~/Views/Shared/_OpenIdLayout.cshtml";
}

@if (!string.IsNullOrWhiteSpace(Model.FrontChannelLogout))
{
    <iframe src="@Model.FrontChannelLogout" style="display: none"></iframe>
}

<a href="@Model.RevokeSessionCallbackUrl" class="btn btn-danger">@OpenIdGlobal.revoke_session_title</a>