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
    /// There are no comments for AssetParametersProposalJournalNameSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetParametersProposalJournalNameSingle")]
    public partial class AssetParametersProposalJournalNameSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetParametersProposalJournalName>
    {
        /// <summary>
        /// Initialize a new AssetParametersProposalJournalNameSingle object.
        /// </summary>
        public AssetParametersProposalJournalNameSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetParametersProposalJournalNameSingle object.
        /// </summary>
        public AssetParametersProposalJournalNameSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetParametersProposalJournalNameSingle object.
        /// </summary>
        public AssetParametersProposalJournalNameSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetParametersProposalJournalName> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetParameterProposalJournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetParameterProposalJournalName")]
        public virtual global::Microsoft.Dynamics.DataEntities.JournalNameSingle AssetParameterProposalJournalName
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetParameterProposalJournalName == null))
                {
                    this._AssetParameterProposalJournalName = new global::Microsoft.Dynamics.DataEntities.JournalNameSingle(this.Context, GetPath("AssetParameterProposalJournalName"));
                }
                return this._AssetParameterProposalJournalName;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JournalNameSingle _AssetParameterProposalJournalName;
        /// <summary>
        /// There are no comments for AssetParameterProposalJournalNameParameters in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetParameterProposalJournalNameParameters")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetParameterSingle AssetParameterProposalJournalNameParameters
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetParameterProposalJournalNameParameters == null))
                {
                    this._AssetParameterProposalJournalNameParameters = new global::Microsoft.Dynamics.DataEntities.AssetParameterSingle(this.Context, GetPath("AssetParameterProposalJournalNameParameters"));
                }
                return this._AssetParameterProposalJournalNameParameters;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetParameterSingle _AssetParameterProposalJournalNameParameters;
    }
    /// <summary>
    /// There are no comments for AssetParametersProposalJournalName in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// AssetParameters
    /// PostingType
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AssetParameters", "PostingType")]
    [global::Microsoft.OData.Client.EntitySet("AssetParametersProposalJournalNames")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetParametersProposalJournalName")]
    public partial class AssetParametersProposalJournalName : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetParametersProposalJournalName object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="assetParameters">Initial value of AssetParameters.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetParametersProposalJournalName CreateAssetParametersProposalJournalName(string dataAreaId, int assetParameters)
        {
            AssetParametersProposalJournalName assetParametersProposalJournalName = new AssetParametersProposalJournalName();
            assetParametersProposalJournalName.DataAreaId = dataAreaId;
            assetParametersProposalJournalName.AssetParameters = assetParameters;
            return assetParametersProposalJournalName;
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
        /// There are no comments for Property AssetParameters in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetParameters")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssetParameters is required.")]
        public virtual int AssetParameters
        {
            get
            {
                return this._AssetParameters;
            }
            set
            {
                this.OnAssetParametersChanging(value);
                this._AssetParameters = value;
                this.OnAssetParametersChanged();
                this.OnPropertyChanged("AssetParameters");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _AssetParameters;
        partial void OnAssetParametersChanging(int value);
        partial void OnAssetParametersChanged();
        /// <summary>
        /// There are no comments for Property PostingType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostingType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> PostingType
        {
            get
            {
                return this._PostingType;
            }
            set
            {
                this.OnPostingTypeChanging(value);
                this._PostingType = value;
                this.OnPostingTypeChanged();
                this.OnPropertyChanged("PostingType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> _PostingType;
        partial void OnPostingTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> value);
        partial void OnPostingTypeChanged();
        /// <summary>
        /// There are no comments for Property JournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalName")]
        public virtual string JournalName
        {
            get
            {
                return this._JournalName;
            }
            set
            {
                this.OnJournalNameChanging(value);
                this._JournalName = value;
                this.OnJournalNameChanged();
                this.OnPropertyChanged("JournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalName;
        partial void OnJournalNameChanging(string value);
        partial void OnJournalNameChanged();
        /// <summary>
        /// There are no comments for Property AssetParameterProposalJournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetParameterProposalJournalName")]
        public virtual global::Microsoft.Dynamics.DataEntities.JournalName AssetParameterProposalJournalName
        {
            get
            {
                return this._AssetParameterProposalJournalName;
            }
            set
            {
                this.OnAssetParameterProposalJournalNameChanging(value);
                this._AssetParameterProposalJournalName = value;
                this.OnAssetParameterProposalJournalNameChanged();
                this.OnPropertyChanged("AssetParameterProposalJournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JournalName _AssetParameterProposalJournalName;
        partial void OnAssetParameterProposalJournalNameChanging(global::Microsoft.Dynamics.DataEntities.JournalName value);
        partial void OnAssetParameterProposalJournalNameChanged();
        /// <summary>
        /// There are no comments for Property AssetParameterProposalJournalNameParameters in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetParameterProposalJournalNameParameters")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetParameter AssetParameterProposalJournalNameParameters
        {
            get
            {
                return this._AssetParameterProposalJournalNameParameters;
            }
            set
            {
                this.OnAssetParameterProposalJournalNameParametersChanging(value);
                this._AssetParameterProposalJournalNameParameters = value;
                this.OnAssetParameterProposalJournalNameParametersChanged();
                this.OnPropertyChanged("AssetParameterProposalJournalNameParameters");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetParameter _AssetParameterProposalJournalNameParameters;
        partial void OnAssetParameterProposalJournalNameParametersChanging(global::Microsoft.Dynamics.DataEntities.AssetParameter value);
        partial void OnAssetParameterProposalJournalNameParametersChanged();
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