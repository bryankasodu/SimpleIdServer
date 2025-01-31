﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;

namespace SimpleIdServer.Configuration;

[AttributeUsage(AttributeTargets.Property)]
public class ConfigurationRecordAttribute : Attribute
{
	public ConfigurationRecordAttribute(string displayName, string description = null, int order = 0)
	{
		DisplayName = displayName;
		Description = description;
		Order = order;
	}

	public ConfigurationRecordAttribute(string displayName, string description = null, int order = 0, bool isProtected = false, string displayCondition = null, bool isOTPValue = false) : this(displayName, description, order)
	{
		IsProtected = isProtected;
        DisplayCondition = displayCondition;
		IsOTPValue = isOTPValue;

    }

	public string DisplayName { get; set; } = null!;
	public string? Description { get; set; } = null;
	public bool IsProtected { get; set; } = false;
	public int Order { get; set; } = 0;
	public string DisplayCondition { get; set; }
	public bool IsOTPValue { get; set; } = false;

    public Dictionary<string, string>? Values { get; set; } = null;
}
