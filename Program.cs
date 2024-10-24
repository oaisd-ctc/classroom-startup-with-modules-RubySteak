﻿using System;

public class Program
{
    public static void Main(string[] args)
    {
        FindSeat();
        SignIn();
        DailyLogic();
        BoxBreathing();
        DailyHypothetical();
    }

    public static void FindSeat()
    {
        Console.WriteLine("Walk in the room.");
        Console.WriteLine("Walk towards desk.");
        Console.WriteLine("Pull out chair.");
        Console.WriteLine("Take off backpack.");
        Console.WriteLine("Place backpack on the ground.");
        Console.WriteLine("Sit down in chair.");
    }

    public static void SignIn()
    {
        Console.WriteLine("Turn on computer.");
        Console.WriteLine("Sign in to computer.");
        Console.WriteLine("Open browser.");
    }

    public static void DailyLogic()
    {
        Console.WriteLine("Turn on computer.");
        Console.WriteLine("Sign in to computer.");
        Console.WriteLine("Open browser.");
        Console.WriteLine("Navigate to the Daily Logic Classroom.");
        Console.WriteLine("Complete the Daily Logic for the day.");
    }

    public static void BoxBreathing()
    {
        int counter = 1;

        while (counter <= 3)
        {
            Console.WriteLine("Inhale for 4 seconds.");
            Console.WriteLine("Hold breath for 4 seconds.");
            Console.WriteLine("Exhale for 4 seconds.");
            Console.WriteLine("Hold breath for 4 seconds.");
            counter++;
        }

    }

    public static void DailyHypothetical()
    {
        Console.WriteLine("Open a new tab in the browser.");
        Console.WriteLine("Navigate to Google.");
        Console.WriteLine("Open Gmail.");
        Console.WriteLine("Read Daily Hypothetical.");
        Console.WriteLine("Talk to neighbors about Daily Hypothetical.");
        Console.WriteLine("Respond to Daily Hypothetical email.");
    }
}