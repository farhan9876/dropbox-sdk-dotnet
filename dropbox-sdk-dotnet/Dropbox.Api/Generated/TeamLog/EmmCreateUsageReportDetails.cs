// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Created EMM mobile app usage report.</para>
    /// </summary>
    public class EmmCreateUsageReportDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<EmmCreateUsageReportDetails> Encoder = new EmmCreateUsageReportDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<EmmCreateUsageReportDetails> Decoder = new EmmCreateUsageReportDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="EmmCreateUsageReportDetails" />
        /// class.</para>
        /// </summary>
        public EmmCreateUsageReportDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="EmmCreateUsageReportDetails" />.</para>
        /// </summary>
        private class EmmCreateUsageReportDetailsEncoder : enc.StructEncoder<EmmCreateUsageReportDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(EmmCreateUsageReportDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="EmmCreateUsageReportDetails" />.</para>
        /// </summary>
        private class EmmCreateUsageReportDetailsDecoder : enc.StructDecoder<EmmCreateUsageReportDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="EmmCreateUsageReportDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override EmmCreateUsageReportDetails Create()
            {
                return new EmmCreateUsageReportDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(EmmCreateUsageReportDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}