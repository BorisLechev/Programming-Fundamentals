namespace _2.SoftUniCoursePlanning
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()  //50 => 55
        {
            var scheduleLessons = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "course start")
            {
                var commandInput = input.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string lessonTitle = commandInput[1];

                switch (commandInput[0])
                {
                    case "Add":

                        if (!scheduleLessons.Contains(lessonTitle))
                        {
                            scheduleLessons.Insert(scheduleLessons.Count, lessonTitle);
                        }
                        break;

                    case "Insert":
                        int index = int.Parse(commandInput[2]);
                        //?
                        if (!scheduleLessons.Contains(lessonTitle) && index >= 0 && index < scheduleLessons.Count - 1)
                        {
                            scheduleLessons.Insert(index, lessonTitle);
                        }
                        break;

                    case "Remove":   //?

                        if (scheduleLessons.Contains(lessonTitle) || lessonTitle.Contains("Exercise"))
                        {
                            scheduleLessons.Remove(lessonTitle);
                        }
                        break;

                    case "Swap": //??
                        string secondLessonTitle = commandInput[2];

                        if (scheduleLessons.Contains(lessonTitle) && scheduleLessons.Contains(secondLessonTitle)
                            || scheduleLessons.Contains($"{secondLessonTitle}-Exercise") ||
                            scheduleLessons.Contains($"{lessonTitle}-Exercise"))
                        {
                            int indexOfFirstLesson = scheduleLessons.IndexOf(lessonTitle);

                            int indexOfSecondLesson = 0;

                            if (scheduleLessons.Contains($"{secondLessonTitle}-Exercise"))
                            {
                                indexOfSecondLesson = scheduleLessons.IndexOf($"{secondLessonTitle}-Exercise");

                                scheduleLessons.Insert(indexOfFirstLesson, secondLessonTitle);
                                scheduleLessons.Insert(indexOfFirstLesson + 1, $"{secondLessonTitle}-Exercise");
                                scheduleLessons.RemoveAt(scheduleLessons.LastIndexOf($"{secondLessonTitle}-Exercise"));
                            }
                            else
                            {
                                indexOfSecondLesson = scheduleLessons.IndexOf(secondLessonTitle);
                            }

                            scheduleLessons.RemoveAt(indexOfFirstLesson);
                            scheduleLessons.Insert(indexOfFirstLesson, secondLessonTitle);

                            if (scheduleLessons.Contains($"{secondLessonTitle}-Exercise"))
                            {
                                scheduleLessons.Insert(indexOfFirstLesson + 1, $"{secondLessonTitle}-Exercise");
                            }

                            scheduleLessons.RemoveAt(indexOfSecondLesson);
                            scheduleLessons.Insert(indexOfSecondLesson, lessonTitle);

                            if (scheduleLessons.Contains($"{lessonTitle}-Exercise"))
                            {
                                scheduleLessons.Insert(indexOfFirstLesson + 1, $"{lessonTitle}-Exercise");
                            }
                        }
                        break;

                    case "Exercise": //?

                        if (!scheduleLessons.Contains(lessonTitle))
                        {
                            scheduleLessons.Insert(scheduleLessons.Count, $"{lessonTitle}-Exercise");
                        }
                        break;
                }
            }

            int position = 1;

            foreach (var lesson in scheduleLessons)
            {
                Console.WriteLine($"{position++}.{lesson}");
            }
        }
    }
}
