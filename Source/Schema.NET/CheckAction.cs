namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An agent inspects, determines, investigates, inquires, or examines an object's accuracy, quality, condition, or state.
    /// </summary>
    [DataContract]
    public class CheckAction : FindAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "CheckAction";
    }
}
