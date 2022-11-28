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
    /// There are no comments for SADGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SADGroupSingle")]
    public partial class SADGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SADGroup>
    {
        /// <summary>
        /// Initialize a new SADGroupSingle object.
        /// </summary>
        public SADGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SADGroupSingle object.
        /// </summary>
        public SADGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SADGroupSingle object.
        /// </summary>
        public SADGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SADGroup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SADGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// SADGroup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "SADGroup")]
    [global::Microsoft.OData.Client.EntitySet("SADGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SADGroup")]
    public partial class SADGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SADGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="sADGroup1">Initial value of SADGroup1.</param>
        /// <param name="duty">Initial value of Duty.</param>
        /// <param name="excise">Initial value of Excise.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SADGroup CreateSADGroup(string dataAreaId, string sADGroup1, decimal duty, decimal excise)
        {
            SADGroup sADGroup = new SADGroup();
            sADGroup.DataAreaId = dataAreaId;
            sADGroup.SADGroup1 = sADGroup1;
            sADGroup.Duty = duty;
            sADGroup.Excise = excise;
            return sADGroup;
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
        /// There are no comments for Property SADGroup1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SADGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SADGroup1 is required.")]
        public virtual string SADGroup1
        {
            get
            {
                return this._SADGroup1;
            }
            set
            {
                this.OnSADGroup1Changing(value);
                this._SADGroup1 = value;
                this.OnSADGroup1Changed();
                this.OnPropertyChanged("SADGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SADGroup1;
        partial void OnSADGroup1Changing(string value);
        partial void OnSADGroup1Changed();
        /// <summary>
        /// There are no comments for Property Duty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Duty")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Duty is required.")]
        public virtual decimal Duty
        {
            get
            {
                return this._Duty;
            }
            set
            {
                this.OnDutyChanging(value);
                this._Duty = value;
                this.OnDutyChanged();
                this.OnPropertyChanged("Duty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Duty;
        partial void OnDutyChanging(decimal value);
        partial void OnDutyChanged();
        /// <summary>
        /// There are no comments for Property VATCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VATCode")]
        public virtual string VATCode
        {
            get
            {
                return this._VATCode;
            }
            set
            {
                this.OnVATCodeChanging(value);
                this._VATCode = value;
                this.OnVATCodeChanged();
                this.OnPropertyChanged("VATCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VATCode;
        partial void OnVATCodeChanging(string value);
        partial void OnVATCodeChanged();
        /// <summary>
        /// There are no comments for Property Excise in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Excise")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Excise is required.")]
        public virtual decimal Excise
        {
            get
            {
                return this._Excise;
            }
            set
            {
                this.OnExciseChanging(value);
                this._Excise = value;
                this.OnExciseChanged();
                this.OnPropertyChanged("Excise");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Excise;
        partial void OnExciseChanging(decimal value);
        partial void OnExciseChanged();
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