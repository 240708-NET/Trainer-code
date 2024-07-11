using Xunit;
using System.Collections.Generic;
using _5_OperatorsChallenge;

namespace _5_OperatorsChallenge.Tests
{
    public class ProgramTest
    {
        public static readonly IEnumerable<object[]> _singleNumbers = new List<object[]>
        {
            new object[] {1},
            new object[] {2},
            new object[] {3},
            new object[] {4}
        };
        public static readonly IEnumerable<object[]> _pairNumbers = new List<object[]>
        {
            new object[] {1,2},
            new object[] {2,3},
            new object[] {3,4},
            new object[] {4,5}
        };

        [Theory]
        [MemberData(nameof(_singleNumbers))]
        public void IncrementShouldIncrement(int input)
        {
            
        }

        [Theory]
        [MemberData(nameof(_singleNumbers))]
        public void DecrementShouldDecrement(int input)
        {
            
        }

        [Theory]
        [MemberData(nameof(_singleNumbers))]
        public void NegateShouldNegate(int input)
        {
            
        }

        [Fact]
        public void NotShouldNegate()
        {

        }

        [Theory]
        [MemberData(nameof(_pairNumbers))]
        public void SumShouldReturnSum(int num1, int num2)
        {
            
        }

        [Theory]
        [MemberData(nameof(_pairNumbers))]
        public void DiffShouldReturnDiff(int num1, int num2)
        {
            
        }

        [Theory]
        [MemberData(nameof(_pairNumbers))]
        public void ProductShouldReturnProduct(int num1, int num2)
        {
           
        }

        [Theory]
        [MemberData(nameof(_pairNumbers))]
        public void QuotientShouldReturnQuotient(int num1, int num2)
        {
            
        }

        [Theory]
        [MemberData(nameof(_pairNumbers))]
        public void RemainderShouldReturnRemainder(int num1, int num2)
        {
            
        }

        [Theory]
        [MemberData(nameof(_pairNumbers))]
        public void AndShouldReturnFalse(int num1, int num2)
        {
            
        }
        [Theory]
        [MemberData(nameof(_pairNumbers))]
        public void OrShouldReturnFalse(int num1, int num2)
        {
            
        }

    }
}
