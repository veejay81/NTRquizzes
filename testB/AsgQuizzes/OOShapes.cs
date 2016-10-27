using System;
using System.Collections.Generic;

namespace AsgQuizzes
{
    public class OOShapes
    {
        public IEnumerable<IShape> AllShapes
        {
            get { throw new NotImplementedException(); }
        }

        public void AddTriangle(double height, double width)
        {
            throw new NotImplementedException();
        }

        public void AddRectangle(double height, double width)
        {
            throw new NotImplementedException();
        }

        public string PrintAll()
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// HINT: You are expected to write classes that implement this interface
    /// </summary>
    public interface IShape
    {
        string WhatIAm { get; }
        double Area { get; }
    }
}