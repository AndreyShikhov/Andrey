// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class WarhammerOnlineEditorTarget : TargetRules
{
	public WarhammerOnlineEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "WarhammerOnline" } );
	}
}
