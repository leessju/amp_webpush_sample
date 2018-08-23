﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="amp_access.Push.amp.Default" %>

<!doctype html>
<html ⚡>
<head>
  <meta charset="utf-8">
  <title>amp-web-push example</title>
  <link rel="canonical" href="amps.html">
  <meta name="viewport" content="width=device-width,minimum-scale=1,initial-scale=1">
  <style amp-boilerplate>body{-webkit-animation:-amp-start 8s steps(1,end) 0s 1 normal both;-moz-animation:-amp-start 8s steps(1,end) 0s 1 normal both;-ms-animation:-amp-start 8s steps(1,end) 0s 1 normal both;animation:-amp-start 8s steps(1,end) 0s 1 normal both}@-webkit-keyframes -amp-start{from{visibility:hidden}to{visibility:visible}}@-moz-keyframes -amp-start{from{visibility:hidden}to{visibility:visible}}@-ms-keyframes -amp-start{from{visibility:hidden}to{visibility:visible}}@-o-keyframes -amp-start{from{visibility:hidden}to{visibility:visible}}@keyframes -amp-start{from{visibility:hidden}to{visibility:visible}}</style><noscript><style amp-boilerplate>body{-webkit-animation:none;-moz-animation:none;-ms-animation:none;animation:none}</style></noscript>
  <style amp-custom>
    .amp-web-push button {
      border-radius: 2px;
      border: 0;
      box-sizing: border-box;
      margin: 0;
      padding: 10px 15px;
      cursor: pointer;
      outline: none;
      font-size: inherit;
      font-weight: inherit;
      background: #2196F3;
      color: white;
      display: inline-block;
      box-shadow: rgba(0, 0, 0, 0.12) 0px 1px 6px, rgba(0, 0, 0, 0.12) 0px 1px 4px;
      text-align: center;
      -webkit-tap-highlight-color: rgba(0, 0, 0, 0);
    }
    .amp-web-push button:hover {
      background: #269BF8;
    }
    .amp-web-push button:active {
      background: #1C91EE;
      transform: scale(0.99);
    }
  </style>
  <script async custom-element="amp-web-push" src="https://cdn.ampproject.org/v0/amp-web-push-0.1.js"></script>
  <script async src="https://cdn.ampproject.org/v0.js"></script>
</head>
<body>
  <!-- AMP Web Push Extension Configuration -->
  <amp-web-push
    id="amp-web-push"
    layout="nodisplay"
    helper-iframe-url="<%= host%>/Push/amp/amp-web-push-helper-frame.html"
    permission-dialog-url="<%= host%>/Push/amp/amp-web-push-permission-dialog.html"
    service-worker-url="<%= host%>/Push/amp/amp-web-push.service-worker.js"
  ></amp-web-push>

  <amp-web-push-widget visibility="unsubscribed" layout="fixed" width="250" height="80">
    <button on="tap:amp-web-push.subscribe">Subscribe to Notifications</button>
  </amp-web-push-widget>
  <amp-web-push-widget visibility="subscribed" layout="fixed" width="250" height="80">
    <button on="tap:amp-web-push.unsubscribe">Unsubscribe me from Notifications</button>
  </amp-web-push-widget>
  <amp-web-push-widget visibility="blocked" layout="fixed" width="250" height="80">
    Looks like you've blocked notifications!
  </amp-web-push-widget>
  <p>
    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi eget
    ligula eu augue scelerisque sodales. Vivamus consequat consectetur mauris, sed
    mollis justo aliquam feugiat. Phasellus sagittis dui eget posuere pulvinar.
    Curabitur leo urna, auctor in fringilla ut, eleifend in dolor. Aenean
    imperdiet lectus et lectus tincidunt, eu porttitor nisi placerat. Class aptent
    taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.
    Praesent pretium tincidunt lectus sit amet semper. Sed egestas vulputate
    ultricies. Nunc vestibulum porta ante sed iaculis.
  </p>
</body>
</html>