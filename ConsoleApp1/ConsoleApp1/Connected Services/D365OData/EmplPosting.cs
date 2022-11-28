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
    /// There are no comments for EmplPostingSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EmplPostingSingle")]
    public partial class EmplPostingSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EmplPosting>
    {
        /// <summary>
        /// Initialize a new EmplPostingSingle object.
        /// </summary>
        public EmplPostingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EmplPostingSingle object.
        /// </summary>
        public EmplPostingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EmplPostingSingle object.
        /// </summary>
        public EmplPostingSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EmplPosting> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for EmplPosting in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PostingProfile
    /// AccountCode
    /// Num
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PostingProfile", "AccountCode", "Num")]
    [global::Microsoft.OData.Client.EntitySet("EmplPostings")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("EmplPosting")]
    public partial class EmplPosting : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EmplPosting object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="postingProfile">Initial value of PostingProfile.</param>
        /// <param name="num">Initial value of Num.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EmplPosting CreateEmplPosting(string dataAreaId, string postingProfile, string num)
        {
            EmplPosting emplPosting = new EmplPosting();
            emplPosting.DataAreaId = dataAreaId;
            emplPosting.PostingProfile = postingProfile;
            emplPosting.Num = num;
            return emplPosting;
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
        /// There are no comments for Property PostingProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostingProfile")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PostingProfile is required.")]
        public virtual string PostingProfile
        {
            get
            {
                return this._PostingProfile;
            }
            set
            {
                this.OnPostingProfileChanging(value);
                this._PostingProfile = value;
                this.OnPostingProfileChanged();
                this.OnPropertyChanged("PostingProfile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PostingProfile;
        partial void OnPostingProfileChanging(string value);
        partial void OnPostingProfileChanged();
        /// <summary>
        /// There are no comments for Property AccountCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountCode")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TableGroupAll> AccountCode
        {
            get
            {
                return this._AccountCode;
            }
            set
            {
                this.OnAccountCodeChanging(value);
                this._AccountCode = value;
                this.OnAccountCodeChanged();
                this.OnPropertyChanged("AccountCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TableGroupAll> _AccountCode;
        partial void OnAccountCodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TableGroupAll> value);
        partial void OnAccountCodeChanged();
        /// <summary>
        /// There are no comments for Property Num in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Num")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Num is required.")]
        public virtual string Num
        {
            get
            {
                return this._Num;
            }
            set
            {
                this.OnNumChanging(value);
                this._Num = value;
                this.OnNumChanged();
                this.OnPropertyChanged("Num");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Num;
        partial void OnNumChanging(string value);
        partial void OnNumChanged();
        /// <summary>
        /// There are no comments for Property SummaryLedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SummaryLedgerDimensionDisplayValue")]
        public virtual string SummaryLedgerDimensionDisplayValue
        {
            get
            {
                return this._SummaryLedgerDimensionDisplayValue;
            }
            set
            {
                this.OnSummaryLedgerDimensionDisplayValueChanging(value);
                this._SummaryLedgerDimensionDisplayValue = value;
                this.OnSummaryLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("SummaryLedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SummaryLedgerDimensionDisplayValue;
        partial void OnSummaryLedgerDimensionDisplayValueChanging(string value);
        partial void OnSummaryLedgerDimensionDisplayValueChanged();
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
        /// There are no comments for Property SettlementByDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SettlementByDimension")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DimSettlementCtrlType_RU> SettlementByDimension
        {
            get
            {
                return this._SettlementByDimension;
            }
            set
            {
                this.OnSettlementByDimensionChanging(value);
                this._SettlementByDimension = value;
                this.OnSettlementByDimensionChanged();
                this.OnPropertyChanged("SettlementByDimension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DimSettlementCtrlType_RU> _SettlementByDimension;
        partial void OnSettlementByDimensionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DimSettlementCtrlType_RU> value);
        partial void OnSettlementByDimensionChanged();
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
