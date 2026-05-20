using System; 

class URI {

    static void Main(string[] args) { 

        string[] startDay = Console.ReadLine().Split(' ');
        int day1 = int.Parse(startDay[1]);

        string[] startTime = Console.ReadLine().Split(':');
        int hour1 = int.Parse(startTime[0]);
        int minute1 = int.Parse(startTime[1]);
        int second1 = int.Parse(startTime[2]);

        string[] endDay = Console.ReadLine().Split(' ');
        int day2 = int.Parse(endDay[1]);

        string[] endTime = Console.ReadLine().Split(':');
        int hour2 = int.Parse(endTime[0]);
        int minute2 = int.Parse(endTime[1]);
        int second2 = int.Parse(endTime[2]);

        var (day, hour, minute, second) = ReadDateTime(
            day1, hour1, minute1, second1,
            day2, hour2, minute2, second2
        );

        Console.WriteLine($"{day} dia(s)");
        Console.WriteLine($"{hour} hora(s)");
        Console.WriteLine($"{minute} minuto(s)");
        Console.WriteLine($"{second} segundo(s)");        

    }

    public static (int, int, int, int) ReadDateTime(int day1, int hour1, int minute1, int second1, int day2, int hour2, int minute2, int second2)
    {
        int totalSeconds1 = day1 * 24 * 3600 + hour1 * 3600 + minute1 * 60 + second1;
        int totalSeconds2 = day2 * 24 * 3600 + hour2 * 3600 + minute2 * 60 + second2;

        int duracao = totalSeconds2 - totalSeconds1;

        int day = duracao / (24 * 3600);
        int hour = (duracao % (24 * 3600)) / 3600;
        int minute = (duracao % 3600) / 60;
        int second = duracao % 60;

        return (day, hour, minute, second);
    } 


}