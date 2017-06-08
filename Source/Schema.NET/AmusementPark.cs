namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An amusement park.
    /// </summary>
    [DataContract]
    public class AmusementPark : EntertainmentBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "AmusementPark";
    }
}
