namespace Task2_BackEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Task 2:

            #region Question 1:

            //Console.WriteLine("Enter the number:");
            //int num = Convert.ToInt32(Console.ReadLine());


            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;

            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;

            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;

            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;

            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;

            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;

            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;

            //    default:
            //        if (num < 1 || num > 7)
            //        {
            //            Console.WriteLine("Invalid day number");
            //        }
            //        break;

            //}
            #endregion


            #region Question 2:

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{number} x {i} = {number * i}");
            //}

            #endregion

            #region Question 3:

            //Console.Write("Enter a positive number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number <= 0)
            //{
            //    Console.WriteLine("Please enter a positive number");
            //}
            //else
            //{
            //    while (number >= 1)
            //    {
            //        Console.WriteLine(number);
            //        number--;
            //    }

            //    Console.WriteLine("Go!");
            //}
            #endregion

            #region Question 4:

            //Console.Write("Enter month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());

            //switch (month)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Winter");
            //        break;

            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Spring");
            //        break;

            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Summer");
            //        break;

            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("Autumn");
            //        break;

            //    default:
            //        if (month < 1 || month > 12)
            //        {
            //            Console.WriteLine("Invalid month number");
            //        }
            //        break;
            //}
            #endregion

            #region Question 5:

            //Console.Write("Enter a positive number : ");
            //int N = int.Parse(Console.ReadLine());

            //int evenNum = 0;
            //int oddNum = 0;

            //for (int i = 1; i <= N; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        evenNum += i;
            //    }
            //    else
            //    {
            //        oddNum += i;
            //    }
            //}

            //Console.WriteLine("Sum of Even Numbers = " + evenNum);
            //Console.WriteLine("Sum of Odd Numbers = " + oddNum);
            //}
            #endregion

            #region Question 6 :


            //string correctPassword = "1234";
            //string password = "";
            //int attempts = 0;

            //while (password != correctPassword)
            //{
            //    Console.Write("Enter password: ");
            //    password = Console.ReadLine();
            //    attempts++;

            //    if (password == correctPassword)
            //    {
            //        Console.WriteLine("Access Granted");
            //    }
            //    else if (attempts == 3)
            //    {
            //        Console.WriteLine("Account Locked");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong password, try again");
            //        Console.WriteLine("Attempts remaining: " + (3 - attempts));
            //    }
            //}

            #endregion


            #region Question 7 :

            //    double num1, num2, result;
            //    string op;

            //    while (true)
            //    {
            //        Console.Write("Enter first number: ");
            //        num1 = Convert.ToDouble(Console.ReadLine());

            //        Console.Write("Enter second number: ");
            //        num2 = Convert.ToDouble(Console.ReadLine());

            //        Console.Write("Enter operator (+, -, *, /) or type exit: ");
            //        op = Console.ReadLine();

            //        if (op == "exit")
            //        {
            //            break;
            //        }

            //        switch (op)
            //        {
            //            case "+":
            //                result = num1 + num2;
            //                Console.WriteLine("Result = " + result);
            //                break;

            //            case "-":
            //                result = num1 - num2;
            //                Console.WriteLine("Result = " + result);
            //                break;

            //            case "*":
            //                result = num1 * num2;
            //                Console.WriteLine("Result = " + result);
            //                break;

            //            case "/":
            //                if (num2 != 0)
            //                {
            //                    result = num1 / num2;
            //                    Console.WriteLine("Result = " + result);
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Cannot divide by zero");
            //                }
            //                break;

            //            default:
            //                Console.WriteLine("Invalid operator");
            //                break;
            //        }

            //        Console.WriteLine();
            //    }
            //}
            #endregion

            #region Question 8 :

            //    int start, end;
            //    bool found = false;

            //    Console.Write("Enter start number: ");
            //    start = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter end number: ");
            //    end = Convert.ToInt32(Console.ReadLine());

            //    for (int i = start; i <= end; i++)
            //    {
            //        bool isPrime = true;

            //        if (i <= 1)
            //        {
            //            isPrime = false;
            //        }
            //        else
            //        {
            //            for (int j = 2; j < i; j++)
            //            {
            //                if (i % j == 0)
            //                {
            //                    isPrime = false;
            //                    break;
            //                }
            //            }
            //        }

            //        if (isPrime)
            //        {
            //            Console.WriteLine(i);
            //            found = true;
            //        }
            //    }

            //    if (found == false)
            //    {
            //        Console.WriteLine("No prime numbers found");
            //    }

            //    Console.ReadLine();
            //}
            #endregion

            #region Question 9:


            //int N;

            //Console.Write("Enter number of students: ");
            //N = Convert.ToInt32(Console.ReadLine());

            //int[] scores = new int[N];

            //int excellent = 0;
            //int veryGood = 0;
            //int good = 0;
            //int pass = 0;
            //int fail = 0;

            //int highest = 0;
            //int lowest = 100;

            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write("Enter score for student " + (i + 1) + ": ");
            //    scores[i] = Convert.ToInt32(Console.ReadLine());

            //    if (i == 0)
            //    {
            //        highest = scores[i];
            //        lowest = scores[i];
            //    }

            //    if (scores[i] > highest)
            //        highest = scores[i];

            //    if (scores[i] < lowest)
            //        lowest = scores[i];

            //    switch (scores[i] / 10)
            //    {
            //        case 10:
            //        case 9:
            //            Console.WriteLine("Excellent");
            //            break;

            //        case 8:
            //            Console.WriteLine("Very Good");
            //            break;

            //        case 7:
            //            Console.WriteLine("Good");
            //            break;

            //        case 6:
            //        case 5:
            //            Console.WriteLine("Pass");
            //            break;

            //        default:
            //            Console.WriteLine("Fail");
            //            break;
            //    }
            //}

            //for (int i = 0; i < N; i++)
            //{
            //    switch (scores[i] / 10)
            //    {
            //        case 10:
            //        case 9:
            //            excellent++;
            //            break;

            //        case 8:
            //            veryGood++;
            //            break;

            //        case 7:
            //            good++;
            //            break;

            //        case 6:
            //        case 5:
            //            pass++;
            //            break;

            //        default:
            //            fail++;
            //            break;
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Excellent: " + excellent);
            //Console.WriteLine("Very Good: " + veryGood);
            //Console.WriteLine("Good: " + good);
            //Console.WriteLine("Pass: " + pass);
            //Console.WriteLine("Fail: " + fail);
            //Console.WriteLine("Highest Score: " + highest);
            //Console.WriteLine("Lowest Score: " + lowest);

            //Console.ReadLine();

            #endregion

            #region Question 10:

            string pin;
            string correctPin = "9999";
            int attempts = 0;

            double balance = 5000;

            string[] transactionType = new string[100];
            double[] transactionAmount = new double[100];
            int count = 0;

            // STEP 1 – LOGIN
            while (attempts < 3)
            {
                Console.Write("Enter PIN: ");
                pin = Console.ReadLine();

                if (pin == correctPin)
                {
                    Console.WriteLine("Login Successful");
                    break;
                }
                else
                {
                    attempts++;
                    Console.WriteLine("Wrong PIN");

                    if (attempts == 3)
                    {
                        Console.WriteLine("Card Blocked");
                        return;
                    }
                }
            }

            // STEP 2 – MENU
            int choice = 0;

            while (choice != 4)
            {
                Console.WriteLine();
                Console.WriteLine("1 - Check Balance");
                Console.WriteLine("2 - Deposit");
                Console.WriteLine("3 - Withdraw");
                Console.WriteLine("4 - Exit");
                Console.Write("Choose option: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Current Balance: " + balance);
                        break;

                    case 2:
                        Console.Write("Enter deposit amount: ");
                        double deposit = Convert.ToDouble(Console.ReadLine());

                        if (deposit > 0 && deposit <= 10000)
                        {
                            balance += deposit;
                            Console.WriteLine("Deposit Successful");

                            transactionType[count] = "Deposit";
                            transactionAmount[count] = deposit;
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("Invalid deposit amount");
                        }
                        break;

                    case 3:
                        Console.Write("Enter withdrawal amount: ");
                        double withdraw = Convert.ToDouble(Console.ReadLine());

                        if (withdraw <= 0)
                        {
                            Console.WriteLine("Invalid withdrawal amount");
                        }
                        else if (withdraw > balance)
                        {
                            Console.WriteLine("Insufficient balance");
                        }
                        else
                        {
                            balance -= withdraw;
                            Console.WriteLine("Withdrawal Successful");

                            transactionType[count] = "Withdrawal";
                            transactionAmount[count] = withdraw;
                            count++;
                        }
                        break;

                    case 4:
                        Console.WriteLine("Exiting system...");
                        break;

                    default:
                        Console.WriteLine("Invalid option, please try again");
                        break;
                }
            }

            // STEP 4 – TRANSACTION LOG
            Console.WriteLine();
            Console.WriteLine("Transaction Summary:");

            if (count == 0)
            {
                Console.WriteLine("No transactions made.");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + transactionType[i] + " - " + transactionAmount[i]);
                }
            }

            Console.ReadLine();
            #endregion

        }
    }
}


            

