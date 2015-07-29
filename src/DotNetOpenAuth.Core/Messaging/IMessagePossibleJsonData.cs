namespace DotNetOpenAuth.Messaging {
    /// <summary>
    ///  The interface that classes may implement to be optionally serialized/deserialized as JSON
    /// </summary>
    public interface IMessagePossibleJsonData : IMessage {
        /// <summary>
        /// determines that we want a JSON request
        /// </summary>
        bool JsonRequest { get; set; }
    }
}