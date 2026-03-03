using System;

namespace Unity.Hierarchy;

[Flags]
public enum HierarchyNodeFlags : uint
{
	None = 0u,
	Expanded = 1u,
	Selected = 2u,
	Cut = 4u,
	Hidden = 8u
}
