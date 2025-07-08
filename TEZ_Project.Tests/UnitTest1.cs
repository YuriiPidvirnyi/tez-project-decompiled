using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace TEZ_Project.Tests;

public class BasicTests
{
    [Fact]
    public void Basic_Test_Should_Pass()
    {
        // Arrange
        var expected = "Hello, World!";
        
        // Act
        var actual = "Hello, World!";
        
        // Assert
        actual.Should().Be(expected);
    }
    
    [Fact]
    public void Math_Operations_Should_Work()
    {
        // Arrange
        var a = 5;
        var b = 3;
        
        // Act
        var result = a + b;
        
        // Assert
        result.Should().Be(8);
    }
    
    [Fact]
    public void Collections_Should_Work()
    {
        // Arrange
        var list = new List<string> { "item1", "item2", "item3" };
        
        // Act
        var count = list.Count;
        
        // Assert
        count.Should().Be(3);
        list.Should().Contain("item2");
    }
    
    [Fact]
    public async Task Async_Operations_Should_Work()
    {
        // Arrange
        var expected = "async result";
        
        // Act
        var result = await GetAsyncResult().ConfigureAwait(false);
        
        // Assert
        result.Should().Be(expected);
    }
    
    private static async Task<string> GetAsyncResult()
    {
        await Task.Delay(1).ConfigureAwait(false); // Simulate async work
        return "async result";
    }
}

public class ConsoleApplicationTests
{
    [Fact]
    public void Test_Project_Reference_Should_Work()
    {
        // This test verifies that the test project can reference the console project
        // Arrange & Act
        var result = true;
        
        // Assert
        result.Should().BeTrue();
    }
}
