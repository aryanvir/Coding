# 												                   Cshrap - C#  Notes                                                            

# Data Types 

1. Strings - strings
2. Integers - int
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

int [] (variable name) = {(value 1), (value 2 ),.... };

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
# ####################################################################################################################################################################################################


# Methods or Functions 

__Syntax__:
static void nameOfTheMethod(Parameter)
{
	Action code ... 
}

__Example :__

static void Main(string[] args) main function/method like the python init function
	{
	    SayHi("Aryan",14); 
	}
	static void SayHi(string name , int age)
	{
	    Console.WriteLine($"Hello {name} you are {age}");
	}

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

__Exaple 2 with Return statement :__

static void Main(string[] args)
	{
	Console.WriteLine(Cube(5));
	  
	}
	static int Cube(int number)
	{
	int result = number * number * number;
	__return__ result; 
	}

# ####################################################################################################################################################################################################


# While Loop 

__Syntax__

while (condition)
{
    code to be executed;
}



__Example__

static void Main(string[] args)
        {
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

        }

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
static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }                    
        }



# Exception Handling 






# 			               	End Of Notes 																				   #