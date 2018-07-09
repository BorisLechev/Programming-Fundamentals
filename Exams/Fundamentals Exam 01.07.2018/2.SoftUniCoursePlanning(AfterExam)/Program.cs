namespace _2.SoftUniCoursePlanning_AfterExam_
{
    using System;
    using System.Linq;

    public class SoftUniCoursePlanning_AfterExam_
    {
        public static void Main()
        {
            var scheduleLessons = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

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
                            scheduleLessons.Add(lessonTitle);
                        }
                        break;

                    case "Insert":
                        int index = int.Parse(commandInput[2]);

                        if (!scheduleLessons.Contains(lessonTitle) && index >= 0 && index <= scheduleLessons.Count)
                        {
                            scheduleLessons.Insert(index, lessonTitle);
                        }
                        break;

                    case "Remove":
                        if (scheduleLessons.Contains(lessonTitle))
                        {
                            scheduleLessons.Remove(lessonTitle);

                            if (scheduleLessons.Contains($"{lessonTitle}-Exercise"))
                            {
                                scheduleLessons.Remove($"{lessonTitle}-Exercise");
                            }
                        }
                        break;

                    case "Swap":
                        string secondLessonTitle = commandInput[2];

                        if (scheduleLessons.Contains(lessonTitle) && scheduleLessons.Contains(secondLessonTitle))
                        {
                            if (scheduleLessons.Contains($"{lessonTitle}-Exercise") ||
                                scheduleLessons.Contains($"{secondLessonTitle}-Exercise"))
                            {
                                if (scheduleLessons.Contains($"{lessonTitle}-Exercise"))
                                {
                                    int indexOfLessonTitle = scheduleLessons.IndexOf(lessonTitle);

                                    if (scheduleLessons.Contains($"{secondLessonTitle}-Exercise"))
                                    {
                                        int indexOfSecondTitle = scheduleLessons.IndexOf(secondLessonTitle);

                                        scheduleLessons.RemoveAt(indexOfLessonTitle + 1);
                                        scheduleLessons.RemoveAt(indexOfLessonTitle);
                                        scheduleLessons.Insert(indexOfLessonTitle, secondLessonTitle);
                                        scheduleLessons.Insert(indexOfLessonTitle + 1, $"{secondLessonTitle}-Exercise");
                                        scheduleLessons.RemoveAt(indexOfSecondTitle + 1);
                                        scheduleLessons.RemoveAt(indexOfSecondTitle);
                                        scheduleLessons.Insert(indexOfSecondTitle, lessonTitle);
                                        scheduleLessons.Insert(indexOfSecondTitle + 1, $"{lessonTitle}-Exercise");
                                    }

                                    else
                                    {
                                        int indexOfSecondTitle = scheduleLessons.IndexOf(secondLessonTitle);
                                        scheduleLessons.RemoveAt(indexOfLessonTitle + 1);
                                        scheduleLessons.RemoveAt(indexOfLessonTitle);
                                        scheduleLessons.Insert(indexOfLessonTitle, secondLessonTitle);
                                        scheduleLessons.RemoveAt(indexOfSecondTitle);
                                        scheduleLessons.Insert(indexOfSecondTitle, $"{lessonTitle}-Exercise");
                                        scheduleLessons.Insert(indexOfSecondTitle, lessonTitle);
                                    }
                                }

                                else if (scheduleLessons.Contains($"{secondLessonTitle}-Exercise"))
                                {
                                    int indexOfSecondTitleWithExercise = scheduleLessons.IndexOf(secondLessonTitle);

                                    int indexOfFirstTitle = scheduleLessons.IndexOf(lessonTitle);

                                    scheduleLessons.Insert(scheduleLessons.Count, lessonTitle);
                                    scheduleLessons.RemoveAt(indexOfSecondTitleWithExercise + 1);
                                    scheduleLessons.RemoveAt(indexOfSecondTitleWithExercise);
                                    scheduleLessons.RemoveAt(indexOfFirstTitle);
                                    scheduleLessons.Insert(indexOfFirstTitle, secondLessonTitle);
                                    scheduleLessons.Insert(indexOfFirstTitle + 1, $"{secondLessonTitle}-Exercise");
                                }
                            }

                            else
                            {
                                int indexOfFirstLessonTitle = scheduleLessons.IndexOf(lessonTitle);
                                int indexOfSecondLessonTitle = scheduleLessons.IndexOf(secondLessonTitle);

                                scheduleLessons.RemoveAt(indexOfFirstLessonTitle);
                                scheduleLessons.Insert(indexOfFirstLessonTitle, secondLessonTitle);

                                scheduleLessons.RemoveAt(indexOfSecondLessonTitle);
                                scheduleLessons.Insert(indexOfSecondLessonTitle, lessonTitle);
                            }
                        }
                        break;

                    case "Exercise":

                        if (scheduleLessons.Contains(lessonTitle) && !scheduleLessons.Contains($"{lessonTitle}-Exercise"))
                        {
                            int indexOfLessonTitle = scheduleLessons.IndexOf(lessonTitle);

                            scheduleLessons.Insert(indexOfLessonTitle + 1, $"{lessonTitle}-Exercise");
                        }

                        if (!scheduleLessons.Contains(lessonTitle))
                        {
                            scheduleLessons.Add(lessonTitle);
                            scheduleLessons.Add($"{lessonTitle}-Exercise");
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
