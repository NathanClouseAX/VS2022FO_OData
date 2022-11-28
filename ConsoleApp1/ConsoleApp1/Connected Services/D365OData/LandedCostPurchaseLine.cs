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
    /// There are no comments for LandedCostPurchaseLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LandedCostPurchaseLineSingle")]
    public partial class LandedCostPurchaseLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LandedCostPurchaseLine>
    {
        /// <summary>
        /// Initialize a new LandedCostPurchaseLineSingle object.
        /// </summary>
        public LandedCostPurchaseLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LandedCostPurchaseLineSingle object.
        /// </summary>
        public LandedCostPurchaseLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LandedCostPurchaseLineSingle object.
        /// </summary>
        public LandedCostPurchaseLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LandedCostPurchaseLine> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for LandedCostPurchaseLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ShipDataArea
    /// PurchaseLineNumber
    /// PurchaseOrderId
    /// ShipId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ShipDataArea", "PurchaseLineNumber", "PurchaseOrderId", "ShipId")]
    [global::Microsoft.OData.Client.EntitySet("LandedCostPurchaseLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LandedCostPurchaseLine")]
    public partial class LandedCostPurchaseLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LandedCostPurchaseLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="shipDataArea">Initial value of ShipDataArea.</param>
        /// <param name="purchaseLineNumber">Initial value of PurchaseLineNumber.</param>
        /// <param name="purchaseOrderId">Initial value of PurchaseOrderId.</param>
        /// <param name="shipId">Initial value of ShipId.</param>
        /// <param name="shipPosition">Initial value of ShipPosition.</param>
        /// <param name="shipNoOfCartons">Initial value of ShipNoOfCartons.</param>
        /// <param name="shipDeclaredQty">Initial value of ShipDeclaredQty.</param>
        /// <param name="shipQty">Initial value of ShipQty.</param>
        /// <param name="weight">Initial value of Weight.</param>
        /// <param name="shipMeasurement">Initial value of ShipMeasurement.</param>
        /// <param name="volume">Initial value of Volume.</param>
        /// <param name="lineAmountMST">Initial value of LineAmountMST.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LandedCostPurchaseLine CreateLandedCostPurchaseLine(string dataAreaId, 
                    string shipDataArea, 
                    long purchaseLineNumber, 
                    string purchaseOrderId, 
                    string shipId, 
                    int shipPosition, 
                    decimal shipNoOfCartons, 
                    decimal shipDeclaredQty, 
                    decimal shipQty, 
                    decimal weight, 
                    decimal shipMeasurement, 
                    decimal volume, 
                    decimal lineAmountMST)
        {
            LandedCostPurchaseLine landedCostPurchaseLine = new LandedCostPurchaseLine();
            landedCostPurchaseLine.DataAreaId = dataAreaId;
            landedCostPurchaseLine.ShipDataArea = shipDataArea;
            landedCostPurchaseLine.PurchaseLineNumber = purchaseLineNumber;
            landedCostPurchaseLine.PurchaseOrderId = purchaseOrderId;
            landedCostPurchaseLine.ShipId = shipId;
            landedCostPurchaseLine.ShipPosition = shipPosition;
            landedCostPurchaseLine.ShipNoOfCartons = shipNoOfCartons;
            landedCostPurchaseLine.ShipDeclaredQty = shipDeclaredQty;
            landedCostPurchaseLine.ShipQty = shipQty;
            landedCostPurchaseLine.Weight = weight;
            landedCostPurchaseLine.ShipMeasurement = shipMeasurement;
            landedCostPurchaseLine.Volume = volume;
            landedCostPurchaseLine.LineAmountMST = lineAmountMST;
            return landedCostPurchaseLine;
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
        /// There are no comments for Property ShipDataArea in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipDataArea")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShipDataArea is required.")]
        public virtual string ShipDataArea
        {
            get
            {
                return this._ShipDataArea;
            }
            set
            {
                this.OnShipDataAreaChanging(value);
                this._ShipDataArea = value;
                this.OnShipDataAreaChanged();
                this.OnPropertyChanged("ShipDataArea");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipDataArea;
        partial void OnShipDataAreaChanging(string value);
        partial void OnShipDataAreaChanged();
        /// <summary>
        /// There are no comments for Property PurchaseLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseLineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PurchaseLineNumber is required.")]
        public virtual long PurchaseLineNumber
        {
            get
            {
                return this._PurchaseLineNumber;
            }
            set
            {
                this.OnPurchaseLineNumberChanging(value);
                this._PurchaseLineNumber = value;
                this.OnPurchaseLineNumberChanged();
                this.OnPropertyChanged("PurchaseLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _PurchaseLineNumber;
        partial void OnPurchaseLineNumberChanging(long value);
        partial void OnPurchaseLineNumberChanged();
        /// <summary>
        /// There are no comments for Property PurchaseOrderId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseOrderId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PurchaseOrderId is required.")]
        public virtual string PurchaseOrderId
        {
            get
            {
                return this._PurchaseOrderId;
            }
            set
            {
                this.OnPurchaseOrderIdChanging(value);
                this._PurchaseOrderId = value;
                this.OnPurchaseOrderIdChanged();
                this.OnPropertyChanged("PurchaseOrderId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchaseOrderId;
        partial void OnPurchaseOrderIdChanging(string value);
        partial void OnPurchaseOrderIdChanged();
        /// <summary>
        /// There are no comments for Property ShipId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShipId is required.")]
        public virtual string ShipId
        {
            get
            {
                return this._ShipId;
            }
            set
            {
                this.OnShipIdChanging(value);
                this._ShipId = value;
                this.OnShipIdChanged();
                this.OnPropertyChanged("ShipId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipId;
        partial void OnShipIdChanging(string value);
        partial void OnShipIdChanged();
        /// <summary>
        /// There are no comments for Property ShipPosition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipPosition")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShipPosition is required.")]
        public virtual int ShipPosition
        {
            get
            {
                return this._ShipPosition;
            }
            set
            {
                this.OnShipPositionChanging(value);
                this._ShipPosition = value;
                this.OnShipPositionChanged();
                this.OnPropertyChanged("ShipPosition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ShipPosition;
        partial void OnShipPositionChanging(int value);
        partial void OnShipPositionChanged();
        /// <summary>
        /// There are no comments for Property ShipItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipItemId")]
        public virtual string ShipItemId
        {
            get
            {
                return this._ShipItemId;
            }
            set
            {
                this.OnShipItemIdChanging(value);
                this._ShipItemId = value;
                this.OnShipItemIdChanged();
                this.OnPropertyChanged("ShipItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipItemId;
        partial void OnShipItemIdChanging(string value);
        partial void OnShipItemIdChanged();
        /// <summary>
        /// There are no comments for Property CurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyCode")]
        public virtual string CurrencyCode
        {
            get
            {
                return this._CurrencyCode;
            }
            set
            {
                this.OnCurrencyCodeChanging(value);
                this._CurrencyCode = value;
                this.OnCurrencyCodeChanged();
                this.OnPropertyChanged("CurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyCode;
        partial void OnCurrencyCodeChanging(string value);
        partial void OnCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property ShipNoOfCartons in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipNoOfCartons")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShipNoOfCartons is required.")]
        public virtual decimal ShipNoOfCartons
        {
            get
            {
                return this._ShipNoOfCartons;
            }
            set
            {
                this.OnShipNoOfCartonsChanging(value);
                this._ShipNoOfCartons = value;
                this.OnShipNoOfCartonsChanged();
                this.OnPropertyChanged("ShipNoOfCartons");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ShipNoOfCartons;
        partial void OnShipNoOfCartonsChanging(decimal value);
        partial void OnShipNoOfCartonsChanged();
        /// <summary>
        /// There are no comments for Property ShipDeclaredQty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipDeclaredQty")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShipDeclaredQty is required.")]
        public virtual decimal ShipDeclaredQty
        {
            get
            {
                return this._ShipDeclaredQty;
            }
            set
            {
                this.OnShipDeclaredQtyChanging(value);
                this._ShipDeclaredQty = value;
                this.OnShipDeclaredQtyChanged();
                this.OnPropertyChanged("ShipDeclaredQty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ShipDeclaredQty;
        partial void OnShipDeclaredQtyChanging(decimal value);
        partial void OnShipDeclaredQtyChanged();
        /// <summary>
        /// There are no comments for Property ShipQty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipQty")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShipQty is required.")]
        public virtual decimal ShipQty
        {
            get
            {
                return this._ShipQty;
            }
            set
            {
                this.OnShipQtyChanging(value);
                this._ShipQty = value;
                this.OnShipQtyChanged();
                this.OnPropertyChanged("ShipQty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ShipQty;
        partial void OnShipQtyChanging(decimal value);
        partial void OnShipQtyChanged();
        /// <summary>
        /// There are no comments for Property Weight in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Weight")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Weight is required.")]
        public virtual decimal Weight
        {
            get
            {
                return this._Weight;
            }
            set
            {
                this.OnWeightChanging(value);
                this._Weight = value;
                this.OnWeightChanged();
                this.OnPropertyChanged("Weight");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Weight;
        partial void OnWeightChanging(decimal value);
        partial void OnWeightChanged();
        /// <summary>
        /// There are no comments for Property ShipMeasurement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipMeasurement")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShipMeasurement is required.")]
        public virtual decimal ShipMeasurement
        {
            get
            {
                return this._ShipMeasurement;
            }
            set
            {
                this.OnShipMeasurementChanging(value);
                this._ShipMeasurement = value;
                this.OnShipMeasurementChanged();
                this.OnPropertyChanged("ShipMeasurement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ShipMeasurement;
        partial void OnShipMeasurementChanging(decimal value);
        partial void OnShipMeasurementChanged();
        /// <summary>
        /// There are no comments for Property Volume in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Volume")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Volume is required.")]
        public virtual decimal Volume
        {
            get
            {
                return this._Volume;
            }
            set
            {
                this.OnVolumeChanging(value);
                this._Volume = value;
                this.OnVolumeChanged();
                this.OnPropertyChanged("Volume");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Volume;
        partial void OnVolumeChanging(decimal value);
        partial void OnVolumeChanged();
        /// <summary>
        /// There are no comments for Property ShipContainerId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipContainerId")]
        public virtual string ShipContainerId
        {
            get
            {
                return this._ShipContainerId;
            }
            set
            {
                this.OnShipContainerIdChanging(value);
                this._ShipContainerId = value;
                this.OnShipContainerIdChanged();
                this.OnPropertyChanged("ShipContainerId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipContainerId;
        partial void OnShipContainerIdChanging(string value);
        partial void OnShipContainerIdChanged();
        /// <summary>
        /// There are no comments for Property ShipFolioId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipFolioId")]
        public virtual string ShipFolioId
        {
            get
            {
                return this._ShipFolioId;
            }
            set
            {
                this.OnShipFolioIdChanging(value);
                this._ShipFolioId = value;
                this.OnShipFolioIdChanged();
                this.OnPropertyChanged("ShipFolioId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipFolioId;
        partial void OnShipFolioIdChanging(string value);
        partial void OnShipFolioIdChanged();
        /// <summary>
        /// There are no comments for Property UnitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitId")]
        public virtual string UnitId
        {
            get
            {
                return this._UnitId;
            }
            set
            {
                this.OnUnitIdChanging(value);
                this._UnitId = value;
                this.OnUnitIdChanged();
                this.OnPropertyChanged("UnitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitId;
        partial void OnUnitIdChanging(string value);
        partial void OnUnitIdChanged();
        /// <summary>
        /// There are no comments for Property LineAmountMST in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineAmountMST")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineAmountMST is required.")]
        public virtual decimal LineAmountMST
        {
            get
            {
                return this._LineAmountMST;
            }
            set
            {
                this.OnLineAmountMSTChanging(value);
                this._LineAmountMST = value;
                this.OnLineAmountMSTChanged();
                this.OnPropertyChanged("LineAmountMST");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineAmountMST;
        partial void OnLineAmountMSTChanging(decimal value);
        partial void OnLineAmountMSTChanged();
        /// <summary>
        /// There are no comments for Property ShipMeasurementUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipMeasurementUnit")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ITMMeasurementUnit> ShipMeasurementUnit
        {
            get
            {
                return this._ShipMeasurementUnit;
            }
            set
            {
                this.OnShipMeasurementUnitChanging(value);
                this._ShipMeasurementUnit = value;
                this.OnShipMeasurementUnitChanged();
                this.OnPropertyChanged("ShipMeasurementUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ITMMeasurementUnit> _ShipMeasurementUnit;
        partial void OnShipMeasurementUnitChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ITMMeasurementUnit> value);
        partial void OnShipMeasurementUnitChanged();
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