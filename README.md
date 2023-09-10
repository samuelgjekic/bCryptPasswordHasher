# bCrypt Password Hasher Example
This is a password hasher example that uses bCrypt to hash a password with a salt. 

It first generates the salt and then hashes both the salt and the password.

```c#
 // Returns a hash from password, the salt is automatically generated and added to the hash.
 string hashedPassword = encrypt.EncryptPassword(password); 
```


Feel free to use the example to try out bCrypt hashing and see if its right for your solution. 
