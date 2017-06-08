namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A camping pitch is an individual place for overnight stay in the outdoors, typically being part of a larger camping site...
    /// </summary>
    [DataContract]
    public class CampingPitch : Accommodation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "CampingPitch";
    }
}
