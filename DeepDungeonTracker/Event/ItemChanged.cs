using System;

namespace DeepDungeonTracker.Event
{
    public enum PomanderChangedType
    {
        PomanderObtained,
        PomanderUsed,
    }

    public enum StoneChangedType
    {
        StoneObtained,
        StoneUsed,
    }


    public class ItemChangedEventArgs<TChangeType>(TChangeType type, int itemId, uint stoneType) : EventArgs
        where TChangeType : Enum
    {
        public TChangeType Type { get; } = type;
        public int ItemId { get; } = itemId;
        
        public uint StoneType { get; } = stoneType;
    }

    public static class ItemChangedEvents<TChangeType>
        where TChangeType : Enum
    {
        public static event EventHandler<ItemChangedEventArgs<TChangeType>>? Changed;

        public static void Publish(TChangeType type, int itemId, uint stoneType = 0)
            => OnChanged(new ItemChangedEventArgs<TChangeType>(type, itemId, stoneType));

        private static void OnChanged(ItemChangedEventArgs<TChangeType> e)
            => Changed?.Invoke(null, e);
    }
}