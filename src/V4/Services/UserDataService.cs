// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/services/user_data_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/services/user_data_service.proto</summary>
  public static partial class UserDataServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/services/user_data_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserDataServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9zZXJ2aWNlcy91c2VyX2RhdGFf",
            "c2VydmljZS5wcm90bxIgZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQuc2Vydmlj",
            "ZXMaNmdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Y0L2NvbW1vbi9vZmZsaW5lX3Vz",
            "ZXJfZGF0YS5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxof",
            "Z29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoeZ29vZ2xlL3Byb3Rv",
            "YnVmL3dyYXBwZXJzLnByb3RvGhdnb29nbGUvYXBpL2NsaWVudC5wcm90byL3",
            "AQoVVXBsb2FkVXNlckRhdGFSZXF1ZXN0EhgKC2N1c3RvbWVyX2lkGAEgASgJ",
            "QgPgQQISTAoKb3BlcmF0aW9ucxgDIAMoCzIzLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnY0LnNlcnZpY2VzLlVzZXJEYXRhT3BlcmF0aW9uQgPgQQISagohY3Vz",
            "dG9tZXJfbWF0Y2hfdXNlcl9saXN0X21ldGFkYXRhGAIgASgLMj0uZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjQuY29tbW9uLkN1c3RvbWVyTWF0Y2hVc2VyTGlz",
            "dE1ldGFkYXRhSABCCgoIbWV0YWRhdGEimAEKEVVzZXJEYXRhT3BlcmF0aW9u",
            "EjoKBmNyZWF0ZRgBIAEoCzIoLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LmNv",
            "bW1vbi5Vc2VyRGF0YUgAEjoKBnJlbW92ZRgCIAEoCzIoLmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnY0LmNvbW1vbi5Vc2VyRGF0YUgAQgsKCW9wZXJhdGlvbiKQ",
            "AQoWVXBsb2FkVXNlckRhdGFSZXNwb25zZRI2ChB1cGxvYWRfZGF0ZV90aW1l",
            "GAEgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlEj4KGXJlY2Vp",
            "dmVkX29wZXJhdGlvbnNfY291bnQYAiABKAsyGy5nb29nbGUucHJvdG9idWYu",
            "SW50MzJWYWx1ZTLtAQoPVXNlckRhdGFTZXJ2aWNlErwBCg5VcGxvYWRVc2Vy",
            "RGF0YRI3Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LnNlcnZpY2VzLlVwbG9h",
            "ZFVzZXJEYXRhUmVxdWVzdBo4Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LnNl",
            "cnZpY2VzLlVwbG9hZFVzZXJEYXRhUmVzcG9uc2UiN4LT5JMCMSIsL3Y0L2N1",
            "c3RvbWVycy97Y3VzdG9tZXJfaWQ9Kn06dXBsb2FkVXNlckRhdGE6ASoaG8pB",
            "GGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbUL7AQokY29tLmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnY0LnNlcnZpY2VzQhRVc2VyRGF0YVNlcnZpY2VQcm90b1AB",
            "Wkhnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjQvc2VydmljZXM7c2VydmljZXOiAgNHQUGqAiBHb29nbGUu",
            "QWRzLkdvb2dsZUFkcy5WNC5TZXJ2aWNlc8oCIEdvb2dsZVxBZHNcR29vZ2xl",
            "QWRzXFY0XFNlcnZpY2Vz6gIkR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjQ6",
            "OlNlcnZpY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V4.Common.OfflineUserDataReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Services.UploadUserDataRequest), global::Google.Ads.GoogleAds.V4.Services.UploadUserDataRequest.Parser, new[]{ "CustomerId", "Operations", "CustomerMatchUserListMetadata" }, new[]{ "Metadata" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Services.UserDataOperation), global::Google.Ads.GoogleAds.V4.Services.UserDataOperation.Parser, new[]{ "Create", "Remove" }, new[]{ "Operation" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Services.UploadUserDataResponse), global::Google.Ads.GoogleAds.V4.Services.UploadUserDataResponse.Parser, new[]{ "UploadDateTime", "ReceivedOperationsCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [UserDataService.UploadUserData][google.ads.googleads.v4.services.UserDataService.UploadUserData]
  /// </summary>
  public sealed partial class UploadUserDataRequest : pb::IMessage<UploadUserDataRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UploadUserDataRequest> _parser = new pb::MessageParser<UploadUserDataRequest>(() => new UploadUserDataRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UploadUserDataRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Services.UserDataServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadUserDataRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadUserDataRequest(UploadUserDataRequest other) : this() {
      customerId_ = other.customerId_;
      operations_ = other.operations_.Clone();
      switch (other.MetadataCase) {
        case MetadataOneofCase.CustomerMatchUserListMetadata:
          CustomerMatchUserListMetadata = other.CustomerMatchUserListMetadata.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadUserDataRequest Clone() {
      return new UploadUserDataRequest(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    /// <summary>
    /// Required. The ID of the customer for which to update the user data.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "operations" field.</summary>
    public const int OperationsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V4.Services.UserDataOperation> _repeated_operations_codec
        = pb::FieldCodec.ForMessage(26, global::Google.Ads.GoogleAds.V4.Services.UserDataOperation.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V4.Services.UserDataOperation> operations_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V4.Services.UserDataOperation>();
    /// <summary>
    /// Required. The list of operations to be done.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V4.Services.UserDataOperation> Operations {
      get { return operations_; }
    }

    /// <summary>Field number for the "customer_match_user_list_metadata" field.</summary>
    public const int CustomerMatchUserListMetadataFieldNumber = 2;
    /// <summary>
    /// Metadata for data updates to a Customer Match user list.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Common.CustomerMatchUserListMetadata CustomerMatchUserListMetadata {
      get { return metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata ? (global::Google.Ads.GoogleAds.V4.Common.CustomerMatchUserListMetadata) metadata_ : null; }
      set {
        metadata_ = value;
        metadataCase_ = value == null ? MetadataOneofCase.None : MetadataOneofCase.CustomerMatchUserListMetadata;
      }
    }

    private object metadata_;
    /// <summary>Enum of possible cases for the "metadata" oneof.</summary>
    public enum MetadataOneofCase {
      None = 0,
      CustomerMatchUserListMetadata = 2,
    }
    private MetadataOneofCase metadataCase_ = MetadataOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MetadataOneofCase MetadataCase {
      get { return metadataCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearMetadata() {
      metadataCase_ = MetadataOneofCase.None;
      metadata_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UploadUserDataRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UploadUserDataRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if(!operations_.Equals(other.operations_)) return false;
      if (!object.Equals(CustomerMatchUserListMetadata, other.CustomerMatchUserListMetadata)) return false;
      if (MetadataCase != other.MetadataCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      hash ^= operations_.GetHashCode();
      if (metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata) hash ^= CustomerMatchUserListMetadata.GetHashCode();
      hash ^= (int) metadataCase_;
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      if (metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata) {
        output.WriteRawTag(18);
        output.WriteMessage(CustomerMatchUserListMetadata);
      }
      operations_.WriteTo(output, _repeated_operations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      if (metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata) {
        output.WriteRawTag(18);
        output.WriteMessage(CustomerMatchUserListMetadata);
      }
      operations_.WriteTo(ref output, _repeated_operations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      size += operations_.CalculateSize(_repeated_operations_codec);
      if (metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CustomerMatchUserListMetadata);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UploadUserDataRequest other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      operations_.Add(other.operations_);
      switch (other.MetadataCase) {
        case MetadataOneofCase.CustomerMatchUserListMetadata:
          if (CustomerMatchUserListMetadata == null) {
            CustomerMatchUserListMetadata = new global::Google.Ads.GoogleAds.V4.Common.CustomerMatchUserListMetadata();
          }
          CustomerMatchUserListMetadata.MergeFrom(other.CustomerMatchUserListMetadata);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            global::Google.Ads.GoogleAds.V4.Common.CustomerMatchUserListMetadata subBuilder = new global::Google.Ads.GoogleAds.V4.Common.CustomerMatchUserListMetadata();
            if (metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata) {
              subBuilder.MergeFrom(CustomerMatchUserListMetadata);
            }
            input.ReadMessage(subBuilder);
            CustomerMatchUserListMetadata = subBuilder;
            break;
          }
          case 26: {
            operations_.AddEntriesFrom(input, _repeated_operations_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            global::Google.Ads.GoogleAds.V4.Common.CustomerMatchUserListMetadata subBuilder = new global::Google.Ads.GoogleAds.V4.Common.CustomerMatchUserListMetadata();
            if (metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata) {
              subBuilder.MergeFrom(CustomerMatchUserListMetadata);
            }
            input.ReadMessage(subBuilder);
            CustomerMatchUserListMetadata = subBuilder;
            break;
          }
          case 26: {
            operations_.AddEntriesFrom(ref input, _repeated_operations_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Operation to be made for the UploadUserDataRequest.
  /// </summary>
  public sealed partial class UserDataOperation : pb::IMessage<UserDataOperation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserDataOperation> _parser = new pb::MessageParser<UserDataOperation>(() => new UserDataOperation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserDataOperation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Services.UserDataServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserDataOperation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserDataOperation(UserDataOperation other) : this() {
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          Create = other.Create.Clone();
          break;
        case OperationOneofCase.Remove:
          Remove = other.Remove.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserDataOperation Clone() {
      return new UserDataOperation(this);
    }

    /// <summary>Field number for the "create" field.</summary>
    public const int CreateFieldNumber = 1;
    /// <summary>
    /// The list of user data to be appended to the user list.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Common.UserData Create {
      get { return operationCase_ == OperationOneofCase.Create ? (global::Google.Ads.GoogleAds.V4.Common.UserData) operation_ : null; }
      set {
        operation_ = value;
        operationCase_ = value == null ? OperationOneofCase.None : OperationOneofCase.Create;
      }
    }

    /// <summary>Field number for the "remove" field.</summary>
    public const int RemoveFieldNumber = 2;
    /// <summary>
    /// The list of user data to be removed from the user list.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Common.UserData Remove {
      get { return operationCase_ == OperationOneofCase.Remove ? (global::Google.Ads.GoogleAds.V4.Common.UserData) operation_ : null; }
      set {
        operation_ = value;
        operationCase_ = value == null ? OperationOneofCase.None : OperationOneofCase.Remove;
      }
    }

    private object operation_;
    /// <summary>Enum of possible cases for the "operation" oneof.</summary>
    public enum OperationOneofCase {
      None = 0,
      Create = 1,
      Remove = 2,
    }
    private OperationOneofCase operationCase_ = OperationOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperationOneofCase OperationCase {
      get { return operationCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearOperation() {
      operationCase_ = OperationOneofCase.None;
      operation_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserDataOperation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserDataOperation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Create, other.Create)) return false;
      if (!object.Equals(Remove, other.Remove)) return false;
      if (OperationCase != other.OperationCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (operationCase_ == OperationOneofCase.Create) hash ^= Create.GetHashCode();
      if (operationCase_ == OperationOneofCase.Remove) hash ^= Remove.GetHashCode();
      hash ^= (int) operationCase_;
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (operationCase_ == OperationOneofCase.Create) {
        output.WriteRawTag(10);
        output.WriteMessage(Create);
      }
      if (operationCase_ == OperationOneofCase.Remove) {
        output.WriteRawTag(18);
        output.WriteMessage(Remove);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (operationCase_ == OperationOneofCase.Create) {
        output.WriteRawTag(10);
        output.WriteMessage(Create);
      }
      if (operationCase_ == OperationOneofCase.Remove) {
        output.WriteRawTag(18);
        output.WriteMessage(Remove);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (operationCase_ == OperationOneofCase.Create) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Create);
      }
      if (operationCase_ == OperationOneofCase.Remove) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Remove);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserDataOperation other) {
      if (other == null) {
        return;
      }
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          if (Create == null) {
            Create = new global::Google.Ads.GoogleAds.V4.Common.UserData();
          }
          Create.MergeFrom(other.Create);
          break;
        case OperationOneofCase.Remove:
          if (Remove == null) {
            Remove = new global::Google.Ads.GoogleAds.V4.Common.UserData();
          }
          Remove.MergeFrom(other.Remove);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            global::Google.Ads.GoogleAds.V4.Common.UserData subBuilder = new global::Google.Ads.GoogleAds.V4.Common.UserData();
            if (operationCase_ == OperationOneofCase.Create) {
              subBuilder.MergeFrom(Create);
            }
            input.ReadMessage(subBuilder);
            Create = subBuilder;
            break;
          }
          case 18: {
            global::Google.Ads.GoogleAds.V4.Common.UserData subBuilder = new global::Google.Ads.GoogleAds.V4.Common.UserData();
            if (operationCase_ == OperationOneofCase.Remove) {
              subBuilder.MergeFrom(Remove);
            }
            input.ReadMessage(subBuilder);
            Remove = subBuilder;
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            global::Google.Ads.GoogleAds.V4.Common.UserData subBuilder = new global::Google.Ads.GoogleAds.V4.Common.UserData();
            if (operationCase_ == OperationOneofCase.Create) {
              subBuilder.MergeFrom(Create);
            }
            input.ReadMessage(subBuilder);
            Create = subBuilder;
            break;
          }
          case 18: {
            global::Google.Ads.GoogleAds.V4.Common.UserData subBuilder = new global::Google.Ads.GoogleAds.V4.Common.UserData();
            if (operationCase_ == OperationOneofCase.Remove) {
              subBuilder.MergeFrom(Remove);
            }
            input.ReadMessage(subBuilder);
            Remove = subBuilder;
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Response message for [UserDataService.UploadUserData][google.ads.googleads.v4.services.UserDataService.UploadUserData]
  /// </summary>
  public sealed partial class UploadUserDataResponse : pb::IMessage<UploadUserDataResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UploadUserDataResponse> _parser = new pb::MessageParser<UploadUserDataResponse>(() => new UploadUserDataResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UploadUserDataResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Services.UserDataServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadUserDataResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadUserDataResponse(UploadUserDataResponse other) : this() {
      UploadDateTime = other.UploadDateTime;
      ReceivedOperationsCount = other.ReceivedOperationsCount;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadUserDataResponse Clone() {
      return new UploadUserDataResponse(this);
    }

    /// <summary>Field number for the "upload_date_time" field.</summary>
    public const int UploadDateTimeFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_uploadDateTime_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string uploadDateTime_;
    /// <summary>
    /// The date time at which the request was received by API, formatted as
    /// "yyyy-mm-dd hh:mm:ss+|-hh:mm", e.g. "2019-01-01 12:32:45-08:00".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UploadDateTime {
      get { return uploadDateTime_; }
      set {
        uploadDateTime_ = value;
      }
    }


    /// <summary>Field number for the "received_operations_count" field.</summary>
    public const int ReceivedOperationsCountFieldNumber = 2;
    private static readonly pb::FieldCodec<int?> _single_receivedOperationsCount_codec = pb::FieldCodec.ForStructWrapper<int>(18);
    private int? receivedOperationsCount_;
    /// <summary>
    /// Number of upload data operations received by API.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int? ReceivedOperationsCount {
      get { return receivedOperationsCount_; }
      set {
        receivedOperationsCount_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UploadUserDataResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UploadUserDataResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UploadDateTime != other.UploadDateTime) return false;
      if (ReceivedOperationsCount != other.ReceivedOperationsCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (uploadDateTime_ != null) hash ^= UploadDateTime.GetHashCode();
      if (receivedOperationsCount_ != null) hash ^= ReceivedOperationsCount.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (uploadDateTime_ != null) {
        _single_uploadDateTime_codec.WriteTagAndValue(output, UploadDateTime);
      }
      if (receivedOperationsCount_ != null) {
        _single_receivedOperationsCount_codec.WriteTagAndValue(output, ReceivedOperationsCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (uploadDateTime_ != null) {
        _single_uploadDateTime_codec.WriteTagAndValue(ref output, UploadDateTime);
      }
      if (receivedOperationsCount_ != null) {
        _single_receivedOperationsCount_codec.WriteTagAndValue(ref output, ReceivedOperationsCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (uploadDateTime_ != null) {
        size += _single_uploadDateTime_codec.CalculateSizeWithTag(UploadDateTime);
      }
      if (receivedOperationsCount_ != null) {
        size += _single_receivedOperationsCount_codec.CalculateSizeWithTag(ReceivedOperationsCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UploadUserDataResponse other) {
      if (other == null) {
        return;
      }
      if (other.uploadDateTime_ != null) {
        if (uploadDateTime_ == null || other.UploadDateTime != "") {
          UploadDateTime = other.UploadDateTime;
        }
      }
      if (other.receivedOperationsCount_ != null) {
        if (receivedOperationsCount_ == null || other.ReceivedOperationsCount != 0) {
          ReceivedOperationsCount = other.ReceivedOperationsCount;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            string value = _single_uploadDateTime_codec.Read(input);
            if (uploadDateTime_ == null || value != "") {
              UploadDateTime = value;
            }
            break;
          }
          case 18: {
            int? value = _single_receivedOperationsCount_codec.Read(input);
            if (receivedOperationsCount_ == null || value != 0) {
              ReceivedOperationsCount = value;
            }
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            string value = _single_uploadDateTime_codec.Read(ref input);
            if (uploadDateTime_ == null || value != "") {
              UploadDateTime = value;
            }
            break;
          }
          case 18: {
            int? value = _single_receivedOperationsCount_codec.Read(ref input);
            if (receivedOperationsCount_ == null || value != 0) {
              ReceivedOperationsCount = value;
            }
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
