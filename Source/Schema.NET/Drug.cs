namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism...
    /// </summary>
    [DataContract]
    public class Drug : Substance
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Drug";
    }
}
