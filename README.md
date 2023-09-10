# bCrypt Password Hasher Example
This is a password hasher example that uses bCrypt to hash a password with a salt. 

It first generates the salt and then hashes both the salt and the password.


### Encryption Class
The **Encryption.cs** is a class i have made that includes most tools from bCrypts libraries.
It contains 2 methods for now, **EncryptPassword** and **VerifyPassword**

_EncryptPassword example:_
```c#
 // Returns a hash from password, the salt is automatically generated and added to the hash.
 string hashedPassword = encrypt.EncryptPassword(password); 
```
_VerifyPassword example:_
```c#
string verifyPassword; // Store the input password
string verifyHash; // Store the input hash

 // Returns true if password matched hash, returns false if password did not match the hash.
 bool isValid = encrypt.VerifyPassword(verifyPassword, VerifyHash); // Validate the password with the hash and return to bool
```


![hasher](https://github.com/samuelgjekic/bCryptPasswordHasher/assets/41647182/2fe95b6f-455a-4e78-bac0-abd84abf82c4)
_It creates a hash from password and salt using bCrypt_
![hasherverify](https://github.com/samuelgjekic/bCryptPasswordHasher/assets/41647182/af7619e1-d7cd-4435-ba04-2b4c786739d1)
_It can compare and validate a password and hash_

Feel free to use the example to try out bCrypt hashing and see if its right for your solution. 
