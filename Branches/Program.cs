// See https://aka.ms/new-console-template for more information
using Branches;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

internal class Program
{
    
    private static void Main(string[] args)
    {
        Branch root = new Branch();
        //LEFT TREE
        Branch branch = new Branch();
        root.Add(branch);

        Branch branch2 = new Branch();
        branch.Add(branch2);
        //RIGHT TREE
        Branch branch3 = new Branch();
        root.Add(branch3);

        Branch branch4 = new Branch();
        branch3.Add(branch4);
        Branch branch5 = new Branch();
        branch3.Add(branch5);
        Branch branch6 = new Branch();
        branch3.Add(branch6);
        Branch branch7 = new Branch();
        branch4.Add(branch7);
        Branch branch8 = new Branch();
        branch5.Add(branch8);
        Branch branch9 = new Branch();
        branch5.Add(branch9);
        Branch branch10 = new Branch();
        branch8.Add(branch10);

        int depth = root.GetDepth(root);
        Console.WriteLine($"Level of branch branch10: {depth}");

        //idk why I cant get all the branches I added to the branches list...
        Console.WriteLine(root.Show());
    }
}