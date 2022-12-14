# 0x06. C# - Classes and Namespaces
## Tasks

### 0. Braaainsss

Create a new namespace  `Enemies`. Create an empty public class  `Zombie`  within  `Enemies`  that defines a zombie.

#### Expected output using [`0-main.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x06-csharp-classes/0-enemy/0-main.cs):

```
Titania792@ubuntu:~/0x06-csharp-classes/0-enemy$ ls
0-enemy.cs  0-enemy.csproj  0-main.cs  bin  obj
Titania792@ubuntu:~/0x06-csharp-classes/0-enemy$ dotnet run
newObject is of type Enemies.Zombie
String representation: Enemies.Zombie
Titania792@ubuntu:~/0x06-csharp-classes/0-enemy$ 

```

-   Directory:  [`0-enemy/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x06-csharp-classes/0-enemy)
-   File:  [`0-enemy.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x06-csharp-classes/0-enemy/0-enemy.cs)

### 1. Healthy competition

Based on  `0-enemy`, write a public class  `Zombie`  that defines a zombie by:

-   public field  `health`
-   `health`  should be an int and have no value
-   public constructor:  `public Zombie()`
    -   sets the value of  `health`  to  `0`

#### Expected output using [`1-main.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x06-csharp-classes/1-enemy/1-main.cs):
```
Titania792@ubuntu:~/0x06-csharp-classes/1-enemy$ ls
1-enemy.cs  1-enemy.csproj  1-main.cs  bin  obj
Titania792@ubuntu:~/0x06-csharp-classes/1-enemy$ dotnet run
newObject is of type Enemies.Zombie and has a total of 0 health
Titania792@ubuntu:~/0x06-csharp-classes/1-enemy$ 

```

-   Directory:  [`1-enemy/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x06-csharp-classes/1-enemy)
-   File:  [`1-enemy.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x06-csharp-classes/1-enemy/1-enemy.cs)

### 2. Health validation

Based on  `1-enemy`, write a public class  `Zombie`  that defines a zombie by:

-   public field  `health`
-   `health`  should be an int and have no value
-   public constructor:  `public Zombie()`
    -   sets the value of  `health`  to  `0`
-   a new public constructor:  `public Zombie(int value)`
    -   `value`  must be greater than or equal to 0
    -   if  `value`  is less than 0, throw an  `ArgumentException`  with the message  `Health must be greater than or equal to 0`

#### Expected output using [`2-main.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x06-csharp-classes/2-enemy/2-main.cs):

```
Titania792@ubuntu:~/0x06-csharp-classes/2-enemy$ ls
2-enemy.cs  2-enemy.csproj  2-main.cs  bin  obj
Titania792@ubuntu:~/0x06-csharp-classes/2-enemy$ dotnet run
newObject1 is of type Enemies.Zombie and has a total of 10 health
Health must be greater than or equal to 0
Titania792@ubuntu:~/0x06-csharp-classes/2-enemy$ 

```

-   Directory:  [`2-enemy/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x06-csharp-classes/2-enemy)
-   File:  [`2-enemy.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x06-csharp-classes/2-enemy/2-enemy.cs)

### 3. Zombie health

Based on  `2-enemy`, write a public class  `Zombie`  that defines a zombie by:

-   **private**  field  `health`
-   `health`  should be an int and have no value
-   public constructor:  `public Zombie()`
    -   sets the value of  `health`  to  `0`
-   public constructor:  `public Zombie(int value)`
    -   `value`  must be greater than or equal to 0
-   public method  `public int GetHealth()`  that returns the value of health of the Zombie object

#### Expected output using [`3-main.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x06-csharp-classes/3-enemy/3-main.cs):

```
Titania792@ubuntu:~/0x06-csharp-classes/3-enemy$ ls
3-enemy.cs  3-enemy.csproj  3-main.cs  bin  obj
Titania792@ubuntu:~/0x06-csharp-classes/3-enemy$ dotnet run
newObject1 is of type Enemies.Zombie and has a total of 10 health
newObject2 is of type Enemies.Zombie and has a total of 98 health
Titania792@ubuntu:~/0x06-csharp-classes/3-enemy$ 

```

-   Directory:  [`3-enemy/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x06-csharp-classes/3-enemy)
-   File:  [`3-enemy.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x06-csharp-classes/3-enemy/3-enemy.cs)


### 4. Hello, my name is

Based on  `3-enemy`, write a public class  `Zombie`  that defines a zombie by:

-   private field  `health`
-   `health`  should be an int and have no value
-   public constructor:  `public Zombie()`
    -   sets the value of  `health`  to  `0`
-   public constructor:  `public Zombie(int value)`
    -   `value`  must be greater than or equal to 0
-   private field  `name`
-   `name`  should be a string and have a default value of  `(No name)`
-   public property  `Name`
    -   `get`: retrieve name
    -   `set`: set name
-   public method  `public int GetHealth()`  that returns the value of health of the Zombie object

#### Expected output using [`4-main.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x06-csharp-classes/4-enemy/4-main.cs):

```
Titania792@ubuntu:~/0x06-csharp-classes/4-enemy$ ls
4-enemy.cs  4-enemy.csproj  4-main.cs  bin  obj
Titania792@ubuntu:~/0x06-csharp-classes/4-enemy$ dotnet run
Ed is of type Enemies.Zombie and has a total of 10 health
(No name) is of type Enemies.Zombie and has a total of 98 health
Titania792@ubuntu:~/0x06-csharp-classes/4-enemy$ 

```

-   Directory:  [`4-enemy/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x06-csharp-classes/4-enemy)
-   File:  [`4-enemy.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x06-csharp-classes/4-enemy/4-enemy.cs)

### 5. Printing a zombie

Based on  `4-enemy`, write a public class  `Zombie`  that defines a zombie by:

-   private field  `health`
-   `health`  should be an int and have no value
-   public constructor:  `public Zombie()`
    -   sets the value of  `health`  to  `0`
-   public constructor:  `public Zombie(int value)`
    -   `value`  must be greater than or equal to 0
-   private field  `name`
-   `name`  should be a string and have a default value of  `(No name)`
-   public property  `Name`
    -   `get`: retrieve name
    -   `set`: set name
-   public method  `public int GetHealth()`  that returns the value of health of the Zombie object
-   public  `.toString()`  override that prints the Zombie object’s attributes to stdout
    -   Format:  `Zombie Name: <name> / Total Health: <health>`  

#### Expected output using [`5-main.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x06-csharp-classes/5-enemy/5-main.cs):
```
Titania792@ubuntu:~/0x06-csharp-classes/5-enemy$ ls
5-enemy.cs  5-enemy.csproj  5-main.cs  bin  obj
Titania792@ubuntu:~/0x06-csharp-classes/5-enemy$ dotnet run
Zombie Name: Ed / Total Health: 10
Zombie Name: (No name) / Total Health: 98
Titania792@ubuntu:~/0x06-csharp-classes/5-enemy$ 

```

-   Directory:  [`5-enemy/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x06-csharp-classes/5-enemy)
-   File:  [`5-enemy.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x06-csharp-classes/5-enemy/5-enemy.cs)