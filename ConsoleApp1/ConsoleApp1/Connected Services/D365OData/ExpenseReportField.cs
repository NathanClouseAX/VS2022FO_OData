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
    /// There are no comments for ExpenseReportFieldSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ExpenseReportFieldSingle")]
    public partial class ExpenseReportFieldSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ExpenseReportField>
    {
        /// <summary>
        /// Initialize a new ExpenseReportFieldSingle object.
        /// </summary>
        public ExpenseReportFieldSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ExpenseReportFieldSingle object.
        /// </summary>
        public ExpenseReportFieldSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ExpenseReportFieldSingle object.
        /// </summary>
        public ExpenseReportFieldSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ExpenseReportField> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ExpenseReportField in the schema.
    /// </summary>
    /// <KeyProperties>
    /// LegalEntityId
    /// TableName
    /// FieldName
    /// MethodName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LegalEntityId", "TableName", "FieldName", "MethodName")]
    [global::Microsoft.OData.Client.EntitySet("ExpenseReportFields")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ExpenseReportField")]
    public partial class ExpenseReportField : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ExpenseReportField object.
        /// </summary>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="tableName">Initial value of TableName.</param>
        /// <param name="fieldName">Initial value of FieldName.</param>
        /// <param name="methodName">Initial value of MethodName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ExpenseReportField CreateExpenseReportField(string legalEntityId, string tableName, string fieldName, string methodName)
        {
            ExpenseReportField expenseReportField = new ExpenseReportField();
            expenseReportField.LegalEntityId = legalEntityId;
            expenseReportField.TableName = tableName;
            expenseReportField.FieldName = fieldName;
            expenseReportField.MethodName = methodName;
            return expenseReportField;
        }
        /// <summary>
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LegalEntityId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LegalEntityId is required.")]
        public virtual string LegalEntityId
        {
            get
            {
                return this._LegalEntityId;
            }
            set
            {
                this.OnLegalEntityIdChanging(value);
                this._LegalEntityId = value;
                this.OnLegalEntityIdChanged();
                this.OnPropertyChanged("LegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntityId;
        partial void OnLegalEntityIdChanging(string value);
        partial void OnLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property TableName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TableName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TableName is required.")]
        public virtual string TableName
        {
            get
            {
                return this._TableName;
            }
            set
            {
                this.OnTableNameChanging(value);
                this._TableName = value;
                this.OnTableNameChanged();
                this.OnPropertyChanged("TableName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TableName;
        partial void OnTableNameChanging(string value);
        partial void OnTableNameChanged();
        /// <summary>
        /// There are no comments for Property FieldName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FieldName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FieldName is required.")]
        public virtual string FieldName
        {
            get
            {
                return this._FieldName;
            }
            set
            {
                this.OnFieldNameChanging(value);
                this._FieldName = value;
                this.OnFieldNameChanged();
                this.OnPropertyChanged("FieldName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FieldName;
        partial void OnFieldNameChanging(string value);
        partial void OnFieldNameChanged();
        /// <summary>
        /// There are no comments for Property MethodName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MethodName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MethodName is required.")]
        public virtual string MethodName
        {
            get
            {
                return this._MethodName;
            }
            set
            {
                this.OnMethodNameChanging(value);
                this._MethodName = value;
                this.OnMethodNameChanged();
                this.OnPropertyChanged("MethodName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MethodName;
        partial void OnMethodNameChanging(string value);
        partial void OnMethodNameChanged();
        /// <summary>
        /// There are no comments for Property Visibility in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Visibility")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvFieldVisibility> Visibility
        {
            get
            {
                return this._Visibility;
            }
            set
            {
                this.OnVisibilityChanging(value);
                this._Visibility = value;
                this.OnVisibilityChanged();
                this.OnPropertyChanged("Visibility");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvFieldVisibility> _Visibility;
        partial void OnVisibilityChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvFieldVisibility> value);
        partial void OnVisibilityChanged();
        /// <summary>
        /// There are no comments for Property ShowInForm in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShowInForm")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ShowInForm
        {
            get
            {
                return this._ShowInForm;
            }
            set
            {
                this.OnShowInFormChanging(value);
                this._ShowInForm = value;
                this.OnShowInFormChanged();
                this.OnPropertyChanged("ShowInForm");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ShowInForm;
        partial void OnShowInFormChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnShowInFormChanged();
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