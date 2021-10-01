[![.NET](https://github.com/matheus-vieira/restaurant-order-app-minimal-api/actions/workflows/dotnet.yml/badge.svg)](https://github.com/matheus-vieira/restaurant-order-app-minimal-api/actions/workflows/dotnet.yml)
[![Build](https://github.com/matheus-vieira/restaurant-order-app-minimal-api/actions/workflows/build.yml/badge.svg)](https://github.com/matheus-vieira/restaurant-order-app-minimal-api/actions/workflows/build.yml)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=matheus-vieira_restaurant-order-app-minimal-api&metric=alert_status)](https://sonarcloud.io/dashboard?id=matheus-vieira_restaurant-order-app-minimal-api)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=matheus-vieira_restaurant-order-app-minimal-api&metric=bugs)](https://sonarcloud.io/dashboard?id=matheus-vieira_restaurant-order-app-minimal-api)
[![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=matheus-vieira_restaurant-order-app-minimal-api&metric=code_smells)](https://sonarcloud.io/dashboard?id=matheus-vieira_restaurant-order-app-minimal-api)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=matheus-vieira_restaurant-order-app-minimal-api&metric=coverage)](https://sonarcloud.io/dashboard?id=matheus-vieira_restaurant-order-app-minimal-api)
[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=matheus-vieira_restaurant-order-app-minimal-api&metric=sqale_index)](https://sonarcloud.io/dashboard?id=matheus-vieira_restaurant-order-app-minimal-api)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=matheus-vieira_restaurant-order-app-minimal-api&metric=ncloc)](https://sonarcloud.io/dashboard?id=matheus-vieira_restaurant-order-app-minimal-api)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=matheus-vieira_restaurant-order-app-minimal-api&metric=duplicated_lines_density)](https://sonarcloud.io/dashboard?id=matheus-vieira_restaurant-order-app-minimal-api)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=matheus-vieira_restaurant-order-app-minimal-api&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=matheus-vieira_restaurant-order-app-minimal-api)
[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=matheus-vieira_restaurant-order-app-minimal-api&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=matheus-vieira_restaurant-order-app-minimal-api)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=matheus-vieira_restaurant-order-app-minimal-api&metric=security_rating)](https://sonarcloud.io/dashboard?id=matheus-vieira_restaurant-order-app-minimal-api)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=matheus-vieira_restaurant-order-app-minimal-api&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=matheus-vieira_restaurant-order-app-minimal-api)


# Restaurant Order App (technical test)

## We are expecting to evaluate follow criteria:

1. Object Oriente dDesign
2. Respect SOLID Principles
3. Readability
4. Maintainability
5. Testability

## FrontendRequirements:

1. Create SPA website using any JavaScriptframework (e.g.Angular, ReactJs etc.)
2. Main Page must have 4 components :  input textbox, output textbox, button( send order) and grid
3. The grid must keep history of inputs and outputs that user had requested before
4. Website can(optional)have unit tests 
5. Pushyour solution in a GitHub repository, and send us a link when done

## Backend Requirements:

1. Create this solution as a web APIapplication
2. Solution musthave unit tests
3. Pushyour solution in a GitHub repository, and send us a link when done

## Rules:

1. You must enter time of day as “morning” or “night”
2. You must enter a comma delimited list of dish types with at least one selection
3. The output must print food in the following order: entrée, side, drink, dessert
4. There is no dessert for morning meals
5. Input is not case sensitive
6. If invalid selection is encountered, display valid selections up to the error, then print error
7. In the morning, you can order multiple cups of coffee
8. At night, you can have multiple orders of potatoes
9. Except for the above rules, you can only order 1 of each dish type

## Dishes for Each time of day

| Dish Type   | morning        | night  |
|-------------|----------------|--------|
| 1 (entrée)  | eggs           | steak  |
| 2 (side)    | Toast          | potato |
| 3 (drink)   | coffee         | wine   |
| 4 (dessert) | Not Applicable | cake   |

### Sample Input and Output:

```text
Input: morning, 1, 2, 3        Output: eggs,toast, coffee
Input: morning, 2, 1, 3        Output: eggs, toast, coffee
Input: morning, 1, 2, 3, 4     Output: eggs, toast, coffee, error
Input: morning, 1, 2, 3, 3, 3  Output: eggs, toast, coffee(x3)
Input: night, 1, 2, 3, 4       Output: steak, potato, wine, cake
Input: night, 1, 2, 2, 4       Output steak, potato(x2), cake
Input: night, 1, 2, 3, 5       Output: steak, potato, wine, error
Input: night, 1, 1, 2, 3, 5    Output:  steak, error
```
