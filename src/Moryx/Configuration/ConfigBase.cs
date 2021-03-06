// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System.ComponentModel;
using System.Runtime.Serialization;

namespace Moryx.Configuration
{
    /// <summary>
    /// Base implementation of IConfig to reduce redundant code
    /// </summary>
    [DataContract]
    public class ConfigBase : UpdatableEntry, IConfig, IPersistentConfig
    {
        /// <inheritdoc />
        bool IPersistentConfig.PersistDefaultConfig => PersistDefaultConfig;

        /// <see cref="IPersistentConfig"/>
        protected virtual bool PersistDefaultConfig => true;

        /// <summary>
        /// Current state of the config object
        /// </summary>
        [DataMember]
        public ConfigState ConfigState { get; set; }

        /// <summary>
        /// Exception message if load failed
        /// </summary>
        [ReadOnly(true)]
        public string LoadError { get; set; }

        /// <summary>
        /// Method called if no file was found and the config was generated
        /// </summary>
        protected internal virtual void Initialize()
        {
        }
    }
}
