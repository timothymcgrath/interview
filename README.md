# .NET Developer Interview Test

## Directions

The app is a WPF client app that displays a list of stocks and a small summary. The app loads its data from
an MVC Web App with a REST call to GET /stocks/.

The summary will calculate the number of Buy and Sell recommendations for the stocks and display them in a text
summary.

The app needs to refresh the data in the UI every 5 seconds.

A pre-built client proxy exists for the client to use in the VectorVest.Interview.Api.Client project named 
InterviewService.

Also, execute the tests in the VectorVest.Interview.Tests project and fix any broken tests.