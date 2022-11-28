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
    /// There are no comments for LoanedEquipmentSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LoanedEquipmentSingle")]
    public partial class LoanedEquipmentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LoanedEquipment>
    {
        /// <summary>
        /// Initialize a new LoanedEquipmentSingle object.
        /// </summary>
        public LoanedEquipmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LoanedEquipmentSingle object.
        /// </summary>
        public LoanedEquipmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LoanedEquipmentSingle object.
        /// </summary>
        public LoanedEquipmentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LoanedEquipment> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LoanItem in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LoanItem")]
        public virtual global::Microsoft.Dynamics.DataEntities.LoanItemSingle LoanItem
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LoanItem == null))
                {
                    this._LoanItem = new global::Microsoft.Dynamics.DataEntities.LoanItemSingle(this.Context, GetPath("LoanItem"));
                }
                return this._LoanItem;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LoanItemSingle _LoanItem;
        /// <summary>
        /// There are no comments for DirPerson in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DirPerson")]
        public virtual global::Microsoft.Dynamics.DataEntities.PersonSingle DirPerson
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DirPerson == null))
                {
                    this._DirPerson = new global::Microsoft.Dynamics.DataEntities.PersonSingle(this.Context, GetPath("DirPerson"));
                }
                return this._DirPerson;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PersonSingle _DirPerson;
    }
    /// <summary>
    /// There are no comments for LoanedEquipment in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonId
    /// LoanItemId
    /// Loaned
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PersonId", "LoanItemId", "Loaned")]
    [global::Microsoft.OData.Client.EntitySet("LoanedEquipments")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LoanedEquipment")]
    public partial class LoanedEquipment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LoanedEquipment object.
        /// </summary>
        /// <param name="personId">Initial value of PersonId.</param>
        /// <param name="loanItemId">Initial value of LoanItemId.</param>
        /// <param name="loaned">Initial value of Loaned.</param>
        /// <param name="actualReturn">Initial value of ActualReturn.</param>
        /// <param name="plannedReturn">Initial value of PlannedReturn.</param>
        /// <param name="loanItem">Initial value of LoanItem.</param>
        /// <param name="dirPerson">Initial value of DirPerson.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LoanedEquipment CreateLoanedEquipment(string personId, 
                    string loanItemId, 
                    global::System.DateTimeOffset loaned, 
                    global::System.DateTimeOffset actualReturn, 
                    global::System.DateTimeOffset plannedReturn, 
                    global::Microsoft.Dynamics.DataEntities.LoanItem loanItem, 
                    global::Microsoft.Dynamics.DataEntities.Person dirPerson)
        {
            LoanedEquipment loanedEquipment = new LoanedEquipment();
            loanedEquipment.PersonId = personId;
            loanedEquipment.LoanItemId = loanItemId;
            loanedEquipment.Loaned = loaned;
            loanedEquipment.ActualReturn = actualReturn;
            loanedEquipment.PlannedReturn = plannedReturn;
            if ((loanItem == null))
            {
                throw new global::System.ArgumentNullException("loanItem");
            }
            loanedEquipment.LoanItem = loanItem;
            if ((dirPerson == null))
            {
                throw new global::System.ArgumentNullException("dirPerson");
            }
            loanedEquipment.DirPerson = dirPerson;
            return loanedEquipment;
        }
        /// <summary>
        /// There are no comments for Property PersonId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PersonId is required.")]
        public virtual string PersonId
        {
            get
            {
                return this._PersonId;
            }
            set
            {
                this.OnPersonIdChanging(value);
                this._PersonId = value;
                this.OnPersonIdChanged();
                this.OnPropertyChanged("PersonId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonId;
        partial void OnPersonIdChanging(string value);
        partial void OnPersonIdChanged();
        /// <summary>
        /// There are no comments for Property LoanItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LoanItemId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LoanItemId is required.")]
        public virtual string LoanItemId
        {
            get
            {
                return this._LoanItemId;
            }
            set
            {
                this.OnLoanItemIdChanging(value);
                this._LoanItemId = value;
                this.OnLoanItemIdChanged();
                this.OnPropertyChanged("LoanItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LoanItemId;
        partial void OnLoanItemIdChanging(string value);
        partial void OnLoanItemIdChanged();
        /// <summary>
        /// There are no comments for Property Loaned in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Loaned")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Loaned is required.")]
        public virtual global::System.DateTimeOffset Loaned
        {
            get
            {
                return this._Loaned;
            }
            set
            {
                this.OnLoanedChanging(value);
                this._Loaned = value;
                this.OnLoanedChanged();
                this.OnPropertyChanged("Loaned");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Loaned;
        partial void OnLoanedChanging(global::System.DateTimeOffset value);
        partial void OnLoanedChanged();
        /// <summary>
        /// There are no comments for Property ActualReturn in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActualReturn")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ActualReturn is required.")]
        public virtual global::System.DateTimeOffset ActualReturn
        {
            get
            {
                return this._ActualReturn;
            }
            set
            {
                this.OnActualReturnChanging(value);
                this._ActualReturn = value;
                this.OnActualReturnChanged();
                this.OnPropertyChanged("ActualReturn");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ActualReturn;
        partial void OnActualReturnChanging(global::System.DateTimeOffset value);
        partial void OnActualReturnChanged();
        /// <summary>
        /// There are no comments for Property PlannedReturn in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlannedReturn")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PlannedReturn is required.")]
        public virtual global::System.DateTimeOffset PlannedReturn
        {
            get
            {
                return this._PlannedReturn;
            }
            set
            {
                this.OnPlannedReturnChanging(value);
                this._PlannedReturn = value;
                this.OnPlannedReturnChanged();
                this.OnPropertyChanged("PlannedReturn");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PlannedReturn;
        partial void OnPlannedReturnChanging(global::System.DateTimeOffset value);
        partial void OnPlannedReturnChanged();
        /// <summary>
        /// There are no comments for Property LoanItem in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LoanItem")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LoanItem is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.LoanItem LoanItem
        {
            get
            {
                return this._LoanItem;
            }
            set
            {
                this.OnLoanItemChanging(value);
                this._LoanItem = value;
                this.OnLoanItemChanged();
                this.OnPropertyChanged("LoanItem");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LoanItem _LoanItem;
        partial void OnLoanItemChanging(global::Microsoft.Dynamics.DataEntities.LoanItem value);
        partial void OnLoanItemChanged();
        /// <summary>
        /// There are no comments for Property DirPerson in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DirPerson")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DirPerson is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Person DirPerson
        {
            get
            {
                return this._DirPerson;
            }
            set
            {
                this.OnDirPersonChanging(value);
                this._DirPerson = value;
                this.OnDirPersonChanged();
                this.OnPropertyChanged("DirPerson");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Person _DirPerson;
        partial void OnDirPersonChanging(global::Microsoft.Dynamics.DataEntities.Person value);
        partial void OnDirPersonChanged();
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
