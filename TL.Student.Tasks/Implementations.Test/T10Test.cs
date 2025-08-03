using TL.Student.Interfaces;
using TL.Student.Implementations;
namespace Implementations.Test
{
    public class T10Test
    {

        [Fact]
        public void Calculate_WithLimitUnder12_Returns0()
        {
            var task = new T10istoyanov().Limit(11);
            int result = task.Calculate();
            Assert.Equal(0, result);
        }

        [Fact]
        public void Calculate_WithLimit12_Returns1()
        {
            var task = new T10istoyanov().Limit(12);
            int result = task.Calculate();
            Assert.Equal(1, result);
        }

        [Fact]
        public void Calculate_WithLimit30_Returns3()
        {
            var task = new T10istoyanov().Limit(30);
            int result = task.Calculate();
            Assert.Equal(3, result);
        }

        [Fact]
        public void Calculate_WithLimit100_Returns17()
        {
            var task = new T10istoyanov().Limit(100);
            int result = task.Calculate();
            Assert.Equal(17, result);
        }
    }
}