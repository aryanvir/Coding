#                                                                  Cshrap - C#  Notes                                                            

# Data Types 

1. Strings -  strings 
2. Integers -  int 
3. Decimal - float , double , decimal 
4. Boolean - bool (True , False)
5. Charecter - char 
6. Array - [] 

# Comment 

// - is used for commenting single lines 

/* */* - is used for comenting multipule lines 

# Strings 

>>  sign is used for doing string formating 
>> [] is used for indexes 

# Number 

>> % mod operator - To find the Remainder 
>> 5 / 2 - Integer value 
>> 5/ 2.0 - Double / Decimal 

# Array 

__Syntax__ 

```csharp 
int [] (variable name) = {(value 1), (value 2 ),.... };
```

__Used to create empty array__

string [] (variable name) = new string[(no. of elements it will hold )] ;




# 2D Array

>> an array inside and array is 2d array 

__Syntax__

int[,] (variable name) = {{1,2,3},{4,5,6}};

__Used to create empty 2D array__

string [] (variable name) = new string[(no. of elements it will hold ), (number of elements the array inside of it will hold)] ; 


__Example__

int[,] numberGird = 
            {
                {1, 2, 3, },
                {4, 5, 6, },
                {7, 8, 9, },
                {8, 9, 10, },

            };
            Console.WriteLine(numberGird[0,0]);

# Functional operator (and , or )

>> && = and in C#
>> || = or in C#
>> ! = not in C#


# Switch Statements 

__Syntax__ :

switch(variableBeingSwitched)
{
    case senario:
        outputvariable = switchedvalue;
        break; *optional if you want to break out after switching*
    case ...
        out..
    default senario:
        outputvariable = defaultvalue;
}

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

__Example:__
```csharp
static void Main(string[] args)
        {
            Console.Write(" Enter Day Number :");
            int dayNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetDay(dayNum));

        }
        static string GetDay(int dayNum)
        {
            string dayName ;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }
```

# ####################################################################################################################################################################################################

#  Conditional Statements (if , else , else if)

__Syntax__:

if (Condition)
{
   Code to be executed
}
else
{
    Code to be executed 
}
else if (Condition)
{
    Code to be executed
}

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

__Example:__

```csharp
static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male ");
            } else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            } else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall");
            }
            else
            {
                Console.WriteLine("You are not male and not tall");
            }
```
# ####################################################################################################################################################################################################


# Methods or Functions 

__Syntax__:
static void nameOfTheMethod(Parameter)
{
    Action code ... 
}

__Example :__

```csharp
static void Main(string[] args) // main function/method like the python init function
    {
        SayHi("Aryan",14); 
    }
    static void SayHi(string name , int age)
    {
        Console.WriteLine($"Hello {name} you are {age}");
    }

```
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

__Exaple 2 with Return statement :__

```csharp
static void Main(string[] args)
    {
    Console.WriteLine(Cube(5));
      
    }
    static int Cube(int number)
    {
    int result = number * number * number;
    __return__ result; 
    }
```
# ####################################################################################################################################################################################################


# While Loop 

__Syntax__

while (condition)
{
    code to be executed;
}



__Example__
```csharp
static void Main(string[] args)
        {
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

        }
```
# Do while loop 

do
{
    code to be executed;  __In This loop the code is executed before checking the condition__
}while (condition);


# For Loop

__Syntax__ 

for(Declare variable ; Condition ; Code to be excuted)
{
    Code which needs to be excuted 
}

__Example__
```csharp
static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }                    
        }
```

# ###############################################################################################################################################################################

# Exception Handling 

__Syntax__

try
{
    Code you want to run
}
catch(Exception e)
{
    Error message
}

__Example__

```csharp
static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
         
        }

```
# Note : There is a _finally_ keyword which allows user to execute code no matter what the execption 

and the syntax for that is 

finally{
    code...
}



# ###############################################################################################################################################################################


# Classes and Objects 

__Syntax__

*Create a file in a new cs file with class template or add this bellow the code*

internal class ClassName
    {
        Attributes..  
    }

static void Main(string[] args)
        {
            ClassName book1 = new ClassName();
            book1.Attribute1 = "HarryPotter";
            book1.Attribute2 = "JK Rowling";
            book1.Attribute3 = 400;

            Console.WriteLine(book1.Attribute1);
            Console.WriteLine(book1.Attribute2);
        }

__Example__
```csharp
internal class Book
    {
        public string title;
        public string author;
        public int pages;

    }

static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "HarryPotter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
        }
```
# Constructors 


a function which is executed as the instance of the class is made , like the def __init__ function in python classes 


__Syntax__

public ClassName(Parameters the method takes in)
{

}

__Example__

*Class file*
```csharp

internal class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle,string aAuthor,int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

```
*Program file*
```csharp
static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter","JK Rowling",400);
            
            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);

```
# Note: The public Book() method is called when we create the object of the book class 

Book book 1 = new __Book()__ this the constructor method 

# ###############################################################################################################################################################################

# Object methods 

methods inside of the class which can be called upond

__Syntax__ is the same as any function or method in Csharp


__Example__

```csharp
internal class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string studentName, string studentMajor, double studentGpa)
        {
            name = studentName;
            major = studentMajor;
            gpa = studentGpa;

        }
```
__Is a object method__

```csharp

        public bool hasHonors()  
        {
            if(gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

```
# Getters and Setters

Now we use getter and setter to make our class and code more secure and safe . These are used when we dont a value of a parameter apart from the fixed values for example a movie rating can only be a fixed few not anything therefore we will use getters and setters here.

__Example__

```csharp

internal class Movie
    {
        public string title;
        public string director;
        private string rating;  
        <span style="color: green;"> 
            *Ratings should only be G, PG, PG-13, R, NR
            therefore the rating is private which will not allow other program to acces it*
        </span>

        public Movie(string movieTitle, string movieDirector, string movieRating)
        {
            title = movieTitle;
            director = movieDirector;
            Rating  = movieRating;

        }
        public string Rating 
        { 
            get { return rating; }
            set { 
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;

                }
                else
                {
                    rating = "NR";
                }; 
            }
        }
    }


```

#                           End Of Notes                                                                                   #
