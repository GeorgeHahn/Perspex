﻿// -----------------------------------------------------------------------
// <copyright file="Brushes.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace Perspex.Media
{
    /// <summary>
    /// Predefined brushes.
    /// </summary>
    public static class Brushes
    {
        static Brushes()
        {
            Black = new SolidColorBrush(0xff000000);
        }

        public static SolidColorBrush Black
        {
            get;
            private set;
        }
    }
}