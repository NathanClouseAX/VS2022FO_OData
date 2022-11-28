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
    /// There are no comments for RetailInformationSubcodeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInformationSubcodeSingle")]
    public partial class RetailInformationSubcodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailInformationSubcode>
    {
        /// <summary>
        /// Initialize a new RetailInformationSubcodeSingle object.
        /// </summary>
        public RetailInformationSubcodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailInformationSubcodeSingle object.
        /// </summary>
        public RetailInformationSubcodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailInformationSubcodeSingle object.
        /// </summary>
        public RetailInformationSubcodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailInformationSubcode> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Infocode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Infocode")]
        public virtual global::Microsoft.Dynamics.DataEntities.InfocodeSingle Infocode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Infocode == null))
                {
                    this._Infocode = new global::Microsoft.Dynamics.DataEntities.InfocodeSingle(this.Context, GetPath("Infocode"));
                }
                return this._Infocode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.InfocodeSingle _Infocode;
        /// <summary>
        /// There are no comments for RetailInformationSubcodeTranslation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInformationSubcodeTranslation")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailInformationSubcodeTranslation> RetailInformationSubcodeTranslation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailInformationSubcodeTranslation == null))
                {
                    this._RetailInformationSubcodeTranslation = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailInformationSubcodeTranslation>(GetPath("RetailInformationSubcodeTranslation"));
                }
                return this._RetailInformationSubcodeTranslation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailInformationSubcodeTranslation> _RetailInformationSubcodeTranslation;
    }
    /// <summary>
    /// There are no comments for RetailInformationSubcode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// InfocodeId
    /// SubcodeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "InfocodeId", "SubcodeId")]
    [global::Microsoft.OData.Client.EntitySet("RetailInformationSubcodes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInformationSubcode")]
    public partial class RetailInformationSubcode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailInformationSubcode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="infocodeId">Initial value of InfocodeId.</param>
        /// <param name="subcodeId">Initial value of SubcodeId.</param>
        /// <param name="amountPercent">Initial value of AmountPercent.</param>
        /// <param name="infocode">Initial value of Infocode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailInformationSubcode CreateRetailInformationSubcode(string dataAreaId, string infocodeId, string subcodeId, decimal amountPercent, global::Microsoft.Dynamics.DataEntities.Infocode infocode)
        {
            RetailInformationSubcode retailInformationSubcode = new RetailInformationSubcode();
            retailInformationSubcode.DataAreaId = dataAreaId;
            retailInformationSubcode.InfocodeId = infocodeId;
            retailInformationSubcode.SubcodeId = subcodeId;
            retailInformationSubcode.AmountPercent = amountPercent;
            if ((infocode == null))
            {
                throw new global::System.ArgumentNullException("infocode");
            }
            retailInformationSubcode.Infocode = infocode;
            return retailInformationSubcode;
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
        /// There are no comments for Property InfocodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InfocodeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InfocodeId is required.")]
        public virtual string InfocodeId
        {
            get
            {
                return this._InfocodeId;
            }
            set
            {
                this.OnInfocodeIdChanging(value);
                this._InfocodeId = value;
                this.OnInfocodeIdChanged();
                this.OnPropertyChanged("InfocodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InfocodeId;
        partial void OnInfocodeIdChanging(string value);
        partial void OnInfocodeIdChanged();
        /// <summary>
        /// There are no comments for Property SubcodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubcodeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SubcodeId is required.")]
        public virtual string SubcodeId
        {
            get
            {
                return this._SubcodeId;
            }
            set
            {
                this.OnSubcodeIdChanging(value);
                this._SubcodeId = value;
                this.OnSubcodeIdChanged();
                this.OnPropertyChanged("SubcodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SubcodeId;
        partial void OnSubcodeIdChanging(string value);
        partial void OnSubcodeIdChanged();
        /// <summary>
        /// There are no comments for Property TriggerCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TriggerCode")]
        public virtual string TriggerCode
        {
            get
            {
                return this._TriggerCode;
            }
            set
            {
                this.OnTriggerCodeChanging(value);
                this._TriggerCode = value;
                this.OnTriggerCodeChanged();
                this.OnPropertyChanged("TriggerCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TriggerCode;
        partial void OnTriggerCodeChanging(string value);
        partial void OnTriggerCodeChanged();
        /// <summary>
        /// There are no comments for Property TriggerFunction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TriggerFunction")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTriggerFunction> TriggerFunction
        {
            get
            {
                return this._TriggerFunction;
            }
            set
            {
                this.OnTriggerFunctionChanging(value);
                this._TriggerFunction = value;
                this.OnTriggerFunctionChanged();
                this.OnPropertyChanged("TriggerFunction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTriggerFunction> _TriggerFunction;
        partial void OnTriggerFunctionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTriggerFunction> value);
        partial void OnTriggerFunctionChanged();
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
        /// There are no comments for Property AmountPercent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AmountPercent")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AmountPercent is required.")]
        public virtual decimal AmountPercent
        {
            get
            {
                return this._AmountPercent;
            }
            set
            {
                this.OnAmountPercentChanging(value);
                this._AmountPercent = value;
                this.OnAmountPercentChanged();
                this.OnPropertyChanged("AmountPercent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AmountPercent;
        partial void OnAmountPercentChanging(decimal value);
        partial void OnAmountPercentChanged();
        /// <summary>
        /// There are no comments for Property PriceType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailPriceType> PriceType
        {
            get
            {
                return this._PriceType;
            }
            set
            {
                this.OnPriceTypeChanging(value);
                this._PriceType = value;
                this.OnPriceTypeChanged();
                this.OnPropertyChanged("PriceType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailPriceType> _PriceType;
        partial void OnPriceTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailPriceType> value);
        partial void OnPriceTypeChanged();
        /// <summary>
        /// There are no comments for Property Infocode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Infocode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Infocode is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Infocode Infocode
        {
            get
            {
                return this._Infocode;
            }
            set
            {
                this.OnInfocodeChanging(value);
                this._Infocode = value;
                this.OnInfocodeChanged();
                this.OnPropertyChanged("Infocode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Infocode _Infocode;
        partial void OnInfocodeChanging(global::Microsoft.Dynamics.DataEntities.Infocode value);
        partial void OnInfocodeChanged();
        /// <summary>
        /// There are no comments for Property RetailInformationSubcodeTranslation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInformationSubcodeTranslation")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailInformationSubcodeTranslation> RetailInformationSubcodeTranslation
        {
            get
            {
                return this._RetailInformationSubcodeTranslation;
            }
            set
            {
                this.OnRetailInformationSubcodeTranslationChanging(value);
                this._RetailInformationSubcodeTranslation = value;
                this.OnRetailInformationSubcodeTranslationChanged();
                this.OnPropertyChanged("RetailInformationSubcodeTranslation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailInformationSubcodeTranslation> _RetailInformationSubcodeTranslation = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailInformationSubcodeTranslation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailInformationSubcodeTranslationChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailInformationSubcodeTranslation> value);
        partial void OnRetailInformationSubcodeTranslationChanged();
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