# MSC refactoring interview
Refactoring session with SOLID principles

## How To
To be able to calculate the discount for a customer type, the discount object 
must be configured with the various calculation rules.

 ```csharp
 Discount disc = new Discount();

            disc.Add(Customer.Type.Unregistered, new Type1Calculator());
            disc.Add(Customer.Type.Registered, new Type2Calculator());
            disc.Add(Customer.Type.Valuable, new Type3Calculator());
            disc.Add(Customer.Type.MostValuable, new Type4Calculator());

            disc.SetCalculator(Customer.Type.Valuable);

            decimal result = disc.GetCalculator().Calculate(-10, -20);
```

## Additional info
A whole system could be built around the discount calculation system, in fact the Customer class does not respect SOLID principles. If you want to add a new type of customer you have to change the main class by having to change the enum.

But the the completeness of this project is not the subject of this review.