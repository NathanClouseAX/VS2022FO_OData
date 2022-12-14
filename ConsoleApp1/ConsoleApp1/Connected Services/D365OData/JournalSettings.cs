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
    /// There are no comments for JournalSettingsSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("JournalSettingsSingle")]
    public partial class JournalSettingsSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<JournalSettings>
    {
        /// <summary>
        /// Initialize a new JournalSettingsSingle object.
        /// </summary>
        public JournalSettingsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new JournalSettingsSingle object.
        /// </summary>
        public JournalSettingsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new JournalSettingsSingle object.
        /// </summary>
        public JournalSettingsSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<JournalSettings> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for JournalSettings in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LineId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LineId")]
    [global::Microsoft.OData.Client.EntitySet("JournalSettings")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("JournalSettings")]
    public partial class JournalSettings : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new JournalSettings object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="lineId">Initial value of LineId.</param>
        /// <param name="minimumNumberOfDays">Initial value of MinimumNumberOfDays.</param>
        /// <param name="maximumNumberOfDays">Initial value of MaximumNumberOfDays.</param>
        /// <param name="paymTermDays">Initial value of PaymTermDays.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static JournalSettings CreateJournalSettings(string dataAreaId, global::System.Guid lineId, int minimumNumberOfDays, int maximumNumberOfDays, int paymTermDays)
        {
            JournalSettings journalSettings = new JournalSettings();
            journalSettings.DataAreaId = dataAreaId;
            journalSettings.LineId = lineId;
            journalSettings.MinimumNumberOfDays = minimumNumberOfDays;
            journalSettings.MaximumNumberOfDays = maximumNumberOfDays;
            journalSettings.PaymTermDays = paymTermDays;
            return journalSettings;
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
        /// There are no comments for Property LineId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineId is required.")]
        public virtual global::System.Guid LineId
        {
            get
            {
                return this._LineId;
            }
            set
            {
                this.OnLineIdChanging(value);
                this._LineId = value;
                this.OnLineIdChanged();
                this.OnPropertyChanged("LineId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _LineId;
        partial void OnLineIdChanging(global::System.Guid value);
        partial void OnLineIdChanged();
        /// <summary>
        /// There are no comments for Property MinimumNumberOfDays in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MinimumNumberOfDays")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MinimumNumberOfDays is required.")]
        public virtual int MinimumNumberOfDays
        {
            get
            {
                return this._MinimumNumberOfDays;
            }
            set
            {
                this.OnMinimumNumberOfDaysChanging(value);
                this._MinimumNumberOfDays = value;
                this.OnMinimumNumberOfDaysChanged();
                this.OnPropertyChanged("MinimumNumberOfDays");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _MinimumNumberOfDays;
        partial void OnMinimumNumberOfDaysChanging(int value);
        partial void OnMinimumNumberOfDaysChanged();
        /// <summary>
        /// There are no comments for Property JournalType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OverdueJournalType_W> JournalType
        {
            get
            {
                return this._JournalType;
            }
            set
            {
                this.OnJournalTypeChanging(value);
                this._JournalType = value;
                this.OnJournalTypeChanged();
                this.OnPropertyChanged("JournalType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OverdueJournalType_W> _JournalType;
        partial void OnJournalTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OverdueJournalType_W> value);
        partial void OnJournalTypeChanged();
        /// <summary>
        /// There are no comments for Property MaximumNumberOfDays in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaximumNumberOfDays")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaximumNumberOfDays is required.")]
        public virtual int MaximumNumberOfDays
        {
            get
            {
                return this._MaximumNumberOfDays;
            }
            set
            {
                this.OnMaximumNumberOfDaysChanging(value);
                this._MaximumNumberOfDays = value;
                this.OnMaximumNumberOfDaysChanged();
                this.OnPropertyChanged("MaximumNumberOfDays");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _MaximumNumberOfDays;
        partial void OnMaximumNumberOfDaysChanging(int value);
        partial void OnMaximumNumberOfDaysChanged();
        /// <summary>
        /// There are no comments for Property PaymTermDays in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymTermDays")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PaymTermDays is required.")]
        public virtual int PaymTermDays
        {
            get
            {
                return this._PaymTermDays;
            }
            set
            {
                this.OnPaymTermDaysChanging(value);
                this._PaymTermDays = value;
                this.OnPaymTermDaysChanged();
                this.OnPropertyChanged("PaymTermDays");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PaymTermDays;
        partial void OnPaymTermDaysChanging(int value);
        partial void OnPaymTermDaysChanged();
        /// <summary>
        /// There are no comments for Property Condition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Condition")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ComparisonCondition_W> Condition
        {
            get
            {
                return this._Condition;
            }
            set
            {
                this.OnConditionChanging(value);
                this._Condition = value;
                this.OnConditionChanged();
                this.OnPropertyChanged("Condition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ComparisonCondition_W> _Condition;
        partial void OnConditionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ComparisonCondition_W> value);
        partial void OnConditionChanged();
        /// <summary>
        /// There are no comments for Property IsValidateEnabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsValidateEnabled")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsValidateEnabled
        {
            get
            {
                return this._IsValidateEnabled;
            }
            set
            {
                this.OnIsValidateEnabledChanging(value);
                this._IsValidateEnabled = value;
                this.OnIsValidateEnabledChanged();
                this.OnPropertyChanged("IsValidateEnabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsValidateEnabled;
        partial void OnIsValidateEnabledChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsValidateEnabledChanged();
        /// <summary>
        /// There are no comments for Property CalculationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CalculationType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OverdueCalcType_W> CalculationType
        {
            get
            {
                return this._CalculationType;
            }
            set
            {
                this.OnCalculationTypeChanging(value);
                this._CalculationType = value;
                this.OnCalculationTypeChanged();
                this.OnPropertyChanged("CalculationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OverdueCalcType_W> _CalculationType;
        partial void OnCalculationTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OverdueCalcType_W> value);
        partial void OnCalculationTypeChanged();
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
