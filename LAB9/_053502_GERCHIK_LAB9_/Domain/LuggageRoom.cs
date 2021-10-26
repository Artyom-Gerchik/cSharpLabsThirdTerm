using System;

namespace Domain
{
    [Serializable]
    public class LuggageRoom
    {
        private int _luggageRoomHeight;
        private int _luggageRoomWidth;
        private int _luggageRoomDepth;

        public LuggageRoom(int luggageRoomHeight, int luggageRoomWidth, int luggageRoomDepth)
        {
            this._luggageRoomHeight = luggageRoomHeight;
            this._luggageRoomWidth = luggageRoomWidth;
            this._luggageRoomDepth = luggageRoomDepth;
        }
    }
}