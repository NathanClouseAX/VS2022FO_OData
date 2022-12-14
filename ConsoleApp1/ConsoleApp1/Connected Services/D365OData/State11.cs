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
    /// There are no comments for State11Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("State11Single")]
    public partial class State11Single : global::Microsoft.OData.Client.DataServiceQuerySingle<State11>
    {
        /// <summary>
        /// Initialize a new State11Single object.
        /// </summary>
        public State11Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new State11Single object.
        /// </summary>
        public State11Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new State11Single object.
        /// </summary>
        public State11Single(global::Microsoft.OData.Client.DataServiceQuerySingle<State11> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for State11 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// BankAccount
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "BankAccount")]
    [global::Microsoft.OData.Client.EntitySet("State11")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("State11")]
    public partial class State11 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new State11 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="bankAccount">Initial value of BankAccount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static State11 CreateState11(string dataAreaId, string bankAccount)
        {
            State11 state11 = new State11();
            state11.DataAreaId = dataAreaId;
            state11.BankAccount = bankAccount;
            return state11;
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
        /// There are no comments for Property BankAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BankAccount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BankAccount is required.")]
        public virtual string BankAccount
        {
            get
            {
                return this._BankAccount;
            }
            set
            {
                this.OnBankAccountChanging(value);
                this._BankAccount = value;
                this.OnBankAccountChanged();
                this.OnPropertyChanged("BankAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BankAccount;
        partial void OnBankAccountChanging(string value);
        partial void OnBankAccountChanged();
        /// <summary>
        /// There are no comments for Property SequenceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SequenceNumber")]
        public virtual string SequenceNumber
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
        private string _SequenceNumber;
        partial void OnSequenceNumberChanging(string value);
        partial void OnSequenceNumberChanged();
        /// <summary>
        /// There are no comments for Property ReportOnState11 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportOnState11")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ReportOnState11
        {
            get
            {
                return this._ReportOnState11;
            }
            set
            {
                this.OnReportOnState11Changing(value);
                this._ReportOnState11 = value;
                this.OnReportOnState11Changed();
                this.OnPropertyChanged("ReportOnState11");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ReportOnState11;
        partial void OnReportOnState11Changing(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnReportOnState11Changed();
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
