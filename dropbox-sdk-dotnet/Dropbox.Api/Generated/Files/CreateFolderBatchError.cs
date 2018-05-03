// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The create folder batch error object</para>
    /// </summary>
    public class CreateFolderBatchError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<CreateFolderBatchError> Encoder = new CreateFolderBatchErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<CreateFolderBatchError> Decoder = new CreateFolderBatchErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="CreateFolderBatchError" />
        /// class.</para>
        /// </summary>
        public CreateFolderBatchError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is TooManyFiles</para>
        /// </summary>
        public bool IsTooManyFiles
        {
            get
            {
                return this is TooManyFiles;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TooManyFiles, or <c>null</c>.</para>
        /// </summary>
        public TooManyFiles AsTooManyFiles
        {
            get
            {
                return this as TooManyFiles;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="CreateFolderBatchError" />.</para>
        /// </summary>
        private class CreateFolderBatchErrorEncoder : enc.StructEncoder<CreateFolderBatchError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(CreateFolderBatchError value, enc.IJsonWriter writer)
            {
                if (value is TooManyFiles)
                {
                    WriteProperty(".tag", "too_many_files", writer, enc.StringEncoder.Instance);
                    TooManyFiles.Encoder.EncodeFields((TooManyFiles)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="CreateFolderBatchError" />.</para>
        /// </summary>
        private class CreateFolderBatchErrorDecoder : enc.UnionDecoder<CreateFolderBatchError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="CreateFolderBatchError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override CreateFolderBatchError Create()
            {
                return new CreateFolderBatchError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override CreateFolderBatchError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "too_many_files":
                        return TooManyFiles.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The operation would involve too many files or folders.</para>
        /// </summary>
        public sealed class TooManyFiles : CreateFolderBatchError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<TooManyFiles> Encoder = new TooManyFilesEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<TooManyFiles> Decoder = new TooManyFilesDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TooManyFiles" />
            /// class.</para>
            /// </summary>
            private TooManyFiles()
            {
            }

            /// <summary>
            /// <para>A singleton instance of TooManyFiles</para>
            /// </summary>
            public static readonly TooManyFiles Instance = new TooManyFiles();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="TooManyFiles" />.</para>
            /// </summary>
            private class TooManyFilesEncoder : enc.StructEncoder<TooManyFiles>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(TooManyFiles value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="TooManyFiles" />.</para>
            /// </summary>
            private class TooManyFilesDecoder : enc.StructDecoder<TooManyFiles>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="TooManyFiles" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override TooManyFiles Create()
                {
                    return TooManyFiles.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : CreateFolderBatchError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}