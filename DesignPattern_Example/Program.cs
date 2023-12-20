using DesignPattern_Example.Homework512.Decorator;
using DesignPattern_Example.OnTapLan1.Command;
using DesignPattern_Example.OnTapLan1.Factory;


// Decorator
Console.WriteLine("Enter student name");
var studentName = Console.ReadLine();

Console.WriteLine("Enter student ID");
var studentID = Console.ReadLine();

Console.WriteLine("Enter number of credits");
var credits = Console.ReadLine();

Console.WriteLine("Enter fee per credit");
var feePerCredit = Console.ReadLine();

var titles = new List<Title>()
{
    Title.CongHien,
    Title.TOT
};

var condition = Condition.Poor;
var fee = new Fee()
{
    NumberOfCredits = int.Parse(credits!),
    FeePerCredit = double.Parse(feePerCredit!)
};
var student = new Student(studentName!, studentID!, fee);
var feeService = new FeeService(student);
Console.WriteLine($"Original fee: {feeService.CalculateManualFee()}");

var studentsWithTitles = new StudentWithTitlesDecorator(feeService);
studentsWithTitles.AddTitles(titles);
feeService.TilteDiscountRatio = studentsWithTitles.CalculateDiscountRatio();
var studentsWithConditon = new StudentWithConditionDecorator(feeService);
studentsWithConditon.AddConditon(condition);
feeService.ConditionDiscountRatio = studentsWithConditon.CalculateDiscountRatio();

Console.WriteLine($"Discount ratio: {feeService.DiscountRatio()}");
Console.WriteLine($"Discount fee: {feeService.CalculateManualFee()}");

// Factory

Console.WriteLine("Enter service");
var service = Console.ReadLine();

switch (service)
{
    case "Laundry":
        new LaundryFeeCalculator().CalculateMethod();
        break;
    case "Printing":
        new PrintingFeeCalculator().CalculateMethod();
        break;
    case "RentalCar":
        new RentalCarFeeCalculator().CalculateMethod();
        break;
    default:
        break;
}


// Command

Console.WriteLine("Input rows");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Input columns");
int columns = int.Parse(Console.ReadLine());

double[,] inputArray = new double[rows, columns];

Console.WriteLine("Input each value of _matrix");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"Input for [{i},{j}] value: ");
        inputArray[i, j] = double.Parse(Console.ReadLine());
    }
}

MatrixOperator matrixOperator = new(inputArray);
MatrixCommandInvoker invoker = new();

while (true)
{
    Console.WriteLine("Pick operation");
    Console.WriteLine("1. Sum of matricx");
    Console.WriteLine("2. Set all to default value");
    Console.WriteLine("3. Find max value");
    Console.WriteLine("4. Find min value");
    Console.WriteLine("5. Exit");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            invoker.SetCommand(new CalculateTotalMatrixSumCommand(matrixOperator));
            invoker.ExecuteCommand();
            break;
        case 2:
            Console.WriteLine("Input default value");
            double defaultValue = double.Parse(Console.ReadLine());
            invoker.SetCommand(new SetMatrixToDefaultValueCommand(matrixOperator, defaultValue));
            invoker.ExecuteCommand();
            break;
        case 3:
            invoker.SetCommand(new FindMaxValueInMatrixCommand(matrixOperator));
            invoker.ExecuteCommand();
            break;
        case 4:
            invoker.SetCommand(new FindMinValueInMatrixCommand(matrixOperator));
            invoker.ExecuteCommand();
            break;
        case 5:
            return;
        default:
            Console.WriteLine("Invalid operation");
            break;
    }
}
