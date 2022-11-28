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
    /// There are no comments for RetailDesignerTillLayoutImageZoneSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailDesignerTillLayoutImageZoneSingle")]
    public partial class RetailDesignerTillLayoutImageZoneSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailDesignerTillLayoutImageZone>
    {
        /// <summary>
        /// Initialize a new RetailDesignerTillLayoutImageZoneSingle object.
        /// </summary>
        public RetailDesignerTillLayoutImageZoneSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailDesignerTillLayoutImageZoneSingle object.
        /// </summary>
        public RetailDesignerTillLayoutImageZoneSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailDesignerTillLayoutImageZoneSingle object.
        /// </summary>
        public RetailDesignerTillLayoutImageZoneSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailDesignerTillLayoutImageZone> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailDesignerTillLayoutImageZone in the schema.
    /// </summary>
    /// <KeyProperties>
    /// LayoutId
    /// Zone
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LayoutId", "Zone")]
    [global::Microsoft.OData.Client.EntitySet("RetailDesignerTillLayoutImageZones")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailDesignerTillLayoutImageZone")]
    public partial class RetailDesignerTillLayoutImageZone : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailDesignerTillLayoutImageZone object.
        /// </summary>
        /// <param name="layoutId">Initial value of LayoutId.</param>
        /// <param name="zone">Initial value of Zone.</param>
        /// <param name="axRecId">Initial value of AxRecId.</param>
        /// <param name="instanceRelationType">Initial value of InstanceRelationType.</param>
        /// <param name="pictureId">Initial value of PictureId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailDesignerTillLayoutImageZone CreateRetailDesignerTillLayoutImageZone(string layoutId, long zone, long axRecId, long instanceRelationType, int pictureId)
        {
            RetailDesignerTillLayoutImageZone retailDesignerTillLayoutImageZone = new RetailDesignerTillLayoutImageZone();
            retailDesignerTillLayoutImageZone.LayoutId = layoutId;
            retailDesignerTillLayoutImageZone.Zone = zone;
            retailDesignerTillLayoutImageZone.AxRecId = axRecId;
            retailDesignerTillLayoutImageZone.InstanceRelationType = instanceRelationType;
            retailDesignerTillLayoutImageZone.PictureId = pictureId;
            return retailDesignerTillLayoutImageZone;
        }
        /// <summary>
        /// There are no comments for Property LayoutId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LayoutId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LayoutId is required.")]
        public virtual string LayoutId
        {
            get
            {
                return this._LayoutId;
            }
            set
            {
                this.OnLayoutIdChanging(value);
                this._LayoutId = value;
                this.OnLayoutIdChanged();
                this.OnPropertyChanged("LayoutId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LayoutId;
        partial void OnLayoutIdChanging(string value);
        partial void OnLayoutIdChanged();
        /// <summary>
        /// There are no comments for Property Zone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Zone")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Zone is required.")]
        public virtual long Zone
        {
            get
            {
                return this._Zone;
            }
            set
            {
                this.OnZoneChanging(value);
                this._Zone = value;
                this.OnZoneChanged();
                this.OnPropertyChanged("Zone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _Zone;
        partial void OnZoneChanging(long value);
        partial void OnZoneChanged();
        /// <summary>
        /// There are no comments for Property AxRecId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AxRecId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AxRecId is required.")]
        public virtual long AxRecId
        {
            get
            {
                return this._AxRecId;
            }
            set
            {
                this.OnAxRecIdChanging(value);
                this._AxRecId = value;
                this.OnAxRecIdChanged();
                this.OnPropertyChanged("AxRecId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _AxRecId;
        partial void OnAxRecIdChanging(long value);
        partial void OnAxRecIdChanged();
        /// <summary>
        /// There are no comments for Property InstanceRelationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InstanceRelationType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InstanceRelationType is required.")]
        public virtual long InstanceRelationType
        {
            get
            {
                return this._InstanceRelationType;
            }
            set
            {
                this.OnInstanceRelationTypeChanging(value);
                this._InstanceRelationType = value;
                this.OnInstanceRelationTypeChanged();
                this.OnPropertyChanged("InstanceRelationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _InstanceRelationType;
        partial void OnInstanceRelationTypeChanging(long value);
        partial void OnInstanceRelationTypeChanged();
        /// <summary>
        /// There are no comments for Property PictureId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PictureId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PictureId is required.")]
        public virtual int PictureId
        {
            get
            {
                return this._PictureId;
            }
            set
            {
                this.OnPictureIdChanging(value);
                this._PictureId = value;
                this.OnPictureIdChanged();
                this.OnPropertyChanged("PictureId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PictureId;
        partial void OnPictureIdChanging(int value);
        partial void OnPictureIdChanged();
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