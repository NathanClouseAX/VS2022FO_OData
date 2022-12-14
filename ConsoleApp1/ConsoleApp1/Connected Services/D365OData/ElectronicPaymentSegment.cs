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
    /// There are no comments for ElectronicPaymentSegmentSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ElectronicPaymentSegmentSingle")]
    public partial class ElectronicPaymentSegmentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ElectronicPaymentSegment>
    {
        /// <summary>
        /// Initialize a new ElectronicPaymentSegmentSingle object.
        /// </summary>
        public ElectronicPaymentSegmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ElectronicPaymentSegmentSingle object.
        /// </summary>
        public ElectronicPaymentSegmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ElectronicPaymentSegmentSingle object.
        /// </summary>
        public ElectronicPaymentSegmentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ElectronicPaymentSegment> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ElectronicPaymentSegment in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Segment
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Segment")]
    [global::Microsoft.OData.Client.EntitySet("ElectronicPaymentSegments")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ElectronicPaymentSegment")]
    public partial class ElectronicPaymentSegment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ElectronicPaymentSegment object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="segment">Initial value of Segment.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ElectronicPaymentSegment CreateElectronicPaymentSegment(string dataAreaId, string segment)
        {
            ElectronicPaymentSegment electronicPaymentSegment = new ElectronicPaymentSegment();
            electronicPaymentSegment.DataAreaId = dataAreaId;
            electronicPaymentSegment.Segment = segment;
            return electronicPaymentSegment;
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
        /// There are no comments for Property Segment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Segment")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Segment is required.")]
        public virtual string Segment
        {
            get
            {
                return this._Segment;
            }
            set
            {
                this.OnSegmentChanging(value);
                this._Segment = value;
                this.OnSegmentChanged();
                this.OnPropertyChanged("Segment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Segment;
        partial void OnSegmentChanging(string value);
        partial void OnSegmentChanged();
        /// <summary>
        /// There are no comments for Property Nextsegment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Nextsegment")]
        public virtual string Nextsegment
        {
            get
            {
                return this._Nextsegment;
            }
            set
            {
                this.OnNextsegmentChanging(value);
                this._Nextsegment = value;
                this.OnNextsegmentChanged();
                this.OnPropertyChanged("Nextsegment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Nextsegment;
        partial void OnNextsegmentChanging(string value);
        partial void OnNextsegmentChanged();
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
        /// There are no comments for Property Mandatory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Mandatory")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Mandatory
        {
            get
            {
                return this._Mandatory;
            }
            set
            {
                this.OnMandatoryChanging(value);
                this._Mandatory = value;
                this.OnMandatoryChanged();
                this.OnPropertyChanged("Mandatory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Mandatory;
        partial void OnMandatoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnMandatoryChanged();
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
