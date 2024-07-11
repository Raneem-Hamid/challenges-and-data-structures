using challenges.Common_Elements;

namespace Common_Elements_test
{
    public class UnitTest1
    {
        [Fact]
        public void test1()
        {

            // Arrange
            int[] arr1 = { 1, 2, 3, 0 };
            int[] arr2 = { 2, 3, 4, 9 };

            // Act
            var result = Common_Elements.CommonElements(arr1,arr2);
            var expected = new[] { 2,3 };

            // Assert
            Assert.Equal(expected,result); 

        }


        [Fact]
        public void test2()
        {

            // Arrange
            int[] arr1 = { 79, 8, 15 };
            int[] arr2 = { 23, 79, 8 };

            // Act
            var result = Common_Elements.CommonElements(arr1, arr2);
            var expected = new[] { 79, 8 };

            // Assert
            Assert.Equal(expected, result);

        }
    }
}