## Week 4

### IdentityAuthApi
This api is created for auhthentication and authorization. If a user logins and get authenticated then this user can access **WebApi controllers**. 

##### Steps
* Created **Role** and **User** models.
* Created an in memory database.
* Not yet created a common repository which is genereic repository to avoid code repetitions for CRUD operations.
* Not yet User and role database operations.
* Not yet Done user and role controllers.

### Clean architecture
I tried to apply clean architecture to the other parts of this project. For this reason, i created following layers:
* Domain
    1. Models and Interfaces goes here
* Application
    1. All business operations 
* Insfrastructure
    1. Contexts and thirt party needs
* WebApi
    1. Restfullapi
