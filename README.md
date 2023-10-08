# Final Degree Project - Programming II

This is the final degree project of the Programming II subject. The project is divided into four points, aimed at testing the programming skills acquired throughout the course. The last three points, which form the development aspects of the project, are described as follows:

- Point #1: Investigation and personal opinionl.
- Point #2: Create a program to determine an employee's net salary.
- Point #3: Create a form to simulate the operation of an invoice.
- Point #4: Create a login and integrate it into the previous points.

## Table of contents

- [Final Degree Project - Programming II](#final-degree-project---programming-ii)
  - [Table of contents](#table-of-contents)
  - [Screenshots](#screenshots)
  - [Installation](#installation)
  - [Usage](#usage)
  - [Contributing](#contributing)
    - [Requirements](#requirements)
    - [First steps](#first-steps)
    - [License](#license)

## Screenshots
| | |
|:-------------------------:|:-------------------------:|
|<img src="./assets/login.png" alt="Login" style="width:100%">|<img src="./assets/welcome.png" alt="Salary" style="width:100%">|
|<img src="./assets/neto-calc.png" alt="Invoice" style="width:100%">|<img src="./assets/invoice.png" alt="Invoice" style="width:100%">|

## Installation

1. Dowload the zip file from here: [Download](https://github.com/isaacismaelx14/finalDegreeProjectP2/releases/download/1.0.0/final-project_1.0.0.zip)

2. Unzip the file.
3. Open the folder and run the `setup.exe` file.
4. Follow the installation steps.

## Usage

1. Open the program.
2. Enter the username and password. If you don't have an account, you can use guest credentials:
    - Username: `guest`
    - Password: `guest123`
3. Use the program.

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

### Requirements
- [PostgreSQL](https://www.postgresql.org/download/)
- [Visual Studio](https://visualstudio.microsoft.com/es/downloads/)
- [Npgsql](https://www.npgsql.org/doc/index.html)


### First steps

1. Clone the repository.
2. Create a new branch with the name of the feature you want to add.
3. Setup the `App.config` file with the following code:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>
    <add key="ConnectionString" value="Host=HOST;Port=PORT;Database=DATABASE;Username=USERNAME;Password=PASSWORD;"/>
    </appSettings>
</configuration>
```

4. Replace the values with your own credentials.

### License

[MIT](LICENSE)
