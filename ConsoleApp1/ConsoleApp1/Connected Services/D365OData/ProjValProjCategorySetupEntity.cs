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
    /// There are no comments for ProjValProjCategorySetupEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjValProjCategorySetupEntitySingle")]
    public partial class ProjValProjCategorySetupEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjValProjCategorySetupEntity>
    {
        /// <summary>
        /// Initialize a new ProjValProjCategorySetupEntitySingle object.
        /// </summary>
        public ProjValProjCategorySetupEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjValProjCategorySetupEntitySingle object.
        /// </summary>
        public ProjValProjCategorySetupEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjValProjCategorySetupEntitySingle object.
        /// </summary>
        public ProjValProjCategorySetupEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjValProjCategorySetupEntity> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProjValProjCategorySetupEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// GroupId
    /// ProjectID
    /// Category
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GroupId", "ProjectID", "Category")]
    [global::Microsoft.OData.Client.EntitySet("ProjValProjCategorySetupEntities")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjValProjCategorySetupEntity")]
    public partial class ProjValProjCategorySetupEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjValProjCategorySetupEntity object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="groupId">Initial value of GroupId.</param>
        /// <param name="projectID">Initial value of ProjectID.</param>
        /// <param name="category">Initial value of Category.</param>
        /// <param name="amount">Initial value of Amount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjValProjCategorySetupEntity CreateProjValProjCategorySetupEntity(string dataAreaId, string groupId, string projectID, string category, decimal amount)
        {
            ProjValProjCategorySetupEntity projValProjCategorySetupEntity = new ProjValProjCategorySetupEntity();
            projValProjCategorySetupEntity.DataAreaId = dataAreaId;
            projValProjCategorySetupEntity.GroupId = groupId;
            projValProjCategorySetupEntity.ProjectID = projectID;
            projValProjCategorySetupEntity.Category = category;
            projValProjCategorySetupEntity.Amount = amount;
            return projValProjCategorySetupEntity;
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
        /// There are no comments for Property GroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GroupId is required.")]
        public virtual string GroupId
        {
            get
            {
                return this._GroupId;
            }
            set
            {
                this.OnGroupIdChanging(value);
                this._GroupId = value;
                this.OnGroupIdChanged();
                this.OnPropertyChanged("GroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupId;
        partial void OnGroupIdChanging(string value);
        partial void OnGroupIdChanged();
        /// <summary>
        /// There are no comments for Property ProjectID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjectID is required.")]
        public virtual string ProjectID
        {
            get
            {
                return this._ProjectID;
            }
            set
            {
                this.OnProjectIDChanging(value);
                this._ProjectID = value;
                this.OnProjectIDChanged();
                this.OnPropertyChanged("ProjectID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectID;
        partial void OnProjectIDChanging(string value);
        partial void OnProjectIDChanged();
        /// <summary>
        /// There are no comments for Property Category in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Category")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Category is required.")]
        public virtual string Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this.OnCategoryChanging(value);
                this._Category = value;
                this.OnCategoryChanged();
                this.OnPropertyChanged("Category");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Category;
        partial void OnCategoryChanging(string value);
        partial void OnCategoryChanged();
        /// <summary>
        /// There are no comments for Property Amount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Amount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Amount is required.")]
        public virtual decimal Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this.OnAmountChanging(value);
                this._Amount = value;
                this.OnAmountChanged();
                this.OnPropertyChanged("Amount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Amount;
        partial void OnAmountChanging(decimal value);
        partial void OnAmountChanged();
        /// <summary>
        /// There are no comments for Property CategoryValidationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CategoryValidationType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PSAExpenseProjValCategoryType> CategoryValidationType
        {
            get
            {
                return this._CategoryValidationType;
            }
            set
            {
                this.OnCategoryValidationTypeChanging(value);
                this._CategoryValidationType = value;
                this.OnCategoryValidationTypeChanged();
                this.OnPropertyChanged("CategoryValidationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PSAExpenseProjValCategoryType> _CategoryValidationType;
        partial void OnCategoryValidationTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PSAExpenseProjValCategoryType> value);
        partial void OnCategoryValidationTypeChanged();
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
