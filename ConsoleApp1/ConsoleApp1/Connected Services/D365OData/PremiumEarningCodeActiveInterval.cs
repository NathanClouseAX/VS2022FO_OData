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
    /// There are no comments for PremiumEarningCodeActiveIntervalSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PremiumEarningCodeActiveIntervalSingle")]
    public partial class PremiumEarningCodeActiveIntervalSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PremiumEarningCodeActiveInterval>
    {
        /// <summary>
        /// Initialize a new PremiumEarningCodeActiveIntervalSingle object.
        /// </summary>
        public PremiumEarningCodeActiveIntervalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PremiumEarningCodeActiveIntervalSingle object.
        /// </summary>
        public PremiumEarningCodeActiveIntervalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PremiumEarningCodeActiveIntervalSingle object.
        /// </summary>
        public PremiumEarningCodeActiveIntervalSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PremiumEarningCodeActiveInterval> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PremiumEarningCodeActiveInterval in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PremiumEarningCodeId
    /// ValidFrom
    /// ValidTo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PremiumEarningCodeId", "ValidFrom", "ValidTo")]
    [global::Microsoft.OData.Client.EntitySet("PremiumEarningCodeActiveIntervals")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PremiumEarningCodeActiveInterval")]
    public partial class PremiumEarningCodeActiveInterval : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PremiumEarningCodeActiveInterval object.
        /// </summary>
        /// <param name="premiumEarningCodeId">Initial value of PremiumEarningCodeId.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PremiumEarningCodeActiveInterval CreatePremiumEarningCodeActiveInterval(string premiumEarningCodeId, global::System.DateTimeOffset validFrom, global::System.DateTimeOffset validTo)
        {
            PremiumEarningCodeActiveInterval premiumEarningCodeActiveInterval = new PremiumEarningCodeActiveInterval();
            premiumEarningCodeActiveInterval.PremiumEarningCodeId = premiumEarningCodeId;
            premiumEarningCodeActiveInterval.ValidFrom = validFrom;
            premiumEarningCodeActiveInterval.ValidTo = validTo;
            return premiumEarningCodeActiveInterval;
        }
        /// <summary>
        /// There are no comments for Property PremiumEarningCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PremiumEarningCodeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PremiumEarningCodeId is required.")]
        public virtual string PremiumEarningCodeId
        {
            get
            {
                return this._PremiumEarningCodeId;
            }
            set
            {
                this.OnPremiumEarningCodeIdChanging(value);
                this._PremiumEarningCodeId = value;
                this.OnPremiumEarningCodeIdChanged();
                this.OnPropertyChanged("PremiumEarningCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PremiumEarningCodeId;
        partial void OnPremiumEarningCodeIdChanging(string value);
        partial void OnPremiumEarningCodeIdChanged();
        /// <summary>
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidFrom is required.")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidTo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidTo is required.")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
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