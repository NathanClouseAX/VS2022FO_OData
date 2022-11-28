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
    /// There are no comments for CollectionAgencyGracePeriodSetupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CollectionAgencyGracePeriodSetupSingle")]
    public partial class CollectionAgencyGracePeriodSetupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CollectionAgencyGracePeriodSetup>
    {
        /// <summary>
        /// Initialize a new CollectionAgencyGracePeriodSetupSingle object.
        /// </summary>
        public CollectionAgencyGracePeriodSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CollectionAgencyGracePeriodSetupSingle object.
        /// </summary>
        public CollectionAgencyGracePeriodSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CollectionAgencyGracePeriodSetupSingle object.
        /// </summary>
        public CollectionAgencyGracePeriodSetupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CollectionAgencyGracePeriodSetup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CollectionAgencyGracePeriodSetup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AccountOrGroupNumber
    /// AccountCode
    /// ValidFrom
    /// ValidTo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AccountOrGroupNumber", "AccountCode", "ValidFrom", "ValidTo")]
    [global::Microsoft.OData.Client.EntitySet("CollectionAgencyGracePeriodSetup")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CollectionAgencyGracePeriodSetup")]
    public partial class CollectionAgencyGracePeriodSetup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CollectionAgencyGracePeriodSetup object.
        /// </summary>
        /// <param name="accountOrGroupNumber">Initial value of AccountOrGroupNumber.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="gracePeriodInDaysAfterTransactionDate">Initial value of GracePeriodInDaysAfterTransactionDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CollectionAgencyGracePeriodSetup CreateCollectionAgencyGracePeriodSetup(string accountOrGroupNumber, global::System.DateTimeOffset validFrom, global::System.DateTimeOffset validTo, int gracePeriodInDaysAfterTransactionDate)
        {
            CollectionAgencyGracePeriodSetup collectionAgencyGracePeriodSetup = new CollectionAgencyGracePeriodSetup();
            collectionAgencyGracePeriodSetup.AccountOrGroupNumber = accountOrGroupNumber;
            collectionAgencyGracePeriodSetup.ValidFrom = validFrom;
            collectionAgencyGracePeriodSetup.ValidTo = validTo;
            collectionAgencyGracePeriodSetup.GracePeriodInDaysAfterTransactionDate = gracePeriodInDaysAfterTransactionDate;
            return collectionAgencyGracePeriodSetup;
        }
        /// <summary>
        /// There are no comments for Property AccountOrGroupNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountOrGroupNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccountOrGroupNumber is required.")]
        public virtual string AccountOrGroupNumber
        {
            get
            {
                return this._AccountOrGroupNumber;
            }
            set
            {
                this.OnAccountOrGroupNumberChanging(value);
                this._AccountOrGroupNumber = value;
                this.OnAccountOrGroupNumberChanged();
                this.OnPropertyChanged("AccountOrGroupNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountOrGroupNumber;
        partial void OnAccountOrGroupNumberChanging(string value);
        partial void OnAccountOrGroupNumberChanged();
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
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidFrom is required.")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidTo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidTo is required.")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
        /// <summary>
        /// There are no comments for Property GracePeriodInDaysAfterTransactionDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GracePeriodInDaysAfterTransactionDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GracePeriodInDaysAfterTransactionDate is required.")]
        public virtual int GracePeriodInDaysAfterTransactionDate
        {
            get
            {
                return this._GracePeriodInDaysAfterTransactionDate;
            }
            set
            {
                this.OnGracePeriodInDaysAfterTransactionDateChanging(value);
                this._GracePeriodInDaysAfterTransactionDate = value;
                this.OnGracePeriodInDaysAfterTransactionDateChanged();
                this.OnPropertyChanged("GracePeriodInDaysAfterTransactionDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _GracePeriodInDaysAfterTransactionDate;
        partial void OnGracePeriodInDaysAfterTransactionDateChanging(int value);
        partial void OnGracePeriodInDaysAfterTransactionDateChanged();
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
