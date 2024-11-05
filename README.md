# EmployeeAdminPortal

## Overview
This project is an ASP.NET Core Web API for managing employee and customer data in an organizational context(Microsot Dynamics Business Central). It utilizes JWT (JSON Web Tokens) for secure authorization, enabling different access levels based on user roles.

## Features
- **Employee Management(Custom DB)**: CRUD operations for employee records using DTOs (Data Transfer Objects) such as `AddEmployeeDto` and `UpdateEmployeeDto` for adding and updating employee details.
- **Customer Management(BC)**: Retrieve and create customer data with role-based access control.
- **Authorization**: Access to endpoints is restricted based on user roles (Admin and User) using JWT authentication.

## Endpoints
- **AccountController**:
  - `POST api/account/register`: Registers a new user.
  - `POST api/account/login`: Authenticates a user and returns a JWT token.
  - `POST api/account/add-role`: Adds a new role (Admin only).
  - `POST api/account/assign-role`: Assigns a role to a user (Admin only).
- **EmployeeController**: 
  - `GET api/employee`: Retrieves all employees (Admin only).
  - `GET api/employee/{id}`: Retrieves an employee by ID (Admin only).
  - `POST api/employee`: Adds a new employee.
  - `PUT api/employee/{id}`: Updates an existing employee by ID.
  - `DELETE api/employee/{id}`: Deletes an employee by ID.

- **CustomerController**:
  - `GET api/customer`: Retrieves all customers (Admin and User).
  - `GET api/customer/{id}`: Retrieves a customer by ID (Admin and User).
  - `POST api/customer`: Creates a new customer (Admin only).
 
 - **KcbController**:
  - `GET api/kcb/token`: Fetches an authentication token from the KCB service.
    - **Parameters**:
      - `username` (query): The username for KCB service authentication.
      - `password` (query): The password for KCB service authentication.
    - **Returns**: JSON response containing:
      - `access_token`: The token used for further authentication.
      - `token_type`: Type of the token (e.g., Bearer).
      - `expires_in`: Expiration time in seconds for the token.

## Authentication
JWT is used for authentication, ensuring that users are authorized to access specific endpoints based on their assigned roles. The configuration for JWT is done in the `Startup` class, where token validation parameters are defined.

## How to Run
1. Clone the repository.
2. Set up the database connection string in the `appsettings.json`.
3. Run the application
4. Use Swagger UI/Postman for testing the API endpoints.

## Note
- Ensure that the JWT tokens are correctly implemented in your authentication flow for secure access.
- Ensure you Modify all BC URLs in `CustomerController`
- In Swagger UI, After the token is generated (in /login endpoint), remember to add `Bearer` before to token in Authorize Action.
- Assign roles before Testing(Remove the Admin authorization from `POST api/account/assign-role`, `POST api/account/add-role`)
