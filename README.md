# ProtoType Design Pattren => Creational

Gang of Four Definition : "Prototype Design Pattern Specify the kind of objects to create using a prototypical instance, and create new objects by copying this prototype"

To simplify, instead of creating object from scratch every time, you can make copies of an original instance and modify it as required. 

Prototype is unique among the other creational patterns as it doesn't require a class but only an end object. 

We need to choose Prototype Design Pattern when 
1. Creating an object is an expensive operation and it would be more efficient to copy an object.
2. System should be independent of how its products are created, composed, and represented.
3. Objects are required that are similar to existing objects.
4. We need to hide the complexity of creating new instance from the client.

Shallow and Deep Copy : The idea of using copy is to create a new object of the same type without knowing the exact type of the object we are invoking. 

Shallow Copy : copies an object's value type fields into the target object and the object's reference types are copied as references into the target object. 

Deep Copy : Deep Copy copies an object's value and reference types into a complete new copy of the target objects. 

//////////////////////
Significance of Copying 

1. The idea of using copy is to create a new object of the same type without knowing the exact type of the object we are invoking

2. Shallow Copy and Deep copy plays prominent role in copying the objects in Prototype Design Pattern

3. Creating the required object once and by creating the subsequent required objects by cloning helps reducing the time for creating the objects

4. With Prototype design pattern, based on the requirement situations we can save memory by cloning the objects
Example : Adapting to clone an object which consists of many strings (immutable) is a good idea than creating an object

MemberwiseClone and ICloneable Interface

MemberwiseClone Method : 
1. The MemberwiseClone method is part of system.object and creates a shallow copy of the given object.

2. MemberwiseClone Method copies the nonstatic fields of the chosen object to the new object.

3. In the process of copying, if a field is a value type, a bit by bit copy of the field is performed. If a field is reference type, the reference is copied but the referenced object is not.

ICloneable Interface :
1. The ICloneable interface provides with a customized implementation that creates copy of an existing object.

2. The ICloneable interface contains one member, the clone method, which is intended to provide support beyond MemberwiseClone method.
