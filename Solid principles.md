
 ### Single Responsibility Principal
 
 * There should never be more than one reason for class change
 * Class should only have one job to preform
 
 Class can contain many methods and properties, but as long as they all relate to the same 
 responsibility they will align to this principle.
 
* Classes become smaller and cleaner. Number of classes will increase.
* Simpler to understand and maintain.


### Open / Closed Principal

* Class should be Open to extension, but Closed for modification

Classes should be design so that new requirements can be added (Open).
Once we developed class we should never need to modify it except to correct bugs (Closed)

* Use interfaces or abstract classes 
* Limits the need to change code once it has been tested and debugged
* Reduced risks o introducing new bugs
* Reduced coupling and increase flexibility


### Liskov Substitution Principal

* Use Derived classes without knowing it
* Subclasses must operate in the same manner as their base class

Functions that use pointers or reference to tbase classes must be able to use objects
of derived classes without knowing it.

Program has the ability to replace any instance (object) of a parent class
with an instnace of one of its's child classes without negative side effects.



