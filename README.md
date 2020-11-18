# Command API Tutorial

This project is an in-progress exercise based on a kudvenkat video series ASP.NET CORE Tutorial.

## Core concepts

### Basics

This is a simple MVC Application that manages employees, it exists as a backdrop for learning other concepts.

### Middleware Pipeline, DI

![alt text](https://github.com/Piterino/commapitut/blob/main/middlewarepipeline.png?raw=true)

A pipeline of generic delegates allows for our application to rely entirely on coding against interfaces, whilst every dependency can be injected.

### Validation Attributes

We can extend in-built validation attributes for fields, roles, policy, DTO's etc. This results in clean and easily modifiable code.

### Serving files

By assigning every uploaded file a guid, we avoid naming collisions in our system. We serve them asynchronously, by a temporary filestream.

### Tag Helpers

These allow us to map our Controllers and their verbs directly in markup of our pages. To take benefit of static type-checking, we pass our model DTO into each view. This ensures cohesion and avoids errors.

### Bootstrap

![alt text](https://github.com/Piterino/commapitut/blob/main/employeemgmtindex.png?raw=true)

Using a popular library for creating simple components

### Repository Pattern

Default to AspDotNet, allows for loose coupling between our data providers and inner logic.

### NLog logging

A popular library that allows us to create log files, to ease future debugging.
