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
    /// <para>Renamed files and/or folders.</para>
    /// </summary>
    public class FileRenameDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileRenameDetails> Encoder = new FileRenameDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileRenameDetails> Decoder = new FileRenameDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileRenameDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="relocateActionDetails">Relocate action details.</param>
        public FileRenameDetails(col.IEnumerable<RelocateAssetReferencesLogInfo> relocateActionDetails)
        {
            var relocateActionDetailsList = enc.Util.ToList(relocateActionDetails);

            if (relocateActionDetails == null)
            {
                throw new sys.ArgumentNullException("relocateActionDetails");
            }

            this.RelocateActionDetails = relocateActionDetailsList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileRenameDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public FileRenameDetails()
        {
        }

        /// <summary>
        /// <para>Relocate action details.</para>
        /// </summary>
        public col.IList<RelocateAssetReferencesLogInfo> RelocateActionDetails { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileRenameDetails" />.</para>
        /// </summary>
        private class FileRenameDetailsEncoder : enc.StructEncoder<FileRenameDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileRenameDetails value, enc.IJsonWriter writer)
            {
                WriteListProperty("relocate_action_details", value.RelocateActionDetails, writer, global::Dropbox.Api.TeamLog.RelocateAssetReferencesLogInfo.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileRenameDetails" />.</para>
        /// </summary>
        private class FileRenameDetailsDecoder : enc.StructDecoder<FileRenameDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileRenameDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileRenameDetails Create()
            {
                return new FileRenameDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileRenameDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "relocate_action_details":
                        value.RelocateActionDetails = ReadList<RelocateAssetReferencesLogInfo>(reader, global::Dropbox.Api.TeamLog.RelocateAssetReferencesLogInfo.Decoder);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
