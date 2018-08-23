<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="amp_access.Default" %>
<!doctype html>
<html ⚡>
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width,minimum-scale=1,initial-scale=1">
        <link rel="canonical" href="Default.html">
        <style amp-boilerplate>body{-webkit-animation:-amp-start 8s steps(1,end) 0s 1 normal both;-moz-animation:-amp-start 8s steps(1,end) 0s 1 normal both;-ms-animation:-amp-start 8s steps(1,end) 0s 1 normal both;animation:-amp-start 8s steps(1,end) 0s 1 normal both}@-webkit-keyframes -amp-start{from{visibility:hidden}to{visibility:visible}}@-moz-keyframes -amp-start{from{visibility:hidden}to{visibility:visible}}@-ms-keyframes -amp-start{from{visibility:hidden}to{visibility:visible}}@-o-keyframes -amp-start{from{visibility:hidden}to{visibility:visible}}@keyframes -amp-start{from{visibility:hidden}to{visibility:visible}}</style><noscript><style amp-boilerplate>body{-webkit-animation:none;-moz-animation:none;-ms-animation:none;animation:none}</style></noscript>
        <script async custom-element="amp-analytics" src="https://cdn.ampproject.org/v0/amp-analytics-0.1.js"></script>
        <script async custom-element="amp-access" src="https://cdn.ampproject.org/v0/amp-access-0.1.js"></script>
        <script async custom-template="amp-mustache" src="https://cdn.ampproject.org/v0/amp-mustache-0.1.js"></script>
        <script async src="https://cdn.ampproject.org/v0.js"></script>
        <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700" type="text/css">

        <script id="amp-access" type="application/json">
            {
                "authorization": "<%= domain%>/Api/AmpAuthorization/?rid=READER_ID&url=CANONICAL_URL&ref=DOCUMENT_REFERRER&_=RANDOM",
                "pingback": "<%= domain%>/Api/AmpPingback/?rid=READER_ID&url=CANONICAL_URL&ref=DOCUMENT_REFERRER&_=RANDOM",
                "login": "<%= domain %>/Login/?rid=READER_ID&url=CANONICAL_URL",
                "authorizationFallbackResponse": {
                    "error": true,
                    "access": false,
                    "subscriber": false
                }
            }
        </script>

        <%--The Pingback endpoint is called when the Reader has started viewing the document and after the Reader has successfully completed the Login Flow.

        The publisher may choose to use the pingback:

        to count down the number of free views of the page
        to map the AMP Reader ID to the Publisher’s identity, since as a credentialed CORS endpoint, the Pingback may contain Publisher cookies--%>


    </head>
    <body>
        <section amp-access="subscriber OR premeum" amp-access-hide>
            <h2>로그인 성공!!!</h2>
            <a href="<%= domain %>/Api/logout" class="logout">Logout</a>
        </section>

        <section amp-access="NOT subscriber" amp-access-hide>
            <h2>로그인 하세요.</h2>
            <a on="tap:amp-access.login">Login</a>
        </section>
    </body>
</html>