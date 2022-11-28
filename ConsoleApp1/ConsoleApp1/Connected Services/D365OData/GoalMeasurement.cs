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
    /// There are no comments for GoalMeasurementSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("GoalMeasurementSingle")]
    public partial class GoalMeasurementSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<GoalMeasurement>
    {
        /// <summary>
        /// Initialize a new GoalMeasurementSingle object.
        /// </summary>
        public GoalMeasurementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new GoalMeasurementSingle object.
        /// </summary>
        public GoalMeasurementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new GoalMeasurementSingle object.
        /// </summary>
        public GoalMeasurementSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<GoalMeasurement> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Measurements in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Measurements")]
        public virtual global::Microsoft.Dynamics.DataEntities.GoalSingle Measurements
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Measurements == null))
                {
                    this._Measurements = new global::Microsoft.Dynamics.DataEntities.GoalSingle(this.Context, GetPath("Measurements"));
                }
                return this._Measurements;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.GoalSingle _Measurements;
        /// <summary>
        /// There are no comments for Goals in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Goals")]
        public virtual global::Microsoft.Dynamics.DataEntities.MeasurementSingle Goals
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Goals == null))
                {
                    this._Goals = new global::Microsoft.Dynamics.DataEntities.MeasurementSingle(this.Context, GetPath("Goals"));
                }
                return this._Goals;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.MeasurementSingle _Goals;
    }
    /// <summary>
    /// There are no comments for GoalMeasurement in the schema.
    /// </summary>
    /// <KeyProperties>
    /// GoalId
    /// GoalHeadingId
    /// PersonnelNumber
    /// MeasurementId
    /// SequenceNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("GoalId", "GoalHeadingId", "PersonnelNumber", "MeasurementId", "SequenceNumber")]
    [global::Microsoft.OData.Client.EntitySet("GoalMeasurements")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("GoalMeasurement")]
    public partial class GoalMeasurement : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new GoalMeasurement object.
        /// </summary>
        /// <param name="goalId">Initial value of GoalId.</param>
        /// <param name="goalHeadingId">Initial value of GoalHeadingId.</param>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="measurementId">Initial value of MeasurementId.</param>
        /// <param name="sequenceNumber">Initial value of SequenceNumber.</param>
        /// <param name="targetValue">Initial value of TargetValue.</param>
        /// <param name="targetPercent">Initial value of TargetPercent.</param>
        /// <param name="actualPercent">Initial value of ActualPercent.</param>
        /// <param name="targetDate">Initial value of TargetDate.</param>
        /// <param name="targetAmount">Initial value of TargetAmount.</param>
        /// <param name="actualAmount">Initial value of ActualAmount.</param>
        /// <param name="actualValue">Initial value of ActualValue.</param>
        /// <param name="actualDate">Initial value of ActualDate.</param>
        /// <param name="measurements">Initial value of Measurements.</param>
        /// <param name="goals">Initial value of Goals.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static GoalMeasurement CreateGoalMeasurement(string goalId, 
                    string goalHeadingId, 
                    string personnelNumber, 
                    string measurementId, 
                    int sequenceNumber, 
                    int targetValue, 
                    decimal targetPercent, 
                    decimal actualPercent, 
                    global::System.DateTimeOffset targetDate, 
                    decimal targetAmount, 
                    decimal actualAmount, 
                    int actualValue, 
                    global::System.DateTimeOffset actualDate, 
                    global::Microsoft.Dynamics.DataEntities.Goal measurements, 
                    global::Microsoft.Dynamics.DataEntities.Measurement goals)
        {
            GoalMeasurement goalMeasurement = new GoalMeasurement();
            goalMeasurement.GoalId = goalId;
            goalMeasurement.GoalHeadingId = goalHeadingId;
            goalMeasurement.PersonnelNumber = personnelNumber;
            goalMeasurement.MeasurementId = measurementId;
            goalMeasurement.SequenceNumber = sequenceNumber;
            goalMeasurement.TargetValue = targetValue;
            goalMeasurement.TargetPercent = targetPercent;
            goalMeasurement.ActualPercent = actualPercent;
            goalMeasurement.TargetDate = targetDate;
            goalMeasurement.TargetAmount = targetAmount;
            goalMeasurement.ActualAmount = actualAmount;
            goalMeasurement.ActualValue = actualValue;
            goalMeasurement.ActualDate = actualDate;
            if ((measurements == null))
            {
                throw new global::System.ArgumentNullException("measurements");
            }
            goalMeasurement.Measurements = measurements;
            if ((goals == null))
            {
                throw new global::System.ArgumentNullException("goals");
            }
            goalMeasurement.Goals = goals;
            return goalMeasurement;
        }
        /// <summary>
        /// There are no comments for Property GoalId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GoalId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GoalId is required.")]
        public virtual string GoalId
        {
            get
            {
                return this._GoalId;
            }
            set
            {
                this.OnGoalIdChanging(value);
                this._GoalId = value;
                this.OnGoalIdChanged();
                this.OnPropertyChanged("GoalId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GoalId;
        partial void OnGoalIdChanging(string value);
        partial void OnGoalIdChanged();
        /// <summary>
        /// There are no comments for Property GoalHeadingId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GoalHeadingId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GoalHeadingId is required.")]
        public virtual string GoalHeadingId
        {
            get
            {
                return this._GoalHeadingId;
            }
            set
            {
                this.OnGoalHeadingIdChanging(value);
                this._GoalHeadingId = value;
                this.OnGoalHeadingIdChanged();
                this.OnPropertyChanged("GoalHeadingId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GoalHeadingId;
        partial void OnGoalHeadingIdChanging(string value);
        partial void OnGoalHeadingIdChanged();
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonnelNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PersonnelNumber is required.")]
        public virtual string PersonnelNumber
        {
            get
            {
                return this._PersonnelNumber;
            }
            set
            {
                this.OnPersonnelNumberChanging(value);
                this._PersonnelNumber = value;
                this.OnPersonnelNumberChanged();
                this.OnPropertyChanged("PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelNumber;
        partial void OnPersonnelNumberChanging(string value);
        partial void OnPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property MeasurementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MeasurementId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MeasurementId is required.")]
        public virtual string MeasurementId
        {
            get
            {
                return this._MeasurementId;
            }
            set
            {
                this.OnMeasurementIdChanging(value);
                this._MeasurementId = value;
                this.OnMeasurementIdChanged();
                this.OnPropertyChanged("MeasurementId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MeasurementId;
        partial void OnMeasurementIdChanging(string value);
        partial void OnMeasurementIdChanged();
        /// <summary>
        /// There are no comments for Property SequenceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SequenceNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SequenceNumber is required.")]
        public virtual int SequenceNumber
        {
            get
            {
                return this._SequenceNumber;
            }
            set
            {
                this.OnSequenceNumberChanging(value);
                this._SequenceNumber = value;
                this.OnSequenceNumberChanged();
                this.OnPropertyChanged("SequenceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _SequenceNumber;
        partial void OnSequenceNumberChanging(int value);
        partial void OnSequenceNumberChanged();
        /// <summary>
        /// There are no comments for Property TargetValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TargetValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TargetValue is required.")]
        public virtual int TargetValue
        {
            get
            {
                return this._TargetValue;
            }
            set
            {
                this.OnTargetValueChanging(value);
                this._TargetValue = value;
                this.OnTargetValueChanged();
                this.OnPropertyChanged("TargetValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _TargetValue;
        partial void OnTargetValueChanging(int value);
        partial void OnTargetValueChanged();
        /// <summary>
        /// There are no comments for Property IsStretchGoal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsStretchGoal")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsStretchGoal
        {
            get
            {
                return this._IsStretchGoal;
            }
            set
            {
                this.OnIsStretchGoalChanging(value);
                this._IsStretchGoal = value;
                this.OnIsStretchGoalChanged();
                this.OnPropertyChanged("IsStretchGoal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsStretchGoal;
        partial void OnIsStretchGoalChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsStretchGoalChanged();
        /// <summary>
        /// There are no comments for Property TargetPercent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TargetPercent")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TargetPercent is required.")]
        public virtual decimal TargetPercent
        {
            get
            {
                return this._TargetPercent;
            }
            set
            {
                this.OnTargetPercentChanging(value);
                this._TargetPercent = value;
                this.OnTargetPercentChanged();
                this.OnPropertyChanged("TargetPercent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TargetPercent;
        partial void OnTargetPercentChanging(decimal value);
        partial void OnTargetPercentChanged();
        /// <summary>
        /// There are no comments for Property TargetRatingLevelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TargetRatingLevelId")]
        public virtual string TargetRatingLevelId
        {
            get
            {
                return this._TargetRatingLevelId;
            }
            set
            {
                this.OnTargetRatingLevelIdChanging(value);
                this._TargetRatingLevelId = value;
                this.OnTargetRatingLevelIdChanged();
                this.OnPropertyChanged("TargetRatingLevelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TargetRatingLevelId;
        partial void OnTargetRatingLevelIdChanging(string value);
        partial void OnTargetRatingLevelIdChanged();
        /// <summary>
        /// There are no comments for Property ActualPercent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActualPercent")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ActualPercent is required.")]
        public virtual decimal ActualPercent
        {
            get
            {
                return this._ActualPercent;
            }
            set
            {
                this.OnActualPercentChanging(value);
                this._ActualPercent = value;
                this.OnActualPercentChanged();
                this.OnPropertyChanged("ActualPercent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ActualPercent;
        partial void OnActualPercentChanging(decimal value);
        partial void OnActualPercentChanged();
        /// <summary>
        /// There are no comments for Property TargetDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TargetDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TargetDate is required.")]
        public virtual global::System.DateTimeOffset TargetDate
        {
            get
            {
                return this._TargetDate;
            }
            set
            {
                this.OnTargetDateChanging(value);
                this._TargetDate = value;
                this.OnTargetDateChanged();
                this.OnPropertyChanged("TargetDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _TargetDate;
        partial void OnTargetDateChanging(global::System.DateTimeOffset value);
        partial void OnTargetDateChanged();
        /// <summary>
        /// There are no comments for Property TargetAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TargetAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TargetAmount is required.")]
        public virtual decimal TargetAmount
        {
            get
            {
                return this._TargetAmount;
            }
            set
            {
                this.OnTargetAmountChanging(value);
                this._TargetAmount = value;
                this.OnTargetAmountChanged();
                this.OnPropertyChanged("TargetAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TargetAmount;
        partial void OnTargetAmountChanging(decimal value);
        partial void OnTargetAmountChanged();
        /// <summary>
        /// There are no comments for Property RatingModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RatingModelId")]
        public virtual string RatingModelId
        {
            get
            {
                return this._RatingModelId;
            }
            set
            {
                this.OnRatingModelIdChanging(value);
                this._RatingModelId = value;
                this.OnRatingModelIdChanged();
                this.OnPropertyChanged("RatingModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RatingModelId;
        partial void OnRatingModelIdChanging(string value);
        partial void OnRatingModelIdChanged();
        /// <summary>
        /// There are no comments for Property ActualAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActualAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ActualAmount is required.")]
        public virtual decimal ActualAmount
        {
            get
            {
                return this._ActualAmount;
            }
            set
            {
                this.OnActualAmountChanging(value);
                this._ActualAmount = value;
                this.OnActualAmountChanged();
                this.OnPropertyChanged("ActualAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ActualAmount;
        partial void OnActualAmountChanging(decimal value);
        partial void OnActualAmountChanged();
        /// <summary>
        /// There are no comments for Property ActualValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActualValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ActualValue is required.")]
        public virtual int ActualValue
        {
            get
            {
                return this._ActualValue;
            }
            set
            {
                this.OnActualValueChanging(value);
                this._ActualValue = value;
                this.OnActualValueChanged();
                this.OnPropertyChanged("ActualValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ActualValue;
        partial void OnActualValueChanging(int value);
        partial void OnActualValueChanged();
        /// <summary>
        /// There are no comments for Property MeasurementType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MeasurementType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmMeasurementType> MeasurementType
        {
            get
            {
                return this._MeasurementType;
            }
            set
            {
                this.OnMeasurementTypeChanging(value);
                this._MeasurementType = value;
                this.OnMeasurementTypeChanged();
                this.OnPropertyChanged("MeasurementType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmMeasurementType> _MeasurementType;
        partial void OnMeasurementTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmMeasurementType> value);
        partial void OnMeasurementTypeChanged();
        /// <summary>
        /// There are no comments for Property ActualDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActualDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ActualDate is required.")]
        public virtual global::System.DateTimeOffset ActualDate
        {
            get
            {
                return this._ActualDate;
            }
            set
            {
                this.OnActualDateChanging(value);
                this._ActualDate = value;
                this.OnActualDateChanged();
                this.OnPropertyChanged("ActualDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ActualDate;
        partial void OnActualDateChanging(global::System.DateTimeOffset value);
        partial void OnActualDateChanged();
        /// <summary>
        /// There are no comments for Property ActualRatingLevelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActualRatingLevelId")]
        public virtual string ActualRatingLevelId
        {
            get
            {
                return this._ActualRatingLevelId;
            }
            set
            {
                this.OnActualRatingLevelIdChanging(value);
                this._ActualRatingLevelId = value;
                this.OnActualRatingLevelIdChanged();
                this.OnPropertyChanged("ActualRatingLevelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActualRatingLevelId;
        partial void OnActualRatingLevelIdChanging(string value);
        partial void OnActualRatingLevelIdChanged();
        /// <summary>
        /// There are no comments for Property Measurements in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Measurements")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Measurements is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Goal Measurements
        {
            get
            {
                return this._Measurements;
            }
            set
            {
                this.OnMeasurementsChanging(value);
                this._Measurements = value;
                this.OnMeasurementsChanged();
                this.OnPropertyChanged("Measurements");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Goal _Measurements;
        partial void OnMeasurementsChanging(global::Microsoft.Dynamics.DataEntities.Goal value);
        partial void OnMeasurementsChanged();
        /// <summary>
        /// There are no comments for Property Goals in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Goals")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Goals is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Measurement Goals
        {
            get
            {
                return this._Goals;
            }
            set
            {
                this.OnGoalsChanging(value);
                this._Goals = value;
                this.OnGoalsChanged();
                this.OnPropertyChanged("Goals");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Measurement _Goals;
        partial void OnGoalsChanging(global::Microsoft.Dynamics.DataEntities.Measurement value);
        partial void OnGoalsChanged();
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