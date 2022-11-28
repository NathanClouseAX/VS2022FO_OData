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
    /// There are no comments for PricingPrioritySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PricingPrioritySingle")]
    public partial class PricingPrioritySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PricingPriority>
    {
        /// <summary>
        /// Initialize a new PricingPrioritySingle object.
        /// </summary>
        public PricingPrioritySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PricingPrioritySingle object.
        /// </summary>
        public PricingPrioritySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PricingPrioritySingle object.
        /// </summary>
        public PricingPrioritySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PricingPriority> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PricingPriority in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PricingPriorityNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PricingPriorityNumber")]
    [global::Microsoft.OData.Client.EntitySet("PricingPriorities")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PricingPriority")]
    public partial class PricingPriority : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PricingPriority object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="pricingPriorityNumber">Initial value of PricingPriorityNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PricingPriority CreatePricingPriority(string dataAreaId, int pricingPriorityNumber)
        {
            PricingPriority pricingPriority = new PricingPriority();
            pricingPriority.DataAreaId = dataAreaId;
            pricingPriority.PricingPriorityNumber = pricingPriorityNumber;
            return pricingPriority;
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
        /// There are no comments for Property PricingPriorityNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PricingPriorityNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PricingPriorityNumber is required.")]
        public virtual int PricingPriorityNumber
        {
            get
            {
                return this._PricingPriorityNumber;
            }
            set
            {
                this.OnPricingPriorityNumberChanging(value);
                this._PricingPriorityNumber = value;
                this.OnPricingPriorityNumberChanged();
                this.OnPropertyChanged("PricingPriorityNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PricingPriorityNumber;
        partial void OnPricingPriorityNumberChanging(int value);
        partial void OnPricingPriorityNumberChanged();
        /// <summary>
        /// There are no comments for Property PricingPriorityName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PricingPriorityName")]
        public virtual string PricingPriorityName
        {
            get
            {
                return this._PricingPriorityName;
            }
            set
            {
                this.OnPricingPriorityNameChanging(value);
                this._PricingPriorityName = value;
                this.OnPricingPriorityNameChanged();
                this.OnPropertyChanged("PricingPriorityName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PricingPriorityName;
        partial void OnPricingPriorityNameChanging(string value);
        partial void OnPricingPriorityNameChanged();
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