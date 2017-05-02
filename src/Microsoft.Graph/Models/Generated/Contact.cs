// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Contact.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Contact : OutlookItem
    {
    
        /// <summary>
        /// Gets or sets parent folder id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentFolderId", Required = Newtonsoft.Json.Required.Default)]
        public string ParentFolderId { get; set; }
    
        /// <summary>
        /// Gets or sets birthday.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "birthday", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? Birthday { get; set; }
    
        /// <summary>
        /// Gets or sets file as.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileAs", Required = Newtonsoft.Json.Required.Default)]
        public string FileAs { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets given name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "givenName", Required = Newtonsoft.Json.Required.Default)]
        public string GivenName { get; set; }
    
        /// <summary>
        /// Gets or sets initials.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "initials", Required = Newtonsoft.Json.Required.Default)]
        public string Initials { get; set; }
    
        /// <summary>
        /// Gets or sets middle name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "middleName", Required = Newtonsoft.Json.Required.Default)]
        public string MiddleName { get; set; }
    
        /// <summary>
        /// Gets or sets nick name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nickName", Required = Newtonsoft.Json.Required.Default)]
        public string NickName { get; set; }
    
        /// <summary>
        /// Gets or sets surname.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "surname", Required = Newtonsoft.Json.Required.Default)]
        public string Surname { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "title", Required = Newtonsoft.Json.Required.Default)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets yomi given name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "yomiGivenName", Required = Newtonsoft.Json.Required.Default)]
        public string YomiGivenName { get; set; }
    
        /// <summary>
        /// Gets or sets yomi surname.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "yomiSurname", Required = Newtonsoft.Json.Required.Default)]
        public string YomiSurname { get; set; }
    
        /// <summary>
        /// Gets or sets yomi company name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "yomiCompanyName", Required = Newtonsoft.Json.Required.Default)]
        public string YomiCompanyName { get; set; }
    
        /// <summary>
        /// Gets or sets generation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "generation", Required = Newtonsoft.Json.Required.Default)]
        public string Generation { get; set; }
    
        /// <summary>
        /// Gets or sets email addresses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailAddresses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<EmailAddress> EmailAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets im addresses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "imAddresses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ImAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets job title.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "jobTitle", Required = Newtonsoft.Json.Required.Default)]
        public string JobTitle { get; set; }
    
        /// <summary>
        /// Gets or sets company name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "companyName", Required = Newtonsoft.Json.Required.Default)]
        public string CompanyName { get; set; }
    
        /// <summary>
        /// Gets or sets department.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "department", Required = Newtonsoft.Json.Required.Default)]
        public string Department { get; set; }
    
        /// <summary>
        /// Gets or sets office location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "officeLocation", Required = Newtonsoft.Json.Required.Default)]
        public string OfficeLocation { get; set; }
    
        /// <summary>
        /// Gets or sets profession.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "profession", Required = Newtonsoft.Json.Required.Default)]
        public string Profession { get; set; }
    
        /// <summary>
        /// Gets or sets business home page.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "businessHomePage", Required = Newtonsoft.Json.Required.Default)]
        public string BusinessHomePage { get; set; }
    
        /// <summary>
        /// Gets or sets assistant name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assistantName", Required = Newtonsoft.Json.Required.Default)]
        public string AssistantName { get; set; }
    
        /// <summary>
        /// Gets or sets manager.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "manager", Required = Newtonsoft.Json.Required.Default)]
        public string Manager { get; set; }
    
        /// <summary>
        /// Gets or sets home phones.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "homePhones", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> HomePhones { get; set; }
    
        /// <summary>
        /// Gets or sets mobile phone.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobilePhone", Required = Newtonsoft.Json.Required.Default)]
        public string MobilePhone { get; set; }
    
        /// <summary>
        /// Gets or sets business phones.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "businessPhones", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> BusinessPhones { get; set; }
    
        /// <summary>
        /// Gets or sets home address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "homeAddress", Required = Newtonsoft.Json.Required.Default)]
        public PhysicalAddress HomeAddress { get; set; }
    
        /// <summary>
        /// Gets or sets business address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "businessAddress", Required = Newtonsoft.Json.Required.Default)]
        public PhysicalAddress BusinessAddress { get; set; }
    
        /// <summary>
        /// Gets or sets other address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "otherAddress", Required = Newtonsoft.Json.Required.Default)]
        public PhysicalAddress OtherAddress { get; set; }
    
        /// <summary>
        /// Gets or sets spouse name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "spouseName", Required = Newtonsoft.Json.Required.Default)]
        public string SpouseName { get; set; }
    
        /// <summary>
        /// Gets or sets personal notes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "personalNotes", Required = Newtonsoft.Json.Required.Default)]
        public string PersonalNotes { get; set; }
    
        /// <summary>
        /// Gets or sets children.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "children", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Children { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extensions", Required = Newtonsoft.Json.Required.Default)]
        public IContactExtensionsCollectionPage Extensions { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "singleValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IContactSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "multiValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IContactMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets photo.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "photo", Required = Newtonsoft.Json.Required.Default)]
        public ProfilePhoto Photo { get; set; }
    
    }
}

