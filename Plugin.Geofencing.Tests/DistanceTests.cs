﻿using System;
using FluentAssertions;
using Xunit;


namespace Plugin.Geofencing.Abstractions.Tests
{
    public class DistanceTests
    {
        [Fact]
        public void MetersToKm() =>
            Distance
                .FromMeters(2000)
                .TotalKilometers
                .Should()
                .Be(2);


        [Fact]
        public void MilesToKm() =>
            Distance
                .FromMiles(2)
                .TotalKilometers
                .Should()
                .Be(3.21868);


        [Fact]
        public void KmToMiles() =>
            Distance
                .FromKilometers(2)
                .TotalMiles
                .Should()
                .Be(1.242742);
    }
}
