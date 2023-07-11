﻿// Write a program to create a delegate called TrafficDel and a class called
// TrafficSignal with the following delegate methods.
// Public static void Yellow()
// {
//     Console.WriteLine(“Yellow Light Signal To Get Ready”);
// }
// Public static void Green()
// {
//     Console.WriteLine(“Green Light Signal To Go”);
// }
// Public static void Red()
// {
//     Console.WriteLine(“Red Light Signal To Stop”);
// }
using System;

delegate void TrafficDel();

class TrafficSignal
{
    public static void Yellow()
    {
        Console.WriteLine("Yellow Light Signal To Get Ready");
    }

    public static void Green()
    {
        Console.WriteLine("Green Light Signal To Go");
    }

    public static void Red()
    {
        Console.WriteLine("Red Light Signal To Stop");
    }
}

class Program
{
    static void Main(string[] args)
    {
        TrafficDel trafficDel = TrafficSignal.Yellow;
        trafficDel += TrafficSignal.Green;
        trafficDel += TrafficSignal.Red;  
        trafficDel.Invoke();
    }
}