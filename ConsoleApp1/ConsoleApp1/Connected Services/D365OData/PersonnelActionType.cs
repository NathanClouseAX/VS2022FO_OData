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
    /// There are no comments for PersonnelActionTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PersonnelActionTypeSingle")]
    public partial class PersonnelActionTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PersonnelActionType>
    {
        /// <summary>
        /// Initialize a new PersonnelActionTypeSingle object.
        /// </summary>
        public PersonnelActionTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PersonnelActionTypeSingle object.
        /// </summary>
        public PersonnelActionTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PersonnelActionTypeSingle object.
        /// </summary>
        public PersonnelActionTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PersonnelActionType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RelatedFixedCompensationAction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RelatedFixedCompensationAction")]
        public virtual global::Microsoft.Dynamics.DataEntities.FixedCompensationActionSingle RelatedFixedCompensationAction
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RelatedFixedCompensationAction == null))
                {
                    this._RelatedFixedCompensationAction = new global::Microsoft.Dynamics.DataEntities.FixedCompensationActionSingle(this.Context, GetPath("RelatedFixedCompensationAction"));
                }
                return this._RelatedFixedCompensationAction;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.FixedCompensationActionSingle _RelatedFixedCompensationAction;
    }
    /// <summary>
    /// There are no comments for PersonnelActionType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonnelActionType
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PersonnelActionType")]
    [global::Microsoft.OData.Client.EntitySet("PersonnelActionTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PersonnelActionType")]
    public partial class PersonnelActionType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PersonnelActionType object.
        /// </summary>
        /// <param name="personnelActionType1">Initial value of PersonnelActionType1.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PersonnelActionType CreatePersonnelActionType(string personnelActionType1)
        {
            PersonnelActionType personnelActionType = new PersonnelActionType();
            personnelActionType.PersonnelActionType1 = personnelActionType1;
            return personnelActionType;
        }
        /// <summary>
        /// There are no comments for Property PersonnelActionType1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonnelActionType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PersonnelActionType1 is required.")]
        public virtual string PersonnelActionType1
        {
            get
            {
                return this._PersonnelActionType1;
            }
            set
            {
                this.OnPersonnelActionType1Changing(value);
                this._PersonnelActionType1 = value;
                this.OnPersonnelActionType1Changed();
                this.OnPropertyChanged("PersonnelActionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelActionType1;
        partial void OnPersonnelActionType1Changing(string value);
        partial void OnPersonnelActionType1Changed();
        /// <summary>
        /// There are no comments for Property Workflow in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Workflow")]
        public virtual string Workflow
        {
            get
            {
                return this._Workflow;
            }
            set
            {
                this.OnWorkflowChanging(value);
                this._Workflow = value;
                this.OnWorkflowChanged();
                this.OnPropertyChanged("Workflow");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Workflow;
        partial void OnWorkflowChanging(string value);
        partial void OnWorkflowChanged();
        /// <summary>
        /// There are no comments for Property PersonnelAction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonnelAction")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmActionType> PersonnelAction
        {
            get
            {
                return this._PersonnelAction;
            }
            set
            {
                this.OnPersonnelActionChanging(value);
                this._PersonnelAction = value;
                this.OnPersonnelActionChanged();
                this.OnPropertyChanged("PersonnelAction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmActionType> _PersonnelAction;
        partial void OnPersonnelActionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmActionType> value);
        partial void OnPersonnelActionChanged();
        /// <summary>
        /// There are no comments for Property LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LegalEntity")]
        public virtual string LegalEntity
        {
            get
            {
                return this._LegalEntity;
            }
            set
            {
                this.OnLegalEntityChanging(value);
                this._LegalEntity = value;
                this.OnLegalEntityChanged();
                this.OnPropertyChanged("LegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntity;
        partial void OnLegalEntityChanging(string value);
        partial void OnLegalEntityChanged();
        /// <summary>
        /// There are no comments for Property FixedCompensationAction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FixedCompensationAction")]
        public virtual string FixedCompensationAction
        {
            get
            {
                return this._FixedCompensationAction;
            }
            set
            {
                this.OnFixedCompensationActionChanging(value);
                this._FixedCompensationAction = value;
                this.OnFixedCompensationActionChanged();
                this.OnPropertyChanged("FixedCompensationAction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FixedCompensationAction;
        partial void OnFixedCompensationActionChanging(string value);
        partial void OnFixedCompensationActionChanged();
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
        /// There are no comments for Property RelatedFixedCompensationAction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RelatedFixedCompensationAction")]
        public virtual global::Microsoft.Dynamics.DataEntities.FixedCompensationAction RelatedFixedCompensationAction
        {
            get
            {
                return this._RelatedFixedCompensationAction;
            }
            set
            {
                this.OnRelatedFixedCompensationActionChanging(value);
                this._RelatedFixedCompensationAction = value;
                this.OnRelatedFixedCompensationActionChanged();
                this.OnPropertyChanged("RelatedFixedCompensationAction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.FixedCompensationAction _RelatedFixedCompensationAction;
        partial void OnRelatedFixedCompensationActionChanging(global::Microsoft.Dynamics.DataEntities.FixedCompensationAction value);
        partial void OnRelatedFixedCompensationActionChanged();
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