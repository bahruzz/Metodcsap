//// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");

//using System.ComponentModel.Design;

//void showtext()
//{
//    Console.WriteLine("welcome pb101");

//}
////showtext();

//void sum()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    Console.WriteLine(sum);
//}
////sum();




//int SumOFNumbers()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    return sum;

//}


////int result=SumOFNumbers();
//Console.WriteLine(result);


//string SumOFNumbers()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    return "salam";

//}


//string result = SumOFNumbers();
//Console.WriteLine(result);



//string SumOFNumbers()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    string res = $"sum of number is - {sum}";
//    return res;

//}


//string result = SumOFNumbers();
//Console.WriteLine(result);

//void SumOfEvenNumbers()
//{
//    int[] elems = { 1, 2, 3, 4, 56 };
//    int sum = 0;
//    foreach (var item in elems)
//    {
//        if (item%2==0)
//        {
//            sum += item;
//        }
//    }
//    Console.WriteLine(sum);
//}
//SumOfEvenNumbers();


//void ShowText(string text)
//{
//    Console.WriteLine(text);
//}

//ShowText("salam");
//ShowText("azerbaycan");


//void ShowText(string text)
//{
//    Console.WriteLine(text);
//}
//bool IsMarried = true;
//if (IsMarried)
//{
//    ShowText("salam");

//}
//else
//{
//    ShowText ("Azerbaycan");
//}



//void Sum(int num1, int num2)
//{

//    int sum = num1 + num2;
//    Console.WriteLine(sum);
//}

//Sum (100,200);


//void SumOfEvenNumbers(int[] elems, int number)
//{

//    int sum = 0;
//    foreach (var item in elems)
//    {
//        if (item % 2 == 0)
//        {
//            sum += item;
//        }

//    }
//    int result = sum + number;
//    Console.WriteLine(result);
//}


//int [] nums ={ 1,2,3,4,5};
//SumOfEvenNumbers(nums,100);



//int SumOfEvenNumbers(int[] elems, int number)
//{

//    int sum = 0;
//    foreach (var item in elems)
//    {
//        if (item % 2 == 0)
//        {
//            sum += item;
//        }

//    }
//    int result = sum + number;
//    return result;

//}
//int[] nums = { 1, 2, 3, 4, 5 };

//var result = SumOfEvenNumbers(nums, 100);

//    Console.WriteLine(result);


//Console.WriteLine("add your name");
//string name = Console.ReadLine();
//Console.WriteLine(name);


//Console.WriteLine("add your name");

//string name = Console.ReadLine();

//Console.WriteLine("add your surname");

//string surname= Console.ReadLine();

//Console.WriteLine(name +  "-"  +  surname);


//Console.WriteLine("Add first number");

//int num1=int.Parse(Console.ReadLine());

//Console.WriteLine("Add second number");

//int num2=int.Parse(Console.ReadLine()); 

//int result=num1+num2;

//Console.WriteLine(result);


//using System.Globalization;

//int[] GetDatas(int num1, int num2, params int[] nums)
//{
//    return nums;

//}
//var result = GetDatas(1, 2, 3, 4, 5, 6);
//foreach (var item in result)
//{
//    Console.WriteLine(item);





//int SumOfDatas(int num1, int num2, params int[] nums)
//{
//    int SumNumbers = num1 + num2;
//    int SumOfArrayItems = 0;

//    foreach (var item in nums)
//    {
//        SumOfArrayItems += item;
        
//    }
//    int result=SumNumbers+SumOfArrayItems;

//    return result;
//}

//var result = SumOfDatas(1, 2, 3, 4, 5, 6);

//Console.WriteLine(result);


//string GetName(string name= "XXX")
//{
//    return name;
//}
//Name: string name=Console.ReadLine();
//if (name=="")
//{
//    Console.WriteLine(GetName());
//}
//else
//{
//    Console.WriteLine(GetName(name));
//}



//string Login(string username, string password)
//{
//    if (username == "Cavid123" && password == "Cavid123_")
//    {
//        return "Login successful";
//    }
//    else
//    {
//        return "Email or password wrong";
//    }
       
//}
//Console.WriteLine("Username: ");

//string UserName=Console.ReadLine();

//Console.WriteLine("Password: ");

//string password =Console.ReadLine();

//string result=Login(UserName, password);

//Console.WriteLine(result);

