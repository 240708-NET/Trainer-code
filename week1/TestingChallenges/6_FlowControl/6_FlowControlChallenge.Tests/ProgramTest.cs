using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using _6_FlowControl;

namespace _6_FlowControlChallenge.Tests
{
    public class ProgramTest
    {
        public static readonly StringWriter output = new StringWriter();
        public static readonly IEnumerable<object[]> _tempList = new List<object[]>
        {
            new object[] {-30},
            new object[] {18},
            new object[] {60},
            new object[] {120}
        };

        [Theory]
        [MemberData(nameof(_tempList))]
        public void GetValidTempReturnsValidTemp(int temp)
        {

        }

        [Fact]
        public void RegisterShouldRegister()
        {
            
        }

        [Fact]
        public void GetTemperatureTernaryShouldSayTooCold()
        {
            
        }

        [Fact]
        public void GetTemperatureTernaryShouldSayOK()
        {
            
        }

        [Fact]
        public void GetTemperatureTernaryShouldSayTooHot()
        {
            
        }

        [Theory]
        [InlineData(-21)]
        [InlineData(-22)]
        [InlineData(-30)]
        [InlineData(-40)]
        public void GiveActivityAdviceShouldSayHellaCold(int temp)
        {
            
        }
        [Theory]
        [InlineData(-19)]
        [InlineData(-18)]
        [InlineData(-5)]
        [InlineData(-1)]
        public void GiveActivityAdviceShouldSayPrettyCold(int temp)
        {
            
        }
        [Theory]
        [InlineData(10)]
        [InlineData(9)]
        [InlineData(6)]
        [InlineData(19)]
        public void GiveActivityAdviceShouldSayCold(int temp)
        {
            
        }
        [Theory]
        [InlineData(21)]
        [InlineData(30)]
        [InlineData(35)]
        [InlineData(25)]
        public void GiveActivityAdviceShouldSayThawedOut(int temp)
        {
            
        }

        [Theory]
        [InlineData(45)]
        [InlineData(50)]
        [InlineData(55)]
        [InlineData(40)]
        public void GiveActivityAdviceShouldSayFeelsLikeAutumn(int temp)
        {
            
        }

        [Theory]
        [InlineData(65)]
        [InlineData(70)]
        [InlineData(75)]
        [InlineData(60)]
        public void GiveActivityAdviceShouldSayPerfectOutdoorTemp(int temp)
        {
            
        }

        [Theory]
        [InlineData(80)]
        [InlineData(82)]
        [InlineData(85)]
        [InlineData(88)]
        public void GiveActivityAdviceShouldSayNice(int temp)
        {
            
        }

        [Theory]
        [InlineData(95)]
        [InlineData(90)]
        [InlineData(93)]
        [InlineData(99)]
        public void GiveActivityAdviceShouldSayHellaHot(int temp)
        {
            
        }

        [Theory]
        [InlineData(100)]
        [InlineData(120)]
        [InlineData(125)]
        [InlineData(130)]
        public void GiveActivityAdviceShouldSayHottest(int temp)
        {
            
        }
    }
}
