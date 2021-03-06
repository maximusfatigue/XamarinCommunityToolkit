﻿namespace XamarinCommunityToolkitSample.Models.Converters
{
    public class ConverterSectionModel
    {
        public ConverterSectionModel(ConverterSectionId id)
        {
            Id = id;
            Title = id.GetTitle();
        }

        public ConverterSectionId Id { get; }
        public string Title { get; }
    }
}
