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

# Primitive Types

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