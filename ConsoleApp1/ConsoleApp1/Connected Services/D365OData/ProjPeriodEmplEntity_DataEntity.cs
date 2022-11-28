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
    /// There are no comments for ProjPeriodEmplEntity_DataEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjPeriodEmplEntity_DataEntitySingle")]
    public partial class ProjPeriodEmplEntity_DataEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjPeriodEmplEntity_DataEntity>
    {
        /// <summary>
        /// Initialize a new ProjPeriodEmplEntity_DataEntitySingle object.
        /// </summary>
        public ProjPeriodEmplEntity_DataEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjPeriodEmplEntity_DataEntitySingle object.
        /// </summary>
        public ProjPeriodEmplEntity_DataEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjPeriodEmplEntity_DataEntitySingle object.
        /// </summary>
        public ProjPeriodEmplEntity_DataEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjPeriodEmplEntity_DataEntity> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProjPeriodEmplEntity_DataEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PeriodId
    /// PeriodFrom
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PeriodId", "PeriodFrom")]
    [global::Microsoft.OData.Client.EntitySet("ProjPeriodEmplEntity_DataEntities")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjPeriodEmplEntity_DataEntity")]
    public partial class ProjPeriodEmplEntity_DataEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjPeriodEmplEntity_DataEntity object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="periodId">Initial value of PeriodId.</param>
        /// <param name="periodFrom">Initial value of PeriodFrom.</param>
        /// <param name="normBillable">Initial value of NormBillable.</param>
        /// <param name="normEfficiency">Initial value of NormEfficiency.</param>
        /// <param name="postedDate">Initial value of PostedDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjPeriodEmplEntity_DataEntity CreateProjPeriodEmplEntity_DataEntity(string dataAreaId, 
                    string periodId, 
                    global::System.DateTimeOffset periodFrom, 
                    decimal normBillable, 
                    decimal normEfficiency, 
                    global::System.DateTimeOffset postedDate)
        {
            ProjPeriodEmplEntity_DataEntity projPeriodEmplEntity_DataEntity = new ProjPeriodEmplEntity_DataEntity();
            projPeriodEmplEntity_DataEntity.DataAreaId = dataAreaId;
            projPeriodEmplEntity_DataEntity.PeriodId = periodId;
            projPeriodEmplEntity_DataEntity.PeriodFrom = periodFrom;
            projPeriodEmplEntity_DataEntity.NormBillable = normBillable;
            projPeriodEmplEntity_DataEntity.NormEfficiency = normEfficiency;
            projPeriodEmplEntity_DataEntity.PostedDate = postedDate;
            return projPeriodEmplEntity_DataEntity;
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
        /// There are no comments for Property PeriodId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodId is required.")]
        public virtual string PeriodId
        {
            get
            {
                return this._PeriodId;
            }
            set
            {
                this.OnPeriodIdChanging(value);
                this._PeriodId = value;
                this.OnPeriodIdChanged();
                this.OnPropertyChanged("PeriodId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PeriodId;
        partial void OnPeriodIdChanging(string value);
        partial void OnPeriodIdChanged();
        /// <summary>
        /// There are no comments for Property PeriodFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodFrom is required.")]
        public virtual global::System.DateTimeOffset PeriodFrom
        {
            get
            {
                return this._PeriodFrom;
            }
            set
            {
                this.OnPeriodFromChanging(value);
                this._PeriodFrom = value;
                this.OnPeriodFromChanged();
                this.OnPropertyChanged("PeriodFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PeriodFrom;
        partial void OnPeriodFromChanging(global::System.DateTimeOffset value);
        partial void OnPeriodFromChanged();
        /// <summary>
        /// There are no comments for Property IsPosted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsPosted")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPosted
        {
            get
            {
                return this._IsPosted;
            }
            set
            {
                this.OnIsPostedChanging(value);
                this._IsPosted = value;
                this.OnIsPostedChanged();
                this.OnPropertyChanged("IsPosted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPosted;
        partial void OnIsPostedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPostedChanged();
        /// <summary>
        /// There are no comments for Property ResourceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ResourceId")]
        public virtual string ResourceId
        {
            get
            {
                return this._ResourceId;
            }
            set
            {
                this.OnResourceIdChanging(value);
                this._ResourceId = value;
                this.OnResourceIdChanged();
                this.OnPropertyChanged("ResourceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ResourceId;
        partial void OnResourceIdChanging(string value);
        partial void OnResourceIdChanged();
        /// <summary>
        /// There are no comments for Property NormBillable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NormBillable")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NormBillable is required.")]
        public virtual decimal NormBillable
        {
            get
            {
                return this._NormBillable;
            }
            set
            {
                this.OnNormBillableChanging(value);
                this._NormBillable = value;
                this.OnNormBillableChanged();
                this.OnPropertyChanged("NormBillable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _NormBillable;
        partial void OnNormBillableChanging(decimal value);
        partial void OnNormBillableChanged();
        /// <summary>
        /// There are no comments for Property NormEfficiency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NormEfficiency")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NormEfficiency is required.")]
        public virtual decimal NormEfficiency
        {
            get
            {
                return this._NormEfficiency;
            }
            set
            {
                this.OnNormEfficiencyChanging(value);
                this._NormEfficiency = value;
                this.OnNormEfficiencyChanged();
                this.OnPropertyChanged("NormEfficiency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _NormEfficiency;
        partial void OnNormEfficiencyChanging(decimal value);
        partial void OnNormEfficiencyChanged();
        /// <summary>
        /// There are no comments for Property PostedDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostedDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PostedDate is required.")]
        public virtual global::System.DateTimeOffset PostedDate
        {
            get
            {
                return this._PostedDate;
            }
            set
            {
                this.OnPostedDateChanging(value);
                this._PostedDate = value;
                this.OnPostedDateChanged();
                this.OnPropertyChanged("PostedDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PostedDate;
        partial void OnPostedDateChanging(global::System.DateTimeOffset value);
        partial void OnPostedDateChanged();
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