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
    /// There are no comments for NRTaxReportSetupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("NRTaxReportSetupSingle")]
    public partial class NRTaxReportSetupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<NRTaxReportSetup>
    {
        /// <summary>
        /// Initialize a new NRTaxReportSetupSingle object.
        /// </summary>
        public NRTaxReportSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new NRTaxReportSetupSingle object.
        /// </summary>
        public NRTaxReportSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new NRTaxReportSetupSingle object.
        /// </summary>
        public NRTaxReportSetupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<NRTaxReportSetup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for NRTaxReportSetup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// FormNumber
    /// SequenceNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FormNumber", "SequenceNumber")]
    [global::Microsoft.OData.Client.EntitySet("NRTaxReportSetups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("NRTaxReportSetup")]
    public partial class NRTaxReportSetup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new NRTaxReportSetup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="sequenceNumber">Initial value of SequenceNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static NRTaxReportSetup CreateNRTaxReportSetup(string dataAreaId, int sequenceNumber)
        {
            NRTaxReportSetup nRTaxReportSetup = new NRTaxReportSetup();
            nRTaxReportSetup.DataAreaId = dataAreaId;
            nRTaxReportSetup.SequenceNumber = sequenceNumber;
            return nRTaxReportSetup;
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
        /// There are no comments for Property FormNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FormNumber")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LvNRTaxFormNumber> FormNumber
        {
            get
            {
                return this._FormNumber;
            }
            set
            {
                this.OnFormNumberChanging(value);
                this._FormNumber = value;
                this.OnFormNumberChanged();
                this.OnPropertyChanged("FormNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LvNRTaxFormNumber> _FormNumber;
        partial void OnFormNumberChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LvNRTaxFormNumber> value);
        partial void OnFormNumberChanged();
        /// <summary>
        /// There are no comments for Property SequenceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SequenceNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SequenceNumber is required.")]
        public virtual int SequenceNumber
        {
            get
            {
                return this._SequenceNumber;
            }
            set
            {
                this.OnSequenceNumberChanging(value);
                this._SequenceNumber = value;
                this.OnSequenceNumberChanged();
                this.OnPropertyChanged("SequenceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _SequenceNumber;
        partial void OnSequenceNumberChanging(int value);
        partial void OnSequenceNumberChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Description")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property WarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseId")]
        public virtual string WarehouseId
        {
            get
            {
                return this._WarehouseId;
            }
            set
            {
                this.OnWarehouseIdChanging(value);
                this._WarehouseId = value;
                this.OnWarehouseIdChanged();
                this.OnPropertyChanged("WarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WarehouseId;
        partial void OnWarehouseIdChanging(string value);
        partial void OnWarehouseIdChanged();
        /// <summary>
        /// There are no comments for Property PackMaterialCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PackMaterialCode")]
        public virtual string PackMaterialCode
        {
            get
            {
                return this._PackMaterialCode;
            }
            set
            {
                this.OnPackMaterialCodeChanging(value);
                this._PackMaterialCode = value;
                this.OnPackMaterialCodeChanged();
                this.OnPropertyChanged("PackMaterialCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PackMaterialCode;
        partial void OnPackMaterialCodeChanging(string value);
        partial void OnPackMaterialCodeChanged();
        /// <summary>
        /// There are no comments for Property LineCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineCode")]
        public virtual string LineCode
        {
            get
            {
                return this._LineCode;
            }
            set
            {
                this.OnLineCodeChanging(value);
                this._LineCode = value;
                this.OnLineCodeChanged();
                this.OnPropertyChanged("LineCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LineCode;
        partial void OnLineCodeChanging(string value);
        partial void OnLineCodeChanged();
        /// <summary>
        /// There are no comments for Property LineType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LvNRTaxReportLineType> LineType
        {
            get
            {
                return this._LineType;
            }
            set
            {
                this.OnLineTypeChanging(value);
                this._LineType = value;
                this.OnLineTypeChanged();
                this.OnPropertyChanged("LineType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LvNRTaxReportLineType> _LineType;
        partial void OnLineTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LvNRTaxReportLineType> value);
        partial void OnLineTypeChanged();
        /// <summary>
        /// There are no comments for Property TotalLineCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalLineCode")]
        public virtual string TotalLineCode
        {
            get
            {
                return this._TotalLineCode;
            }
            set
            {
                this.OnTotalLineCodeChanging(value);
                this._TotalLineCode = value;
                this.OnTotalLineCodeChanged();
                this.OnPropertyChanged("TotalLineCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TotalLineCode;
        partial void OnTotalLineCodeChanging(string value);
        partial void OnTotalLineCodeChanged();
        /// <summary>
        /// There are no comments for Property TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxCode")]
        public virtual string TaxCode
        {
            get
            {
                return this._TaxCode;
            }
            set
            {
                this.OnTaxCodeChanging(value);
                this._TaxCode = value;
                this.OnTaxCodeChanged();
                this.OnPropertyChanged("TaxCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxCode;
        partial void OnTaxCodeChanging(string value);
        partial void OnTaxCodeChanged();
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