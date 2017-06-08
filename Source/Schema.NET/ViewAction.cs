namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of consuming static visual content.
    /// </summary>
    [DataContract]
    public class ViewAction : ConsumeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ViewAction";
    }
}
