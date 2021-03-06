﻿using System.Reflection;
using Abp.Modules;
using Abp.Zero.Configuration;

namespace Abp.Zero
{
    /// <summary>
    /// ABP zero core module.
    /// </summary>
    public class AbpZeroCoreModule : AbpModule
    {
        /// <summary>
        /// Current version of the zero module.
        /// </summary>
        public const string CurrentVersion = "0.5.8.0";

        public override void PreInitialize()
        {
            IocManager.Register<ZeroConfig>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
