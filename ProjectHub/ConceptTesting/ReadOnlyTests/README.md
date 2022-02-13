## Readonly tests
### Readonly attribute test observations
- Purpose of the test:
  - from the general outlook and output perspective, `constant` and `readonly` work the same way.
  - Then why the the need for readonly?
  - This test compares the observation of `readonly` with what we know about `constant`
- `readonly` vs `constant`:
  - `constant` must be assigned value at declaration. But `readonly` value can be set at constructor as well
  - According to online docs: `constant` value is set at compile time, but `readonly` can be set at runtime.
    - Visual studio allowed me to place break point on the line with `readonly` attribute
    - But did not allow me to place a break point on the line with `constant` attribute
    - Hence this proves the claim of the online docs
  - So `readonly` has advantage over `constant` if your program requires the constant value to be identified at runtime
  - Unlike `constant` which is static, `readonly` behaves like non-static but cannot be modified outside of constructor.
    - Very useful if we want to assign different constant values for different objects
- Value can be assigned at declaration in class. But that value can be modified at constructor.
