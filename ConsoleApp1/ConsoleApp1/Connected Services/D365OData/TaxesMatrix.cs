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
    /// There are no comments for TaxesMatrixSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TaxesMatrixSingle")]
    public partial class TaxesMatrixSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TaxesMatrix>
    {
        /// <summary>
        /// Initialize a new TaxesMatrixSingle object.
        /// </summary>
        public TaxesMatrixSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TaxesMatrixSingle object.
        /// </summary>
        public TaxesMatrixSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TaxesMatrixSingle object.
        /// </summary>
        public TaxesMatrixSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TaxesMatrix> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for TaxesMatrix in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// FiscalEstablishmentGroupId
    /// CFOPGroupId
    /// Type
    /// AccountRelation
    /// ItemRelation
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FiscalEstablishmentGroupId", "CFOPGroupId", "Type", "AccountRelation", "ItemRelation")]
    [global::Microsoft.OData.Client.EntitySet("TaxesMatrices")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TaxesMatrix")]
    public partial class TaxesMatrix : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TaxesMatrix object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="fiscalEstablishmentGroupId">Initial value of FiscalEstablishmentGroupId.</param>
        /// <param name="cFOPGroupId">Initial value of CFOPGroupId.</param>
        /// <param name="accountRelation">Initial value of AccountRelation.</param>
        /// <param name="itemRelation">Initial value of ItemRelation.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TaxesMatrix CreateTaxesMatrix(string dataAreaId, string fiscalEstablishmentGroupId, string cFOPGroupId, string accountRelation, string itemRelation)
        {
            TaxesMatrix taxesMatrix = new TaxesMatrix();
            taxesMatrix.DataAreaId = dataAreaId;
            taxesMatrix.FiscalEstablishmentGroupId = fiscalEstablishmentGroupId;
            taxesMatrix.CFOPGroupId = cFOPGroupId;
            taxesMatrix.AccountRelation = accountRelation;
            taxesMatrix.ItemRelation = itemRelation;
            return taxesMatrix;
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
        /// There are no comments for Property FiscalEstablishmentGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalEstablishmentGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiscalEstablishmentGroupId is required.")]
        public virtual string FiscalEstablishmentGroupId
        {
            get
            {
                return this._FiscalEstablishmentGroupId;
            }
            set
            {
                this.OnFiscalEstablishmentGroupIdChanging(value);
                this._FiscalEstablishmentGroupId = value;
                this.OnFiscalEstablishmentGroupIdChanged();
                this.OnPropertyChanged("FiscalEstablishmentGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalEstablishmentGroupId;
        partial void OnFiscalEstablishmentGroupIdChanging(string value);
        partial void OnFiscalEstablishmentGroupIdChanged();
        /// <summary>
        /// There are no comments for Property CFOPGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CFOPGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CFOPGroupId is required.")]
        public virtual string CFOPGroupId
        {
            get
            {
                return this._CFOPGroupId;
            }
            set
            {
                this.OnCFOPGroupIdChanging(value);
                this._CFOPGroupId = value;
                this.OnCFOPGroupIdChanged();
                this.OnPropertyChanged("CFOPGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CFOPGroupId;
        partial void OnCFOPGroupIdChanging(string value);
        partial void OnCFOPGroupIdChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendType_BR> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendType_BR> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendType_BR> value);
        partial void OnTypeChanged();
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
        /// There are no comments for Property ItemRelation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemRelation")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemRelation is required.")]
        public virtual string ItemRelation
        {
            get
            {
                return this._ItemRelation;
            }
            set
            {
                this.OnItemRelationChanging(value);
                this._ItemRelation = value;
                this.OnItemRelationChanged();
                this.OnPropertyChanged("ItemRelation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemRelation;
        partial void OnItemRelationChanging(string value);
        partial void OnItemRelationChanged();
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
        /// There are no comments for Property IsUsedForServiceItems in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsUsedForServiceItems")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsUsedForServiceItems
        {
            get
            {
                return this._IsUsedForServiceItems;
            }
            set
            {
                this.OnIsUsedForServiceItemsChanging(value);
                this._IsUsedForServiceItems = value;
                this.OnIsUsedForServiceItemsChanged();
                this.OnPropertyChanged("IsUsedForServiceItems");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsUsedForServiceItems;
        partial void OnIsUsedForServiceItemsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsUsedForServiceItemsChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesTaxGroup")]
        public virtual string SalesTaxGroup
        {
            get
            {
                return this._SalesTaxGroup;
            }
            set
            {
                this.OnSalesTaxGroupChanging(value);
                this._SalesTaxGroup = value;
                this.OnSalesTaxGroupChanged();
                this.OnPropertyChanged("SalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesTaxGroup;
        partial void OnSalesTaxGroupChanging(string value);
        partial void OnSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property IsUsedForFreeTextInvoice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsUsedForFreeTextInvoice")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsUsedForFreeTextInvoice
        {
            get
            {
                return this._IsUsedForFreeTextInvoice;
            }
            set
            {
                this.OnIsUsedForFreeTextInvoiceChanging(value);
                this._IsUsedForFreeTextInvoice = value;
                this.OnIsUsedForFreeTextInvoiceChanged();
                this.OnPropertyChanged("IsUsedForFreeTextInvoice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsUsedForFreeTextInvoice;
        partial void OnIsUsedForFreeTextInvoiceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsUsedForFreeTextInvoiceChanged();
        /// <summary>
        /// There are no comments for Property ItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemSalesTaxGroup")]
        public virtual string ItemSalesTaxGroup
        {
            get
            {
                return this._ItemSalesTaxGroup;
            }
            set
            {
                this.OnItemSalesTaxGroupChanging(value);
                this._ItemSalesTaxGroup = value;
                this.OnItemSalesTaxGroupChanged();
                this.OnPropertyChanged("ItemSalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemSalesTaxGroup;
        partial void OnItemSalesTaxGroupChanging(string value);
        partial void OnItemSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property ItemCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemCode")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TableGroupAll> ItemCode
        {
            get
            {
                return this._ItemCode;
            }
            set
            {
                this.OnItemCodeChanging(value);
                this._ItemCode = value;
                this.OnItemCodeChanged();
                this.OnPropertyChanged("ItemCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TableGroupAll> _ItemCode;
        partial void OnItemCodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TableGroupAll> value);
        partial void OnItemCodeChanged();
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