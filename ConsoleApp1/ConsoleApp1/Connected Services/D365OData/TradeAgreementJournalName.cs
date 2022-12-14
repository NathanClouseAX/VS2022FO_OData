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
    /// There are no comments for TradeAgreementJournalNameSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TradeAgreementJournalNameSingle")]
    public partial class TradeAgreementJournalNameSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TradeAgreementJournalName>
    {
        /// <summary>
        /// Initialize a new TradeAgreementJournalNameSingle object.
        /// </summary>
        public TradeAgreementJournalNameSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TradeAgreementJournalNameSingle object.
        /// </summary>
        public TradeAgreementJournalNameSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TradeAgreementJournalNameSingle object.
        /// </summary>
        public TradeAgreementJournalNameSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TradeAgreementJournalName> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for OpenTradeAgreementJournalHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("OpenTradeAgreementJournalHeaders")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.OpenTradeAgreementJournalHeaderV2> OpenTradeAgreementJournalHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OpenTradeAgreementJournalHeaders == null))
                {
                    this._OpenTradeAgreementJournalHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.OpenTradeAgreementJournalHeaderV2>(GetPath("OpenTradeAgreementJournalHeaders"));
                }
                return this._OpenTradeAgreementJournalHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.OpenTradeAgreementJournalHeaderV2> _OpenTradeAgreementJournalHeaders;
        /// <summary>
        /// There are no comments for TradeAgreementJournalHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TradeAgreementJournalHeaders")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TradeAgreementJournalHeader> TradeAgreementJournalHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TradeAgreementJournalHeaders == null))
                {
                    this._TradeAgreementJournalHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.TradeAgreementJournalHeader>(GetPath("TradeAgreementJournalHeaders"));
                }
                return this._TradeAgreementJournalHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TradeAgreementJournalHeader> _TradeAgreementJournalHeaders;
    }
    /// <summary>
    /// There are no comments for TradeAgreementJournalName in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// TradeAgreementJournalNameId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TradeAgreementJournalNameId")]
    [global::Microsoft.OData.Client.EntitySet("TradeAgreementJournalNames")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TradeAgreementJournalName")]
    public partial class TradeAgreementJournalName : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TradeAgreementJournalName object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="tradeAgreementJournalNameId">Initial value of TradeAgreementJournalNameId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TradeAgreementJournalName CreateTradeAgreementJournalName(string dataAreaId, string tradeAgreementJournalNameId)
        {
            TradeAgreementJournalName tradeAgreementJournalName = new TradeAgreementJournalName();
            tradeAgreementJournalName.DataAreaId = dataAreaId;
            tradeAgreementJournalName.TradeAgreementJournalNameId = tradeAgreementJournalNameId;
            return tradeAgreementJournalName;
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
        /// There are no comments for Property TradeAgreementJournalNameId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TradeAgreementJournalNameId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TradeAgreementJournalNameId is required.")]
        public virtual string TradeAgreementJournalNameId
        {
            get
            {
                return this._TradeAgreementJournalNameId;
            }
            set
            {
                this.OnTradeAgreementJournalNameIdChanging(value);
                this._TradeAgreementJournalNameId = value;
                this.OnTradeAgreementJournalNameIdChanged();
                this.OnPropertyChanged("TradeAgreementJournalNameId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TradeAgreementJournalNameId;
        partial void OnTradeAgreementJournalNameIdChanging(string value);
        partial void OnTradeAgreementJournalNameIdChanged();
        /// <summary>
        /// There are no comments for Property DefaultTradeAgreementType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultTradeAgreementType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PriceType> DefaultTradeAgreementType
        {
            get
            {
                return this._DefaultTradeAgreementType;
            }
            set
            {
                this.OnDefaultTradeAgreementTypeChanging(value);
                this._DefaultTradeAgreementType = value;
                this.OnDefaultTradeAgreementTypeChanged();
                this.OnPropertyChanged("DefaultTradeAgreementType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PriceType> _DefaultTradeAgreementType;
        partial void OnDefaultTradeAgreementTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PriceType> value);
        partial void OnDefaultTradeAgreementTypeChanged();
        /// <summary>
        /// There are no comments for Property DefaultJournalDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultJournalDescription")]
        public virtual string DefaultJournalDescription
        {
            get
            {
                return this._DefaultJournalDescription;
            }
            set
            {
                this.OnDefaultJournalDescriptionChanging(value);
                this._DefaultJournalDescription = value;
                this.OnDefaultJournalDescriptionChanged();
                this.OnPropertyChanged("DefaultJournalDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultJournalDescription;
        partial void OnDefaultJournalDescriptionChanging(string value);
        partial void OnDefaultJournalDescriptionChanged();
        /// <summary>
        /// There are no comments for Property PriceDiscPriceAttributeEnable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceDiscPriceAttributeEnable")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PriceDiscPriceAttributeEnable
        {
            get
            {
                return this._PriceDiscPriceAttributeEnable;
            }
            set
            {
                this.OnPriceDiscPriceAttributeEnableChanging(value);
                this._PriceDiscPriceAttributeEnable = value;
                this.OnPriceDiscPriceAttributeEnableChanged();
                this.OnPropertyChanged("PriceDiscPriceAttributeEnable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PriceDiscPriceAttributeEnable;
        partial void OnPriceDiscPriceAttributeEnableChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPriceDiscPriceAttributeEnableChanged();
        /// <summary>
        /// There are no comments for Property OpenTradeAgreementJournalHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OpenTradeAgreementJournalHeaders")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenTradeAgreementJournalHeaderV2> OpenTradeAgreementJournalHeaders
        {
            get
            {
                return this._OpenTradeAgreementJournalHeaders;
            }
            set
            {
                this.OnOpenTradeAgreementJournalHeadersChanging(value);
                this._OpenTradeAgreementJournalHeaders = value;
                this.OnOpenTradeAgreementJournalHeadersChanged();
                this.OnPropertyChanged("OpenTradeAgreementJournalHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenTradeAgreementJournalHeaderV2> _OpenTradeAgreementJournalHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenTradeAgreementJournalHeaderV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnOpenTradeAgreementJournalHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenTradeAgreementJournalHeaderV2> value);
        partial void OnOpenTradeAgreementJournalHeadersChanged();
        /// <summary>
        /// There are no comments for Property TradeAgreementJournalHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TradeAgreementJournalHeaders")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAgreementJournalHeader> TradeAgreementJournalHeaders
        {
            get
            {
                return this._TradeAgreementJournalHeaders;
            }
            set
            {
                this.OnTradeAgreementJournalHeadersChanging(value);
                this._TradeAgreementJournalHeaders = value;
                this.OnTradeAgreementJournalHeadersChanged();
                this.OnPropertyChanged("TradeAgreementJournalHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAgreementJournalHeader> _TradeAgreementJournalHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAgreementJournalHeader>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTradeAgreementJournalHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAgreementJournalHeader> value);
        partial void OnTradeAgreementJournalHeadersChanged();
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
