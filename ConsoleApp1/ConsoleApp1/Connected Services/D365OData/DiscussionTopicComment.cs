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
    /// There are no comments for DiscussionTopicCommentSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DiscussionTopicCommentSingle")]
    public partial class DiscussionTopicCommentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DiscussionTopicComment>
    {
        /// <summary>
        /// Initialize a new DiscussionTopicCommentSingle object.
        /// </summary>
        public DiscussionTopicCommentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DiscussionTopicCommentSingle object.
        /// </summary>
        public DiscussionTopicCommentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DiscussionTopicCommentSingle object.
        /// </summary>
        public DiscussionTopicCommentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DiscussionTopicComment> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Discussion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Discussion")]
        public virtual global::Microsoft.Dynamics.DataEntities.DiscussionSingle Discussion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Discussion == null))
                {
                    this._Discussion = new global::Microsoft.Dynamics.DataEntities.DiscussionSingle(this.Context, GetPath("Discussion"));
                }
                return this._Discussion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DiscussionSingle _Discussion;
        /// <summary>
        /// There are no comments for Commenter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Commenter")]
        public virtual global::Microsoft.Dynamics.DataEntities.PersonSingle Commenter
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Commenter == null))
                {
                    this._Commenter = new global::Microsoft.Dynamics.DataEntities.PersonSingle(this.Context, GetPath("Commenter"));
                }
                return this._Commenter;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PersonSingle _Commenter;
        /// <summary>
        /// There are no comments for Topic in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Topic")]
        public virtual global::Microsoft.Dynamics.DataEntities.DiscussionTopicSingle Topic
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Topic == null))
                {
                    this._Topic = new global::Microsoft.Dynamics.DataEntities.DiscussionTopicSingle(this.Context, GetPath("Topic"));
                }
                return this._Topic;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DiscussionTopicSingle _Topic;
    }
    /// <summary>
    /// There are no comments for DiscussionTopicComment in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DiscussionWorkerPersonnelNumber
    /// DiscussionId
    /// TopicNumber
    /// CommentId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DiscussionWorkerPersonnelNumber", "DiscussionId", "TopicNumber", "CommentId")]
    [global::Microsoft.OData.Client.EntitySet("DiscussionTopicComments")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DiscussionTopicComment")]
    public partial class DiscussionTopicComment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DiscussionTopicComment object.
        /// </summary>
        /// <param name="discussionWorkerPersonnelNumber">Initial value of DiscussionWorkerPersonnelNumber.</param>
        /// <param name="discussionId">Initial value of DiscussionId.</param>
        /// <param name="topicNumber">Initial value of TopicNumber.</param>
        /// <param name="commentId">Initial value of CommentId.</param>
        /// <param name="commentDateTime">Initial value of CommentDateTime.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DiscussionTopicComment CreateDiscussionTopicComment(string discussionWorkerPersonnelNumber, string discussionId, int topicNumber, int commentId, global::System.DateTimeOffset commentDateTime)
        {
            DiscussionTopicComment discussionTopicComment = new DiscussionTopicComment();
            discussionTopicComment.DiscussionWorkerPersonnelNumber = discussionWorkerPersonnelNumber;
            discussionTopicComment.DiscussionId = discussionId;
            discussionTopicComment.TopicNumber = topicNumber;
            discussionTopicComment.CommentId = commentId;
            discussionTopicComment.CommentDateTime = commentDateTime;
            return discussionTopicComment;
        }
        /// <summary>
        /// There are no comments for Property DiscussionWorkerPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscussionWorkerPersonnelNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DiscussionWorkerPersonnelNumber is required.")]
        public virtual string DiscussionWorkerPersonnelNumber
        {
            get
            {
                return this._DiscussionWorkerPersonnelNumber;
            }
            set
            {
                this.OnDiscussionWorkerPersonnelNumberChanging(value);
                this._DiscussionWorkerPersonnelNumber = value;
                this.OnDiscussionWorkerPersonnelNumberChanged();
                this.OnPropertyChanged("DiscussionWorkerPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DiscussionWorkerPersonnelNumber;
        partial void OnDiscussionWorkerPersonnelNumberChanging(string value);
        partial void OnDiscussionWorkerPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property DiscussionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscussionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DiscussionId is required.")]
        public virtual string DiscussionId
        {
            get
            {
                return this._DiscussionId;
            }
            set
            {
                this.OnDiscussionIdChanging(value);
                this._DiscussionId = value;
                this.OnDiscussionIdChanged();
                this.OnPropertyChanged("DiscussionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DiscussionId;
        partial void OnDiscussionIdChanging(string value);
        partial void OnDiscussionIdChanged();
        /// <summary>
        /// There are no comments for Property TopicNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TopicNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TopicNumber is required.")]
        public virtual int TopicNumber
        {
            get
            {
                return this._TopicNumber;
            }
            set
            {
                this.OnTopicNumberChanging(value);
                this._TopicNumber = value;
                this.OnTopicNumberChanged();
                this.OnPropertyChanged("TopicNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _TopicNumber;
        partial void OnTopicNumberChanging(int value);
        partial void OnTopicNumberChanged();
        /// <summary>
        /// There are no comments for Property CommentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CommentId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CommentId is required.")]
        public virtual int CommentId
        {
            get
            {
                return this._CommentId;
            }
            set
            {
                this.OnCommentIdChanging(value);
                this._CommentId = value;
                this.OnCommentIdChanged();
                this.OnPropertyChanged("CommentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _CommentId;
        partial void OnCommentIdChanging(int value);
        partial void OnCommentIdChanged();
        /// <summary>
        /// There are no comments for Property CommenterPartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CommenterPartyNumber")]
        public virtual string CommenterPartyNumber
        {
            get
            {
                return this._CommenterPartyNumber;
            }
            set
            {
                this.OnCommenterPartyNumberChanging(value);
                this._CommenterPartyNumber = value;
                this.OnCommenterPartyNumberChanged();
                this.OnPropertyChanged("CommenterPartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CommenterPartyNumber;
        partial void OnCommenterPartyNumberChanging(string value);
        partial void OnCommenterPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property CommentDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CommentDateTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CommentDateTime is required.")]
        public virtual global::System.DateTimeOffset CommentDateTime
        {
            get
            {
                return this._CommentDateTime;
            }
            set
            {
                this.OnCommentDateTimeChanging(value);
                this._CommentDateTime = value;
                this.OnCommentDateTimeChanged();
                this.OnPropertyChanged("CommentDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CommentDateTime;
        partial void OnCommentDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnCommentDateTimeChanged();
        /// <summary>
        /// There are no comments for Property Comment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Comment")]
        public virtual string Comment
        {
            get
            {
                return this._Comment;
            }
            set
            {
                this.OnCommentChanging(value);
                this._Comment = value;
                this.OnCommentChanged();
                this.OnPropertyChanged("Comment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Comment;
        partial void OnCommentChanging(string value);
        partial void OnCommentChanged();
        /// <summary>
        /// There are no comments for Property CreatedByUser in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreatedByUser")]
        public virtual string CreatedByUser
        {
            get
            {
                return this._CreatedByUser;
            }
            set
            {
                this.OnCreatedByUserChanging(value);
                this._CreatedByUser = value;
                this.OnCreatedByUserChanged();
                this.OnPropertyChanged("CreatedByUser");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CreatedByUser;
        partial void OnCreatedByUserChanging(string value);
        partial void OnCreatedByUserChanged();
        /// <summary>
        /// There are no comments for Property Discussion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Discussion")]
        public virtual global::Microsoft.Dynamics.DataEntities.Discussion Discussion
        {
            get
            {
                return this._Discussion;
            }
            set
            {
                this.OnDiscussionChanging(value);
                this._Discussion = value;
                this.OnDiscussionChanged();
                this.OnPropertyChanged("Discussion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Discussion _Discussion;
        partial void OnDiscussionChanging(global::Microsoft.Dynamics.DataEntities.Discussion value);
        partial void OnDiscussionChanged();
        /// <summary>
        /// There are no comments for Property Commenter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Commenter")]
        public virtual global::Microsoft.Dynamics.DataEntities.Person Commenter
        {
            get
            {
                return this._Commenter;
            }
            set
            {
                this.OnCommenterChanging(value);
                this._Commenter = value;
                this.OnCommenterChanged();
                this.OnPropertyChanged("Commenter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Person _Commenter;
        partial void OnCommenterChanging(global::Microsoft.Dynamics.DataEntities.Person value);
        partial void OnCommenterChanged();
        /// <summary>
        /// There are no comments for Property Topic in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Topic")]
        public virtual global::Microsoft.Dynamics.DataEntities.DiscussionTopic Topic
        {
            get
            {
                return this._Topic;
            }
            set
            {
                this.OnTopicChanging(value);
                this._Topic = value;
                this.OnTopicChanged();
                this.OnPropertyChanged("Topic");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DiscussionTopic _Topic;
        partial void OnTopicChanging(global::Microsoft.Dynamics.DataEntities.DiscussionTopic value);
        partial void OnTopicChanged();
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
