# bCrypt Password Hasher Example
This is a password hasher example that uses bCrypt to hash a password with a salt. 

It first generates the salt and then hashes both the salt and the password.

```c#
 // Returns a hash from password, the salt is automatically generated and added to the hash.
 string hashedPassword = encrypt.EncryptPassword(password); 
```
![hasher](https://github.com/samuelgjekic/bCryptPasswordHasher/assets/41647182/b7cca57b-fd13-4844-aed3-b973b1eff62f)
![hasherverify](https://github.com/samuelgjekic/bCryptPasswordHasher/assets/41647182/188b907b-47a6-4883-83a2-afbf87ce7b7f)

Feel free to use the example to try out bCrypt hashing and see if its right for your solution. 
