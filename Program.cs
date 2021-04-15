﻿using System;

var numLoops = 1d;
TimeSpan sum = TimeSpan.FromMilliseconds(0);
var printedRes = false;



for (int i = 0; i < numLoops; i++)
{
    var st = new System.Diagnostics.Stopwatch();
    st.Start();
    var res = Algos.LongestCommonSubstring.commonChild("12341", @"341213");
    st.Stop();
    if (!printedRes)
    {
        Console.WriteLine(string.Join(", ", res));
        printedRes = true;
    }
    if (i % (numLoops / 4) == 0)
    {
        Console.WriteLine("...");
    }
    sum += st.Elapsed;
}



Console.WriteLine($"=================================================");
Console.WriteLine($"Avg. Time elapsed ({numLoops}X): {sum / numLoops}");
Console.WriteLine($"=================================================");





