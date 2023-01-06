using Encoding;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Key value is -> 1000000000000");
long key = 100000000000;
string encoded = Base62.Encode(key);
long decode = Base62.Decode(encoded);
Console.WriteLine(encoded); // prints "0000C6WB"
Console.WriteLine(decode);


