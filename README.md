# xunit-csharp-sample
## Adding xUnit Test Project to Your C# Application in Visual Studio


In this tutorial, We will demonstrate how to add a test project to your existing C# application using xUnit. We will be using Visual Studio and xUnit, which is a popular testing framework for .NET applications.

We'll be using the "myAPI" project which is available in this repo.

Clone the repository and open it with Visual Studio.

### Step 1: Create a new xUnit Test Project

1. In Visual Studio, right-click on the solution in the Solution Explorer.
2. Choose "Add" > "New Project..."
3. In the "Add a new project" window, search for "xUnit Test Project" and select "xUnit Test Project (C#)".
4. Click "Next" and give your test project a name, e.g., "myAPI.Tests".
5. Choose a location for your test project, and click "Next".
6. Select the right Framework version, and click "Create"

Now, you should have a new xUnit test project added to your solution.

### Step 2: Add a reference to your main project

1. In the Solution Explorer, right-click on the "myAPI.Tests" project.
2. Choose "Add" > "Project Reference..."
3. Check the box next to the "myAPI" project and click "OK".
This will enable your test project to access the classes and methods from your main project.

### Step 3: Add xUnit NuGet packages
In the "myAPI.Tests" project, make sure you have the following NuGet packages installed:

1. xunit
2. xunit.runner.visualstudio
3. Microsoft.NET.Test.Sdk


To install or verify these packages, follow these steps:

1. In the Solution Explorer, right-click on the "myAPI.Tests" project.
2. Choose "Manage NuGet Packages..."
3. Click on the "Installed" tab and make sure the packages mentioned above are listed.
4. If any of them are missing, click on the "Browse" tab, search for the missing package, and click "Install" to add it.


### Step 4: Write a test for the NumberChecker class

In the "myAPI.Tests" project, create a new class called NumberCheckerTests. (Or you can just rename the existing UnitTest1 class) We will write a test method for the IsEven method in the NumberChecker class.

```c#
using myAPI;

namespace myAPI.Tests
{
    public class NumberCheckerTests
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, false)]
        [InlineData(0, true)]
        public void IsEven_ReturnsCorrectResult(int number, bool expectedResult)
        {
            // Arrange
            var numberChecker = new NumberChecker();

            // Act
            var result = numberChecker.IsEven(number);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}

```

This test uses the **Theory** attribute and **InlineData** to provide multiple test cases for the **IsEven** method. It checks if the method returns the correct result for each test case.

### Step 5: Run the tests
Now that we have a test method in place, let's run the tests.

1. In Visual Studio, go to "Test" > "Test Explorer".
2. If the "Test Explorer" pane is not already open, it will open now.
3. Click on the "Run All Tests" button (the double play button icon) or right-click on the "myAPI.Tests" project and choose "Run Tests".

Visual Studio will build the solution and run the tests. You should see the test results in the "Test Explorer" pane. If everything is set up correctly, your test should pass.

##### *The **test** branch of current repo already have the test project ready!*

### Conclusion
In this tutorial, we demonstrated how to add an xUnit test project to an existing C# application using Visual Studio. We created a test for the NumberChecker class's IsEven method and ran the test successfully. This approach will enable you and your team to write and run unit tests for your application, improving its reliability and maintainability.
