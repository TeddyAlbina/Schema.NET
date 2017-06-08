namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of expressing a positive sentiment about the object. An agent likes an object (a proposition, topic or theme) with participants.
    /// </summary>
    [DataContract]
    public class LikeAction : ReactAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "LikeAction";
    }
}
