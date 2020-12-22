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

Data Encapsulation/ Information Hiding

- Object's data is only accessible to that object

- Fields are private

- Accessible outside of the class through property getters and setters

```csharp
private string description;
private int productId;
private string productName;
private Vendor productVendor;
```

Nullable Types

```csharp
private decimal? cost;
private DateTime? availablityDate;
```

- Allows definition of a value OR null

- Specified with a "?" suffix on the type

- Distinguishes "not set" from the default value

Nullable Type Best Practices

- Use on simple types to distinguish "not set" and "default value"

- Use properties of the type such as HasValue and Value as needed
  
  - ```csharp
    if (AvailablityDate.HasValue)
    {
        DateTime aDate = AvailabilityDate.Value;
    }
    ```

Constants

```csharp
public const double Pi = 3.14;
public const int Red = 0xFF0000;
public const double InchesPerMeter = 39.37;
```

- Defined in a class

- Holds a hard-coded value that does not change

- Must be assigned to an expression that can be fully evaluated at compile time
  
  - Think of a constant as a "compile-time" constant value

- Compiled into every location that references it

- Are static

Read-Only Fields

```csharp
public readonly decimal MinimumPrice;
public readonly string DefaultMeasure = GetDefaultMeasure();
public Product()
{
    MinimumPrice = RetrieveMinimumPrice();
}
```

- A variable in a class

- Holds a value that is initialized and then not changed

- Must be initialized:
  
  - In the declaration
  
  - Or in a constructor

- Think of a readonly fields as a "runtime" constant value

Constant vs. Read-Only

| Constant Field                                      | Read-only Field                             |
| --------------------------------------------------- | ------------------------------------------- |
| Compile-time constant                               | Runtime constant                            |
| Assigned to an expression evaluated at compile time | Assigned to any valid expression at runtime |
| Assigned on declaration                             | Assigned on declaration or constructor      |
| Only number, Boolean, or string                     | Any data type                               |
| Always static                                       | Optionally static                           |

FAQs

- Explain the data encapsulation principle
  
  - An object's data should be accessible only to the object
  
  - Backing fields containing the object data should be marked as private

- What is a backing field?
  
  - A variable in a class used to retain each object's data

- When should you use a backing field?
  
  - For every data field retained for an object

- When should you use a constant?
  
  - When defining a filed with a simple data type that will never change

- When should you use a readonly field?
  
  - When defining a field that is initialized from a file, table, or code but should not then be changed anywhere else in the application

Properties

```csharp
private string productName;

public string ProductName
{
    get { return productName; }
    set { productName = value; }
}
```

- Getter and setter functions

- Guard access to the fields

- Encapsulate the fields

Code in the Getter

- Check the user's credentials (admin, mod,...)

- Check application state

- Format the returned value

- Log

- Lazy loading

```csharp
private string productName;

public string ProductName
{
    get {
        var formattedValue = productName?.Trim();
        return formattedValue; 
    }
    set { productName = value; }
}

private Vendor productVendor;

public Vendor ProductVendor
{
    get 
    {
        if (productVendor == null)
            productVendor = new Vendor();
        return productVendor;
    }
    set { productVendor = value; }
}
```

Code in the Setter

- Check the user's credentials

- Check application state

- Validate the incoming value

- Log or change tracking

- Format, convert, clean up

```csharp
private string productName;
public string ProductName
{
    get {return productName; }
    set 
    {
        if (value.Length < 3)
            Message = "Too short";
        else
            productName = value;
    }
}
```

Auto-Implemented Properties

```csharp
public string Category { get; set; }
public int SequenceNumber { get; set; }
```

- Concise property declaration

- Implicit backing field

- Don't allow code in the getter or setter

- Best used for simple properties

Read-only auto implemented Properties

```csharp
public int InventoryCount { get; }
public Product()
{
    this.InventoryCount = GetInventoryCount();
}
```

Additional Uses of Properties

- Define concatednated values
  
  - ```csharp
    public string LastName {get; set;}
    public string FirstName {get; set;}
    
    public string FullName
    {
        get {return FirstName + " " + LastName;}
    }
    ```

- Calculations
  
  - ```csharp
    public int Quantity {get; set;}
    public int Price {get; set;}
    
    public int LineItemTotal
    {
        get {return Quantity * Price;}
    }
    ```

- Related Object Properties
  
  - ```csharp
    public int Vendor ProductVendor {get; set;}
    
    public string VendorName
    {
        get {return ProductVendor?.CompanyName;}
    }
    ```

Expression-Bodied Properties

- Syntax shortcut

- Readonly properties

- Immediately return a value

- ```csharp
  public string FullName => FirstName + " " + LastName;
  public int ItemTotal => Quantity * Price;
  public string VendorName => ProductVendor?.CompanyName;
  ```