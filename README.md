# WPF - Toaster #
<a target="_blank" href="LICENSE"><img src="https://img.shields.io/badge/licence-MIT-brightgreen.svg" alt="license : MIT"></a> <a target="_blank" href="https://www.cmarix.com/wpf-wcf-web-development-services.html"><img src="https://img.shields.io/badge/framework-WPF-blue.svg" alt="framework : WPF"></a>

<p align="center">
  <img alt="WPF toaster example" src="https://www.cmarix.com/git/DotNet/WPF-toaster-example.gif">
</p>

## Installation ##

    Install-Package Notifications.Wpf

## Usage ##
	var notificationManager = new NotificationManager();
	
	notificationManager.Show(new NotificationContent
	{
		Title = "Success",
		Message = "Data saved successfully",
		Type = NotificationType.Success
	});

## Parameters ##
#### object:

Need to pass content and type of notification as a object of **NotificationContent**. **NotificationContent** contains Title, Message and NotificationType property.

#### areaName:

Need to pass the area where we want to show the notification. eg: WindowArea

#### expirationTime:

Need to pass the expiration time of notification as a TimeSpan.

#### onClick:

Can create click event on notification.

#### onClose:

Can create close event of notification to handle some code once notification gets closed.

## Let us know! ##
We’d be really happy if you sent us links to your projects where you use our component. Just send an email to [biz@cmarix.com](mailto:biz@cmarix.com "biz@cmarix.com") and do let us know if you have any questions or suggestion regarding WPF.

P.S. We’re going to publish more awesomeness examples on third party libaries, coding standards, plugins etc, in all the technology. Stay tuned!

## License ##

	MIT License

	Copyright © 2019 CMARIX TechnoLabs

	Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

	The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
