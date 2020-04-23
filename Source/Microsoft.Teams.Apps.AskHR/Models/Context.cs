// <copyright file="Context.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.AskHR.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// This class models the context which will contain prompts where necessary.
    /// </summary>
    public class Context
    {
        /// <summary>
        /// Gets or sets a value indicating whether or not a prompt is in context.
        /// </summary>
        [JsonProperty("isContextOnly")]
        public bool IsContextOnly { get; set; }

        /// <summary>
        /// Gets or sets the prompts.
        /// </summary>
        [JsonProperty("prompts")]
        List<Prompt> Prompts { get; set; }
    }
}