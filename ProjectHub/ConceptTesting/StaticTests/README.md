## Static Tests
### Static Constructor Test Observations
- `static` attributes/methods are executed only during the first `new()` call of the class
- If there is a _parameterized_ constructor and no _parameterless_ constructor:
  - Then cannot create object of that class without giving parameters
  - The default constructor provided by C# for any class is not valid here, since we _overloaded_ the constructor
  - To be able to create objects without giving parameters, parameterless constructor must be created
- Execution order:
  - `static` attributes declaration are executed first, regardless of where they are positioned in the class
  - `static` constructor is executed after that
  - Now non-Static attribute declarations are executed
  - finally the _default_ constructor or _overloaded_ constructor
