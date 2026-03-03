using System;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.LowLevel;

[Serializable]
public abstract class OpenTypeLayoutLookup
{
	public virtual void UpdateRecords(int lookupIndex, uint glyphIndex)
	{
	}

	public virtual void UpdateRecords(int lookupIndex, uint glyphIndex, float emScale)
	{
	}

	public virtual void UpdateRecords(int lookupIndex, List<uint> glyphIndexes)
	{
	}

	public virtual void UpdateRecords(int lookupIndex, List<uint> glyphIndexes, float emScale)
	{
	}
}
