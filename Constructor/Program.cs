using Constructor;


//player p1 = new player();
//student s1 = new student();
//Console.Write("Enter Username:");
//s1.name = Console.ReadLine();
//Console.WriteLine(s1.name);
//Console.WriteLine("enter Rollnumber");
//s1.roll = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Obtain Marks");
//s1.obmarks = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("##################################################");
//s1.show();


student s1 = new student();
s1.show();

student s2 = new student("salman", 10, 870, 1100);
s2.show();

student s3 = new student ( s2, 845, 1100);
s3.show();	

