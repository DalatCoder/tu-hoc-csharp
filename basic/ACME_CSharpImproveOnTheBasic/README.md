# Building good C# class

- Signature
- Fields
- Properties
- Constructors
- Methods

Class signature
Fields

- A variable in the class
- Holds the data

Methods

- Functions
- Behaviors and operations

Constructors

- Special method
- Executed     when instance is created
- Named with the class name
- Default constructor has no parameter

Namespace 

- Automatically added around every class

- Same name as the project

- Provide a unique address 

- Organize class into a logical hierarchy

- Best practices:
  
  - <company>.<technology>.<feature>
  
  - Acme.Wpf.Pm
  
  - Microsoft.Office.Interop.PowerPoint
  
  - Use PascalCasing

Static class

- Static keyword in the signature

- Only static members

- Can not instanctiate a static class

Define a singleton

- Provides only one instance

- Private constructor(s)

- Static property provides the one instance

- Instance accessed with User.Instance

- ```csharp
  public class User
  {
      private static User instance;
      private User() { }
      public static User Instance
      {
          get
          {
              if (instance == null)
                  instance = new User();
              return instance;
          }
      }
  }
  ```

References and Using Best Practices

- Take care when defining references

- **References must be one way**

- Take advantage of the using directive

Object Initialization

- Setting properties

- Parameterized constructor

- Object initializers

Object initialization Best Practices

- Setting Properties
  
  - When populating from database values
  
  - When modifying properties

- Parameterized Constructor
  
  - When setting the basic set of properties

- Object Initializers
  
  - When readability is important
  
  - When initializing a subset or superset of properties

Null Checking: Null-Conditional Operators

```csharp
var companyName = currentProduct?.ProductVendor?.CompanyName;
```

- ?. is the null-conditional operator

- If the variable on the left side is null, the expression is null

- If the variable on the left side is not null, then we continue with the dot

- "If null then null; if not then dot"

FAQs:

- What is the difference between an object and a class?
  
  - A class is a template that specifies the data and operations for an entity
  
  - An object is an instance of that class created at runtime using the new keyword

- What is lazy loading and when would you use it?
  
  - Instantiating related objects when they are needed and not before
  
  - This often involves creating the instance in the property getter for the related object