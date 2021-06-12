using System;
using System.Collections.Generic;

namespace CourseLibrary.API.Services
{
    // used inside PropertyMappingService
    public class PropertyMappingValue
    {
        public IEnumerable<string> DestinationProperties { get; private set; }

        // if Age is come as property from client side, destination property is DateOfBirth
        // Age Ascending order mean, Descending order of DateOfBirth
        // To Identify it, when genrate Query, "Revert" property is used
        public bool Revert { get; private set; }

        public PropertyMappingValue(IEnumerable<string> destinationProperties,
            bool revert = false)
        {
            DestinationProperties = destinationProperties
                ?? throw new ArgumentNullException(nameof(destinationProperties));
            Revert = revert;
        }
    }
}
