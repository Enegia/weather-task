# Welcome to EnerKey coding challenge!
Weather Api is a work in progress web api written with C# and NET6.0.

## Descriptions
Solution is divided to three projects:
1. Weather.Api, which acts as a web api containing controllers and other logic related to returning data from the endpoints
2. Weather.Data, which acts as a inmemory & random generated data that is accceible through model
3. Weather.Model, which acts as data access layer

## Tasks
This project contains four tasks:
- Task 1: Create an endpoint, that allows user to search stations by their name and city and construction year
- Task 2: Create an endpoint that allows you to insert one station to WeatherDataContext
- Task 3: Create an endpoint, that returns combined wind and temperature within same payload for given station
- Task 4: DataReader class in Data-project, contains information about humidity. Implement it through solution and return it from endpoint

## Other
To get started, check Weather.Api.Contollers.StationController and Weather.Api.Contollers.WeatherController.

You have complete freedom on how to handle the implementations. In this challenge, unit and/or integration testing should not be done at all 
and focus is purely on the controller-side.
