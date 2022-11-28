#!/usr/bin/env bash
#simplifying projects preparation by me c:
dotnet new console -o $1
dotnet build $1
mv $1/Program.cs $1/$1.cs