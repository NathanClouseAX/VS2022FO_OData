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
    /// There are no comments for AccomodationTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AccomodationTypeSingle")]
    public partial class AccomodationTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AccomodationType>
    {
        /// <summary>
        /// Initialize a new AccomodationTypeSingle object.
        /// </summary>
        public AccomodationTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AccomodationTypeSingle object.
        /// </summary>
        public AccomodationTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AccomodationTypeSingle object.
        /// </summary>
        public AccomodationTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AccomodationType> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AccomodationType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AccommodationTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AccommodationTypeId")]
    [global::Microsoft.OData.Client.EntitySet("AccomodationTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AccomodationType")]
    public partial class AccomodationType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AccomodationType object.
        /// </summary>
        /// <param name="accommodationTypeId">Initial value of AccommodationTypeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AccomodationType CreateAccomodationType(string accommodationTypeId)
        {
            AccomodationType accomodationType = new AccomodationType();
            accomodationType.AccommodationTypeId = accommodationTypeId;
            return accomodationType;
        }
        /// <summary>
        /// There are no comments for Property AccommodationTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccommodationTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccommodationTypeId is required.")]
        public virtual string AccommodationTypeId
        {
            get
            {
                return this._AccommodationTypeId;
            }
            set
            {
                this.OnAccommodationTypeIdChanging(value);
                this._AccommodationTypeId = value;
                this.OnAccommodationTypeIdChanged();
                this.OnPropertyChanged("AccommodationTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccommodationTypeId;
        partial void OnAccommodationTypeIdChanging(string value);
        partial void OnAccommodationTypeIdChanged();
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
        /// There are no comments for Property Note in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Note")]
        public virtual string Note
        {
            get
            {
                return this._Note;
            }
            set
            {
                this.OnNoteChanging(value);
                this._Note = value;
                this.OnNoteChanged();
                this.OnPropertyChanged("Note");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Note;
        partial void OnNoteChanging(string value);
        partial void OnNoteChanged();
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
