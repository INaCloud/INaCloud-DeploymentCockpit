﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DeploymentCockpit.Common
{
    public static class GeneralExtensions
    {
        public static T Do<T>(this T obj, Action<T> action)
        {
            action(obj);
            return obj;
        }

        public static TOut To<TIn, TOut>(this TIn obj, Func<TIn, TOut> fn)
        {
            return fn(obj);
        }

        public static T? Map<T>(this T? nullable, Func<T, T> fn)
            where T : struct
        {
            return nullable.HasValue ? fn(nullable.Value) : nullable;
        }

        /// <summary>
        /// Checks if current object is contained in passed array of objects of same type
        /// </summary>
        public static bool ContainedIn<T>(this T item, params T[] items)
        {
            return items.Contains(item);
        }

        /// <summary>
        /// Checks if current object is contained in passed collection of objects of same type
        /// </summary>
        public static bool ContainedIn<T>(this T item, IEnumerable<T> items)
        {
            return items.Contains(item);
        }

        public static bool IsBetween<T>(this T value, T fromValue, T toValue)
            where T : IComparable
        {
            return value.CompareTo(fromValue) >= 0
                && value.CompareTo(toValue) <= 0;
        }
    }
}
