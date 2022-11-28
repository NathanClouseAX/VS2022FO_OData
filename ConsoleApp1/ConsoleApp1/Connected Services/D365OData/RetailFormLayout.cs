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
    /// There are no comments for RetailFormLayoutSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailFormLayoutSingle")]
    public partial class RetailFormLayoutSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailFormLayout>
    {
        /// <summary>
        /// Initialize a new RetailFormLayoutSingle object.
        /// </summary>
        public RetailFormLayoutSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailFormLayoutSingle object.
        /// </summary>
        public RetailFormLayoutSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailFormLayoutSingle object.
        /// </summary>
        public RetailFormLayoutSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailFormLayout> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailFormLayout in the schema.
    /// </summary>
    /// <KeyProperties>
    /// FormLayoutId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("FormLayoutId")]
    [global::Microsoft.OData.Client.EntitySet("RetailFormLayouts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailFormLayout")]
    public partial class RetailFormLayout : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailFormLayout object.
        /// </summary>
        /// <param name="formLayoutId">Initial value of FormLayoutId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailFormLayout CreateRetailFormLayout(string formLayoutId)
        {
            RetailFormLayout retailFormLayout = new RetailFormLayout();
            retailFormLayout.FormLayoutId = formLayoutId;
            return retailFormLayout;
        }
        /// <summary>
        /// There are no comments for Property FormLayoutId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FormLayoutId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FormLayoutId is required.")]
        public virtual string FormLayoutId
        {
            get
            {
                return this._FormLayoutId;
            }
            set
            {
                this.OnFormLayoutIdChanging(value);
                this._FormLayoutId = value;
                this.OnFormLayoutIdChanged();
                this.OnPropertyChanged("FormLayoutId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FormLayoutId;
        partial void OnFormLayoutIdChanging(string value);
        partial void OnFormLayoutIdChanged();
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
        /// There are no comments for Property PrintBehaviour in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("printBehaviour")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailPrintBehaviourBase> PrintBehaviour
        {
            get
            {
                return this._PrintBehaviour;
            }
            set
            {
                this.OnPrintBehaviourChanging(value);
                this._PrintBehaviour = value;
                this.OnPrintBehaviourChanged();
                this.OnPropertyChanged("printBehaviour");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailPrintBehaviourBase> _PrintBehaviour;
        partial void OnPrintBehaviourChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailPrintBehaviourBase> value);
        partial void OnPrintBehaviourChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Title")]
        public virtual string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property LinesXML in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("linesXML")]
        public virtual string LinesXML
        {
            get
            {
                return this._LinesXML;
            }
            set
            {
                this.OnLinesXMLChanging(value);
                this._LinesXML = value;
                this.OnLinesXMLChanged();
                this.OnPropertyChanged("linesXML");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LinesXML;
        partial void OnLinesXMLChanging(string value);
        partial void OnLinesXMLChanged();
        /// <summary>
        /// There are no comments for Property PromptQuestion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PromptQuestion")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PromptQuestion
        {
            get
            {
                return this._PromptQuestion;
            }
            set
            {
                this.OnPromptQuestionChanging(value);
                this._PromptQuestion = value;
                this.OnPromptQuestionChanged();
                this.OnPropertyChanged("PromptQuestion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PromptQuestion;
        partial void OnPromptQuestionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPromptQuestionChanged();
        /// <summary>
        /// There are no comments for Property LayoutType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LayoutType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailReceipt> LayoutType
        {
            get
            {
                return this._LayoutType;
            }
            set
            {
                this.OnLayoutTypeChanging(value);
                this._LayoutType = value;
                this.OnLayoutTypeChanged();
                this.OnPropertyChanged("LayoutType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailReceipt> _LayoutType;
        partial void OnLayoutTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailReceipt> value);
        partial void OnLayoutTypeChanged();
        /// <summary>
        /// There are no comments for Property FooterXML in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("footerXML")]
        public virtual string FooterXML
        {
            get
            {
                return this._FooterXML;
            }
            set
            {
                this.OnFooterXMLChanging(value);
                this._FooterXML = value;
                this.OnFooterXMLChanged();
                this.OnPropertyChanged("footerXML");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FooterXML;
        partial void OnFooterXMLChanging(string value);
        partial void OnFooterXMLChanged();
        /// <summary>
        /// There are no comments for Property UpperCase in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UpperCase")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UpperCase
        {
            get
            {
                return this._UpperCase;
            }
            set
            {
                this.OnUpperCaseChanging(value);
                this._UpperCase = value;
                this.OnUpperCaseChanged();
                this.OnPropertyChanged("UpperCase");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UpperCase;
        partial void OnUpperCaseChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUpperCaseChanged();
        /// <summary>
        /// There are no comments for Property EmailBehavior in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmailBehavior")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailEmailBehaviorBase> EmailBehavior
        {
            get
            {
                return this._EmailBehavior;
            }
            set
            {
                this.OnEmailBehaviorChanging(value);
                this._EmailBehavior = value;
                this.OnEmailBehaviorChanged();
                this.OnPropertyChanged("EmailBehavior");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailEmailBehaviorBase> _EmailBehavior;
        partial void OnEmailBehaviorChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailEmailBehaviorBase> value);
        partial void OnEmailBehaviorChanged();
        /// <summary>
        /// There are no comments for Property PrintAsSlip in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PrintAsSlip")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PrintAsSlip
        {
            get
            {
                return this._PrintAsSlip;
            }
            set
            {
                this.OnPrintAsSlipChanging(value);
                this._PrintAsSlip = value;
                this.OnPrintAsSlipChanged();
                this.OnPropertyChanged("PrintAsSlip");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PrintAsSlip;
        partial void OnPrintAsSlipChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPrintAsSlipChanged();
        /// <summary>
        /// There are no comments for Property HeaderXML in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("headerXML")]
        public virtual string HeaderXML
        {
            get
            {
                return this._HeaderXML;
            }
            set
            {
                this.OnHeaderXMLChanging(value);
                this._HeaderXML = value;
                this.OnHeaderXMLChanged();
                this.OnPropertyChanged("headerXML");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HeaderXML;
        partial void OnHeaderXMLChanging(string value);
        partial void OnHeaderXMLChanged();
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