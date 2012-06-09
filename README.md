disable-request-validation
==========================

When installed into an ASP.NET 4.0+ web site, this NuGet package will disable the request validation feature.  The common use case for this package is to provide an opt-out mechanism for applications which anticipate end users passing HTML or other potentially "unsafe" input to ASP.NET.

As always, application developers are ultimately responsible for making sure that potentially untrusted user input is sanitized appropriately.