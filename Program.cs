enterForProgram();

static void enterForProgram()
{
    string cont = "";
    while (cont != "stop")
    {
        chooseOption();
        stopOption(ref cont);
    }
}

static void stopOption(ref string cont)
{
    System.Console.WriteLine("If you want to stop, type 'stop'");
    string userStopInput = Console.ReadLine();
    userStopInput.ToLower();
    if (userStopInput == "stop")
        cont = userStopInput;
}

static int userInput()
{
    Console.WriteLine("Insert your grade:");
    int userGradeInput = Convert.ToInt16(Console.ReadLine());
    return userGradeInput;
}

static void chooseOption()
{
    System.Console.WriteLine("Choose way to get answer through:\n1.If else\n2.Switch\n3.Ternart");
    int userOptionInput = Convert.ToInt16(Console.ReadLine());

    switch (userOptionInput)
    {
        case 1:
            ifElse(userInput());
            break;
        case 2:
            answerThroughSwitch(userInput());
            break;
        case 3:
            answerThroughTernary(userInput());
            break;
        default:
            System.Console.WriteLine("Error");
            break;
    }
}

static void ifElse(int userGradeInput)
{
    if (userGradeInput < 60)
    {
        System.Console.WriteLine("Your Grade: F");
    }
    else if (userGradeInput >= 60 && userGradeInput < 70)
    {
        System.Console.WriteLine("Your Grade: D");
    }
    else if (userGradeInput >= 70 && userGradeInput < 80)
    {
        System.Console.WriteLine("Your Grade: C");
    }
    else if (userGradeInput >= 80 && userGradeInput < 90)
    {
        System.Console.WriteLine("Your Grade: B");
    }
    else if (userGradeInput >= 90 && userGradeInput <= 100)
    {
        System.Console.WriteLine("Your Grade: A");
    }
    else
    {
        System.Console.WriteLine("Something wrong...");
    }
}

static void answerThroughSwitch(int userGradeInput)
{
    switch (userGradeInput)
    {
        case > 100:
            System.Console.WriteLine("Error");
            break;
        case >= 90:
            System.Console.WriteLine("Your Grade: A");
            break;
        case >= 80:
            System.Console.WriteLine("Your Grade: B");
            break;
        case >= 70:
            System.Console.WriteLine("Your Grade: C");
            break;
        case >= 60:
            System.Console.WriteLine("Your Grade: D");
            break;
        case >= 0:
            System.Console.WriteLine("Your Grade: F");
            break;
        case < 0:
            System.Console.WriteLine("Error");
            break;
    }
}

static void answerThroughTernary(int userGradeInput)
{
    string grade;

    grade = userGradeInput > 100 ? "Error" : userGradeInput >= 90 ? "A" : userGradeInput >= 80 ? "B" : userGradeInput >= 70 ? "C" : userGradeInput >= 60 ? "D" : userGradeInput >= 0 ? "F" : "Error";

    Console.WriteLine("Your grade: " + grade);
}