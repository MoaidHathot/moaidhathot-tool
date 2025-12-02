#!/usr/bin/env dotnet run

#:package Dumpify@0.6.*

#:property PackAsTool=true
#:property ToolCommandName=moaid
#:property PackageId=MoaidHathot.Tool
#:property PackageVersion=1.0.0
#:property Authors=Moaid Hathot
#:property Description=A simple .NET Tool telling a bit about Moaid Hathot

using Dumpify;

var info = new[]
{
    new { Property = "Name", Value = "Moaid Hathot" },
    new { Property = "Title", Value = "Principal Software Engineer @Microsoft" },
    new { Property = "Location", Value = "Seattle" },
    new { Property = "Interests", Value = ".NET, C#, Cloud, AI" },
    new { Property = "GitHub", Value = "https://github.com/MoaidHathot" },
    new { Property = "Website", Value = "https://moaid.codes" }
};

info.Dump("About Moaid Hathot");
