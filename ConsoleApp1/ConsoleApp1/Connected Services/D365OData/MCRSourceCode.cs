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
    /// There are no comments for MCRSourceCodeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("MCRSourceCodeSingle")]
    public partial class MCRSourceCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<MCRSourceCode>
    {
        /// <summary>
        /// Initialize a new MCRSourceCodeSingle object.
        /// </summary>
        public MCRSourceCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new MCRSourceCodeSingle object.
        /// </summary>
        public MCRSourceCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new MCRSourceCodeSingle object.
        /// </summary>
        public MCRSourceCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<MCRSourceCode> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for MCRSourceCode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// SourceId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "SourceId")]
    [global::Microsoft.OData.Client.EntitySet("MCRSourceCodes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("MCRSourceCode")]
    public partial class MCRSourceCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new MCRSourceCode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="sourceId">Initial value of SourceId.</param>
        /// <param name="projectedOrders">Initial value of ProjectedOrders.</param>
        /// <param name="otherCost">Initial value of OtherCost.</param>
        /// <param name="futureOrderDate">Initial value of FutureOrderDate.</param>
        /// <param name="projectedReturns">Initial value of ProjectedReturns.</param>
        /// <param name="projectedFirstOrderDate">Initial value of ProjectedFirstOrderDate.</param>
        /// <param name="actualCost">Initial value of ActualCost.</param>
        /// <param name="distributionQuantity">Initial value of DistributionQuantity.</param>
        /// <param name="projectedSales">Initial value of ProjectedSales.</param>
        /// <param name="mailingCosts">Initial value of MailingCosts.</param>
        /// <param name="mailDate">Initial value of MailDate.</param>
        /// <param name="printingCosts">Initial value of PrintingCosts.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static MCRSourceCode CreateMCRSourceCode(string dataAreaId, 
                    string sourceId, 
                    int projectedOrders, 
                    decimal otherCost, 
                    global::System.DateTimeOffset futureOrderDate, 
                    decimal projectedReturns, 
                    global::System.DateTimeOffset projectedFirstOrderDate, 
                    decimal actualCost, 
                    int distributionQuantity, 
                    decimal projectedSales, 
                    decimal mailingCosts, 
                    global::System.DateTimeOffset mailDate, 
                    decimal printingCosts)
        {
            MCRSourceCode mCRSourceCode = new MCRSourceCode();
            mCRSourceCode.DataAreaId = dataAreaId;
            mCRSourceCode.SourceId = sourceId;
            mCRSourceCode.ProjectedOrders = projectedOrders;
            mCRSourceCode.OtherCost = otherCost;
            mCRSourceCode.FutureOrderDate = futureOrderDate;
            mCRSourceCode.ProjectedReturns = projectedReturns;
            mCRSourceCode.ProjectedFirstOrderDate = projectedFirstOrderDate;
            mCRSourceCode.ActualCost = actualCost;
            mCRSourceCode.DistributionQuantity = distributionQuantity;
            mCRSourceCode.ProjectedSales = projectedSales;
            mCRSourceCode.MailingCosts = mailingCosts;
            mCRSourceCode.MailDate = mailDate;
            mCRSourceCode.PrintingCosts = printingCosts;
            return mCRSourceCode;
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
        /// There are no comments for Property SourceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SourceId is required.")]
        public virtual string SourceId
        {
            get
            {
                return this._SourceId;
            }
            set
            {
                this.OnSourceIdChanging(value);
                this._SourceId = value;
                this.OnSourceIdChanged();
                this.OnPropertyChanged("SourceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceId;
        partial void OnSourceIdChanging(string value);
        partial void OnSourceIdChanged();
        /// <summary>
        /// There are no comments for Property ProjectedOrders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectedOrders")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjectedOrders is required.")]
        public virtual int ProjectedOrders
        {
            get
            {
                return this._ProjectedOrders;
            }
            set
            {
                this.OnProjectedOrdersChanging(value);
                this._ProjectedOrders = value;
                this.OnProjectedOrdersChanged();
                this.OnPropertyChanged("ProjectedOrders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ProjectedOrders;
        partial void OnProjectedOrdersChanging(int value);
        partial void OnProjectedOrdersChanged();
        /// <summary>
        /// There are no comments for Property OtherCost in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OtherCost")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OtherCost is required.")]
        public virtual decimal OtherCost
        {
            get
            {
                return this._OtherCost;
            }
            set
            {
                this.OnOtherCostChanging(value);
                this._OtherCost = value;
                this.OnOtherCostChanged();
                this.OnPropertyChanged("OtherCost");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OtherCost;
        partial void OnOtherCostChanging(decimal value);
        partial void OnOtherCostChanged();
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
        /// There are no comments for Property FutureOrderDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FutureOrderDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FutureOrderDate is required.")]
        public virtual global::System.DateTimeOffset FutureOrderDate
        {
            get
            {
                return this._FutureOrderDate;
            }
            set
            {
                this.OnFutureOrderDateChanging(value);
                this._FutureOrderDate = value;
                this.OnFutureOrderDateChanged();
                this.OnPropertyChanged("FutureOrderDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _FutureOrderDate;
        partial void OnFutureOrderDateChanging(global::System.DateTimeOffset value);
        partial void OnFutureOrderDateChanged();
        /// <summary>
        /// There are no comments for Property ProjectedReturns in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectedReturns")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjectedReturns is required.")]
        public virtual decimal ProjectedReturns
        {
            get
            {
                return this._ProjectedReturns;
            }
            set
            {
                this.OnProjectedReturnsChanging(value);
                this._ProjectedReturns = value;
                this.OnProjectedReturnsChanged();
                this.OnPropertyChanged("ProjectedReturns");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ProjectedReturns;
        partial void OnProjectedReturnsChanging(decimal value);
        partial void OnProjectedReturnsChanged();
        /// <summary>
        /// There are no comments for Property ProjectedFirstOrderDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectedFirstOrderDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjectedFirstOrderDate is required.")]
        public virtual global::System.DateTimeOffset ProjectedFirstOrderDate
        {
            get
            {
                return this._ProjectedFirstOrderDate;
            }
            set
            {
                this.OnProjectedFirstOrderDateChanging(value);
                this._ProjectedFirstOrderDate = value;
                this.OnProjectedFirstOrderDateChanged();
                this.OnPropertyChanged("ProjectedFirstOrderDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ProjectedFirstOrderDate;
        partial void OnProjectedFirstOrderDateChanging(global::System.DateTimeOffset value);
        partial void OnProjectedFirstOrderDateChanged();
        /// <summary>
        /// There are no comments for Property ActualCost in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActualCost")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ActualCost is required.")]
        public virtual decimal ActualCost
        {
            get
            {
                return this._ActualCost;
            }
            set
            {
                this.OnActualCostChanging(value);
                this._ActualCost = value;
                this.OnActualCostChanged();
                this.OnPropertyChanged("ActualCost");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ActualCost;
        partial void OnActualCostChanging(decimal value);
        partial void OnActualCostChanged();
        /// <summary>
        /// There are no comments for Property TargetId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TargetId")]
        public virtual string TargetId
        {
            get
            {
                return this._TargetId;
            }
            set
            {
                this.OnTargetIdChanging(value);
                this._TargetId = value;
                this.OnTargetIdChanged();
                this.OnPropertyChanged("TargetId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TargetId;
        partial void OnTargetIdChanging(string value);
        partial void OnTargetIdChanged();
        /// <summary>
        /// There are no comments for Property DistributionQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DistributionQuantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DistributionQuantity is required.")]
        public virtual int DistributionQuantity
        {
            get
            {
                return this._DistributionQuantity;
            }
            set
            {
                this.OnDistributionQuantityChanging(value);
                this._DistributionQuantity = value;
                this.OnDistributionQuantityChanged();
                this.OnPropertyChanged("DistributionQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _DistributionQuantity;
        partial void OnDistributionQuantityChanging(int value);
        partial void OnDistributionQuantityChanged();
        /// <summary>
        /// There are no comments for Property CatalogNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CatalogNumber")]
        public virtual string CatalogNumber
        {
            get
            {
                return this._CatalogNumber;
            }
            set
            {
                this.OnCatalogNumberChanging(value);
                this._CatalogNumber = value;
                this.OnCatalogNumberChanged();
                this.OnPropertyChanged("CatalogNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CatalogNumber;
        partial void OnCatalogNumberChanging(string value);
        partial void OnCatalogNumberChanged();
        /// <summary>
        /// There are no comments for Property ProjectedSales in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectedSales")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjectedSales is required.")]
        public virtual decimal ProjectedSales
        {
            get
            {
                return this._ProjectedSales;
            }
            set
            {
                this.OnProjectedSalesChanging(value);
                this._ProjectedSales = value;
                this.OnProjectedSalesChanged();
                this.OnPropertyChanged("ProjectedSales");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ProjectedSales;
        partial void OnProjectedSalesChanging(decimal value);
        partial void OnProjectedSalesChanged();
        /// <summary>
        /// There are no comments for Property MailingCosts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MailingCosts")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MailingCosts is required.")]
        public virtual decimal MailingCosts
        {
            get
            {
                return this._MailingCosts;
            }
            set
            {
                this.OnMailingCostsChanging(value);
                this._MailingCosts = value;
                this.OnMailingCostsChanged();
                this.OnPropertyChanged("MailingCosts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MailingCosts;
        partial void OnMailingCostsChanging(decimal value);
        partial void OnMailingCostsChanged();
        /// <summary>
        /// There are no comments for Property OnlyCatalogPlans in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OnlyCatalogPlans")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> OnlyCatalogPlans
        {
            get
            {
                return this._OnlyCatalogPlans;
            }
            set
            {
                this.OnOnlyCatalogPlansChanging(value);
                this._OnlyCatalogPlans = value;
                this.OnOnlyCatalogPlansChanged();
                this.OnPropertyChanged("OnlyCatalogPlans");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _OnlyCatalogPlans;
        partial void OnOnlyCatalogPlansChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnOnlyCatalogPlansChanged();
        /// <summary>
        /// There are no comments for Property MailDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MailDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MailDate is required.")]
        public virtual global::System.DateTimeOffset MailDate
        {
            get
            {
                return this._MailDate;
            }
            set
            {
                this.OnMailDateChanging(value);
                this._MailDate = value;
                this.OnMailDateChanged();
                this.OnPropertyChanged("MailDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _MailDate;
        partial void OnMailDateChanging(global::System.DateTimeOffset value);
        partial void OnMailDateChanged();
        /// <summary>
        /// There are no comments for Property PrintingCosts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PrintingCosts")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PrintingCosts is required.")]
        public virtual decimal PrintingCosts
        {
            get
            {
                return this._PrintingCosts;
            }
            set
            {
                this.OnPrintingCostsChanging(value);
                this._PrintingCosts = value;
                this.OnPrintingCostsChanged();
                this.OnPropertyChanged("PrintingCosts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PrintingCosts;
        partial void OnPrintingCostsChanging(decimal value);
        partial void OnPrintingCostsChanged();
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
