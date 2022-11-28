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
    /// There are no comments for LineDiscountVendorGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LineDiscountVendorGroupSingle")]
    public partial class LineDiscountVendorGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LineDiscountVendorGroup>
    {
        /// <summary>
        /// Initialize a new LineDiscountVendorGroupSingle object.
        /// </summary>
        public LineDiscountVendorGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LineDiscountVendorGroupSingle object.
        /// </summary>
        public LineDiscountVendorGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LineDiscountVendorGroupSingle object.
        /// </summary>
        public LineDiscountVendorGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LineDiscountVendorGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for OpenPurchaseLineDiscountJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("OpenPurchaseLineDiscountJournalLine")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.OpenPurchaseLineDiscountJournalLine> OpenPurchaseLineDiscountJournalLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OpenPurchaseLineDiscountJournalLine == null))
                {
                    this._OpenPurchaseLineDiscountJournalLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.OpenPurchaseLineDiscountJournalLine>(GetPath("OpenPurchaseLineDiscountJournalLine"));
                }
                return this._OpenPurchaseLineDiscountJournalLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.OpenPurchaseLineDiscountJournalLine> _OpenPurchaseLineDiscountJournalLine;
    }
    /// <summary>
    /// There are no comments for LineDiscountVendorGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// GroupCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GroupCode")]
    [global::Microsoft.OData.Client.EntitySet("LineDiscountVendorGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LineDiscountVendorGroup")]
    public partial class LineDiscountVendorGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LineDiscountVendorGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="groupCode">Initial value of GroupCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LineDiscountVendorGroup CreateLineDiscountVendorGroup(string dataAreaId, string groupCode)
        {
            LineDiscountVendorGroup lineDiscountVendorGroup = new LineDiscountVendorGroup();
            lineDiscountVendorGroup.DataAreaId = dataAreaId;
            lineDiscountVendorGroup.GroupCode = groupCode;
            return lineDiscountVendorGroup;
        }
        /// <summary>
        /// There are no comments for Property DataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("dataAreaId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DataAreaId is required.")]
        public virtual string DataAreaId
        {
            get
            {
                return this._DataAreaId;
            }
            set
            {
                this.OnDataAreaIdChanging(value);
                this._DataAreaId = value;
                this.OnDataAreaIdChanged();
                this.OnPropertyChanged("dataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataAreaId;
        partial void OnDataAreaIdChanging(string value);
        partial void OnDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property GroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GroupCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GroupCode is required.")]
        public virtual string GroupCode
        {
            get
            {
                return this._GroupCode;
            }
            set
            {
                this.OnGroupCodeChanging(value);
                this._GroupCode = value;
                this.OnGroupCodeChanged();
                this.OnPropertyChanged("GroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupCode;
        partial void OnGroupCodeChanging(string value);
        partial void OnGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property GroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GroupName")]
        public virtual string GroupName
        {
            get
            {
                return this._GroupName;
            }
            set
            {
                this.OnGroupNameChanging(value);
                this._GroupName = value;
                this.OnGroupNameChanged();
                this.OnPropertyChanged("GroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupName;
        partial void OnGroupNameChanging(string value);
        partial void OnGroupNameChanged();
        /// <summary>
        /// There are no comments for Property OpenPurchaseLineDiscountJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OpenPurchaseLineDiscountJournalLine")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenPurchaseLineDiscountJournalLine> OpenPurchaseLineDiscountJournalLine
        {
            get
            {
                return this._OpenPurchaseLineDiscountJournalLine;
            }
            set
            {
                this.OnOpenPurchaseLineDiscountJournalLineChanging(value);
                this._OpenPurchaseLineDiscountJournalLine = value;
                this.OnOpenPurchaseLineDiscountJournalLineChanged();
                this.OnPropertyChanged("OpenPurchaseLineDiscountJournalLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenPurchaseLineDiscountJournalLine> _OpenPurchaseLineDiscountJournalLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenPurchaseLineDiscountJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnOpenPurchaseLineDiscountJournalLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenPurchaseLineDiscountJournalLine> value);
        partial void OnOpenPurchaseLineDiscountJournalLineChanged();
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
