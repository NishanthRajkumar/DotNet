# Static Tests
## Static Constructor Test
### * Static attributes/methods are executed only during the first new() call of the class
### * If there is a parameterized constructor and no parameterless constructor:
#### * Then cannot creat object of that class without giving parameters
#### * The default constructor provided by C# for any class is not valid here, since we overloaded the constructor
#### * To be able to create objects without giving parameters, parameterless constructor must be created
### * Execution order:
#### * Static attributes declaration are executed first, regardless of where they are positioned in the class
#### * Static constructor is executed after that
#### * Now non-Static attribute declarations are executed
#### * finally the default constructor or overloaded constructor
