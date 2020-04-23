// <copyright file="Prompt.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.AskHR.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// This class models the prompt.
    /// </summary>
    public class Prompt
    {
        /// <summary>
        /// Gets or sets the displayOrder.
        /// </summary>
        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the qnaId.
        /// </summary>
        [JsonProperty("qnaId")]
        public int QnAId { get; set; }

        /// <summary>
        /// Gets or sets the qna.
        /// </summary>
        [JsonProperty("qna")]
        public object Qna { get; set; }

        /// <summary>
        /// Gets or sets the displayText.
        /// </summary>
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }
    }
}