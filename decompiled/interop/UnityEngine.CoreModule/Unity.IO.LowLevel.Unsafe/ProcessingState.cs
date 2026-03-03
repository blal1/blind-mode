namespace Unity.IO.LowLevel.Unsafe;

public enum ProcessingState
{
	Unknown,
	InQueue,
	Reading,
	Completed,
	Failed,
	Canceled
}
