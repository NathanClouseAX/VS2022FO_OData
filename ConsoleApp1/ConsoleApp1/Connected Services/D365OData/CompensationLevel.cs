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
    /// There are no comments for CompensationLevelSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationLevelSingle")]
    public partial class CompensationLevelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationLevel>
    {
        /// <summary>
        /// Initialize a new CompensationLevelSingle object.
        /// </summary>
        public CompensationLevelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CompensationLevelSingle object.
        /// </summary>
        public CompensationLevelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CompensationLevelSingle object.
        /// </summary>
        public CompensationLevelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationLevel> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CompVarPlanLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CompVarPlanLevel")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevel> CompVarPlanLevel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompVarPlanLevel == null))
                {
                    this._CompVarPlanLevel = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevel>(GetPath("CompVarPlanLevel"));
                }
                return this._CompVarPlanLevel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevel> _CompVarPlanLevel;
        /// <summary>
        /// There are no comments for CompFixedEmpls in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CompFixedEmpls")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompFixedEmpl> CompFixedEmpls
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompFixedEmpls == null))
                {
                    this._CompFixedEmpls = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CompFixedEmpl>(GetPath("CompFixedEmpls"));
                }
                return this._CompFixedEmpls;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompFixedEmpl> _CompFixedEmpls;
        /// <summary>
        /// There are no comments for BenefitRateTiers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitRateTiers")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsRateTier> BenefitRateTiers
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitRateTiers == null))
                {
                    this._BenefitRateTiers = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BenefitsRateTier>(GetPath("BenefitRateTiers"));
                }
                return this._BenefitRateTiers;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsRateTier> _BenefitRateTiers;
        /// <summary>
        /// There are no comments for CompensationStructures in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationStructures")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationStructure> CompensationStructures
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationStructures == null))
                {
                    this._CompensationStructures = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CompensationStructure>(GetPath("CompensationStructures"));
                }
                return this._CompensationStructures;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationStructure> _CompensationStructures;
        /// <summary>
        /// There are no comments for Jobs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Jobs")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Job> Jobs
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Jobs == null))
                {
                    this._Jobs = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Job>(GetPath("Jobs"));
                }
                return this._Jobs;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Job> _Jobs;
        /// <summary>
        /// There are no comments for CompensationLevels in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationLevels")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobCompensation> CompensationLevels
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationLevels == null))
                {
                    this._CompensationLevels = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JobCompensation>(GetPath("CompensationLevels"));
                }
                return this._CompensationLevels;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobCompensation> _CompensationLevels;
        /// <summary>
        /// There are no comments for BenefitRateDoubleTiers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitRateDoubleTiers")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsRateDoubleTier> BenefitRateDoubleTiers
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitRateDoubleTiers == null))
                {
                    this._BenefitRateDoubleTiers = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BenefitsRateDoubleTier>(GetPath("BenefitRateDoubleTiers"));
                }
                return this._BenefitRateDoubleTiers;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsRateDoubleTier> _BenefitRateDoubleTiers;
        /// <summary>
        /// There are no comments for CompVarPlanLevelV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CompVarPlanLevelV2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevelV2> CompVarPlanLevelV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompVarPlanLevelV2 == null))
                {
                    this._CompVarPlanLevelV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevelV2>(GetPath("CompVarPlanLevelV2"));
                }
                return this._CompVarPlanLevelV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevelV2> _CompVarPlanLevelV2;
        /// <summary>
        /// There are no comments for RecruitingRequests in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RecruitingRequests")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RecruitingRequest> RecruitingRequests
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RecruitingRequests == null))
                {
                    this._RecruitingRequests = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RecruitingRequest>(GetPath("RecruitingRequests"));
                }
                return this._RecruitingRequests;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RecruitingRequest> _RecruitingRequests;
    }
    /// <summary>
    /// There are no comments for CompensationLevel in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Level
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Level")]
    [global::Microsoft.OData.Client.EntitySet("CompensationLevels")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationLevel")]
    public partial class CompensationLevel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CompensationLevel object.
        /// </summary>
        /// <param name="level">Initial value of Level.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CompensationLevel CreateCompensationLevel(string level, decimal lineNumber)
        {
            CompensationLevel compensationLevel = new CompensationLevel();
            compensationLevel.Level = level;
            compensationLevel.LineNumber = lineNumber;
            return compensationLevel;
        }
        /// <summary>
        /// There are no comments for Property Level in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Level")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Level is required.")]
        public virtual string Level
        {
            get
            {
                return this._Level;
            }
            set
            {
                this.OnLevelChanging(value);
                this._Level = value;
                this.OnLevelChanged();
                this.OnPropertyChanged("Level");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Level;
        partial void OnLevelChanging(string value);
        partial void OnLevelChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNumber is required.")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
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
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmCompensationType> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmCompensationType> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmCompensationType> value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property CompVarPlanLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompVarPlanLevel")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevel> CompVarPlanLevel
        {
            get
            {
                return this._CompVarPlanLevel;
            }
            set
            {
                this.OnCompVarPlanLevelChanging(value);
                this._CompVarPlanLevel = value;
                this.OnCompVarPlanLevelChanged();
                this.OnPropertyChanged("CompVarPlanLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevel> _CompVarPlanLevel = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevel>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompVarPlanLevelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevel> value);
        partial void OnCompVarPlanLevelChanged();
        /// <summary>
        /// There are no comments for Property CompFixedEmpls in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompFixedEmpls")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompFixedEmpl> CompFixedEmpls
        {
            get
            {
                return this._CompFixedEmpls;
            }
            set
            {
                this.OnCompFixedEmplsChanging(value);
                this._CompFixedEmpls = value;
                this.OnCompFixedEmplsChanged();
                this.OnPropertyChanged("CompFixedEmpls");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompFixedEmpl> _CompFixedEmpls = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompFixedEmpl>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompFixedEmplsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompFixedEmpl> value);
        partial void OnCompFixedEmplsChanged();
        /// <summary>
        /// There are no comments for Property BenefitRateTiers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitRateTiers")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsRateTier> BenefitRateTiers
        {
            get
            {
                return this._BenefitRateTiers;
            }
            set
            {
                this.OnBenefitRateTiersChanging(value);
                this._BenefitRateTiers = value;
                this.OnBenefitRateTiersChanged();
                this.OnPropertyChanged("BenefitRateTiers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsRateTier> _BenefitRateTiers = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsRateTier>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBenefitRateTiersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsRateTier> value);
        partial void OnBenefitRateTiersChanged();
        /// <summary>
        /// There are no comments for Property CompensationStructures in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationStructures")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationStructure> CompensationStructures
        {
            get
            {
                return this._CompensationStructures;
            }
            set
            {
                this.OnCompensationStructuresChanging(value);
                this._CompensationStructures = value;
                this.OnCompensationStructuresChanged();
                this.OnPropertyChanged("CompensationStructures");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationStructure> _CompensationStructures = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationStructure>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompensationStructuresChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationStructure> value);
        partial void OnCompensationStructuresChanged();
        /// <summary>
        /// There are no comments for Property Jobs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Jobs")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Job> Jobs
        {
            get
            {
                return this._Jobs;
            }
            set
            {
                this.OnJobsChanging(value);
                this._Jobs = value;
                this.OnJobsChanged();
                this.OnPropertyChanged("Jobs");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Job> _Jobs = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Job>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Job> value);
        partial void OnJobsChanged();
        /// <summary>
        /// There are no comments for Property CompensationLevels in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationLevels")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobCompensation> CompensationLevels
        {
            get
            {
                return this._CompensationLevels;
            }
            set
            {
                this.OnCompensationLevelsChanging(value);
                this._CompensationLevels = value;
                this.OnCompensationLevelsChanged();
                this.OnPropertyChanged("CompensationLevels");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobCompensation> _CompensationLevels = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobCompensation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompensationLevelsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobCompensation> value);
        partial void OnCompensationLevelsChanged();
        /// <summary>
        /// There are no comments for Property BenefitRateDoubleTiers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitRateDoubleTiers")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsRateDoubleTier> BenefitRateDoubleTiers
        {
            get
            {
                return this._BenefitRateDoubleTiers;
            }
            set
            {
                this.OnBenefitRateDoubleTiersChanging(value);
                this._BenefitRateDoubleTiers = value;
                this.OnBenefitRateDoubleTiersChanged();
                this.OnPropertyChanged("BenefitRateDoubleTiers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsRateDoubleTier> _BenefitRateDoubleTiers = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsRateDoubleTier>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBenefitRateDoubleTiersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsRateDoubleTier> value);
        partial void OnBenefitRateDoubleTiersChanged();
        /// <summary>
        /// There are no comments for Property CompVarPlanLevelV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompVarPlanLevelV2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevelV2> CompVarPlanLevelV2
        {
            get
            {
                return this._CompVarPlanLevelV2;
            }
            set
            {
                this.OnCompVarPlanLevelV2Changing(value);
                this._CompVarPlanLevelV2 = value;
                this.OnCompVarPlanLevelV2Changed();
                this.OnPropertyChanged("CompVarPlanLevelV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevelV2> _CompVarPlanLevelV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevelV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompVarPlanLevelV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompVarPlanLevelV2> value);
        partial void OnCompVarPlanLevelV2Changed();
        /// <summary>
        /// There are no comments for Property RecruitingRequests in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecruitingRequests")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecruitingRequest> RecruitingRequests
        {
            get
            {
                return this._RecruitingRequests;
            }
            set
            {
                this.OnRecruitingRequestsChanging(value);
                this._RecruitingRequests = value;
                this.OnRecruitingRequestsChanged();
                this.OnPropertyChanged("RecruitingRequests");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecruitingRequest> _RecruitingRequests = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecruitingRequest>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRecruitingRequestsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecruitingRequest> value);
        partial void OnRecruitingRequestsChanged();
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