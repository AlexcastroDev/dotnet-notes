# Introduction 

- Store a value in a variable.

```csharp
// Type name = value;
var number = 1;

// or
int number = 1;

// or
int number;
number = 1;
```

# Contants

- Store a value in a constant.
- The definition of a constant is given by the reserved keyword "const" before the type.
- If a value is not provided, the default value will be assigned.

```csharp
// const Type name = value;
const int AGE = 1;
```

### Considerations

Use meaningful names.

- Do not use special characters or spaces.
- Do not start with numbers.
- It is common to see constants in all uppercase letters, separated by underscores.
The idea is to glance at the code and know that it is a constant.

# Primitive Types / Built-in Types

Remarks
The primitive types are Boolean, Byte, SByte, Int16, UInt16, Int32, UInt32, Int64, UInt64, IntPtr, UIntPtr, Char, Double, and Single.

- Also known as built-in types.
- These are base types from which other (complex) types will derive.
- Defining the correct type optimizes program execution.
- They are referred to as Value Types.
- They store the value itself, not a reference to a memory item.

- They are classified into:

    -- Simple Types
    -- Enumerators (Enums)
    -- Structures (Structs)
    -- Nullable Types

example of null

```csharp
int? number = null;
```

All primitive types can be null.

# Alias

example of alias

```csharp
int number = 1; // alias
Int32 number = 1; // full name
```

# Default values

In C#, all built-in types have a default value.

int => 0
bool => false
char => '\0'
float => 0
double => 0
decimal => 0
string => ""

# Casting ( Implicit and Explicit )

## Implicit

- When the conversion is done automatically by the compiler.
- When there is no loss of information.

```csharp
int number = 1;
double number2 = number;
```

## Explicit

- When the conversion is done manually by the programmer.
- When there is loss of information.

```csharp
double number = 1.5;
int number2 = (int)number;
```

# Parse

- Convert a string to another type.

```csharp
string number = "1";
int number2 = int.Parse(number);
```

# Convert 

- Convert a string to another type.

```csharp
string number = "1";
int number2 = Convert.ToInt32(number);
```

```csharp

int number = 1;
float real = 25.5f;

real = number; // implicit => 100.0f
integer = (int)real; // explicit => 25
```

All variable have toString() method.

```csharp
int number = 1;
string text = number.ToString();
```


# Enums 

example of enum

```csharp

enum EEstadoCivil {
    Solteiro = 1,
    Casado = 2,
    Divorciado = 3,
    Viuvo = 4
}

EEstadoCivil estadoCivil = EEstadoCivil.Solteiro;
```