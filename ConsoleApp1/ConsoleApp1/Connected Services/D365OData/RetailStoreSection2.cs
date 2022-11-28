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
    /// There are no comments for RetailStoreSection2Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailStoreSection2Single")]
    public partial class RetailStoreSection2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailStoreSection2>
    {
        /// <summary>
        /// Initialize a new RetailStoreSection2Single object.
        /// </summary>
        public RetailStoreSection2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailStoreSection2Single object.
        /// </summary>
        public RetailStoreSection2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailStoreSection2Single object.
        /// </summary>
        public RetailStoreSection2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailStoreSection2> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailStoreSection2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// SectionId
    /// StoreNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "SectionId", "StoreNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailStoreSections2")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailStoreSection2")]
    public partial class RetailStoreSection2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailStoreSection2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="sectionId">Initial value of SectionId.</param>
        /// <param name="storeNumber">Initial value of StoreNumber.</param>
        /// <param name="size">Initial value of Size.</param>
        /// <param name="lastCheckedStock">Initial value of LastCheckedStock.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailStoreSection2 CreateRetailStoreSection2(string dataAreaId, string sectionId, string storeNumber, decimal size, global::System.DateTimeOffset lastCheckedStock)
        {
            RetailStoreSection2 retailStoreSection2 = new RetailStoreSection2();
            retailStoreSection2.DataAreaId = dataAreaId;
            retailStoreSection2.SectionId = sectionId;
            retailStoreSection2.StoreNumber = storeNumber;
            retailStoreSection2.Size = size;
            retailStoreSection2.LastCheckedStock = lastCheckedStock;
            return retailStoreSection2;
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
        /// There are no comments for Property SectionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SectionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SectionId is required.")]
        public virtual string SectionId
        {
            get
            {
                return this._SectionId;
            }
            set
            {
                this.OnSectionIdChanging(value);
                this._SectionId = value;
                this.OnSectionIdChanged();
                this.OnPropertyChanged("SectionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SectionId;
        partial void OnSectionIdChanging(string value);
        partial void OnSectionIdChanged();
        /// <summary>
        /// There are no comments for Property StoreNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StoreNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StoreNumber is required.")]
        public virtual string StoreNumber
        {
            get
            {
                return this._StoreNumber;
            }
            set
            {
                this.OnStoreNumberChanging(value);
                this._StoreNumber = value;
                this.OnStoreNumberChanged();
                this.OnPropertyChanged("StoreNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StoreNumber;
        partial void OnStoreNumberChanging(string value);
        partial void OnStoreNumberChanged();
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
        /// There are no comments for Property Size in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Size")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Size is required.")]
        public virtual decimal Size
        {
            get
            {
                return this._Size;
            }
            set
            {
                this.OnSizeChanging(value);
                this._Size = value;
                this.OnSizeChanged();
                this.OnPropertyChanged("Size");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Size;
        partial void OnSizeChanging(decimal value);
        partial void OnSizeChanged();
        /// <summary>
        /// There are no comments for Property LastCheckedStock in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LastCheckedStock")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LastCheckedStock is required.")]
        public virtual global::System.DateTimeOffset LastCheckedStock
        {
            get
            {
                return this._LastCheckedStock;
            }
            set
            {
                this.OnLastCheckedStockChanging(value);
                this._LastCheckedStock = value;
                this.OnLastCheckedStockChanged();
                this.OnPropertyChanged("LastCheckedStock");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _LastCheckedStock;
        partial void OnLastCheckedStockChanging(global::System.DateTimeOffset value);
        partial void OnLastCheckedStockChanged();
        /// <summary>
        /// There are no comments for Property SizeUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SizeUnit")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailSizeUnit> SizeUnit
        {
            get
            {
                return this._SizeUnit;
            }
            set
            {
                this.OnSizeUnitChanging(value);
                this._SizeUnit = value;
                this.OnSizeUnitChanged();
                this.OnPropertyChanged("SizeUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailSizeUnit> _SizeUnit;
        partial void OnSizeUnitChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailSizeUnit> value);
        partial void OnSizeUnitChanged();
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