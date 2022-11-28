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
    /// There are no comments for RAssetMainGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RAssetMainGroupSingle")]
    public partial class RAssetMainGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RAssetMainGroup>
    {
        /// <summary>
        /// Initialize a new RAssetMainGroupSingle object.
        /// </summary>
        public RAssetMainGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RAssetMainGroupSingle object.
        /// </summary>
        public RAssetMainGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RAssetMainGroupSingle object.
        /// </summary>
        public RAssetMainGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RAssetMainGroup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RAssetMainGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// FAGroup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FAGroup")]
    [global::Microsoft.OData.Client.EntitySet("RAssetMainGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RAssetMainGroup")]
    public partial class RAssetMainGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RAssetMainGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="fAGroup">Initial value of FAGroup.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RAssetMainGroup CreateRAssetMainGroup(string dataAreaId, string fAGroup)
        {
            RAssetMainGroup rAssetMainGroup = new RAssetMainGroup();
            rAssetMainGroup.DataAreaId = dataAreaId;
            rAssetMainGroup.FAGroup = fAGroup;
            return rAssetMainGroup;
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
        /// There are no comments for Property FAGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FAGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FAGroup is required.")]
        public virtual string FAGroup
        {
            get
            {
                return this._FAGroup;
            }
            set
            {
                this.OnFAGroupChanging(value);
                this._FAGroup = value;
                this.OnFAGroupChanged();
                this.OnPropertyChanged("FAGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FAGroup;
        partial void OnFAGroupChanging(string value);
        partial void OnFAGroupChanged();
        /// <summary>
        /// There are no comments for Property FAAutonumberingSequence in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FAAutonumberingSequence")]
        public virtual string FAAutonumberingSequence
        {
            get
            {
                return this._FAAutonumberingSequence;
            }
            set
            {
                this.OnFAAutonumberingSequenceChanging(value);
                this._FAAutonumberingSequence = value;
                this.OnFAAutonumberingSequenceChanged();
                this.OnPropertyChanged("FAAutonumberingSequence");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FAAutonumberingSequence;
        partial void OnFAAutonumberingSequenceChanging(string value);
        partial void OnFAAutonumberingSequenceChanged();
        /// <summary>
        /// There are no comments for Property BarcodeAutonumerationSequence in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BarcodeAutonumerationSequence")]
        public virtual string BarcodeAutonumerationSequence
        {
            get
            {
                return this._BarcodeAutonumerationSequence;
            }
            set
            {
                this.OnBarcodeAutonumerationSequenceChanging(value);
                this._BarcodeAutonumerationSequence = value;
                this.OnBarcodeAutonumerationSequenceChanged();
                this.OnPropertyChanged("BarcodeAutonumerationSequence");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BarcodeAutonumerationSequence;
        partial void OnBarcodeAutonumerationSequenceChanging(string value);
        partial void OnBarcodeAutonumerationSequenceChanged();
        /// <summary>
        /// There are no comments for Property TypeOfGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TypeOfGroup")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RAssetGroupTypes> TypeOfGroup
        {
            get
            {
                return this._TypeOfGroup;
            }
            set
            {
                this.OnTypeOfGroupChanging(value);
                this._TypeOfGroup = value;
                this.OnTypeOfGroupChanged();
                this.OnPropertyChanged("TypeOfGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RAssetGroupTypes> _TypeOfGroup;
        partial void OnTypeOfGroupChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RAssetGroupTypes> value);
        partial void OnTypeOfGroupChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property BarcodesAutonumeration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BarcodesAutonumeration")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> BarcodesAutonumeration
        {
            get
            {
                return this._BarcodesAutonumeration;
            }
            set
            {
                this.OnBarcodesAutonumerationChanging(value);
                this._BarcodesAutonumeration = value;
                this.OnBarcodesAutonumerationChanged();
                this.OnPropertyChanged("BarcodesAutonumeration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _BarcodesAutonumeration;
        partial void OnBarcodesAutonumerationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnBarcodesAutonumerationChanged();
        /// <summary>
        /// There are no comments for Property VATRefunding in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VATRefunding")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RAssetVatRefundingStartDate> VATRefunding
        {
            get
            {
                return this._VATRefunding;
            }
            set
            {
                this.OnVATRefundingChanging(value);
                this._VATRefunding = value;
                this.OnVATRefundingChanged();
                this.OnPropertyChanged("VATRefunding");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RAssetVatRefundingStartDate> _VATRefunding;
        partial void OnVATRefundingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RAssetVatRefundingStartDate> value);
        partial void OnVATRefundingChanged();
        /// <summary>
        /// There are no comments for Property AutonumerationFA in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AutonumerationFA")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AutonumerationFA
        {
            get
            {
                return this._AutonumerationFA;
            }
            set
            {
                this.OnAutonumerationFAChanging(value);
                this._AutonumerationFA = value;
                this.OnAutonumerationFAChanged();
                this.OnPropertyChanged("AutonumerationFA");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AutonumerationFA;
        partial void OnAutonumerationFAChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAutonumerationFAChanged();
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
