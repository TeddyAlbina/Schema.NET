namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A simple system that adds up the number of risk factors to yield a score that is associated with prognosis, e...
    /// </summary>
    [DataContract]
    public class MedicalRiskScore : MedicalRiskEstimator
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalRiskScore";
    }
}
