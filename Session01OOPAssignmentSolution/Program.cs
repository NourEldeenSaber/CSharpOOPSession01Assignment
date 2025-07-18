namespace Session01OOPAssignmentSolution
{

    #region 1- Create an enum called "WeekDays"
    enum WeekDays : byte
    {
        Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    #endregion

    #region 2- Create an enum called "Season"
    enum Sesson:byte
    {
        Spring = 1, Summer, Autumn, Winter
    }
    #endregion
    
    #region 3- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
    [Flags]
    enum Permissions : byte
    {
        Read = 1, Write = 2, Delete = 4, Execute = 8
    }

    #endregion

    #region 4- Create an enum called "Colors" with the basic colors (Red, Green, Blue)

    enum Colors
    {
        Red = 1, Green, Blue
    } 
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Create an enum called "WeekDays"
            ///foreach (WeekDays weekDays in Enum.GetValues(typeof(WeekDays)))
            ///{
            ///    Console.WriteLine(weekDays);
            ///} 
            #endregion

            #region 2- Create an enum called "Season"
            /// Console.WriteLine("Enter Sesson Name");
            /// bool isParsed ,isDefiend;
            /// isParsed = Enum.TryParse(typeof(Sesson),Console.ReadLine(),true,out object? sesson );
            /// 
            /// if (sesson != null && isParsed != false )
            /// {
            ///     isDefiend = Enum.IsDefined<Sesson>((Sesson)sesson);
            ///     if(isDefiend == true)
            ///     {
            ///         switch (sesson)
            ///         {
            ///             case Sesson.Spring:
            ///                 Console.WriteLine("March, April, May");
            ///                 break;
            ///             case Sesson.Summer:
            ///                 Console.WriteLine("June, July, August");
            ///                 break;
            ///             case Sesson.Autumn:
            ///                 Console.WriteLine("September, October, November");
            ///                 break;
            ///             case Sesson.Winter:
            ///                 Console.WriteLine("December, January, February");
            ///                 break;
            ///             default:
            ///                 Console.WriteLine("Something went wrong");
            ///                 break;
            ///         }
            ///     }else
            ///         Console.WriteLine("Something went wrong");
            ///     
            /// }
            /// else {
            /// 
            ///     Console.WriteLine("Error : may be you insert a wrong sesson or something went wrong");
            /// } 
            #endregion

            #region 3- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            /// Permissions permissions = Permissions.Execute | Permissions.Read;
            /// permissions = Permissions.Write | Permissions.Delete | Permissions.Execute;
            /// Console.WriteLine(permissions);
            /// 
            /// int myPermissions;
            /// myPermissions = (int)Permissions.Read + (int)Permissions.Delete;
            /// Console.WriteLine((Permissions)myPermissions); 
            #endregion

            #region 4- Create an enum called "Colors" with the basic colors (Red, Green, Blue)
            /// Console.WriteLine("Enter the Color Name : ");
            /// bool isParsed = Enum.TryParse<Colors>(Console.ReadLine(), true, out Colors color);
            /// 
            /// 
            /// if (color == Colors.Red || color == Colors.Blue || color == Colors.Green)
            /// {
            ///     Console.WriteLine("input Color is a primary ");
            /// }
            /// else
            ///     Console.WriteLine("input Color is not primary "); 
            #endregion


        }
    }
}
