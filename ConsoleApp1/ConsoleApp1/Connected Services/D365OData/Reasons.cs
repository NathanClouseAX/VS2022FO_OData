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
    /// There are no comments for ReasonsSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ReasonsSingle")]
    public partial class ReasonsSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Reasons>
    {
        /// <summary>
        /// Initialize a new ReasonsSingle object.
        /// </summary>
        public ReasonsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ReasonsSingle object.
        /// </summary>
        public ReasonsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ReasonsSingle object.
        /// </summary>
        public ReasonsSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Reasons> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for Reasons in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ReasonCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ReasonCode")]
    [global::Microsoft.OData.Client.EntitySet("Reasons")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Reasons")]
    public partial class Reasons : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Reasons object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="reasonCode">Initial value of ReasonCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Reasons CreateReasons(string dataAreaId, string reasonCode)
        {
            Reasons reasons = new Reasons();
            reasons.DataAreaId = dataAreaId;
            reasons.ReasonCode = reasonCode;
            return reasons;
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
        /// There are no comments for Property ReasonCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReasonCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReasonCode is required.")]
        public virtual string ReasonCode
        {
            get
            {
                return this._ReasonCode;
            }
            set
            {
                this.OnReasonCodeChanging(value);
                this._ReasonCode = value;
                this.OnReasonCodeChanged();
                this.OnPropertyChanged("ReasonCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReasonCode;
        partial void OnReasonCodeChanging(string value);
        partial void OnReasonCodeChanged();
        /// <summary>
        /// There are no comments for Property FixedAssets in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FixedAssets")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> FixedAssets
        {
            get
            {
                return this._FixedAssets;
            }
            set
            {
                this.OnFixedAssetsChanging(value);
                this._FixedAssets = value;
                this.OnFixedAssetsChanged();
                this.OnPropertyChanged("FixedAssets");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _FixedAssets;
        partial void OnFixedAssetsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnFixedAssetsChanged();
        /// <summary>
        /// There are no comments for Property DefaultComment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultComment")]
        public virtual string DefaultComment
        {
            get
            {
                return this._DefaultComment;
            }
            set
            {
                this.OnDefaultCommentChanging(value);
                this._DefaultComment = value;
                this.OnDefaultCommentChanged();
                this.OnPropertyChanged("DefaultComment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultComment;
        partial void OnDefaultCommentChanging(string value);
        partial void OnDefaultCommentChanged();
        /// <summary>
        /// There are no comments for Property Ledger in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Ledger")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Ledger
        {
            get
            {
                return this._Ledger;
            }
            set
            {
                this.OnLedgerChanging(value);
                this._Ledger = value;
                this.OnLedgerChanged();
                this.OnPropertyChanged("Ledger");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Ledger;
        partial void OnLedgerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnLedgerChanged();
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
