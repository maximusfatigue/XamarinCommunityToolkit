﻿using XamarinCommunityToolkit.Converters;
using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;
using System;
using Xunit;

namespace XamarinCommunityToolkit.UnitTests.Converters
{
    public class ItemSelectedEventArgsConverter_Tests
    {
        static object expectedValue = 100;

        public static IEnumerable<object[]> GetData() => new List<object[]>
        {
            new object[] { new SelectedItemChangedEventArgs(expectedValue), expectedValue},
        };

        [Theory]
        [MemberData(nameof(GetData))]
        public void ItemSelectedEventArgsConverter(SelectedItemChangedEventArgs value, object expectedResult)
        {
            var itemSelectedEventArgsConverter = new ItemSelectedEventArgsConverter();

            var result = itemSelectedEventArgsConverter.Convert(value, typeof(ItemSelectedEventArgsConverter), null, CultureInfo.CurrentCulture);
            Assert.Equal(result, expectedResult);
        }

        [Theory]
        [InlineData("Random String")]
        public void InvalidConverterValuesThrowsArgumenException(object value)
        {
            var itemSelectedEventArgsConverter = new ItemSelectedEventArgsConverter();
            Assert.Throws<ArgumentException>(() => itemSelectedEventArgsConverter.Convert(value, typeof(ItemSelectedEventArgsConverter), null, CultureInfo.CurrentCulture));
        }
    }
}