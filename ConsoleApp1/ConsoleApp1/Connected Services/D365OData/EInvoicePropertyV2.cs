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
    /// There are no comments for EInvoicePropertyV2Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EInvoicePropertyV2Single")]
    public partial class EInvoicePropertyV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<EInvoicePropertyV2>
    {
        /// <summary>
        /// Initialize a new EInvoicePropertyV2Single object.
        /// </summary>
        public EInvoicePropertyV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EInvoicePropertyV2Single object.
        /// </summary>
        public EInvoicePropertyV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EInvoicePropertyV2Single object.
        /// </summary>
        public EInvoicePropertyV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<EInvoicePropertyV2> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for EInvoicePropertyV2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TableName
    /// TableFieldName
    /// TableFieldValue
    /// Type
    /// TableDataAreaId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TableName", "TableFieldName", "TableFieldValue", "Type", "TableDataAreaId")]
    [global::Microsoft.OData.Client.EntitySet("EInvoicePropertiesV2")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("EInvoicePropertyV2")]
    public partial class EInvoicePropertyV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EInvoicePropertyV2 object.
        /// </summary>
        /// <param name="tableName">Initial value of TableName.</param>
        /// <param name="tableFieldName">Initial value of TableFieldName.</param>
        /// <param name="tableFieldValue">Initial value of TableFieldValue.</param>
        /// <param name="type">Initial value of Type.</param>
        /// <param name="tableDataAreaId">Initial value of TableDataAreaId.</param>
        /// <param name="refTableId">Initial value of RefTableId.</param>
        /// <param name="refRecId">Initial value of RefRecId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EInvoicePropertyV2 CreateEInvoicePropertyV2(string tableName, 
                    string tableFieldName, 
                    string tableFieldValue, 
                    string type, 
                    string tableDataAreaId, 
                    int refTableId, 
                    long refRecId)
        {
            EInvoicePropertyV2 eInvoicePropertyV2 = new EInvoicePropertyV2();
            eInvoicePropertyV2.TableName = tableName;
            eInvoicePropertyV2.TableFieldName = tableFieldName;
            eInvoicePropertyV2.TableFieldValue = tableFieldValue;
            eInvoicePropertyV2.Type = type;
            eInvoicePropertyV2.TableDataAreaId = tableDataAreaId;
            eInvoicePropertyV2.RefTableId = refTableId;
            eInvoicePropertyV2.RefRecId = refRecId;
            return eInvoicePropertyV2;
        }
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
        /// There are no comments for Property TableFieldName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TableFieldName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TableFieldName is required.")]
        public virtual string TableFieldName
        {
            get
            {
                return this._TableFieldName;
            }
            set
            {
                this.OnTableFieldNameChanging(value);
                this._TableFieldName = value;
                this.OnTableFieldNameChanged();
                this.OnPropertyChanged("TableFieldName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TableFieldName;
        partial void OnTableFieldNameChanging(string value);
        partial void OnTableFieldNameChanged();
        /// <summary>
        /// There are no comments for Property TableFieldValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TableFieldValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TableFieldValue is required.")]
        public virtual string TableFieldValue
        {
            get
            {
                return this._TableFieldValue;
            }
            set
            {
                this.OnTableFieldValueChanging(value);
                this._TableFieldValue = value;
                this.OnTableFieldValueChanged();
                this.OnPropertyChanged("TableFieldValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TableFieldValue;
        partial void OnTableFieldValueChanging(string value);
        partial void OnTableFieldValueChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Type is required.")]
        public virtual string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Type;
        partial void OnTypeChanging(string value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property TableDataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TableDataAreaId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TableDataAreaId is required.")]
        public virtual string TableDataAreaId
        {
            get
            {
                return this._TableDataAreaId;
            }
            set
            {
                this.OnTableDataAreaIdChanging(value);
                this._TableDataAreaId = value;
                this.OnTableDataAreaIdChanged();
                this.OnPropertyChanged("TableDataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TableDataAreaId;
        partial void OnTableDataAreaIdChanging(string value);
        partial void OnTableDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Value")]
        public virtual string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
        /// <summary>
        /// There are no comments for Property RefTableId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RefTableId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RefTableId is required.")]
        public virtual int RefTableId
        {
            get
            {
                return this._RefTableId;
            }
            set
            {
                this.OnRefTableIdChanging(value);
                this._RefTableId = value;
                this.OnRefTableIdChanged();
                this.OnPropertyChanged("RefTableId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _RefTableId;
        partial void OnRefTableIdChanging(int value);
        partial void OnRefTableIdChanged();
        /// <summary>
        /// There are no comments for Property RefRecId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RefRecId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RefRecId is required.")]
        public virtual long RefRecId
        {
            get
            {
                return this._RefRecId;
            }
            set
            {
                this.OnRefRecIdChanging(value);
                this._RefRecId = value;
                this.OnRefRecIdChanged();
                this.OnPropertyChanged("RefRecId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _RefRecId;
        partial void OnRefRecIdChanging(long value);
        partial void OnRefRecIdChanged();
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