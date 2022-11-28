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
    /// There are no comments for PSNCashPositionColumnSetupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PSNCashPositionColumnSetupSingle")]
    public partial class PSNCashPositionColumnSetupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PSNCashPositionColumnSetup>
    {
        /// <summary>
        /// Initialize a new PSNCashPositionColumnSetupSingle object.
        /// </summary>
        public PSNCashPositionColumnSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PSNCashPositionColumnSetupSingle object.
        /// </summary>
        public PSNCashPositionColumnSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PSNCashPositionColumnSetupSingle object.
        /// </summary>
        public PSNCashPositionColumnSetupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PSNCashPositionColumnSetup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PSNCashPositionColumnSetup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Key
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Key")]
    [global::Microsoft.OData.Client.EntitySet("PSNCashPositionColumnSetup")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PSNCashPositionColumnSetup")]
    public partial class PSNCashPositionColumnSetup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PSNCashPositionColumnSetup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="key">Initial value of Key.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PSNCashPositionColumnSetup CreatePSNCashPositionColumnSetup(string dataAreaId, int key)
        {
            PSNCashPositionColumnSetup pSNCashPositionColumnSetup = new PSNCashPositionColumnSetup();
            pSNCashPositionColumnSetup.DataAreaId = dataAreaId;
            pSNCashPositionColumnSetup.Key = key;
            return pSNCashPositionColumnSetup;
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
        /// There are no comments for Property Key in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Key")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Key is required.")]
        public virtual int Key
        {
            get
            {
                return this._Key;
            }
            set
            {
                this.OnKeyChanging(value);
                this._Key = value;
                this.OnKeyChanged();
                this.OnPropertyChanged("Key");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Key;
        partial void OnKeyChanging(int value);
        partial void OnKeyChanged();
        /// <summary>
        /// There are no comments for Property ColumnSevenRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnSevenRange")]
        public virtual string ColumnSevenRange
        {
            get
            {
                return this._ColumnSevenRange;
            }
            set
            {
                this.OnColumnSevenRangeChanging(value);
                this._ColumnSevenRange = value;
                this.OnColumnSevenRangeChanged();
                this.OnPropertyChanged("ColumnSevenRange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnSevenRange;
        partial void OnColumnSevenRangeChanging(string value);
        partial void OnColumnSevenRangeChanged();
        /// <summary>
        /// There are no comments for Property ColumnFourRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnFourRange")]
        public virtual string ColumnFourRange
        {
            get
            {
                return this._ColumnFourRange;
            }
            set
            {
                this.OnColumnFourRangeChanging(value);
                this._ColumnFourRange = value;
                this.OnColumnFourRangeChanged();
                this.OnPropertyChanged("ColumnFourRange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnFourRange;
        partial void OnColumnFourRangeChanging(string value);
        partial void OnColumnFourRangeChanged();
        /// <summary>
        /// There are no comments for Property ColumnEightLabel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnEightLabel")]
        public virtual string ColumnEightLabel
        {
            get
            {
                return this._ColumnEightLabel;
            }
            set
            {
                this.OnColumnEightLabelChanging(value);
                this._ColumnEightLabel = value;
                this.OnColumnEightLabelChanged();
                this.OnPropertyChanged("ColumnEightLabel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnEightLabel;
        partial void OnColumnEightLabelChanging(string value);
        partial void OnColumnEightLabelChanged();
        /// <summary>
        /// There are no comments for Property ColumnOneLabel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnOneLabel")]
        public virtual string ColumnOneLabel
        {
            get
            {
                return this._ColumnOneLabel;
            }
            set
            {
                this.OnColumnOneLabelChanging(value);
                this._ColumnOneLabel = value;
                this.OnColumnOneLabelChanged();
                this.OnPropertyChanged("ColumnOneLabel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnOneLabel;
        partial void OnColumnOneLabelChanging(string value);
        partial void OnColumnOneLabelChanged();
        /// <summary>
        /// There are no comments for Property ColumnSixRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnSixRange")]
        public virtual string ColumnSixRange
        {
            get
            {
                return this._ColumnSixRange;
            }
            set
            {
                this.OnColumnSixRangeChanging(value);
                this._ColumnSixRange = value;
                this.OnColumnSixRangeChanged();
                this.OnPropertyChanged("ColumnSixRange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnSixRange;
        partial void OnColumnSixRangeChanging(string value);
        partial void OnColumnSixRangeChanged();
        /// <summary>
        /// There are no comments for Property ColumnSixLabel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnSixLabel")]
        public virtual string ColumnSixLabel
        {
            get
            {
                return this._ColumnSixLabel;
            }
            set
            {
                this.OnColumnSixLabelChanging(value);
                this._ColumnSixLabel = value;
                this.OnColumnSixLabelChanged();
                this.OnPropertyChanged("ColumnSixLabel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnSixLabel;
        partial void OnColumnSixLabelChanging(string value);
        partial void OnColumnSixLabelChanged();
        /// <summary>
        /// There are no comments for Property ColumnFiveLabel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnFiveLabel")]
        public virtual string ColumnFiveLabel
        {
            get
            {
                return this._ColumnFiveLabel;
            }
            set
            {
                this.OnColumnFiveLabelChanging(value);
                this._ColumnFiveLabel = value;
                this.OnColumnFiveLabelChanged();
                this.OnPropertyChanged("ColumnFiveLabel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnFiveLabel;
        partial void OnColumnFiveLabelChanging(string value);
        partial void OnColumnFiveLabelChanged();
        /// <summary>
        /// There are no comments for Property ColumnTwoCreditRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnTwoCreditRange")]
        public virtual string ColumnTwoCreditRange
        {
            get
            {
                return this._ColumnTwoCreditRange;
            }
            set
            {
                this.OnColumnTwoCreditRangeChanging(value);
                this._ColumnTwoCreditRange = value;
                this.OnColumnTwoCreditRangeChanged();
                this.OnPropertyChanged("ColumnTwoCreditRange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnTwoCreditRange;
        partial void OnColumnTwoCreditRangeChanging(string value);
        partial void OnColumnTwoCreditRangeChanged();
        /// <summary>
        /// There are no comments for Property ColumnFourCreditRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnFourCreditRange")]
        public virtual string ColumnFourCreditRange
        {
            get
            {
                return this._ColumnFourCreditRange;
            }
            set
            {
                this.OnColumnFourCreditRangeChanging(value);
                this._ColumnFourCreditRange = value;
                this.OnColumnFourCreditRangeChanged();
                this.OnPropertyChanged("ColumnFourCreditRange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnFourCreditRange;
        partial void OnColumnFourCreditRangeChanging(string value);
        partial void OnColumnFourCreditRangeChanged();
        /// <summary>
        /// There are no comments for Property ColumnSixDebitRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnSixDebitRange")]
        public virtual string ColumnSixDebitRange
        {
            get
            {
                return this._ColumnSixDebitRange;
            }
            set
            {
                this.OnColumnSixDebitRangeChanging(value);
                this._ColumnSixDebitRange = value;
                this.OnColumnSixDebitRangeChanged();
                this.OnPropertyChanged("ColumnSixDebitRange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnSixDebitRange;
        partial void OnColumnSixDebitRangeChanging(string value);
        partial void OnColumnSixDebitRangeChanged();
        /// <summary>
        /// There are no comments for Property ColumnOneRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnOneRange")]
        public virtual string ColumnOneRange
        {
            get
            {
                return this._ColumnOneRange;
            }
            set
            {
                this.OnColumnOneRangeChanging(value);
                this._ColumnOneRange = value;
                this.OnColumnOneRangeChanged();
                this.OnPropertyChanged("ColumnOneRange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnOneRange;
        partial void OnColumnOneRangeChanging(string value);
        partial void OnColumnOneRangeChanged();
        /// <summary>
        /// There are no comments for Property ColumnThreeDebitRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnThreeDebitRange")]
        public virtual string ColumnThreeDebitRange
        {
            get
            {
                return this._ColumnThreeDebitRange;
            }
            set
            {
                this.OnColumnThreeDebitRangeChanging(value);
                this._ColumnThreeDebitRange = value;
                this.OnColumnThreeDebitRangeChanged();
                this.OnPropertyChanged("ColumnThreeDebitRange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnThreeDebitRange;
        partial void OnColumnThreeDebitRangeChanging(string value);
        partial void OnColumnThreeDebitRangeChanged();
        /// <summary>
        /// There are no comments for Property ColumnFourDebitRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnFourDebitRange")]
        public virtual string ColumnFourDebitRange
        {
            get
            {
                return this._ColumnFourDebitRange;
            }
            set
            {
                this.OnColumnFourDebitRangeChanging(value);
                this._ColumnFourDebitRange = value;
                this.OnColumnFourDebitRangeChanged();
                this.OnPropertyChanged("ColumnFourDebitRange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnFourDebitRange;
        partial void OnColumnFourDebitRangeChanging(string value);
        partial void OnColumnFourDebitRangeChanged();
        /// <summary>
        /// There are no comments for Property ColumnTwoDebitRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnTwoDebitRange")]
        public virtual string ColumnTwoDebitRange
        {
            get
            {
                return this._ColumnTwoDebitRange;
            }
            set
            {
                this.OnColumnTwoDebitRangeChanging(value);
                this._ColumnTwoDebitRange = value;
                this.OnColumnTwoDebitRangeChanged();
                this.OnPropertyChanged("ColumnTwoDebitRange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnTwoDebitRange;
        partial void OnColumnTwoDebitRangeChanging(string value);
        partial void OnColumnTwoDebitRangeChanged();
        /// <summary>
        /// There are no comments for Property ColumnSevenLabel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnSevenLabel")]
        public virtual string ColumnSevenLabel
        {
            get
            {
                return this._ColumnSevenLabel;
            }
            set
            {
                this.OnColumnSevenLabelChanging(value);
                this._ColumnSevenLabel = value;
                this.OnColumnSevenLabelChanged();
                this.OnPropertyChanged("ColumnSevenLabel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnSevenLabel;
        partial void OnColumnSevenLabelChanging(string value);
        partial void OnColumnSevenLabelChanged();
        /// <summary>
        /// There are no comments for Property ColumnThreeLabel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnThreeLabel")]
        public virtual string ColumnThreeLabel
        {
            get
            {
                return this._ColumnThreeLabel;
            }
            set
            {
                this.OnColumnThreeLabelChanging(value);
                this._ColumnThreeLabel = value;
                this.OnColumnThreeLabelChanged();
                this.OnPropertyChanged("ColumnThreeLabel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnThreeLabel;
        partial void OnColumnThreeLabelChanging(string value);
        partial void OnColumnThreeLabelChanged();
        /// <summary>
        /// There are no comments for Property ColumnSevenCreditRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnSevenCreditRange")]
        public virtual string ColumnSevenCreditRange
        {
            get
            {
                return this._ColumnSevenCreditRange;
            }
            set
            {
                this.OnColumnSevenCreditRangeChanging(value);
                this._ColumnSevenCreditRange = value;
                this.OnColumnSevenCreditRangeChanged();
                this.OnPropertyChanged("ColumnSevenCreditRange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnSevenCreditRange;
        partial void OnColumnSevenCreditRangeChanging(string value);
        partial void OnColumnSevenCreditRangeChanged();
        /// <summary>
        /// There are no comments for Property ColumnThreeCreditRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnThreeCreditRange")]
        public virtual string ColumnThreeCreditRange
        {
            get
            {
                return this._ColumnThreeCreditRange;
            }
            set
            {
                this.OnColumnThreeCreditRangeChanging(value);
                this._ColumnThreeCreditRange = value;
                this.OnColumnThreeCreditRangeChanged();
                this.OnPropertyChanged("ColumnThreeCreditRange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnThreeCreditRange;
        partial void OnColumnThreeCreditRangeChanging(string value);
        partial void OnColumnThreeCreditRangeChanged();
        /// <summary>
        /// There are no comments for Property ColumnTwoLabel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnTwoLabel")]
        public virtual string ColumnTwoLabel
        {
            get
            {
                return this._ColumnTwoLabel;
            }
            set
            {
                this.OnColumnTwoLabelChanging(value);
                this._ColumnTwoLabel = value;
                this.OnColumnTwoLabelChanged();
                this.OnPropertyChanged("ColumnTwoLabel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnTwoLabel;
        partial void OnColumnTwoLabelChanging(string value);
        partial void OnColumnTwoLabelChanged();
        /// <summary>
        /// There are no comments for Property ColumnTwoRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnTwoRange")]
        public virtual string ColumnTwoRange
        {
            get
            {
                return this._ColumnTwoRange;
            }
            set
            {
                this.OnColumnTwoRangeChanging(value);
                this._ColumnTwoRange = value;
                this.OnColumnTwoRangeChanged();
                this.OnPropertyChanged("ColumnTwoRange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnTwoRange;
        partial void OnColumnTwoRangeChanging(string value);
        partial void OnColumnTwoRangeChanged();
        /// <summary>
        /// There are no comments for Property ColumnSevenDebitRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnSevenDebitRange")]
        public virtual string ColumnSevenDebitRange
        {
            get
            {
                return this._ColumnSevenDebitRange;
            }
            set
            {
                this.OnColumnSevenDebitRangeChanging(value);
                this._ColumnSevenDebitRange = value;
                this.OnColumnSevenDebitRangeChanged();
                this.OnPropertyChanged("ColumnSevenDebitRange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnSevenDebitRange;
        partial void OnColumnSevenDebitRangeChanging(string value);
        partial void OnColumnSevenDebitRangeChanged();
        /// <summary>
        /// There are no comments for Property ColumnSixCreditRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnSixCreditRange")]
        public virtual string ColumnSixCreditRange
        {
            get
            {
                return this._ColumnSixCreditRange;
            }
            set
            {
                this.OnColumnSixCreditRangeChanging(value);
                this._ColumnSixCreditRange = value;
                this.OnColumnSixCreditRangeChanged();
                this.OnPropertyChanged("ColumnSixCreditRange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnSixCreditRange;
        partial void OnColumnSixCreditRangeChanging(string value);
        partial void OnColumnSixCreditRangeChanged();
        /// <summary>
        /// There are no comments for Property ColumnFourLabel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnFourLabel")]
        public virtual string ColumnFourLabel
        {
            get
            {
                return this._ColumnFourLabel;
            }
            set
            {
                this.OnColumnFourLabelChanging(value);
                this._ColumnFourLabel = value;
                this.OnColumnFourLabelChanged();
                this.OnPropertyChanged("ColumnFourLabel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnFourLabel;
        partial void OnColumnFourLabelChanging(string value);
        partial void OnColumnFourLabelChanged();
        /// <summary>
        /// There are no comments for Property ColumnThreeRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnThreeRange")]
        public virtual string ColumnThreeRange
        {
            get
            {
                return this._ColumnThreeRange;
            }
            set
            {
                this.OnColumnThreeRangeChanging(value);
                this._ColumnThreeRange = value;
                this.OnColumnThreeRangeChanged();
                this.OnPropertyChanged("ColumnThreeRange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnThreeRange;
        partial void OnColumnThreeRangeChanging(string value);
        partial void OnColumnThreeRangeChanged();
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
