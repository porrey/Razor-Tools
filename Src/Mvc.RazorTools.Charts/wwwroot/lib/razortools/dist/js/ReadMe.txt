1. Place the style sheet link below in the head of your page or your _Layout.cshtml file.
2. Place the script links at the bottom of your page or the bottom of your _Layout.cshtml file.
3. If you plan to use the charts on just a few pages, place these links in each view. If you
   plan to use charts in multiple pages consider placing these links in _Layout.cshtml.

<head>
	<link rel="stylesheet" href="//cdnjs.cloudflare.com/ajax/libs/morris.js/0.5.1/morris.css">
</head>


<script src="//cdnjs.cloudflare.com/ajax/libs/raphael/2.1.0/raphael-min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/morris.js/0.5.1/morris.min.js"></script>
<script src="~/lib/razortools/dist/js/moment.js"></script>
<script src="~/lib/razortools/dist/js/razortools.charts.unobtrusive.js"></script>