// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/product_bidding_category_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/product_bidding_category_status.proto</summary>
  public static partial class ProductBiddingCategoryStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/product_bidding_category_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductBiddingCategoryStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy9wcm9kdWN0X2JpZGRp",
            "bmdfY2F0ZWdvcnlfc3RhdHVzLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MS5lbnVtcxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byJ6CiBQ",
            "cm9kdWN0QmlkZGluZ0NhdGVnb3J5U3RhdHVzRW51bSJWChxQcm9kdWN0Qmlk",
            "ZGluZ0NhdGVnb3J5U3RhdHVzEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9X",
            "ThABEgoKBkFDVElWRRACEgwKCE9CU09MRVRFEANC9gEKIWNvbS5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52MS5lbnVtc0IhUHJvZHVjdEJpZGRpbmdDYXRlZ29y",
            "eVN0YXR1c1Byb3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dv",
            "b2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MS9lbnVtcztlbnVtc6ICA0dBQaoC",
            "HUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxLkVudW1zygIdR29vZ2xlXEFkc1xH",
            "b29nbGVBZHNcVjFcRW51bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpW",
            "MTo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.ProductBiddingCategoryStatusEnum), global::Google.Ads.GoogleAds.V1.Enums.ProductBiddingCategoryStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.ProductBiddingCategoryStatusEnum.Types.ProductBiddingCategoryStatus) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Status of the product bidding category.
  /// </summary>
  public sealed partial class ProductBiddingCategoryStatusEnum : pb::IMessage<ProductBiddingCategoryStatusEnum> {
    private static readonly pb::MessageParser<ProductBiddingCategoryStatusEnum> _parser = new pb::MessageParser<ProductBiddingCategoryStatusEnum>(() => new ProductBiddingCategoryStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProductBiddingCategoryStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.ProductBiddingCategoryStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductBiddingCategoryStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductBiddingCategoryStatusEnum(ProductBiddingCategoryStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductBiddingCategoryStatusEnum Clone() {
      return new ProductBiddingCategoryStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProductBiddingCategoryStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProductBiddingCategoryStatusEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProductBiddingCategoryStatusEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ProductBiddingCategoryStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing the status of the product bidding category.
      /// </summary>
      public enum ProductBiddingCategoryStatus {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The category is active and can be used for bidding.
        /// </summary>
        [pbr::OriginalName("ACTIVE")] Active = 2,
        /// <summary>
        /// The category is obsolete. Used only for reporting purposes.
        /// </summary>
        [pbr::OriginalName("OBSOLETE")] Obsolete = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code