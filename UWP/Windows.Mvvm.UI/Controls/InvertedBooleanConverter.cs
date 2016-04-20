﻿
#region Using Directives

using System;
using Windows.UI.Xaml.Data;

#endregion

namespace Windows.UI.Xaml.Controls
{
    /// <summary>
    /// Convertes boolean values into their negated boolean value (true => false, false => true).
    /// </summary>
    public class InvertedBooleanConverter : IValueConverter
    {
        #region IValueConverter Implementation

        /// <summary>
        /// Convertes the boolean value parameter to its inverted boolean value. True converts to false and false converts to true.
        /// </summary>
        /// <param name="value">The boolean value that is to be converted.</param>
        /// <param name="targetType">The type to which the value is to be converted. In this case it is always <see cref="bool"/>.</param>
        /// <param name="parameter">A parameter for the conversion. Not used in this converter, so it should always be null.</param>
        /// <param name="language">The name of the language, so that parsing can be adjusted to cultural conventions.</param>
        /// <returns>Returns false if the value is true and true if the value is false.</returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
                return DependencyProperty.UnsetValue;
            return (bool)value ? false : true;
        }

        /// <summary>
        /// Convertes the visibility value parameter to a boolean value. Visible converts to true and collapsed converts to false.
        /// </summary>
        /// <param name="value">The visibility value that is to be converted.</param>
        /// <param name="targetType">The type to which the value is to be converted. In this case it is always <see cref="bool"/>.</param>
        /// <param name="parameter">A parameter for the conversion. Not used in this converter, so it should always be null.</param>
        /// <param name="language">The name of the language, so that parsing can be adjusted to cultural conventions.</param>
        /// <returns>Returns true if the value is <see cref="Visible"/> and false if the value is <see cref="Collapsed"/>.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
                return DependencyProperty.UnsetValue;
            return (bool)value ? false : true;
        }

        #endregion
    }
}