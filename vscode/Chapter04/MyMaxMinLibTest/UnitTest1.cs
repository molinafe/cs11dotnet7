using Xunit;
using MyMaxMinLib;

namespace MyMaxMinLibTest;

public class UnitTest1
{
    [Fact]
    	public void TestMax() {
	
		double a = 2;
        double b = 4;
		double expected = 4;
	
		double actual = MaxMin.MyMax(a, b); // act
 
		Assert.Equal(expected, actual); // assert
	}
}