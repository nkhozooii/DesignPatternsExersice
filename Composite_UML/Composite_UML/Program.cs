﻿using Composite_UML.CompositeClass;
using System;

namespace Composite_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            //Component component = new Composite
            //   ("Root Item", new Component[]
            //   {
            //        new Leaf("Leaf 1"),
            //        new Composite ("Composite 1",new Component[]
            //        {
            //            new Leaf("Leaf 1-1"),
            //            new Leaf("Leaf 1-2"),
            //            new Composite("Composite 1-1",new Component[]
            //            {
            //                new Leaf("Laef 1-1-1-"),
            //                new Composite("empty Composite",new Component[]{ }),
            //            })
            //        }),
            //        new Leaf("Leaf 2"),
            //        new Leaf("Leaf 3"),
            //        new Leaf("Leaf 4"),
            //   });
            //component.Display(1);
            //Console.ReadLine();

            // Create a tree structure
            Component root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));
            Component comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));
            root.Add(comp);
            root.Add(new Leaf("Leaf C"));
            // Add and remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);
            // Recursively display tree
            root.Display(1);
            // Wait for user
            Console.ReadKey();
        }

    }
}
