# Requirements

- Dotnet SDK 7 is required for running the services.

## Usage

1. Open a terminal.
2. Navigate to the root directory of the solution.
3. Run the following command to start the services:

```bash
./run.bat
```
## Description

Within this repository, you will find two distinct services: `FruitService` and `ConsumerService`, each serving a specific role.

### FruitService

- Access Swagger Documentation: [http://localhost:5003/swagger/index.html](http://localhost:5003/swagger/index.html)
- Available Endpoints:
  - GET `/Fruit`: Retrieve a list of fruits.
  - GET `/Fruit/{id}`: Retrieve detailed information about a specific fruit.

### ConsumerService

- Access Swagger Documentation: [http://localhost:5191/swagger/index.html](http://localhost:5191/swagger/index.html)
- Available Endpoints:
  - GET `/Consumer`: Fetch consumer-related information.
  - GET `/Consumer/{id}`: Retrieve detailed information about a specific consumer.

The interaction between these two services involves `ConsumerService` utilizing the endpoints provided by `FruitService` to accomplish its designated tasks.