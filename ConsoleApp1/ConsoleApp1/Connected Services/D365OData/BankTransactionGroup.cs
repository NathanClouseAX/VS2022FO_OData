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
    /// There are no comments for BankTransactionGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BankTransactionGroupSingle")]
    public partial class BankTransactionGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BankTransactionGroup>
    {
        /// <summary>
        /// Initialize a new BankTransactionGroupSingle object.
        /// </summary>
        public BankTransactionGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BankTransactionGroupSingle object.
        /// </summary>
        public BankTransactionGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BankTransactionGroupSingle object.
        /// </summary>
        public BankTransactionGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BankTransactionGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BankTransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BankTransactionType")]
        public virtual global::Microsoft.Dynamics.DataEntities.BankTransactionTypeSingle BankTransactionType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BankTransactionType == null))
                {
                    this._BankTransactionType = new global::Microsoft.Dynamics.DataEntities.BankTransactionTypeSingle(this.Context, GetPath("BankTransactionType"));
                }
                return this._BankTransactionType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BankTransactionTypeSingle _BankTransactionType;
    }
    /// <summary>
    /// There are no comments for BankTransactionGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// TransactionGroupId
    /// TransactionTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TransactionGroupId", "TransactionTypeId")]
    [global::Microsoft.OData.Client.EntitySet("BankTransactionGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BankTransactionGroup")]
    public partial class BankTransactionGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BankTransactionGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="transactionGroupId">Initial value of TransactionGroupId.</param>
        /// <param name="transactionTypeId">Initial value of TransactionTypeId.</param>
        /// <param name="bankTransactionType">Initial value of BankTransactionType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BankTransactionGroup CreateBankTransactionGroup(string dataAreaId, string transactionGroupId, string transactionTypeId, global::Microsoft.Dynamics.DataEntities.BankTransactionType bankTransactionType)
        {
            BankTransactionGroup bankTransactionGroup = new BankTransactionGroup();
            bankTransactionGroup.DataAreaId = dataAreaId;
            bankTransactionGroup.TransactionGroupId = transactionGroupId;
            bankTransactionGroup.TransactionTypeId = transactionTypeId;
            if ((bankTransactionType == null))
            {
                throw new global::System.ArgumentNullException("bankTransactionType");
            }
            bankTransactionGroup.BankTransactionType = bankTransactionType;
            return bankTransactionGroup;
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
        /// There are no comments for Property TransactionGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransactionGroupId is required.")]
        public virtual string TransactionGroupId
        {
            get
            {
                return this._TransactionGroupId;
            }
            set
            {
                this.OnTransactionGroupIdChanging(value);
                this._TransactionGroupId = value;
                this.OnTransactionGroupIdChanged();
                this.OnPropertyChanged("TransactionGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionGroupId;
        partial void OnTransactionGroupIdChanging(string value);
        partial void OnTransactionGroupIdChanged();
        /// <summary>
        /// There are no comments for Property TransactionTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransactionTypeId is required.")]
        public virtual string TransactionTypeId
        {
            get
            {
                return this._TransactionTypeId;
            }
            set
            {
                this.OnTransactionTypeIdChanging(value);
                this._TransactionTypeId = value;
                this.OnTransactionTypeIdChanged();
                this.OnPropertyChanged("TransactionTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionTypeId;
        partial void OnTransactionTypeIdChanging(string value);
        partial void OnTransactionTypeIdChanged();
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
        /// There are no comments for Property BankTransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BankTransactionType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BankTransactionType is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.BankTransactionType BankTransactionType
        {
            get
            {
                return this._BankTransactionType;
            }
            set
            {
                this.OnBankTransactionTypeChanging(value);
                this._BankTransactionType = value;
                this.OnBankTransactionTypeChanged();
                this.OnPropertyChanged("BankTransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BankTransactionType _BankTransactionType;
        partial void OnBankTransactionTypeChanging(global::Microsoft.Dynamics.DataEntities.BankTransactionType value);
        partial void OnBankTransactionTypeChanged();
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