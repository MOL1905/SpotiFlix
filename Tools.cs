namespace SpotiFlix
{
    internal class Tools
    { 
        public static int HourAndMinutesToSeconds (string s)
        {
            //1:45 == array[0] = 1, array[1] = 45;
            string[] array = s.Split(':');
            return int.Parse(array[0]) * 3600 + int.Parse(array[1]) * 60;
        }
    }
}
