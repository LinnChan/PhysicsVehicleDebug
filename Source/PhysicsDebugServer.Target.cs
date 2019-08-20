// Copyright (c) 2016 - 2018 UISEE Corp. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

[SupportedPlatforms(UnrealPlatformClass.Server)]
public class PhysicsDebugServerTarget : TargetRules
{
    public PhysicsDebugServerTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Server;
    }
}
