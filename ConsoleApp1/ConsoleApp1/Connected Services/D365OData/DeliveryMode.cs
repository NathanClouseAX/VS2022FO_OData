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
    /// There are no comments for DeliveryModeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DeliveryModeSingle")]
    public partial class DeliveryModeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DeliveryMode>
    {
        /// <summary>
        /// Initialize a new DeliveryModeSingle object.
        /// </summary>
        public DeliveryModeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DeliveryModeSingle object.
        /// </summary>
        public DeliveryModeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DeliveryModeSingle object.
        /// </summary>
        public DeliveryModeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DeliveryMode> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for DeliveryMode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DeliveryModeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DeliveryModeId")]
    [global::Microsoft.OData.Client.EntitySet("DeliveryMode")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DeliveryMode")]
    public partial class DeliveryMode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DeliveryMode object.
        /// </summary>
        /// <param name="deliveryModeId">Initial value of DeliveryModeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DeliveryMode CreateDeliveryMode(string deliveryModeId)
        {
            DeliveryMode deliveryMode = new DeliveryMode();
            deliveryMode.DeliveryModeId = deliveryModeId;
            return deliveryMode;
        }
        /// <summary>
        /// There are no comments for Property DeliveryModeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeliveryModeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DeliveryModeId is required.")]
        public virtual string DeliveryModeId
        {
            get
            {
                return this._DeliveryModeId;
            }
            set
            {
                this.OnDeliveryModeIdChanging(value);
                this._DeliveryModeId = value;
                this.OnDeliveryModeIdChanged();
                this.OnPropertyChanged("DeliveryModeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeliveryModeId;
        partial void OnDeliveryModeIdChanging(string value);
        partial void OnDeliveryModeIdChanged();
        /// <summary>
        /// There are no comments for Property DeliveryModeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeliveryModeName")]
        public virtual string DeliveryModeName
        {
            get
            {
                return this._DeliveryModeName;
            }
            set
            {
                this.OnDeliveryModeNameChanging(value);
                this._DeliveryModeName = value;
                this.OnDeliveryModeNameChanged();
                this.OnPropertyChanged("DeliveryModeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeliveryModeName;
        partial void OnDeliveryModeNameChanging(string value);
        partial void OnDeliveryModeNameChanged();
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
