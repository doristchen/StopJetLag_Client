

# StopJetLag_Client

Using Xamarin.Forms allows for one UI code base for all three platforms (iOS, Android, and Windows) instead of multiple separate native UI apps. Also converting the StopJetLag separate shared files core logic solutions into one PCL core non-UI logic solution makes maintenance significantly easier and less error prone. Because Xamarin.Forms is primarily a XAML technology, the StopJetLag app made extensive use of the Model-View-View-Model (MVVM) design pattern. To avoid reinventing the wheel, these Plugins were added to the projects using NuGet.

•	MvvmHelpers

•	Connectivity

•	DeviceInfo

•	SQLLite

•	Xamarin.Forms.CarouselView

These plugins are designed to add platform specific implementations where necessary which is a great timesaver during development.

TripJetLag Mobile App from Azure App Service REST

I developed mobile apps for retrieving trip advice and trip legs associated with trip notes by using Xamarin.Forms. Jet lag advice and trip notes are retrieved with an asynchronous web request to the Azure App Service REST endpoint using Async and Await in order not to block the main thread of the app.  The following key technology is used:

•	ListView: takes care of performance for scrolling

•	Creating Custom Cells for better flexibility in layout with image icons and text

•	Enhancing ListView with Grouping Headers for sorting and grouping: use MvvmHelpers

•	Image resources are stored in client side only for better performance

o	The location of image resources need to be in correct location and they are platform dependent

o	Xamarin.Forms make it easy to maintain and organize

•	Asynchronous REST call to Azure App Service REST endpoint

•	Data reader for DTO model

The project repository is at
https://github.com/doristchen/StopJetLag_Client/tree/master/TripJetLagApp

TripetLag Mobile App Offline
One of the challenge is to support the StopJetLag app offline, as most travelers will want to see the trip advice and trip notes while they don’t have internet access.  I developed the app to support offline by using SQLite for local persistence.  Also, if the content of trip notes and advices are not updated, the data in local storage will be used for better performance. After the traveler uses the StopJetLag Mobile app to retrieve their jet lag advice information and trip notes from Azure REST endpoints, the information is persisted locally using a SQLite database located on the mobile device.  The key technology is as follows:

•	Using SQLite:

o	SQLite database file needs in the correct location on the mobile device which is platform dependent

o	Xamarin.Forms make it easy to maintain and organize

•	Enhancing ListView with Grouping Headers for sorting and grouping: use MvvmHelpers

o	Trip leg location is used as the key for grouping and sorting

•	Implemented CarouselView (new feature in Xamarin.Forms)  for cool flipping UI experience

•	Creating Custom Cells (in ListView) for better flexibility in layout with image icons and text

 The project repository is at
https://github.com/doristchen/StopJetLag_Client/tree/master/TripJetLagAppOffLine 
