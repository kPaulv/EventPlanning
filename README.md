# EventPlanning Web App

### Test task for BTC


There are admin and basic user parts.

#### Admin features:

User(admin role) creates an event of a custom type with a custom set of fields for a specific date and time, e.g.: 

 1. [Name: Football match, Topic: Sport, Location: Richard st. 77],
 2. [Name: test event 2, Dreescode: mandatory, Topic: Music, Subtopic: Rock, Subtopic: Classical music, Participants: Singers, Location: Birmingham]

#### User features:

User (ordinary) can register and apply for existing event.


### TODO list:
#### Level 1:
+         Registration via e-mail.
#### Level 2:
+         Event creator can limit participants amount.
+         After registration and logging in User has to provide additional info about himself.
#### Level 3:
+         Registration via SMS or EDS.
+         After registration and logging in User has to provide additional info via ".xls" or ".pdf" profile.
#### Level 4:
+         The number of users is large and increases during peak times, e.g. 5 unique users per second, 100 per minute.
+         Propose a solution for optimizing and building the application architecture to achieve acceptable page response time (<1 sec)


 ### Stack
 + ASP.NET CORE MVC
 + .NET 6
 + MS SQL
