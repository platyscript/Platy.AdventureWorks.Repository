[![Build Project](https://github.com/tremorscript/Platy.AdventureWorks.Repository/actions/workflows/ci.yml/badge.svg)](https://github.com/tremorscript/Platy.AdventureWorks.Repository/actions/workflows/ci.yml)

[![NuGet Version](https://img.shields.io/nuget/v/Platy.AdventureWorks.Repository?label=Platy.AdventureWorks.Repository)](https://www.nuget.org/packages/Platy.AdventureWorks.Repository/)

# Overview

A project template that I use to quickly create a set of repository classes for interacting with any existing database.

# Features

- The DbContext class is internal, which means that external libraries users cannot make db changes without interacting with the repository classes.
- The repository classes validate the entities before making changes to the database keeping it clean.
- A [Result](https://github.com/ardalis/Result) type is returned in case of success or failure, instead of relying on exceptions. Makes [testing](https://github.com/xunit/xunit) and [validation](https://github.com/FluentValidation/FluentValidation) easier.
- A [notification](https://github.com/LuckyPennySoftware/MediatR) is published for every Create, Update and Delete event. External libraries can subscribe to these events and accordingly perform any required action.
- `csx` templates to customize the entities,the repository classes and the model classes that are output by the [generator](https://github.com/loresoft/EntityFrameworkCore.Generator).
- Integration tests using [TestContainers](https://dotnet.testcontainers.org/) helps testing the repository classes with a real database that is spun up and down as the tests execute.

# Build solution

First, initialize the submodule using `git submodule update --init`.

Build the solution - `Platy.AdventureWorks.Repostory.sln`
