
### Many ways to import class 
* Using className;
* Project / new file, fileName => make sure you choose the same solution
* Just right click on solution (on the right), go add class and name the class 

### Import class from another project
Once you create a new project and a class, in both cases you will need to
go to the main class right click on reference (on the right),
go to reference and find the class you just created (in new project) and mark it => click on it

* Then (bad practice) simply add the same namespace name in new class as it is in the original
* Or keep different namespaces, but import the other class into main one using Using followed by
the name of the file 

If we have multiple classes with the same class names we wouldn't write Using fileName like above,
instead we would write namespace.className 
```Example:
Main{
MyNameSpace.MyClass myObj = new MyNameSpace.MyClass(); // consructor;
MyNameSpace2.MyClass myObj2 = new MyNameSpace2.MyClass();
}

```
