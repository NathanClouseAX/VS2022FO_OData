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
    /// There are no comments for GSTReliefCategorySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("GSTReliefCategorySingle")]
    public partial class GSTReliefCategorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<GSTReliefCategory>
    {
        /// <summary>
        /// Initialize a new GSTReliefCategorySingle object.
        /// </summary>
        public GSTReliefCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new GSTReliefCategorySingle object.
        /// </summary>
        public GSTReliefCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new GSTReliefCategorySingle object.
        /// </summary>
        public GSTReliefCategorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<GSTReliefCategory> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductsV2 == null))
                {
                    this._ReleasedProductsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(GetPath("ReleasedProductsV2"));
                }
                return this._ReleasedProductsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2;
    }
    /// <summary>
    /// There are no comments for GSTReliefCategory in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ReliefCategoryEntityKey
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ReliefCategoryEntityKey")]
    [global::Microsoft.OData.Client.EntitySet("GSTReliefCategories")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("GSTReliefCategory")]
    public partial class GSTReliefCategory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new GSTReliefCategory object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="reliefCategoryEntityKey">Initial value of ReliefCategoryEntityKey.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static GSTReliefCategory CreateGSTReliefCategory(string dataAreaId, global::System.Guid reliefCategoryEntityKey)
        {
            GSTReliefCategory gSTReliefCategory = new GSTReliefCategory();
            gSTReliefCategory.DataAreaId = dataAreaId;
            gSTReliefCategory.ReliefCategoryEntityKey = reliefCategoryEntityKey;
            return gSTReliefCategory;
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
        /// There are no comments for Property ReliefCategoryEntityKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReliefCategoryEntityKey")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReliefCategoryEntityKey is required.")]
        public virtual global::System.Guid ReliefCategoryEntityKey
        {
            get
            {
                return this._ReliefCategoryEntityKey;
            }
            set
            {
                this.OnReliefCategoryEntityKeyChanging(value);
                this._ReliefCategoryEntityKey = value;
                this.OnReliefCategoryEntityKeyChanged();
                this.OnPropertyChanged("ReliefCategoryEntityKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _ReliefCategoryEntityKey;
        partial void OnReliefCategoryEntityKeyChanging(global::System.Guid value);
        partial void OnReliefCategoryEntityKeyChanged();
        /// <summary>
        /// There are no comments for Property ReliefSchedule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReliefSchedule")]
        public virtual string ReliefSchedule
        {
            get
            {
                return this._ReliefSchedule;
            }
            set
            {
                this.OnReliefScheduleChanging(value);
                this._ReliefSchedule = value;
                this.OnReliefScheduleChanged();
                this.OnPropertyChanged("ReliefSchedule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReliefSchedule;
        partial void OnReliefScheduleChanging(string value);
        partial void OnReliefScheduleChanged();
        /// <summary>
        /// There are no comments for Property ReliefCategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReliefCategoryId")]
        public virtual string ReliefCategoryId
        {
            get
            {
                return this._ReliefCategoryId;
            }
            set
            {
                this.OnReliefCategoryIdChanging(value);
                this._ReliefCategoryId = value;
                this.OnReliefCategoryIdChanged();
                this.OnPropertyChanged("ReliefCategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReliefCategoryId;
        partial void OnReliefCategoryIdChanging(string value);
        partial void OnReliefCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property ReliefItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReliefItemNumber")]
        public virtual string ReliefItemNumber
        {
            get
            {
                return this._ReliefItemNumber;
            }
            set
            {
                this.OnReliefItemNumberChanging(value);
                this._ReliefItemNumber = value;
                this.OnReliefItemNumberChanged();
                this.OnPropertyChanged("ReliefItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReliefItemNumber;
        partial void OnReliefItemNumberChanging(string value);
        partial void OnReliefItemNumberChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                return this._ReleasedProductsV2;
            }
            set
            {
                this.OnReleasedProductsV2Changing(value);
                this._ReleasedProductsV2 = value;
                this.OnReleasedProductsV2Changed();
                this.OnPropertyChanged("ReleasedProductsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedProductsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> value);
        partial void OnReleasedProductsV2Changed();
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
