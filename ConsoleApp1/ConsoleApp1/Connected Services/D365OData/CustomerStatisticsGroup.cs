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
    /// There are no comments for CustomerStatisticsGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerStatisticsGroupSingle")]
    public partial class CustomerStatisticsGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerStatisticsGroup>
    {
        /// <summary>
        /// Initialize a new CustomerStatisticsGroupSingle object.
        /// </summary>
        public CustomerStatisticsGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CustomerStatisticsGroupSingle object.
        /// </summary>
        public CustomerStatisticsGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CustomerStatisticsGroupSingle object.
        /// </summary>
        public CustomerStatisticsGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerStatisticsGroup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CustomerStatisticsGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// StatisticsGroup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "StatisticsGroup")]
    [global::Microsoft.OData.Client.EntitySet("CustomerStatisticsGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerStatisticsGroup")]
    public partial class CustomerStatisticsGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CustomerStatisticsGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="statisticsGroup">Initial value of StatisticsGroup.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CustomerStatisticsGroup CreateCustomerStatisticsGroup(string dataAreaId, string statisticsGroup)
        {
            CustomerStatisticsGroup customerStatisticsGroup = new CustomerStatisticsGroup();
            customerStatisticsGroup.DataAreaId = dataAreaId;
            customerStatisticsGroup.StatisticsGroup = statisticsGroup;
            return customerStatisticsGroup;
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
        /// There are no comments for Property StatisticsGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StatisticsGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StatisticsGroup is required.")]
        public virtual string StatisticsGroup
        {
            get
            {
                return this._StatisticsGroup;
            }
            set
            {
                this.OnStatisticsGroupChanging(value);
                this._StatisticsGroup = value;
                this.OnStatisticsGroupChanged();
                this.OnPropertyChanged("StatisticsGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StatisticsGroup;
        partial void OnStatisticsGroupChanging(string value);
        partial void OnStatisticsGroupChanged();
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