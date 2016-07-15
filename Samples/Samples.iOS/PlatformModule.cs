﻿using System;
using Autofac;


namespace Samples.iOS
{
    public class PlatformModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterModule(new CoreModule());

            builder
                .Register(x => new SampleDbConnection(
                    new SQLitePlatformAndroid(),
                    Environment.GetFolderPath(Environment.SpecialFolder.Personal)
                ))
                .AsSelf()
                .SingleInstance();
        }
    }
}
