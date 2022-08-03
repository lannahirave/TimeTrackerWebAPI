# TimeTrackerWebAPI

General information:
Implement simple API application (no UI) that could help to track time for employees of small
company.

Employee should be able to track his/her daily activities which are based on project (eg.
Project_1, Project_2), activity type (eg. Regular work, Overtime), Role (eg. Software Engineer,
Business Analyst).

• “Project” contains Name, Date start, Date end

• “Activity type” contains Name

• “Role” contains Name

• “Employee” contains Name, Sex, Birthday

• “Activity” contains all necessary fields to output information (see the example below).


For example, 25.06.2022 as a "Software Engineer" [Role] I worked on the "Project_3" [Project] 8
hours regular work [activity type] but 26.06.2022 as a "Software Architect" [Role] I worked on
the "Project_2" [Project] 2 hours overtimes [activity type] and 6 hours as a "team lead" [Role]
on the "Project_1" [Project] regular work [activity type].

It is possible to track different activities on the same day.


Tech requirements:
Stack of technologies:
- .NET Core/ 5+
- Entity Framework or Dapper as ORM
- MS SQL Server
- Best practices (SOLID, IoC containers, Restful) nice to have
- Swagger set up nice to have
- Logging (Serilog and etc.) in Console or DB
- No constraints regarding to packages\libraries\projects amoun
