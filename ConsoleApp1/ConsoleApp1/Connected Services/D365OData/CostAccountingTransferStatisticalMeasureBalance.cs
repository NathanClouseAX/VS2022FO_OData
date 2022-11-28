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
    /// There are no comments for CostAccountingTransferStatisticalMeasureBalanceSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CostAccountingTransferStatisticalMeasureBalanceSingle")]
    public partial class CostAccountingTransferStatisticalMeasureBalanceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CostAccountingTransferStatisticalMeasureBalance>
    {
        /// <summary>
        /// Initialize a new CostAccountingTransferStatisticalMeasureBalanceSingle object.
        /// </summary>
        public CostAccountingTransferStatisticalMeasureBalanceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CostAccountingTransferStatisticalMeasureBalanceSingle object.
        /// </summary>
        public CostAccountingTransferStatisticalMeasureBalanceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CostAccountingTransferStatisticalMeasureBalanceSingle object.
        /// </summary>
        public CostAccountingTransferStatisticalMeasureBalanceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CostAccountingTransferStatisticalMeasureBalance> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CostAccountingTransferStatisticalMeasureBalance in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataConnectorSystemInstanceSurrogateKey
    /// DataConnectorStatisticalMeasureConfigurationName
    /// PeriodStartDate
    /// PeriodEndDate
    /// StartDate
    /// EndDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DataConnectorSystemInstanceSurrogateKey", "DataConnectorStatisticalMeasureConfigurationName", "PeriodStartDate", "PeriodEndDate", "StartDate", "EndDate")]
    [global::Microsoft.OData.Client.EntitySet("CostAccountingTransferStatisticalMeasureBalances")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CostAccountingTransferStatisticalMeasureBalance")]
    public partial class CostAccountingTransferStatisticalMeasureBalance : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CostAccountingTransferStatisticalMeasureBalance object.
        /// </summary>
        /// <param name="dataConnectorSystemInstanceSurrogateKey">Initial value of DataConnectorSystemInstanceSurrogateKey.</param>
        /// <param name="dataConnectorStatisticalMeasureConfigurationName">Initial value of DataConnectorStatisticalMeasureConfigurationName.</param>
        /// <param name="periodStartDate">Initial value of PeriodStartDate.</param>
        /// <param name="periodEndDate">Initial value of PeriodEndDate.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CostAccountingTransferStatisticalMeasureBalance CreateCostAccountingTransferStatisticalMeasureBalance(string dataConnectorSystemInstanceSurrogateKey, 
                    string dataConnectorStatisticalMeasureConfigurationName, 
                    global::System.DateTimeOffset periodStartDate, 
                    global::System.DateTimeOffset periodEndDate, 
                    global::System.DateTimeOffset startDate, 
                    global::System.DateTimeOffset endDate)
        {
            CostAccountingTransferStatisticalMeasureBalance costAccountingTransferStatisticalMeasureBalance = new CostAccountingTransferStatisticalMeasureBalance();
            costAccountingTransferStatisticalMeasureBalance.DataConnectorSystemInstanceSurrogateKey = dataConnectorSystemInstanceSurrogateKey;
            costAccountingTransferStatisticalMeasureBalance.DataConnectorStatisticalMeasureConfigurationName = dataConnectorStatisticalMeasureConfigurationName;
            costAccountingTransferStatisticalMeasureBalance.PeriodStartDate = periodStartDate;
            costAccountingTransferStatisticalMeasureBalance.PeriodEndDate = periodEndDate;
            costAccountingTransferStatisticalMeasureBalance.StartDate = startDate;
            costAccountingTransferStatisticalMeasureBalance.EndDate = endDate;
            return costAccountingTransferStatisticalMeasureBalance;
        }
        /// <summary>
        /// There are no comments for Property DataConnectorSystemInstanceSurrogateKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DataConnectorSystemInstanceSurrogateKey")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DataConnectorSystemInstanceSurrogateKey is required.")]
        public virtual string DataConnectorSystemInstanceSurrogateKey
        {
            get
            {
                return this._DataConnectorSystemInstanceSurrogateKey;
            }
            set
            {
                this.OnDataConnectorSystemInstanceSurrogateKeyChanging(value);
                this._DataConnectorSystemInstanceSurrogateKey = value;
                this.OnDataConnectorSystemInstanceSurrogateKeyChanged();
                this.OnPropertyChanged("DataConnectorSystemInstanceSurrogateKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataConnectorSystemInstanceSurrogateKey;
        partial void OnDataConnectorSystemInstanceSurrogateKeyChanging(string value);
        partial void OnDataConnectorSystemInstanceSurrogateKeyChanged();
        /// <summary>
        /// There are no comments for Property DataConnectorStatisticalMeasureConfigurationName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DataConnectorStatisticalMeasureConfigurationName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DataConnectorStatisticalMeasureConfigurationName is required.")]
        public virtual string DataConnectorStatisticalMeasureConfigurationName
        {
            get
            {
                return this._DataConnectorStatisticalMeasureConfigurationName;
            }
            set
            {
                this.OnDataConnectorStatisticalMeasureConfigurationNameChanging(value);
                this._DataConnectorStatisticalMeasureConfigurationName = value;
                this.OnDataConnectorStatisticalMeasureConfigurationNameChanged();
                this.OnPropertyChanged("DataConnectorStatisticalMeasureConfigurationName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataConnectorStatisticalMeasureConfigurationName;
        partial void OnDataConnectorStatisticalMeasureConfigurationNameChanging(string value);
        partial void OnDataConnectorStatisticalMeasureConfigurationNameChanged();
        /// <summary>
        /// There are no comments for Property PeriodStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodStartDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodStartDate is required.")]
        public virtual global::System.DateTimeOffset PeriodStartDate
        {
            get
            {
                return this._PeriodStartDate;
            }
            set
            {
                this.OnPeriodStartDateChanging(value);
                this._PeriodStartDate = value;
                this.OnPeriodStartDateChanged();
                this.OnPropertyChanged("PeriodStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PeriodStartDate;
        partial void OnPeriodStartDateChanging(global::System.DateTimeOffset value);
        partial void OnPeriodStartDateChanged();
        /// <summary>
        /// There are no comments for Property PeriodEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodEndDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodEndDate is required.")]
        public virtual global::System.DateTimeOffset PeriodEndDate
        {
            get
            {
                return this._PeriodEndDate;
            }
            set
            {
                this.OnPeriodEndDateChanging(value);
                this._PeriodEndDate = value;
                this.OnPeriodEndDateChanged();
                this.OnPropertyChanged("PeriodEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PeriodEndDate;
        partial void OnPeriodEndDateChanging(global::System.DateTimeOffset value);
        partial void OnPeriodEndDateChanged();
        /// <summary>
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StartDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StartDate is required.")]
        public virtual global::System.DateTimeOffset StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartDate;
        partial void OnStartDateChanging(global::System.DateTimeOffset value);
        partial void OnStartDateChanged();
        /// <summary>
        /// There are no comments for Property EndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EndDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EndDate is required.")]
        public virtual global::System.DateTimeOffset EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this.OnEndDateChanging(value);
                this._EndDate = value;
                this.OnEndDateChanged();
                this.OnPropertyChanged("EndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EndDate;
        partial void OnEndDateChanging(global::System.DateTimeOffset value);
        partial void OnEndDateChanged();
        /// <summary>
        /// There are no comments for Property DataConnectorStatisticalMeasureConfigurationSurrogateKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DataConnectorStatisticalMeasureConfigurationSurrogateKey")]
        public virtual string DataConnectorStatisticalMeasureConfigurationSurrogateKey
        {
            get
            {
                return this._DataConnectorStatisticalMeasureConfigurationSurrogateKey;
            }
            set
            {
                this.OnDataConnectorStatisticalMeasureConfigurationSurrogateKeyChanging(value);
                this._DataConnectorStatisticalMeasureConfigurationSurrogateKey = value;
                this.OnDataConnectorStatisticalMeasureConfigurationSurrogateKeyChanged();
                this.OnPropertyChanged("DataConnectorStatisticalMeasureConfigurationSurrogateKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataConnectorStatisticalMeasureConfigurationSurrogateKey;
        partial void OnDataConnectorStatisticalMeasureConfigurationSurrogateKeyChanging(string value);
        partial void OnDataConnectorStatisticalMeasureConfigurationSurrogateKeyChanged();
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