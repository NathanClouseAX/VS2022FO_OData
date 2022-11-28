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
    /// There are no comments for SequenceV2TableSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SequenceV2TableSingle")]
    public partial class SequenceV2TableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SequenceV2Table>
    {
        /// <summary>
        /// Initialize a new SequenceV2TableSingle object.
        /// </summary>
        public SequenceV2TableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SequenceV2TableSingle object.
        /// </summary>
        public SequenceV2TableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SequenceV2TableSingle object.
        /// </summary>
        public SequenceV2TableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SequenceV2Table> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SequenceV2Table in the schema.
    /// </summary>
    /// <KeyProperties>
    /// NumberSequenceCode
    /// ScopeType
    /// ScopeValue
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("NumberSequenceCode", "ScopeType", "ScopeValue")]
    [global::Microsoft.OData.Client.EntitySet("SequenceV2Tables")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SequenceV2Table")]
    public partial class SequenceV2Table : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SequenceV2Table object.
        /// </summary>
        /// <param name="numberSequenceCode">Initial value of NumberSequenceCode.</param>
        /// <param name="scopeValue">Initial value of ScopeValue.</param>
        /// <param name="quantityOfNumbers">Initial value of QuantityOfNumbers.</param>
        /// <param name="next">Initial value of Next.</param>
        /// <param name="interval">Initial value of Interval.</param>
        /// <param name="dateTime">Initial value of DateTime.</param>
        /// <param name="largest">Initial value of Largest.</param>
        /// <param name="smallest">Initial value of Smallest.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SequenceV2Table CreateSequenceV2Table(string numberSequenceCode, 
                    string scopeValue, 
                    int quantityOfNumbers, 
                    int next, 
                    decimal interval, 
                    global::System.DateTimeOffset dateTime, 
                    int largest, 
                    int smallest)
        {
            SequenceV2Table sequenceV2Table = new SequenceV2Table();
            sequenceV2Table.NumberSequenceCode = numberSequenceCode;
            sequenceV2Table.ScopeValue = scopeValue;
            sequenceV2Table.QuantityOfNumbers = quantityOfNumbers;
            sequenceV2Table.Next = next;
            sequenceV2Table.Interval = interval;
            sequenceV2Table.DateTime = dateTime;
            sequenceV2Table.Largest = largest;
            sequenceV2Table.Smallest = smallest;
            return sequenceV2Table;
        }
        /// <summary>
        /// There are no comments for Property NumberSequenceCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NumberSequenceCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NumberSequenceCode is required.")]
        public virtual string NumberSequenceCode
        {
            get
            {
                return this._NumberSequenceCode;
            }
            set
            {
                this.OnNumberSequenceCodeChanging(value);
                this._NumberSequenceCode = value;
                this.OnNumberSequenceCodeChanged();
                this.OnPropertyChanged("NumberSequenceCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NumberSequenceCode;
        partial void OnNumberSequenceCodeChanging(string value);
        partial void OnNumberSequenceCodeChanged();
        /// <summary>
        /// There are no comments for Property ScopeType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ScopeType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NumberSequenceType> ScopeType
        {
            get
            {
                return this._ScopeType;
            }
            set
            {
                this.OnScopeTypeChanging(value);
                this._ScopeType = value;
                this.OnScopeTypeChanged();
                this.OnPropertyChanged("ScopeType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NumberSequenceType> _ScopeType;
        partial void OnScopeTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NumberSequenceType> value);
        partial void OnScopeTypeChanged();
        /// <summary>
        /// There are no comments for Property ScopeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ScopeValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ScopeValue is required.")]
        public virtual string ScopeValue
        {
            get
            {
                return this._ScopeValue;
            }
            set
            {
                this.OnScopeValueChanging(value);
                this._ScopeValue = value;
                this.OnScopeValueChanged();
                this.OnPropertyChanged("ScopeValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ScopeValue;
        partial void OnScopeValueChanging(string value);
        partial void OnScopeValueChanged();
        /// <summary>
        /// There are no comments for Property QuantityOfNumbers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QuantityOfNumbers")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QuantityOfNumbers is required.")]
        public virtual int QuantityOfNumbers
        {
            get
            {
                return this._QuantityOfNumbers;
            }
            set
            {
                this.OnQuantityOfNumbersChanging(value);
                this._QuantityOfNumbers = value;
                this.OnQuantityOfNumbersChanged();
                this.OnPropertyChanged("QuantityOfNumbers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _QuantityOfNumbers;
        partial void OnQuantityOfNumbersChanging(int value);
        partial void OnQuantityOfNumbersChanged();
        /// <summary>
        /// There are no comments for Property ToAHigherNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ToAHigherNumber")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ToAHigherNumber
        {
            get
            {
                return this._ToAHigherNumber;
            }
            set
            {
                this.OnToAHigherNumberChanging(value);
                this._ToAHigherNumber = value;
                this.OnToAHigherNumberChanged();
                this.OnPropertyChanged("ToAHigherNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ToAHigherNumber;
        partial void OnToAHigherNumberChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnToAHigherNumberChanged();
        /// <summary>
        /// There are no comments for Property Next in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Next")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Next is required.")]
        public virtual int Next
        {
            get
            {
                return this._Next;
            }
            set
            {
                this.OnNextChanging(value);
                this._Next = value;
                this.OnNextChanged();
                this.OnPropertyChanged("Next");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Next;
        partial void OnNextChanging(int value);
        partial void OnNextChanged();
        /// <summary>
        /// There are no comments for Property Continuous in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Continuous")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Continuous
        {
            get
            {
                return this._Continuous;
            }
            set
            {
                this.OnContinuousChanging(value);
                this._Continuous = value;
                this.OnContinuousChanged();
                this.OnPropertyChanged("Continuous");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Continuous;
        partial void OnContinuousChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnContinuousChanged();
        /// <summary>
        /// There are no comments for Property Preallocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Preallocation")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Preallocation
        {
            get
            {
                return this._Preallocation;
            }
            set
            {
                this.OnPreallocationChanging(value);
                this._Preallocation = value;
                this.OnPreallocationChanged();
                this.OnPropertyChanged("Preallocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Preallocation;
        partial void OnPreallocationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPreallocationChanged();
        /// <summary>
        /// There are no comments for Property Interval in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Interval")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Interval is required.")]
        public virtual decimal Interval
        {
            get
            {
                return this._Interval;
            }
            set
            {
                this.OnIntervalChanging(value);
                this._Interval = value;
                this.OnIntervalChanged();
                this.OnPropertyChanged("Interval");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Interval;
        partial void OnIntervalChanging(decimal value);
        partial void OnIntervalChanged();
        /// <summary>
        /// There are no comments for Property OperatingUnitTypes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OperatingUnitTypes")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OMOperatingUnitType> OperatingUnitTypes
        {
            get
            {
                return this._OperatingUnitTypes;
            }
            set
            {
                this.OnOperatingUnitTypesChanging(value);
                this._OperatingUnitTypes = value;
                this.OnOperatingUnitTypesChanged();
                this.OnPropertyChanged("OperatingUnitTypes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OMOperatingUnitType> _OperatingUnitTypes;
        partial void OnOperatingUnitTypesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OMOperatingUnitType> value);
        partial void OnOperatingUnitTypesChanged();
        /// <summary>
        /// There are no comments for Property SkipCounting in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SkipCounting")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> SkipCounting
        {
            get
            {
                return this._SkipCounting;
            }
            set
            {
                this.OnSkipCountingChanging(value);
                this._SkipCounting = value;
                this.OnSkipCountingChanged();
                this.OnPropertyChanged("SkipCounting");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _SkipCounting;
        partial void OnSkipCountingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnSkipCountingChanged();
        /// <summary>
        /// There are no comments for Property Company in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Company")]
        public virtual string Company
        {
            get
            {
                return this._Company;
            }
            set
            {
                this.OnCompanyChanging(value);
                this._Company = value;
                this.OnCompanyChanged();
                this.OnPropertyChanged("Company");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Company;
        partial void OnCompanyChanging(string value);
        partial void OnCompanyChanged();
        /// <summary>
        /// There are no comments for Property AnnotatedFormat in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AnnotatedFormat")]
        public virtual string AnnotatedFormat
        {
            get
            {
                return this._AnnotatedFormat;
            }
            set
            {
                this.OnAnnotatedFormatChanging(value);
                this._AnnotatedFormat = value;
                this.OnAnnotatedFormatChanged();
                this.OnPropertyChanged("AnnotatedFormat");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AnnotatedFormat;
        partial void OnAnnotatedFormatChanging(string value);
        partial void OnAnnotatedFormatChanged();
        /// <summary>
        /// There are no comments for Property CleanUp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CleanUp")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CleanUp
        {
            get
            {
                return this._CleanUp;
            }
            set
            {
                this.OnCleanUpChanging(value);
                this._CleanUp = value;
                this.OnCleanUpChanged();
                this.OnPropertyChanged("CleanUp");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CleanUp;
        partial void OnCleanUpChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCleanUpChanged();
        /// <summary>
        /// There are no comments for Property DateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DateTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DateTime is required.")]
        public virtual global::System.DateTimeOffset DateTime
        {
            get
            {
                return this._DateTime;
            }
            set
            {
                this.OnDateTimeChanging(value);
                this._DateTime = value;
                this.OnDateTimeChanged();
                this.OnPropertyChanged("DateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DateTime;
        partial void OnDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnDateTimeChanged();
        /// <summary>
        /// There are no comments for Property Manual in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Manual")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Manual
        {
            get
            {
                return this._Manual;
            }
            set
            {
                this.OnManualChanging(value);
                this._Manual = value;
                this.OnManualChanged();
                this.OnPropertyChanged("Manual");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Manual;
        partial void OnManualChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnManualChanged();
        /// <summary>
        /// There are no comments for Property Cyclical in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Cyclical")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Cyclical
        {
            get
            {
                return this._Cyclical;
            }
            set
            {
                this.OnCyclicalChanging(value);
                this._Cyclical = value;
                this.OnCyclicalChanged();
                this.OnPropertyChanged("Cyclical");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Cyclical;
        partial void OnCyclicalChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCyclicalChanged();
        /// <summary>
        /// There are no comments for Property Format in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Format")]
        public virtual string Format
        {
            get
            {
                return this._Format;
            }
            set
            {
                this.OnFormatChanging(value);
                this._Format = value;
                this.OnFormatChanged();
                this.OnPropertyChanged("Format");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Format;
        partial void OnFormatChanging(string value);
        partial void OnFormatChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Largest in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Largest")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Largest is required.")]
        public virtual int Largest
        {
            get
            {
                return this._Largest;
            }
            set
            {
                this.OnLargestChanging(value);
                this._Largest = value;
                this.OnLargestChanged();
                this.OnPropertyChanged("Largest");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Largest;
        partial void OnLargestChanging(int value);
        partial void OnLargestChanged();
        /// <summary>
        /// There are no comments for Property InUse in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InUse")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> InUse
        {
            get
            {
                return this._InUse;
            }
            set
            {
                this.OnInUseChanging(value);
                this._InUse = value;
                this.OnInUseChanged();
                this.OnPropertyChanged("InUse");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _InUse;
        partial void OnInUseChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnInUseChanged();
        /// <summary>
        /// There are no comments for Property Stopped in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Stopped")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Stopped
        {
            get
            {
                return this._Stopped;
            }
            set
            {
                this.OnStoppedChanging(value);
                this._Stopped = value;
                this.OnStoppedChanged();
                this.OnPropertyChanged("Stopped");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Stopped;
        partial void OnStoppedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnStoppedChanged();
        /// <summary>
        /// There are no comments for Property Smallest in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Smallest")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Smallest is required.")]
        public virtual int Smallest
        {
            get
            {
                return this._Smallest;
            }
            set
            {
                this.OnSmallestChanging(value);
                this._Smallest = value;
                this.OnSmallestChanged();
                this.OnPropertyChanged("Smallest");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Smallest;
        partial void OnSmallestChanging(int value);
        partial void OnSmallestChanged();
        /// <summary>
        /// There are no comments for Property ToALowerNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ToALowerNumber")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ToALowerNumber
        {
            get
            {
                return this._ToALowerNumber;
            }
            set
            {
                this.OnToALowerNumberChanging(value);
                this._ToALowerNumber = value;
                this.OnToALowerNumberChanged();
                this.OnPropertyChanged("ToALowerNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ToALowerNumber;
        partial void OnToALowerNumberChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnToALowerNumberChanged();
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
