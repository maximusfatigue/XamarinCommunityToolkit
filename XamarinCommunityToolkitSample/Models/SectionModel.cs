﻿using System;
using Xamarin.Forms;

namespace XamarinCommunityToolkitSample.Models
{
    public sealed class SectionModel
    {
        public SectionModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public SectionModel(Type type, string title, Color color, string description)
        {
            Type = type;
            Title = title;
            Description = description;
            Color = color;
        }

        public Type Type { get; }
        public string Title { get; }
        public string Description { get; }
        public Color Color { get; }
    }
}