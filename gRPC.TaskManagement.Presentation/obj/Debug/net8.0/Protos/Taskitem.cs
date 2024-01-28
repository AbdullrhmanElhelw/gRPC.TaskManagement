// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/taskitem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace gRPC.TaskManagement.Presentation {

  /// <summary>Holder for reflection information generated from Protos/taskitem.proto</summary>
  public static partial class TaskitemReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/taskitem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TaskitemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQcm90b3MvdGFza2l0ZW0ucHJvdG8ikwEKEUNyZWF0ZVRhc2tSZXF1ZXN0",
            "EgwKBE5hbWUYASABKAkSEwoLRGVzY3JpcHRpb24YAiABKAkSFwoGU3RhdHVz",
            "GAMgASgOMgcuU3RhdHVzEhsKCFByaW9yaXR5GAQgASgOMgkuUHJpb3JpdHkS",
            "EgoKQ2F0ZWdvcnlJZBgFIAEoBRIRCglQcm9qZWN0SWQYBiABKAUiJAoSQ3Jl",
            "YXRlVGFza1Jlc3BvbnNlEg4KBnN0YXR1cxgBIAEoBSoxCgZTdGF0dXMSCAoE",
            "T3BlbhAAEg4KCkluUHJvZ3Jlc3MQARINCglDb21wbGV0ZWQQAiopCghQcmlv",
            "cml0eRIICgRIaWdoEAASCgoGTWVkaXVtEAESBwoDTG93EAIySAoPVGFza0l0",
            "ZW1TZXJ2aWNlEjUKCkNyZWF0ZVRhc2sSEi5DcmVhdGVUYXNrUmVxdWVzdBoT",
            "LkNyZWF0ZVRhc2tSZXNwb25zZUIjqgIgZ1JQQy5UYXNrTWFuYWdlbWVudC5Q",
            "cmVzZW50YXRpb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::gRPC.TaskManagement.Presentation.Status), typeof(global::gRPC.TaskManagement.Presentation.Priority), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::gRPC.TaskManagement.Presentation.CreateTaskRequest), global::gRPC.TaskManagement.Presentation.CreateTaskRequest.Parser, new[]{ "Name", "Description", "Status", "Priority", "CategoryId", "ProjectId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::gRPC.TaskManagement.Presentation.CreateTaskResponse), global::gRPC.TaskManagement.Presentation.CreateTaskResponse.Parser, new[]{ "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum Status {
    [pbr::OriginalName("Open")] Open = 0,
    [pbr::OriginalName("InProgress")] InProgress = 1,
    [pbr::OriginalName("Completed")] Completed = 2,
  }

  public enum Priority {
    [pbr::OriginalName("High")] High = 0,
    [pbr::OriginalName("Medium")] Medium = 1,
    [pbr::OriginalName("Low")] Low = 2,
  }

  #endregion

  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CreateTaskRequest : pb::IMessage<CreateTaskRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CreateTaskRequest> _parser = new pb::MessageParser<CreateTaskRequest>(() => new CreateTaskRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CreateTaskRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gRPC.TaskManagement.Presentation.TaskitemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateTaskRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateTaskRequest(CreateTaskRequest other) : this() {
      name_ = other.name_;
      description_ = other.description_;
      status_ = other.status_;
      priority_ = other.priority_;
      categoryId_ = other.categoryId_;
      projectId_ = other.projectId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateTaskRequest Clone() {
      return new CreateTaskRequest(this);
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Description" field.</summary>
    public const int DescriptionFieldNumber = 2;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Status" field.</summary>
    public const int StatusFieldNumber = 3;
    private global::gRPC.TaskManagement.Presentation.Status status_ = global::gRPC.TaskManagement.Presentation.Status.Open;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::gRPC.TaskManagement.Presentation.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "Priority" field.</summary>
    public const int PriorityFieldNumber = 4;
    private global::gRPC.TaskManagement.Presentation.Priority priority_ = global::gRPC.TaskManagement.Presentation.Priority.High;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::gRPC.TaskManagement.Presentation.Priority Priority {
      get { return priority_; }
      set {
        priority_ = value;
      }
    }

    /// <summary>Field number for the "CategoryId" field.</summary>
    public const int CategoryIdFieldNumber = 5;
    private int categoryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CategoryId {
      get { return categoryId_; }
      set {
        categoryId_ = value;
      }
    }

    /// <summary>Field number for the "ProjectId" field.</summary>
    public const int ProjectIdFieldNumber = 6;
    private int projectId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ProjectId {
      get { return projectId_; }
      set {
        projectId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CreateTaskRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CreateTaskRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (Status != other.Status) return false;
      if (Priority != other.Priority) return false;
      if (CategoryId != other.CategoryId) return false;
      if (ProjectId != other.ProjectId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Status != global::gRPC.TaskManagement.Presentation.Status.Open) hash ^= Status.GetHashCode();
      if (Priority != global::gRPC.TaskManagement.Presentation.Priority.High) hash ^= Priority.GetHashCode();
      if (CategoryId != 0) hash ^= CategoryId.GetHashCode();
      if (ProjectId != 0) hash ^= ProjectId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (Status != global::gRPC.TaskManagement.Presentation.Status.Open) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (Priority != global::gRPC.TaskManagement.Presentation.Priority.High) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Priority);
      }
      if (CategoryId != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(CategoryId);
      }
      if (ProjectId != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(ProjectId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (Status != global::gRPC.TaskManagement.Presentation.Status.Open) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (Priority != global::gRPC.TaskManagement.Presentation.Priority.High) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Priority);
      }
      if (CategoryId != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(CategoryId);
      }
      if (ProjectId != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(ProjectId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Status != global::gRPC.TaskManagement.Presentation.Status.Open) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (Priority != global::gRPC.TaskManagement.Presentation.Priority.High) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Priority);
      }
      if (CategoryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CategoryId);
      }
      if (ProjectId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ProjectId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CreateTaskRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Status != global::gRPC.TaskManagement.Presentation.Status.Open) {
        Status = other.Status;
      }
      if (other.Priority != global::gRPC.TaskManagement.Presentation.Priority.High) {
        Priority = other.Priority;
      }
      if (other.CategoryId != 0) {
        CategoryId = other.CategoryId;
      }
      if (other.ProjectId != 0) {
        ProjectId = other.ProjectId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
          case 24: {
            Status = (global::gRPC.TaskManagement.Presentation.Status) input.ReadEnum();
            break;
          }
          case 32: {
            Priority = (global::gRPC.TaskManagement.Presentation.Priority) input.ReadEnum();
            break;
          }
          case 40: {
            CategoryId = input.ReadInt32();
            break;
          }
          case 48: {
            ProjectId = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
          case 24: {
            Status = (global::gRPC.TaskManagement.Presentation.Status) input.ReadEnum();
            break;
          }
          case 32: {
            Priority = (global::gRPC.TaskManagement.Presentation.Priority) input.ReadEnum();
            break;
          }
          case 40: {
            CategoryId = input.ReadInt32();
            break;
          }
          case 48: {
            ProjectId = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CreateTaskResponse : pb::IMessage<CreateTaskResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CreateTaskResponse> _parser = new pb::MessageParser<CreateTaskResponse>(() => new CreateTaskResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CreateTaskResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gRPC.TaskManagement.Presentation.TaskitemReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateTaskResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateTaskResponse(CreateTaskResponse other) : this() {
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateTaskResponse Clone() {
      return new CreateTaskResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private int status_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CreateTaskResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CreateTaskResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CreateTaskResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
          case 8: {
            Status = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Status = input.ReadInt32();
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