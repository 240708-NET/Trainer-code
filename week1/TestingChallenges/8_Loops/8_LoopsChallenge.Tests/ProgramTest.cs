using System;
using System.IO;
using Xunit;
using _8_LoopsChallenge;
using System.Collections.Generic;

namespace _8_LoopsChallenge.Tests
{
    public class ProgramTest
    {
        //public static readonly StringWriter output = new StringWriter();

        private readonly List<int> oddsAndEvens = new List<int>()
        {
            1,2,3,4,5,6,7,8,9,10,1234,10,9,8,7,6,5,4,3,2,1
        };

        private readonly List<object> oddsAndEvensDiffTypes = new List<object>()
        {
            -128,127,0,255,'h','e','y',-2147483648,"hey",21474836470,4294967295,
            "hey",-9223372036854775808,9223372036854775807,"hey",18446744073709551615,"hey"
        };

        [Fact]
        public void UseForShouldReturnHowManyEvenInts()
        {
            
        }

        [Fact]
        public void UseForEachShouldReturnHowManyEvenObjects()
        {
            
        }

        [Fact]
        public void UseWhilehouldReturnHowManyMultiplesOf4()
        {
            
        }

        [Fact]
        public void UseForThreeFourReturnsHowManyMultiplesOf3And4()
        {
            
        }

        [Fact]
        public void LoopdyLoopReturnsHowManyMultiplesOf3And4()
        {
            
        }
    }// EoC
}// EoN
