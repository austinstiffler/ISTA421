#### C# Chapter 19 Homework
#### Austin Stiffler
#### 21 March, 2021
---

1. An *enumerable collection* is a collection that implements the System.Collections.IEnumerable interface.

1. The IEnumerable interface contains a single method called GetEnumerator.

1. The IEnumerator interface contains the Current property, MoveNext method, and Reset method.

1. The MoveNext() method moves the pointer down to the next item in the list. It will return true if there is another item and false if there is not.

1. The Reset() method returns the pointer back to before the first item in the list.

1. The IEnumerable and IEnumerator interfaces are type safe. They are defined in the System.Collections.Generic namespace.

1. Recursive algorithms do not lend themselves to maintaining state information between method calls in an easily accessible manner.

1. Create a class that will generate an enumerator. You must then provide a type parameter and implement the IEnumerator interface.

1. An *iterator* is a block of code that yields an ordered sequence of values.

1. *Yield* indicates the value that should be returned by each iteration.