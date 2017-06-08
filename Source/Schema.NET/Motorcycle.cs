namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A motorcycle or motorbike is a single-track, two-wheeled motor vehicle.
    /// </summary>
    [DataContract]
    public class Motorcycle : Vehicle
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Motorcycle";
    }
}
