namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of an agent communicating (service provider, social media, etc) their departure of a previously reserved service (e...
    /// </summary>
    [DataContract]
    public class CheckOutAction : CommunicateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "CheckOutAction";
    }
}
