﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/27/2022 9:27:22 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for ArchiveMarkedRecordSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ArchiveMarkedRecordSingle")]
    public partial class ArchiveMarkedRecordSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ArchiveMarkedRecord>
    {
        /// <summary>
        /// Initialize a new ArchiveMarkedRecordSingle object.
        /// </summary>
        public ArchiveMarkedRecordSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ArchiveMarkedRecordSingle object.
        /// </summary>
        public ArchiveMarkedRecordSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ArchiveMarkedRecordSingle object.
        /// </summary>
        public ArchiveMarkedRecordSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ArchiveMarkedRecord> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ArchiveMarkedRecord in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ArchiveRunId
    /// ArchiveBundleId
    /// EntityLogicalName
    /// RecordId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ArchiveRunId", "ArchiveBundleId", "EntityLogicalName", "RecordId")]
    [global::Microsoft.OData.Client.EntitySet("ArchiveMarkedRecords")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ArchiveMarkedRecord")]
    public partial class ArchiveMarkedRecord : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ArchiveMarkedRecord object.
        /// </summary>
        /// <param name="archiveRunId">Initial value of ArchiveRunId.</param>
        /// <param name="archiveBundleId">Initial value of ArchiveBundleId.</param>
        /// <param name="entityLogicalName">Initial value of EntityLogicalName.</param>
        /// <param name="recordId">Initial value of RecordId.</param>
        /// <param name="shouldDelete">Initial value of ShouldDelete.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ArchiveMarkedRecord CreateArchiveMarkedRecord(string archiveRunId, string archiveBundleId, string entityLogicalName, long recordId, int shouldDelete)
        {
            ArchiveMarkedRecord archiveMarkedRecord = new ArchiveMarkedRecord();
            archiveMarkedRecord.ArchiveRunId = archiveRunId;
            archiveMarkedRecord.ArchiveBundleId = archiveBundleId;
            archiveMarkedRecord.EntityLogicalName = entityLogicalName;
            archiveMarkedRecord.RecordId = recordId;
            archiveMarkedRecord.ShouldDelete = shouldDelete;
            return archiveMarkedRecord;
        }
        /// <summary>
        /// There are no comments for Property ArchiveRunId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ArchiveRunId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ArchiveRunId is required.")]
        public virtual string ArchiveRunId
        {
            get
            {
                return this._ArchiveRunId;
            }
            set
            {
                this.OnArchiveRunIdChanging(value);
                this._ArchiveRunId = value;
                this.OnArchiveRunIdChanged();
                this.OnPropertyChanged("ArchiveRunId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ArchiveRunId;
        partial void OnArchiveRunIdChanging(string value);
        partial void OnArchiveRunIdChanged();
        /// <summary>
        /// There are no comments for Property ArchiveBundleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ArchiveBundleId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ArchiveBundleId is required.")]
        public virtual string ArchiveBundleId
        {
            get
            {
                return this._ArchiveBundleId;
            }
            set
            {
                this.OnArchiveBundleIdChanging(value);
                this._ArchiveBundleId = value;
                this.OnArchiveBundleIdChanged();
                this.OnPropertyChanged("ArchiveBundleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ArchiveBundleId;
        partial void OnArchiveBundleIdChanging(string value);
        partial void OnArchiveBundleIdChanged();
        /// <summary>
        /// There are no comments for Property EntityLogicalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EntityLogicalName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EntityLogicalName is required.")]
        public virtual string EntityLogicalName
        {
            get
            {
                return this._EntityLogicalName;
            }
            set
            {
                this.OnEntityLogicalNameChanging(value);
                this._EntityLogicalName = value;
                this.OnEntityLogicalNameChanged();
                this.OnPropertyChanged("EntityLogicalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EntityLogicalName;
        partial void OnEntityLogicalNameChanging(string value);
        partial void OnEntityLogicalNameChanged();
        /// <summary>
        /// There are no comments for Property RecordId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecordId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RecordId is required.")]
        public virtual long RecordId
        {
            get
            {
                return this._RecordId;
            }
            set
            {
                this.OnRecordIdChanging(value);
                this._RecordId = value;
                this.OnRecordIdChanged();
                this.OnPropertyChanged("RecordId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _RecordId;
        partial void OnRecordIdChanging(long value);
        partial void OnRecordIdChanged();
        /// <summary>
        /// There are no comments for Property ShouldDelete in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShouldDelete")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShouldDelete is required.")]
        public virtual int ShouldDelete
        {
            get
            {
                return this._ShouldDelete;
            }
            set
            {
                this.OnShouldDeleteChanging(value);
                this._ShouldDelete = value;
                this.OnShouldDeleteChanged();
                this.OnPropertyChanged("ShouldDelete");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ShouldDelete;
        partial void OnShouldDeleteChanging(int value);
        partial void OnShouldDeleteChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}