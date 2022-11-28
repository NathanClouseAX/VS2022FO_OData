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
    /// There are no comments for OpenTradeAgreementJournalHeaderV2Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("OpenTradeAgreementJournalHeaderV2Single")]
    public partial class OpenTradeAgreementJournalHeaderV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<OpenTradeAgreementJournalHeaderV2>
    {
        /// <summary>
        /// Initialize a new OpenTradeAgreementJournalHeaderV2Single object.
        /// </summary>
        public OpenTradeAgreementJournalHeaderV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new OpenTradeAgreementJournalHeaderV2Single object.
        /// </summary>
        public OpenTradeAgreementJournalHeaderV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new OpenTradeAgreementJournalHeaderV2Single object.
        /// </summary>
        public OpenTradeAgreementJournalHeaderV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<OpenTradeAgreementJournalHeaderV2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TradeAgreementJournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TradeAgreementJournalName")]
        public virtual global::Microsoft.Dynamics.DataEntities.TradeAgreementJournalNameSingle TradeAgreementJournalName
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TradeAgreementJournalName == null))
                {
                    this._TradeAgreementJournalName = new global::Microsoft.Dynamics.DataEntities.TradeAgreementJournalNameSingle(this.Context, GetPath("TradeAgreementJournalName"));
                }
                return this._TradeAgreementJournalName;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TradeAgreementJournalNameSingle _TradeAgreementJournalName;
    }
    /// <summary>
    /// There are no comments for OpenTradeAgreementJournalHeaderV2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// JournalNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "JournalNumber")]
    [global::Microsoft.OData.Client.EntitySet("OpenTradeAgreementJournalHeadersV2")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("OpenTradeAgreementJournalHeaderV2")]
    public partial class OpenTradeAgreementJournalHeaderV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new OpenTradeAgreementJournalHeaderV2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="journalNumber">Initial value of JournalNumber.</param>
        /// <param name="tradeAgreementJournalName">Initial value of TradeAgreementJournalName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static OpenTradeAgreementJournalHeaderV2 CreateOpenTradeAgreementJournalHeaderV2(string dataAreaId, string journalNumber, global::Microsoft.Dynamics.DataEntities.TradeAgreementJournalName tradeAgreementJournalName)
        {
            OpenTradeAgreementJournalHeaderV2 openTradeAgreementJournalHeaderV2 = new OpenTradeAgreementJournalHeaderV2();
            openTradeAgreementJournalHeaderV2.DataAreaId = dataAreaId;
            openTradeAgreementJournalHeaderV2.JournalNumber = journalNumber;
            if ((tradeAgreementJournalName == null))
            {
                throw new global::System.ArgumentNullException("tradeAgreementJournalName");
            }
            openTradeAgreementJournalHeaderV2.TradeAgreementJournalName = tradeAgreementJournalName;
            return openTradeAgreementJournalHeaderV2;
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
        /// There are no comments for Property JournalNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JournalNumber is required.")]
        public virtual string JournalNumber
        {
            get
            {
                return this._JournalNumber;
            }
            set
            {
                this.OnJournalNumberChanging(value);
                this._JournalNumber = value;
                this.OnJournalNumberChanged();
                this.OnPropertyChanged("JournalNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalNumber;
        partial void OnJournalNumberChanging(string value);
        partial void OnJournalNumberChanged();
        /// <summary>
        /// There are no comments for Property JournalDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalDescription")]
        public virtual string JournalDescription
        {
            get
            {
                return this._JournalDescription;
            }
            set
            {
                this.OnJournalDescriptionChanging(value);
                this._JournalDescription = value;
                this.OnJournalDescriptionChanged();
                this.OnPropertyChanged("JournalDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalDescription;
        partial void OnJournalDescriptionChanging(string value);
        partial void OnJournalDescriptionChanged();
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
        /// There are no comments for Property IsCurrentPriceExported in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsCurrentPriceExported")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCurrentPriceExported
        {
            get
            {
                return this._IsCurrentPriceExported;
            }
            set
            {
                this.OnIsCurrentPriceExportedChanging(value);
                this._IsCurrentPriceExported = value;
                this.OnIsCurrentPriceExportedChanged();
                this.OnPropertyChanged("IsCurrentPriceExported");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCurrentPriceExported;
        partial void OnIsCurrentPriceExportedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCurrentPriceExportedChanged();
        /// <summary>
        /// There are no comments for Property TradeAgreementJournalNameId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TradeAgreementJournalNameId")]
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
        /// There are no comments for Property TradeAgreementJournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TradeAgreementJournalName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TradeAgreementJournalName is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.TradeAgreementJournalName TradeAgreementJournalName
        {
            get
            {
                return this._TradeAgreementJournalName;
            }
            set
            {
                this.OnTradeAgreementJournalNameChanging(value);
                this._TradeAgreementJournalName = value;
                this.OnTradeAgreementJournalNameChanged();
                this.OnPropertyChanged("TradeAgreementJournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TradeAgreementJournalName _TradeAgreementJournalName;
        partial void OnTradeAgreementJournalNameChanging(global::Microsoft.Dynamics.DataEntities.TradeAgreementJournalName value);
        partial void OnTradeAgreementJournalNameChanged();
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
