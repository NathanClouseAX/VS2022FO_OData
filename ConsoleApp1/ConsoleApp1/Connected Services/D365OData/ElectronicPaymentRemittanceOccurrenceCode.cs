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
    /// There are no comments for ElectronicPaymentRemittanceOccurrenceCodeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ElectronicPaymentRemittanceOccurrenceCodeSingle")]
    public partial class ElectronicPaymentRemittanceOccurrenceCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ElectronicPaymentRemittanceOccurrenceCode>
    {
        /// <summary>
        /// Initialize a new ElectronicPaymentRemittanceOccurrenceCodeSingle object.
        /// </summary>
        public ElectronicPaymentRemittanceOccurrenceCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ElectronicPaymentRemittanceOccurrenceCodeSingle object.
        /// </summary>
        public ElectronicPaymentRemittanceOccurrenceCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ElectronicPaymentRemittanceOccurrenceCodeSingle object.
        /// </summary>
        public ElectronicPaymentRemittanceOccurrenceCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ElectronicPaymentRemittanceOccurrenceCode> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ElectronicPaymentRemittanceOccurrenceCode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LayoutGroupId
    /// LayoutRemittanceOccurrenceCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LayoutGroupId", "LayoutRemittanceOccurrenceCode")]
    [global::Microsoft.OData.Client.EntitySet("ElectronicPaymentRemittanceOccurrenceCodes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ElectronicPaymentRemittanceOccurrenceCode")]
    public partial class ElectronicPaymentRemittanceOccurrenceCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ElectronicPaymentRemittanceOccurrenceCode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="layoutGroupId">Initial value of LayoutGroupId.</param>
        /// <param name="layoutRemittanceOccurrenceCode">Initial value of LayoutRemittanceOccurrenceCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ElectronicPaymentRemittanceOccurrenceCode CreateElectronicPaymentRemittanceOccurrenceCode(string dataAreaId, string layoutGroupId, string layoutRemittanceOccurrenceCode)
        {
            ElectronicPaymentRemittanceOccurrenceCode electronicPaymentRemittanceOccurrenceCode = new ElectronicPaymentRemittanceOccurrenceCode();
            electronicPaymentRemittanceOccurrenceCode.DataAreaId = dataAreaId;
            electronicPaymentRemittanceOccurrenceCode.LayoutGroupId = layoutGroupId;
            electronicPaymentRemittanceOccurrenceCode.LayoutRemittanceOccurrenceCode = layoutRemittanceOccurrenceCode;
            return electronicPaymentRemittanceOccurrenceCode;
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
        /// There are no comments for Property LayoutGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LayoutGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LayoutGroupId is required.")]
        public virtual string LayoutGroupId
        {
            get
            {
                return this._LayoutGroupId;
            }
            set
            {
                this.OnLayoutGroupIdChanging(value);
                this._LayoutGroupId = value;
                this.OnLayoutGroupIdChanged();
                this.OnPropertyChanged("LayoutGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LayoutGroupId;
        partial void OnLayoutGroupIdChanging(string value);
        partial void OnLayoutGroupIdChanged();
        /// <summary>
        /// There are no comments for Property LayoutRemittanceOccurrenceCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LayoutRemittanceOccurrenceCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LayoutRemittanceOccurrenceCode is required.")]
        public virtual string LayoutRemittanceOccurrenceCode
        {
            get
            {
                return this._LayoutRemittanceOccurrenceCode;
            }
            set
            {
                this.OnLayoutRemittanceOccurrenceCodeChanging(value);
                this._LayoutRemittanceOccurrenceCode = value;
                this.OnLayoutRemittanceOccurrenceCodeChanged();
                this.OnPropertyChanged("LayoutRemittanceOccurrenceCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LayoutRemittanceOccurrenceCode;
        partial void OnLayoutRemittanceOccurrenceCodeChanging(string value);
        partial void OnLayoutRemittanceOccurrenceCodeChanged();
        /// <summary>
        /// There are no comments for Property RemittanceOccurrenceCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RemittanceOccurrenceCode")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EPRemitOccCode_BR> RemittanceOccurrenceCode
        {
            get
            {
                return this._RemittanceOccurrenceCode;
            }
            set
            {
                this.OnRemittanceOccurrenceCodeChanging(value);
                this._RemittanceOccurrenceCode = value;
                this.OnRemittanceOccurrenceCodeChanged();
                this.OnPropertyChanged("RemittanceOccurrenceCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EPRemitOccCode_BR> _RemittanceOccurrenceCode;
        partial void OnRemittanceOccurrenceCodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EPRemitOccCode_BR> value);
        partial void OnRemittanceOccurrenceCodeChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Description")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
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