using System;

namespace UnityEngine;

[Flags]
public enum ComputeBufferType
{
	Default = 0,
	Raw = 1,
	Append = 2,
	Counter = 4,
	Constant = 8,
	Structured = 0x10,
	DrawIndirect = 0x100,
	IndirectArguments = 0x100,
	GPUMemory = 0x200
}
