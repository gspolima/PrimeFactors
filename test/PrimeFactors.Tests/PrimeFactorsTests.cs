using System;
using Xunit;
using System.Collections.Generic;
using PrimeFactors;


namespace PrimeFactors.Tests
{
    public class primeFactorsTests
    {
        [Fact]
        public void CheckCorrectprimeFactors()
        {
            var primeFactors = new PrimeFactors();

            Assert.Equal(new List<int>() {}, primeFactors.of(1));
            Assert.Equal(new List<int>() {2}, primeFactors.of(2));
            Assert.Equal(new List<int>() {3}, primeFactors.of(3));
            Assert.Equal(new List<int>() {2, 2}, primeFactors.of(4));
            Assert.Equal(new List<int>() {2, 3}, primeFactors.of(6));
            Assert.Equal(new List<int>() {7}, primeFactors.of(7));
            Assert.Equal(new List<int>() {2, 2, 2}, primeFactors.of(8));
            Assert.Equal(new List<int>() {3, 3}, primeFactors.of(9));
            Assert.Equal(new List<int>() {2, 5}, primeFactors.of(10));
            Assert.Equal(new List<int>() {2,2,3,3,5,7,11,13}, 
                primeFactors.of(2*2*3*3*5*7*11*13));
        }
    }
}
