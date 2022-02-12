# Static Tests
## Static Constructor Test Observations
<ul>
  <li>
    Static attributes/methods are executed only during the first new() call of the class
  </li>
  <li>
    If there is a parameterized constructor and no parameterless constructor:
  </li>
  <ul>
    <li>
      * Then cannot creat object of that class without giving parameters
    </li>
    <li>
      * The default constructor provided by C# for any class is not valid here, since we overloaded the constructor
    </li>
    <li>
      * To be able to create objects without giving parameters, parameterless constructor must be created
    </li>
  </ul>
  <li>
    Execution order:
  </li>
  <ul>
    <li>
      * Static attributes declaration are executed first, regardless of where they are positioned in the class
    </li>
    <li>
      * Static constructor is executed after that
    </li>
    <li>
      * Now non-Static attribute declarations are executed
    </li>
    <li>
      * finally the default constructor or overloaded constructor
    </li>
  </ul>
</ul>
