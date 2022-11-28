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
    /// There are no comments for SubBillItemGroupSetupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillItemGroupSetupSingle")]
    public partial class SubBillItemGroupSetupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillItemGroupSetup>
    {
        /// <summary>
        /// Initialize a new SubBillItemGroupSetupSingle object.
        /// </summary>
        public SubBillItemGroupSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SubBillItemGroupSetupSingle object.
        /// </summary>
        public SubBillItemGroupSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SubBillItemGroupSetupSingle object.
        /// </summary>
        public SubBillItemGroupSetupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillItemGroupSetup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SubBillItemGroupSetup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ItemGroup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ItemGroup")]
    [global::Microsoft.OData.Client.EntitySet("SubBillItemGroupSetups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillItemGroupSetup")]
    public partial class SubBillItemGroupSetup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SubBillItemGroupSetup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="itemGroup">Initial value of ItemGroup.</param>
        /// <param name="numberOfTopLines">Initial value of NumberOfTopLines.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SubBillItemGroupSetup CreateSubBillItemGroupSetup(string dataAreaId, string itemGroup, int numberOfTopLines)
        {
            SubBillItemGroupSetup subBillItemGroupSetup = new SubBillItemGroupSetup();
            subBillItemGroupSetup.DataAreaId = dataAreaId;
            subBillItemGroupSetup.ItemGroup = itemGroup;
            subBillItemGroupSetup.NumberOfTopLines = numberOfTopLines;
            return subBillItemGroupSetup;
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
        /// There are no comments for Property ItemGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemGroup is required.")]
        public virtual string ItemGroup
        {
            get
            {
                return this._ItemGroup;
            }
            set
            {
                this.OnItemGroupChanging(value);
                this._ItemGroup = value;
                this.OnItemGroupChanged();
                this.OnPropertyChanged("ItemGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemGroup;
        partial void OnItemGroupChanging(string value);
        partial void OnItemGroupChanged();
        /// <summary>
        /// There are no comments for Property ProrateSupportAndRenewal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProrateSupportAndRenewal")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ProrateSupportAndRenewal
        {
            get
            {
                return this._ProrateSupportAndRenewal;
            }
            set
            {
                this.OnProrateSupportAndRenewalChanging(value);
                this._ProrateSupportAndRenewal = value;
                this.OnProrateSupportAndRenewalChanged();
                this.OnPropertyChanged("ProrateSupportAndRenewal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ProrateSupportAndRenewal;
        partial void OnProrateSupportAndRenewalChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnProrateSupportAndRenewalChanged();
        /// <summary>
        /// There are no comments for Property NumberOfTopLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NumberOfTopLines")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NumberOfTopLines is required.")]
        public virtual int NumberOfTopLines
        {
            get
            {
                return this._NumberOfTopLines;
            }
            set
            {
                this.OnNumberOfTopLinesChanging(value);
                this._NumberOfTopLines = value;
                this.OnNumberOfTopLinesChanged();
                this.OnPropertyChanged("NumberOfTopLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NumberOfTopLines;
        partial void OnNumberOfTopLinesChanging(int value);
        partial void OnNumberOfTopLinesChanged();
        /// <summary>
        /// There are no comments for Property AdjustRenewalDates in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AdjustRenewalDates")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AdjustRenewalDates
        {
            get
            {
                return this._AdjustRenewalDates;
            }
            set
            {
                this.OnAdjustRenewalDatesChanging(value);
                this._AdjustRenewalDates = value;
                this.OnAdjustRenewalDatesChanged();
                this.OnPropertyChanged("AdjustRenewalDates");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AdjustRenewalDates;
        partial void OnAdjustRenewalDatesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAdjustRenewalDatesChanged();
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