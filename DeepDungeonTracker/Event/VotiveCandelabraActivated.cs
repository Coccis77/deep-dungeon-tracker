using System;

namespace DeepDungeonTracker.Event
{
    public class VotiveCandelabraActivatedEventArgs(int itemId) : EventArgs
    {
        public int ItemId { get; } = itemId;
    }

    public static class VotiveCandelabraActivatedEvents
    {
        public static event EventHandler<VotiveCandelabraActivatedEventArgs>? Changed;

        public static void Publish(int itemId)
            => OnChanged(new VotiveCandelabraActivatedEventArgs(itemId));

        private static void OnChanged(VotiveCandelabraActivatedEventArgs e)
            => Changed?.Invoke(null, e);
    }
}