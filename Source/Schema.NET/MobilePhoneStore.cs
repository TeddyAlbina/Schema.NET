namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A store that sells mobile phones and related accessories.
    /// </summary>
    [DataContract]
    public class MobilePhoneStore : Store
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MobilePhoneStore";
    }
}
