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
    /// There are no comments for AdditionalFieldsValueSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AdditionalFieldsValueSingle")]
    public partial class AdditionalFieldsValueSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AdditionalFieldsValue>
    {
        /// <summary>
        /// Initialize a new AdditionalFieldsValueSingle object.
        /// </summary>
        public AdditionalFieldsValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AdditionalFieldsValueSingle object.
        /// </summary>
        public AdditionalFieldsValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AdditionalFieldsValueSingle object.
        /// </summary>
        public AdditionalFieldsValueSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AdditionalFieldsValue> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AdditionalFieldsValue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// FieldName
    /// FieldValue
    /// AccountType
    /// AccountCode
    /// AccountRelation
    /// Effective
    /// Expiration
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FieldName", "FieldValue", "AccountType", "AccountCode", "AccountRelation", "Effective", "Expiration")]
    [global::Microsoft.OData.Client.EntitySet("AdditionalFieldsValues")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AdditionalFieldsValue")]
    public partial class AdditionalFieldsValue : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AdditionalFieldsValue object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="fieldName">Initial value of FieldName.</param>
        /// <param name="fieldValue">Initial value of FieldValue.</param>
        /// <param name="accountRelation">Initial value of AccountRelation.</param>
        /// <param name="effective">Initial value of Effective.</param>
        /// <param name="expiration">Initial value of Expiration.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AdditionalFieldsValue CreateAdditionalFieldsValue(string dataAreaId, 
                    string fieldName, 
                    string fieldValue, 
                    string accountRelation, 
                    global::System.DateTimeOffset effective, 
                    global::System.DateTimeOffset expiration)
        {
            AdditionalFieldsValue additionalFieldsValue = new AdditionalFieldsValue();
            additionalFieldsValue.DataAreaId = dataAreaId;
            additionalFieldsValue.FieldName = fieldName;
            additionalFieldsValue.FieldValue = fieldValue;
            additionalFieldsValue.AccountRelation = accountRelation;
            additionalFieldsValue.Effective = effective;
            additionalFieldsValue.Expiration = expiration;
            return additionalFieldsValue;
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
        /// There are no comments for Property FieldName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FieldName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FieldName is required.")]
        public virtual string FieldName
        {
            get
            {
                return this._FieldName;
            }
            set
            {
                this.OnFieldNameChanging(value);
                this._FieldName = value;
                this.OnFieldNameChanged();
                this.OnPropertyChanged("FieldName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FieldName;
        partial void OnFieldNameChanging(string value);
        partial void OnFieldNameChanged();
        /// <summary>
        /// There are no comments for Property FieldValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FieldValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FieldValue is required.")]
        public virtual string FieldValue
        {
            get
            {
                return this._FieldValue;
            }
            set
            {
                this.OnFieldValueChanging(value);
                this._FieldValue = value;
                this.OnFieldValueChanged();
                this.OnPropertyChanged("FieldValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FieldValue;
        partial void OnFieldValueChanging(string value);
        partial void OnFieldValueChanged();
        /// <summary>
        /// There are no comments for Property AccountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EMAccountType> AccountType
        {
            get
            {
                return this._AccountType;
            }
            set
            {
                this.OnAccountTypeChanging(value);
                this._AccountType = value;
                this.OnAccountTypeChanged();
                this.OnPropertyChanged("AccountType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EMAccountType> _AccountType;
        partial void OnAccountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EMAccountType> value);
        partial void OnAccountTypeChanged();
        /// <summary>
        /// There are no comments for Property AccountCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountCode")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TableGroupAll> AccountCode
        {
            get
            {
                return this._AccountCode;
            }
            set
            {
                this.OnAccountCodeChanging(value);
                this._AccountCode = value;
                this.OnAccountCodeChanged();
                this.OnPropertyChanged("AccountCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TableGroupAll> _AccountCode;
        partial void OnAccountCodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TableGroupAll> value);
        partial void OnAccountCodeChanged();
        /// <summary>
        /// There are no comments for Property AccountRelation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountRelation")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccountRelation is required.")]
        public virtual string AccountRelation
        {
            get
            {
                return this._AccountRelation;
            }
            set
            {
                this.OnAccountRelationChanging(value);
                this._AccountRelation = value;
                this.OnAccountRelationChanged();
                this.OnPropertyChanged("AccountRelation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountRelation;
        partial void OnAccountRelationChanging(string value);
        partial void OnAccountRelationChanged();
        /// <summary>
        /// There are no comments for Property Effective in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Effective")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Effective is required.")]
        public virtual global::System.DateTimeOffset Effective
        {
            get
            {
                return this._Effective;
            }
            set
            {
                this.OnEffectiveChanging(value);
                this._Effective = value;
                this.OnEffectiveChanged();
                this.OnPropertyChanged("Effective");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Effective;
        partial void OnEffectiveChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveChanged();
        /// <summary>
        /// There are no comments for Property Expiration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Expiration")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Expiration is required.")]
        public virtual global::System.DateTimeOffset Expiration
        {
            get
            {
                return this._Expiration;
            }
            set
            {
                this.OnExpirationChanging(value);
                this._Expiration = value;
                this.OnExpirationChanged();
                this.OnPropertyChanged("Expiration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Expiration;
        partial void OnExpirationChanging(global::System.DateTimeOffset value);
        partial void OnExpirationChanged();
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