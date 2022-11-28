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
    /// There are no comments for JobTemplateSkillSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("JobTemplateSkillSingle")]
    public partial class JobTemplateSkillSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<JobTemplateSkill>
    {
        /// <summary>
        /// Initialize a new JobTemplateSkillSingle object.
        /// </summary>
        public JobTemplateSkillSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new JobTemplateSkillSingle object.
        /// </summary>
        public JobTemplateSkillSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new JobTemplateSkillSingle object.
        /// </summary>
        public JobTemplateSkillSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<JobTemplateSkill> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for JobTemplate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("JobTemplate")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobTemplateSingle JobTemplate
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobTemplate == null))
                {
                    this._JobTemplate = new global::Microsoft.Dynamics.DataEntities.JobTemplateSingle(this.Context, GetPath("JobTemplate"));
                }
                return this._JobTemplate;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobTemplateSingle _JobTemplate;
        /// <summary>
        /// There are no comments for RatingLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RatingLevel")]
        public virtual global::Microsoft.Dynamics.DataEntities.RatingLevelSingle RatingLevel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RatingLevel == null))
                {
                    this._RatingLevel = new global::Microsoft.Dynamics.DataEntities.RatingLevelSingle(this.Context, GetPath("RatingLevel"));
                }
                return this._RatingLevel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RatingLevelSingle _RatingLevel;
        /// <summary>
        /// There are no comments for Skill in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Skill")]
        public virtual global::Microsoft.Dynamics.DataEntities.SkillSingle Skill
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Skill == null))
                {
                    this._Skill = new global::Microsoft.Dynamics.DataEntities.SkillSingle(this.Context, GetPath("Skill"));
                }
                return this._Skill;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SkillSingle _Skill;
    }
    /// <summary>
    /// There are no comments for JobTemplateSkill in the schema.
    /// </summary>
    /// <KeyProperties>
    /// JobTemplateId
    /// SkillId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("JobTemplateId", "SkillId")]
    [global::Microsoft.OData.Client.EntitySet("JobTemplateSkills")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("JobTemplateSkill")]
    public partial class JobTemplateSkill : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new JobTemplateSkill object.
        /// </summary>
        /// <param name="jobTemplateId">Initial value of JobTemplateId.</param>
        /// <param name="skillId">Initial value of SkillId.</param>
        /// <param name="jobTemplate">Initial value of JobTemplate.</param>
        /// <param name="ratingLevel">Initial value of RatingLevel.</param>
        /// <param name="skill">Initial value of Skill.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static JobTemplateSkill CreateJobTemplateSkill(string jobTemplateId, string skillId, global::Microsoft.Dynamics.DataEntities.JobTemplate jobTemplate, global::Microsoft.Dynamics.DataEntities.RatingLevel ratingLevel, global::Microsoft.Dynamics.DataEntities.Skill skill)
        {
            JobTemplateSkill jobTemplateSkill = new JobTemplateSkill();
            jobTemplateSkill.JobTemplateId = jobTemplateId;
            jobTemplateSkill.SkillId = skillId;
            if ((jobTemplate == null))
            {
                throw new global::System.ArgumentNullException("jobTemplate");
            }
            jobTemplateSkill.JobTemplate = jobTemplate;
            if ((ratingLevel == null))
            {
                throw new global::System.ArgumentNullException("ratingLevel");
            }
            jobTemplateSkill.RatingLevel = ratingLevel;
            if ((skill == null))
            {
                throw new global::System.ArgumentNullException("skill");
            }
            jobTemplateSkill.Skill = skill;
            return jobTemplateSkill;
        }
        /// <summary>
        /// There are no comments for Property JobTemplateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JobTemplateId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JobTemplateId is required.")]
        public virtual string JobTemplateId
        {
            get
            {
                return this._JobTemplateId;
            }
            set
            {
                this.OnJobTemplateIdChanging(value);
                this._JobTemplateId = value;
                this.OnJobTemplateIdChanged();
                this.OnPropertyChanged("JobTemplateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTemplateId;
        partial void OnJobTemplateIdChanging(string value);
        partial void OnJobTemplateIdChanged();
        /// <summary>
        /// There are no comments for Property SkillId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SkillId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SkillId is required.")]
        public virtual string SkillId
        {
            get
            {
                return this._SkillId;
            }
            set
            {
                this.OnSkillIdChanging(value);
                this._SkillId = value;
                this.OnSkillIdChanged();
                this.OnPropertyChanged("SkillId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SkillId;
        partial void OnSkillIdChanging(string value);
        partial void OnSkillIdChanged();
        /// <summary>
        /// There are no comments for Property LevelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LevelId")]
        public virtual string LevelId
        {
            get
            {
                return this._LevelId;
            }
            set
            {
                this.OnLevelIdChanging(value);
                this._LevelId = value;
                this.OnLevelIdChanged();
                this.OnPropertyChanged("LevelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LevelId;
        partial void OnLevelIdChanging(string value);
        partial void OnLevelIdChanged();
        /// <summary>
        /// There are no comments for Property RatingId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RatingId")]
        public virtual string RatingId
        {
            get
            {
                return this._RatingId;
            }
            set
            {
                this.OnRatingIdChanging(value);
                this._RatingId = value;
                this.OnRatingIdChanged();
                this.OnPropertyChanged("RatingId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RatingId;
        partial void OnRatingIdChanging(string value);
        partial void OnRatingIdChanged();
        /// <summary>
        /// There are no comments for Property Importance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Importance")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmSkillImportance> Importance
        {
            get
            {
                return this._Importance;
            }
            set
            {
                this.OnImportanceChanging(value);
                this._Importance = value;
                this.OnImportanceChanged();
                this.OnPropertyChanged("Importance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmSkillImportance> _Importance;
        partial void OnImportanceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmSkillImportance> value);
        partial void OnImportanceChanged();
        /// <summary>
        /// There are no comments for Property JobTemplate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JobTemplate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JobTemplate is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobTemplate JobTemplate
        {
            get
            {
                return this._JobTemplate;
            }
            set
            {
                this.OnJobTemplateChanging(value);
                this._JobTemplate = value;
                this.OnJobTemplateChanged();
                this.OnPropertyChanged("JobTemplate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobTemplate _JobTemplate;
        partial void OnJobTemplateChanging(global::Microsoft.Dynamics.DataEntities.JobTemplate value);
        partial void OnJobTemplateChanged();
        /// <summary>
        /// There are no comments for Property RatingLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RatingLevel")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RatingLevel is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RatingLevel RatingLevel
        {
            get
            {
                return this._RatingLevel;
            }
            set
            {
                this.OnRatingLevelChanging(value);
                this._RatingLevel = value;
                this.OnRatingLevelChanged();
                this.OnPropertyChanged("RatingLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RatingLevel _RatingLevel;
        partial void OnRatingLevelChanging(global::Microsoft.Dynamics.DataEntities.RatingLevel value);
        partial void OnRatingLevelChanged();
        /// <summary>
        /// There are no comments for Property Skill in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Skill")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Skill is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Skill Skill
        {
            get
            {
                return this._Skill;
            }
            set
            {
                this.OnSkillChanging(value);
                this._Skill = value;
                this.OnSkillChanged();
                this.OnPropertyChanged("Skill");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Skill _Skill;
        partial void OnSkillChanging(global::Microsoft.Dynamics.DataEntities.Skill value);
        partial void OnSkillChanged();
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
