////Describe the strings in C#. What is typical for the string data type? 
////Describe the most important methods of the String class.

/*  
  Answer:

  Strings:

A string is traditionally a sequence of characters, either as a literal constant or as some kind of variable. 
The latter may allow its elements to be mutated and/or the length changed, or it may be fixed (after creation). 
A string is generally understood as a data type and is often implemented as an array of bytes (or words) that 
stores a sequence of elements, typically characters, using some character encoding. A string may also denote 
more general arrays or other sequence (or list) data types and structures.
A string is an object of type String whose value is text. Internally, the text is stored as a sequential read-only
collection of Char objects. There is no null-terminating character at the end of a C# string; therefore a C# string
can contain any number of embedded null characters ('\0'). The Length property of a string represents the number of
Char objects it contains, not the number of Unicode characters. To access the individual Unicode code points in a 
string, use the StringInfo object.
In C#, the string keyword is an alias for String. Therefore, String and string are equivalent, and you can use 
whichever naming convention you prefer. The String class provides many methods for safely creating, manipulating, 
and comparing strings. In addition, the C# language overloads some operators to simplify common string operations. 

  Methods of String class:
 
  - Compare(String, String) - Compares two specified String objects and returns an integer that indicates their  
relative position in the sort order.
  - Concat(Object) - Creates the string representation of a specified object.
  - Contains - Returns a value indicating whether the specified String object occurs within this string.
  - Copy - Creates a new instance of String with the same value as a specified String.
  - Equals(Object) - Determines whether this instance and a specified object, which must also be a String object, 
have the same value. (Overrides Object.Equals(Object).)
  - Format(String, Object) - Replaces one or more format items in a specified string with the string representation 
of a specified object.
  - IndexOf(Char) - Reports the zero-based index of the first occurrence of the specified Unicode character in this 
string.
  - Join(String, IEnumerable<String>) - Concatenates the members of a constructed IEnumerable<T> collection of type 
String, using the specified separator between each member.
  - Split(Char[]) - Returns a string array that contains the substrings in this instance that are delimited by 
elements of a specified Unicode character array.
  - ToCharArray() - Copies the characters in this instance to a Unicode character array.
  - Trim() - Removes all leading and trailing white-space characters from the current String object.
*/























class Null
{
    static void Main()
    {
    }
}