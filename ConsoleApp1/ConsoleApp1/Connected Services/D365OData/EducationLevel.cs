//------------------------------------------------------------------------------
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
    /// There are no comments for EducationLevelSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EducationLevelSingle")]
    public partial class EducationLevelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EducationLevel>
    {
        /// <summary>
        /// Initialize a new EducationLevelSingle object.
        /// </summary>
        public EducationLevelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EducationLevelSingle object.
        /// </summary>
        public EducationLevelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EducationLevelSingle object.
        /// </summary>
        public EducationLevelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EducationLevel> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RecruitingRequestEducationLevels in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RecruitingRequestEducationLevels")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RecruitingRequestEducation> RecruitingRequestEducationLevels
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RecruitingRequestEducationLevels == null))
                {
                    this._RecruitingRequestEducationLevels = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RecruitingRequestEducation>(GetPath("RecruitingRequestEducationLevels"));
                }
                return this._RecruitingRequestEducationLevels;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RecruitingRequestEducation> _RecruitingRequestEducationLevels;
    }
    /// <summary>
    /// There are no comments for EducationLevel in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EducationLevelId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EducationLevelId")]
    [global::Microsoft.OData.Client.EntitySet("EducationLevels")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("EducationLevel")]
    public partial class EducationLevel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EducationLevel object.
        /// </summary>
        /// <param name="educationLevelId">Initial value of EducationLevelId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EducationLevel CreateEducationLevel(string educationLevelId)
        {
            EducationLevel educationLevel = new EducationLevel();
            educationLevel.EducationLevelId = educationLevelId;
            return educationLevel;
        }
        /// <summary>
        /// There are no comments for Property EducationLevelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EducationLevelId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EducationLevelId is required.")]
        public virtual string EducationLevelId
        {
            get
            {
                return this._EducationLevelId;
            }
            set
            {
                this.OnEducationLevelIdChanging(value);
                this._EducationLevelId = value;
                this.OnEducationLevelIdChanged();
                this.OnPropertyChanged("EducationLevelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EducationLevelId;
        partial void OnEducationLevelIdChanging(string value);
        partial void OnEducationLevelIdChanged();
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
        /// There are no comments for Property RecruitingRequestEducationLevels in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecruitingRequestEducationLevels")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecruitingRequestEducation> RecruitingRequestEducationLevels
        {
            get
            {
                return this._RecruitingRequestEducationLevels;
            }
            set
            {
                this.OnRecruitingRequestEducationLevelsChanging(value);
                this._RecruitingRequestEducationLevels = value;
                this.OnRecruitingRequestEducationLevelsChanged();
                this.OnPropertyChanged("RecruitingRequestEducationLevels");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecruitingRequestEducation> _RecruitingRequestEducationLevels = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecruitingRequestEducation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRecruitingRequestEducationLevelsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecruitingRequestEducation> value);
        partial void OnRecruitingRequestEducationLevelsChanged();
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
