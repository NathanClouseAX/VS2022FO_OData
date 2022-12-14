//------------------------------------------------------------------------------
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
    /// There are no comments for TillLayoutConfigurationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TillLayoutConfigurationSingle")]
    public partial class TillLayoutConfigurationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TillLayoutConfiguration>
    {
        /// <summary>
        /// Initialize a new TillLayoutConfigurationSingle object.
        /// </summary>
        public TillLayoutConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TillLayoutConfigurationSingle object.
        /// </summary>
        public TillLayoutConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TillLayoutConfigurationSingle object.
        /// </summary>
        public TillLayoutConfigurationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TillLayoutConfiguration> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TillLayoutSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TillLayoutSize")]
        public virtual global::Microsoft.Dynamics.DataEntities.TillLayoutSizeSingle TillLayoutSize
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TillLayoutSize == null))
                {
                    this._TillLayoutSize = new global::Microsoft.Dynamics.DataEntities.TillLayoutSizeSingle(this.Context, GetPath("TillLayoutSize"));
                }
                return this._TillLayoutSize;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TillLayoutSizeSingle _TillLayoutSize;
        /// <summary>
        /// There are no comments for RetailTillLayout in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailTillLayout")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailTillLayoutSingle RetailTillLayout
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailTillLayout == null))
                {
                    this._RetailTillLayout = new global::Microsoft.Dynamics.DataEntities.RetailTillLayoutSingle(this.Context, GetPath("RetailTillLayout"));
                }
                return this._RetailTillLayout;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailTillLayoutSingle _RetailTillLayout;
    }
    /// <summary>
    /// There are no comments for TillLayoutConfiguration in the schema.
    /// </summary>
    /// <KeyProperties>
    /// LayoutId
    /// LayoutSizeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LayoutId", "LayoutSizeId")]
    [global::Microsoft.OData.Client.EntitySet("TillLayoutConfigurations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TillLayoutConfiguration")]
    public partial class TillLayoutConfiguration : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TillLayoutConfiguration object.
        /// </summary>
        /// <param name="layoutId">Initial value of LayoutId.</param>
        /// <param name="layoutSizeId">Initial value of LayoutSizeId.</param>
        /// <param name="tillLayoutSize">Initial value of TillLayoutSize.</param>
        /// <param name="retailTillLayout">Initial value of RetailTillLayout.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TillLayoutConfiguration CreateTillLayoutConfiguration(string layoutId, string layoutSizeId, global::Microsoft.Dynamics.DataEntities.TillLayoutSize tillLayoutSize, global::Microsoft.Dynamics.DataEntities.RetailTillLayout retailTillLayout)
        {
            TillLayoutConfiguration tillLayoutConfiguration = new TillLayoutConfiguration();
            tillLayoutConfiguration.LayoutId = layoutId;
            tillLayoutConfiguration.LayoutSizeId = layoutSizeId;
            if ((tillLayoutSize == null))
            {
                throw new global::System.ArgumentNullException("tillLayoutSize");
            }
            tillLayoutConfiguration.TillLayoutSize = tillLayoutSize;
            if ((retailTillLayout == null))
            {
                throw new global::System.ArgumentNullException("retailTillLayout");
            }
            tillLayoutConfiguration.RetailTillLayout = retailTillLayout;
            return tillLayoutConfiguration;
        }
        /// <summary>
        /// There are no comments for Property LayoutId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LayoutId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LayoutId is required.")]
        public virtual string LayoutId
        {
            get
            {
                return this._LayoutId;
            }
            set
            {
                this.OnLayoutIdChanging(value);
                this._LayoutId = value;
                this.OnLayoutIdChanged();
                this.OnPropertyChanged("LayoutId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LayoutId;
        partial void OnLayoutIdChanging(string value);
        partial void OnLayoutIdChanged();
        /// <summary>
        /// There are no comments for Property LayoutSizeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LayoutSizeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LayoutSizeId is required.")]
        public virtual string LayoutSizeId
        {
            get
            {
                return this._LayoutSizeId;
            }
            set
            {
                this.OnLayoutSizeIdChanging(value);
                this._LayoutSizeId = value;
                this.OnLayoutSizeIdChanged();
                this.OnPropertyChanged("LayoutSizeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LayoutSizeId;
        partial void OnLayoutSizeIdChanging(string value);
        partial void OnLayoutSizeIdChanged();
        /// <summary>
        /// There are no comments for Property TotalId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalId")]
        public virtual string TotalId
        {
            get
            {
                return this._TotalId;
            }
            set
            {
                this.OnTotalIdChanging(value);
                this._TotalId = value;
                this.OnTotalIdChanged();
                this.OnPropertyChanged("TotalId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TotalId;
        partial void OnTotalIdChanging(string value);
        partial void OnTotalIdChanged();
        /// <summary>
        /// There are no comments for Property ReceiptPaymentLayout in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReceiptPaymentLayout")]
        public virtual string ReceiptPaymentLayout
        {
            get
            {
                return this._ReceiptPaymentLayout;
            }
            set
            {
                this.OnReceiptPaymentLayoutChanging(value);
                this._ReceiptPaymentLayout = value;
                this.OnReceiptPaymentLayoutChanged();
                this.OnPropertyChanged("ReceiptPaymentLayout");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReceiptPaymentLayout;
        partial void OnReceiptPaymentLayoutChanging(string value);
        partial void OnReceiptPaymentLayoutChanged();
        /// <summary>
        /// There are no comments for Property ReceiptItemsLayout in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReceiptItemsLayout")]
        public virtual string ReceiptItemsLayout
        {
            get
            {
                return this._ReceiptItemsLayout;
            }
            set
            {
                this.OnReceiptItemsLayoutChanging(value);
                this._ReceiptItemsLayout = value;
                this.OnReceiptItemsLayoutChanged();
                this.OnPropertyChanged("ReceiptItemsLayout");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReceiptItemsLayout;
        partial void OnReceiptItemsLayoutChanging(string value);
        partial void OnReceiptItemsLayoutChanged();
        /// <summary>
        /// There are no comments for Property CustomerLayout in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerLayout")]
        public virtual string CustomerLayout
        {
            get
            {
                return this._CustomerLayout;
            }
            set
            {
                this.OnCustomerLayoutChanging(value);
                this._CustomerLayout = value;
                this.OnCustomerLayoutChanged();
                this.OnPropertyChanged("CustomerLayout");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerLayout;
        partial void OnCustomerLayoutChanging(string value);
        partial void OnCustomerLayoutChanged();
        /// <summary>
        /// There are no comments for Property LayoutLandscape in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LayoutLandscape")]
        public virtual string LayoutLandscape
        {
            get
            {
                return this._LayoutLandscape;
            }
            set
            {
                this.OnLayoutLandscapeChanging(value);
                this._LayoutLandscape = value;
                this.OnLayoutLandscapeChanged();
                this.OnPropertyChanged("LayoutLandscape");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LayoutLandscape;
        partial void OnLayoutLandscapeChanging(string value);
        partial void OnLayoutLandscapeChanged();
        /// <summary>
        /// There are no comments for Property ReceiptId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReceiptId")]
        public virtual string ReceiptId
        {
            get
            {
                return this._ReceiptId;
            }
            set
            {
                this.OnReceiptIdChanging(value);
                this._ReceiptId = value;
                this.OnReceiptIdChanged();
                this.OnPropertyChanged("ReceiptId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReceiptId;
        partial void OnReceiptIdChanging(string value);
        partial void OnReceiptIdChanged();
        /// <summary>
        /// There are no comments for Property TotalsLayout in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalsLayout")]
        public virtual string TotalsLayout
        {
            get
            {
                return this._TotalsLayout;
            }
            set
            {
                this.OnTotalsLayoutChanging(value);
                this._TotalsLayout = value;
                this.OnTotalsLayoutChanged();
                this.OnPropertyChanged("TotalsLayout");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TotalsLayout;
        partial void OnTotalsLayoutChanging(string value);
        partial void OnTotalsLayoutChanged();
        /// <summary>
        /// There are no comments for Property CustomerLayoutId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerLayoutId")]
        public virtual string CustomerLayoutId
        {
            get
            {
                return this._CustomerLayoutId;
            }
            set
            {
                this.OnCustomerLayoutIdChanging(value);
                this._CustomerLayoutId = value;
                this.OnCustomerLayoutIdChanged();
                this.OnPropertyChanged("CustomerLayoutId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerLayoutId;
        partial void OnCustomerLayoutIdChanging(string value);
        partial void OnCustomerLayoutIdChanged();
        /// <summary>
        /// There are no comments for Property IMG_CashChangerLayout in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IMG_CashChangerLayout")]
        public virtual byte[] IMG_CashChangerLayout
        {
            get
            {
                return this._IMG_CashChangerLayout;
            }
            set
            {
                this.OnIMG_CashChangerLayoutChanging(value);
                this._IMG_CashChangerLayout = value;
                this.OnIMG_CashChangerLayoutChanged();
                this.OnPropertyChanged("IMG_CashChangerLayout");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private byte[] _IMG_CashChangerLayout;
        partial void OnIMG_CashChangerLayoutChanging(byte[] value);
        partial void OnIMG_CashChangerLayoutChanged();
        /// <summary>
        /// There are no comments for Property LayoutPortrait in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LayoutPortrait")]
        public virtual string LayoutPortrait
        {
            get
            {
                return this._LayoutPortrait;
            }
            set
            {
                this.OnLayoutPortraitChanging(value);
                this._LayoutPortrait = value;
                this.OnLayoutPortraitChanged();
                this.OnPropertyChanged("LayoutPortrait");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LayoutPortrait;
        partial void OnLayoutPortraitChanging(string value);
        partial void OnLayoutPortraitChanged();
        /// <summary>
        /// There are no comments for Property CashChangerLayout in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CashChangerLayout")]
        public virtual string CashChangerLayout
        {
            get
            {
                return this._CashChangerLayout;
            }
            set
            {
                this.OnCashChangerLayoutChanging(value);
                this._CashChangerLayout = value;
                this.OnCashChangerLayoutChanged();
                this.OnPropertyChanged("CashChangerLayout");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CashChangerLayout;
        partial void OnCashChangerLayoutChanging(string value);
        partial void OnCashChangerLayoutChanged();
        /// <summary>
        /// There are no comments for Property TillLayoutSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TillLayoutSize")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TillLayoutSize is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.TillLayoutSize TillLayoutSize
        {
            get
            {
                return this._TillLayoutSize;
            }
            set
            {
                this.OnTillLayoutSizeChanging(value);
                this._TillLayoutSize = value;
                this.OnTillLayoutSizeChanged();
                this.OnPropertyChanged("TillLayoutSize");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TillLayoutSize _TillLayoutSize;
        partial void OnTillLayoutSizeChanging(global::Microsoft.Dynamics.DataEntities.TillLayoutSize value);
        partial void OnTillLayoutSizeChanged();
        /// <summary>
        /// There are no comments for Property RetailTillLayout in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailTillLayout")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailTillLayout is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailTillLayout RetailTillLayout
        {
            get
            {
                return this._RetailTillLayout;
            }
            set
            {
                this.OnRetailTillLayoutChanging(value);
                this._RetailTillLayout = value;
                this.OnRetailTillLayoutChanged();
                this.OnPropertyChanged("RetailTillLayout");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailTillLayout _RetailTillLayout;
        partial void OnRetailTillLayoutChanging(global::Microsoft.Dynamics.DataEntities.RetailTillLayout value);
        partial void OnRetailTillLayoutChanged();
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
