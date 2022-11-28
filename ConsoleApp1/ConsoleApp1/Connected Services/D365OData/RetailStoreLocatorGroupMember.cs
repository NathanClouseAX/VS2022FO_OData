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
    /// There are no comments for RetailStoreLocatorGroupMemberSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailStoreLocatorGroupMemberSingle")]
    public partial class RetailStoreLocatorGroupMemberSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailStoreLocatorGroupMember>
    {
        /// <summary>
        /// Initialize a new RetailStoreLocatorGroupMemberSingle object.
        /// </summary>
        public RetailStoreLocatorGroupMemberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailStoreLocatorGroupMemberSingle object.
        /// </summary>
        public RetailStoreLocatorGroupMemberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailStoreLocatorGroupMemberSingle object.
        /// </summary>
        public RetailStoreLocatorGroupMemberSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailStoreLocatorGroupMember> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailStoreLocatorGroupMember in the schema.
    /// </summary>
    /// <KeyProperties>
    /// StoreLocatorGroupName
    /// InventLocationId
    /// InventLocationDataAreaId
    /// OMOperatingUnitNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("StoreLocatorGroupName", "InventLocationId", "InventLocationDataAreaId", "OMOperatingUnitNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailStoreLocatorGroupMembers")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailStoreLocatorGroupMember")]
    public partial class RetailStoreLocatorGroupMember : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailStoreLocatorGroupMember object.
        /// </summary>
        /// <param name="storeLocatorGroupName">Initial value of StoreLocatorGroupName.</param>
        /// <param name="inventLocationId">Initial value of InventLocationId.</param>
        /// <param name="inventLocationDataAreaId">Initial value of InventLocationDataAreaId.</param>
        /// <param name="oMOperatingUnitNumber">Initial value of OMOperatingUnitNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailStoreLocatorGroupMember CreateRetailStoreLocatorGroupMember(string storeLocatorGroupName, string inventLocationId, string inventLocationDataAreaId, string oMOperatingUnitNumber)
        {
            RetailStoreLocatorGroupMember retailStoreLocatorGroupMember = new RetailStoreLocatorGroupMember();
            retailStoreLocatorGroupMember.StoreLocatorGroupName = storeLocatorGroupName;
            retailStoreLocatorGroupMember.InventLocationId = inventLocationId;
            retailStoreLocatorGroupMember.InventLocationDataAreaId = inventLocationDataAreaId;
            retailStoreLocatorGroupMember.OMOperatingUnitNumber = oMOperatingUnitNumber;
            return retailStoreLocatorGroupMember;
        }
        /// <summary>
        /// There are no comments for Property StoreLocatorGroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StoreLocatorGroupName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StoreLocatorGroupName is required.")]
        public virtual string StoreLocatorGroupName
        {
            get
            {
                return this._StoreLocatorGroupName;
            }
            set
            {
                this.OnStoreLocatorGroupNameChanging(value);
                this._StoreLocatorGroupName = value;
                this.OnStoreLocatorGroupNameChanged();
                this.OnPropertyChanged("StoreLocatorGroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StoreLocatorGroupName;
        partial void OnStoreLocatorGroupNameChanging(string value);
        partial void OnStoreLocatorGroupNameChanged();
        /// <summary>
        /// There are no comments for Property InventLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InventLocationId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InventLocationId is required.")]
        public virtual string InventLocationId
        {
            get
            {
                return this._InventLocationId;
            }
            set
            {
                this.OnInventLocationIdChanging(value);
                this._InventLocationId = value;
                this.OnInventLocationIdChanged();
                this.OnPropertyChanged("InventLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventLocationId;
        partial void OnInventLocationIdChanging(string value);
        partial void OnInventLocationIdChanged();
        /// <summary>
        /// There are no comments for Property InventLocationDataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InventLocationDataAreaId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InventLocationDataAreaId is required.")]
        public virtual string InventLocationDataAreaId
        {
            get
            {
                return this._InventLocationDataAreaId;
            }
            set
            {
                this.OnInventLocationDataAreaIdChanging(value);
                this._InventLocationDataAreaId = value;
                this.OnInventLocationDataAreaIdChanged();
                this.OnPropertyChanged("InventLocationDataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventLocationDataAreaId;
        partial void OnInventLocationDataAreaIdChanging(string value);
        partial void OnInventLocationDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property OMOperatingUnitNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OMOperatingUnitNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OMOperatingUnitNumber is required.")]
        public virtual string OMOperatingUnitNumber
        {
            get
            {
                return this._OMOperatingUnitNumber;
            }
            set
            {
                this.OnOMOperatingUnitNumberChanging(value);
                this._OMOperatingUnitNumber = value;
                this.OnOMOperatingUnitNumberChanged();
                this.OnPropertyChanged("OMOperatingUnitNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OMOperatingUnitNumber;
        partial void OnOMOperatingUnitNumberChanging(string value);
        partial void OnOMOperatingUnitNumberChanged();
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