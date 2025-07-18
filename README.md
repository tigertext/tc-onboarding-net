# Practice Project: Clean Code and SOLID Design Principles in C#

Welcome to the practice repository for Clean Code and SOLID design principles in C#! In this project, you will focus on learning and applying fundamental concepts of object-oriented programming and best practices for writing clean code in the context of the C# programming language.

## Project Objectives

The main goal of this repository is to enhance your C# programming skills through understanding and applying the following aspects:

1. **Clean Code**: We will learn to write clean and readable code, following the guidelines and recommendations of Robert C. Martin in his book "Clean Code." We will explore techniques and practices to enhance the quality and maintainability of our code.

2. **SOLID Design Principles**: We will delve into the five SOLID design principles proposed by Robert C. Martin for designing more maintainable, scalable, and flexible software. These principles are:
   - **S** - Single Responsibility Principle (SRP)
   - **O** - Open/Closed Principle (OCP)
   - **L** - Liskov Substitution Principle (LSP)
   - **I** - Interface Segregation Principle (ISP)
   - **D** - Dependency Inversion Principle (DIP)

## Repository Structure

The repository will be organized as follows:

- **`TcAPI/`**: This folder will contain the source files of our C# project. We will implement examples and exercises related to Clean Code and SOLID design principles here.
- **`TcAPI.Test/`**: This folder will contain the Unit Test files of TcAPI project based on XUnit.

## Contributions

Contributions are welcome! If you'd like to participate in this project, you can follow these steps:

1. Clone this repository to your local.
2. Create a branch with a descriptive name for your contribution.
3. Make your changes and improvements in the branch.
4. Submit a pull request so that we can review your changes and merge them into the main project.

## Recommended Resources

Here are some resources that can help you understand and apply the concepts of Clean Code and SOLID Design Principles:

- Book: "Clean Code: A Handbook of Agile Software Craftsmanship" by Robert C. Martin.
- Article: "The SOLID Principles in Real Life" by Dhananjay Kumar on dev.to.
- [Official C# documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Best practices for RESTful web API design](https://learn.microsoft.com/en-us/azure/architecture/best-practices/api-design)
- [Swagger - Best Practices in API Design](https://swagger.io/resources/articles/best-practices-in-api-design/)

## Let's Get Started!

We hope this repository serves as a useful tool to enhance your C# programming skills and your understanding of Clean Code and SOLID design principles!

1. Download the .zip file of this repository.
2. Using your TigerConnect GitHub account, create a new private repository (your username will be the owner) and share this private repo with your team.
3. You have to copy the project you just downloaded to your personal repository. Please version all the same files and do not forget to add the hidden files (for example, the .gitignore file).
4. Create a branch with a descriptive name for your coding exercise.
5. Work the corresponding coding exercise in your branch, follow the next instructions:\
   **Context:** TigerConnect(TC) is developing a RESTful API to support Create and Read operations on three primary business entities: Users, Organizations, and Roles. Currently, our Users API only supports GET Users.\
   You are required to implement the following tickets:
   
   - [ ] **USR-1:** As a TC client, I want to be able to query the TC's account information linked to a user identified by a non-empty alphanumeric string in our User Directory provider and not by using the TC's ID
      - Bug: The client is getting a Format Exception when requesting a user account by its external user ID.
      - Enhancement: Implement a practical but efficient way to return the actual static data instead of the current response while keeping the business rules for filtering results based on the internal ID.
      - Bonus: Improve the Users API contract where responses are mapped to JSON strings instead of plain text.
      - Acceptance criteria:
         - When the resource does not exist in TC, then the client should receive a Not Found response.
         - When the resource exists, the client should receive a Success response with the corresponding user information.
         - An alphanumeric resource identifier should be valid.
         - The code must be compliant with the C# Naming Conventions, Programming Best Practices, and REST API Best Practices.
         - A minimum of 70% Code Coverage.
       
   - [ ] **USR-2:** As a TC client, I want to be able to create Organizations and assign users to those organizations using POST requests; these requests will have the following information:
   - Organization Name: Alphanumeric string up to 100 characters.
   - List of users in the organization: Same information returned by the Users API.
      - Acceptance criteria:
         - Organizations must be identified by a unique numeric identifier in TC's system.
         - Each organization can have zero, one, or more users in the payload request.
         - A user can belong to zero, one, or more organizations.
   
7. When you complete an exercise, please submit a pull request so that we can review your changes and give you any feedback.

Let's embark on your journey to write more solid and clean code at Tiger Connect! Explore the sample code, experiment, and feel free to share your learnings and accomplishments in the repository. Together, we can improve our skills and create higher quality software.

Happy coding! 👨‍💻👩‍💻
