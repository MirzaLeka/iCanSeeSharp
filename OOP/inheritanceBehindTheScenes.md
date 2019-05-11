
## Inheritance

Let's say we have a list of **Person** class and there is also **Customer** class,
which inherits Person class.

```
class Person{}

class Customer : Person{}
```

Since Customer is a Person, all properties we give to Person class, 
except those that are private, will be available in Customer class.

**But that's not all!**

If we create a list of type Person ```List<Person>``` we can swap Person class
with a generic type Customer, since Customer class inherits Person: ```List<Customer>```.

Furthermore, we can have method type **ActionResult** and return a **View**, 
because **View** inherits **ViewItem** and ViewItem inherits **ActionResult**.

**IQueryable** inherits from **IEnumerable** and thus when creating a method
type of **IQueryable**, we can return items which will be **IEnumerable**. 

Arrays also inherit IEnumerable, so we can print an array using IEnumerator as seen here:

https://github.com/MirzaLeka/iCanSeeSharp/blob/master/Collections/Enumerable.cs

Unlike arrays, Enumerators can print data long before data is loaded, thus Enumerators don't
have Length property. They are basically used for retrieving large amount of that very fast.

Since it inherits IEnumerable, IQueryable is almost completely the same, 
but where IEnumerable lacks is in working with RDBs and it has greater trafficking,
so between the two, IQueryable is often a better approach.
