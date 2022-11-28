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
    /// There are no comments for RetailMultibuyDiscountLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailMultibuyDiscountLineSingle")]
    public partial class RetailMultibuyDiscountLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailMultibuyDiscountLine>
    {
        /// <summary>
        /// Initialize a new RetailMultibuyDiscountLineSingle object.
        /// </summary>
        public RetailMultibuyDiscountLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailMultibuyDiscountLineSingle object.
        /// </summary>
        public RetailMultibuyDiscountLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailMultibuyDiscountLineSingle object.
        /// </summary>
        public RetailMultibuyDiscountLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailMultibuyDiscountLine> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailMultibuyDiscountLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// MultibuyId
    /// QtyLowest
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MultibuyId", "QtyLowest")]
    [global::Microsoft.OData.Client.EntitySet("RetailMultibuyDiscountLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailMultibuyDiscountLine")]
    public partial class RetailMultibuyDiscountLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailMultibuyDiscountLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="multibuyId">Initial value of MultibuyId.</param>
        /// <param name="qtyLowest">Initial value of QtyLowest.</param>
        /// <param name="priceDiscPct">Initial value of PriceDiscPct.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailMultibuyDiscountLine CreateRetailMultibuyDiscountLine(string dataAreaId, string multibuyId, decimal qtyLowest, decimal priceDiscPct)
        {
            RetailMultibuyDiscountLine retailMultibuyDiscountLine = new RetailMultibuyDiscountLine();
            retailMultibuyDiscountLine.DataAreaId = dataAreaId;
            retailMultibuyDiscountLine.MultibuyId = multibuyId;
            retailMultibuyDiscountLine.QtyLowest = qtyLowest;
            retailMultibuyDiscountLine.PriceDiscPct = priceDiscPct;
            return retailMultibuyDiscountLine;
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
        /// There are no comments for Property MultibuyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MultibuyId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MultibuyId is required.")]
        public virtual string MultibuyId
        {
            get
            {
                return this._MultibuyId;
            }
            set
            {
                this.OnMultibuyIdChanging(value);
                this._MultibuyId = value;
                this.OnMultibuyIdChanged();
                this.OnPropertyChanged("MultibuyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MultibuyId;
        partial void OnMultibuyIdChanging(string value);
        partial void OnMultibuyIdChanged();
        /// <summary>
        /// There are no comments for Property QtyLowest in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QtyLowest")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QtyLowest is required.")]
        public virtual decimal QtyLowest
        {
            get
            {
                return this._QtyLowest;
            }
            set
            {
                this.OnQtyLowestChanging(value);
                this._QtyLowest = value;
                this.OnQtyLowestChanged();
                this.OnPropertyChanged("QtyLowest");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _QtyLowest;
        partial void OnQtyLowestChanging(decimal value);
        partial void OnQtyLowestChanged();
        /// <summary>
        /// There are no comments for Property PriceDiscPct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceDiscPct")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PriceDiscPct is required.")]
        public virtual decimal PriceDiscPct
        {
            get
            {
                return this._PriceDiscPct;
            }
            set
            {
                this.OnPriceDiscPctChanging(value);
                this._PriceDiscPct = value;
                this.OnPriceDiscPctChanged();
                this.OnPropertyChanged("PriceDiscPct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PriceDiscPct;
        partial void OnPriceDiscPctChanging(decimal value);
        partial void OnPriceDiscPctChanged();
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
