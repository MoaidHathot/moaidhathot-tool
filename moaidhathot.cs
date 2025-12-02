#!/usr/bin/env dotnet run

#:package Dumpify@0.6.*

#:property PackAsTool=true
#:property ToolCommandName=moaidhathot
#:property PackageId=MoaidHathot.Tool
#:property PackageVersion=1.0.0
#:property Authors=Moaid Hathot
#:property Description=A simple .NET Tool telling a bit about Moaid Hathot

using Dumpify;

var info = new[]
{
    new { Property = "Name", Value = "Moaid Hathot" },
    new { Property = "Title", Value = "Software Engineer" },
    new { Property = "Location", Value = "Israel" },
    new { Property = "Interests", Value = ".NET, C#, Cloud, AI" },
    new { Property = "GitHub", Value = "https://github.com/MoaidHathot" }
};

info.Dump("About Moaid Hathot");
