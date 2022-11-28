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
    /// There are no comments for RetailWorkShiftSetup2Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailWorkShiftSetup2Single")]
    public partial class RetailWorkShiftSetup2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailWorkShiftSetup2>
    {
        /// <summary>
        /// Initialize a new RetailWorkShiftSetup2Single object.
        /// </summary>
        public RetailWorkShiftSetup2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailWorkShiftSetup2Single object.
        /// </summary>
        public RetailWorkShiftSetup2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailWorkShiftSetup2Single object.
        /// </summary>
        public RetailWorkShiftSetup2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailWorkShiftSetup2> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailWorkShiftSetup2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// WorkShiftId
    /// StoreNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "WorkShiftId", "StoreNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailWorkShiftSetups2")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailWorkShiftSetup2")]
    public partial class RetailWorkShiftSetup2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailWorkShiftSetup2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="workShiftId">Initial value of WorkShiftId.</param>
        /// <param name="storeNumber">Initial value of StoreNumber.</param>
        /// <param name="startTime">Initial value of StartTime.</param>
        /// <param name="endingTime">Initial value of EndingTime.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailWorkShiftSetup2 CreateRetailWorkShiftSetup2(string dataAreaId, string workShiftId, string storeNumber, int startTime, int endingTime)
        {
            RetailWorkShiftSetup2 retailWorkShiftSetup2 = new RetailWorkShiftSetup2();
            retailWorkShiftSetup2.DataAreaId = dataAreaId;
            retailWorkShiftSetup2.WorkShiftId = workShiftId;
            retailWorkShiftSetup2.StoreNumber = storeNumber;
            retailWorkShiftSetup2.StartTime = startTime;
            retailWorkShiftSetup2.EndingTime = endingTime;
            return retailWorkShiftSetup2;
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
        /// There are no comments for Property WorkShiftId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkShiftId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WorkShiftId is required.")]
        public virtual string WorkShiftId
        {
            get
            {
                return this._WorkShiftId;
            }
            set
            {
                this.OnWorkShiftIdChanging(value);
                this._WorkShiftId = value;
                this.OnWorkShiftIdChanged();
                this.OnPropertyChanged("WorkShiftId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkShiftId;
        partial void OnWorkShiftIdChanging(string value);
        partial void OnWorkShiftIdChanged();
        /// <summary>
        /// There are no comments for Property StoreNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StoreNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StoreNumber is required.")]
        public virtual string StoreNumber
        {
            get
            {
                return this._StoreNumber;
            }
            set
            {
                this.OnStoreNumberChanging(value);
                this._StoreNumber = value;
                this.OnStoreNumberChanged();
                this.OnPropertyChanged("StoreNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StoreNumber;
        partial void OnStoreNumberChanging(string value);
        partial void OnStoreNumberChanged();
        /// <summary>
        /// There are no comments for Property StartTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StartTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StartTime is required.")]
        public virtual int StartTime
        {
            get
            {
                return this._StartTime;
            }
            set
            {
                this.OnStartTimeChanging(value);
                this._StartTime = value;
                this.OnStartTimeChanged();
                this.OnPropertyChanged("StartTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _StartTime;
        partial void OnStartTimeChanging(int value);
        partial void OnStartTimeChanged();
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
        /// There are no comments for Property AbbreviationText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AbbreviationText")]
        public virtual string AbbreviationText
        {
            get
            {
                return this._AbbreviationText;
            }
            set
            {
                this.OnAbbreviationTextChanging(value);
                this._AbbreviationText = value;
                this.OnAbbreviationTextChanged();
                this.OnPropertyChanged("AbbreviationText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AbbreviationText;
        partial void OnAbbreviationTextChanging(string value);
        partial void OnAbbreviationTextChanged();
        /// <summary>
        /// There are no comments for Property Abbreviation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Abbreviation")]
        public virtual string Abbreviation
        {
            get
            {
                return this._Abbreviation;
            }
            set
            {
                this.OnAbbreviationChanging(value);
                this._Abbreviation = value;
                this.OnAbbreviationChanged();
                this.OnPropertyChanged("Abbreviation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Abbreviation;
        partial void OnAbbreviationChanging(string value);
        partial void OnAbbreviationChanged();
        /// <summary>
        /// There are no comments for Property DateReference in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DateReference")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailEndTimeStartTime> DateReference
        {
            get
            {
                return this._DateReference;
            }
            set
            {
                this.OnDateReferenceChanging(value);
                this._DateReference = value;
                this.OnDateReferenceChanged();
                this.OnPropertyChanged("DateReference");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailEndTimeStartTime> _DateReference;
        partial void OnDateReferenceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailEndTimeStartTime> value);
        partial void OnDateReferenceChanged();
        /// <summary>
        /// There are no comments for Property EndingTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EndingTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EndingTime is required.")]
        public virtual int EndingTime
        {
            get
            {
                return this._EndingTime;
            }
            set
            {
                this.OnEndingTimeChanging(value);
                this._EndingTime = value;
                this.OnEndingTimeChanged();
                this.OnPropertyChanged("EndingTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _EndingTime;
        partial void OnEndingTimeChanging(int value);
        partial void OnEndingTimeChanged();
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
