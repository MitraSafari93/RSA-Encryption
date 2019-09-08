# RSA-Encryption
Encrypt and  decrypt  a string with RSA algorithm
***********************

RSA is an algorithm used to encrypt and decrypt messages. You can read more in this link https://simple.wikipedia.org/wiki/RSA_algorithm.

You can initialize p & q value with two different large prime desirable numbers(in RSA.cs class).
The public key is n & e, and the private key is d.

n = p*q

Φ = (p - 1) * (q - 1) / GCD(p - 1, q - 1)

e = The smallest number that GCD(phi, e) is equal to 1

d = (k * phi + 1) / e

k = The smallest number ,Provided that (k * phi + 1) is divisible by e

## How to use?
There are 2 textbox in the program, you can entire a message in upper textbox and when you click the button you can see the encrypted message,
and when you click for the second time, you can see the ASCII code and your primitive message will returned and decrypted.

