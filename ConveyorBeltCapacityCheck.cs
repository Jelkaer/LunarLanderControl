Console.WriteLine("Is there enough motors to carry the boxes?");
Console.WriteLine("How much do the boxes weigh in kg?");
    var w=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("How many motors do we have?");
var antal_motorer =Convert.ToDouble(Console.ReadLine());
double quotient = antal_motorer / w;
if (quotient <= 5.6)
    Console.WriteLine("Yes! The ConveyorBelt can carry the boxes");
else Console.WriteLine("No. The ConveyorBelt can't carry the boxes");
return;
