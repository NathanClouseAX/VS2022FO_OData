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
    /// There are no comments for ShipConsolidationPolicyV2Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ShipConsolidationPolicyV2Single")]
    public partial class ShipConsolidationPolicyV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<ShipConsolidationPolicyV2>
    {
        /// <summary>
        /// Initialize a new ShipConsolidationPolicyV2Single object.
        /// </summary>
        public ShipConsolidationPolicyV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ShipConsolidationPolicyV2Single object.
        /// </summary>
        public ShipConsolidationPolicyV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ShipConsolidationPolicyV2Single object.
        /// </summary>
        public ShipConsolidationPolicyV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<ShipConsolidationPolicyV2> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ShipConsolidationPolicyV2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ShipConsolidationPolicyType
    /// ShipConsolidationPolicyName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ShipConsolidationPolicyType", "ShipConsolidationPolicyName")]
    [global::Microsoft.OData.Client.EntitySet("ShipConsolidationPoliciesV2")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ShipConsolidationPolicyV2")]
    public partial class ShipConsolidationPolicyV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ShipConsolidationPolicyV2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="shipConsolidationPolicyName">Initial value of ShipConsolidationPolicyName.</param>
        /// <param name="shipConsolidationPolicySeqNum">Initial value of ShipConsolidationPolicySeqNum.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ShipConsolidationPolicyV2 CreateShipConsolidationPolicyV2(string dataAreaId, string shipConsolidationPolicyName, int shipConsolidationPolicySeqNum)
        {
            ShipConsolidationPolicyV2 shipConsolidationPolicyV2 = new ShipConsolidationPolicyV2();
            shipConsolidationPolicyV2.DataAreaId = dataAreaId;
            shipConsolidationPolicyV2.ShipConsolidationPolicyName = shipConsolidationPolicyName;
            shipConsolidationPolicyV2.ShipConsolidationPolicySeqNum = shipConsolidationPolicySeqNum;
            return shipConsolidationPolicyV2;
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
        /// There are no comments for Property ShipConsolidationPolicyType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipConsolidationPolicyType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSShipConsolidationPolicyType> ShipConsolidationPolicyType
        {
            get
            {
                return this._ShipConsolidationPolicyType;
            }
            set
            {
                this.OnShipConsolidationPolicyTypeChanging(value);
                this._ShipConsolidationPolicyType = value;
                this.OnShipConsolidationPolicyTypeChanged();
                this.OnPropertyChanged("ShipConsolidationPolicyType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSShipConsolidationPolicyType> _ShipConsolidationPolicyType;
        partial void OnShipConsolidationPolicyTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSShipConsolidationPolicyType> value);
        partial void OnShipConsolidationPolicyTypeChanged();
        /// <summary>
        /// There are no comments for Property ShipConsolidationPolicyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipConsolidationPolicyName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShipConsolidationPolicyName is required.")]
        public virtual string ShipConsolidationPolicyName
        {
            get
            {
                return this._ShipConsolidationPolicyName;
            }
            set
            {
                this.OnShipConsolidationPolicyNameChanging(value);
                this._ShipConsolidationPolicyName = value;
                this.OnShipConsolidationPolicyNameChanged();
                this.OnPropertyChanged("ShipConsolidationPolicyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipConsolidationPolicyName;
        partial void OnShipConsolidationPolicyNameChanging(string value);
        partial void OnShipConsolidationPolicyNameChanged();
        /// <summary>
        /// There are no comments for Property Valid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Valid")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSShipConsolidationPolicyValidationStatus> Valid
        {
            get
            {
                return this._Valid;
            }
            set
            {
                this.OnValidChanging(value);
                this._Valid = value;
                this.OnValidChanged();
                this.OnPropertyChanged("Valid");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSShipConsolidationPolicyValidationStatus> _Valid;
        partial void OnValidChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSShipConsolidationPolicyValidationStatus> value);
        partial void OnValidChanged();
        /// <summary>
        /// There are no comments for Property ShipConsolidationPolicyQuery in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipConsolidationPolicyQuery")]
        public virtual byte[] ShipConsolidationPolicyQuery
        {
            get
            {
                return this._ShipConsolidationPolicyQuery;
            }
            set
            {
                this.OnShipConsolidationPolicyQueryChanging(value);
                this._ShipConsolidationPolicyQuery = value;
                this.OnShipConsolidationPolicyQueryChanged();
                this.OnPropertyChanged("ShipConsolidationPolicyQuery");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private byte[] _ShipConsolidationPolicyQuery;
        partial void OnShipConsolidationPolicyQueryChanging(byte[] value);
        partial void OnShipConsolidationPolicyQueryChanged();
        /// <summary>
        /// There are no comments for Property ShipConsolidationPolicyDesc in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipConsolidationPolicyDesc")]
        public virtual string ShipConsolidationPolicyDesc
        {
            get
            {
                return this._ShipConsolidationPolicyDesc;
            }
            set
            {
                this.OnShipConsolidationPolicyDescChanging(value);
                this._ShipConsolidationPolicyDesc = value;
                this.OnShipConsolidationPolicyDescChanged();
                this.OnPropertyChanged("ShipConsolidationPolicyDesc");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipConsolidationPolicyDesc;
        partial void OnShipConsolidationPolicyDescChanging(string value);
        partial void OnShipConsolidationPolicyDescChanged();
        /// <summary>
        /// There are no comments for Property ConsolidateWithExistingShipments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConsolidateWithExistingShipments")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ConsolidateWithExistingShipments
        {
            get
            {
                return this._ConsolidateWithExistingShipments;
            }
            set
            {
                this.OnConsolidateWithExistingShipmentsChanging(value);
                this._ConsolidateWithExistingShipments = value;
                this.OnConsolidateWithExistingShipmentsChanged();
                this.OnPropertyChanged("ConsolidateWithExistingShipments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ConsolidateWithExistingShipments;
        partial void OnConsolidateWithExistingShipmentsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnConsolidateWithExistingShipmentsChanged();
        /// <summary>
        /// There are no comments for Property ShipConsolidationPolicySeqNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipConsolidationPolicySeqNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShipConsolidationPolicySeqNum is required.")]
        public virtual int ShipConsolidationPolicySeqNum
        {
            get
            {
                return this._ShipConsolidationPolicySeqNum;
            }
            set
            {
                this.OnShipConsolidationPolicySeqNumChanging(value);
                this._ShipConsolidationPolicySeqNum = value;
                this.OnShipConsolidationPolicySeqNumChanged();
                this.OnPropertyChanged("ShipConsolidationPolicySeqNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ShipConsolidationPolicySeqNum;
        partial void OnShipConsolidationPolicySeqNumChanging(int value);
        partial void OnShipConsolidationPolicySeqNumChanged();
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