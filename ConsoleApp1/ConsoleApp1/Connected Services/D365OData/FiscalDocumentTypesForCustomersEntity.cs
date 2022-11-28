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
    /// There are no comments for FiscalDocumentTypesForCustomersEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalDocumentTypesForCustomersEntitySingle")]
    public partial class FiscalDocumentTypesForCustomersEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalDocumentTypesForCustomersEntity>
    {
        /// <summary>
        /// Initialize a new FiscalDocumentTypesForCustomersEntitySingle object.
        /// </summary>
        public FiscalDocumentTypesForCustomersEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FiscalDocumentTypesForCustomersEntitySingle object.
        /// </summary>
        public FiscalDocumentTypesForCustomersEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FiscalDocumentTypesForCustomersEntitySingle object.
        /// </summary>
        public FiscalDocumentTypesForCustomersEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalDocumentTypesForCustomersEntity> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for FiscalDocumentTypesForCustomersEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// AccountCode
    /// AccountRelation
    /// ItemType
    /// FiscalEstablishmentId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AccountCode", "AccountRelation", "ItemType", "FiscalEstablishmentId")]
    [global::Microsoft.OData.Client.EntitySet("FiscalDocumentTypesForCustomersEntities")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalDocumentTypesForCustomersEntity")]
    public partial class FiscalDocumentTypesForCustomersEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FiscalDocumentTypesForCustomersEntity object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="accountRelation">Initial value of AccountRelation.</param>
        /// <param name="fiscalEstablishmentId">Initial value of FiscalEstablishmentId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FiscalDocumentTypesForCustomersEntity CreateFiscalDocumentTypesForCustomersEntity(string dataAreaId, string accountRelation, string fiscalEstablishmentId)
        {
            FiscalDocumentTypesForCustomersEntity fiscalDocumentTypesForCustomersEntity = new FiscalDocumentTypesForCustomersEntity();
            fiscalDocumentTypesForCustomersEntity.DataAreaId = dataAreaId;
            fiscalDocumentTypesForCustomersEntity.AccountRelation = accountRelation;
            fiscalDocumentTypesForCustomersEntity.FiscalEstablishmentId = fiscalEstablishmentId;
            return fiscalDocumentTypesForCustomersEntity;
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
        /// There are no comments for Property ItemType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ItemType> ItemType
        {
            get
            {
                return this._ItemType;
            }
            set
            {
                this.OnItemTypeChanging(value);
                this._ItemType = value;
                this.OnItemTypeChanged();
                this.OnPropertyChanged("ItemType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ItemType> _ItemType;
        partial void OnItemTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ItemType> value);
        partial void OnItemTypeChanged();
        /// <summary>
        /// There are no comments for Property FiscalEstablishmentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalEstablishmentId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiscalEstablishmentId is required.")]
        public virtual string FiscalEstablishmentId
        {
            get
            {
                return this._FiscalEstablishmentId;
            }
            set
            {
                this.OnFiscalEstablishmentIdChanging(value);
                this._FiscalEstablishmentId = value;
                this.OnFiscalEstablishmentIdChanged();
                this.OnPropertyChanged("FiscalEstablishmentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalEstablishmentId;
        partial void OnFiscalEstablishmentIdChanging(string value);
        partial void OnFiscalEstablishmentIdChanged();
        /// <summary>
        /// There are no comments for Property FiscalDocumentTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalDocumentTypeId")]
        public virtual string FiscalDocumentTypeId
        {
            get
            {
                return this._FiscalDocumentTypeId;
            }
            set
            {
                this.OnFiscalDocumentTypeIdChanging(value);
                this._FiscalDocumentTypeId = value;
                this.OnFiscalDocumentTypeIdChanged();
                this.OnPropertyChanged("FiscalDocumentTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalDocumentTypeId;
        partial void OnFiscalDocumentTypeIdChanging(string value);
        partial void OnFiscalDocumentTypeIdChanged();
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
