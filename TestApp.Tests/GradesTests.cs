using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        //Arrange
        Dictionary<string, int> gradesDictionary = new()
        {
            { "Ivan", 4},
            { "Peter", 6},
            { "Denis", 3},
            { "Martin", 2},

        };

            //Act
            string actualResult = Grades.GetBestStudents(gradesDictionary);
        string expectedResult = $"Peter with average grade 6.00{Environment.NewLine}" +
            $"Ivan with average grade 4.00{Environment.NewLine}" +
            $"Denis with average grade 3.00";

            //Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        //Arrange
        Dictionary<string, int> gradesDictionary = new();
       

        //Act
        string actualResult = Grades.GetBestStudents(gradesDictionary);
        string expectedResult = string.Empty;

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        //Arrange
        Dictionary<string, int> gradesDictionary = new()
        {
            { "Ivan", 4},
            { "Peter", 6},
           

        };

        //Act
        string actualResult = Grades.GetBestStudents(gradesDictionary);
        string expectedResult = $"Peter with average grade 6.00{Environment.NewLine}" +
            $"Ivan with average grade 4.00";

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        //Arrange
        Dictionary<string, int> gradesDictionary = new()
        {
            { "Ivan", 4},
            { "Peter", 6},
            { "Denis", 4},
            { "Martin", 2},

        };

        //Act
        string actualResult = Grades.GetBestStudents(gradesDictionary);
        string expectedResult = $"Peter with average grade 6.00{Environment.NewLine}" +
            $"Denis with average grade 4.00{Environment.NewLine}" +
            $"Ivan with average grade 4.00";

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }
}
