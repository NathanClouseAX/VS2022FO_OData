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
    /// There are no comments for BarcodeSetupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BarcodeSetupSingle")]
    public partial class BarcodeSetupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BarcodeSetup>
    {
        /// <summary>
        /// Initialize a new BarcodeSetupSingle object.
        /// </summary>
        public BarcodeSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BarcodeSetupSingle object.
        /// </summary>
        public BarcodeSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BarcodeSetupSingle object.
        /// </summary>
        public BarcodeSetupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BarcodeSetup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductBarcodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductBarcodes")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedBarcode> ProductBarcodes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductBarcodes == null))
                {
                    this._ProductBarcodes = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedBarcode>(GetPath("ProductBarcodes"));
                }
                return this._ProductBarcodes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedBarcode> _ProductBarcodes;
        /// <summary>
        /// There are no comments for ProductBarcodesV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductBarcodesV2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductBarcodeAssociation> ProductBarcodesV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductBarcodesV2 == null))
                {
                    this._ProductBarcodesV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductBarcodeAssociation>(GetPath("ProductBarcodesV2"));
                }
                return this._ProductBarcodesV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductBarcodeAssociation> _ProductBarcodesV2;
        /// <summary>
        /// There are no comments for ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductsV2 == null))
                {
                    this._ReleasedProductsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(GetPath("ReleasedProductsV2"));
                }
                return this._ReleasedProductsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2;
        /// <summary>
        /// There are no comments for ProductBarcodesV3 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductBarcodesV3")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductBarcodeV3> ProductBarcodesV3
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductBarcodesV3 == null))
                {
                    this._ProductBarcodesV3 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductBarcodeV3>(GetPath("ProductBarcodesV3"));
                }
                return this._ProductBarcodesV3;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductBarcodeV3> _ProductBarcodesV3;
    }
    /// <summary>
    /// There are no comments for BarcodeSetup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// BarcodeSetupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "BarcodeSetupId")]
    [global::Microsoft.OData.Client.EntitySet("BarcodeSetups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BarcodeSetup")]
    public partial class BarcodeSetup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BarcodeSetup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="barcodeSetupId">Initial value of BarcodeSetupId.</param>
        /// <param name="fontSize">Initial value of FontSize.</param>
        /// <param name="maximumBarcodeLength">Initial value of MaximumBarcodeLength.</param>
        /// <param name="minimumBarcodeLength">Initial value of MinimumBarcodeLength.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BarcodeSetup CreateBarcodeSetup(string dataAreaId, string barcodeSetupId, int fontSize, int maximumBarcodeLength, int minimumBarcodeLength)
        {
            BarcodeSetup barcodeSetup = new BarcodeSetup();
            barcodeSetup.DataAreaId = dataAreaId;
            barcodeSetup.BarcodeSetupId = barcodeSetupId;
            barcodeSetup.FontSize = fontSize;
            barcodeSetup.MaximumBarcodeLength = maximumBarcodeLength;
            barcodeSetup.MinimumBarcodeLength = minimumBarcodeLength;
            return barcodeSetup;
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
        /// There are no comments for Property BarcodeSetupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BarcodeSetupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BarcodeSetupId is required.")]
        public virtual string BarcodeSetupId
        {
            get
            {
                return this._BarcodeSetupId;
            }
            set
            {
                this.OnBarcodeSetupIdChanging(value);
                this._BarcodeSetupId = value;
                this.OnBarcodeSetupIdChanged();
                this.OnPropertyChanged("BarcodeSetupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BarcodeSetupId;
        partial void OnBarcodeSetupIdChanging(string value);
        partial void OnBarcodeSetupIdChanged();
        /// <summary>
        /// There are no comments for Property FontSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FontSize")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FontSize is required.")]
        public virtual int FontSize
        {
            get
            {
                return this._FontSize;
            }
            set
            {
                this.OnFontSizeChanging(value);
                this._FontSize = value;
                this.OnFontSizeChanged();
                this.OnPropertyChanged("FontSize");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _FontSize;
        partial void OnFontSizeChanging(int value);
        partial void OnFontSizeChanged();
        /// <summary>
        /// There are no comments for Property BarcodeMaskId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BarcodeMaskId")]
        public virtual string BarcodeMaskId
        {
            get
            {
                return this._BarcodeMaskId;
            }
            set
            {
                this.OnBarcodeMaskIdChanging(value);
                this._BarcodeMaskId = value;
                this.OnBarcodeMaskIdChanged();
                this.OnPropertyChanged("BarcodeMaskId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BarcodeMaskId;
        partial void OnBarcodeMaskIdChanging(string value);
        partial void OnBarcodeMaskIdChanged();
        /// <summary>
        /// There are no comments for Property BarcodeDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BarcodeDescription")]
        public virtual string BarcodeDescription
        {
            get
            {
                return this._BarcodeDescription;
            }
            set
            {
                this.OnBarcodeDescriptionChanging(value);
                this._BarcodeDescription = value;
                this.OnBarcodeDescriptionChanged();
                this.OnPropertyChanged("BarcodeDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BarcodeDescription;
        partial void OnBarcodeDescriptionChanging(string value);
        partial void OnBarcodeDescriptionChanged();
        /// <summary>
        /// There are no comments for Property BarcodeType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BarcodeType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BarcodeType> BarcodeType
        {
            get
            {
                return this._BarcodeType;
            }
            set
            {
                this.OnBarcodeTypeChanging(value);
                this._BarcodeType = value;
                this.OnBarcodeTypeChanged();
                this.OnPropertyChanged("BarcodeType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BarcodeType> _BarcodeType;
        partial void OnBarcodeTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BarcodeType> value);
        partial void OnBarcodeTypeChanged();
        /// <summary>
        /// There are no comments for Property MaximumBarcodeLength in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaximumBarcodeLength")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaximumBarcodeLength is required.")]
        public virtual int MaximumBarcodeLength
        {
            get
            {
                return this._MaximumBarcodeLength;
            }
            set
            {
                this.OnMaximumBarcodeLengthChanging(value);
                this._MaximumBarcodeLength = value;
                this.OnMaximumBarcodeLengthChanged();
                this.OnPropertyChanged("MaximumBarcodeLength");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _MaximumBarcodeLength;
        partial void OnMaximumBarcodeLengthChanging(int value);
        partial void OnMaximumBarcodeLengthChanged();
        /// <summary>
        /// There are no comments for Property MinimumBarcodeLength in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MinimumBarcodeLength")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MinimumBarcodeLength is required.")]
        public virtual int MinimumBarcodeLength
        {
            get
            {
                return this._MinimumBarcodeLength;
            }
            set
            {
                this.OnMinimumBarcodeLengthChanging(value);
                this._MinimumBarcodeLength = value;
                this.OnMinimumBarcodeLengthChanged();
                this.OnPropertyChanged("MinimumBarcodeLength");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _MinimumBarcodeLength;
        partial void OnMinimumBarcodeLengthChanging(int value);
        partial void OnMinimumBarcodeLengthChanged();
        /// <summary>
        /// There are no comments for Property FontName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FontName")]
        public virtual string FontName
        {
            get
            {
                return this._FontName;
            }
            set
            {
                this.OnFontNameChanging(value);
                this._FontName = value;
                this.OnFontNameChanged();
                this.OnPropertyChanged("FontName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FontName;
        partial void OnFontNameChanging(string value);
        partial void OnFontNameChanged();
        /// <summary>
        /// There are no comments for Property ProductBarcodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductBarcodes")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedBarcode> ProductBarcodes
        {
            get
            {
                return this._ProductBarcodes;
            }
            set
            {
                this.OnProductBarcodesChanging(value);
                this._ProductBarcodes = value;
                this.OnProductBarcodesChanged();
                this.OnPropertyChanged("ProductBarcodes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedBarcode> _ProductBarcodes = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedBarcode>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductBarcodesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductNumberIdentifiedBarcode> value);
        partial void OnProductBarcodesChanged();
        /// <summary>
        /// There are no comments for Property ProductBarcodesV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductBarcodesV2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductBarcodeAssociation> ProductBarcodesV2
        {
            get
            {
                return this._ProductBarcodesV2;
            }
            set
            {
                this.OnProductBarcodesV2Changing(value);
                this._ProductBarcodesV2 = value;
                this.OnProductBarcodesV2Changed();
                this.OnPropertyChanged("ProductBarcodesV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductBarcodeAssociation> _ProductBarcodesV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductBarcodeAssociation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductBarcodesV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductBarcodeAssociation> value);
        partial void OnProductBarcodesV2Changed();
        /// <summary>
        /// There are no comments for Property ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                return this._ReleasedProductsV2;
            }
            set
            {
                this.OnReleasedProductsV2Changing(value);
                this._ReleasedProductsV2 = value;
                this.OnReleasedProductsV2Changed();
                this.OnPropertyChanged("ReleasedProductsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedProductsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> value);
        partial void OnReleasedProductsV2Changed();
        /// <summary>
        /// There are no comments for Property ProductBarcodesV3 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductBarcodesV3")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductBarcodeV3> ProductBarcodesV3
        {
            get
            {
                return this._ProductBarcodesV3;
            }
            set
            {
                this.OnProductBarcodesV3Changing(value);
                this._ProductBarcodesV3 = value;
                this.OnProductBarcodesV3Changed();
                this.OnPropertyChanged("ProductBarcodesV3");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductBarcodeV3> _ProductBarcodesV3 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductBarcodeV3>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductBarcodesV3Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductBarcodeV3> value);
        partial void OnProductBarcodesV3Changed();
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
