namespace _1.TheaThePhotographer
{
    using System;

    public class TheaThePhotographer
    {
        public static void Main()
        {
            int amountOfPictures = int.Parse(Console.ReadLine());
            int filterTimeInSeconds = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine()); // % ot total pictures that will be uploaded.
            int timeForUploadAPicture = int.Parse(Console.ReadLine());

            double filteredPictures = (long)Math.Ceiling((amountOfPictures * filterFactor) / 100.0);
            double totalFilterTimeInSeconds = (long)amountOfPictures * filterTimeInSeconds;
            double uploadTimeForFilteredPicturesInSeconds = timeForUploadAPicture * filteredPictures;
            double totalTimeInSeconds = totalFilterTimeInSeconds + uploadTimeForFilteredPicturesInSeconds;

            var time = TimeSpan.FromSeconds(totalTimeInSeconds);

            string formattedTime = time.ToString(@"d\:hh\:mm\:ss");

            Console.WriteLine(formattedTime);
        }
    }
}
